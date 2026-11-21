using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A4 RID: 22692
	public class SolarSchoolConditionSecondAttrValue : ActivityConditionBase
	{
		// Token: 0x17006B49 RID: 27465
		// (get) Token: 0x06037E75 RID: 228981 RVA: 0x00FA0F87 File Offset: 0x00F9F187
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E76 RID: 228982 RVA: 0x00FA0F8C File Offset: 0x00F9F18C
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			SolarSchoolAttr? attr = SolarSchoolConfig.Instance.GetAttr(p.GetInt("Attr", 0));
			if (attr == null)
			{
				return false;
			}
			this.Attr = (ESolarSchoolSecondAttr)attr.Value.AttrType;
			this.MinValue = p.GetInt("Min", int.MinValue);
			this.MaxValue = p.GetInt("Max", int.MaxValue);
			return true;
		}

		// Token: 0x06037E77 RID: 228983 RVA: 0x00FA1000 File Offset: 0x00F9F200
		protected override bool OnCheck()
		{
			int conditionAttr = SolarSchoolGamePlayModel.Instance.GetConditionAttr(this.Attr);
			return conditionAttr >= this.MinValue && conditionAttr <= this.MaxValue;
		}

		// Token: 0x06037E78 RID: 228984 RVA: 0x00FA1035 File Offset: 0x00F9F235
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06037E79 RID: 228985 RVA: 0x00FA1053 File Offset: 0x00F9F253
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
		}

		// Token: 0x06037E7A RID: 228986 RVA: 0x00FA1071 File Offset: 0x00F9F271
		protected override void OnClear()
		{
			this.Attr = ESolarSchoolSecondAttr.None;
			this.MinValue = 0;
			this.MaxValue = 0;
		}

		// Token: 0x06037E7B RID: 228987 RVA: 0x00FA1088 File Offset: 0x00F9F288
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			if (attr == this.Attr)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7EF RID: 120815
		private ESolarSchoolSecondAttr Attr;

		// Token: 0x0401D7F0 RID: 120816
		private int MinValue;

		// Token: 0x0401D7F1 RID: 120817
		private int MaxValue;
	}
}
