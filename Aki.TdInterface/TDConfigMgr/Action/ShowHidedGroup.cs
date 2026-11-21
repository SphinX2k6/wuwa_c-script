using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246D RID: 9325
	public class ShowHidedGroup : ActionParams
	{
		// Token: 0x0600CAED RID: 51949 RVA: 0x001CF1D0 File Offset: 0x001CD3D0
		private ShowHidedGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ShowHidedGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ShowHidedGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ShowHidedGroup_SetValue());
			}
			return result;
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x001CF208 File Offset: 0x001CD408
		public static ShowHidedGroup Create([Nullable(2)] ShowHidedGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ShowHidedGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x001CF21B File Offset: 0x001CD41B
		public static ShowHidedGroup CreateFromSetValue([Nullable(2)] ShowHidedGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ShowHidedGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x001CF22E File Offset: 0x001CD42E
		public ShowHidedGroup_SetValue ToSetValue()
		{
			return new ShowHidedGroup_SetValue
			{
				GroupKey = this.GroupKey,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600CAF1 RID: 51953 RVA: 0x001CF24D File Offset: 0x001CD44D
		// (set) Token: 0x0600CAF2 RID: 51954 RVA: 0x001CF278 File Offset: 0x001CD478
		public virtual string GroupKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.GroupKey;
			}
			set
			{
				this.GetOrCreatePoco().GroupKey = value;
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0600CAF3 RID: 51955 RVA: 0x001CF286 File Offset: 0x001CD486
		// (set) Token: 0x0600CAF4 RID: 51956 RVA: 0x001CF2B1 File Offset: 0x001CD4B1
		public virtual bool DelayShow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayShow;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayShow;
			}
			set
			{
				this.GetOrCreatePoco().DelayShow = value;
			}
		}

		// Token: 0x04007843 RID: 30787
		[Nullable(2)]
		protected new ShowHidedGroup FbInstance;

		// Token: 0x04007844 RID: 30788
		[Nullable(2)]
		protected ShowHidedGroup_SetValue PocoInterface;
	}
}
