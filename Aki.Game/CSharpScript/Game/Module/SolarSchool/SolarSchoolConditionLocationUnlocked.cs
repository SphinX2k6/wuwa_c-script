using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200589D RID: 22685
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionLocationUnlocked : ActivityConditionProgressBase
	{
		// Token: 0x17006B42 RID: 27458
		// (get) Token: 0x06037E3C RID: 228924 RVA: 0x00FA096A File Offset: 0x00F9EB6A
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E3D RID: 228925 RVA: 0x00FA096D File Offset: 0x00F9EB6D
		protected override bool OnInitialize(ConditionParams p)
		{
			this.LocationIds = p.GetIntList("LocationId").ToArray();
			return true;
		}

		// Token: 0x06037E3E RID: 228926 RVA: 0x00FA0988 File Offset: 0x00F9EB88
		public override int GetCurrent()
		{
			int num = 0;
			foreach (int locationId in this.LocationIds)
			{
				if (SolarSchoolGamePlayModel.Instance.MapData.IsLocationUnlocked(locationId))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06037E3F RID: 228927 RVA: 0x00FA09C7 File Offset: 0x00F9EBC7
		public override int GetTarget()
		{
			return this.LocationIds.Length;
		}

		// Token: 0x06037E40 RID: 228928 RVA: 0x00FA09D1 File Offset: 0x00F9EBD1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolLocationUnlocked, new Action<int>(this.OnLocationUnlocked));
		}

		// Token: 0x06037E41 RID: 228929 RVA: 0x00FA09EF File Offset: 0x00F9EBEF
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolLocationUnlocked, new Action<int>(this.OnLocationUnlocked));
		}

		// Token: 0x06037E42 RID: 228930 RVA: 0x00FA0A0D File Offset: 0x00F9EC0D
		protected override void OnClear()
		{
			this.LocationIds = Array.Empty<int>();
		}

		// Token: 0x06037E43 RID: 228931 RVA: 0x00FA0A1C File Offset: 0x00F9EC1C
		private void OnLocationUnlocked(int locationId)
		{
			int[] locationIds = this.LocationIds;
			for (int i = 0; i < locationIds.Length; i++)
			{
				if (locationIds[i] == locationId)
				{
					base.FinishExecute();
					return;
				}
			}
		}

		// Token: 0x0401D7E1 RID: 120801
		private int[] LocationIds = Array.Empty<int>();
	}
}
