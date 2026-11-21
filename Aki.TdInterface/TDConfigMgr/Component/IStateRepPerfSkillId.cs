using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007BA RID: 1978
	public class IStateRepPerfSkillId : IStateRepPerfBase
	{
		// Token: 0x06002A33 RID: 10803 RVA: 0x0006F174 File Offset: 0x0006D374
		private IStateRepPerfSkillId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfSkillId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfSkillId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfSkillId_SetValue());
			}
			return result;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x0006F1AC File Offset: 0x0006D3AC
		public static IStateRepPerfSkillId Create([Nullable(2)] IStateRepPerfSkillId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfSkillId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x0006F1BF File Offset: 0x0006D3BF
		public static IStateRepPerfSkillId CreateFromSetValue([Nullable(2)] IStateRepPerfSkillId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfSkillId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0006F1D2 File Offset: 0x0006D3D2
		public new IStateRepPerfSkillId_SetValue ToSetValue()
		{
			return new IStateRepPerfSkillId_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0006F1F1 File Offset: 0x0006D3F1
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x0006F21C File Offset: 0x0006D41C
		public override EStateRepPerfType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStateRepPerfType.SkillId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x0006F22A File Offset: 0x0006D42A
		// (set) Token: 0x06002A3A RID: 10810 RVA: 0x0006F256 File Offset: 0x0006D456
		public virtual long SkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.SkillId;
			}
			set
			{
				this.GetOrCreatePoco().SkillId = value;
			}
		}

		// Token: 0x04001C5F RID: 7263
		[Nullable(2)]
		protected new IStateRepPerfSkillId FbInstance;

		// Token: 0x04001C60 RID: 7264
		[Nullable(2)]
		protected new IStateRepPerfSkillId_SetValue PocoInterface;
	}
}
