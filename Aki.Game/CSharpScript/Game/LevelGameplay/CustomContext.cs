using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B05 RID: 23301
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomContext : GeneralContext
	{
		// Token: 0x060394A3 RID: 234659 RVA: 0x0100A5F2 File Offset: 0x010087F2
		public CustomContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Custom);
			this.CustomProperty = new Dictionary<string, object>();
		}

		// Token: 0x060394A4 RID: 234660 RVA: 0x0100A612 File Offset: 0x01008812
		public void SetValueRestricted<[Nullable(2)] T>(string key, T value)
		{
			this.CustomProperty[key] = value;
		}

		// Token: 0x060394A5 RID: 234661 RVA: 0x0100A628 File Offset: 0x01008828
		[NullableContext(2)]
		public T GetValueRestricted<T>([Nullable(1)] string key)
		{
			if (this.CustomProperty == null || !this.CustomProperty.ContainsKey(key))
			{
				return default(T);
			}
			object obj = this.CustomProperty[key];
			if (obj is T)
			{
				return (T)((object)obj);
			}
			return default(T);
		}

		// Token: 0x060394A6 RID: 234662 RVA: 0x0100A67C File Offset: 0x0100887C
		public static CustomContext Create()
		{
			return GeneralContext.GetObj(EGeneralContextType.Custom, null, () => new CustomContext()) as CustomContext;
		}

		// Token: 0x0401E2A8 RID: 123560
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly Dictionary<string, object> CustomProperty;
	}
}
