using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001017 RID: 4119
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingMatrixCodeButton : GridProxyAbstract<GolemHackingGridInfo>
{
	// Token: 0x060069BB RID: 27067 RVA: 0x00152748 File Offset: 0x00150948
	[NullableContext(1)]
	public GolemHackingMatrixCodeButton(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x060069BC RID: 27068 RVA: 0x00152758 File Offset: 0x00150958
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClicked));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060069BD RID: 27069 RVA: 0x001528A4 File Offset: 0x00150AA4
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		if (!Info.Instance.IsMobileInputModel() || Info.Instance.IsInGamepad())
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointEnterCallBack.Bind(new Action(this.OnHovered));
			}
			UUIButtonComponent button2 = base.GetButton(0);
			if (button2 == null)
			{
				return;
			}
			button2.OnPointExitCallBack.Bind(new Action(this.OnUnHovered));
			return;
		}
		else
		{
			UUIButtonComponent button3 = base.GetButton(0);
			if (button3 != null)
			{
				button3.OnPointDownCallBack.Bind(new Action(this.OnMobilePointDown));
			}
			UUIButtonComponent button4 = base.GetButton(0);
			if (button4 != null)
			{
				button4.OnPointUpCallBack.Bind(new Action(this.OnMobilePointUp));
			}
			UUIButtonComponent button5 = base.GetButton(0);
			if (button5 != null)
			{
				button5.OnPointCancelCallBack.Bind(new Action(this.OnMobilePointCancel));
			}
			UUIButtonComponent button6 = base.GetButton(0);
			if (button6 != null)
			{
				button6.OnPointEnterCallBack.Bind(new Action(this.OnMobilePointEnter));
			}
			UUIButtonComponent button7 = base.GetButton(0);
			if (button7 == null)
			{
				return;
			}
			button7.OnPointExitCallBack.Bind(new Action(this.OnMobilePointExit));
			return;
		}
	}

	// Token: 0x060069BE RID: 27070 RVA: 0x001529D4 File Offset: 0x00150BD4
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
		if (!Info.Instance.IsMobileInputModel() || Info.Instance.IsInGamepad())
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointEnterCallBack.Unbind();
			}
			UUIButtonComponent button2 = base.GetButton(0);
			if (button2 == null)
			{
				return;
			}
			button2.OnPointExitCallBack.Unbind();
			return;
		}
		else
		{
			UUIButtonComponent button3 = base.GetButton(0);
			if (button3 != null)
			{
				button3.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent button4 = base.GetButton(0);
			if (button4 != null)
			{
				button4.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent button5 = base.GetButton(0);
			if (button5 != null)
			{
				button5.OnPointCancelCallBack.Unbind();
			}
			UUIButtonComponent button6 = base.GetButton(0);
			if (button6 != null)
			{
				button6.OnPointEnterCallBack.Unbind();
			}
			UUIButtonComponent button7 = base.GetButton(0);
			if (button7 == null)
			{
				return;
			}
			button7.OnPointExitCallBack.Unbind();
			return;
		}
	}

	// Token: 0x060069BF RID: 27071 RVA: 0x00152AB8 File Offset: 0x00150CB8
	[NullableContext(1)]
	public override void Refresh(GolemHackingGridInfo data, bool isSelected, int gridIndex)
	{
		this.CurData = data;
		int indexDistance = this.Proxy.GetIndexDistance(data.Index);
		if (this.TimerHandle != null)
		{
			if (this.TimerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}
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
		string animName = this.Proxy.IsRestart ? "Reset" : "Start";
		if (indexDistance <= 0)
		{
			LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
			if (sequencePlayer3 != null)
			{
				sequencePlayer3.PlayOrReplaySequenceByName(animName, false, null);
			}
		}
		else
		{
			int num = indexDistance * 20;
			this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
				if (sequencePlayer4 == null)
				{
					return;
				}
				sequencePlayer4.PlayOrReplaySequenceByName(animName, false, null);
			}, (float)num, null, null, true, 1f);
		}
		this.UpdateState();
	}

	// Token: 0x060069C0 RID: 27072 RVA: 0x00152BE8 File Offset: 0x00150DE8
	public void UpdateState()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(this.CurData.IsUsed);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(!this.CurData.IsUsed);
		}
		if (this.CurData.IsUsed)
		{
			return;
		}
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		text.SetText(this.CurData.Code, true);
	}

	// Token: 0x060069C1 RID: 27073 RVA: 0x00152C5D File Offset: 0x00150E5D
	[NullableContext(1)]
	public void OnCodeHover(string value)
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(this.CurData.Code == value);
	}

	// Token: 0x060069C2 RID: 27074 RVA: 0x00152C81 File Offset: 0x00150E81
	public void OnCodeUnHover()
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x060069C3 RID: 27075 RVA: 0x00152C95 File Offset: 0x00150E95
	public void UpdateBtnActiveState()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(this.Proxy.CheckMatrixBtnSelfInteractive(this.CurData.Index));
	}

	// Token: 0x060069C4 RID: 27076 RVA: 0x00152CBE File Offset: 0x00150EBE
	public void SetHoverFakeVisibility(bool visible)
	{
		UUISprite sprite = base.GetSprite(6);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(visible && !this.CurData.IsUsed);
	}

	// Token: 0x060069C5 RID: 27077 RVA: 0x00152CE8 File Offset: 0x00150EE8
	private void OnClicked()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null || !button.GetSelfInteractive())
		{
			return;
		}
		if (!this.Proxy.CheckCanInteractive())
		{
			return;
		}
		if (this.Proxy.MatrixPressingTime != 0.0 && Time.Instance.Now - this.Proxy.MatrixPressingTime > 400.0)
		{
			return;
		}
		if (this.CurData.IsUsed)
		{
			return;
		}
		this.CurData.IsUsed = true;
		this.UpdateState();
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlayOrReplaySequenceByName("Sle", false, null);
		}
		Action<int> onClickedCallback = this.OnClickedCallback;
		if (onClickedCallback == null)
		{
			return;
		}
		onClickedCallback(this.CurData.Index);
	}

	// Token: 0x060069C6 RID: 27078 RVA: 0x00152DAC File Offset: 0x00150FAC
	private void OnHovered()
	{
		Action<int> onHoverCallback = this.OnHoverCallback;
		if (onHoverCallback == null)
		{
			return;
		}
		onHoverCallback(this.CurData.Index);
	}

	// Token: 0x060069C7 RID: 27079 RVA: 0x00152DC9 File Offset: 0x00150FC9
	private void OnUnHovered()
	{
		Action<int> onUnHoverCallback = this.OnUnHoverCallback;
		if (onUnHoverCallback == null)
		{
			return;
		}
		onUnHoverCallback(this.CurData.Index);
	}

	// Token: 0x060069C8 RID: 27080 RVA: 0x00152DE6 File Offset: 0x00150FE6
	private void OnMobilePointDown()
	{
		this.Proxy.IsMatrixPressing = true;
		this.Proxy.MatrixPressingTime = Time.Instance.Now;
		Action<int> onHoverCallback = this.OnHoverCallback;
		if (onHoverCallback == null)
		{
			return;
		}
		onHoverCallback(this.CurData.Index);
	}

	// Token: 0x060069C9 RID: 27081 RVA: 0x00152E24 File Offset: 0x00151024
	private void OnMobilePointUp()
	{
		this.Proxy.IsMatrixPressing = false;
		Action<int> onUnHoverCallback = this.OnUnHoverCallback;
		if (onUnHoverCallback == null)
		{
			return;
		}
		onUnHoverCallback(this.CurData.Index);
	}

	// Token: 0x060069CA RID: 27082 RVA: 0x00152E4D File Offset: 0x0015104D
	private void OnMobilePointCancel()
	{
		this.Proxy.IsMatrixPressing = false;
		Action<int> onUnHoverCallback = this.OnUnHoverCallback;
		if (onUnHoverCallback == null)
		{
			return;
		}
		onUnHoverCallback(this.CurData.Index);
	}

	// Token: 0x060069CB RID: 27083 RVA: 0x00152E76 File Offset: 0x00151076
	private void OnMobilePointEnter()
	{
		if (!this.Proxy.IsMatrixPressing)
		{
			return;
		}
		Action<int> onHoverCallback = this.OnHoverCallback;
		if (onHoverCallback == null)
		{
			return;
		}
		onHoverCallback(this.CurData.Index);
	}

	// Token: 0x060069CC RID: 27084 RVA: 0x00152EA1 File Offset: 0x001510A1
	private void OnMobilePointExit()
	{
		if (!this.Proxy.IsMatrixPressing)
		{
			return;
		}
		Action<int> onUnHoverCallback = this.OnUnHoverCallback;
		if (onUnHoverCallback == null)
		{
			return;
		}
		onUnHoverCallback(this.CurData.Index);
	}

	// Token: 0x060069CD RID: 27085 RVA: 0x00152ECC File Offset: 0x001510CC
	public UUIItem GetFirstUiItemWithNavListener()
	{
		UUIItem rootItem = base.GetRootItem();
		AActor owner = rootItem.GetOwner();
		if (owner == null)
		{
			return null;
		}
		UClassStackOnlyPtr classPtr = TsUiNavigationBehaviorListener.StaticClass();
		if (owner.GetComponentByClass(classPtr) != null)
		{
			return rootItem;
		}
		TArray<AActor> tarray = new TArray<AActor>();
		owner.GetAttachedActorDescendants(ref tarray, true);
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			AActor aactor = tarray.Get(i);
			if (aactor != null && aactor.IsValid() && aactor.GetComponentByClass(classPtr) != null)
			{
				UUIItem uuiitem = aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
				if (uuiitem != null)
				{
					return uuiitem;
				}
			}
		}
		return null;
	}

	// Token: 0x040030C2 RID: 12482
	[Nullable(1)]
	public GolemHackingGridInfo CurData;

	// Token: 0x040030C3 RID: 12483
	public Action<int> OnHoverCallback;

	// Token: 0x040030C4 RID: 12484
	public Action<int> OnUnHoverCallback;

	// Token: 0x040030C5 RID: 12485
	public Action<int> OnClickedCallback;

	// Token: 0x040030C6 RID: 12486
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040030C7 RID: 12487
	private TimerHandle TimerHandle;

	// Token: 0x040030C8 RID: 12488
	[Nullable(1)]
	protected GolemHackingGameProxy Proxy;

	// Token: 0x02007612 RID: 30226
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402701F RID: 159775
		Btn,
		// Token: 0x04027020 RID: 159776
		PanelHolder,
		// Token: 0x04027021 RID: 159777
		PanelBtnContent,
		// Token: 0x04027022 RID: 159778
		SpriteMatrixBg,
		// Token: 0x04027023 RID: 159779
		SpriteTipsFrame,
		// Token: 0x04027024 RID: 159780
		TxtCode,
		// Token: 0x04027025 RID: 159781
		SpriteFakeHover
	}
}
