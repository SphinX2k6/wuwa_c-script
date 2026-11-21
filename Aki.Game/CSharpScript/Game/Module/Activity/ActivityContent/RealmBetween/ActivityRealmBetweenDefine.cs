using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051E3 RID: 20963
	public class ActivityRealmBetweenDefine : IStaticVariableResetter
	{
		// Token: 0x060343D0 RID: 213968 RVA: 0x00E9D6B1 File Offset: 0x00E9B8B1
		static ActivityRealmBetweenDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRealmBetweenDefine.CreateStaticDefaultValue), new Action(ActivityRealmBetweenDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060343D1 RID: 213969 RVA: 0x00E9D6D0 File Offset: 0x00E9B8D0
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

		// Token: 0x060343D2 RID: 213970 RVA: 0x00E9D70C File Offset: 0x00E9B90C
		public static void ResetStaticDefaultValue()
		{
			ActivityRealmBetweenDefine.RealmBetweenMonsterTexture = null;
		}

		// Token: 0x0401BB5F RID: 113503
		[Nullable(1)]
		public static Dictionary<int, string> RealmBetweenMonsterTexture;
	}
}
