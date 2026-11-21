using System;
using System.Collections.Generic;

namespace System.Threading
{
	// Token: 0x020003CB RID: 971
	internal static class AsyncLocalValueMap
	{
		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06003F7A RID: 16250 RVA: 0x000D4079 File Offset: 0x000D2279
		public static IAsyncLocalValueMap Empty { get; } = new AsyncLocalValueMap.EmptyAsyncLocalValueMap();

		// Token: 0x06003F7B RID: 16251 RVA: 0x000D4080 File Offset: 0x000D2280
		public static bool IsEmpty(IAsyncLocalValueMap asyncLocalValueMap)
		{
			return asyncLocalValueMap == AsyncLocalValueMap.Empty;
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000D408C File Offset: 0x000D228C
		public static IAsyncLocalValueMap Create(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
		{
			if (value == null && treatNullValueAsNonexistent)
			{
				return AsyncLocalValueMap.Empty;
			}
			return new AsyncLocalValueMap.OneElementAsyncLocalValueMap(KeyValuePair.Create<IAsyncLocal, object>(key, value));
		}

		// Token: 0x020003CC RID: 972
		private sealed class EmptyAsyncLocalValueMap : IAsyncLocalValueMap
		{
			// Token: 0x06003F7E RID: 16254 RVA: 0x000D40C0 File Offset: 0x000D22C0
			public IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
			{
				if (value == null && treatNullValueAsNonexistent)
				{
					return this;
				}
				return new AsyncLocalValueMap.OneElementAsyncLocalValueMap(KeyValuePair.Create<IAsyncLocal, object>(key, value));
			}

			// Token: 0x06003F7F RID: 16255 RVA: 0x000D40E5 File Offset: 0x000D22E5
			public bool TryGetValue(IAsyncLocal key, out object value)
			{
				value = null;
				return false;
			}
		}

		// Token: 0x020003CD RID: 973
		private sealed class OneElementAsyncLocalValueMap : IAsyncLocalValueMap
		{
			// Token: 0x06003F81 RID: 16257 RVA: 0x000D40EB File Offset: 0x000D22EB
			public OneElementAsyncLocalValueMap(KeyValuePair<IAsyncLocal, object> item0)
			{
				this._item0 = item0;
			}

			// Token: 0x06003F82 RID: 16258 RVA: 0x000D40FC File Offset: 0x000D22FC
			public IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
			{
				if (value != null || !treatNullValueAsNonexistent)
				{
					KeyValuePair<IAsyncLocal, object> keyValuePair = KeyValuePair.Create<IAsyncLocal, object>(key, value);
					if (key != this._item0.Key)
					{
						return new AsyncLocalValueMap.TwoElementAsyncLocalValueMap(this._item0, keyValuePair);
					}
					return new AsyncLocalValueMap.OneElementAsyncLocalValueMap(keyValuePair);
				}
				else
				{
					if (key != this._item0.Key)
					{
						return this;
					}
					return AsyncLocalValueMap.Empty;
				}
			}

			// Token: 0x06003F83 RID: 16259 RVA: 0x000D4154 File Offset: 0x000D2354
			public bool TryGetValue(IAsyncLocal key, out object value)
			{
				if (key == this._item0.Key)
				{
					value = this._item0.Value;
					return true;
				}
				value = null;
				return false;
			}

			// Token: 0x04000D1B RID: 3355
			private readonly KeyValuePair<IAsyncLocal, object> _item0;
		}

		// Token: 0x020003CE RID: 974
		private sealed class TwoElementAsyncLocalValueMap : IAsyncLocalValueMap
		{
			// Token: 0x06003F84 RID: 16260 RVA: 0x000D4177 File Offset: 0x000D2377
			public TwoElementAsyncLocalValueMap(KeyValuePair<IAsyncLocal, object> item0, KeyValuePair<IAsyncLocal, object> item1)
			{
				this._item0 = item0;
				this._item1 = item1;
			}

			// Token: 0x06003F85 RID: 16261 RVA: 0x000D4190 File Offset: 0x000D2390
			public IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
			{
				if (value != null || !treatNullValueAsNonexistent)
				{
					KeyValuePair<IAsyncLocal, object> keyValuePair = KeyValuePair.Create<IAsyncLocal, object>(key, value);
					if (key == this._item0.Key)
					{
						return new AsyncLocalValueMap.TwoElementAsyncLocalValueMap(keyValuePair, this._item1);
					}
					if (key != this._item1.Key)
					{
						return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(this._item0, this._item1, keyValuePair);
					}
					return new AsyncLocalValueMap.TwoElementAsyncLocalValueMap(this._item0, keyValuePair);
				}
				else
				{
					if (key == this._item0.Key)
					{
						return new AsyncLocalValueMap.OneElementAsyncLocalValueMap(this._item1);
					}
					if (key != this._item1.Key)
					{
						return this;
					}
					return new AsyncLocalValueMap.OneElementAsyncLocalValueMap(this._item0);
				}
			}

			// Token: 0x06003F86 RID: 16262 RVA: 0x000D4235 File Offset: 0x000D2435
			public bool TryGetValue(IAsyncLocal key, out object value)
			{
				if (key == this._item0.Key)
				{
					value = this._item0.Value;
					return true;
				}
				if (key == this._item1.Key)
				{
					value = this._item1.Value;
					return true;
				}
				value = null;
				return false;
			}

			// Token: 0x04000D1C RID: 3356
			private readonly KeyValuePair<IAsyncLocal, object> _item0;

			// Token: 0x04000D1D RID: 3357
			private readonly KeyValuePair<IAsyncLocal, object> _item1;
		}

		// Token: 0x020003CF RID: 975
		private sealed class ThreeElementAsyncLocalValueMap : IAsyncLocalValueMap
		{
			// Token: 0x06003F87 RID: 16263 RVA: 0x000D4275 File Offset: 0x000D2475
			public ThreeElementAsyncLocalValueMap(KeyValuePair<IAsyncLocal, object> item0, KeyValuePair<IAsyncLocal, object> item1, KeyValuePair<IAsyncLocal, object> item2)
			{
				this._item0 = item0;
				this._item1 = item1;
				this._item2 = item2;
			}

			// Token: 0x06003F88 RID: 16264 RVA: 0x000D4294 File Offset: 0x000D2494
			public IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
			{
				if (value != null || !treatNullValueAsNonexistent)
				{
					KeyValuePair<IAsyncLocal, object> keyValuePair = KeyValuePair.Create<IAsyncLocal, object>(key, value);
					if (key == this._item0.Key)
					{
						return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(keyValuePair, this._item1, this._item2);
					}
					if (key == this._item1.Key)
					{
						return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(this._item0, keyValuePair, this._item2);
					}
					if (key != this._item2.Key)
					{
						return new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._item0, this._item1, this._item2, keyValuePair);
					}
					return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(this._item0, this._item1, keyValuePair);
				}
				else
				{
					if (key == this._item0.Key)
					{
						return new AsyncLocalValueMap.TwoElementAsyncLocalValueMap(this._item1, this._item2);
					}
					if (key == this._item1.Key)
					{
						return new AsyncLocalValueMap.TwoElementAsyncLocalValueMap(this._item0, this._item2);
					}
					if (key != this._item2.Key)
					{
						return this;
					}
					return new AsyncLocalValueMap.TwoElementAsyncLocalValueMap(this._item0, this._item1);
				}
			}

			// Token: 0x06003F89 RID: 16265 RVA: 0x000D43A0 File Offset: 0x000D25A0
			public bool TryGetValue(IAsyncLocal key, out object value)
			{
				if (key == this._item0.Key)
				{
					value = this._item0.Value;
					return true;
				}
				if (key == this._item1.Key)
				{
					value = this._item1.Value;
					return true;
				}
				if (key == this._item2.Key)
				{
					value = this._item2.Value;
					return true;
				}
				value = null;
				return false;
			}

			// Token: 0x04000D1E RID: 3358
			private readonly KeyValuePair<IAsyncLocal, object> _item0;

			// Token: 0x04000D1F RID: 3359
			private readonly KeyValuePair<IAsyncLocal, object> _item1;

			// Token: 0x04000D20 RID: 3360
			private readonly KeyValuePair<IAsyncLocal, object> _item2;
		}

		// Token: 0x020003D0 RID: 976
		private sealed class FourElementAsyncLocalValueMap : IAsyncLocalValueMap
		{
			// Token: 0x06003F8A RID: 16266 RVA: 0x000D4408 File Offset: 0x000D2608
			public FourElementAsyncLocalValueMap(KeyValuePair<IAsyncLocal, object> item0, KeyValuePair<IAsyncLocal, object> item1, KeyValuePair<IAsyncLocal, object> item2, KeyValuePair<IAsyncLocal, object> item3)
			{
				this._item0 = item0;
				this._item1 = item1;
				this._item2 = item2;
				this._item3 = item3;
			}

			// Token: 0x06003F8B RID: 16267 RVA: 0x000D4430 File Offset: 0x000D2630
			public IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
			{
				if (value != null || !treatNullValueAsNonexistent)
				{
					KeyValuePair<IAsyncLocal, object> keyValuePair = KeyValuePair.Create<IAsyncLocal, object>(key, value);
					if (key == this._item0.Key)
					{
						return new AsyncLocalValueMap.FourElementAsyncLocalValueMap(keyValuePair, this._item1, this._item2, this._item3);
					}
					if (key == this._item1.Key)
					{
						return new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._item0, keyValuePair, this._item2, this._item3);
					}
					if (key == this._item2.Key)
					{
						return new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._item0, this._item1, keyValuePair, this._item3);
					}
					if (key != this._item3.Key)
					{
						return new AsyncLocalValueMap.MultiElementAsyncLocalValueMap(new KeyValuePair<IAsyncLocal, object>[]
						{
							this._item0,
							this._item1,
							this._item2,
							this._item3,
							keyValuePair
						});
					}
					return new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._item0, this._item1, this._item2, keyValuePair);
				}
				else
				{
					if (key == this._item0.Key)
					{
						return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(this._item1, this._item2, this._item3);
					}
					if (key == this._item1.Key)
					{
						return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(this._item0, this._item2, this._item3);
					}
					if (key == this._item2.Key)
					{
						return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(this._item0, this._item1, this._item3);
					}
					if (key != this._item3.Key)
					{
						return this;
					}
					return new AsyncLocalValueMap.ThreeElementAsyncLocalValueMap(this._item0, this._item1, this._item2);
				}
			}

			// Token: 0x06003F8C RID: 16268 RVA: 0x000D45E8 File Offset: 0x000D27E8
			public bool TryGetValue(IAsyncLocal key, out object value)
			{
				if (key == this._item0.Key)
				{
					value = this._item0.Value;
					return true;
				}
				if (key == this._item1.Key)
				{
					value = this._item1.Value;
					return true;
				}
				if (key == this._item2.Key)
				{
					value = this._item2.Value;
					return true;
				}
				if (key == this._item3.Key)
				{
					value = this._item3.Value;
					return true;
				}
				value = null;
				return false;
			}

			// Token: 0x04000D21 RID: 3361
			private readonly KeyValuePair<IAsyncLocal, object> _item0;

			// Token: 0x04000D22 RID: 3362
			private readonly KeyValuePair<IAsyncLocal, object> _item1;

			// Token: 0x04000D23 RID: 3363
			private readonly KeyValuePair<IAsyncLocal, object> _item2;

			// Token: 0x04000D24 RID: 3364
			private readonly KeyValuePair<IAsyncLocal, object> _item3;
		}

		// Token: 0x020003D1 RID: 977
		private sealed class MultiElementAsyncLocalValueMap : IAsyncLocalValueMap
		{
			// Token: 0x06003F8D RID: 16269 RVA: 0x000D466D File Offset: 0x000D286D
			internal MultiElementAsyncLocalValueMap(KeyValuePair<IAsyncLocal, object>[] keyValues)
			{
				this._keyValues = keyValues;
			}

			// Token: 0x06003F8E RID: 16270 RVA: 0x000D467C File Offset: 0x000D287C
			public IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
			{
				int i = 0;
				while (i < this._keyValues.Length)
				{
					if (key == this._keyValues[i].Key)
					{
						if (value != null || !treatNullValueAsNonexistent)
						{
							KeyValuePair<IAsyncLocal, object>[] array = this._keyValues.AsSpan<KeyValuePair<IAsyncLocal, object>>().ToArray();
							array[i] = KeyValuePair.Create<IAsyncLocal, object>(key, value);
							return new AsyncLocalValueMap.MultiElementAsyncLocalValueMap(array);
						}
						if (this._keyValues.Length == 5)
						{
							AsyncLocalValueMap.FourElementAsyncLocalValueMap result;
							switch (i)
							{
							case 0:
								result = new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._keyValues[1], this._keyValues[2], this._keyValues[3], this._keyValues[4]);
								break;
							case 1:
								result = new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._keyValues[0], this._keyValues[2], this._keyValues[3], this._keyValues[4]);
								break;
							case 2:
								result = new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._keyValues[0], this._keyValues[1], this._keyValues[3], this._keyValues[4]);
								break;
							case 3:
								result = new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._keyValues[0], this._keyValues[1], this._keyValues[2], this._keyValues[4]);
								break;
							default:
								result = new AsyncLocalValueMap.FourElementAsyncLocalValueMap(this._keyValues[0], this._keyValues[1], this._keyValues[2], this._keyValues[3]);
								break;
							}
							return result;
						}
						KeyValuePair<IAsyncLocal, object>[] array2 = new KeyValuePair<IAsyncLocal, object>[this._keyValues.Length - 1];
						if (i != 0)
						{
							Array.Copy(this._keyValues, array2, i);
						}
						if (i != this._keyValues.Length - 1)
						{
							Array.Copy(this._keyValues, i + 1, array2, i, this._keyValues.Length - i - 1);
						}
						return new AsyncLocalValueMap.MultiElementAsyncLocalValueMap(array2);
					}
					else
					{
						i++;
					}
				}
				if (value == null && treatNullValueAsNonexistent)
				{
					return this;
				}
				if (this._keyValues.Length < 16)
				{
					KeyValuePair<IAsyncLocal, object>[] array3 = new KeyValuePair<IAsyncLocal, object>[this._keyValues.Length + 1];
					Array.Copy(this._keyValues, array3, this._keyValues.Length);
					array3[this._keyValues.Length] = KeyValuePair.Create<IAsyncLocal, object>(key, value);
					return new AsyncLocalValueMap.MultiElementAsyncLocalValueMap(array3);
				}
				AsyncLocalValueMap.ManyElementAsyncLocalValueMap manyElementAsyncLocalValueMap = new AsyncLocalValueMap.ManyElementAsyncLocalValueMap(17);
				foreach (KeyValuePair<IAsyncLocal, object> keyValuePair in this._keyValues)
				{
					manyElementAsyncLocalValueMap[keyValuePair.Key] = keyValuePair.Value;
				}
				manyElementAsyncLocalValueMap[key] = value;
				return manyElementAsyncLocalValueMap;
			}

			// Token: 0x06003F8F RID: 16271 RVA: 0x000D4928 File Offset: 0x000D2B28
			public bool TryGetValue(IAsyncLocal key, out object value)
			{
				foreach (KeyValuePair<IAsyncLocal, object> keyValuePair in this._keyValues)
				{
					if (key == keyValuePair.Key)
					{
						value = keyValuePair.Value;
						return true;
					}
				}
				value = null;
				return false;
			}

			// Token: 0x04000D25 RID: 3365
			private readonly KeyValuePair<IAsyncLocal, object>[] _keyValues;
		}

		// Token: 0x020003D2 RID: 978
		private sealed class ManyElementAsyncLocalValueMap : Dictionary<IAsyncLocal, object>, IAsyncLocalValueMap
		{
			// Token: 0x06003F90 RID: 16272 RVA: 0x000D496B File Offset: 0x000D2B6B
			public ManyElementAsyncLocalValueMap(int capacity) : base(capacity)
			{
			}

			// Token: 0x06003F91 RID: 16273 RVA: 0x000D4974 File Offset: 0x000D2B74
			public IAsyncLocalValueMap Set(IAsyncLocal key, object value, bool treatNullValueAsNonexistent)
			{
				int count = base.Count;
				bool flag = base.ContainsKey(key);
				if (value != null || !treatNullValueAsNonexistent)
				{
					AsyncLocalValueMap.ManyElementAsyncLocalValueMap manyElementAsyncLocalValueMap = new AsyncLocalValueMap.ManyElementAsyncLocalValueMap(count + ((!flag) ? 1 : 0));
					foreach (KeyValuePair<IAsyncLocal, object> keyValuePair in this)
					{
						manyElementAsyncLocalValueMap[keyValuePair.Key] = keyValuePair.Value;
					}
					manyElementAsyncLocalValueMap[key] = value;
					return manyElementAsyncLocalValueMap;
				}
				if (!flag)
				{
					return this;
				}
				if (count == 17)
				{
					KeyValuePair<IAsyncLocal, object>[] array = new KeyValuePair<IAsyncLocal, object>[16];
					int num = 0;
					foreach (KeyValuePair<IAsyncLocal, object> keyValuePair2 in this)
					{
						if (key != keyValuePair2.Key)
						{
							array[num++] = keyValuePair2;
						}
					}
					return new AsyncLocalValueMap.MultiElementAsyncLocalValueMap(array);
				}
				AsyncLocalValueMap.ManyElementAsyncLocalValueMap manyElementAsyncLocalValueMap2 = new AsyncLocalValueMap.ManyElementAsyncLocalValueMap(count - 1);
				foreach (KeyValuePair<IAsyncLocal, object> keyValuePair3 in this)
				{
					if (key != keyValuePair3.Key)
					{
						manyElementAsyncLocalValueMap2[keyValuePair3.Key] = keyValuePair3.Value;
					}
				}
				return manyElementAsyncLocalValueMap2;
			}
		}
	}
}
