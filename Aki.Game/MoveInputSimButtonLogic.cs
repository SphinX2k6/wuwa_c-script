using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;

// Token: 0x0200306D RID: 12397
[NullableContext(1)]
[Nullable(0)]
public class MoveInputSimButtonLogic
{
	// Token: 0x0601A6B4 RID: 108212 RVA: 0x0070B620 File Offset: 0x00709820
	public void Init(List<InputEvent> hdInputEvents)
	{
		if (this.Inited)
		{
			return;
		}
		if (hdInputEvents == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.HWR, "[MoveInputSimButtonLogic.Init] 缺少初始化参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.RefInputEvents = hdInputEvents;
		this.Inited = true;
		this.CheckAxis = (ConfigCommonParamById.GetFloatConfig("MoveInputSimButtonEvent_CheckAxis") ?? this.CheckAxis);
		this.CheckHold = (ConfigCommonParamById.GetFloatConfig("MoveInputSimButtonEvent_CheckHold") ?? this.CheckHold);
		this.CheckYaw = (ConfigCommonParamById.GetFloatConfig("MoveInputSimButtonEvent_CheckYaw") ?? this.CheckYaw);
		this.CheckYawForKeyboard = (ConfigCommonParamById.GetFloatConfig("MoveInputSimButtonEvent_CheckYawForKeyboard") ?? this.CheckYawForKeyboard);
	}

	// Token: 0x0601A6B5 RID: 108213 RVA: 0x0070B708 File Offset: 0x00709908
	public void Reset()
	{
		this.FirstFrame = true;
		this.PressTime = -1.0;
		this.Inside = true;
		this.IsBothZero = false;
	}

	// Token: 0x0601A6B6 RID: 108214 RVA: 0x0070B730 File Offset: 0x00709930
	private void EmitByAxisValue(float axisValue, float yaw, float time)
	{
		if (!this.Inited)
		{
			return;
		}
		if (this.PressTime == -1.0)
		{
			if (axisValue > this.CheckAxis && this.Inside)
			{
				if (Info.Instance.IsInKeyBoard() && this.FirstFrame)
				{
					this.FirstFrame = false;
					return;
				}
				this.Inside = false;
				this.PressTime = (double)time;
				this.PressYaw = yaw;
				this.LastYaw = yaw;
				this.YawLimit = (Info.Instance.IsInKeyBoard() ? this.CheckYawForKeyboard : this.CheckYaw);
				this.RefInputEvents.Add(new InputEvent(CSharpScript.Game.Input.EInputAction.移动输入按键事件, EInputState.Press, time, yaw));
			}
		}
		else
		{
			this.FirstFrame = true;
			if (Math.Abs(yaw - this.PressYaw) > this.YawLimit || axisValue <= this.CheckAxis)
			{
				this.PressTime = -1.0;
				this.RefInputEvents.Add(new InputEvent(CSharpScript.Game.Input.EInputAction.移动输入按键事件, EInputState.Release, time, this.LastYaw));
			}
			else if ((double)time - this.PressTime > (double)this.CheckHold)
			{
				this.LastYaw = yaw;
				this.RefInputEvents.Add(new InputEvent(CSharpScript.Game.Input.EInputAction.移动输入按键事件, EInputState.Hold, time, yaw));
			}
		}
		if (!this.Inside)
		{
			this.Inside = (axisValue <= this.CheckAxis);
		}
	}

	// Token: 0x0601A6B7 RID: 108215 RVA: 0x0070B890 File Offset: 0x00709A90
	public void EmitByAxisMap(Dictionary<EInputAxis, float> axisValues)
	{
		float num;
		axisValues.TryGetValue(EInputAxis.MoveForward, out num);
		float num2;
		axisValues.TryGetValue(EInputAxis.MoveRight, out num2);
		if (num == 0f && num2 == 0f)
		{
			if (this.IsBothZero)
			{
				return;
			}
			this.IsBothZero = true;
		}
		else
		{
			this.IsBothZero = false;
		}
		float axisValue = Math.Min((float)Math.Sqrt((double)(num * num + num2 * num2)), 1f);
		double num3 = Math.Atan2((double)num2, (double)num) * 57.295780181884766;
		this.EmitByAxisValue(axisValue, (float)num3, (float)Time.Instance.WorldTimeSeconds);
	}

	// Token: 0x0400CA6F RID: 51823
	private float CheckAxis = 0.8f;

	// Token: 0x0400CA70 RID: 51824
	private float CheckHold = 0.1f;

	// Token: 0x0400CA71 RID: 51825
	private float CheckYaw = 22.5f;

	// Token: 0x0400CA72 RID: 51826
	private float CheckYawForKeyboard = 50f;

	// Token: 0x0400CA73 RID: 51827
	private float YawLimit;

	// Token: 0x0400CA74 RID: 51828
	private float PressYaw;

	// Token: 0x0400CA75 RID: 51829
	private float LastYaw;

	// Token: 0x0400CA76 RID: 51830
	private List<InputEvent> RefInputEvents;

	// Token: 0x0400CA77 RID: 51831
	private double PressTime = -1.0;

	// Token: 0x0400CA78 RID: 51832
	private bool Inside = true;

	// Token: 0x0400CA79 RID: 51833
	private bool Inited;

	// Token: 0x0400CA7A RID: 51834
	private bool FirstFrame = true;

	// Token: 0x0400CA7B RID: 51835
	private bool IsBothZero;
}
