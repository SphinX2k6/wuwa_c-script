using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.HonamiStory.Data
{
	// Token: 0x0200492C RID: 18732
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryWeaponSuitData
	{
		// Token: 0x0602EF86 RID: 192390 RVA: 0x00D19F9C File Offset: 0x00D1819C
		public HonamiStoryWeaponSuitData(int suitId)
		{
			HonamiStoryWeaponSuit value = HonamiStoryConfig.Instance.GetWeaponSuit(suitId).Value;
			this.Name = value.Name;
			this.Desc = value.Desc;
			this.Args = value.DescArgs();
			this.DescSimple = value.DescSimple;
			this.ArgsSimple = value.DescSimpleArgs();
			this.WeaponPluginType = value.WeaponPluginType;
			this.Enhance = value.EnhanceLevel;
			this.NeedNum = value.NeedNum;
		}

		// Token: 0x04018EEB RID: 102123
		public string Name;

		// Token: 0x04018EEC RID: 102124
		public string Desc;

		// Token: 0x04018EED RID: 102125
		public string DescSimple;

		// Token: 0x04018EEE RID: 102126
		public string[] Args;

		// Token: 0x04018EEF RID: 102127
		public string[] ArgsSimple;

		// Token: 0x04018EF0 RID: 102128
		public int WeaponPluginType;

		// Token: 0x04018EF1 RID: 102129
		public int Enhance;

		// Token: 0x04018EF2 RID: 102130
		public int NeedNum;
	}
}
