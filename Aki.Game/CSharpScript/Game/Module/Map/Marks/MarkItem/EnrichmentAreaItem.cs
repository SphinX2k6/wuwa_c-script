using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B3 RID: 17587
	[NullableContext(1)]
	[Nullable(0)]
	public class EnrichmentAreaItem : ServerMarkItem
	{
		// Token: 0x170058C0 RID: 22720
		// (get) Token: 0x0602C660 RID: 181856 RVA: 0x00C7B67A File Offset: 0x00C7987A
		// (set) Token: 0x0602C661 RID: 181857 RVA: 0x00C7B687 File Offset: 0x00C79887
		public MapMark MarkConfig
		{
			get
			{
				return this.MarkConfigInternal.Value;
			}
			set
			{
				this.MarkConfigInternal = new MapMark?(value);
			}
		}

		// Token: 0x170058C1 RID: 22721
		// (get) Token: 0x0602C662 RID: 181858 RVA: 0x00C7B698 File Offset: 0x00C79898
		public EnrichmentAreaConfig EnrichmentAreaConf
		{
			get
			{
				EnrichmentAreaConfig? enrichmentAreaConfInner = this.EnrichmentAreaConfInner;
				if (enrichmentAreaConfInner == null)
				{
					this.EnrichmentAreaConfInner = MapConfig.Instance.GetEnrichmentAreaConfigByEnrichmentId(base.EntityConfigId);
				}
				return this.EnrichmentAreaConfInner.Value;
			}
		}

		// Token: 0x170058C2 RID: 22722
		// (get) Token: 0x0602C663 RID: 181859 RVA: 0x00C7B6D6 File Offset: 0x00C798D6
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.EnrichmentArea;
			}
		}

		// Token: 0x170058C3 RID: 22723
		// (get) Token: 0x0602C664 RID: 181860 RVA: 0x00C7B6DC File Offset: 0x00C798DC
		public override int MapId
		{
			get
			{
				return this.EnrichmentAreaConf.LevelId;
			}
		}

		// Token: 0x170058C4 RID: 22724
		// (get) Token: 0x0602C665 RID: 181861 RVA: 0x00C7B6F7 File Offset: 0x00C798F7
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x170058C5 RID: 22725
		// (get) Token: 0x0602C666 RID: 181862 RVA: 0x00C7B704 File Offset: 0x00C79904
		public override bool EnableVerticalPointer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602C667 RID: 181863 RVA: 0x00C7B707 File Offset: 0x00C79907
		public EnrichmentAreaItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C668 RID: 181864 RVA: 0x00C7B714 File Offset: 0x00C79914
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.EnrichmentAreaItemView;
		}

		// Token: 0x0602C669 RID: 181865 RVA: 0x00C7B717 File Offset: 0x00C79917
		[PreserveBaseOverrides]
		protected new virtual EnrichmentAreaItemView CreateView()
		{
			return new EnrichmentAreaItemView(this);
		}

		// Token: 0x0602C66A RID: 181866 RVA: 0x00C7B720 File Offset: 0x00C79920
		protected unsafe override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			int cacheEnrichmentAreaEntityId = MapModel.Instance.CacheEnrichmentAreaEntityId;
			int? entityConfigId = serverMarkInfo.EntityConfigId;
			if (!(cacheEnrichmentAreaEntityId == entityConfigId.GetValueOrDefault() & entityConfigId != null))
			{
				int[] array = this.EnrichmentAreaConf.EntityIds();
				if (array != null)
				{
					List<Vector2D> list = new List<Vector2D>();
					foreach (int num in array)
					{
						global::Vector entityPositionByConfig = MapUtil.GetEntityPositionByConfig(num, this.MapId, null);
						if (entityPositionByConfig.Equality(global::Vector.ZeroVectorProxy))
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Map;
							ELogAuthor author = ELogAuthor.LRX;
							string message = "[地图系统]_富集区标记->采集物实体坐标异常，请检查配置";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("富集区Id", serverMarkInfo.EntityConfigId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("采集物Id", num);
							instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
						else
						{
							global::Vector vector = MapUtil.WorldPosition2UiPosition(entityPositionByConfig, null);
							list.Add(Vector2D.Create(vector.X, vector.Y));
						}
					}
					Circle cacheEnrichmentAreaWorldMapCircle = MapUtil.FindMinCircle(list);
					MapModel.Instance.CacheEnrichmentAreaWorldMapCircle = cacheEnrichmentAreaWorldMapCircle;
				}
				MapModel.Instance.CacheEnrichmentAreaEntityId = serverMarkInfo.EntityConfigId.GetValueOrDefault();
			}
			Circle cacheEnrichmentAreaWorldMapCircle2 = MapModel.Instance.CacheEnrichmentAreaWorldMapCircle;
			if (cacheEnrichmentAreaWorldMapCircle2 != null)
			{
				global::Vector value = MapUtil.UiPosition2WorldPosition(global::Vector.Create((double)cacheEnrichmentAreaWorldMapCircle2.X, (double)cacheEnrichmentAreaWorldMapCircle2.Y, 0.0), null);
				float value2 = ConfigCommonParamById.GetFloatConfig("RichZoneExtraRadius").Value;
				this.RangeSize = cacheEnrichmentAreaWorldMapCircle2.R + value2;
				base.SetTrackData(value);
			}
			int configId = 5;
			this.SetConfigId(configId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C66B RID: 181867 RVA: 0x00C7B8F8 File Offset: 0x00C79AF8
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C66C RID: 181868 RVA: 0x00C7B904 File Offset: 0x00C79B04
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.MarkConfigInternal = new MapMark?(value);
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = value.ShowRange(),
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
		}

		// Token: 0x0602C66D RID: 181869 RVA: 0x00C7B98C File Offset: 0x00C79B8C
		public string GetEnrichmentItemNameId()
		{
			return ItemConfig.Instance.GetConfig(this.EnrichmentAreaConf.ItemId).Value.Name;
		}

		// Token: 0x0602C66E RID: 181870 RVA: 0x00C7B9C4 File Offset: 0x00C79BC4
		public bool CheckCanShowIcon()
		{
			EMapType mapType = base.MapType;
			if ((this.MarkConfig.MapShow == 1 && mapType != EMapType.MiniMap) || (this.MarkConfig.MapShow == 2 && mapType == EMapType.MiniMap))
			{
				return this.IsTracking();
			}
			return base.CheckCanShowView();
		}

		// Token: 0x0602C66F RID: 181871 RVA: 0x00C7BA10 File Offset: 0x00C79C10
		public override void SetTitleText(UUIText uiText)
		{
			string markTitle = this.MarkConfig.MarkTitle;
			string localText = MapConfig.Instance.GetLocalText(this.GetEnrichmentItemNameId());
			LguiUtil.Instance.SetLocalTextNew(uiText, markTitle, new <>z__ReadOnlySingleElementList<object>(localText));
		}

		// Token: 0x04017E18 RID: 97816
		private MapMark? MarkConfigInternal;

		// Token: 0x04017E19 RID: 97817
		private EnrichmentAreaConfig? EnrichmentAreaConfInner;
	}
}
