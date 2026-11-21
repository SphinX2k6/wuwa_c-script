using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A8D RID: 6797
	public class ICommonBtPlaceholder
	{
		// Token: 0x0600905D RID: 36957 RVA: 0x00153968 File Offset: 0x00151B68
		private ICommonBtPlaceholder_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonBtPlaceholder 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonBtPlaceholder_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonBtPlaceholder_SetValue());
			}
			return result;
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x001539A0 File Offset: 0x00151BA0
		public static ICommonBtPlaceholder Create([Nullable(2)] ICommonBtPlaceholder instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtPlaceholder
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x001539B3 File Offset: 0x00151BB3
		public static ICommonBtPlaceholder CreateFromSetValue([Nullable(2)] ICommonBtPlaceholder_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonBtPlaceholder
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x001539C6 File Offset: 0x00151BC6
		public ICommonBtPlaceholder_SetValue ToSetValue()
		{
			return new ICommonBtPlaceholder_SetValue
			{
				Id = this.Id,
				Name = this.Name,
				Value = this.Value,
				RefTaskIds = this.RefTaskIds
			};
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x06009061 RID: 36961 RVA: 0x001539FD File Offset: 0x00151BFD
		// (set) Token: 0x06009062 RID: 36962 RVA: 0x00153A28 File Offset: 0x00151C28
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

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x06009063 RID: 36963 RVA: 0x00153A36 File Offset: 0x00151C36
		// (set) Token: 0x06009064 RID: 36964 RVA: 0x00153A61 File Offset: 0x00151C61
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x06009065 RID: 36965 RVA: 0x00153A6F File Offset: 0x00151C6F
		// (set) Token: 0x06009066 RID: 36966 RVA: 0x00153A96 File Offset: 0x00151C96
		public virtual ICommonBtOverrideTaskInfoBase Value
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Value;
				}
				ICommonBtPlaceholder_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Value;
			}
			set
			{
				this.GetOrCreatePoco().Value = value;
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x06009067 RID: 36967 RVA: 0x00153AA4 File Offset: 0x00151CA4
		// (set) Token: 0x06009068 RID: 36968 RVA: 0x00153ACB File Offset: 0x00151CCB
		public virtual List<int> RefTaskIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefTaskIds;
				}
				ICommonBtPlaceholder_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefTaskIds;
			}
			set
			{
				this.GetOrCreatePoco().RefTaskIds = value;
			}
		}

		// Token: 0x04005A52 RID: 23122
		[Nullable(2)]
		protected ICommonBtPlaceholder FbInstance;

		// Token: 0x04005A53 RID: 23123
		[Nullable(2)]
		protected ICommonBtPlaceholder_SetValue PocoInterface;
	}
}
