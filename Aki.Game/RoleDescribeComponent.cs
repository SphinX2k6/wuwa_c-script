using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200114A RID: 4426
[NullableContext(2)]
[Nullable(0)]
public class RoleDescribeComponent : UiPanelBase
{
	// Token: 0x17001212 RID: 4626
	// (get) Token: 0x0600B09B RID: 45211 RVA: 0x003425D2 File Offset: 0x003407D2
	// (set) Token: 0x0600B09C RID: 45212 RVA: 0x003425DA File Offset: 0x003407DA
	public Action OnClickLookCallback { get; set; }

	// Token: 0x0600B09D RID: 45213 RVA: 0x003425E4 File Offset: 0x003407E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnLookClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B09E RID: 45214 RVA: 0x00342750 File Offset: 0x00340950
	private void OnBtnLookClick()
	{
		Action onClickLookCallback = this.OnClickLookCallback;
		if (onClickLookCallback == null)
		{
			return;
		}
		onClickLookCallback();
	}

	// Token: 0x0600B09F RID: 45215 RVA: 0x00342764 File Offset: 0x00340964
	public void SetLookBtnActive(bool active)
	{
		UUIButtonComponent button = base.GetButton(6);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(active);
	}

	// Token: 0x0600B0A0 RID: 45216 RVA: 0x00342798 File Offset: 0x00340998
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(2));
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x0600B0A1 RID: 45217 RVA: 0x00342808 File Offset: 0x00340A08
	public void Update(int gachaTextureInfoId, bool isUp = false)
	{
		this.GachaTextureInfoId = gachaTextureInfoId;
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(this.GachaTextureInfoId);
		if (roleInfoById == null)
		{
			return;
		}
		base.GetText(0).ShowTextNew(roleInfoById.Value.Name);
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(roleInfoById.Value.ElementId);
		UUITexture texture = base.GetTexture(3);
		UUISprite sprite = base.GetSprite(4);
		base.SetTextureByPath(elementConfig.Value.Icon, texture, null, null);
		this.SetSpriteByPath(elementConfig.Value.GachaElementBgSpritePath, sprite, false, null, null);
		this.UpdateQuality(roleInfoById.Value.QualityId);
		base.GetItem(1).SetUIActive(isUp);
	}

	// Token: 0x0600B0A2 RID: 45218 RVA: 0x003428E6 File Offset: 0x00340AE6
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x0600B0A3 RID: 45219 RVA: 0x003428F4 File Offset: 0x00340AF4
	public void OpenRolePreview()
	{
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(this.GachaTextureInfoId);
		UiManager.Instance.OpenView(EUiViewName.RoleHandBookRootView, gachaTextureInfo.Value.TrialId, null);
	}

	// Token: 0x0600B0A4 RID: 45220 RVA: 0x00342936 File Offset: 0x00340B36
	public UUIItem GetJumpBtnRoot()
	{
		return base.GetItem(7);
	}

	// Token: 0x040065F4 RID: 26100
	private int GachaTextureInfoId;

	// Token: 0x040065F5 RID: 26101
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040065F6 RID: 26102
	private SimpleGenericLayout StarLayout;

	// Token: 0x020073EC RID: 29676
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04025BD3 RID: 154579
		public const int RoleNameText = 0;

		// Token: 0x04025BD4 RID: 154580
		public const int UpItem = 1;

		// Token: 0x04025BD5 RID: 154581
		public const int StarLayout = 2;

		// Token: 0x04025BD6 RID: 154582
		public const int AttrTexture = 3;

		// Token: 0x04025BD7 RID: 154583
		public const int AttrBgSprite = 4;

		// Token: 0x04025BD8 RID: 154584
		public const int AttrSprite = 5;

		// Token: 0x04025BD9 RID: 154585
		public const int BtnLook = 6;

		// Token: 0x04025BDA RID: 154586
		public const int JumpBtnRoot = 7;
	}
}
