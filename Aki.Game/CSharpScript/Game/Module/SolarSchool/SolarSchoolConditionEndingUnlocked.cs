using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005898 RID: 22680
	public class SolarSchoolConditionEndingUnlocked : ActivityConditionBase
	{
		// Token: 0x17006B3D RID: 27453
		// (get) Token: 0x06037E0F RID: 228879 RVA: 0x00FA04E6 File Offset: 0x00F9E6E6
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E10 RID: 228880 RVA: 0x00FA04E9 File Offset: 0x00F9E6E9
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.EndingId = p.GetInt("EndingId", 0);
			return true;
		}

		// Token: 0x06037E11 RID: 228881 RVA: 0x00FA0500 File Offset: 0x00F9E700
		protected override bool OnCheck()
		{
			SolarSchoolActivityData currentActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			return currentActivityData != null && currentActivityData.IsEndingUnlocked(this.EndingId);
		}

		// Token: 0x06037E12 RID: 228882 RVA: 0x00FA0529 File Offset: 0x00F9E729
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryUpdate, new Action(this.OnGalleryUpdate));
		}

		// Token: 0x06037E13 RID: 228883 RVA: 0x00FA0547 File Offset: 0x00F9E747
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryUpdate, new Action(this.OnGalleryUpdate));
		}

		// Token: 0x06037E14 RID: 228884 RVA: 0x00FA0565 File Offset: 0x00F9E765
		protected override void OnClear()
		{
			this.EndingId = 0;
		}

		// Token: 0x06037E15 RID: 228885 RVA: 0x00FA056E File Offset: 0x00F9E76E
		private void OnGalleryUpdate()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D7D4 RID: 120788
		private int EndingId;
	}
}
