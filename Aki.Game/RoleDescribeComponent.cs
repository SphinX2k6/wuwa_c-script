using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C8B RID: 7307
[NullableContext(2)]
[Nullable(0)]
public class RoleDescribeComponent : UiPanelBase
{
	// Token: 0x170011EC RID: 4588
	// (get) Token: 0x0600DC85 RID: 56453 RVA: 0x003370AE File Offset: 0x003352AE
	// (set) Token: 0x0600DC86 RID: 56454 RVA: 0x003370B6 File Offset: 0x003352B6
	public Action OnClickLookCallback { get; set; }

	// Token: 0x0600DC87 RID: 56455 RVA: 0x003370C0 File Offset: 0x003352C0
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

	// Token: 0x0600DC88 RID: 56456 RVA: 0x0033722C File Offset: 0x0033542C
	private void OnBtnLookClick()
	{
		Action onClickLookCallback = this.OnClickLookCallback;
		if (onClickLookCallback == null)
		{
			return;
		}
		onClickLookCallback();
	}

	// Token: 0x0600DC89 RID: 56457 RVA: 0x00337240 File Offset: 0x00335440
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

	// Token: 0x0600DC8A RID: 56458 RVA: 0x00337274 File Offset: 0x00335474
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

	// Token: 0x0600DC8B RID: 56459 RVA: 0x003372E4 File Offset: 0x003354E4
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

	// Token: 0x0600DC8C RID: 56460 RVA: 0x003373C2 File Offset: 0x003355C2
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x0600DC8D RID: 56461 RVA: 0x003373D0 File Offset: 0x003355D0
	public void OpenRolePreview()
	{
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(this.GachaTextureInfoId);
		UiManager.Instance.OpenView(EUiViewName.RoleHandBookRootView, gachaTextureInfo.Value.TrialId, null);
	}

	// Token: 0x0600DC8E RID: 56462 RVA: 0x00337412 File Offset: 0x00335612
	public UUIItem GetJumpBtnRoot()
	{
		return base.GetItem(7);
	}

	// Token: 0x04006522 RID: 25890
	private int GachaTextureInfoId;

	// Token: 0x04006523 RID: 25891
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006524 RID: 25892
	private SimpleGenericLayout StarLayout;

	// Token: 0x02008264 RID: 33380
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402A8B2 RID: 174258
		public const int RoleNameText = 0;

		// Token: 0x0402A8B3 RID: 174259
		public const int UpItem = 1;

		// Token: 0x0402A8B4 RID: 174260
		public const int StarLayout = 2;

		// Token: 0x0402A8B5 RID: 174261
		public const int AttrTexture = 3;

		// Token: 0x0402A8B6 RID: 174262
		public const int AttrBgSprite = 4;

		// Token: 0x0402A8B7 RID: 174263
		public const int AttrSprite = 5;

		// Token: 0x0402A8B8 RID: 174264
		public const int BtnLook = 6;

		// Token: 0x0402A8B9 RID: 174265
		public const int JumpBtnRoot = 7;
	}
}
