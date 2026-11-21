using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;

// Token: 0x020025C4 RID: 9668
[NullableContext(1)]
[Nullable(0)]
public class MoveInputSimButtonLogic
{
	// Token: 0x0601806F RID: 98415 RVA: 0x00731E18 File Offset: 0x00730018
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

	// Token: 0x06018070 RID: 98416 RVA: 0x00731F00 File Offset: 0x00730100
	public void Reset()
	{
		this.FirstFrame = true;
		this.PressTime = -1.0;
		this.Inside = true;
		this.IsBothZero = false;
	}

	// Token: 0x06018071 RID: 98417 RVA: 0x00731F28 File Offset: 0x00730128
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

	// Token: 0x06018072 RID: 98418 RVA: 0x00732088 File Offset: 0x00730288
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

	// Token: 0x0400CE49 RID: 52809
	private float CheckAxis = 0.8f;

	// Token: 0x0400CE4A RID: 52810
	private float CheckHold = 0.1f;

	// Token: 0x0400CE4B RID: 52811
	private float CheckYaw = 22.5f;

	// Token: 0x0400CE4C RID: 52812
	private float CheckYawForKeyboard = 50f;

	// Token: 0x0400CE4D RID: 52813
	private float YawLimit;

	// Token: 0x0400CE4E RID: 52814
	private float PressYaw;

	// Token: 0x0400CE4F RID: 52815
	private float LastYaw;

	// Token: 0x0400CE50 RID: 52816
	private List<InputEvent> RefInputEvents;

	// Token: 0x0400CE51 RID: 52817
	private double PressTime = -1.0;

	// Token: 0x0400CE52 RID: 52818
	private bool Inside = true;

	// Token: 0x0400CE53 RID: 52819
	private bool Inited;

	// Token: 0x0400CE54 RID: 52820
	private bool FirstFrame = true;

	// Token: 0x0400CE55 RID: 52821
	private bool IsBothZero;
}
