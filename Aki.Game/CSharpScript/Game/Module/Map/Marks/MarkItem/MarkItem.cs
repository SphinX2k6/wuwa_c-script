using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.ViewComponent.SteamingLoad;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054EE RID: 21742
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MarkItem : IWorldMapStreamingObject
	{
		// Token: 0x17008545 RID: 34117
		// (get) Token: 0x06037825 RID: 227365 RVA: 0x00D2E7EE File Offset: 0x00D2C9EE
		// (set) Token: 0x06037826 RID: 227366 RVA: 0x00D2E7F6 File Offset: 0x00D2C9F6
		public bool IsVisible { get; set; }

		// Token: 0x17008546 RID: 34118
		// (get) Token: 0x06037827 RID: 227367 RVA: 0x00D2E800 File Offset: 0x00D2CA00
		// (set) Token: 0x06037828 RID: 227368 RVA: 0x00D2E886 File Offset: 0x00D2CA86
		[Nullable(2)]
		public unsafe MarkItemEntity MarkItemEntity
		{
			[NullableContext(2)]
			get
			{
				if (this.MarkItemEntityInner == null)
				{
					object key = this.MarkId;
					ELogAuthor author = ELogAuthor.LRX;
					string message = "没有初始化标记逻辑实体，请检查代码逻辑!";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MarkId", this.MarkId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MarkType", this.MarkType);
					MapLogger.ErrorOnce(key, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return this.MarkItemEntityInner;
			}
			[NullableContext(2)]
			set
			{
				this.MarkItemEntityInner = value;
			}
		}

		// Token: 0x17008547 RID: 34119
		// (get) Token: 0x06037829 RID: 227369
		// (set) Token: 0x0603782A RID: 227370
		public abstract int MarkId { get; set; }

		// Token: 0x17008548 RID: 34120
		// (get) Token: 0x0603782B RID: 227371
		public abstract EMarkType MarkType { get; }

		// Token: 0x17008549 RID: 34121
		// (get) Token: 0x0603782C RID: 227372 RVA: 0x00D2E88F File Offset: 0x00D2CA8F
		public virtual EMarkItemType MarkItemType
		{
			get
			{
				return EMarkItemType.Common;
			}
		}

		// Token: 0x1700854A RID: 34122
		// (get) Token: 0x0603782D RID: 227373 RVA: 0x00D2E892 File Offset: 0x00D2CA92
		// (set) Token: 0x0603782E RID: 227374 RVA: 0x00D2E89A File Offset: 0x00D2CA9A
		public EMapType MapType { get; set; }

		// Token: 0x1700854B RID: 34123
		// (get) Token: 0x0603782F RID: 227375 RVA: 0x00D2E8A3 File Offset: 0x00D2CAA3
		// (set) Token: 0x06037830 RID: 227376 RVA: 0x00D2E8AB File Offset: 0x00D2CAAB
		public int ShowPriority { get; set; }

		// Token: 0x1700854C RID: 34124
		// (get) Token: 0x06037831 RID: 227377 RVA: 0x00D2E8B4 File Offset: 0x00D2CAB4
		// (set) Token: 0x06037832 RID: 227378 RVA: 0x00D2E8BC File Offset: 0x00D2CABC
		public bool IsDestroy { get; set; }

		// Token: 0x1700854D RID: 34125
		// (get) Token: 0x06037833 RID: 227379 RVA: 0x00D2E8C5 File Offset: 0x00D2CAC5
		// (set) Token: 0x06037834 RID: 227380 RVA: 0x00D2E8CD File Offset: 0x00D2CACD
		public bool IsIgnoreScaleShow { get; set; }

		// Token: 0x1700854E RID: 34126
		// (get) Token: 0x06037835 RID: 227381 RVA: 0x00D2E8D6 File Offset: 0x00D2CAD6
		// (set) Token: 0x06037836 RID: 227382 RVA: 0x00D2E8DE File Offset: 0x00D2CADE
		public float ConfigScale { get; set; } = 1f;

		// Token: 0x1700854F RID: 34127
		// (get) Token: 0x06037838 RID: 227384 RVA: 0x00D2E901 File Offset: 0x00D2CB01
		// (set) Token: 0x06037837 RID: 227383 RVA: 0x00D2E8E7 File Offset: 0x00D2CAE7
		public float CornerScale
		{
			get
			{
				return this.CornerScaleInner;
			}
			set
			{
				this.CornerScaleInner = value;
				this.CornerScaleVector = new global::Vector((double)value, (double)value, (double)value);
			}
		}

		// Token: 0x17008550 RID: 34128
		// (get) Token: 0x06037839 RID: 227385 RVA: 0x00D2E909 File Offset: 0x00D2CB09
		// (set) Token: 0x0603783A RID: 227386 RVA: 0x00D2E911 File Offset: 0x00D2CB11
		public global::Vector CornerScaleVector { get; private set; } = new global::Vector(1.0, 1.0, 1.0);

		// Token: 0x17008551 RID: 34129
		// (get) Token: 0x0603783B RID: 227387 RVA: 0x00D2E91A File Offset: 0x00D2CB1A
		// (set) Token: 0x0603783C RID: 227388 RVA: 0x00D2E922 File Offset: 0x00D2CB22
		public float TrackFxScale { get; set; } = 1f;

		// Token: 0x17008552 RID: 34130
		// (get) Token: 0x0603783D RID: 227389 RVA: 0x00D2E92B File Offset: 0x00D2CB2B
		private bool IsTeleporting
		{
			get
			{
				return TeleportModel.Instance.IsTeleport;
			}
		}

		// Token: 0x17008553 RID: 34131
		// (get) Token: 0x0603783E RID: 227390 RVA: 0x00D2E937 File Offset: 0x00D2CB37
		// (set) Token: 0x0603783F RID: 227391 RVA: 0x00D2E93F File Offset: 0x00D2CB3F
		public int GridId { get; set; }

		// Token: 0x17008554 RID: 34132
		// (get) Token: 0x06037840 RID: 227392 RVA: 0x00D2E948 File Offset: 0x00D2CB48
		public virtual int MapId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17008555 RID: 34133
		// (get) Token: 0x06037841 RID: 227393 RVA: 0x00D2E94C File Offset: 0x00D2CB4C
		public virtual int? InstanceDungeonId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17008556 RID: 34134
		// (get) Token: 0x06037842 RID: 227394 RVA: 0x00D2E962 File Offset: 0x00D2CB62
		public virtual int? RelativeInstanceDungeonId
		{
			get
			{
				return this.InstanceDungeonId;
			}
		}

		// Token: 0x17008557 RID: 34135
		// (get) Token: 0x06037843 RID: 227395 RVA: 0x00D2E96C File Offset: 0x00D2CB6C
		public int InstanceDungeonOrMapConfigId
		{
			get
			{
				if (this.InstanceDungeonId != null)
				{
					int? instanceDungeonId = this.InstanceDungeonId;
					int num = 0;
					if (!(instanceDungeonId.GetValueOrDefault() == num & instanceDungeonId != null))
					{
						return this.InstanceDungeonId.Value;
					}
				}
				return this.MapId;
			}
		}

		// Token: 0x17008558 RID: 34136
		// (get) Token: 0x06037844 RID: 227396 RVA: 0x00D2E9BB File Offset: 0x00D2CBBB
		// (set) Token: 0x06037845 RID: 227397 RVA: 0x00D2E9C3 File Offset: 0x00D2CBC3
		[Nullable(2)]
		public string NeedPlayShowOrHideSeq { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008559 RID: 34137
		// (get) Token: 0x06037846 RID: 227398 RVA: 0x00D2E9CC File Offset: 0x00D2CBCC
		// (set) Token: 0x06037847 RID: 227399 RVA: 0x00D2E9D4 File Offset: 0x00D2CBD4
		public bool NeedPlayStartSequence { get; set; }

		// Token: 0x1700855A RID: 34138
		// (get) Token: 0x06037848 RID: 227400 RVA: 0x00D2E9DD File Offset: 0x00D2CBDD
		// (set) Token: 0x06037849 RID: 227401 RVA: 0x00D2E9E5 File Offset: 0x00D2CBE5
		public float MarkScale { get; set; } = 1f;

		// Token: 0x1700855B RID: 34139
		// (get) Token: 0x0603784A RID: 227402 RVA: 0x00D2E9EE File Offset: 0x00D2CBEE
		public global::Vector UiPosition
		{
			get
			{
				if (this.UiPositionVector == null)
				{
					return MapUtil.WorldPosition2UiPosition(this.WorldPosition, this.UiPositionVector);
				}
				return this.UiPositionVector;
			}
		}

		// Token: 0x1700855C RID: 34140
		// (get) Token: 0x0603784B RID: 227403 RVA: 0x00D2EA10 File Offset: 0x00D2CC10
		public global::Vector InitUiPosition
		{
			get
			{
				if (this.AnchorOffsetVector != null)
				{
					return this.AnchorOffsetVector;
				}
				return this.UiPosition;
			}
		}

		// Token: 0x0603784C RID: 227404 RVA: 0x00D2EA28 File Offset: 0x00D2CC28
		public void SetAnchorOffset(Vector2D value)
		{
			double x = value.X;
			global::Vector anchorOffsetVector = this.AnchorOffsetVector;
			bool flag;
			if (Math.Abs(x - ((anchorOffsetVector != null) ? anchorOffsetVector.X : 0.0)) <= 1E-08)
			{
				double y = value.Y;
				global::Vector anchorOffsetVector2 = this.AnchorOffsetVector;
				flag = (Math.Abs(y - ((anchorOffsetVector2 != null) ? anchorOffsetVector2.Y : 0.0)) > 1E-08);
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				MarkItemView view = this.View;
				UUIItem uuiitem = (view != null) ? view.GetRootItem() : null;
				this.AnchorOffsetVector = global::Vector.Create(value.X, value.Y, 0.0);
				if (ObjectUtils.IsValid(uuiitem))
				{
					FVector2D anchorOffset = value.ToUeVector2D(false);
					uuiitem.SetAnchorOffset(anchorOffset);
				}
			}
		}

		// Token: 0x0603784D RID: 227405 RVA: 0x00D2EAE6 File Offset: 0x00D2CCE6
		public virtual bool IsMultiMap()
		{
			return false;
		}

		// Token: 0x0603784E RID: 227406 RVA: 0x00D2EAE9 File Offset: 0x00D2CCE9
		public virtual bool LocateInGround()
		{
			return true;
		}

		// Token: 0x0603784F RID: 227407 RVA: 0x00D2EAEC File Offset: 0x00D2CCEC
		public virtual bool ConnectGround()
		{
			return true;
		}

		// Token: 0x06037850 RID: 227408 RVA: 0x00D2EAEF File Offset: 0x00D2CCEF
		public virtual int GetMultiMapId()
		{
			return 0;
		}

		// Token: 0x06037851 RID: 227409 RVA: 0x00D2EAF2 File Offset: 0x00D2CCF2
		public virtual bool ShowSecondaryUiMultiMapIcon()
		{
			return this.IsMultiMap() && !this.LocateInGround();
		}

		// Token: 0x1700855D RID: 34141
		// (get) Token: 0x06037852 RID: 227410 RVA: 0x00D2EB07 File Offset: 0x00D2CD07
		// (set) Token: 0x06037853 RID: 227411 RVA: 0x00D2EB19 File Offset: 0x00D2CD19
		public bool IsSelectThisFloor
		{
			get
			{
				return this.MarkItemEntity.MultiFloor.IsSelectThisFloor;
			}
			set
			{
				this.MarkItemEntity.MultiFloor.IsSelectThisFloor = value;
			}
		}

		// Token: 0x06037854 RID: 227412 RVA: 0x00D2EB2C File Offset: 0x00D2CD2C
		public virtual bool GetIsSelectThisFloor()
		{
			if (!this.IsMultiMap())
			{
				return false;
			}
			int multiMapId = this.GetMultiMapId();
			if (this.MapType == EMapType.MiniMap)
			{
				return this.InMultiMapArea(multiMapId);
			}
			int? worldMapCurrentMultiMapId = WorldMapModel.Instance.WorldMapCurrentMultiMapId;
			int num = multiMapId;
			return worldMapCurrentMultiMapId.GetValueOrDefault() == num & worldMapCurrentMultiMapId != null;
		}

		// Token: 0x06037855 RID: 227413 RVA: 0x00D2EB7C File Offset: 0x00D2CD7C
		protected bool InMultiMapArea(int multiMapId)
		{
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
			return MapConfig.Instance.IsAreaInSubMap(multiMapId, currentAreaId);
		}

		// Token: 0x06037856 RID: 227414 RVA: 0x00D2EBA9 File Offset: 0x00D2CDA9
		private double VectorSquareDistance(global::Vector vector3D, Vector2D vector2D)
		{
			return Math.Pow(vector3D.X - vector2D.X, 2.0) + Math.Pow(vector3D.Y - vector2D.Y, 2.0);
		}

		// Token: 0x1700855E RID: 34142
		// (get) Token: 0x06037857 RID: 227415 RVA: 0x00D2EBE4 File Offset: 0x00D2CDE4
		public global::Vector WorldPosition
		{
			get
			{
				if (this.MapType != EMapType.WorldMap && this.TrackTarget is TTrackTarget_Vector2D)
				{
					global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
					Vector2D value = (this.TrackTarget as TTrackTarget_Vector2D).Value;
					if (this.VectorSquareDistance(playerLocation, value) * 0.009999999776482582 * 0.009999999776482582 < 3600.0 && !this.IsTeleporting)
					{
						global::Vector vector = MapUtil.WorldPosition2UiPosition(global::Vector.Create(value.X, value.Y, 0.0), null);
						global::Vector markPosition = MapController.Instance.GetMarkPosition(vector.X, -vector.Y);
						if (markPosition != null)
						{
							this.UpdateCustomMapMarkPosition(markPosition);
						}
						else
						{
							this.TrackTarget = new TTrackTarget_Vector(global::Vector.Create(value.X, value.Y, 0.0));
						}
					}
				}
				if (this.WorldPositionVector == null || !this.EnableCachePosition)
				{
					this.WorldPositionVector = MapUtil.GetTrackPositionByTrackTargetConfig(this.TrackTarget, this.MapId, this.WorldPositionVector);
					if (this.WorldPositionVector == null)
					{
						this.WorldPositionVector = new global::Vector();
					}
					this.UiPositionVector = MapUtil.WorldPosition2UiPosition(this.WorldPositionVector, this.UiPositionVector);
				}
				return this.WorldPositionVector;
			}
		}

		// Token: 0x06037858 RID: 227416 RVA: 0x00D2ED20 File Offset: 0x00D2CF20
		public void UpdateCustomMapMarkPosition(global::Vector hitResult)
		{
			if (this.MarkType != EMarkType.Custom)
			{
				return;
			}
			global::Vector position = global::Vector.Create(hitResult.X, -hitResult.Y, hitResult.Z);
			global::Vector markPos = global::Vector.Create(hitResult.X, hitResult.Y, hitResult.Z);
			global::Vector vector = MapUtil.UiPosition2WorldPosition(position, null);
			this.TrackTarget = new TTrackTarget_Vector(vector);
			MapController.Instance.UpdateCustomMapMarkPosition(this.MarkId, markPos);
			global::Vector vector2 = global::Vector.Create();
			vector.Multiply(0.009999999776482582, vector2);
			MapModel.Instance.UpdateCustomMarkInfo(this.MarkId, vector2);
			TrackModel.Instance.UpdateTrackData(this.TrackSourceInner, this.MarkId, this.TrackTarget);
		}

		// Token: 0x06037859 RID: 227417 RVA: 0x00D2EDD0 File Offset: 0x00D2CFD0
		public MarkItem(UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark)
		{
			this.MapType = mapType;
			this.MarkScale = markScale;
			this.InnerViewRoot = parent;
			this.TrackSourceInner = trackSource;
			this.UiPositionVector = null;
			this.WorldPositionVector = global::Vector.Create();
		}

		// Token: 0x1700855F RID: 34143
		// (get) Token: 0x0603785A RID: 227418 RVA: 0x00D2EEA1 File Offset: 0x00D2D0A1
		// (set) Token: 0x0603785B RID: 227419 RVA: 0x00D2EEA9 File Offset: 0x00D2D0A9
		public virtual bool IsStreaming { get; set; } = true;

		// Token: 0x0603785C RID: 227420 RVA: 0x00D2EEB2 File Offset: 0x00D2D0B2
		public void OnLoad()
		{
		}

		// Token: 0x0603785D RID: 227421 RVA: 0x00D2EEB4 File Offset: 0x00D2D0B4
		public void OnUnload()
		{
		}

		// Token: 0x0603785E RID: 227422 RVA: 0x00D2EEB6 File Offset: 0x00D2D0B6
		public Vector2D GetPreloadThreshold()
		{
			return this.PreloadThreshold;
		}

		// Token: 0x0603785F RID: 227423 RVA: 0x00D2EEBE File Offset: 0x00D2D0BE
		public global::Vector GetUiPosition()
		{
			return this.UiPosition;
		}

		// Token: 0x06037860 RID: 227424 RVA: 0x00D2EEC8 File Offset: 0x00D2D0C8
		public void Initialize()
		{
			this.MarkItemEntity.Init();
			this.IsOutOfBound = false;
			this.IsInAoiRange = false;
			int instanceDungeonOrMapConfigId = this.InstanceDungeonOrMapConfigId;
			this.CachedDungeonMapConfigId = MapModel.Instance.GetDungeonMapConfigId(instanceDungeonOrMapConfigId);
			this.CachedDungeonLocateWorldMapId = MapModel.Instance.GetDungeonLocateWorldMapId(instanceDungeonOrMapConfigId);
			WorldMapConfig instance = WorldMapConfig.Instance;
			this.CachedIsBelongWorld = (instance != null && instance.IsMapInWorld(instanceDungeonOrMapConfigId));
			this.OnInitialize();
		}

		// Token: 0x06037861 RID: 227425 RVA: 0x00D2EF35 File Offset: 0x00D2D135
		protected virtual void OnInitialize()
		{
		}

		// Token: 0x06037862 RID: 227426 RVA: 0x00D2EF37 File Offset: 0x00D2D137
		public void SetTrackData(TTrackTarget trackTarget)
		{
			this.TrackTarget = trackTarget;
		}

		// Token: 0x06037863 RID: 227427 RVA: 0x00D2EF40 File Offset: 0x00D2D140
		public void LogicUpdate(global::Vector playerLocation)
		{
			this.OnUpdate(playerLocation);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x06037864 RID: 227428 RVA: 0x00D2EF50 File Offset: 0x00D2D150
		public UniTask ViewUpdateAsync(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			MarkItem.<ViewUpdateAsync>d__112 <ViewUpdateAsync>d__;
			<ViewUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ViewUpdateAsync>d__.<>4__this = this;
			<ViewUpdateAsync>d__.playerLocation = playerLocation;
			<ViewUpdateAsync>d__.bDragging = bDragging;
			<ViewUpdateAsync>d__.bIsScale = bIsScale;
			<ViewUpdateAsync>d__.<>1__state = -1;
			<ViewUpdateAsync>d__.<>t__builder.Start<MarkItem.<ViewUpdateAsync>d__112>(ref <ViewUpdateAsync>d__);
			return <ViewUpdateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037865 RID: 227429 RVA: 0x00D2EFAC File Offset: 0x00D2D1AC
		public unsafe virtual void Destroy(bool recycleToPoolImmediately = true)
		{
			ELogAuthor author = ELogAuthor.LRX;
			string message = "标记系统->MarkItem.Destroy";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markType", this.MarkType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MarkId", this.MarkId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("InstanceDungeonId", this.InstanceDungeonId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("MapId", this.MapId);
			MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.IsDestroy = true;
			this.OnDestroy();
			this.RecycleView(recycleToPoolImmediately);
			this.MarkItemEntity.Dispose();
			this.InnerViewRoot = null;
		}

		// Token: 0x17008560 RID: 34144
		// (get) Token: 0x06037866 RID: 227430 RVA: 0x00D2F083 File Offset: 0x00D2D283
		// (set) Token: 0x06037867 RID: 227431 RVA: 0x00D2F095 File Offset: 0x00D2D295
		public bool IsInAoiRange
		{
			get
			{
				return this.MarkItemEntity.ViewLifeCircle.IsInAoiRange;
			}
			set
			{
				this.MarkItemEntity.ViewLifeCircle.IsInAoiRange = value;
			}
		}

		// Token: 0x06037868 RID: 227432
		protected abstract MarkItemView CreateView();

		// Token: 0x06037869 RID: 227433
		protected abstract EMarkItemViewType GetMarkItemViewType();

		// Token: 0x0603786A RID: 227434 RVA: 0x00D2F0A8 File Offset: 0x00D2D2A8
		private void ShowView()
		{
			if (this.View != null)
			{
				this.InitInnerView();
				return;
			}
			EMarkItemViewType markItemViewType = this.GetMarkItemViewType();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<EMarkItemViewType>(markItemViewType);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<EMapType>(this.MapType);
			MarkItemView markItemView = MarkItemViewPoolFactory.Get<MarkItemView>(defaultInterpolatedStringHandler.ToStringAndClear());
			if (markItemView != null)
			{
				this.View = markItemView;
				this.InitInnerView();
				return;
			}
			this.View = this.CreateView();
			MarkItemView view = this.View;
			this.InitInnerViewAsync(view);
		}

		// Token: 0x0603786B RID: 227435 RVA: 0x00D2F130 File Offset: 0x00D2D330
		private UniTask InitInnerViewAsync(MarkItemView view)
		{
			MarkItem.<InitInnerViewAsync>d__120 <InitInnerViewAsync>d__;
			<InitInnerViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitInnerViewAsync>d__.<>4__this = this;
			<InitInnerViewAsync>d__.view = view;
			<InitInnerViewAsync>d__.<>1__state = -1;
			<InitInnerViewAsync>d__.<>t__builder.Start<MarkItem.<InitInnerViewAsync>d__120>(ref <InitInnerViewAsync>d__);
			return <InitInnerViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603786C RID: 227436 RVA: 0x00D2F17C File Offset: 0x00D2D37C
		private void InitInnerView()
		{
			if (this.View == null)
			{
				return;
			}
			if (this.View.LoadingPromise != null)
			{
				return;
			}
			if (!this.IsDestroy && !this.View.IsDestroyOrDestroying)
			{
				this.MarkItemEntity.ViewLifeCircle.SetAllChildViewStateDirty();
				this.View.InitializeData(this);
				this.View.InitializeView();
				this.View.RefreshView();
			}
		}

		// Token: 0x0603786D RID: 227437 RVA: 0x00D2F1E8 File Offset: 0x00D2D3E8
		private void RecycleView(bool recycleToPoolImmediately = false)
		{
			if (this.View == null)
			{
				return;
			}
			this.MarkItemEntity.ViewLifeCircle.SetAllChildViewStateDirty();
			EMarkItemViewType markItemViewType = this.GetMarkItemViewType();
			if (!this.View.ViewInitialized)
			{
				this.View.RecycleToPool();
				this.View = null;
				return;
			}
			this.View.RecycleView(new bool?(recycleToPoolImmediately));
			if (!recycleToPoolImmediately)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<EMarkItemViewType>(markItemViewType);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<EMapType>(this.MapType);
				MarkItemViewPoolFactory.Recycle(defaultInterpolatedStringHandler.ToStringAndClear(), this.View);
			}
			this.View = null;
		}

		// Token: 0x17008561 RID: 34145
		// (get) Token: 0x0603786E RID: 227438 RVA: 0x00D2F28C File Offset: 0x00D2D48C
		// (set) Token: 0x0603786F RID: 227439 RVA: 0x00D2F294 File Offset: 0x00D2D494
		[Nullable(2)]
		public TTrackTarget TrackTarget
		{
			[NullableContext(2)]
			get
			{
				return this.TrackTargetInner;
			}
			[NullableContext(2)]
			set
			{
				this.TrackTargetInner = value;
				this.UiPositionVector = null;
				this.WorldPositionVector = null;
				this.AnchorOffsetVector = null;
			}
		}

		// Token: 0x17008562 RID: 34146
		// (get) Token: 0x06037870 RID: 227440 RVA: 0x00D2F2B4 File Offset: 0x00D2D4B4
		public virtual int? TrackAreaId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06037871 RID: 227441 RVA: 0x00D2F2CC File Offset: 0x00D2D4CC
		public int GetWorldMapAreaId()
		{
			int num = this.TrackAreaId.GetValueOrDefault();
			int mapId = this.MapId;
			if (num != 0 || mapId != 912)
			{
				return num;
			}
			MapModel instance = MapModel.Instance;
			num = instance.GetMarkAreaId(this.MarkId, this.MarkType);
			return instance.ResolveWorldMapMarkAreaId(mapId, num, this.TrackTarget);
		}

		// Token: 0x17008563 RID: 34147
		// (get) Token: 0x06037872 RID: 227442 RVA: 0x00D2F321 File Offset: 0x00D2D521
		public ETrackSource TrackSource
		{
			get
			{
				return this.TrackSourceInner;
			}
		}

		// Token: 0x17008564 RID: 34148
		// (get) Token: 0x06037873 RID: 227443 RVA: 0x00D2F329 File Offset: 0x00D2D529
		// (set) Token: 0x06037874 RID: 227444 RVA: 0x00D2F33B File Offset: 0x00D2D53B
		public bool IsTracked
		{
			get
			{
				return this.MarkItemEntity.ViewLifeCircle.IsTracked;
			}
			set
			{
				MarkViewLifeCircleComponent viewLifeCircle = this.MarkItemEntity.ViewLifeCircle;
				viewLifeCircle.IsTracked = value;
				if (viewLifeCircle.IsTrackedDirty)
				{
					if (value)
					{
						this.OnStartTrack();
						return;
					}
					this.OnEndTrack();
				}
			}
		}

		// Token: 0x17008565 RID: 34149
		// (get) Token: 0x06037875 RID: 227445 RVA: 0x00D2F366 File Offset: 0x00D2D566
		// (set) Token: 0x06037876 RID: 227446 RVA: 0x00D2F378 File Offset: 0x00D2D578
		public bool IsAutoPilotTracked
		{
			get
			{
				return this.MarkItemEntity.ViewLifeCircle.IsAutoPilotTracked;
			}
			set
			{
				this.MarkItemEntity.ViewLifeCircle.IsAutoPilotTracked = value;
			}
		}

		// Token: 0x17008566 RID: 34150
		// (get) Token: 0x06037877 RID: 227447 RVA: 0x00D2F38C File Offset: 0x00D2D58C
		public virtual bool PermanentUpdate
		{
			get
			{
				MarkViewLifeCircleComponent viewLifeCircle = this.MarkItemEntity.ViewLifeCircle;
				return viewLifeCircle.IsTracked || viewLifeCircle.IsSelected || MarkDefine.PermanentUpdateTypeSet.Contains(this.MarkType);
			}
		}

		// Token: 0x17008567 RID: 34151
		// (get) Token: 0x06037878 RID: 227448 RVA: 0x00D2F3C7 File Offset: 0x00D2D5C7
		public bool CanOutOfBound
		{
			get
			{
				return this.IsTracked || MarkDefine.CanOutOfBoundUpdateTypeSet.Contains(this.MarkType);
			}
		}

		// Token: 0x06037879 RID: 227449 RVA: 0x00D2F3E4 File Offset: 0x00D2D5E4
		protected virtual void UpdateVisibleRelativeState()
		{
			MarkItemEntity markItemEntity = this.MarkItemEntity;
			MarkViewLifeCircleComponent viewLifeCircle = markItemEntity.ViewLifeCircle;
			EMapType mapType = this.MapType;
			bool flag = !this.IsInConsistentDistrict(false);
			bool isSelected = viewLifeCircle.IsSelected;
			bool flag2 = this.IsTracking();
			bool flag3 = this.CheckCanShowInGravityLayer(flag2);
			bool flag4 = this.CheckCanShowInMultiMap();
			bool flag5 = ((this.CheckCanShowView() && flag4) || isSelected || flag2) && flag3;
			bool flag6 = flag && flag5 && this.CheckCanShowInBoxArea();
			if (this.MarkItemType != EMarkItemType.Config)
			{
				flag6 &= this.IsTempMapMarkShow();
			}
			if (this.MarkType != EMarkType.AreaMark && this.MarkType != EMarkType.Quest && MapHelper.IsRecallContextMismatched(this.MarkId))
			{
				flag6 = false;
			}
			this.IsCanShowView = flag6;
			this.IsTracked = flag2;
			int markId = this.MarkId;
			if (markId > 0)
			{
				this.IsAutoPilotTracked = AutoPilotModel.Instance.GetIsTracking(markId);
			}
			bool flag7;
			if (!flag6 || !flag)
			{
				flag7 = false;
			}
			else
			{
				if (mapType != EMapType.MiniMap || flag2)
				{
					viewLifeCircle.IsInAoiRange = true;
				}
				flag7 = (flag2 || viewLifeCircle.IsInAoiRange);
			}
			viewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.GravityReverse, markItemEntity.GamePlay.CanShowGravityChildIcon);
			flag7 = this.CheckExtraUiMarkVisible(flag7, mapType, markId);
			viewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.MarkView, flag7);
		}

		// Token: 0x0603787A RID: 227450 RVA: 0x00D2F518 File Offset: 0x00D2D718
		private bool CheckExtraUiMarkVisible(bool showMarkView, EMapType mapType, int markId)
		{
			MapModel instance = MapModel.Instance;
			bool flag = showMarkView;
			if (instance.HasExtraUiMarkType(mapType))
			{
				flag = instance.IsExtraUiMarkType(mapType, this.MarkType);
			}
			if (markId != 0 && instance.HasExtraUiMarkId(mapType))
			{
				flag = (flag || instance.IsExtraUiMarkId(mapType, markId));
			}
			flag = (flag && this.CheckCanShowViewInExtraUi());
			if (instance.HasExtraUiTileRange(mapType))
			{
				flag = (flag && instance.IsInExtraUiTileRange(mapType, this.UiPosition));
			}
			return flag;
		}

		// Token: 0x0603787B RID: 227451 RVA: 0x00D2F58C File Offset: 0x00D2D78C
		public void CreateOrCycleView()
		{
			if (this.MarkItemEntity.ViewLifeCircle.IsChildViewStateDirty(EMarkViewComponentType.MarkView))
			{
				bool flag = this.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.MarkView, false);
				this.MarkItemEntity.ViewLifeCircle.SetChildViewVisibleClean(EMarkViewComponentType.MarkView);
				if (flag)
				{
					this.ShowView();
					return;
				}
				this.RecycleView(false);
			}
		}

		// Token: 0x0603787C RID: 227452 RVA: 0x00D2F5DF File Offset: 0x00D2D7DF
		protected virtual bool IsTempMapMarkShow()
		{
			return this.MapType != EMapType.MiniMap || !this.MarkItemEntity.IsTempMapMark || this.IsTracked;
		}

		// Token: 0x0603787D RID: 227453 RVA: 0x00D2F5FF File Offset: 0x00D2D7FF
		protected virtual bool IsTracking()
		{
			return TrackModel.Instance.IsTracking(this.TrackSource, this.MarkId);
		}

		// Token: 0x0603787E RID: 227454 RVA: 0x00D2F617 File Offset: 0x00D2D817
		protected virtual void OnStartTrack()
		{
			MarkItemView view = this.View;
			if (view == null)
			{
				return;
			}
			view.OnStartTrack();
		}

		// Token: 0x0603787F RID: 227455 RVA: 0x00D2F629 File Offset: 0x00D2D829
		protected virtual void OnEndTrack()
		{
			MarkItemView view = this.View;
			if (view == null)
			{
				return;
			}
			view.OnEndTrack();
		}

		// Token: 0x06037880 RID: 227456 RVA: 0x00D2F63B File Offset: 0x00D2D83B
		protected virtual void OnUpdate(global::Vector playerLocation)
		{
		}

		// Token: 0x06037881 RID: 227457 RVA: 0x00D2F63D File Offset: 0x00D2D83D
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x17008568 RID: 34152
		// (get) Token: 0x06037882 RID: 227458 RVA: 0x00D2F63F File Offset: 0x00D2D83F
		[Nullable(2)]
		public UUIItem ViewRoot
		{
			[NullableContext(2)]
			get
			{
				return this.InnerViewRoot;
			}
		}

		// Token: 0x17008569 RID: 34153
		// (get) Token: 0x06037883 RID: 227459 RVA: 0x00D2F647 File Offset: 0x00D2D847
		// (set) Token: 0x06037884 RID: 227460 RVA: 0x00D2F64F File Offset: 0x00D2D84F
		[Nullable(2)]
		public MarkItemView View { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700856A RID: 34154
		// (get) Token: 0x06037885 RID: 227461 RVA: 0x00D2F658 File Offset: 0x00D2D858
		// (set) Token: 0x06037886 RID: 227462 RVA: 0x00D2F660 File Offset: 0x00D2D860
		public virtual string IconPath
		{
			get
			{
				return this.Icon;
			}
			set
			{
				if (!string.Equals(this.Icon, value, StringComparison.Ordinal))
				{
					this.Icon = value;
				}
			}
		}

		// Token: 0x1700856B RID: 34155
		// (get) Token: 0x06037887 RID: 227463 RVA: 0x00D2F678 File Offset: 0x00D2D878
		// (set) Token: 0x06037888 RID: 227464 RVA: 0x00D2F68C File Offset: 0x00D2D88C
		public bool IsOutOfBound
		{
			get
			{
				return this.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.OutOfBound, false);
			}
			set
			{
				this.MarkItemEntity.ViewLifeCircle.SetChildViewVisibility(EMarkViewComponentType.OutOfBound, value);
				if (this.View != null && this.View.IsViewReady)
				{
					this.View.ApplyOutOfBoundActive();
				}
			}
		}

		// Token: 0x06037889 RID: 227465 RVA: 0x00D2F6C0 File Offset: 0x00D2D8C0
		public void SetSelected(bool value)
		{
			this.MarkItemEntity.ViewLifeCircle.IsSelected = value;
			if (this.View == null || this.IsDestroy)
			{
				return;
			}
			this.View.IsSelected = value;
		}

		// Token: 0x0603788A RID: 227466 RVA: 0x00D2F6F0 File Offset: 0x00D2D8F0
		public bool IsViewReady()
		{
			return this.View != null && !this.View.IsCreating;
		}

		// Token: 0x0603788B RID: 227467 RVA: 0x00D2F70A File Offset: 0x00D2D90A
		[NullableContext(2)]
		public UUIItem GetRootItemSync()
		{
			if (!this.IsViewReady())
			{
				return null;
			}
			MarkItemView view = this.View;
			if (view == null)
			{
				return null;
			}
			return view.GetRootItem();
		}

		// Token: 0x0603788C RID: 227468 RVA: 0x00D2F728 File Offset: 0x00D2D928
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UUIItem> GetRootItemAsync()
		{
			MarkItem.<GetRootItemAsync>d__170 <GetRootItemAsync>d__;
			<GetRootItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UUIItem>.Create();
			<GetRootItemAsync>d__.<>4__this = this;
			<GetRootItemAsync>d__.<>1__state = -1;
			<GetRootItemAsync>d__.<>t__builder.Start<MarkItem.<GetRootItemAsync>d__170>(ref <GetRootItemAsync>d__);
			return <GetRootItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603788D RID: 227469 RVA: 0x00D2F76B File Offset: 0x00D2D96B
		[NullableContext(2)]
		public virtual string GetTitleText()
		{
			return null;
		}

		// Token: 0x0603788E RID: 227470 RVA: 0x00D2F770 File Offset: 0x00D2D970
		public virtual void SetTitleText(UUIText uiText)
		{
			string titleText = this.GetTitleText();
			if (!string.IsNullOrEmpty(titleText))
			{
				uiText.SetText(titleText, true);
			}
		}

		// Token: 0x0603788F RID: 227471 RVA: 0x00D2F794 File Offset: 0x00D2D994
		[NullableContext(2)]
		public virtual string GetStateIconPath()
		{
			if (this.IsMultiMap() && (!this.LocateInGround() || !this.IsSelectThisFloor))
			{
				return UiResourceConfig.Instance.GetResourcePath(this.IsSelectThisFloor ? "SP_MarkMultiMapSelect" : "SP_MarkMultiMap") ?? string.Empty;
			}
			return null;
		}

		// Token: 0x06037890 RID: 227472 RVA: 0x00D2F7E5 File Offset: 0x00D2D9E5
		[NullableContext(2)]
		public virtual string GetLocaleDesc()
		{
			return null;
		}

		// Token: 0x06037891 RID: 227473 RVA: 0x00D2F7E8 File Offset: 0x00D2D9E8
		protected void SetConfigScale(float scale)
		{
			this.ConfigScale = scale;
		}

		// Token: 0x06037892 RID: 227474 RVA: 0x00D2F7F1 File Offset: 0x00D2D9F1
		protected void SetCornerScale(float cornerScale)
		{
			this.CornerScale = cornerScale;
		}

		// Token: 0x1700856C RID: 34156
		// (get) Token: 0x06037893 RID: 227475 RVA: 0x00D2F7FA File Offset: 0x00D2D9FA
		private bool IsCanShowViewExtra
		{
			get
			{
				return MapModel.Instance.GetMarkForceVisible(this.MarkType, this.MarkId);
			}
		}

		// Token: 0x1700856D RID: 34157
		// (get) Token: 0x06037894 RID: 227476 RVA: 0x00D2F812 File Offset: 0x00D2DA12
		protected bool IsCanShowViewIntermediately
		{
			get
			{
				return this.IsCanShowViewInner && this.IsCanShowViewExtra;
			}
		}

		// Token: 0x1700856E RID: 34158
		// (get) Token: 0x06037895 RID: 227477 RVA: 0x00D2F824 File Offset: 0x00D2DA24
		// (set) Token: 0x06037896 RID: 227478 RVA: 0x00D2F836 File Offset: 0x00D2DA36
		public bool IsCanShowView
		{
			get
			{
				return this.IsCanShowViewIntermediately || this.IsCanShowViewFinally;
			}
			set
			{
				this.IsCanShowViewInner = value;
			}
		}

		// Token: 0x06037897 RID: 227479 RVA: 0x00D2F83F File Offset: 0x00D2DA3F
		public virtual bool CheckCanShowView()
		{
			return this.MapType == EMapType.WorldMap;
		}

		// Token: 0x06037898 RID: 227480 RVA: 0x00D2F84C File Offset: 0x00D2DA4C
		protected virtual bool CheckCanShowInBoxArea()
		{
			if (this.MapType != EMapType.WorldMap)
			{
				return true;
			}
			if (this.MarkType == EMarkType.AreaMark)
			{
				return true;
			}
			WorldMapModel instance = WorldMapModel.Instance;
			int currentWorldMapConfigId = instance.CurrentWorldMapConfigId;
			int num = this.TrackAreaId.GetValueOrDefault();
			if (currentWorldMapConfigId != 912)
			{
				return instance.IsAreaInDisplay(currentWorldMapConfigId, num);
			}
			if (num == 0)
			{
				num = MapModel.Instance.GetMarkAreaId(this.MarkId, this.MarkType);
			}
			if (num != 0)
			{
				return instance.IsAreaInDisplay(currentWorldMapConfigId, num);
			}
			TTrackTarget trackTarget = this.TrackTarget;
			TTrackTarget_Vector ttrackTarget_Vector = trackTarget as TTrackTarget_Vector;
			global::Vector vector;
			if (ttrackTarget_Vector == null)
			{
				TTrackTarget_Vector2D ttrackTarget_Vector2D = trackTarget as TTrackTarget_Vector2D;
				if (ttrackTarget_Vector2D == null)
				{
					vector = null;
				}
				else
				{
					vector = global::Vector.Create(ttrackTarget_Vector2D.Value.X, ttrackTarget_Vector2D.Value.Y, 0.0);
				}
			}
			else
			{
				vector = ttrackTarget_Vector.Value;
			}
			global::Vector vector2 = vector;
			return vector2 != null && instance.IsPositionInDisplay(currentWorldMapConfigId, vector2);
		}

		// Token: 0x06037899 RID: 227481 RVA: 0x00D2F92F File Offset: 0x00D2DB2F
		public virtual bool CheckCanShowViewInExtraUi()
		{
			return true;
		}

		// Token: 0x0603789A RID: 227482 RVA: 0x00D2F934 File Offset: 0x00D2DB34
		public bool IsInConsistentDistrict(bool strictMode = false)
		{
			EMapType mapType = this.MapType;
			bool flag = mapType == EMapType.MiniMap;
			int? num = (strictMode || flag) ? new int?(this.CachedDungeonMapConfigId) : this.CachedDungeonLocateWorldMapId;
			WorldMapModel instance = WorldMapModel.Instance;
			int? num2 = num;
			int currentWorldMapConfigId = instance.CurrentWorldMapConfigId;
			if (!(num2.GetValueOrDefault() == currentWorldMapConfigId & num2 != null))
			{
				return true;
			}
			bool flag2 = this.MarkType != EMarkType.AreaMark;
			bool flag3 = instance.IsPlayerInStoryInstanceDungeon();
			if (flag2 && !flag3 && !instance.IsPlayerInBigWorldInstanceDungeon() && instance.EnableInstanceDungeonFilterMark)
			{
				int currentMapConfigId = MapModel.Instance.CurrentMapConfigId;
				num2 = num;
				if (currentMapConfigId == num2.GetValueOrDefault() & num2 != null)
				{
					return this.IsInConsistentDungeonByActivityRule();
				}
			}
			if (flag3 && flag2)
			{
				return this.IsInConsistentDungeonByStoryRule();
			}
			bool cachedIsBelongWorld = this.CachedIsBelongWorld;
			if (flag)
			{
				if (cachedIsBelongWorld)
				{
					return this.IsInConsistentBigWorldDungeon();
				}
				return this.InstanceDungeonId != null && this.IsInConsistentDungeon();
			}
			else
			{
				if (instance.IsPlayerInWorldInstanceDungeon())
				{
					return this.IsInConsistentLocateBigWorldDungeon(cachedIsBelongWorld);
				}
				if (this.MarkType == EMarkType.Quest && mapType == EMapType.WorldMap && RecallQuestModel.Instance.IsInRecallInstance())
				{
					return this.CachedDungeonMapConfigId != instance.CurrentWorldMapConfigId;
				}
				return this.IsInConsistentBigWorldDungeon();
			}
		}

		// Token: 0x0603789B RID: 227483 RVA: 0x00D2FA64 File Offset: 0x00D2DC64
		private bool IsInConsistentBigWorldDungeon()
		{
			int? instanceDungeonId = this.InstanceDungeonId;
			int num = 0;
			if ((instanceDungeonId.GetValueOrDefault() == num & instanceDungeonId != null) || this.InstanceDungeonId == null)
			{
				return false;
			}
			instanceDungeonId = this.InstanceDungeonId;
			num = WorldMapModel.Instance.CurrentWorldMapInstanceId;
			return !(instanceDungeonId.GetValueOrDefault() == num & instanceDungeonId != null);
		}

		// Token: 0x0603789C RID: 227484 RVA: 0x00D2FAC8 File Offset: 0x00D2DCC8
		private bool IsInConsistentLocateBigWorldDungeon(bool targetBelongWorld)
		{
			int? instanceDungeonId = this.InstanceDungeonId;
			int num = 0;
			if ((instanceDungeonId.GetValueOrDefault() == num & instanceDungeonId != null) || this.InstanceDungeonId == null)
			{
				return false;
			}
			instanceDungeonId = this.InstanceDungeonId;
			num = WorldMapModel.Instance.GetCurrentLocateWorldMapInstanceId(targetBelongWorld);
			return !(instanceDungeonId.GetValueOrDefault() == num & instanceDungeonId != null);
		}

		// Token: 0x0603789D RID: 227485 RVA: 0x00D2FB2C File Offset: 0x00D2DD2C
		private bool IsInConsistentDungeon()
		{
			int? instanceDungeonId = this.InstanceDungeonId;
			int currentWorldMapInstanceId = WorldMapModel.Instance.CurrentWorldMapInstanceId;
			return !(instanceDungeonId.GetValueOrDefault() == currentWorldMapInstanceId & instanceDungeonId != null);
		}

		// Token: 0x0603789E RID: 227486 RVA: 0x00D2FB60 File Offset: 0x00D2DD60
		private bool IsInConsistentDungeonByStoryRule()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(WorldMapModel.Instance.CurrentWorldMapInstanceId);
			int num = (config != null) ? config.GetValueOrDefault().MapMarkFilterRule : 0;
			if (num != 0)
			{
				return num == 1 && this.IsInConsistentDungeon();
			}
			if (this.MarkType == EMarkType.Quest && this.MapType == EMapType.WorldMap)
			{
				return false;
			}
			if (this.MapType == EMapType.MiniMap)
			{
				return this.IsInConsistentDungeon();
			}
			return this.IsInConsistentBigWorldDungeon();
		}

		// Token: 0x0603789F RID: 227487 RVA: 0x00D2FBDC File Offset: 0x00D2DDDC
		private bool IsInConsistentDungeonByActivityRule()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(WorldMapModel.Instance.CurrentWorldMapInstanceId);
			int num = (config != null) ? config.GetValueOrDefault().MapMarkFilterRule : 0;
			if (num != 0 && num == 1)
			{
				return this.IsInConsistentDungeon();
			}
			return this.InstanceDungeonId == null || this.IsInConsistentDungeon();
		}

		// Token: 0x060378A0 RID: 227488 RVA: 0x00D2FC40 File Offset: 0x00D2DE40
		protected bool CheckCanShowInGravityLayer(bool isTracking)
		{
			return isTracking || MarkDefine.PermanentShowInGravityLayerTypeSet.Contains(this.MarkType) || this.MarkItemEntity.GamePlay.InGravityLayer;
		}

		// Token: 0x060378A1 RID: 227489 RVA: 0x00D2FC6C File Offset: 0x00D2DE6C
		protected bool CheckCanShowInMultiMap()
		{
			if (this.MapType == EMapType.MiniMap)
			{
				return true;
			}
			if (MarkDefine.AllFloorShowMarkTypeSet.Contains(this.MarkType))
			{
				return true;
			}
			MapMark? configMark = MapConfig.Instance.GetConfigMark(this.MarkId);
			if (configMark != null && configMark.GetValueOrDefault().MultiFloorShowCondition == 0)
			{
				return true;
			}
			if (this.IsMultiMap())
			{
				return this.GetIsSelectThisFloor();
			}
			int? worldMapCurrentMultiMapId = WorldMapModel.Instance.WorldMapCurrentMultiMapId;
			if (worldMapCurrentMultiMapId == null)
			{
				return true;
			}
			MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(worldMapCurrentMultiMapId.Value);
			return subMapConfigById == null || subMapConfigById.Value.Floor == 0;
		}

		// Token: 0x060378A2 RID: 227490 RVA: 0x00D2FD20 File Offset: 0x00D2DF20
		public virtual float GetShowScale()
		{
			float currentMapShowScale = this.GetCurrentMapShowScale();
			return Math.Max(0f, currentMapShowScale);
		}

		// Token: 0x060378A3 RID: 227491 RVA: 0x00D2FD3F File Offset: 0x00D2DF3F
		protected virtual float GetCurrentMapShowScale()
		{
			return WorldMapModel.Instance.MapScale * 100f - 100f;
		}

		// Token: 0x060378A4 RID: 227492 RVA: 0x00D2FD57 File Offset: 0x00D2DF57
		public void OnLevelSequenceStart(string sequenceName)
		{
			if (sequenceName == "ShowView" || sequenceName == "HideView")
			{
				this.IsCanShowViewFinally = true;
			}
		}

		// Token: 0x060378A5 RID: 227493 RVA: 0x00D2FD7A File Offset: 0x00D2DF7A
		public void OnLevelSequenceStop(string sequenceName)
		{
			if (sequenceName == "ShowView" || sequenceName == "HideView")
			{
				this.IsCanShowViewFinally = false;
			}
		}

		// Token: 0x060378A6 RID: 227494 RVA: 0x00D2FD9D File Offset: 0x00D2DF9D
		public virtual bool GetInteractiveFlag()
		{
			return this.IsCanShowView;
		}

		// Token: 0x060378A7 RID: 227495 RVA: 0x00D2FDA5 File Offset: 0x00D2DFA5
		public virtual bool GamePlayIsDiscover()
		{
			return false;
		}

		// Token: 0x060378A8 RID: 227496 RVA: 0x00D2FDA8 File Offset: 0x00D2DFA8
		public virtual ESecondaryPanel GetSecondaryUiType()
		{
			return WorldMapSecondaryUiDefine.MarkPanelTypeMap.GetValueOrDefault(this.MarkType, ESecondaryPanel.GeneralPanel);
		}

		// Token: 0x060378A9 RID: 227497 RVA: 0x00D2FDBB File Offset: 0x00D2DFBB
		public bool GetIsStrictConfigMark()
		{
			return this.MarkItemEntity.IsConfigMark && this.MarkItemType == EMarkItemType.Config;
		}

		// Token: 0x0401D3AA RID: 119722
		[Nullable(2)]
		private MarkItemEntity MarkItemEntityInner;

		// Token: 0x0401D3B0 RID: 119728
		private float CornerScaleInner = 1f;

		// Token: 0x0401D3B3 RID: 119731
		[Nullable(2)]
		private global::Vector UiPositionVector;

		// Token: 0x0401D3B4 RID: 119732
		[Nullable(2)]
		private global::Vector WorldPositionVector;

		// Token: 0x0401D3B5 RID: 119733
		private readonly Vector2D PreloadThreshold = Vector2D.Create(0.0, 0.0);

		// Token: 0x0401D3B7 RID: 119735
		private int CachedDungeonMapConfigId;

		// Token: 0x0401D3B8 RID: 119736
		private int? CachedDungeonLocateWorldMapId;

		// Token: 0x0401D3B9 RID: 119737
		private bool CachedIsBelongWorld;

		// Token: 0x0401D3BD RID: 119741
		[Nullable(2)]
		private global::Vector AnchorOffsetVector;

		// Token: 0x0401D3BF RID: 119743
		[Nullable(2)]
		private TTrackTarget TrackTargetInner;

		// Token: 0x0401D3C0 RID: 119744
		protected bool EnableCachePosition = true;

		// Token: 0x0401D3C1 RID: 119745
		private ETrackSource TrackSourceInner = ETrackSource.Instance;

		// Token: 0x0401D3C2 RID: 119746
		[Nullable(2)]
		private UUIItem InnerViewRoot;

		// Token: 0x0401D3C4 RID: 119748
		private string Icon = string.Empty;

		// Token: 0x0401D3C5 RID: 119749
		private bool IsCanShowViewInner;

		// Token: 0x0401D3C6 RID: 119750
		protected bool IsCanShowViewFinally;
	}
}
