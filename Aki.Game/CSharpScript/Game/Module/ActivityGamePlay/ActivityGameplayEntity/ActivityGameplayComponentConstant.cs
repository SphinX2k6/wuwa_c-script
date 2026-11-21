using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity
{
	// Token: 0x02005885 RID: 22661
	public class ActivityGameplayComponentConstant : IStaticVariableResetter
	{
		// Token: 0x06037D93 RID: 228755 RVA: 0x00F9EFB7 File Offset: 0x00F9D1B7
		static ActivityGameplayComponentConstant()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityGameplayComponentConstant.CreateStaticDefaultValue), new Action(ActivityGameplayComponentConstant.ResetStaticDefaultValue));
		}

		// Token: 0x06037D94 RID: 228756 RVA: 0x00F9EFD6 File Offset: 0x00F9D1D6
		public static void CreateStaticDefaultValue()
		{
			ActivityGameplayComponentConstant.CacheDependencies = new Dictionary<Type, Type[]>();
		}

		// Token: 0x06037D95 RID: 228757 RVA: 0x00F9EFE2 File Offset: 0x00F9D1E2
		public static void ResetStaticDefaultValue()
		{
			ActivityGameplayComponentConstant.CacheDependencies = null;
		}

		// Token: 0x06037D96 RID: 228758 RVA: 0x00F9EFEC File Offset: 0x00F9D1EC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static Type[] GetComponentDependencies(Type componentType)
		{
			Type[] result;
			if (!ActivityGameplayComponentConstant.CacheDependencies.TryGetValue(componentType, out result))
			{
				ActivityGameplayComponentBase activityGameplayComponentBase = RuntimeHelpers.GetUninitializedObject(componentType) as ActivityGameplayComponentBase;
				if (activityGameplayComponentBase == null)
				{
					return null;
				}
				result = (ActivityGameplayComponentConstant.CacheDependencies[componentType] = activityGameplayComponentBase.Dependencies);
			}
			return result;
		}

		// Token: 0x0401D7AE RID: 120750
		[Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})]
		private static Dictionary<Type, Type[]> CacheDependencies;
	}
}
