using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004CB RID: 1227
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GolemHackingMatrixCodeButton : GridProxyAbstract<GolemHackingGridInfo>
{
	// Token: 0x06003D50 RID: 15696 RVA: 0x0015B070 File Offset: 0x00159270
	[NullableContext(1)]
	public GolemHackingMatrixCodeButton(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06003D51 RID: 15697 RVA: 0x0015B080 File Offset: 0x00159280
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

	// Token: 0x06003D52 RID: 15698 RVA: 0x0015B1CC File Offset: 0x001593CC
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

	// Token: 0x06003D53 RID: 15699 RVA: 0x0015B2FC File Offset: 0x001594FC
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

	// Token: 0x06003D54 RID: 15700 RVA: 0x0015B3E0 File Offset: 0x001595E0
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

	// Token: 0x06003D55 RID: 15701 RVA: 0x0015B510 File Offset: 0x00159710
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

	// Token: 0x06003D56 RID: 15702 RVA: 0x0015B585 File Offset: 0x00159785
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

	// Token: 0x06003D57 RID: 15703 RVA: 0x0015B5A9 File Offset: 0x001597A9
	public void OnCodeUnHover()
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x06003D58 RID: 15704 RVA: 0x0015B5BD File Offset: 0x001597BD
	public void UpdateBtnActiveState()
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(this.Proxy.CheckMatrixBtnSelfInteractive(this.CurData.Index));
	}

	// Token: 0x06003D59 RID: 15705 RVA: 0x0015B5E6 File Offset: 0x001597E6
	public void SetHoverFakeVisibility(bool visible)
	{
		UUISprite sprite = base.GetSprite(6);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(visible && !this.CurData.IsUsed);
	}

	// Token: 0x06003D5A RID: 15706 RVA: 0x0015B610 File Offset: 0x00159810
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

	// Token: 0x06003D5B RID: 15707 RVA: 0x0015B6D4 File Offset: 0x001598D4
	private void OnHovered()
	{
		Action<int> onHoverCallback = this.OnHoverCallback;
		if (onHoverCallback == null)
		{
			return;
		}
		onHoverCallback(this.CurData.Index);
	}

	// Token: 0x06003D5C RID: 15708 RVA: 0x0015B6F1 File Offset: 0x001598F1
	private void OnUnHovered()
	{
		Action<int> onUnHoverCallback = this.OnUnHoverCallback;
		if (onUnHoverCallback == null)
		{
			return;
		}
		onUnHoverCallback(this.CurData.Index);
	}

	// Token: 0x06003D5D RID: 15709 RVA: 0x0015B70E File Offset: 0x0015990E
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

	// Token: 0x06003D5E RID: 15710 RVA: 0x0015B74C File Offset: 0x0015994C
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

	// Token: 0x06003D5F RID: 15711 RVA: 0x0015B775 File Offset: 0x00159975
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

	// Token: 0x06003D60 RID: 15712 RVA: 0x0015B79E File Offset: 0x0015999E
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

	// Token: 0x06003D61 RID: 15713 RVA: 0x0015B7C9 File Offset: 0x001599C9
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

	// Token: 0x06003D62 RID: 15714 RVA: 0x0015B7F4 File Offset: 0x001599F4
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

	// Token: 0x0400315B RID: 12635
	[Nullable(1)]
	public GolemHackingGridInfo CurData;

	// Token: 0x0400315C RID: 12636
	public Action<int> OnHoverCallback;

	// Token: 0x0400315D RID: 12637
	public Action<int> OnUnHoverCallback;

	// Token: 0x0400315E RID: 12638
	public Action<int> OnClickedCallback;

	// Token: 0x0400315F RID: 12639
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003160 RID: 12640
	private TimerHandle TimerHandle;

	// Token: 0x04003161 RID: 12641
	[Nullable(1)]
	protected GolemHackingGameProxy Proxy;

	// Token: 0x020067A6 RID: 26534
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402236A RID: 140138
		Btn,
		// Token: 0x0402236B RID: 140139
		PanelHolder,
		// Token: 0x0402236C RID: 140140
		PanelBtnContent,
		// Token: 0x0402236D RID: 140141
		SpriteMatrixBg,
		// Token: 0x0402236E RID: 140142
		SpriteTipsFrame,
		// Token: 0x0402236F RID: 140143
		TxtCode,
		// Token: 0x04022370 RID: 140144
		SpriteFakeHover
	}
}
