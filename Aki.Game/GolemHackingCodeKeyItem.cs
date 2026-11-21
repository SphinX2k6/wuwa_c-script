using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004C8 RID: 1224
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingCodeKeyItem : GridProxyAbstract<GolemHackingCodeGridInfo>
{
	// Token: 0x06003D22 RID: 15650 RVA: 0x00159AD8 File Offset: 0x00157CD8
	public GolemHackingCodeKeyItem(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06003D23 RID: 15651 RVA: 0x00159AE8 File Offset: 0x00157CE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06003D24 RID: 15652 RVA: 0x00159B74 File Offset: 0x00157D74
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (!Info.Instance.IsMobileInputModel() || Info.Instance.IsInGamepad())
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.OnPointEnterCallBack.Bind(new Action(this.OnHovered));
			}
			UUIButtonComponent button2 = base.GetButton(2);
			if (button2 == null)
			{
				return;
			}
			button2.OnPointExitCallBack.Bind(new Action(this.OnUnHovered));
			return;
		}
		else
		{
			UUIButtonComponent button3 = base.GetButton(2);
			if (button3 != null)
			{
				button3.OnPointDownCallBack.Bind(new Action(this.OnMobilePointDown));
			}
			UUIButtonComponent button4 = base.GetButton(2);
			if (button4 != null)
			{
				button4.OnPointUpCallBack.Bind(new Action(this.OnMobilePointUp));
			}
			UUIButtonComponent button5 = base.GetButton(2);
			if (button5 != null)
			{
				button5.OnPointCancelCallBack.Bind(new Action(this.OnMobilePointCancel));
			}
			UUIButtonComponent button6 = base.GetButton(2);
			if (button6 != null)
			{
				button6.OnPointEnterCallBack.Bind(new Action(this.OnMobilePointEnter));
			}
			UUIButtonComponent button7 = base.GetButton(2);
			if (button7 == null)
			{
				return;
			}
			button7.OnPointExitCallBack.Bind(new Action(this.OnMobilePointExit));
			return;
		}
	}

	// Token: 0x06003D25 RID: 15653 RVA: 0x00159CB8 File Offset: 0x00157EB8
	protected override void OnBeforeDestroy()
	{
		this.ClearDelayTimer();
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
		if (!Info.Instance.IsMobileInputModel() || Info.Instance.IsInGamepad())
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				button.OnPointEnterCallBack.Unbind();
			}
			UUIButtonComponent button2 = base.GetButton(2);
			if (button2 == null)
			{
				return;
			}
			button2.OnPointExitCallBack.Unbind();
			return;
		}
		else
		{
			UUIButtonComponent button3 = base.GetButton(2);
			if (button3 != null)
			{
				button3.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent button4 = base.GetButton(2);
			if (button4 != null)
			{
				button4.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent button5 = base.GetButton(2);
			if (button5 != null)
			{
				button5.OnPointCancelCallBack.Unbind();
			}
			UUIButtonComponent button6 = base.GetButton(2);
			if (button6 != null)
			{
				button6.OnPointEnterCallBack.Unbind();
			}
			UUIButtonComponent button7 = base.GetButton(2);
			if (button7 == null)
			{
				return;
			}
			button7.OnPointExitCallBack.Unbind();
			return;
		}
	}

	// Token: 0x06003D26 RID: 15654 RVA: 0x00159DA1 File Offset: 0x00157FA1
	private void ClearDelayTimer()
	{
		if (this.DelayTimerHandle != null)
		{
			if (this.DelayTimerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.DelayTimerHandle);
			}
			this.DelayTimerHandle = null;
		}
	}

	// Token: 0x06003D27 RID: 15655 RVA: 0x00159DD0 File Offset: 0x00157FD0
	public override void Refresh(GolemHackingCodeGridInfo data, bool isSelected, int gridIndex)
	{
		this.GridData = data;
		this.ClearDelayTimer();
		string animName = this.Proxy.IsRestart ? "Reset" : "Start";
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null && sequencePlayer.IsPlayingSequence("Reset"))
		{
			this.SequencePlayer.StopSequenceByKey("Reset", false, true);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 != null && sequencePlayer2.IsPlayingSequence("Start"))
		{
			this.SequencePlayer.StopSequenceByKey("Start", false, true);
		}
		if (data.AnimIndex > 0)
		{
			int num = (data.AnimIndex - 1) * 20;
			if (num <= 0)
			{
				LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
				if (sequencePlayer3 != null)
				{
					sequencePlayer3.PlayOrReplaySequenceByName(animName, false, null);
				}
			}
			else
			{
				this.DelayTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
					if (sequencePlayer4 != null)
					{
						sequencePlayer4.PlayOrReplaySequenceByName(animName, false, null);
					}
					this.DelayTimerHandle = null;
				}, (float)num, null, null, true, 1f);
			}
		}
		this.UpdateInfo();
	}

	// Token: 0x06003D28 RID: 15656 RVA: 0x00159ED4 File Offset: 0x001580D4
	public void UpdateInfo()
	{
		UUIText text = base.GetText(1);
		text.SetText(this.GridData.Code, true);
		if (StringUtils.IsBlank(this.GridData.Code))
		{
			return;
		}
		if (this.GridData.BarState == EGolemHackingBarState.Default)
		{
			text.SetColor(this.GridData.Correct ? GolemHackingCodeKeyItem.SuccessColor : GolemHackingCodeKeyItem.DefaultColor);
			return;
		}
		if (this.GridData.BarState == EGolemHackingBarState.Success)
		{
			text.SetColor(GolemHackingCodeKeyItem.AllClearColor);
			return;
		}
		text.SetColor(GolemHackingCodeKeyItem.FailColor);
	}

	// Token: 0x06003D29 RID: 15657 RVA: 0x00159F60 File Offset: 0x00158160
	public void OnMatrixHover(string value)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.GridData.Code == value);
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x00159F84 File Offset: 0x00158184
	public void OnMatrixUnHover()
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06003D2B RID: 15659 RVA: 0x00159F98 File Offset: 0x00158198
	private void OnHovered()
	{
		this.Proxy.OnHoveredCodeGrid(this.GridData.Code);
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x00159FB0 File Offset: 0x001581B0
	private void OnUnHovered()
	{
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x06003D2D RID: 15661 RVA: 0x00159FBD File Offset: 0x001581BD
	private void OnMobilePointDown()
	{
		this.Proxy.IsCodePressing = true;
		this.Proxy.OnHoveredCodeGrid(this.GridData.Code);
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x00159FE1 File Offset: 0x001581E1
	private void OnMobilePointUp()
	{
		this.Proxy.IsCodePressing = false;
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x00159FFA File Offset: 0x001581FA
	private void OnMobilePointCancel()
	{
		this.Proxy.IsCodePressing = false;
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x0015A013 File Offset: 0x00158213
	private void OnMobilePointEnter()
	{
		if (!this.Proxy.IsCodePressing)
		{
			return;
		}
		this.Proxy.OnHoveredCodeGrid(this.GridData.Code);
	}

	// Token: 0x06003D31 RID: 15665 RVA: 0x0015A039 File Offset: 0x00158239
	private void OnMobilePointExit()
	{
		if (!this.Proxy.IsCodePressing)
		{
			return;
		}
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x04003145 RID: 12613
	[StaticVariableRuleIgnore]
	private static readonly FColor DefaultColor = FColor.FromHex("FFFFFF");

	// Token: 0x04003146 RID: 12614
	[StaticVariableRuleIgnore]
	private static readonly FColor SuccessColor = FColor.FromHex("0BBE77");

	// Token: 0x04003147 RID: 12615
	[StaticVariableRuleIgnore]
	private static readonly FColor AllClearColor = FColor.FromHex("0A482A");

	// Token: 0x04003148 RID: 12616
	[StaticVariableRuleIgnore]
	private static readonly FColor FailColor = FColor.FromHex("6F0D0D");

	// Token: 0x04003149 RID: 12617
	protected GolemHackingGameProxy Proxy;

	// Token: 0x0400314A RID: 12618
	protected GolemHackingCodeGridInfo GridData;

	// Token: 0x0400314B RID: 12619
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400314C RID: 12620
	[Nullable(2)]
	private TimerHandle DelayTimerHandle;
}
