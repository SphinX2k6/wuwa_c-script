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
	// Token: 0x02005501 RID: 21761
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrTreeMarkItem : ConfigMarkItem
	{
		// Token: 0x06037981 RID: 227713 RVA: 0x00D32F4C File Offset: 0x00D3114C
		public VillageInfrTreeMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x06037982 RID: 227714 RVA: 0x00D32F62 File Offset: 0x00D31162
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateGamePlayState();
		}

		// Token: 0x1700859C RID: 34204
		// (get) Token: 0x06037983 RID: 227715 RVA: 0x00D32F70 File Offset: 0x00D31170
		// (set) Token: 0x06037984 RID: 227716 RVA: 0x00D32FAC File Offset: 0x00D311AC
		public override string IconPath
		{
			get
			{
				if (!this.IsLocked)
				{
					return this.MarkConfig.Value.UnlockMarkPic;
				}
				return this.MarkConfig.Value.LockMarkPic;
			}
			set
			{
			}
		}

		// Token: 0x06037985 RID: 227717 RVA: 0x00D32FAE File Offset: 0x00D311AE
		[PreserveBaseOverrides]
		protected new virtual VillageInfrTreeMarkItemView CreateView()
		{
			return new VillageInfrTreeMarkItemView(this);
		}

		// Token: 0x06037986 RID: 227718 RVA: 0x00D32FB6 File Offset: 0x00D311B6
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.VillageInfrTreeMarkItemView;
		}

		// Token: 0x06037987 RID: 227719 RVA: 0x00D32FBC File Offset: 0x00D311BC
		protected override bool GamePlayIsFinish()
		{
			InfrV2TreeBuild? treeConfigByMarkId = VillageInfrConfig.Instance.GetTreeConfigByMarkId(this.MarkId);
			IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(treeConfigByMarkId.Value.Id);
			return treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete;
		}

		// Token: 0x06037988 RID: 227720 RVA: 0x00D33001 File Offset: 0x00D31201
		public void UpdateGamePlayState()
		{
			base.MarkItemEntity.GamePlay.GamePlayState = (this.GamePlayIsFinish() ? EMarkGamePlayState.Finish : EMarkGamePlayState.Processing);
		}

		// Token: 0x0401D405 RID: 119813
		[Nullable(2)]
		public VillageInfrTreeMarkItemView InnerView;
	}
}
