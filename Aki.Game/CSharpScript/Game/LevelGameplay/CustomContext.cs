using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069A9 RID: 27049
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomContext : GeneralContext
	{
		// Token: 0x0604346B RID: 275563 RVA: 0x0106638A File Offset: 0x0106458A
		public CustomContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Custom);
			this.CustomProperty = new Dictionary<string, object>();
		}

		// Token: 0x0604346C RID: 275564 RVA: 0x010663AA File Offset: 0x010645AA
		public void SetValueRestricted<[Nullable(2)] T>(string key, T value)
		{
			this.CustomProperty[key] = value;
		}

		// Token: 0x0604346D RID: 275565 RVA: 0x010663C0 File Offset: 0x010645C0
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

		// Token: 0x0604346E RID: 275566 RVA: 0x01066414 File Offset: 0x01064614
		public static CustomContext Create()
		{
			return GeneralContext.GetObj(EGeneralContextType.Custom, null, () => new CustomContext()) as CustomContext;
		}

		// Token: 0x040230BE RID: 143550
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly Dictionary<string, object> CustomProperty;
	}
}
