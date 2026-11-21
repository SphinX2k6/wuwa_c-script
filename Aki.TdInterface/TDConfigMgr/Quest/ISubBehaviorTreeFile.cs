using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127E RID: 4734
	public class ISubBehaviorTreeFile
	{
		// Token: 0x06006AA7 RID: 27303 RVA: 0x000FF060 File Offset: 0x000FD260
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

		// Token: 0x06006AA8 RID: 27304 RVA: 0x000FF098 File Offset: 0x000FD298
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

		// Token: 0x06006AA9 RID: 27305 RVA: 0x000FF0AB File Offset: 0x000FD2AB
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

		// Token: 0x06006AAA RID: 27306 RVA: 0x000FF0C0 File Offset: 0x000FD2C0
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

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x000FF13E File Offset: 0x000FD33E
		// (set) Token: 0x06006AAC RID: 27308 RVA: 0x000FF169 File Offset: 0x000FD369
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

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06006AAD RID: 27309 RVA: 0x000FF177 File Offset: 0x000FD377
		// (set) Token: 0x06006AAE RID: 27310 RVA: 0x000FF1A2 File Offset: 0x000FD3A2
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

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06006AAF RID: 27311 RVA: 0x000FF1B0 File Offset: 0x000FD3B0
		// (set) Token: 0x06006AB0 RID: 27312 RVA: 0x000FF211 File Offset: 0x000FD411
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

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06006AB1 RID: 27313 RVA: 0x000FF226 File Offset: 0x000FD426
		// (set) Token: 0x06006AB2 RID: 27314 RVA: 0x000FF24D File Offset: 0x000FD44D
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Children = value;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x000FF25B File Offset: 0x000FD45B
		// (set) Token: 0x06006AB4 RID: 27316 RVA: 0x000FF282 File Offset: 0x000FD482
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().Reference = value;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06006AB5 RID: 27317 RVA: 0x000FF290 File Offset: 0x000FD490
		// (set) Token: 0x06006AB6 RID: 27318 RVA: 0x000FF2B7 File Offset: 0x000FD4B7
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().WeakReference = value;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06006AB7 RID: 27319 RVA: 0x000FF2C5 File Offset: 0x000FD4C5
		// (set) Token: 0x06006AB8 RID: 27320 RVA: 0x000FF2F0 File Offset: 0x000FD4F0
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

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06006AB9 RID: 27321 RVA: 0x000FF2FE File Offset: 0x000FD4FE
		// (set) Token: 0x06006ABA RID: 27322 RVA: 0x000FF329 File Offset: 0x000FD529
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

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06006ABB RID: 27323 RVA: 0x000FF337 File Offset: 0x000FD537
		// (set) Token: 0x06006ABC RID: 27324 RVA: 0x000FF34E File Offset: 0x000FD54E
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
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTextRef;
				}
				return null;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().EdTextRef = value;
			}
		}

		// Token: 0x04003FC4 RID: 16324
		[Nullable(2)]
		protected ISubBehaviorTreeFile FbInstance;

		// Token: 0x04003FC5 RID: 16325
		[Nullable(2)]
		protected ISubBehaviorTreeFile_SetValue PocoInterface;

		// Token: 0x04003FC6 RID: 16326
		private IBehaviorTree _TreeCache;

		// Token: 0x04003FC7 RID: 16327
		private bool _TreeInited;
	}
}
