using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x0200645F RID: 25695
	[NullableContext(1)]
	[Nullable(0)]
	public class MoonSignInData : ActivityBaseData
	{
		// Token: 0x06040937 RID: 264503 RVA: 0x00FA0FA0 File Offset: 0x00F9F1A0
		protected override void PhraseEx(ActivityData data)
		{
			MoonPhaseActivityData moonPhaseActivityData = data.MoonPhaseActivityData;
			this.HaveSelectMoonPhaseSelectList = (((moonPhaseActivityData != null) ? moonPhaseActivityData.MoonPhaseSelects.ToList<MoonPhaseSelect>() : null) ?? new List<MoonPhaseSelect>());
			MoonPhaseActivityData moonPhaseActivityData2 = data.MoonPhaseActivityData;
			this.MoonGrandReward = (moonPhaseActivityData2 != null && moonPhaseActivityData2.MoonPhaseSpReward);
			this.SelectMoonPhaseList.Clear();
			foreach (MoonPhaseSelect moonPhaseSelect in this.HaveSelectMoonPhaseSelectList)
			{
				this.SelectMoonPhaseList.Add(moonPhaseSelect.MoonPhaseId);
			}
			IReadOnlyList<PhaseOfMoon> phaseOfMoonList = MoonSignInConfig.Instance.GetPhaseOfMoonList();
			this.AllMoonPhaseCount = ((phaseOfMoonList != null) ? phaseOfMoonList.Count : 0);
			MoonPhaseReward? moonPhaseReward;
			this.UseItemId = ((MoonSignInConfig.Instance.GetMoonSignReward(base.Id) != null) ? moonPhaseReward.GetValueOrDefault().ItemId : 0);
			MoonPhaseActivityData moonPhaseActivityData3 = data.MoonPhaseActivityData;
			this.CurrentMoonId = ((moonPhaseActivityData3 != null) ? moonPhaseActivityData3.NowMoonParse : 0);
		}

		// Token: 0x06040938 RID: 264504 RVA: 0x00FA10AC File Offset: 0x00F9F2AC
		public string GetMoonPhaseProgress()
		{
			return this.HaveSelectMoonPhaseSelectList.Count.ToString() + "/" + this.AllMoonPhaseCount.ToString();
		}

		// Token: 0x06040939 RID: 264505 RVA: 0x00FA10E1 File Offset: 0x00F9F2E1
		public override bool GetExDataRedPointShowState()
		{
			return this.GetAnyRedDot();
		}

		// Token: 0x0604093A RID: 264506 RVA: 0x00FA10E9 File Offset: 0x00F9F2E9
		public bool GetAnyRedDot()
		{
			return this.GetCurrentItemCount() > 0 || this.GetCanGetMoonGrandReward();
		}

		// Token: 0x0604093B RID: 264507 RVA: 0x00FA10FC File Offset: 0x00F9F2FC
		public int GetCurrentItemCount()
		{
			if (this.UseItemId == 0)
			{
				return 0;
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.UseItemId, 0);
		}

		// Token: 0x0604093C RID: 264508 RVA: 0x00FA111C File Offset: 0x00F9F31C
		public bool CheckPhaseLock(int id)
		{
			using (List<MoonPhaseSelect>.Enumerator enumerator = this.HaveSelectMoonPhaseSelectList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MoonPhaseId == id)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0604093D RID: 264509 RVA: 0x00FA1178 File Offset: 0x00F9F378
		public bool GetCanGetMoonGrandReward()
		{
			if (this.MoonGrandReward)
			{
				return false;
			}
			MoonPhaseReward? moonSignReward = MoonSignInConfig.Instance.GetMoonSignReward(base.Id);
			return moonSignReward != null && this.HaveSelectMoonPhaseSelectList.Count >= moonSignReward.Value.NeedMoonNum;
		}

		// Token: 0x0604093E RID: 264510 RVA: 0x00FA11CC File Offset: 0x00F9F3CC
		public List<int> GetMoonNormalRewardData()
		{
			List<int> list = new List<int>();
			for (int i = 1; i <= 10; i++)
			{
				list.Add(i);
			}
			return list;
		}

		// Token: 0x0604093F RID: 264511 RVA: 0x00FA11F4 File Offset: 0x00F9F3F4
		[NullableContext(2)]
		public MoonPhaseSelect GetMoonPhaseSelect(int moonId)
		{
			foreach (MoonPhaseSelect moonPhaseSelect in this.HaveSelectMoonPhaseSelectList)
			{
				if (moonPhaseSelect.MoonPhaseId == moonId)
				{
					return moonPhaseSelect;
				}
			}
			return null;
		}

		// Token: 0x06040940 RID: 264512 RVA: 0x00FA1250 File Offset: 0x00F9F450
		protected override bool GetExDataFinishShowState()
		{
			return this.HaveSelectMoonPhaseSelectList.Count >= 10 && this.MoonGrandReward;
		}

		// Token: 0x04021942 RID: 137538
		private const int MAX_MOON_COUNT = 10;

		// Token: 0x04021943 RID: 137539
		public List<MoonPhaseSelect> HaveSelectMoonPhaseSelectList = new List<MoonPhaseSelect>();

		// Token: 0x04021944 RID: 137540
		public bool MoonGrandReward;

		// Token: 0x04021945 RID: 137541
		private int AllMoonPhaseCount;

		// Token: 0x04021946 RID: 137542
		public List<int> SelectMoonPhaseList = new List<int>();

		// Token: 0x04021947 RID: 137543
		public int UseItemId;

		// Token: 0x04021948 RID: 137544
		public int CurrentMoonId;
	}
}
