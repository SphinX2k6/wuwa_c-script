using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DEC RID: 7660
	[NullableContext(1)]
	[Nullable(0)]
	public class ISeamlessTeleportFinishConfig
	{
		// Token: 0x0600A3F3 RID: 41971 RVA: 0x0017406C File Offset: 0x0017226C
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

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x001740A4 File Offset: 0x001722A4
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

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x001740B7 File Offset: 0x001722B7
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

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x001740CA File Offset: 0x001722CA
		public ISeamlessTeleportFinishConfig_SetValue ToSetValue()
		{
			return new ISeamlessTeleportFinishConfig_SetValue
			{
				IsNotStopScreenEffect = this.IsNotStopScreenEffect,
				EffectExtraState = this.EffectExtraState
			};
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x001740EC File Offset: 0x001722EC
		// (set) Token: 0x0600A3F8 RID: 41976 RVA: 0x00174126 File Offset: 0x00172326
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

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600A3F9 RID: 41977 RVA: 0x00174134 File Offset: 0x00172334
		// (set) Token: 0x0600A3FA RID: 41978 RVA: 0x0017416E File Offset: 0x0017236E
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

		// Token: 0x0400623B RID: 25147
		[Nullable(2)]
		protected ISeamlessTeleportFinishConfig FbInstance;

		// Token: 0x0400623C RID: 25148
		[Nullable(2)]
		protected ISeamlessTeleportFinishConfig_SetValue PocoInterface;
	}
}
