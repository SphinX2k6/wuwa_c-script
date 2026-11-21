using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053DD RID: 21469
	[NullableContext(1)]
	[Nullable(0)]
	public class MoonSignInData : ActivityBaseData
	{
		// Token: 0x060355F8 RID: 218616 RVA: 0x00EE7F1C File Offset: 0x00EE611C
		protected override void PhraseEx(ActivityData data)
		{
			this.HaveSelectMoonPhaseSelectList = ((data.MoonPhaseActivityData != null) ? new List<MoonPhaseSelect>(data.MoonPhaseActivityData.MoonPhaseSelects) : new List<MoonPhaseSelect>());
			MoonPhaseActivityData moonPhaseActivityData = data.MoonPhaseActivityData;
			this.MoonGrandReward = (moonPhaseActivityData != null && moonPhaseActivityData.MoonPhaseSpReward);
			this.SelectMoonPhaseList.Clear();
			foreach (MoonPhaseSelect moonPhaseSelect in this.HaveSelectMoonPhaseSelectList)
			{
				this.SelectMoonPhaseList.Add(moonPhaseSelect.MoonPhaseId);
			}
			IReadOnlyList<PhaseOfMoon> phaseOfMoonList = MoonSignInConfig.Instance.GetPhaseOfMoonList();
			this.AllMoonPhaseCount = ((phaseOfMoonList != null) ? phaseOfMoonList.Count : 0);
			MoonPhaseReward? moonPhaseReward;
			this.UseItemId = ((MoonSignInConfig.Instance.GetMoonSignReward(base.Id) != null) ? moonPhaseReward.GetValueOrDefault().ItemId : 0);
			MoonPhaseActivityData moonPhaseActivityData2 = data.MoonPhaseActivityData;
			this.CurrentMoonId = ((moonPhaseActivityData2 != null) ? moonPhaseActivityData2.NowMoonParse : 0);
		}

		// Token: 0x060355F9 RID: 218617 RVA: 0x00EE8028 File Offset: 0x00EE6228
		public string GetMoonPhaseProgress()
		{
			return this.HaveSelectMoonPhaseSelectList.Count.ToString() + "/" + this.AllMoonPhaseCount.ToString();
		}

		// Token: 0x060355FA RID: 218618 RVA: 0x00EE805D File Offset: 0x00EE625D
		public override bool GetExDataRedPointShowState()
		{
			return this.GetAnyRedDot();
		}

		// Token: 0x060355FB RID: 218619 RVA: 0x00EE8065 File Offset: 0x00EE6265
		public bool GetAnyRedDot()
		{
			return this.GetCurrentItemCount() > 0 || this.GetCanGetMoonGrandReward();
		}

		// Token: 0x060355FC RID: 218620 RVA: 0x00EE8078 File Offset: 0x00EE6278
		public int GetCurrentItemCount()
		{
			if (this.UseItemId == 0)
			{
				return 0;
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.UseItemId, 0);
		}

		// Token: 0x060355FD RID: 218621 RVA: 0x00EE8098 File Offset: 0x00EE6298
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

		// Token: 0x060355FE RID: 218622 RVA: 0x00EE80F4 File Offset: 0x00EE62F4
		public bool GetCanGetMoonGrandReward()
		{
			if (this.MoonGrandReward)
			{
				return false;
			}
			MoonPhaseReward? moonSignReward = MoonSignInConfig.Instance.GetMoonSignReward(base.Id);
			return moonSignReward != null && this.HaveSelectMoonPhaseSelectList.Count >= moonSignReward.Value.NeedMoonNum;
		}

		// Token: 0x060355FF RID: 218623 RVA: 0x00EE8148 File Offset: 0x00EE6348
		public List<int> GetMoonNormalRewardData()
		{
			List<int> list = new List<int>();
			for (int i = 1; i <= 10; i++)
			{
				list.Add(i);
			}
			return list;
		}

		// Token: 0x06035600 RID: 218624 RVA: 0x00EE8170 File Offset: 0x00EE6370
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

		// Token: 0x06035601 RID: 218625 RVA: 0x00EE81CC File Offset: 0x00EE63CC
		protected override bool GetExDataFinishShowState()
		{
			return this.HaveSelectMoonPhaseSelectList.Count >= 10 && this.MoonGrandReward;
		}

		// Token: 0x0401C271 RID: 115313
		private const int MAX_MOON_COUNT = 10;

		// Token: 0x0401C272 RID: 115314
		public List<MoonPhaseSelect> HaveSelectMoonPhaseSelectList = new List<MoonPhaseSelect>();

		// Token: 0x0401C273 RID: 115315
		public bool MoonGrandReward;

		// Token: 0x0401C274 RID: 115316
		private int AllMoonPhaseCount;

		// Token: 0x0401C275 RID: 115317
		public List<int> SelectMoonPhaseList = new List<int>();

		// Token: 0x0401C276 RID: 115318
		public int UseItemId;

		// Token: 0x0401C277 RID: 115319
		public int CurrentMoonId;
	}
}
