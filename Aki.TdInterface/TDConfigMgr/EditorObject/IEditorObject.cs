using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.EditorObject.Fb;

namespace Aki.TDConfigMgr.EditorObject
{
	// Token: 0x0200000C RID: 12
	[NullableContext(2)]
	[Nullable(0)]
	public class IEditorObject
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00013A8C File Offset: 0x00011C8C
		[NullableContext(1)]
		private IEditorObject_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEditorObject 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEditorObject_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEditorObject_SetValue());
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00013AC4 File Offset: 0x00011CC4
		[NullableContext(1)]
		public static IEditorObject Create([Nullable(2)] IEditorObject instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEditorObject
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00013AD7 File Offset: 0x00011CD7
		[NullableContext(1)]
		public static IEditorObject CreateFromSetValue([Nullable(2)] IEditorObject_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEditorObject
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00013AEC File Offset: 0x00011CEC
		[NullableContext(1)]
		public IEditorObject_SetValue ToSetValue()
		{
			return new IEditorObject_SetValue
			{
				ObjType = this.ObjType,
				Children = this.Children,
				Reference = this.Reference,
				WeakReference = this.WeakReference,
				EdPlannedBranch = this.EdPlannedBranch,
				EdTextRef = this.EdTextRef,
				_children = this._children,
				_reference = this._reference
			};
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00013B5E File Offset: 0x00011D5E
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00013B89 File Offset: 0x00011D89
		public virtual TEditorObjectType ObjType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ObjType;
				}
				if (this.PocoInterface == null)
				{
					return TEditorObjectType.BehaviorTreeFragment;
				}
				return this.PocoInterface.ObjType;
			}
			set
			{
				this.GetOrCreatePoco().ObjType = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00013B97 File Offset: 0x00011D97
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00013BBE File Offset: 0x00011DBE
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
				IEditorObject_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00013BCC File Offset: 0x00011DCC
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00013BF3 File Offset: 0x00011DF3
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
				IEditorObject_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00013C01 File Offset: 0x00011E01
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00013C28 File Offset: 0x00011E28
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
				IEditorObject_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00013C36 File Offset: 0x00011E36
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00013C4D File Offset: 0x00011E4D
		public virtual string EdPlannedBranch
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdPlannedBranch;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdPlannedBranch = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00013C5B File Offset: 0x00011E5B
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00013C72 File Offset: 0x00011E72
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00013C80 File Offset: 0x00011E80
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00013C97 File Offset: 0x00011E97
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> _children
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
					return this.PocoInterface._children;
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
				this.GetOrCreatePoco()._children = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00013CA5 File Offset: 0x00011EA5
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00013CBC File Offset: 0x00011EBC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> _reference
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
					return this.PocoInterface._reference;
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
				this.GetOrCreatePoco()._reference = value;
			}
		}

		// Token: 0x0400001D RID: 29
		protected IEditorObject FbInstance;

		// Token: 0x0400001E RID: 30
		protected IEditorObject_SetValue PocoInterface;
	}
}
