using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200159D RID: 5533
	public class ISubBehaviorTreeFile
	{
		// Token: 0x06007CC7 RID: 31943 RVA: 0x001288F2 File Offset: 0x00126AF2
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

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x06007CC8 RID: 31944 RVA: 0x00128911 File Offset: 0x00126B11
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x0012891E File Offset: 0x00126B1E
		public virtual string ParentUid
		{
			get
			{
				return this.Instance.ParentUid;
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06007CCA RID: 31946 RVA: 0x0012892B File Offset: 0x00126B2B
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

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x00128960 File Offset: 0x00126B60
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

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x06007CCC RID: 31948 RVA: 0x001289D8 File Offset: 0x00126BD8
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

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x06007CCD RID: 31949 RVA: 0x00128A50 File Offset: 0x00126C50
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

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x06007CCE RID: 31950 RVA: 0x00128AC5 File Offset: 0x00126CC5
		public virtual string _Name
		{
			get
			{
				return this.Instance._Name;
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x06007CCF RID: 31951 RVA: 0x00128AD2 File Offset: 0x00126CD2
		public virtual string _Path
		{
			get
			{
				return this.Instance._Path;
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06007CD0 RID: 31952 RVA: 0x00128ADF File Offset: 0x00126CDF
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

		// Token: 0x04004813 RID: 18451
		private ISubBehaviorTreeFile Instance;

		// Token: 0x04004814 RID: 18452
		[Nullable(2)]
		private IBehaviorTree _TreeCache;

		// Token: 0x04004815 RID: 18453
		private bool _TreeInited;

		// Token: 0x04004816 RID: 18454
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ChildrenCache;

		// Token: 0x04004817 RID: 18455
		private bool _ChildrenInited;

		// Token: 0x04004818 RID: 18456
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _ReferenceCache;

		// Token: 0x04004819 RID: 18457
		private bool _ReferenceInited;

		// Token: 0x0400481A RID: 18458
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<string> _WeakReferenceCache;

		// Token: 0x0400481B RID: 18459
		private bool _WeakReferenceInited;
	}
}
