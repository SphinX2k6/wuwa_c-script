using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002404 RID: 9220
	public class SetAssistCharacterPos : ActionParams
	{
		// Token: 0x0600C8A4 RID: 51364 RVA: 0x001CAA50 File Offset: 0x001C8C50
		private SetAssistCharacterPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetAssistCharacterPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetAssistCharacterPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetAssistCharacterPos_SetValue());
			}
			return result;
		}

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x001CAA88 File Offset: 0x001C8C88
		public static SetAssistCharacterPos Create([Nullable(2)] SetAssistCharacterPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAssistCharacterPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x001CAA9B File Offset: 0x001C8C9B
		public static SetAssistCharacterPos CreateFromSetValue([Nullable(2)] SetAssistCharacterPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetAssistCharacterPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x001CAAAE File Offset: 0x001C8CAE
		public SetAssistCharacterPos_SetValue ToSetValue()
		{
			return new SetAssistCharacterPos_SetValue
			{
				Id = this.Id,
				Pos = this.Pos
			};
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600C8A8 RID: 51368 RVA: 0x001CAACD File Offset: 0x001C8CCD
		// (set) Token: 0x0600C8A9 RID: 51369 RVA: 0x001CAAF8 File Offset: 0x001C8CF8
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0600C8AA RID: 51370 RVA: 0x001CAB08 File Offset: 0x001C8D08
		// (set) Token: 0x0600C8AB RID: 51371 RVA: 0x001CAB69 File Offset: 0x001C8D69
		public virtual PosA Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				if (this.FbInstance != null)
				{
					this._PosCache = PosA.Create(this.FbInstance.Pos);
				}
				else
				{
					SetAssistCharacterPos_SetValue pocoInterface = this.PocoInterface;
					this._PosCache = ((pocoInterface != null) ? pocoInterface.Pos : null);
				}
				return this._PosCache;
			}
			set
			{
				this.GetOrCreatePoco().Pos = value;
				this._PosInited = false;
			}
		}

		// Token: 0x04007709 RID: 30473
		[Nullable(2)]
		protected new SetAssistCharacterPos FbInstance;

		// Token: 0x0400770A RID: 30474
		[Nullable(2)]
		protected SetAssistCharacterPos_SetValue PocoInterface;

		// Token: 0x0400770B RID: 30475
		private PosA _PosCache;

		// Token: 0x0400770C RID: 30476
		private bool _PosInited;
	}
}
