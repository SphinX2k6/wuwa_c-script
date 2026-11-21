using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x02000288 RID: 648
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceSet : IDisposable, IEnumerable
	{
		// Token: 0x06002EB2 RID: 11954 RVA: 0x0009737B File Offset: 0x0009557B
		protected ResourceSet()
		{
			this._table = new Dictionary<object, object>();
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00005ACC File Offset: 0x00003CCC
		internal ResourceSet(bool _)
		{
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x0009738E File Offset: 0x0009558E
		public ResourceSet(string fileName) : this()
		{
			this.Reader = new ResourceReader(fileName);
			this.ReadResources();
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000973A8 File Offset: 0x000955A8
		public ResourceSet(Stream stream) : this()
		{
			this.Reader = new ResourceReader(stream);
			this.ReadResources();
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000973C2 File Offset: 0x000955C2
		public ResourceSet(IResourceReader reader) : this()
		{
			ArgumentNullException.ThrowIfNull(reader, "reader");
			this.Reader = reader;
			this.ReadResources();
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000973E2 File Offset: 0x000955E2
		public virtual void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x000973EB File Offset: 0x000955EB
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				IResourceReader reader = this.Reader;
				this.Reader = null;
				if (reader != null)
				{
					reader.Close();
				}
			}
			this.Reader = null;
			this._caseInsensitiveTable = null;
			this._table = null;
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000973E2 File Offset: 0x000955E2
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x0009741D File Offset: 0x0009561D
		public virtual Type GetDefaultReader()
		{
			return typeof(ResourceReader);
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00097429 File Offset: 0x00095629
		public virtual Type GetDefaultWriter()
		{
			return Type.GetType("System.Resources.ResourceWriter, System.Resources.Writer", true);
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x00097436 File Offset: 0x00095636
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return this.GetEnumeratorHelper();
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00097436 File Offset: 0x00095636
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumeratorHelper();
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x0009743E File Offset: 0x0009563E
		private IDictionaryEnumerator GetEnumeratorHelper()
		{
			Dictionary<object, object> table = this._table;
			if (table == null)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_ResourceSet);
			}
			return ((IDictionary)table).GetEnumerator();
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x0009745C File Offset: 0x0009565C
		[return: Nullable(2)]
		public virtual string GetString(string name)
		{
			object objectInternal = this.GetObjectInternal(name);
			string text = objectInternal as string;
			if (text != null)
			{
				return text;
			}
			if (objectInternal == null)
			{
				return null;
			}
			throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResourceNotString_Name, name));
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00097494 File Offset: 0x00095694
		[return: Nullable(2)]
		public virtual string GetString(string name, bool ignoreCase)
		{
			object obj = this.GetObjectInternal(name);
			string text = obj as string;
			if (text != null)
			{
				return text;
			}
			if (obj != null)
			{
				throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResourceNotString_Name, name));
			}
			if (!ignoreCase)
			{
				return null;
			}
			obj = this.GetCaseInsensitiveObjectInternal(name);
			string text2 = obj as string;
			if (text2 != null)
			{
				return text2;
			}
			if (obj == null)
			{
				return null;
			}
			throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResourceNotString_Name, name));
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000974F7 File Offset: 0x000956F7
		[return: Nullable(2)]
		public virtual object GetObject(string name)
		{
			return this.GetObjectInternal(name);
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x00097500 File Offset: 0x00095700
		[return: Nullable(2)]
		public virtual object GetObject(string name, bool ignoreCase)
		{
			object objectInternal = this.GetObjectInternal(name);
			if (objectInternal != null || !ignoreCase)
			{
				return objectInternal;
			}
			return this.GetCaseInsensitiveObjectInternal(name);
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00097524 File Offset: 0x00095724
		protected virtual void ReadResources()
		{
			IDictionaryEnumerator enumerator = this.Reader.GetEnumerator();
			while (enumerator.MoveNext())
			{
				this._table.Add(enumerator.Key, enumerator.Value);
			}
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00097560 File Offset: 0x00095760
		private object GetObjectInternal(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			Dictionary<object, object> table = this._table;
			if (table == null)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_ResourceSet);
			}
			object result;
			table.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00097598 File Offset: 0x00095798
		private object GetCaseInsensitiveObjectInternal(string name)
		{
			Dictionary<object, object> table = this._table;
			if (table == null)
			{
				throw new ObjectDisposedException(null, SR.ObjectDisposed_ResourceSet);
			}
			Dictionary<object, object> dictionary = table;
			Dictionary<string, object> dictionary2 = this._caseInsensitiveTable;
			if (dictionary2 == null)
			{
				dictionary2 = new Dictionary<string, object>(dictionary.Count, StringComparer.OrdinalIgnoreCase);
				foreach (KeyValuePair<object, object> keyValuePair in dictionary)
				{
					string text = keyValuePair.Key as string;
					if (text != null)
					{
						dictionary2.Add(text, keyValuePair.Value);
					}
				}
				this._caseInsensitiveTable = dictionary2;
			}
			object result;
			dictionary2.TryGetValue(name, out result);
			return result;
		}

		// Token: 0x040008A5 RID: 2213
		[Nullable(2)]
		protected IResourceReader Reader;

		// Token: 0x040008A6 RID: 2214
		private Dictionary<object, object> _table;

		// Token: 0x040008A7 RID: 2215
		private Dictionary<string, object> _caseInsensitiveTable;
	}
}
