using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
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
	// Token: 0x020044C1 RID: 17601
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MarkItem : IWorldMapStreamingObject
	{
		// Token: 0x170058D4 RID: 22740
		// (get) Token: 0x0602C6DE RID: 181982 RVA: 0x00C7C8B9 File Offset: 0x00C7AAB9
		// (set) Token: 0x0602C6DF RID: 181983 RVA: 0x00C7C8C1 File Offset: 0x00C7AAC1
		public bool IsVisible { get; set; }

		// Token: 0x170058D5 RID: 22741
		// (get) Token: 0x0602C6E0 RID: 181984
		// (set) Token: 0x0602C6E1 RID: 181985
		public abstract int MarkId { get; set; }

		// Token: 0x170058D6 RID: 22742
		// (get) Token: 0x0602C6E2 RID: 181986
		public abstract EMarkType MarkType { get; }

		// Token: 0x170058D7 RID: 22743
		// (get) Token: 0x0602C6E3 RID: 181987 RVA: 0x00C7C8CA File Offset: 0x00C7AACA
		public virtual EMarkItemType MarkItemType
		{
			get
			{
				return EMarkItemType.Common;
			}
		}

		// Token: 0x170058D8 RID: 22744
		// (get) Token: 0x0602C6E4 RID: 181988 RVA: 0x00C7C8CD File Offset: 0x00C7AACD
		// (set) Token: 0x0602C6E5 RID: 181989 RVA: 0x00C7C8D5 File Offset: 0x00C7AAD5
		public EMapType MapType { get; set; }

		// Token: 0x170058D9 RID: 22745
		// (get) Token: 0x0602C6E6 RID: 181990 RVA: 0x00C7C8DE File Offset: 0x00C7AADE
		// (set) Token: 0x0602C6E7 RID: 181991 RVA: 0x00C7C8E6 File Offset: 0x00C7AAE6
		public int? EntityId { get; set; }

		// Token: 0x170058DA RID: 22746
		// (get) Token: 0x0602C6E8 RID: 181992 RVA: 0x00C7C8EF File Offset: 0x00C7AAEF
		public virtual EMapGravityDirection Gravity
		{
			get
			{
				return EMapGravityDirection.All;
			}
		}

		// Token: 0x170058DB RID: 22747
		// (get) Token: 0x0602C6E9 RID: 181993 RVA: 0x00C7C8F2 File Offset: 0x00C7AAF2
		public bool ShowGravityReverseIcon
		{
			get
			{
				return WorldMapModel.Instance.CanShowMarkGravityChildIcon(this.MarkId, this.Gravity);
			}
		}

		// Token: 0x170058DC RID: 22748
		// (get) Token: 0x0602C6EA RID: 181994 RVA: 0x00C7C90A File Offset: 0x00C7AB0A
		// (set) Token: 0x0602C6EB RID: 181995 RVA: 0x00C7C912 File Offset: 0x00C7AB12
		public int ShowPriority { get; set; }

		// Token: 0x170058DD RID: 22749
		// (get) Token: 0x0602C6EC RID: 181996 RVA: 0x00C7C91B File Offset: 0x00C7AB1B
		// (set) Token: 0x0602C6ED RID: 181997 RVA: 0x00C7C923 File Offset: 0x00C7AB23
		public bool IsDestroy { get; set; }

		// Token: 0x170058DE RID: 22750
		// (get) Token: 0x0602C6EE RID: 181998 RVA: 0x00C7C92C File Offset: 0x00C7AB2C
		// (set) Token: 0x0602C6EF RID: 181999 RVA: 0x00C7C934 File Offset: 0x00C7AB34
		public bool IsIgnoreScaleShow { get; set; }

		// Token: 0x170058DF RID: 22751
		// (get) Token: 0x0602C6F0 RID: 182000 RVA: 0x00C7C93D File Offset: 0x00C7AB3D
		// (set) Token: 0x0602C6F1 RID: 182001 RVA: 0x00C7C945 File Offset: 0x00C7AB45
		public float ConfigScale { get; set; } = 1f;

		// Token: 0x170058E0 RID: 22752
		// (get) Token: 0x0602C6F3 RID: 182003 RVA: 0x00C7C968 File Offset: 0x00C7AB68
		// (set) Token: 0x0602C6F2 RID: 182002 RVA: 0x00C7C94E File Offset: 0x00C7AB4E
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

		// Token: 0x170058E1 RID: 22753
		// (get) Token: 0x0602C6F4 RID: 182004 RVA: 0x00C7C970 File Offset: 0x00C7AB70
		// (set) Token: 0x0602C6F5 RID: 182005 RVA: 0x00C7C978 File Offset: 0x00C7AB78
		public global::Vector CornerScaleVector { get; private set; } = new global::Vector(1.0, 1.0, 1.0);

		// Token: 0x170058E2 RID: 22754
		// (get) Token: 0x0602C6F6 RID: 182006 RVA: 0x00C7C981 File Offset: 0x00C7AB81
		// (set) Token: 0x0602C6F7 RID: 182007 RVA: 0x00C7C989 File Offset: 0x00C7AB89
		public float TrackFxScale { get; set; } = 1f;

		// Token: 0x170058E3 RID: 22755
		// (get) Token: 0x0602C6F8 RID: 182008 RVA: 0x00C7C992 File Offset: 0x00C7AB92
		private bool IsTeleporting
		{
			get
			{
				return TeleportModel.Instance.IsTeleport;
			}
		}

		// Token: 0x170058E4 RID: 22756
		// (get) Token: 0x0602C6F9 RID: 182009 RVA: 0x00C7C99E File Offset: 0x00C7AB9E
		// (set) Token: 0x0602C6FA RID: 182010 RVA: 0x00C7C9A6 File Offset: 0x00C7ABA6
		public int GridId { get; set; }

		// Token: 0x170058E5 RID: 22757
		// (get) Token: 0x0602C6FB RID: 182011 RVA: 0x00C7C9AF File Offset: 0x00C7ABAF
		public virtual int MapId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170058E6 RID: 22758
		// (get) Token: 0x0602C6FC RID: 182012 RVA: 0x00C7C9B4 File Offset: 0x00C7ABB4
		public virtual int? InstanceDungeonId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058E7 RID: 22759
		// (get) Token: 0x0602C6FD RID: 182013 RVA: 0x00C7C9CA File Offset: 0x00C7ABCA
		public virtual int? RelativeInstanceDungeonId
		{
			get
			{
				return this.InstanceDungeonId;
			}
		}

		// Token: 0x170058E8 RID: 22760
		// (get) Token: 0x0602C6FE RID: 182014 RVA: 0x00C7C9D2 File Offset: 0x00C7ABD2
		public virtual int RelativeGamePlayId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170058E9 RID: 22761
		// (get) Token: 0x0602C6FF RID: 182015 RVA: 0x00C7C9D5 File Offset: 0x00C7ABD5
		public virtual bool IsRelativeLevelPlay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170058EA RID: 22762
		// (get) Token: 0x0602C700 RID: 182016 RVA: 0x00C7C9D8 File Offset: 0x00C7ABD8
		// (set) Token: 0x0602C701 RID: 182017 RVA: 0x00C7C9E0 File Offset: 0x00C7ABE0
		public bool HasRequestGamePlay { get; set; }

		// Token: 0x170058EB RID: 22763
		// (get) Token: 0x0602C702 RID: 182018 RVA: 0x00C7C9EC File Offset: 0x00C7ABEC
		public int InstanceDungeonOrMapConfigId
		{
			get
			{
				if ((this.InstanceDungeonId ?? 0) != 0)
				{
					return this.InstanceDungeonId.Value;
				}
				return this.MapId;
			}
		}

		// Token: 0x170058EC RID: 22764
		// (get) Token: 0x0602C703 RID: 182019 RVA: 0x00C7CA30 File Offset: 0x00C7AC30
		// (set) Token: 0x0602C704 RID: 182020 RVA: 0x00C7CA38 File Offset: 0x00C7AC38
		[Nullable(2)]
		public string NeedPlayShowOrHideSeq { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170058ED RID: 22765
		// (get) Token: 0x0602C705 RID: 182021 RVA: 0x00C7CA41 File Offset: 0x00C7AC41
		// (set) Token: 0x0602C706 RID: 182022 RVA: 0x00C7CA49 File Offset: 0x00C7AC49
		public bool NeedPlayStartSequence { get; set; }

		// Token: 0x170058EE RID: 22766
		// (get) Token: 0x0602C707 RID: 182023 RVA: 0x00C7CA52 File Offset: 0x00C7AC52
		public float MarkScale { get; }

		// Token: 0x170058EF RID: 22767
		// (get) Token: 0x0602C708 RID: 182024 RVA: 0x00C7CA5A File Offset: 0x00C7AC5A
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

		// Token: 0x170058F0 RID: 22768
		// (get) Token: 0x0602C709 RID: 182025 RVA: 0x00C7CA7C File Offset: 0x00C7AC7C
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

		// Token: 0x0602C70A RID: 182026 RVA: 0x00C7CA94 File Offset: 0x00C7AC94
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

		// Token: 0x0602C70B RID: 182027 RVA: 0x00C7CB52 File Offset: 0x00C7AD52
		public virtual bool IsMultiMap()
		{
			return false;
		}

		// Token: 0x0602C70C RID: 182028 RVA: 0x00C7CB55 File Offset: 0x00C7AD55
		public virtual bool LocateInGround()
		{
			return true;
		}

		// Token: 0x0602C70D RID: 182029 RVA: 0x00C7CB58 File Offset: 0x00C7AD58
		public virtual bool ConnectGround()
		{
			return true;
		}

		// Token: 0x0602C70E RID: 182030 RVA: 0x00C7CB5B File Offset: 0x00C7AD5B
		public virtual int GetMultiMapId()
		{
			return 0;
		}

		// Token: 0x0602C70F RID: 182031 RVA: 0x00C7CB5E File Offset: 0x00C7AD5E
		public virtual bool ShowSecondaryUiMultiMapIcon()
		{
			return this.IsMultiMap() && !this.LocateInGround();
		}

		// Token: 0x170058F1 RID: 22769
		// (get) Token: 0x0602C710 RID: 182032 RVA: 0x00C7CB73 File Offset: 0x00C7AD73
		// (set) Token: 0x0602C711 RID: 182033 RVA: 0x00C7CB7B File Offset: 0x00C7AD7B
		public bool IsSelectThisFloor { get; set; }

		// Token: 0x0602C712 RID: 182034 RVA: 0x00C7CB84 File Offset: 0x00C7AD84
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

		// Token: 0x0602C713 RID: 182035 RVA: 0x00C7CBD4 File Offset: 0x00C7ADD4
		protected bool InMultiMapArea(int multiMapId)
		{
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
			return MapConfig.Instance.IsAreaInSubMap(multiMapId, currentAreaId);
		}

		// Token: 0x0602C714 RID: 182036 RVA: 0x00C7CC01 File Offset: 0x00C7AE01
		private double VectorSquareDistance(global::Vector vector3D, Vector2D vector2D)
		{
			return Math.Pow(vector3D.X - vector2D.X, 2.0) + Math.Pow(vector3D.Y - vector2D.Y, 2.0);
		}

		// Token: 0x170058F2 RID: 22770
		// (get) Token: 0x0602C715 RID: 182037 RVA: 0x00C7CC3C File Offset: 0x00C7AE3C
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

		// Token: 0x0602C716 RID: 182038 RVA: 0x00C7CD78 File Offset: 0x00C7AF78
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

		// Token: 0x0602C717 RID: 182039 RVA: 0x00C7CE28 File Offset: 0x00C7B028
		public MarkItem(UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark)
		{
			this.MapType = mapType;
			this.MarkScale = markScale;
			this.InnerViewRoot = parent;
			this.TrackSourceInner = trackSource;
			this.UiPositionVector = null;
			this.WorldPositionVector = global::Vector.Create();
		}

		// Token: 0x170058F3 RID: 22771
		// (get) Token: 0x0602C718 RID: 182040 RVA: 0x00C7CF0B File Offset: 0x00C7B10B
		// (set) Token: 0x0602C719 RID: 182041 RVA: 0x00C7CF13 File Offset: 0x00C7B113
		public virtual bool IsStreaming { get; set; } = true;

		// Token: 0x0602C71A RID: 182042 RVA: 0x00C7CF1C File Offset: 0x00C7B11C
		public void OnLoad()
		{
		}

		// Token: 0x0602C71B RID: 182043 RVA: 0x00C7CF1E File Offset: 0x00C7B11E
		public void OnUnload()
		{
		}

		// Token: 0x0602C71C RID: 182044 RVA: 0x00C7CF20 File Offset: 0x00C7B120
		public Vector2D GetPreloadThreshold()
		{
			return this.PreloadThreshold;
		}

		// Token: 0x0602C71D RID: 182045 RVA: 0x00C7CF28 File Offset: 0x00C7B128
		public global::Vector GetUiPosition()
		{
			return this.UiPosition;
		}

		// Token: 0x0602C71E RID: 182046 RVA: 0x00C7CF30 File Offset: 0x00C7B130
		public void Initialize()
		{
			this.IsOutOfBound = false;
			this.IsInAoiRange = false;
			this.ShowMarkView = false;
			this.ShowMarkViewDirty = true;
			int instanceDungeonOrMapConfigId = this.InstanceDungeonOrMapConfigId;
			this.CachedDungeonMapConfigId = MapModel.Instance.GetDungeonMapConfigId(instanceDungeonOrMapConfigId);
			this.CachedDungeonLocateWorldMapId = MapModel.Instance.GetDungeonLocateWorldMapId(instanceDungeonOrMapConfigId);
			WorldMapConfig instance = WorldMapConfig.Instance;
			this.CachedIsBelongWorld = (instance != null && instance.IsMapInWorld(instanceDungeonOrMapConfigId));
			this.OnInitialize();
		}

		// Token: 0x0602C71F RID: 182047 RVA: 0x00C7CFA0 File Offset: 0x00C7B1A0
		protected virtual void OnInitialize()
		{
		}

		// Token: 0x0602C720 RID: 182048 RVA: 0x00C7CFA2 File Offset: 0x00C7B1A2
		public void SetTrackData(TTrackTarget trackTarget)
		{
			this.TrackTarget = trackTarget;
		}

		// Token: 0x0602C721 RID: 182049 RVA: 0x00C7CFAB File Offset: 0x00C7B1AB
		public void LogicUpdate(global::Vector playerLocation)
		{
			this.OnUpdate(playerLocation);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C722 RID: 182050 RVA: 0x00C7CFBC File Offset: 0x00C7B1BC
		public UniTask ViewUpdateAsync(global::Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			MarkItem.<ViewUpdateAsync>d__126 <ViewUpdateAsync>d__;
			<ViewUpdateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ViewUpdateAsync>d__.<>4__this = this;
			<ViewUpdateAsync>d__.playerLocation = playerLocation;
			<ViewUpdateAsync>d__.bDragging = bDragging;
			<ViewUpdateAsync>d__.bIsScale = bIsScale;
			<ViewUpdateAsync>d__.<>1__state = -1;
			<ViewUpdateAsync>d__.<>t__builder.Start<MarkItem.<ViewUpdateAsync>d__126>(ref <ViewUpdateAsync>d__);
			return <ViewUpdateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C723 RID: 182051 RVA: 0x00C7D018 File Offset: 0x00C7B218
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
			this.InnerViewRoot = null;
		}

		// Token: 0x170058F4 RID: 22772
		// (get) Token: 0x0602C724 RID: 182052 RVA: 0x00C7D0E4 File Offset: 0x00C7B2E4
		// (set) Token: 0x0602C725 RID: 182053 RVA: 0x00C7D0EC File Offset: 0x00C7B2EC
		public bool IsInAoiRange { get; set; }

		// Token: 0x0602C726 RID: 182054
		protected abstract MarkItemView CreateView();

		// Token: 0x0602C727 RID: 182055
		protected abstract EMarkItemViewType GetMarkItemViewType();

		// Token: 0x0602C728 RID: 182056 RVA: 0x00C7D0F8 File Offset: 0x00C7B2F8
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

		// Token: 0x0602C729 RID: 182057 RVA: 0x00C7D180 File Offset: 0x00C7B380
		private UniTask InitInnerViewAsync(MarkItemView view)
		{
			MarkItem.<InitInnerViewAsync>d__135 <InitInnerViewAsync>d__;
			<InitInnerViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitInnerViewAsync>d__.<>4__this = this;
			<InitInnerViewAsync>d__.view = view;
			<InitInnerViewAsync>d__.<>1__state = -1;
			<InitInnerViewAsync>d__.<>t__builder.Start<MarkItem.<InitInnerViewAsync>d__135>(ref <InitInnerViewAsync>d__);
			return <InitInnerViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C72A RID: 182058 RVA: 0x00C7D1CC File Offset: 0x00C7B3CC
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
				this.View.InitializeData(this);
				this.View.InitializeView();
				this.View.RefreshView();
			}
		}

		// Token: 0x0602C72B RID: 182059 RVA: 0x00C7D228 File Offset: 0x00C7B428
		private void RecycleView(bool recycleToPoolImmediately = false)
		{
			if (this.View == null)
			{
				return;
			}
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

		// Token: 0x170058F5 RID: 22773
		// (get) Token: 0x0602C72C RID: 182060 RVA: 0x00C7D2BC File Offset: 0x00C7B4BC
		// (set) Token: 0x0602C72D RID: 182061 RVA: 0x00C7D2C4 File Offset: 0x00C7B4C4
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

		// Token: 0x170058F6 RID: 22774
		// (get) Token: 0x0602C72E RID: 182062 RVA: 0x00C7D2E4 File Offset: 0x00C7B4E4
		public virtual int? TrackAreaId
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0602C72F RID: 182063 RVA: 0x00C7D2FC File Offset: 0x00C7B4FC
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

		// Token: 0x170058F7 RID: 22775
		// (get) Token: 0x0602C730 RID: 182064 RVA: 0x00C7D351 File Offset: 0x00C7B551
		public ETrackSource TrackSource
		{
			get
			{
				return this.TrackSourceInner;
			}
		}

		// Token: 0x170058F8 RID: 22776
		// (get) Token: 0x0602C731 RID: 182065 RVA: 0x00C7D359 File Offset: 0x00C7B559
		// (set) Token: 0x0602C732 RID: 182066 RVA: 0x00C7D361 File Offset: 0x00C7B561
		public bool IsTracked { get; private set; }

		// Token: 0x170058F9 RID: 22777
		// (get) Token: 0x0602C733 RID: 182067 RVA: 0x00C7D36A File Offset: 0x00C7B56A
		// (set) Token: 0x0602C734 RID: 182068 RVA: 0x00C7D372 File Offset: 0x00C7B572
		public bool IsAutoPilotTracked { get; private set; }

		// Token: 0x170058FA RID: 22778
		// (get) Token: 0x0602C735 RID: 182069 RVA: 0x00C7D37B File Offset: 0x00C7B57B
		public virtual bool PermanentUpdate
		{
			get
			{
				return this.IsTracked || this.IsSelected || MarkDefine.PermanentUpdateTypeSet.Contains(this.MarkType);
			}
		}

		// Token: 0x170058FB RID: 22779
		// (get) Token: 0x0602C736 RID: 182070 RVA: 0x00C7D39F File Offset: 0x00C7B59F
		public bool CanOutOfBound
		{
			get
			{
				return this.IsTracked || MarkDefine.CanOutOfBoundUpdateTypeSet.Contains(this.MarkType);
			}
		}

		// Token: 0x0602C737 RID: 182071 RVA: 0x00C7D3BC File Offset: 0x00C7B5BC
		protected virtual void UpdateVisibleRelativeState()
		{
			EMapType mapType = this.MapType;
			bool flag = !this.IsInConsistentDistrict(false);
			bool isSelected = this.IsSelected;
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
			bool showMarkView;
			if (!flag6 || !flag)
			{
				showMarkView = false;
			}
			else
			{
				if (mapType != EMapType.MiniMap || flag2)
				{
					this.IsInAoiRange = true;
				}
				showMarkView = (flag2 || this.IsInAoiRange);
			}
			showMarkView = this.CheckExtraUiMarkVisible(showMarkView, mapType, markId);
			this.SetShowMarkView(showMarkView);
		}

		// Token: 0x0602C738 RID: 182072 RVA: 0x00C7D4C4 File Offset: 0x00C7B6C4
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

		// Token: 0x0602C739 RID: 182073 RVA: 0x00C7D536 File Offset: 0x00C7B736
		public void CreateOrCycleView()
		{
			if (!this.ShowMarkViewDirty)
			{
				return;
			}
			bool showMarkView = this.ShowMarkView;
			this.CleanShowMarkViewDirty();
			if (showMarkView)
			{
				this.ShowView();
				return;
			}
			this.RecycleView(false);
		}

		// Token: 0x0602C73A RID: 182074 RVA: 0x00C7D55D File Offset: 0x00C7B75D
		protected virtual bool IsTempMapMarkShow()
		{
			return this.MapType != EMapType.MiniMap || !this.IsTempMapMark || this.IsTracked;
		}

		// Token: 0x0602C73B RID: 182075 RVA: 0x00C7D578 File Offset: 0x00C7B778
		protected virtual bool IsTracking()
		{
			return TrackModel.Instance.IsTracking(this.TrackSource, this.MarkId);
		}

		// Token: 0x0602C73C RID: 182076 RVA: 0x00C7D590 File Offset: 0x00C7B790
		protected virtual void OnUpdate(global::Vector playerLocation)
		{
		}

		// Token: 0x0602C73D RID: 182077 RVA: 0x00C7D592 File Offset: 0x00C7B792
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x170058FC RID: 22780
		// (get) Token: 0x0602C73E RID: 182078 RVA: 0x00C7D594 File Offset: 0x00C7B794
		[Nullable(2)]
		public UUIItem ViewRoot
		{
			[NullableContext(2)]
			get
			{
				return this.InnerViewRoot;
			}
		}

		// Token: 0x170058FD RID: 22781
		// (get) Token: 0x0602C73F RID: 182079 RVA: 0x00C7D59C File Offset: 0x00C7B79C
		// (set) Token: 0x0602C740 RID: 182080 RVA: 0x00C7D5A4 File Offset: 0x00C7B7A4
		[Nullable(2)]
		public MarkItemView View { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170058FE RID: 22782
		// (get) Token: 0x0602C741 RID: 182081 RVA: 0x00C7D5AD File Offset: 0x00C7B7AD
		// (set) Token: 0x0602C742 RID: 182082 RVA: 0x00C7D5B5 File Offset: 0x00C7B7B5
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

		// Token: 0x170058FF RID: 22783
		// (get) Token: 0x0602C743 RID: 182083 RVA: 0x00C7D5CD File Offset: 0x00C7B7CD
		public virtual bool EnableVerticalPointer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17005900 RID: 22784
		// (get) Token: 0x0602C744 RID: 182084 RVA: 0x00C7D5D0 File Offset: 0x00C7B7D0
		// (set) Token: 0x0602C745 RID: 182085 RVA: 0x00C7D5D8 File Offset: 0x00C7B7D8
		public bool ShowMarkView { get; private set; }

		// Token: 0x17005901 RID: 22785
		// (get) Token: 0x0602C746 RID: 182086 RVA: 0x00C7D5E1 File Offset: 0x00C7B7E1
		// (set) Token: 0x0602C747 RID: 182087 RVA: 0x00C7D5E9 File Offset: 0x00C7B7E9
		public bool ShowMarkViewDirty { get; private set; } = true;

		// Token: 0x0602C748 RID: 182088 RVA: 0x00C7D5F2 File Offset: 0x00C7B7F2
		public void SetShowMarkView(bool value)
		{
			if (this.ShowMarkView == value)
			{
				return;
			}
			this.ShowMarkView = value;
			this.ShowMarkViewDirty = true;
		}

		// Token: 0x0602C749 RID: 182089 RVA: 0x00C7D60C File Offset: 0x00C7B80C
		private void CleanShowMarkViewDirty()
		{
			this.ShowMarkViewDirty = false;
		}

		// Token: 0x0602C74A RID: 182090 RVA: 0x00C7D615 File Offset: 0x00C7B815
		public void SetOutOfBoundDirection(Vector2D direction)
		{
			this.OutOfBoundDirection = direction;
			this.IsOutOfBoundDirectionDirty = true;
		}

		// Token: 0x17005902 RID: 22786
		// (get) Token: 0x0602C74B RID: 182091 RVA: 0x00C7D625 File Offset: 0x00C7B825
		// (set) Token: 0x0602C74C RID: 182092 RVA: 0x00C7D630 File Offset: 0x00C7B830
		public bool IsOutOfBound
		{
			get
			{
				return this._isOutOfBoundInner;
			}
			set
			{
				this._isOutOfBoundInner = value;
				MarkItemView view = this.View;
				if (view != null && view.IsViewReady)
				{
					this.View.ApplyOutOfBoundActive(value);
				}
			}
		}

		// Token: 0x17005903 RID: 22787
		// (get) Token: 0x0602C74D RID: 182093 RVA: 0x00C7D662 File Offset: 0x00C7B862
		// (set) Token: 0x0602C74E RID: 182094 RVA: 0x00C7D66A File Offset: 0x00C7B86A
		public bool IsSelected { get; private set; }

		// Token: 0x0602C74F RID: 182095 RVA: 0x00C7D673 File Offset: 0x00C7B873
		public void SetSelected(bool value)
		{
			if (this.IsSelected == value)
			{
				return;
			}
			this.IsSelected = value;
			if (this.View == null || this.IsDestroy)
			{
				return;
			}
			this.View.NotifySelectedChanged(value);
		}

		// Token: 0x0602C750 RID: 182096 RVA: 0x00C7D6A3 File Offset: 0x00C7B8A3
		public bool IsViewReady()
		{
			return this.View != null && !this.View.IsCreating;
		}

		// Token: 0x0602C751 RID: 182097 RVA: 0x00C7D6BD File Offset: 0x00C7B8BD
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

		// Token: 0x0602C752 RID: 182098 RVA: 0x00C7D6DC File Offset: 0x00C7B8DC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UUIItem> GetRootItemAsync()
		{
			MarkItem.<GetRootItemAsync>d__210 <GetRootItemAsync>d__;
			<GetRootItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UUIItem>.Create();
			<GetRootItemAsync>d__.<>4__this = this;
			<GetRootItemAsync>d__.<>1__state = -1;
			<GetRootItemAsync>d__.<>t__builder.Start<MarkItem.<GetRootItemAsync>d__210>(ref <GetRootItemAsync>d__);
			return <GetRootItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C753 RID: 182099 RVA: 0x00C7D71F File Offset: 0x00C7B91F
		[NullableContext(2)]
		public virtual string GetTitleText()
		{
			return null;
		}

		// Token: 0x0602C754 RID: 182100 RVA: 0x00C7D724 File Offset: 0x00C7B924
		public virtual void SetTitleText(UUIText uiText)
		{
			string titleText = this.GetTitleText();
			if (!string.IsNullOrEmpty(titleText))
			{
				uiText.SetText(titleText, true);
			}
		}

		// Token: 0x0602C755 RID: 182101 RVA: 0x00C7D748 File Offset: 0x00C7B948
		[NullableContext(2)]
		public virtual string GetStateIconPath()
		{
			if (this.IsMultiMap() && (!this.LocateInGround() || !this.IsSelectThisFloor))
			{
				return UiResourceConfig.Instance.GetResourcePath(this.IsSelectThisFloor ? "SP_MarkMultiMapSelect" : "SP_MarkMultiMap") ?? string.Empty;
			}
			return null;
		}

		// Token: 0x0602C756 RID: 182102 RVA: 0x00C7D799 File Offset: 0x00C7B999
		[NullableContext(2)]
		public virtual string GetLocaleDesc()
		{
			return null;
		}

		// Token: 0x0602C757 RID: 182103 RVA: 0x00C7D79C File Offset: 0x00C7B99C
		protected void SetConfigScale(float scale)
		{
			this.ConfigScale = scale;
		}

		// Token: 0x0602C758 RID: 182104 RVA: 0x00C7D7A5 File Offset: 0x00C7B9A5
		protected void SetCornerScale(float cornerScale)
		{
			this.CornerScale = cornerScale;
		}

		// Token: 0x17005904 RID: 22788
		// (get) Token: 0x0602C759 RID: 182105 RVA: 0x00C7D7AE File Offset: 0x00C7B9AE
		private bool IsCanShowViewExtra
		{
			get
			{
				return MapModel.Instance.GetMarkForceVisible(this.MarkType, this.MarkId);
			}
		}

		// Token: 0x17005905 RID: 22789
		// (get) Token: 0x0602C75A RID: 182106 RVA: 0x00C7D7C6 File Offset: 0x00C7B9C6
		protected bool IsCanShowViewIntermediately
		{
			get
			{
				return this.IsCanShowViewInner && this.IsCanShowViewExtra;
			}
		}

		// Token: 0x17005906 RID: 22790
		// (get) Token: 0x0602C75B RID: 182107 RVA: 0x00C7D7D8 File Offset: 0x00C7B9D8
		// (set) Token: 0x0602C75C RID: 182108 RVA: 0x00C7D7EA File Offset: 0x00C7B9EA
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

		// Token: 0x0602C75D RID: 182109 RVA: 0x00C7D7F3 File Offset: 0x00C7B9F3
		public virtual bool CheckCanShowView()
		{
			return this.MapType == EMapType.WorldMap;
		}

		// Token: 0x0602C75E RID: 182110 RVA: 0x00C7D800 File Offset: 0x00C7BA00
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

		// Token: 0x0602C75F RID: 182111 RVA: 0x00C7D8E3 File Offset: 0x00C7BAE3
		public virtual bool CheckCanShowViewInExtraUi()
		{
			return true;
		}

		// Token: 0x0602C760 RID: 182112 RVA: 0x00C7D8E8 File Offset: 0x00C7BAE8
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

		// Token: 0x0602C761 RID: 182113 RVA: 0x00C7DA18 File Offset: 0x00C7BC18
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

		// Token: 0x0602C762 RID: 182114 RVA: 0x00C7DA7C File Offset: 0x00C7BC7C
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

		// Token: 0x0602C763 RID: 182115 RVA: 0x00C7DAE0 File Offset: 0x00C7BCE0
		private bool IsInConsistentDungeon()
		{
			int? instanceDungeonId = this.InstanceDungeonId;
			int currentWorldMapInstanceId = WorldMapModel.Instance.CurrentWorldMapInstanceId;
			return !(instanceDungeonId.GetValueOrDefault() == currentWorldMapInstanceId & instanceDungeonId != null);
		}

		// Token: 0x0602C764 RID: 182116 RVA: 0x00C7DB14 File Offset: 0x00C7BD14
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

		// Token: 0x0602C765 RID: 182117 RVA: 0x00C7DB90 File Offset: 0x00C7BD90
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

		// Token: 0x0602C766 RID: 182118 RVA: 0x00C7DBF4 File Offset: 0x00C7BDF4
		protected bool CheckCanShowInGravityLayer(bool isTracking)
		{
			return isTracking || MarkDefine.PermanentShowInGravityLayerTypeSet.Contains(this.MarkType) || WorldMapModel.Instance.IsMarkInGravityLayer(this.MarkId, this.Gravity);
		}

		// Token: 0x0602C767 RID: 182119 RVA: 0x00C7DC24 File Offset: 0x00C7BE24
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

		// Token: 0x0602C768 RID: 182120 RVA: 0x00C7DCD8 File Offset: 0x00C7BED8
		public virtual float GetShowScale()
		{
			float currentMapShowScale = this.GetCurrentMapShowScale();
			return Math.Max(0f, currentMapShowScale);
		}

		// Token: 0x0602C769 RID: 182121 RVA: 0x00C7DCF7 File Offset: 0x00C7BEF7
		protected virtual float GetCurrentMapShowScale()
		{
			return WorldMapModel.Instance.MapScale * 100f - 100f;
		}

		// Token: 0x0602C76A RID: 182122 RVA: 0x00C7DD0F File Offset: 0x00C7BF0F
		public void OnLevelSequenceStart(string sequenceName)
		{
			if (sequenceName == "ShowView" || sequenceName == "HideView")
			{
				this.IsCanShowViewFinally = true;
			}
		}

		// Token: 0x0602C76B RID: 182123 RVA: 0x00C7DD32 File Offset: 0x00C7BF32
		public void OnLevelSequenceStop(string sequenceName)
		{
			if (sequenceName == "ShowView" || sequenceName == "HideView")
			{
				this.IsCanShowViewFinally = false;
			}
		}

		// Token: 0x0602C76C RID: 182124 RVA: 0x00C7DD55 File Offset: 0x00C7BF55
		public virtual bool GetInteractiveFlag()
		{
			return this.IsCanShowView;
		}

		// Token: 0x0602C76D RID: 182125 RVA: 0x00C7DD5D File Offset: 0x00C7BF5D
		public virtual bool GamePlayIsDiscover()
		{
			return false;
		}

		// Token: 0x0602C76E RID: 182126 RVA: 0x00C7DD60 File Offset: 0x00C7BF60
		protected virtual bool IsGamePlayFinishRaw()
		{
			return false;
		}

		// Token: 0x0602C76F RID: 182127 RVA: 0x00C7DD63 File Offset: 0x00C7BF63
		public virtual bool IsMarkDisabled()
		{
			return false;
		}

		// Token: 0x0602C770 RID: 182128 RVA: 0x00C7DD68 File Offset: 0x00C7BF68
		[NullableContext(2)]
		public virtual string GetMarkHideReason()
		{
			return MapModel.Instance.GetMarkHideReason(this.MapId, this.EntityId.GetValueOrDefault());
		}

		// Token: 0x17005907 RID: 22791
		// (get) Token: 0x0602C771 RID: 182129 RVA: 0x00C7DD93 File Offset: 0x00C7BF93
		public virtual bool IsGamePlayFinishWithReward
		{
			get
			{
				return this.IsGamePlayFinishRaw();
			}
		}

		// Token: 0x0602C772 RID: 182130 RVA: 0x00C7DD9B File Offset: 0x00C7BF9B
		protected virtual bool IsGamePlayFinish()
		{
			return this.IsGamePlayFinishWithReward;
		}

		// Token: 0x0602C773 RID: 182131 RVA: 0x00C7DDA3 File Offset: 0x00C7BFA3
		public virtual ESecondaryPanel GetSecondaryUiType()
		{
			return WorldMapSecondaryUiDefine.MarkPanelTypeMap.GetValueOrDefault(this.MarkType, ESecondaryPanel.GeneralPanel);
		}

		// Token: 0x0602C774 RID: 182132 RVA: 0x00C7DDB6 File Offset: 0x00C7BFB6
		public bool GetIsStrictConfigMark()
		{
			return this is ConfigMarkItem;
		}

		// Token: 0x04017E23 RID: 97827
		[Nullable(2)]
		public IMarkConfig Config;

		// Token: 0x04017E24 RID: 97828
		public bool IsTempMapMark;

		// Token: 0x04017E29 RID: 97833
		private float CornerScaleInner = 1f;

		// Token: 0x04017E2C RID: 97836
		[Nullable(2)]
		private global::Vector UiPositionVector;

		// Token: 0x04017E2D RID: 97837
		[Nullable(2)]
		private global::Vector WorldPositionVector;

		// Token: 0x04017E2E RID: 97838
		private readonly Vector2D PreloadThreshold = Vector2D.Create(0.0, 0.0);

		// Token: 0x04017E30 RID: 97840
		private int CachedDungeonMapConfigId;

		// Token: 0x04017E31 RID: 97841
		private int? CachedDungeonLocateWorldMapId;

		// Token: 0x04017E32 RID: 97842
		private bool CachedIsBelongWorld;

		// Token: 0x04017E37 RID: 97847
		[Nullable(2)]
		private global::Vector AnchorOffsetVector;

		// Token: 0x04017E3B RID: 97851
		[Nullable(2)]
		private TTrackTarget TrackTargetInner;

		// Token: 0x04017E3C RID: 97852
		protected bool EnableCachePosition = true;

		// Token: 0x04017E3D RID: 97853
		private ETrackSource TrackSourceInner = ETrackSource.Instance;

		// Token: 0x04017E40 RID: 97856
		[Nullable(2)]
		private UUIItem InnerViewRoot;

		// Token: 0x04017E42 RID: 97858
		private string Icon = string.Empty;

		// Token: 0x04017E43 RID: 97859
		public string TopRightIconPath = string.Empty;

		// Token: 0x04017E44 RID: 97860
		public bool ShowTopRightIcon;

		// Token: 0x04017E45 RID: 97861
		public string ChildIconPath = string.Empty;

		// Token: 0x04017E46 RID: 97862
		public bool ShowChildIcon;

		// Token: 0x04017E47 RID: 97863
		public float RangeSize;

		// Token: 0x04017E4A RID: 97866
		[Nullable(2)]
		public Vector2D OutOfBoundDirection;

		// Token: 0x04017E4B RID: 97867
		public bool IsOutOfBoundDirectionDirty;

		// Token: 0x04017E4C RID: 97868
		private bool _isOutOfBoundInner;

		// Token: 0x04017E4E RID: 97870
		private bool IsCanShowViewInner;

		// Token: 0x04017E4F RID: 97871
		protected bool IsCanShowViewFinally;
	}
}
