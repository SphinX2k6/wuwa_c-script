using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C70 RID: 7280
	public class IGamepadShakeOptions
	{
		// Token: 0x06009AC8 RID: 39624 RVA: 0x00166068 File Offset: 0x00164268
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

		// Token: 0x06009AC9 RID: 39625 RVA: 0x001660A0 File Offset: 0x001642A0
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

		// Token: 0x06009ACA RID: 39626 RVA: 0x001660B3 File Offset: 0x001642B3
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

		// Token: 0x06009ACB RID: 39627 RVA: 0x001660C6 File Offset: 0x001642C6
		public IGamepadShakeOptions_SetValue ToSetValue()
		{
			return new IGamepadShakeOptions_SetValue
			{
				KuroForceFeedbackEffect = this.KuroForceFeedbackEffect,
				GamepadShakeConfig = this.GamepadShakeConfig
			};
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06009ACC RID: 39628 RVA: 0x001660E5 File Offset: 0x001642E5
		// (set) Token: 0x06009ACD RID: 39629 RVA: 0x00166110 File Offset: 0x00164310
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

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06009ACE RID: 39630 RVA: 0x0016611E File Offset: 0x0016431E
		// (set) Token: 0x06009ACF RID: 39631 RVA: 0x00166145 File Offset: 0x00164345
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

		// Token: 0x04005EFC RID: 24316
		[Nullable(2)]
		protected IGamepadShakeOptions FbInstance;

		// Token: 0x04005EFD RID: 24317
		[Nullable(2)]
		protected IGamepadShakeOptions_SetValue PocoInterface;
	}
}
