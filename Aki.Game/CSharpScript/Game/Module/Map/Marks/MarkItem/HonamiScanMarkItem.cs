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
	// Token: 0x020044BC RID: 17596
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiScanMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C6C1 RID: 181953 RVA: 0x00C7C63B File Offset: 0x00C7A83B
		public HonamiScanMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.Instance) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C6C2 RID: 181954 RVA: 0x00C7C65C File Offset: 0x00C7A85C
		protected override void OnInitialize()
		{
			base.OnInitialize();
			this.RefreshSubMapState();
		}

		// Token: 0x0602C6C3 RID: 181955 RVA: 0x00C7C66A File Offset: 0x00C7A86A
		protected override void OnUpdate(global::Vector playerLocation)
		{
			base.OnUpdate(playerLocation);
			if (base.MapType == EMapType.MiniMap)
			{
				this.RefreshSubMapState();
			}
		}

		// Token: 0x0602C6C4 RID: 181956 RVA: 0x00C7C682 File Offset: 0x00C7A882
		protected override void InitIcon()
		{
			this.UpdateIcon();
		}

		// Token: 0x0602C6C5 RID: 181957 RVA: 0x00C7C68C File Offset: 0x00C7A88C
		public void UpdateIcon()
		{
			this.IconPathInner = (this.IsLocked ? base.MarkConfig.Value.LockMarkPic : base.MarkConfig.Value.UnlockMarkPic);
		}

		// Token: 0x0602C6C6 RID: 181958 RVA: 0x00C7C6D5 File Offset: 0x00C7A8D5
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.HonamiScanMarkItemView;
		}

		// Token: 0x0602C6C7 RID: 181959 RVA: 0x00C7C6D9 File Offset: 0x00C7A8D9
		[PreserveBaseOverrides]
		protected new virtual HonamiScanMarkItemView CreateView()
		{
			return new HonamiScanMarkItemView(this);
		}

		// Token: 0x170058D2 RID: 22738
		// (get) Token: 0x0602C6C8 RID: 181960 RVA: 0x00C7C6E1 File Offset: 0x00C7A8E1
		public override bool IsLocked
		{
			get
			{
				return MapModel.Instance.GetHonamiScanMarkInfo(this.MarkId) == MarkState.MarkDisable;
			}
		}

		// Token: 0x170058D3 RID: 22739
		// (get) Token: 0x0602C6C9 RID: 181961 RVA: 0x00C7C6F6 File Offset: 0x00C7A8F6
		// (set) Token: 0x0602C6CA RID: 181962 RVA: 0x00C7C6FE File Offset: 0x00C7A8FE
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

		// Token: 0x0602C6CB RID: 181963 RVA: 0x00C7C707 File Offset: 0x00C7A907
		protected override bool IsGamePlayFinishRaw()
		{
			return MapModel.Instance.GetHonamiScanMarkInfo(this.MarkId) == MarkState.MarkComplete;
		}

		// Token: 0x0602C6CC RID: 181964 RVA: 0x00C7C71C File Offset: 0x00C7A91C
		private void RefreshSubMapState()
		{
			base.IsSelectThisFloor = this.GetIsSelectThisFloor();
		}

		// Token: 0x04017E1E RID: 97822
		public bool IsDirty;

		// Token: 0x04017E1F RID: 97823
		private string IconPathInner = "";
	}
}
