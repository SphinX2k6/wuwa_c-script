using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C64 RID: 7268
	public class IFrequencyPaint : IUiGame
	{
		// Token: 0x06009A90 RID: 39568 RVA: 0x00165A40 File Offset: 0x00163C40
		private IFrequencyPaint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyPaint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyPaint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyPaint_SetValue());
			}
			return result;
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x00165A78 File Offset: 0x00163C78
		public static IFrequencyPaint Create([Nullable(2)] IFrequencyPaint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x00165A8B File Offset: 0x00163C8B
		public static IFrequencyPaint CreateFromSetValue([Nullable(2)] IFrequencyPaint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyPaint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x00165A9E File Offset: 0x00163C9E
		public new IFrequencyPaint_SetValue ToSetValue()
		{
			return new IFrequencyPaint_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06009A94 RID: 39572 RVA: 0x00165AB1 File Offset: 0x00163CB1
		// (set) Token: 0x06009A95 RID: 39573 RVA: 0x00165ADC File Offset: 0x00163CDC
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005EE2 RID: 24290
		[Nullable(2)]
		protected new IFrequencyPaint FbInstance;

		// Token: 0x04005EE3 RID: 24291
		[Nullable(2)]
		protected new IFrequencyPaint_SetValue PocoInterface;
	}
}
