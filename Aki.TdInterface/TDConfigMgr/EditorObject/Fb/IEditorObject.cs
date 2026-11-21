using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.EditorObject;

namespace Aki.TDConfigMgr.EditorObject.Fb
{
	// Token: 0x02000010 RID: 16
	public class IEditorObject
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000148A2 File Offset: 0x00012AA2
		public static IEditorObject Create(IEditorObject? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEditorObject
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000148C1 File Offset: 0x00012AC1
		public virtual TEditorObjectType ObjType
		{
			get
			{
				return (TEditorObjectType)this.Instance.ObjType;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000148D0 File Offset: 0x00012AD0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> Children
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ChildrenInited)
				{
					return this._ChildrenCache;
				}
				this._ChildrenInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int childrenLength = this.Instance.ChildrenLength;
				this._ChildrenCache = new List<string>(childrenLength);
				for (int i = 0; i < childrenLength; i++)
				{
					this._ChildrenCache.Add(this.Instance.Children(i));
				}
				return this._ChildrenCache;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00014948 File Offset: 0x00012B48
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> Reference
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ReferenceInited)
				{
					return this._ReferenceCache;
				}
				this._ReferenceInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int referenceLength = this.Instance.ReferenceLength;
				this._ReferenceCache = new List<string>(referenceLength);
				for (int i = 0; i < referenceLength; i++)
				{
					this._ReferenceCache.Add(this.Instance.Reference(i));
				}
				return this._ReferenceCache;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000149C0 File Offset: 0x00012BC0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> WeakReference
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._WeakReferenceInited)
				{
					return this._WeakReferenceCache;
				}
				this._WeakReferenceInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int weakReferenceLength = this.Instance.WeakReferenceLength;
				this._WeakReferenceCache = new List<string>(weakReferenceLength);
				for (int i = 0; i < weakReferenceLength; i++)
				{
					this._WeakReferenceCache.Add(this.Instance.WeakReference(i));
				}
				return this._WeakReferenceCache;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00014A35 File Offset: 0x00012C35
		[Nullable(2)]
		public virtual string EdPlannedBranch
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00014A38 File Offset: 0x00012C38
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> EdTextRef
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00014A3B File Offset: 0x00012C3B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> _children
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00014A3E File Offset: 0x00012C3E
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> _reference
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				return null;
			}
		}

		// Token: 0x04000028 RID: 40
		private IEditorObject Instance;

		// Token: 0x04000029 RID: 41
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ChildrenCache;

		// Token: 0x0400002A RID: 42
		private bool _ChildrenInited;

		// Token: 0x0400002B RID: 43
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ReferenceCache;

		// Token: 0x0400002C RID: 44
		private bool _ReferenceInited;

		// Token: 0x0400002D RID: 45
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _WeakReferenceCache;

		// Token: 0x0400002E RID: 46
		private bool _WeakReferenceInited;
	}
}
