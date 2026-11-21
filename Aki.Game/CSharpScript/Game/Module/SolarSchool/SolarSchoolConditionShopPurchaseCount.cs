using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A5 RID: 22693
	public class SolarSchoolConditionShopPurchaseCount : ActivityConditionProgressBase, ISolarSchoolProgressCondition
	{
		// Token: 0x17006B4A RID: 27466
		// (get) Token: 0x06037E7D RID: 228989 RVA: 0x00FA10A1 File Offset: 0x00F9F2A1
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E7E RID: 228990 RVA: 0x00FA10A4 File Offset: 0x00F9F2A4
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.ShopId = p.GetInt("ShopId", 0);
			this.GoodsIds = (p.Has("GoodsId") ? p.GetIntList("GoodsId").ToArray() : null);
			this.TargetCount = p.GetInt("Count", 0);
			return true;
		}

		// Token: 0x06037E7F RID: 228991 RVA: 0x00FA10FC File Offset: 0x00F9F2FC
		public override int GetCurrent()
		{
			int rawCurrent = this.GetRawCurrent();
			if (!this.UseLocalProgress)
			{
				return rawCurrent;
			}
			return Math.Max(rawCurrent - this.ProgressBaseline, 0);
		}

		// Token: 0x06037E80 RID: 228992 RVA: 0x00FA1128 File Offset: 0x00F9F328
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037E81 RID: 228993 RVA: 0x00FA1130 File Offset: 0x00F9F330
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolShopPurchaseChanged, new Action(this.OnShopPurchaseChanged));
		}

		// Token: 0x06037E82 RID: 228994 RVA: 0x00FA114E File Offset: 0x00F9F34E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolShopPurchaseChanged, new Action(this.OnShopPurchaseChanged));
		}

		// Token: 0x06037E83 RID: 228995 RVA: 0x00FA116C File Offset: 0x00F9F36C
		protected override void OnClear()
		{
			this.ShopId = 0;
			this.GoodsIds = null;
			this.TargetCount = 0;
			this.UseLocalProgress = false;
			this.ProgressBaseline = 0;
		}

		// Token: 0x06037E84 RID: 228996 RVA: 0x00FA1191 File Offset: 0x00F9F391
		public void RestoreProgress(int progress)
		{
			this.UseLocalProgress = true;
			this.ProgressBaseline = Math.Max(this.GetRawCurrent() - progress, 0);
		}

		// Token: 0x06037E85 RID: 228997 RVA: 0x00FA11AE File Offset: 0x00F9F3AE
		public int GetSaveProgress()
		{
			return Math.Clamp(this.GetCurrent(), 0, this.GetTarget());
		}

		// Token: 0x06037E86 RID: 228998 RVA: 0x00FA11C2 File Offset: 0x00F9F3C2
		private int GetRawCurrent()
		{
			return SolarSchoolGamePlayModel.Instance.ShopData.GetBoughtCount(this.ShopId, this.GoodsIds);
		}

		// Token: 0x06037E87 RID: 228999 RVA: 0x00FA11DF File Offset: 0x00F9F3DF
		private void OnShopPurchaseChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D7F2 RID: 120818
		private int ShopId;

		// Token: 0x0401D7F3 RID: 120819
		[Nullable(2)]
		private int[] GoodsIds;

		// Token: 0x0401D7F4 RID: 120820
		private int TargetCount;

		// Token: 0x0401D7F5 RID: 120821
		private bool UseLocalProgress;

		// Token: 0x0401D7F6 RID: 120822
		private int ProgressBaseline;
	}
}
