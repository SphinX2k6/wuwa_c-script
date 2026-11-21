using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

// Token: 0x02001418 RID: 5144
[NullableContext(1)]
[Nullable(0)]
public class StrengthUnit : HudUnitBase
{
	// Token: 0x0600CC7C RID: 52348 RVA: 0x003CD7A8 File Offset: 0x003CB9A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CC7D RID: 52349 RVA: 0x003CD854 File Offset: 0x003CBA54
	protected override void OnStart()
	{
		base.OnStart();
		this.ItemList.Add(base.GetItem(0));
		this.ItemList.Add(base.GetItem(1));
		base.InitTweenAnim(2);
		base.InitTweenAnim(3);
		this.AddStrengthItem(EStrengthItemType.Default);
		IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("OverShoulderViewStrengthUnitPos");
		if (floatArrayConfig != null && floatArrayConfig.Count >= 2)
		{
			this.OverShoulderViewOffset[0] = floatArrayConfig[0];
			this.OverShoulderViewOffset[1] = floatArrayConfig[1];
		}
	}

	// Token: 0x0600CC7E RID: 52350 RVA: 0x003CD8D8 File Offset: 0x003CBAD8
	protected override void OnBeforeDestroy()
	{
		this.RoleData = null;
		this.ActorComponent = null;
		foreach (StrengthItemInfo strengthItemInfo in this.Data.InfoMap.Values)
		{
			if (strengthItemInfo.StrengthItem != null)
			{
				base.AddChild(strengthItemInfo.StrengthItem);
			}
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CC7F RID: 52351 RVA: 0x003CD958 File Offset: 0x003CBB58
	[NullableContext(2)]
	public void RefreshRoleData(BattleUiRoleData roleData)
	{
		if (this.RoleData == roleData)
		{
			return;
		}
		this.RoleData = roleData;
		if (roleData == null)
		{
			this.ActorComponent = null;
			return;
		}
		this.ActorComponent = roleData.EntityHandle.Entity.GetComponent<CharacterActorComponent>();
		foreach (StrengthItemInfo strengthItemInfo in this.Data.InfoMap.Values)
		{
			StrengthItemBase strengthItem = strengthItemInfo.StrengthItem;
			if (strengthItem != null)
			{
				strengthItem.RefreshRoleData(roleData);
			}
		}
	}

	// Token: 0x0600CC80 RID: 52352 RVA: 0x003CD9F0 File Offset: 0x003CBBF0
	public void AddStrengthItem(EStrengthItemType strengthItemType)
	{
		if (this.Data.EnableStrengthItem(strengthItemType) == null)
		{
			return;
		}
		this.RefreshStrengthItem();
	}

	// Token: 0x0600CC81 RID: 52353 RVA: 0x003CDA07 File Offset: 0x003CBC07
	public void RemoveStrengthItem(EStrengthItemType strengthItemType)
	{
		if (this.Data.DisableStrengthItem(strengthItemType) == null)
		{
			return;
		}
		this.RefreshStrengthItem();
	}

	// Token: 0x0600CC82 RID: 52354 RVA: 0x003CDA20 File Offset: 0x003CBC20
	private void RefreshStrengthItem()
	{
		StrengthItemInfo strengthItemInfo = null;
		foreach (StrengthItemInfo strengthItemInfo2 in this.Data.InfoMap.Values)
		{
			if (strengthItemInfo2.Enable)
			{
				if (strengthItemInfo == null)
				{
					strengthItemInfo = strengthItemInfo2;
				}
				else if (strengthItemInfo2.Config.Priority > strengthItemInfo.Config.Priority)
				{
					strengthItemInfo = strengthItemInfo2;
				}
			}
		}
		if (strengthItemInfo == null)
		{
			Log.Instance.Error(ELogModule.HudUnit, ELogAuthor.CFT, "人物耐力条必须存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int group = strengthItemInfo.Config.Group;
		EStrengthItemType estrengthItemType = this.StrengthItemTypeList[group - 1];
		if (estrengthItemType != strengthItemInfo.ItemType)
		{
			this.StrengthItemTypeList[group - 1] = strengthItemInfo.ItemType;
			StrengthItemInfo strengthItemInfo3;
			if (this.Data.InfoMap.TryGetValue(estrengthItemType, out strengthItemInfo3) && strengthItemInfo3.StrengthItem != null)
			{
				if (strengthItemInfo3.Config.DestroyWhenLowPriority)
				{
					strengthItemInfo3.StrengthItem.Destroy(null);
					strengthItemInfo3.StrengthItem = null;
				}
				else
				{
					strengthItemInfo3.StrengthItem.SetEnableByHighPriority(false, false);
				}
			}
			StrengthItemInfo strengthItemInfo4 = strengthItemInfo;
			if (strengthItemInfo4.StrengthItem != null)
			{
				strengthItemInfo4.StrengthItem.SetEnableByHighPriority(true, false);
			}
			else
			{
				UUIItem parentItem = this.ItemList[strengthItemInfo4.Config.Group - 1];
				StrengthItemBase strengthItemBase = (StrengthItemBase)Activator.CreateInstance(strengthItemInfo4.Config.ItemClass);
				strengthItemInfo4.StrengthItem = strengthItemBase;
				strengthItemBase.Init(parentItem, this.RoleData, new Action<bool>(this.OnItemUiVisibleChanged));
			}
		}
		this.SwapPlace(group != 1);
	}

	// Token: 0x0600CC83 RID: 52355 RVA: 0x003CDBD0 File Offset: 0x003CBDD0
	public void SwapPlace(bool value)
	{
		if (this.IsSwapPlace == value)
		{
			return;
		}
		this.IsSwapPlace = value;
		this.RefreshItemPlace();
	}

	// Token: 0x0600CC84 RID: 52356 RVA: 0x003CDBE9 File Offset: 0x003CBDE9
	private void OnItemUiVisibleChanged(bool uiVisible)
	{
		this.RefreshItemPlace();
	}

	// Token: 0x0600CC85 RID: 52357 RVA: 0x003CDBF4 File Offset: 0x003CBDF4
	private void RefreshItemPlace()
	{
		bool flag = true;
		foreach (EStrengthItemType key in this.StrengthItemTypeList)
		{
			StrengthItemInfo strengthItemInfo;
			StrengthItemBase strengthItemBase = this.Data.InfoMap.TryGetValue(key, out strengthItemInfo) ? strengthItemInfo.StrengthItem : null;
			if (strengthItemBase == null || !strengthItemBase.GetUiVisible())
			{
				flag = false;
			}
		}
		if (!flag)
		{
			int[] array = this.IsSwapPlace ? StrengthUnit.SwapIndex : StrengthUnit.NormalIndex;
			int num = 0;
			bool flag2 = true;
			foreach (int num2 in array)
			{
				UUIItem uuiitem = this.ItemList[num2];
				EStrengthItemType key2 = this.StrengthItemTypeList[num2];
				StrengthItemInfo strengthItemInfo2;
				StrengthItemBase strengthItemBase2 = this.Data.InfoMap.TryGetValue(key2, out strengthItemInfo2) ? strengthItemInfo2.StrengthItem : null;
				if (strengthItemBase2 != null && strengthItemBase2.GetUiVisible())
				{
					uuiitem.SetAnchorOffsetX(157f + 105f * (float)num);
					uuiitem.SetAlpha(flag2 ? 1f : 0.3f);
					uuiitem.SetUIItemScale(global::Vector.OneVector);
					num++;
				}
				flag2 = false;
			}
			return;
		}
		if (this.IsSwapPlace)
		{
			base.StopTweenAnim(2);
			base.PlayTweenAnim(3);
			return;
		}
		base.StopTweenAnim(3);
		base.PlayTweenAnim(2);
	}

	// Token: 0x0600CC86 RID: 52358 RVA: 0x003CDD3D File Offset: 0x003CBF3D
	public void SetFirstPersonState(bool b)
	{
		this.IsFirstPersonView = b;
	}

	// Token: 0x0600CC87 RID: 52359 RVA: 0x003CDD46 File Offset: 0x003CBF46
	public void SetOverShoulderState(bool value)
	{
		this.IsOverShoulderView = value;
	}

	// Token: 0x0600CC88 RID: 52360 RVA: 0x003CDD50 File Offset: 0x003CBF50
	public override void Tick(float delta)
	{
		this.RefreshTargetPosition(delta);
		foreach (EStrengthItemType key in this.StrengthItemTypeList)
		{
			StrengthItemInfo strengthItemInfo;
			StrengthItemBase strengthItemBase = this.Data.InfoMap.TryGetValue(key, out strengthItemInfo) ? strengthItemInfo.StrengthItem : null;
			if (strengthItemBase != null && strengthItemBase.GetUiVisible())
			{
				strengthItemBase.Tick(delta);
			}
		}
	}

	// Token: 0x0600CC89 RID: 52361 RVA: 0x003CDDB0 File Offset: 0x003CBFB0
	private void RefreshTargetPosition(float delta)
	{
		if (!base.GetActive())
		{
			return;
		}
		if (this.IsOverShoulderView)
		{
			if (!this.OffsetX.Equals(this.OverShoulderViewOffset[0]) || !this.OffsetY.Equals(this.OverShoulderViewOffset[1]))
			{
				this.OffsetX = this.OverShoulderViewOffset[0];
				this.OffsetY = this.OverShoulderViewOffset[1];
				base.SetAnchorOffset(this.OffsetX, this.OffsetY);
			}
			return;
		}
		if (this.IsFirstPersonView)
		{
			if (!this.OffsetX.Equals(600f) || this.OffsetY != 0f)
			{
				this.OffsetX = 600f;
				this.OffsetY = 0f;
				base.SetAnchorOffset(this.OffsetX, this.OffsetY);
			}
			return;
		}
		if (this.ActorComponent == null)
		{
			return;
		}
		TsBaseCharacter actor = this.ActorComponent.Actor;
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		FVectorDouble actorLocation = this.ActorComponent.ActorLocation;
		if (!HudUnitUtils.PositionUtil.ProjectWorldToScreen(actorLocation, this.ScreenPos))
		{
			return;
		}
		float num = (float)this.ScreenPos.X;
		float num2 = (float)this.ScreenPos.Y;
		if (Math.Abs(num - this.OffsetX) > 500f || Math.Abs(num2 - this.OffsetY) > 500f)
		{
			this.OffsetX = num;
			this.OffsetY = num2;
			base.SetAnchorOffset(this.OffsetX, this.OffsetY);
			return;
		}
		this.SpeedX = this.GetSpeed(delta, num, this.OffsetX, this.SpeedX);
		this.SpeedY = this.GetSpeed(delta, num2, this.OffsetY, this.SpeedY);
		float num3 = this.SpeedX * delta;
		float num4 = this.SpeedY * delta;
		if (num3 < 0.5f && num3 > -0.5f && num4 < 0.5f && num4 > -0.5f)
		{
			return;
		}
		this.OffsetX += num3;
		this.OffsetY += num4;
		base.SetAnchorOffset(this.OffsetX, this.OffsetY);
	}

	// Token: 0x0600CC8A RID: 52362 RVA: 0x003CDFBC File Offset: 0x003CC1BC
	private float GetSpeed(float delta, float target, float cur, float lastSpeed)
	{
		float num = target - cur;
		bool flag = false;
		if (num < 0f)
		{
			num = -num;
			flag = true;
		}
		if (num < 1f)
		{
			return 0f;
		}
		float num2 = (delta >= 200f) ? (num / delta) : (num / 200f);
		if (flag)
		{
			num2 = -num2;
		}
		return (float)MathUtils.Instance.Lerp((double)lastSpeed, (double)num2, 0.5);
	}

	// Token: 0x0600CC8C RID: 52364 RVA: 0x003CE06C File Offset: 0x003CC26C
	// Note: this type is marked as 'beforefieldinit'.
	static StrengthUnit()
	{
		int[] array = new int[2];
		array[0] = 1;
		StrengthUnit.SwapIndex = array;
	}

	// Token: 0x0400743D RID: 29757
	private const float MaxDeltaTime = 200f;

	// Token: 0x0400743E RID: 29758
	private const float MinDeltaOffset = 0.5f;

	// Token: 0x0400743F RID: 29759
	private const float MaxPosOffset = 500f;

	// Token: 0x04007440 RID: 29760
	private const float ItemOffsetXBase = 157f;

	// Token: 0x04007441 RID: 29761
	private const float ItemOffsetXInterval = 105f;

	// Token: 0x04007442 RID: 29762
	[StaticVariableRuleIgnore]
	private static readonly int[] NormalIndex = new int[]
	{
		0,
		1
	};

	// Token: 0x04007443 RID: 29763
	[StaticVariableRuleIgnore]
	private static readonly int[] SwapIndex;

	// Token: 0x04007444 RID: 29764
	private const float FirstPersonOffsetX = 600f;

	// Token: 0x04007445 RID: 29765
	public StrengthUnitData Data = new StrengthUnitData();

	// Token: 0x04007446 RID: 29766
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x04007447 RID: 29767
	[Nullable(2)]
	private BattleUiRoleData RoleData;

	// Token: 0x04007448 RID: 29768
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x04007449 RID: 29769
	private float OffsetX;

	// Token: 0x0400744A RID: 29770
	private float OffsetY;

	// Token: 0x0400744B RID: 29771
	private float SpeedX;

	// Token: 0x0400744C RID: 29772
	private float SpeedY;

	// Token: 0x0400744D RID: 29773
	private readonly List<UUIItem> ItemList = new List<UUIItem>();

	// Token: 0x0400744E RID: 29774
	private bool IsSwapPlace;

	// Token: 0x0400744F RID: 29775
	private readonly EStrengthItemType[] StrengthItemTypeList = new EStrengthItemType[2];

	// Token: 0x04007450 RID: 29776
	private bool IsFirstPersonView;

	// Token: 0x04007451 RID: 29777
	private bool IsOverShoulderView;

	// Token: 0x04007452 RID: 29778
	private readonly float[] OverShoulderViewOffset = new float[2];

	// Token: 0x020076DB RID: 30427
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040269B0 RID: 158128
		Item1,
		// Token: 0x040269B1 RID: 158129
		Item2,
		// Token: 0x040269B2 RID: 158130
		AniSwitchIn,
		// Token: 0x040269B3 RID: 158131
		AniSwitchOut
	}
}
