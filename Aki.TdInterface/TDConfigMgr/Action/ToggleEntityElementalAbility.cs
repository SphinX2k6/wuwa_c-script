using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AF RID: 9391
	public class ToggleEntityElementalAbility : ActionParams
	{
		// Token: 0x0600CC40 RID: 52288 RVA: 0x001D1A30 File Offset: 0x001CFC30
		private ToggleEntityElementalAbility_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleEntityElementalAbility 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleEntityElementalAbility_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleEntityElementalAbility_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC41 RID: 52289 RVA: 0x001D1A68 File Offset: 0x001CFC68
		public static ToggleEntityElementalAbility Create([Nullable(2)] ToggleEntityElementalAbility instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleEntityElementalAbility
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC42 RID: 52290 RVA: 0x001D1A7B File Offset: 0x001CFC7B
		public static ToggleEntityElementalAbility CreateFromSetValue([Nullable(2)] ToggleEntityElementalAbility_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleEntityElementalAbility
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC43 RID: 52291 RVA: 0x001D1A8E File Offset: 0x001CFC8E
		public ToggleEntityElementalAbility_SetValue ToSetValue()
		{
			return new ToggleEntityElementalAbility_SetValue
			{
				EntityId = this.EntityId,
				Enable = this.Enable
			};
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x0600CC44 RID: 52292 RVA: 0x001D1AAD File Offset: 0x001CFCAD
		// (set) Token: 0x0600CC45 RID: 52293 RVA: 0x001D1AD8 File Offset: 0x001CFCD8
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0600CC46 RID: 52294 RVA: 0x001D1AE6 File Offset: 0x001CFCE6
		// (set) Token: 0x0600CC47 RID: 52295 RVA: 0x001D1B11 File Offset: 0x001CFD11
		public virtual bool Enable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Enable;
				}
				return this.PocoInterface != null && this.PocoInterface.Enable;
			}
			set
			{
				this.GetOrCreatePoco().Enable = value;
			}
		}

		// Token: 0x04007910 RID: 30992
		[Nullable(2)]
		protected new ToggleEntityElementalAbility FbInstance;

		// Token: 0x04007911 RID: 30993
		[Nullable(2)]
		protected ToggleEntityElementalAbility_SetValue PocoInterface;
	}
}
