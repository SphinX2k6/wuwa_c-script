using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.VillageInfr;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044D4 RID: 17620
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrTreeMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C852 RID: 182354 RVA: 0x00C80F04 File Offset: 0x00C7F104
		public VillageInfrTreeMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x17005938 RID: 22840
		// (get) Token: 0x0602C853 RID: 182355 RVA: 0x00C80F1C File Offset: 0x00C7F11C
		// (set) Token: 0x0602C854 RID: 182356 RVA: 0x00C80F5E File Offset: 0x00C7F15E
		public override string IconPath
		{
			get
			{
				if (!this.IsLocked)
				{
					return base.MarkConfig.Value.UnlockMarkPic;
				}
				return base.MarkConfig.Value.LockMarkPic;
			}
			set
			{
			}
		}

		// Token: 0x0602C855 RID: 182357 RVA: 0x00C80F60 File Offset: 0x00C7F160
		[PreserveBaseOverrides]
		protected new virtual VillageInfrTreeMarkItemView CreateView()
		{
			return new VillageInfrTreeMarkItemView(this);
		}

		// Token: 0x0602C856 RID: 182358 RVA: 0x00C80F68 File Offset: 0x00C7F168
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.VillageInfrTreeMarkItemView;
		}

		// Token: 0x0602C857 RID: 182359 RVA: 0x00C80F6C File Offset: 0x00C7F16C
		protected override bool IsGamePlayFinishRaw()
		{
			InfrV2TreeBuild? treeConfigByMarkId = VillageInfrConfig.Instance.GetTreeConfigByMarkId(this.MarkId);
			IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(treeConfigByMarkId.Value.Id);
			return treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete;
		}
	}
}
