using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054E0 RID: 21728
	[NullableContext(1)]
	[Nullable(0)]
	public class EnrichmentAreaItem : ServerMarkItem
	{
		// Token: 0x17008533 RID: 34099
		// (get) Token: 0x060377A5 RID: 227237 RVA: 0x00D2D58E File Offset: 0x00D2B78E
		// (set) Token: 0x060377A6 RID: 227238 RVA: 0x00D2D59B File Offset: 0x00D2B79B
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

		// Token: 0x17008534 RID: 34100
		// (get) Token: 0x060377A7 RID: 227239 RVA: 0x00D2D5AC File Offset: 0x00D2B7AC
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

		// Token: 0x17008535 RID: 34101
		// (get) Token: 0x060377A8 RID: 227240 RVA: 0x00D2D5EA File Offset: 0x00D2B7EA
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.EnrichmentArea;
			}
		}

		// Token: 0x17008536 RID: 34102
		// (get) Token: 0x060377A9 RID: 227241 RVA: 0x00D2D5F0 File Offset: 0x00D2B7F0
		public override int MapId
		{
			get
			{
				return this.EnrichmentAreaConf.LevelId;
			}
		}

		// Token: 0x17008537 RID: 34103
		// (get) Token: 0x060377AA RID: 227242 RVA: 0x00D2D60B File Offset: 0x00D2B80B
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x060377AB RID: 227243 RVA: 0x00D2D618 File Offset: 0x00D2B818
		public EnrichmentAreaItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x060377AC RID: 227244 RVA: 0x00D2D625 File Offset: 0x00D2B825
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.EnrichmentAreaItemView;
		}

		// Token: 0x060377AD RID: 227245 RVA: 0x00D2D628 File Offset: 0x00D2B828
		[PreserveBaseOverrides]
		protected new virtual EnrichmentAreaItemView CreateView()
		{
			return new EnrichmentAreaItemView(this);
		}

		// Token: 0x060377AE RID: 227246 RVA: 0x00D2D630 File Offset: 0x00D2B830
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
				base.MarkItemEntity.GetComponent<MarkResourceComponent>(EMapComponent.MarkResource).RangeSize = cacheEnrichmentAreaWorldMapCircle2.R + value2;
				base.SetTrackData(value);
			}
			int configId = 5;
			this.SetConfigId(configId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x060377AF RID: 227247 RVA: 0x00D2D814 File Offset: 0x00D2BA14
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x060377B0 RID: 227248 RVA: 0x00D2D820 File Offset: 0x00D2BA20
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

		// Token: 0x060377B1 RID: 227249 RVA: 0x00D2D8A8 File Offset: 0x00D2BAA8
		public string GetEnrichmentItemNameId()
		{
			return ItemConfig.Instance.GetConfig(this.EnrichmentAreaConf.ItemId).Value.Name;
		}

		// Token: 0x060377B2 RID: 227250 RVA: 0x00D2D8E0 File Offset: 0x00D2BAE0
		public bool CheckCanShowIcon()
		{
			EMapType mapType = base.MapType;
			if ((this.MarkConfig.MapShow == 1 && mapType != EMapType.MiniMap) || (this.MarkConfig.MapShow == 2 && mapType == EMapType.MiniMap))
			{
				return this.IsTracking();
			}
			return base.CheckCanShowView();
		}

		// Token: 0x060377B3 RID: 227251 RVA: 0x00D2D92C File Offset: 0x00D2BB2C
		public override void SetTitleText(UUIText uiText)
		{
			string markTitle = this.MarkConfig.MarkTitle;
			string localText = MapConfig.Instance.GetLocalText(this.GetEnrichmentItemNameId());
			LguiUtil.Instance.SetLocalTextNew(uiText, markTitle, new <>z__ReadOnlySingleElementList<object>(localText));
		}

		// Token: 0x0401D39C RID: 119708
		private MapMark? MarkConfigInternal;

		// Token: 0x0401D39D RID: 119709
		private EnrichmentAreaConfig? EnrichmentAreaConfInner;
	}
}
