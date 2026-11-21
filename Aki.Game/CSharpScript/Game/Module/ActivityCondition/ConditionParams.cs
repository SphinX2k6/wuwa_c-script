using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A86 RID: 23174
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class ConditionParams
	{
		// Token: 0x060391EF RID: 233967 RVA: 0x010000AE File Offset: 0x00FFE2AE
		internal ConditionParams()
		{
		}

		// Token: 0x060391F0 RID: 233968 RVA: 0x010000C4 File Offset: 0x00FFE2C4
		internal void Initialize(ActivityCondition config)
		{
			this.Params.Clear();
			int paramsLength = config.ParamsLength;
			for (int i = 0; i < paramsLength; i++)
			{
				DicStringString? dicStringString = config.Params(i);
				if (dicStringString != null && !string.IsNullOrEmpty(dicStringString.Value.Key))
				{
					this.Params[dicStringString.Value.Key] = (dicStringString.Value.Value ?? string.Empty);
				}
			}
		}

		// Token: 0x060391F1 RID: 233969 RVA: 0x0100014A File Offset: 0x00FFE34A
		internal void Clear()
		{
			this.Params.Clear();
		}

		// Token: 0x060391F2 RID: 233970 RVA: 0x01000157 File Offset: 0x00FFE357
		public bool Has(string key)
		{
			return this.Params.ContainsKey(key);
		}

		// Token: 0x060391F3 RID: 233971 RVA: 0x01000168 File Offset: 0x00FFE368
		public string GetString(string key, string def = "")
		{
			string text;
			if (this.Params.TryGetValue(key, out text) && text != null)
			{
				return text;
			}
			return def;
		}

		// Token: 0x060391F4 RID: 233972 RVA: 0x0100018C File Offset: 0x00FFE38C
		public int GetInt(string key, int def = 0)
		{
			string s;
			int result;
			if (this.Params.TryGetValue(key, out s) && int.TryParse(s, out result))
			{
				return result;
			}
			return def;
		}

		// Token: 0x060391F5 RID: 233973 RVA: 0x010001B8 File Offset: 0x00FFE3B8
		public bool GetBool(string key, bool def = false)
		{
			string text;
			if (!this.Params.TryGetValue(key, out text) || text == null)
			{
				return def;
			}
			bool result;
			if (bool.TryParse(text, out result))
			{
				return result;
			}
			int num;
			if (int.TryParse(text, out num))
			{
				return num != 0;
			}
			return def;
		}

		// Token: 0x060391F6 RID: 233974 RVA: 0x010001F8 File Offset: 0x00FFE3F8
		[NullableContext(0)]
		public T GetEnum<T>([Nullable(1)] string key) where T : struct, Enum
		{
			string value;
			T result;
			if (this.Params.TryGetValue(key, out value) && Enum.TryParse<T>(value, true, out result))
			{
				return result;
			}
			return default(T);
		}

		// Token: 0x060391F7 RID: 233975 RVA: 0x0100022C File Offset: 0x00FFE42C
		public List<int> GetIntList(string key)
		{
			List<int> list = new List<int>();
			string @string = this.GetString(key, "");
			if (string.IsNullOrEmpty(@string))
			{
				return list;
			}
			string[] array = @string.Split('|', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				int item;
				if (int.TryParse(array[i], out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0401E0EB RID: 123115
		private readonly Dictionary<string, string> Params = new Dictionary<string, string>();
	}
}
