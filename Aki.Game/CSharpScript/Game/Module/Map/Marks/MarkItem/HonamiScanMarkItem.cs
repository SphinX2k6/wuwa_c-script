using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054E9 RID: 21737
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiScanMarkItem : ConfigMarkItem
	{
		// Token: 0x06037804 RID: 227332 RVA: 0x00D2E525 File Offset: 0x00D2C725
		public HonamiScanMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.Instance) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x06037805 RID: 227333 RVA: 0x00D2E546 File Offset: 0x00D2C746
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.UpdateGamePlayState();
			this.RefreshSubMapState();
		}

		// Token: 0x06037806 RID: 227334 RVA: 0x00D2E55A File Offset: 0x00D2C75A
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.RefreshSubMapState();
			}
		}

		// Token: 0x06037807 RID: 227335 RVA: 0x00D2E572 File Offset: 0x00D2C772
		protected override void InitIcon()
		{
			this.UpdateIcon();
		}

		// Token: 0x06037808 RID: 227336 RVA: 0x00D2E57C File Offset: 0x00D2C77C
		public void UpdateIcon()
		{
			this.IconPathInner = (this.IsLocked ? this.MarkConfig.Value.LockMarkPic : this.MarkConfig.Value.UnlockMarkPic);
		}

		// Token: 0x06037809 RID: 227337 RVA: 0x00D2E5BF File Offset: 0x00D2C7BF
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.HonamiScanMarkItemView;
		}

		// Token: 0x0603780A RID: 227338 RVA: 0x00D2E5C3 File Offset: 0x00D2C7C3
		[PreserveBaseOverrides]
		protected new virtual HonamiScanMarkItemView CreateView()
		{
			return new HonamiScanMarkItemView(this);
		}

		// Token: 0x17008543 RID: 34115
		// (get) Token: 0x0603780B RID: 227339 RVA: 0x00D2E5CB File Offset: 0x00D2C7CB
		public override bool IsLocked
		{
			get
			{
				return MapModel.Instance.GetHonamiScanMarkInfo(this.MarkId) == MarkState.MarkDisable;
			}
		}

		// Token: 0x17008544 RID: 34116
		// (get) Token: 0x0603780C RID: 227340 RVA: 0x00D2E5E0 File Offset: 0x00D2C7E0
		// (set) Token: 0x0603780D RID: 227341 RVA: 0x00D2E5E8 File Offset: 0x00D2C7E8
		public override string IconPath
		{
			get
			{
				return this.IconPathInner;
			}
			set
			{
				this.IconPathInner = value;
			}
		}

		// Token: 0x0603780E RID: 227342 RVA: 0x00D2E5F1 File Offset: 0x00D2C7F1
		protected override bool GamePlayIsFinish()
		{
			return MapModel.Instance.GetHonamiScanMarkInfo(this.MarkId) == MarkState.MarkComplete;
		}

		// Token: 0x0603780F RID: 227343 RVA: 0x00D2E606 File Offset: 0x00D2C806
		private void UpdateGamePlayState()
		{
			base.MarkItemEntity.GamePlay.GamePlayState = (this.GamePlayIsFinish() ? EMarkGamePlayState.Finish : EMarkGamePlayState.Lock);
		}

		// Token: 0x06037810 RID: 227344 RVA: 0x00D2E624 File Offset: 0x00D2C824
		private void RefreshSubMapState()
		{
			base.IsSelectThisFloor = this.GetIsSelectThisFloor();
		}

		// Token: 0x0401D3A4 RID: 119716
		[Nullable(2)]
		public HonamiScanMarkItemView InnerView;

		// Token: 0x0401D3A5 RID: 119717
		public bool IsDirty;

		// Token: 0x0401D3A6 RID: 119718
		private string IconPathInner = "";
	}
}
