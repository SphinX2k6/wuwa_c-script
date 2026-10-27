using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001014 RID: 4116
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingCodeKeyItem : GridProxyAbstract<GolemHackingCodeGridInfo>
{
	// Token: 0x0600698D RID: 27021 RVA: 0x001511B0 File Offset: 0x0014F3B0
	public GolemHackingCodeKeyItem(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x0600698E RID: 27022 RVA: 0x001511C0 File Offset: 0x0014F3C0
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

	// Token: 0x0600698F RID: 27023 RVA: 0x0015124C File Offset: 0x0014F44C
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

	// Token: 0x06006990 RID: 27024 RVA: 0x00151390 File Offset: 0x0014F590
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

	// Token: 0x06006991 RID: 27025 RVA: 0x00151479 File Offset: 0x0014F679
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

	// Token: 0x06006992 RID: 27026 RVA: 0x001514A8 File Offset: 0x0014F6A8
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

	// Token: 0x06006993 RID: 27027 RVA: 0x001515AC File Offset: 0x0014F7AC
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

	// Token: 0x06006994 RID: 27028 RVA: 0x00151638 File Offset: 0x0014F838
	public void OnMatrixHover(string value)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.GridData.Code == value);
	}

	// Token: 0x06006995 RID: 27029 RVA: 0x0015165C File Offset: 0x0014F85C
	public void OnMatrixUnHover()
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06006996 RID: 27030 RVA: 0x00151670 File Offset: 0x0014F870
	private void OnHovered()
	{
		this.Proxy.OnHoveredCodeGrid(this.GridData.Code);
	}

	// Token: 0x06006997 RID: 27031 RVA: 0x00151688 File Offset: 0x0014F888
	private void OnUnHovered()
	{
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x06006998 RID: 27032 RVA: 0x00151695 File Offset: 0x0014F895
	private void OnMobilePointDown()
	{
		this.Proxy.IsCodePressing = true;
		this.Proxy.OnHoveredCodeGrid(this.GridData.Code);
	}

	// Token: 0x06006999 RID: 27033 RVA: 0x001516B9 File Offset: 0x0014F8B9
	private void OnMobilePointUp()
	{
		this.Proxy.IsCodePressing = false;
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x0600699A RID: 27034 RVA: 0x001516D2 File Offset: 0x0014F8D2
	private void OnMobilePointCancel()
	{
		this.Proxy.IsCodePressing = false;
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x0600699B RID: 27035 RVA: 0x001516EB File Offset: 0x0014F8EB
	private void OnMobilePointEnter()
	{
		if (!this.Proxy.IsCodePressing)
		{
			return;
		}
		this.Proxy.OnHoveredCodeGrid(this.GridData.Code);
	}

	// Token: 0x0600699C RID: 27036 RVA: 0x00151711 File Offset: 0x0014F911
	private void OnMobilePointExit()
	{
		if (!this.Proxy.IsCodePressing)
		{
			return;
		}
		this.Proxy.OnUnHoveredCodeGrid();
	}

	// Token: 0x040030AC RID: 12460
	[StaticVariableRuleIgnore]
	private static readonly FColor DefaultColor = FColor.FromHex("FFFFFF");

	// Token: 0x040030AD RID: 12461
	[StaticVariableRuleIgnore]
	private static readonly FColor SuccessColor = FColor.FromHex("0BBE77");

	// Token: 0x040030AE RID: 12462
	[StaticVariableRuleIgnore]
	private static readonly FColor AllClearColor = FColor.FromHex("0A482A");

	// Token: 0x040030AF RID: 12463
	[StaticVariableRuleIgnore]
	private static readonly FColor FailColor = FColor.FromHex("6F0D0D");

	// Token: 0x040030B0 RID: 12464
	protected GolemHackingGameProxy Proxy;

	// Token: 0x040030B1 RID: 12465
	protected GolemHackingCodeGridInfo GridData;

	// Token: 0x040030B2 RID: 12466
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040030B3 RID: 12467
	[Nullable(2)]
	private TimerHandle DelayTimerHandle;
}
