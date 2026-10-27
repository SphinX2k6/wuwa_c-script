using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001445 RID: 5189
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubBehaviorTreeFile
	{
		// Token: 0x060075FF RID: 30207 RVA: 0x00119E1E File Offset: 0x0011801E
		public static ISubBehaviorTreeFile Create(ISubBehaviorTreeFile? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubBehaviorTreeFile
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x06007600 RID: 30208 RVA: 0x00119E3D File Offset: 0x0011803D
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x06007601 RID: 30209 RVA: 0x00119E4A File Offset: 0x0011804A
		public virtual string ParentUid
		{
			get
			{
				return this.Instance.ParentUid;
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x00119E57 File Offset: 0x00118057
		public virtual IBehaviorTree Tree
		{
			get
			{
				if (this._TreeInited)
				{
					return this._TreeCache;
				}
				this._TreeInited = true;
				this._TreeCache = IBehaviorTree.Create(this.Instance.Tree);
				return this._TreeCache;
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x06007603 RID: 30211 RVA: 0x00119E8C File Offset: 0x0011808C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> Children
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x00119F04 File Offset: 0x00118104
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> Reference
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x06007605 RID: 30213 RVA: 0x00119F7C File Offset: 0x0011817C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> WeakReference
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x00119FF1 File Offset: 0x001181F1
		public virtual string _Name
		{
			get
			{
				return this.Instance._Name;
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x06007607 RID: 30215 RVA: 0x00119FFE File Offset: 0x001181FE
		public virtual string _Path
		{
			get
			{
				return this.Instance._Path;
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x06007608 RID: 30216 RVA: 0x0011A00B File Offset: 0x0011820B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> EdTextRef
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return null;
			}
		}

		// Token: 0x0400447D RID: 17533
		private ISubBehaviorTreeFile Instance;

		// Token: 0x0400447E RID: 17534
		[Nullable(2)]
		private IBehaviorTree _TreeCache;

		// Token: 0x0400447F RID: 17535
		private bool _TreeInited;

		// Token: 0x04004480 RID: 17536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _ChildrenCache;

		// Token: 0x04004481 RID: 17537
		private bool _ChildrenInited;

		// Token: 0x04004482 RID: 17538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _ReferenceCache;

		// Token: 0x04004483 RID: 17539
		private bool _ReferenceInited;

		// Token: 0x04004484 RID: 17540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> _WeakReferenceCache;

		// Token: 0x04004485 RID: 17541
		private bool _WeakReferenceInited;
	}
}
