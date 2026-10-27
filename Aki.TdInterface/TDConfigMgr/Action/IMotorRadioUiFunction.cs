using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C22 RID: 7202
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorRadioUiFunction : EnableFunction
	{
		// Token: 0x06009A87 RID: 39559 RVA: 0x0016361C File Offset: 0x0016181C
		private IMotorRadioUiFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorRadioUiFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorRadioUiFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorRadioUiFunction_SetValue());
			}
			return result;
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x00163654 File Offset: 0x00161854
		public static IMotorRadioUiFunction Create([Nullable(2)] IMotorRadioUiFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioUiFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x00163667 File Offset: 0x00161867
		public static IMotorRadioUiFunction CreateFromSetValue([Nullable(2)] IMotorRadioUiFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorRadioUiFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x0016367A File Offset: 0x0016187A
		public new IMotorRadioUiFunction_SetValue ToSetValue()
		{
			return new IMotorRadioUiFunction_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode
			};
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x06009A8B RID: 39563 RVA: 0x00163699 File Offset: 0x00161899
		// (set) Token: 0x06009A8C RID: 39564 RVA: 0x001636C4 File Offset: 0x001618C4
		public override EEnableFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x06009A8D RID: 39565 RVA: 0x001636D2 File Offset: 0x001618D2
		// (set) Token: 0x06009A8E RID: 39566 RVA: 0x001636F9 File Offset: 0x001618F9
		public virtual IMotorRadioOperationRestriction DisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayMode;
				}
				IMotorRadioUiFunction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayMode;
			}
			set
			{
				this.GetOrCreatePoco().DisplayMode = value;
			}
		}

		// Token: 0x04005DFA RID: 24058
		[Nullable(2)]
		protected new IMotorRadioUiFunction FbInstance;

		// Token: 0x04005DFB RID: 24059
		[Nullable(2)]
		protected new IMotorRadioUiFunction_SetValue PocoInterface;
	}
}
