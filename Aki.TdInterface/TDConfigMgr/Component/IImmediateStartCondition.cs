using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004AB RID: 1195
	public class IImmediateStartCondition : ISpawnMonsterStartCondition
	{
		// Token: 0x060017FB RID: 6139 RVA: 0x00048FF8 File Offset: 0x000471F8
		private IImmediateStartCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IImmediateStartCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IImmediateStartCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IImmediateStartCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00049030 File Offset: 0x00047230
		public static IImmediateStartCondition Create([Nullable(2)] IImmediateStartCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IImmediateStartCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00049043 File Offset: 0x00047243
		public static IImmediateStartCondition CreateFromSetValue([Nullable(2)] IImmediateStartCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IImmediateStartCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00049056 File Offset: 0x00047256
		public new IImmediateStartCondition_SetValue ToSetValue()
		{
			return new IImmediateStartCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00049069 File Offset: 0x00047269
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x00049094 File Offset: 0x00047294
		public override ESpawnMonsterStartCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400123A RID: 4666
		[Nullable(2)]
		protected new IImmediateStartCondition FbInstance;

		// Token: 0x0400123B RID: 4667
		[Nullable(2)]
		protected new IImmediateStartCondition_SetValue PocoInterface;
	}
}
