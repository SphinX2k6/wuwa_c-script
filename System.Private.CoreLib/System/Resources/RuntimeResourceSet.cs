using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace System.Resources
{
	// Token: 0x0200028A RID: 650
	internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable
	{
		// Token: 0x06002EC6 RID: 11974 RVA: 0x00097648 File Offset: 0x00095848
		internal RuntimeResourceSet(string fileName) : this(new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read), false)
		{
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x0009765A File Offset: 0x0009585A
		internal RuntimeResourceSet(Stream stream, bool permitDeserialization = false) : base(false)
		{
			this._resCache = new Dictionary<string, ResourceLocator>(FastResourceComparer.Default);
			this._defaultReader = new ResourceReader(stream, this._resCache, permitDeserialization);
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00097686 File Offset: 0x00095886
		protected override void Dispose(bool disposing)
		{
			if (this._defaultReader == null)
			{
				return;
			}
			if (disposing)
			{
				ResourceReader defaultReader = this._defaultReader;
				if (defaultReader != null)
				{
					defaultReader.Close();
				}
			}
			this._defaultReader = null;
			this._resCache = null;
			this._caseInsensitiveTable = null;
			base.Dispose(disposing);
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x000976C1 File Offset: 0x000958C1
		public override IDictionaryEnumerator GetEnumerator()
		{
			return this.GetEnumeratorHelper();
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x000976C1 File Offset: 0x000958C1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumeratorHelper();
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x000976C9 File Offset: 0x000958C9
		private IDictionaryEnumerator GetEnumeratorHelper()
		{
			ResourceReader defaultReader = this._defaultReader;
			if (defaultReader == null)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_ResourceSet);
			}
			return defaultReader.GetEnumerator();
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x000976E6 File Offset: 0x000958E6
		public override string GetString(string key)
		{
			return (string)this.GetObject(key, false, true);
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x000976F6 File Offset: 0x000958F6
		public override string GetString(string key, bool ignoreCase)
		{
			return (string)this.GetObject(key, ignoreCase, true);
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00097706 File Offset: 0x00095906
		public override object GetObject(string key)
		{
			return this.GetObject(key, false, false);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00097711 File Offset: 0x00095911
		public override object GetObject(string key, bool ignoreCase)
		{
			return this.GetObject(key, ignoreCase, false);
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x0009771C File Offset: 0x0009591C
		private object GetObject(string key, bool ignoreCase, bool isString)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			ResourceReader defaultReader = this._defaultReader;
			Dictionary<string, ResourceLocator> resCache = this._resCache;
			if (defaultReader == null || resCache == null)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_ResourceSet);
			}
			Dictionary<string, ResourceLocator> obj = resCache;
			object obj2;
			lock (obj)
			{
				ResourceLocator value;
				if (resCache.TryGetValue(key, out value))
				{
					obj2 = value.Value;
					if (obj2 != null)
					{
						return obj2;
					}
					int num = value.DataPosition;
					return isString ? defaultReader.LoadString(num) : defaultReader.LoadObject(num);
				}
				else
				{
					int num = defaultReader.FindPosForResource(key);
					if (num >= 0)
					{
						obj2 = RuntimeResourceSet.ReadValue(defaultReader, num, isString, out value);
						resCache[key] = value;
						return obj2;
					}
				}
			}
			if (!ignoreCase)
			{
				return null;
			}
			bool flag2 = false;
			Dictionary<string, ResourceLocator> dictionary = this._caseInsensitiveTable;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, ResourceLocator>(StringComparer.OrdinalIgnoreCase);
				flag2 = true;
			}
			obj = dictionary;
			lock (obj)
			{
				if (flag2)
				{
					ResourceReader.ResourceEnumerator enumeratorInternal = defaultReader.GetEnumeratorInternal();
					while (enumeratorInternal.MoveNext())
					{
						string key2 = (string)enumeratorInternal.Key;
						ResourceLocator value2 = new ResourceLocator(enumeratorInternal.DataPosition, null);
						dictionary.Add(key2, value2);
					}
					this._caseInsensitiveTable = dictionary;
				}
				ResourceLocator value;
				if (!dictionary.TryGetValue(key, out value))
				{
					return null;
				}
				if (value.Value != null)
				{
					return value.Value;
				}
				obj2 = RuntimeResourceSet.ReadValue(defaultReader, value.DataPosition, isString, out value);
				if (value.Value != null)
				{
					dictionary[key] = value;
				}
			}
			return obj2;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x000978D0 File Offset: 0x00095AD0
		private static object ReadValue(ResourceReader reader, int dataPos, bool isString, out ResourceLocator locator)
		{
			object obj;
			ResourceTypeCode value;
			if (isString)
			{
				obj = reader.LoadString(dataPos);
				value = ResourceTypeCode.String;
			}
			else
			{
				obj = reader.LoadObject(dataPos, out value);
			}
			locator = new ResourceLocator(dataPos, ResourceLocator.CanCache(value) ? obj : null);
			return obj;
		}

		// Token: 0x040008BE RID: 2238
		private Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x040008BF RID: 2239
		private ResourceReader _defaultReader;

		// Token: 0x040008C0 RID: 2240
		private Dictionary<string, ResourceLocator> _caseInsensitiveTable;
	}
}
