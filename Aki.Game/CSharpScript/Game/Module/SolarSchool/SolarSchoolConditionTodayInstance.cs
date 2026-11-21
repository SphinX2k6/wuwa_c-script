using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058AA RID: 22698
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionTodayInstance : ActivityConditionBase
	{
		// Token: 0x17006B4F RID: 27471
		// (get) Token: 0x06037EB1 RID: 229041 RVA: 0x00FA15C2 File Offset: 0x00F9F7C2
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037EB2 RID: 229042 RVA: 0x00FA15C5 File Offset: 0x00F9F7C5
		protected override bool OnInitialize(ConditionParams p)
		{
			this.InstanceIds = p.GetIntList("InstanceIds").ToArray();
			return true;
		}

		// Token: 0x06037EB3 RID: 229043 RVA: 0x00FA15E0 File Offset: 0x00F9F7E0
		protected override bool OnCheck()
		{
			int instanceId = SolarSchoolGamePlayModel.Instance.InstanceId;
			int[] instanceIds = this.InstanceIds;
			for (int i = 0; i < instanceIds.Length; i++)
			{
				if (instanceIds[i] == instanceId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037EB4 RID: 229044 RVA: 0x00FA1616 File Offset: 0x00F9F816
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037EB5 RID: 229045 RVA: 0x00FA1634 File Offset: 0x00F9F834
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037EB6 RID: 229046 RVA: 0x00FA1652 File Offset: 0x00F9F852
		protected override void OnClear()
		{
			this.InstanceIds = Array.Empty<int>();
		}

		// Token: 0x06037EB7 RID: 229047 RVA: 0x00FA165F File Offset: 0x00F9F85F
		private void OnTimeChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D800 RID: 120832
		private int[] InstanceIds = Array.Empty<int>();
	}
}
