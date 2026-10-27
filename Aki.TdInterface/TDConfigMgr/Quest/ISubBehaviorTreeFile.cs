using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200114E RID: 4430
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubBehaviorTreeFile
	{
		// Token: 0x060064A0 RID: 25760 RVA: 0x000F1D9C File Offset: 0x000EFF9C
		private ISubBehaviorTreeFile_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubBehaviorTreeFile 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubBehaviorTreeFile_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubBehaviorTreeFile_SetValue());
			}
			return result;
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x000F1DD4 File Offset: 0x000EFFD4
		public static ISubBehaviorTreeFile Create([Nullable(2)] ISubBehaviorTreeFile instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubBehaviorTreeFile
			{
				FbInstance = instance
			};
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x000F1DE7 File Offset: 0x000EFFE7
		public static ISubBehaviorTreeFile CreateFromSetValue([Nullable(2)] ISubBehaviorTreeFile_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubBehaviorTreeFile
			{
				PocoInterface = value
			};
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x000F1DFC File Offset: 0x000EFFFC
		public ISubBehaviorTreeFile_SetValue ToSetValue()
		{
			return new ISubBehaviorTreeFile_SetValue
			{
				Id = this.Id,
				ParentUid = this.ParentUid,
				Tree = this.Tree,
				Children = this.Children,
				Reference = this.Reference,
				WeakReference = this.WeakReference,
				_name = this._Name,
				_path = this._Path,
				EdTextRef = this.EdTextRef
			};
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x060064A4 RID: 25764 RVA: 0x000F1E7A File Offset: 0x000F007A
		// (set) Token: 0x060064A5 RID: 25765 RVA: 0x000F1EA5 File Offset: 0x000F00A5
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x060064A6 RID: 25766 RVA: 0x000F1EB3 File Offset: 0x000F00B3
		// (set) Token: 0x060064A7 RID: 25767 RVA: 0x000F1EDE File Offset: 0x000F00DE
		public virtual string ParentUid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ParentUid;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ParentUid;
			}
			set
			{
				this.GetOrCreatePoco().ParentUid = value;
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x060064A8 RID: 25768 RVA: 0x000F1EEC File Offset: 0x000F00EC
		// (set) Token: 0x060064A9 RID: 25769 RVA: 0x000F1F4D File Offset: 0x000F014D
		public virtual IBehaviorTree Tree
		{
			get
			{
				if (this._TreeInited)
				{
					return this._TreeCache;
				}
				this._TreeInited = true;
				if (this.FbInstance != null)
				{
					this._TreeCache = IBehaviorTree.Create(this.FbInstance.Tree);
				}
				else
				{
					ISubBehaviorTreeFile_SetValue pocoInterface = this.PocoInterface;
					this._TreeCache = ((pocoInterface != null) ? pocoInterface.Tree : null);
				}
				return this._TreeCache;
			}
			set
			{
				this.GetOrCreatePoco().Tree = value;
				this._TreeInited = false;
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x060064AA RID: 25770 RVA: 0x000F1F62 File Offset: 0x000F0162
		// (set) Token: 0x060064AB RID: 25771 RVA: 0x000F1F89 File Offset: 0x000F0189
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
				if (this.FbInstance != null)
				{
					return this.FbInstance.Children;
				}
				ISubBehaviorTreeFile_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Children;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Children = value;
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x000F1F97 File Offset: 0x000F0197
		// (set) Token: 0x060064AD RID: 25773 RVA: 0x000F1FBE File Offset: 0x000F01BE
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
				if (this.FbInstance != null)
				{
					return this.FbInstance.Reference;
				}
				ISubBehaviorTreeFile_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Reference;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Reference = value;
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x060064AE RID: 25774 RVA: 0x000F1FCC File Offset: 0x000F01CC
		// (set) Token: 0x060064AF RID: 25775 RVA: 0x000F1FF3 File Offset: 0x000F01F3
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
				if (this.FbInstance != null)
				{
					return this.FbInstance.WeakReference;
				}
				ISubBehaviorTreeFile_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.WeakReference;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().WeakReference = value;
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x060064B0 RID: 25776 RVA: 0x000F2001 File Offset: 0x000F0201
		// (set) Token: 0x060064B1 RID: 25777 RVA: 0x000F202C File Offset: 0x000F022C
		public virtual string _Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface._name;
			}
			set
			{
				this.GetOrCreatePoco()._name = value;
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x060064B2 RID: 25778 RVA: 0x000F203A File Offset: 0x000F023A
		// (set) Token: 0x060064B3 RID: 25779 RVA: 0x000F2065 File Offset: 0x000F0265
		public virtual string _Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface._path;
			}
			set
			{
				this.GetOrCreatePoco()._path = value;
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x060064B4 RID: 25780 RVA: 0x000F2073 File Offset: 0x000F0273
		// (set) Token: 0x060064B5 RID: 25781 RVA: 0x000F208A File Offset: 0x000F028A
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
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTextRef;
				}
				return null;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().EdTextRef = value;
			}
		}

		// Token: 0x04003C71 RID: 15473
		[Nullable(2)]
		protected ISubBehaviorTreeFile FbInstance;

		// Token: 0x04003C72 RID: 15474
		[Nullable(2)]
		protected ISubBehaviorTreeFile_SetValue PocoInterface;

		// Token: 0x04003C73 RID: 15475
		private IBehaviorTree _TreeCache;

		// Token: 0x04003C74 RID: 15476
		private bool _TreeInited;
	}
}
