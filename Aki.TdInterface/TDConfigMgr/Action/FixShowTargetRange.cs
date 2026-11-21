using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A9 RID: 6313
	public class FixShowTargetRange : ActionParams
	{
		// Token: 0x06008477 RID: 33911 RVA: 0x0013C498 File Offset: 0x0013A698
		private FixShowTargetRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FixShowTargetRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FixShowTargetRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FixShowTargetRange_SetValue());
			}
			return result;
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x0013C4D0 File Offset: 0x0013A6D0
		public static FixShowTargetRange Create([Nullable(2)] FixShowTargetRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixShowTargetRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x0013C4E3 File Offset: 0x0013A6E3
		public static FixShowTargetRange CreateFromSetValue([Nullable(2)] FixShowTargetRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FixShowTargetRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x0013C4F6 File Offset: 0x0013A6F6
		public FixShowTargetRange_SetValue ToSetValue()
		{
			return new FixShowTargetRange_SetValue
			{
				RangeEntities = this.RangeEntities,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0600847B RID: 33915 RVA: 0x0013C515 File Offset: 0x0013A715
		// (set) Token: 0x0600847C RID: 33916 RVA: 0x0013C53C File Offset: 0x0013A73C
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntities;
				}
				FixShowTargetRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RangeEntities;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntities = value;
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600847D RID: 33917 RVA: 0x0013C54A File Offset: 0x0013A74A
		// (set) Token: 0x0600847E RID: 33918 RVA: 0x0013C575 File Offset: 0x0013A775
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

		// Token: 0x04005451 RID: 21585
		[Nullable(2)]
		protected new FixShowTargetRange FbInstance;

		// Token: 0x04005452 RID: 21586
		[Nullable(2)]
		protected FixShowTargetRange_SetValue PocoInterface;
	}
}
