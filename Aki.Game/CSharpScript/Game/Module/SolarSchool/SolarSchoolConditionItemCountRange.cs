using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200589C RID: 22684
	public class SolarSchoolConditionItemCountRange : ActivityConditionBase
	{
		// Token: 0x17006B41 RID: 27457
		// (get) Token: 0x06037E34 RID: 228916 RVA: 0x00FA0884 File Offset: 0x00F9EA84
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E35 RID: 228917 RVA: 0x00FA0887 File Offset: 0x00F9EA87
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.ItemId = p.GetInt("ItemId", 0);
			this.MinCount = p.GetInt("Min", 0);
			this.MaxCount = p.GetInt("Max", int.MaxValue);
			return true;
		}

		// Token: 0x06037E36 RID: 228918 RVA: 0x00FA08C4 File Offset: 0x00F9EAC4
		protected override bool OnCheck()
		{
			int itemCount = SolarSchoolGamePlayModel.Instance.InventoryData.GetItemCount(this.ItemId);
			return itemCount >= this.MinCount && itemCount <= this.MaxCount;
		}

		// Token: 0x06037E37 RID: 228919 RVA: 0x00FA08FE File Offset: 0x00F9EAFE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
		}

		// Token: 0x06037E38 RID: 228920 RVA: 0x00FA091C File Offset: 0x00F9EB1C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
		}

		// Token: 0x06037E39 RID: 228921 RVA: 0x00FA093A File Offset: 0x00F9EB3A
		protected override void OnClear()
		{
			this.ItemId = 0;
			this.MinCount = 0;
			this.MaxCount = 0;
		}

		// Token: 0x06037E3A RID: 228922 RVA: 0x00FA0951 File Offset: 0x00F9EB51
		private void OnItemChanged(int itemId)
		{
			if (itemId == this.ItemId)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7DE RID: 120798
		private int ItemId;

		// Token: 0x0401D7DF RID: 120799
		private int MinCount;

		// Token: 0x0401D7E0 RID: 120800
		private int MaxCount;
	}
}
