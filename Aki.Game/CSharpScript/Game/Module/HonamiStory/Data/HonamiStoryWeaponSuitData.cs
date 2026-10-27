using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.HonamiStory.Data
{
	// Token: 0x02005953 RID: 22867
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryWeaponSuitData
	{
		// Token: 0x0603A063 RID: 237667 RVA: 0x00DCACE8 File Offset: 0x00DC8EE8
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

		// Token: 0x0401E44E RID: 123982
		public string Name;

		// Token: 0x0401E44F RID: 123983
		public string Desc;

		// Token: 0x0401E450 RID: 123984
		public string DescSimple;

		// Token: 0x0401E451 RID: 123985
		public string[] Args;

		// Token: 0x0401E452 RID: 123986
		public string[] ArgsSimple;

		// Token: 0x0401E453 RID: 123987
		public int WeaponPluginType;

		// Token: 0x0401E454 RID: 123988
		public int Enhance;

		// Token: 0x0401E455 RID: 123989
		public int NeedNum;
	}
}
