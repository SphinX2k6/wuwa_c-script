using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

// Token: 0x02001F56 RID: 8022
[NullableContext(1)]
[Nullable(0)]
public class StrengthUnit : HudUnitBase
{
	// Token: 0x0600F85D RID: 63581 RVA: 0x003C1CBC File Offset: 0x003BFEBC
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

	// Token: 0x0600F85E RID: 63582 RVA: 0x003C1D68 File Offset: 0x003BFF68
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

	// Token: 0x0600F85F RID: 63583 RVA: 0x003C1DEC File Offset: 0x003BFFEC
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

	// Token: 0x0600F860 RID: 63584 RVA: 0x003C1E6C File Offset: 0x003C006C
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

	// Token: 0x0600F861 RID: 63585 RVA: 0x003C1F04 File Offset: 0x003C0104
	public void AddStrengthItem(EStrengthItemType strengthItemType)
	{
		if (this.Data.EnableStrengthItem(strengthItemType) == null)
		{
			return;
		}
		this.RefreshStrengthItem();
	}

	// Token: 0x0600F862 RID: 63586 RVA: 0x003C1F1B File Offset: 0x003C011B
	public void RemoveStrengthItem(EStrengthItemType strengthItemType)
	{
		if (this.Data.DisableStrengthItem(strengthItemType) == null)
		{
			return;
		}
		this.RefreshStrengthItem();
	}

	// Token: 0x0600F863 RID: 63587 RVA: 0x003C1F34 File Offset: 0x003C0134
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

	// Token: 0x0600F864 RID: 63588 RVA: 0x003C20E4 File Offset: 0x003C02E4
	public void SwapPlace(bool value)
	{
		if (this.IsSwapPlace == value)
		{
			return;
		}
		this.IsSwapPlace = value;
		this.RefreshItemPlace();
	}

	// Token: 0x0600F865 RID: 63589 RVA: 0x003C20FD File Offset: 0x003C02FD
	private void OnItemUiVisibleChanged(bool uiVisible)
	{
		this.RefreshItemPlace();
	}

	// Token: 0x0600F866 RID: 63590 RVA: 0x003C2108 File Offset: 0x003C0308
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

	// Token: 0x0600F867 RID: 63591 RVA: 0x003C2251 File Offset: 0x003C0451
	public void SetFirstPersonState(bool b)
	{
		this.IsFirstPersonView = b;
	}

	// Token: 0x0600F868 RID: 63592 RVA: 0x003C225A File Offset: 0x003C045A
	public void SetOverShoulderState(bool value)
	{
		this.IsOverShoulderView = value;
	}

	// Token: 0x0600F869 RID: 63593 RVA: 0x003C2264 File Offset: 0x003C0464
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

	// Token: 0x0600F86A RID: 63594 RVA: 0x003C22C4 File Offset: 0x003C04C4
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

	// Token: 0x0600F86B RID: 63595 RVA: 0x003C24D0 File Offset: 0x003C06D0
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

	// Token: 0x0600F86D RID: 63597 RVA: 0x003C2580 File Offset: 0x003C0780
	// Note: this type is marked as 'beforefieldinit'.
	static StrengthUnit()
	{
		int[] array = new int[2];
		array[0] = 1;
		StrengthUnit.SwapIndex = array;
	}

	// Token: 0x0400735C RID: 29532
	private const float MaxDeltaTime = 200f;

	// Token: 0x0400735D RID: 29533
	private const float MinDeltaOffset = 0.5f;

	// Token: 0x0400735E RID: 29534
	private const float MaxPosOffset = 500f;

	// Token: 0x0400735F RID: 29535
	private const float ItemOffsetXBase = 157f;

	// Token: 0x04007360 RID: 29536
	private const float ItemOffsetXInterval = 105f;

	// Token: 0x04007361 RID: 29537
	[StaticVariableRuleIgnore]
	private static readonly int[] NormalIndex = new int[]
	{
		0,
		1
	};

	// Token: 0x04007362 RID: 29538
	[StaticVariableRuleIgnore]
	private static readonly int[] SwapIndex;

	// Token: 0x04007363 RID: 29539
	private const float FirstPersonOffsetX = 600f;

	// Token: 0x04007364 RID: 29540
	public StrengthUnitData Data = new StrengthUnitData();

	// Token: 0x04007365 RID: 29541
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x04007366 RID: 29542
	[Nullable(2)]
	private BattleUiRoleData RoleData;

	// Token: 0x04007367 RID: 29543
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x04007368 RID: 29544
	private float OffsetX;

	// Token: 0x04007369 RID: 29545
	private float OffsetY;

	// Token: 0x0400736A RID: 29546
	private float SpeedX;

	// Token: 0x0400736B RID: 29547
	private float SpeedY;

	// Token: 0x0400736C RID: 29548
	private readonly List<UUIItem> ItemList = new List<UUIItem>();

	// Token: 0x0400736D RID: 29549
	private bool IsSwapPlace;

	// Token: 0x0400736E RID: 29550
	private readonly EStrengthItemType[] StrengthItemTypeList = new EStrengthItemType[2];

	// Token: 0x0400736F RID: 29551
	private bool IsFirstPersonView;

	// Token: 0x04007370 RID: 29552
	private bool IsOverShoulderView;

	// Token: 0x04007371 RID: 29553
	private readonly float[] OverShoulderViewOffset = new float[2];

	// Token: 0x02008556 RID: 34134
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B68C RID: 177804
		Item1,
		// Token: 0x0402B68D RID: 177805
		Item2,
		// Token: 0x0402B68E RID: 177806
		AniSwitchIn,
		// Token: 0x0402B68F RID: 177807
		AniSwitchOut
	}
}
