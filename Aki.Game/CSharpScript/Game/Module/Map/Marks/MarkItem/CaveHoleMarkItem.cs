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
	// Token: 0x020054D8 RID: 21720
	[NullableContext(1)]
	[Nullable(0)]
	public class CaveHoleMarkItem : ConfigMarkItem
	{
		// Token: 0x06037739 RID: 227129 RVA: 0x00D2C040 File Offset: 0x00D2A240
		public CaveHoleMarkItem(int markId, MapMark config, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, config, parent, mapType, markScale, new ETrackSource?((config.InstanceDungeonId != 0) ? ETrackSource.Instance : trackSource))
		{
		}

		// Token: 0x0603773A RID: 227130 RVA: 0x00D2C062 File Offset: 0x00D2A262
		protected override void OnInitialize()
		{
			this.UpdateMultiMapFloorSelectedState();
			base.OnInitialize();
		}

		// Token: 0x0603773B RID: 227131 RVA: 0x00D2C070 File Offset: 0x00D2A270
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.CaveHoleMarkItemView;
		}

		// Token: 0x0603773C RID: 227132 RVA: 0x00D2C073 File Offset: 0x00D2A273
		protected override MarkItemView CreateView()
		{
			return new CaveHoleMarkItemView(this);
		}

		// Token: 0x0603773D RID: 227133 RVA: 0x00D2C07C File Offset: 0x00D2A27C
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

		// Token: 0x0603773E RID: 227134 RVA: 0x00D2C0E8 File Offset: 0x00D2A2E8
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.UpdateMultiMapFloorSelectedState();
			}
		}

		// Token: 0x0603773F RID: 227135 RVA: 0x00D2C100 File Offset: 0x00D2A300
		public override bool GetIsSelectThisFloor()
		{
			if (!this.IsMultiMap())
			{
				return this.LocateInGround();
			}
			int multiMapId = this.GetMultiMapId();
			int multiMapFloorId = this.MarkConfig.Value.MultiMapFloorId;
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

		// Token: 0x06037740 RID: 227136 RVA: 0x00D2C194 File Offset: 0x00D2A394
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
