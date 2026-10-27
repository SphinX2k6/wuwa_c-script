using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C2 RID: 6338
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientModifySelfTarget : IClientModifyTarget
	{
		// Token: 0x060087F9 RID: 34809 RVA: 0x00141F3C File Offset: 0x0014013C
		private IClientModifySelfTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientModifySelfTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientModifySelfTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientModifySelfTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x00141F74 File Offset: 0x00140174
		public static IClientModifySelfTarget Create([Nullable(2)] IClientModifySelfTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifySelfTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x00141F87 File Offset: 0x00140187
		public static IClientModifySelfTarget CreateFromSetValue([Nullable(2)] IClientModifySelfTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientModifySelfTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x00141F9A File Offset: 0x0014019A
		public new IClientModifySelfTarget_SetValue ToSetValue()
		{
			return new IClientModifySelfTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x060087FD RID: 34813 RVA: 0x00141FAD File Offset: 0x001401AD
		// (set) Token: 0x060087FE RID: 34814 RVA: 0x00141FD8 File Offset: 0x001401D8
		public override EClientModifyTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientModifyTargetType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005579 RID: 21881
		[Nullable(2)]
		protected new IClientModifySelfTarget FbInstance;

		// Token: 0x0400557A RID: 21882
		[Nullable(2)]
		protected new IClientModifySelfTarget_SetValue PocoInterface;
	}
}
