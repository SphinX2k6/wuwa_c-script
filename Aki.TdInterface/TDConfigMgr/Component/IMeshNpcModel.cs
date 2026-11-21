using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000555 RID: 1365
	public class IMeshNpcModel : INpcModelConfig
	{
		// Token: 0x06001BB6 RID: 7094 RVA: 0x00050BD4 File Offset: 0x0004EDD4
		private IMeshNpcModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMeshNpcModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMeshNpcModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMeshNpcModel_SetValue());
			}
			return result;
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00050C0C File Offset: 0x0004EE0C
		public static IMeshNpcModel Create([Nullable(2)] IMeshNpcModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMeshNpcModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00050C1F File Offset: 0x0004EE1F
		public static IMeshNpcModel CreateFromSetValue([Nullable(2)] IMeshNpcModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMeshNpcModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00050C32 File Offset: 0x0004EE32
		public new IMeshNpcModel_SetValue ToSetValue()
		{
			return new IMeshNpcModel_SetValue
			{
				Type = this.Type,
				Mesh = this.Mesh
			};
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00050C51 File Offset: 0x0004EE51
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x00050C7C File Offset: 0x0004EE7C
		public override ENpcModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00050C8A File Offset: 0x0004EE8A
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x00050CB5 File Offset: 0x0004EEB5
		public virtual string Mesh
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mesh;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mesh;
			}
			set
			{
				this.GetOrCreatePoco().Mesh = value;
			}
		}

		// Token: 0x04001443 RID: 5187
		[Nullable(2)]
		protected new IMeshNpcModel FbInstance;

		// Token: 0x04001444 RID: 5188
		[Nullable(2)]
		protected new IMeshNpcModel_SetValue PocoInterface;
	}
}
