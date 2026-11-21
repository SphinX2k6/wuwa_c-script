using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200201F RID: 8223
	public class ISeamlessTeleportFinishConfig
	{
		// Token: 0x0600AE9B RID: 44699 RVA: 0x00189A74 File Offset: 0x00187C74
		private ISeamlessTeleportFinishConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISeamlessTeleportFinishConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISeamlessTeleportFinishConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISeamlessTeleportFinishConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE9C RID: 44700 RVA: 0x00189AAC File Offset: 0x00187CAC
		public static ISeamlessTeleportFinishConfig Create([Nullable(2)] ISeamlessTeleportFinishConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISeamlessTeleportFinishConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE9D RID: 44701 RVA: 0x00189ABF File Offset: 0x00187CBF
		public static ISeamlessTeleportFinishConfig CreateFromSetValue([Nullable(2)] ISeamlessTeleportFinishConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISeamlessTeleportFinishConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE9E RID: 44702 RVA: 0x00189AD2 File Offset: 0x00187CD2
		public ISeamlessTeleportFinishConfig_SetValue ToSetValue()
		{
			return new ISeamlessTeleportFinishConfig_SetValue
			{
				IsNotStopScreenEffect = this.IsNotStopScreenEffect,
				EffectExtraState = this.EffectExtraState
			};
		}

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600AE9F RID: 44703 RVA: 0x00189AF4 File Offset: 0x00187CF4
		// (set) Token: 0x0600AEA0 RID: 44704 RVA: 0x00189B2E File Offset: 0x00187D2E
		public virtual bool? IsNotStopScreenEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNotStopScreenEffect;
				}
				ISeamlessTeleportFinishConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNotStopScreenEffect;
			}
			set
			{
				this.GetOrCreatePoco().IsNotStopScreenEffect = value;
			}
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x00189B3C File Offset: 0x00187D3C
		// (set) Token: 0x0600AEA2 RID: 44706 RVA: 0x00189B76 File Offset: 0x00187D76
		public virtual int? EffectExtraState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectExtraState;
				}
				ISeamlessTeleportFinishConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectExtraState;
			}
			set
			{
				this.GetOrCreatePoco().EffectExtraState = value;
			}
		}

		// Token: 0x04006812 RID: 26642
		[Nullable(2)]
		protected ISeamlessTeleportFinishConfig FbInstance;

		// Token: 0x04006813 RID: 26643
		[Nullable(2)]
		protected ISeamlessTeleportFinishConfig_SetValue PocoInterface;
	}
}
