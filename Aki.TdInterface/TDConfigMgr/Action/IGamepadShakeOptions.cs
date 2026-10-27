using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC9 RID: 6857
	[NullableContext(1)]
	[Nullable(0)]
	public class IGamepadShakeOptions
	{
		// Token: 0x0600930A RID: 37642 RVA: 0x00155848 File Offset: 0x00153A48
		private IGamepadShakeOptions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGamepadShakeOptions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGamepadShakeOptions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGamepadShakeOptions_SetValue());
			}
			return result;
		}

		// Token: 0x0600930B RID: 37643 RVA: 0x00155880 File Offset: 0x00153A80
		public static IGamepadShakeOptions Create([Nullable(2)] IGamepadShakeOptions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamepadShakeOptions
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x00155893 File Offset: 0x00153A93
		public static IGamepadShakeOptions CreateFromSetValue([Nullable(2)] IGamepadShakeOptions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGamepadShakeOptions
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600930D RID: 37645 RVA: 0x001558A6 File Offset: 0x00153AA6
		public IGamepadShakeOptions_SetValue ToSetValue()
		{
			return new IGamepadShakeOptions_SetValue
			{
				KuroForceFeedbackEffect = this.KuroForceFeedbackEffect,
				GamepadShakeConfig = this.GamepadShakeConfig
			};
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0600930E RID: 37646 RVA: 0x001558C5 File Offset: 0x00153AC5
		// (set) Token: 0x0600930F RID: 37647 RVA: 0x001558F0 File Offset: 0x00153AF0
		public virtual string KuroForceFeedbackEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KuroForceFeedbackEffect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.KuroForceFeedbackEffect;
			}
			set
			{
				this.GetOrCreatePoco().KuroForceFeedbackEffect = value;
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x06009310 RID: 37648 RVA: 0x001558FE File Offset: 0x00153AFE
		// (set) Token: 0x06009311 RID: 37649 RVA: 0x00155925 File Offset: 0x00153B25
		public virtual IGamepadShakeConfig GamepadShakeConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GamepadShakeConfig;
				}
				IGamepadShakeOptions_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GamepadShakeConfig;
			}
			set
			{
				this.GetOrCreatePoco().GamepadShakeConfig = value;
			}
		}

		// Token: 0x04005A72 RID: 23154
		[Nullable(2)]
		protected IGamepadShakeOptions FbInstance;

		// Token: 0x04005A73 RID: 23155
		[Nullable(2)]
		protected IGamepadShakeOptions_SetValue PocoInterface;
	}
}
