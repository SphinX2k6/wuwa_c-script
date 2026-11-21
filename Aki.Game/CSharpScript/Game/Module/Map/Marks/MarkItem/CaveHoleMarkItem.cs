using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044AB RID: 17579
	[NullableContext(1)]
	[Nullable(0)]
	public class CaveHoleMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C5DE RID: 181726 RVA: 0x00C79B28 File Offset: 0x00C77D28
		public CaveHoleMarkItem(int markId, MapMark config, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, config, parent, mapType, markScale, new ETrackSource?((config.InstanceDungeonId != 0) ? ETrackSource.Instance : trackSource))
		{
		}

		// Token: 0x0602C5DF RID: 181727 RVA: 0x00C79B4A File Offset: 0x00C77D4A
		protected override void OnInitialize()
		{
			this.UpdateMultiMapFloorSelectedState();
			base.OnInitialize();
		}

		// Token: 0x0602C5E0 RID: 181728 RVA: 0x00C79B58 File Offset: 0x00C77D58
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.CaveHoleMarkItemView;
		}

		// Token: 0x0602C5E1 RID: 181729 RVA: 0x00C79B5B File Offset: 0x00C77D5B
		protected override MarkItemView CreateView()
		{
			return new CaveHoleMarkItemView(this);
		}

		// Token: 0x0602C5E2 RID: 181730 RVA: 0x00C79B63 File Offset: 0x00C77D63
		public override bool IsMarkDisabled()
		{
			return false;
		}

		// Token: 0x0602C5E3 RID: 181731 RVA: 0x00C79B68 File Offset: 0x00C77D68
		public override bool CheckCanShowView()
		{
			bool flag = base.CheckCanShowView();
			if (this.IsMultiMap())
			{
				int multiMapId = this.GetMultiMapId();
				Span<int> connectMultiMapIds = base.GetConnectMultiMapIds();
				bool flag2 = this.ConnectGround();
				int? worldMapCurrentMultiMapId = WorldMapModel.Instance.WorldMapCurrentMultiMapId;
				bool flag3;
				if (!flag2)
				{
					int num = multiMapId;
					int? num2 = worldMapCurrentMultiMapId;
					if (!(num == num2.GetValueOrDefault() & num2 != null))
					{
						flag3 = connectMultiMapIds.Contains(worldMapCurrentMultiMapId.GetValueOrDefault());
						goto IL_57;
					}
				}
				flag3 = true;
				IL_57:
				bool flag4 = flag3;
				return flag && flag4;
			}
			return flag;
		}

		// Token: 0x0602C5E4 RID: 181732 RVA: 0x00C79BD4 File Offset: 0x00C77DD4
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.UpdateMultiMapFloorSelectedState();
			}
		}

		// Token: 0x0602C5E5 RID: 181733 RVA: 0x00C79BEC File Offset: 0x00C77DEC
		public override bool GetIsSelectThisFloor()
		{
			if (!this.IsMultiMap())
			{
				return this.LocateInGround();
			}
			int multiMapId = this.GetMultiMapId();
			int multiMapFloorId = base.MarkConfig.Value.MultiMapFloorId;
			if (base.MapType == EMapType.MiniMap)
			{
				return base.InMultiMapArea(multiMapId) || base.InMultiMapArea(multiMapFloorId);
			}
			int? worldMapCurrentMultiMapId = WorldMapModel.Instance.WorldMapCurrentMultiMapId;
			int? num = worldMapCurrentMultiMapId;
			int num2 = multiMapId;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				num = worldMapCurrentMultiMapId;
				num2 = multiMapFloorId;
				return num.GetValueOrDefault() == num2 & num != null;
			}
			return true;
		}

		// Token: 0x0602C5E6 RID: 181734 RVA: 0x00C79C84 File Offset: 0x00C77E84
		private void UpdateMultiMapFloorSelectedState()
		{
			bool isSelectThisFloor = base.IsSelectThisFloor;
			base.IsSelectThisFloor = this.GetIsSelectThisFloor();
			if (isSelectThisFloor != base.IsSelectThisFloor)
			{
				base.UpdateViewIcon();
			}
		}
	}
}
