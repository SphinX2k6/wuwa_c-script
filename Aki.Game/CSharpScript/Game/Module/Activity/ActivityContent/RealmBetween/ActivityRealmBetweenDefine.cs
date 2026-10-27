using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006265 RID: 25189
	public class ActivityRealmBetweenDefine : IStaticVariableResetter
	{
		// Token: 0x0603F70F RID: 259855 RVA: 0x00F56755 File Offset: 0x00F54955
		static ActivityRealmBetweenDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRealmBetweenDefine.CreateStaticDefaultValue), new Action(ActivityRealmBetweenDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603F710 RID: 259856 RVA: 0x00F56774 File Offset: 0x00F54974
		public static void CreateStaticDefaultValue()
		{
			ActivityRealmBetweenDefine.RealmBetweenMonsterTexture = new Dictionary<int, string>
			{
				{
					0,
					"T_VisionBgA"
				},
				{
					1,
					"T_VisionBgB"
				},
				{
					2,
					"T_VisionBgC"
				},
				{
					3,
					"T_VisionBgD"
				}
			};
		}

		// Token: 0x0603F711 RID: 259857 RVA: 0x00F567B0 File Offset: 0x00F549B0
		public static void ResetStaticDefaultValue()
		{
			ActivityRealmBetweenDefine.RealmBetweenMonsterTexture = null;
		}

		// Token: 0x04021230 RID: 135728
		[Nullable(1)]
		public static Dictionary<int, string> RealmBetweenMonsterTexture;
	}
}
