using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200589B RID: 22683
	public class SolarSchoolConditionHasItem : ActivityConditionProgressBase
	{
		// Token: 0x17006B40 RID: 27456
		// (get) Token: 0x06037E2B RID: 228907 RVA: 0x00FA07D6 File Offset: 0x00F9E9D6
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E2C RID: 228908 RVA: 0x00FA07D9 File Offset: 0x00F9E9D9
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.ItemId = p.GetInt("ItemId", 0);
			this.TargetCount = p.GetInt("Count", 1);
			return true;
		}

		// Token: 0x06037E2D RID: 228909 RVA: 0x00FA0800 File Offset: 0x00F9EA00
		public override int GetCurrent()
		{
			return SolarSchoolGamePlayModel.Instance.InventoryData.GetItemCount(this.ItemId);
		}

		// Token: 0x06037E2E RID: 228910 RVA: 0x00FA0817 File Offset: 0x00F9EA17
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037E2F RID: 228911 RVA: 0x00FA081F File Offset: 0x00F9EA1F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
		}

		// Token: 0x06037E30 RID: 228912 RVA: 0x00FA083D File Offset: 0x00F9EA3D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
		}

		// Token: 0x06037E31 RID: 228913 RVA: 0x00FA085B File Offset: 0x00F9EA5B
		protected override void OnClear()
		{
			this.ItemId = 0;
			this.TargetCount = 0;
		}

		// Token: 0x06037E32 RID: 228914 RVA: 0x00FA086B File Offset: 0x00F9EA6B
		private void OnItemChanged(int itemId)
		{
			if (itemId == this.ItemId)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7DC RID: 120796
		private int ItemId;

		// Token: 0x0401D7DD RID: 120797
		private int TargetCount;
	}
}
