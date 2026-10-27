using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C0E RID: 7182
	[NullableContext(1)]
	[Nullable(0)]
	public class IMorseCode : IUiGame
	{
		// Token: 0x060099F7 RID: 39415 RVA: 0x001623E4 File Offset: 0x001605E4
		private IMorseCode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMorseCode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMorseCode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMorseCode_SetValue());
			}
			return result;
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x0016241C File Offset: 0x0016061C
		public static IMorseCode Create([Nullable(2)] IMorseCode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMorseCode
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x0016242F File Offset: 0x0016062F
		public static IMorseCode CreateFromSetValue([Nullable(2)] IMorseCode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMorseCode
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x00162442 File Offset: 0x00160642
		public new IMorseCode_SetValue ToSetValue()
		{
			return new IMorseCode_SetValue
			{
				Type = this.Type,
				MorseCodeId = this.MorseCodeId
			};
		}

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x060099FB RID: 39419 RVA: 0x00162461 File Offset: 0x00160661
		// (set) Token: 0x060099FC RID: 39420 RVA: 0x0016248C File Offset: 0x0016068C
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

		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x060099FD RID: 39421 RVA: 0x0016249A File Offset: 0x0016069A
		// (set) Token: 0x060099FE RID: 39422 RVA: 0x001624C5 File Offset: 0x001606C5
		public virtual string MorseCodeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MorseCodeId;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MorseCodeId;
			}
			set
			{
				this.GetOrCreatePoco().MorseCodeId = value;
			}
		}

		// Token: 0x04005DB2 RID: 23986
		[Nullable(2)]
		protected new IMorseCode FbInstance;

		// Token: 0x04005DB3 RID: 23987
		[Nullable(2)]
		protected new IMorseCode_SetValue PocoInterface;
	}
}
