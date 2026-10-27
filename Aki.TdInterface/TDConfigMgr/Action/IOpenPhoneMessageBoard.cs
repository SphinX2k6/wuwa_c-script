using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA4 RID: 7332
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenPhoneMessageBoard : IPhoneSystemInteractBase
	{
		// Token: 0x06009D5D RID: 40285 RVA: 0x00168704 File Offset: 0x00166904
		private IOpenPhoneMessageBoard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenPhoneMessageBoard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenPhoneMessageBoard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenPhoneMessageBoard_SetValue());
			}
			return result;
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x0016873C File Offset: 0x0016693C
		public static IOpenPhoneMessageBoard Create([Nullable(2)] IOpenPhoneMessageBoard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenPhoneMessageBoard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x0016874F File Offset: 0x0016694F
		public static IOpenPhoneMessageBoard CreateFromSetValue([Nullable(2)] IOpenPhoneMessageBoard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenPhoneMessageBoard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x00168762 File Offset: 0x00166962
		public new IOpenPhoneMessageBoard_SetValue ToSetValue()
		{
			return new IOpenPhoneMessageBoard_SetValue
			{
				Type = this.Type,
				PhoneBoardType = this.PhoneBoardType
			};
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x06009D61 RID: 40289 RVA: 0x00168781 File Offset: 0x00166981
		// (set) Token: 0x06009D62 RID: 40290 RVA: 0x001687AC File Offset: 0x001669AC
		public override EPhoneSystemInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneSystemInteractType.SendPhoneMessage;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x06009D63 RID: 40291 RVA: 0x001687BC File Offset: 0x001669BC
		// (set) Token: 0x06009D64 RID: 40292 RVA: 0x0016881D File Offset: 0x00166A1D
		public virtual IMessageBoard PhoneBoardType
		{
			get
			{
				if (this._PhoneBoardTypeInited)
				{
					return this._PhoneBoardTypeCache;
				}
				this._PhoneBoardTypeInited = true;
				if (this.FbInstance != null)
				{
					this._PhoneBoardTypeCache = IMessageBoard.Create(this.FbInstance.PhoneBoardType);
				}
				else
				{
					IOpenPhoneMessageBoard_SetValue pocoInterface = this.PocoInterface;
					this._PhoneBoardTypeCache = ((pocoInterface != null) ? pocoInterface.PhoneBoardType : null);
				}
				return this._PhoneBoardTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().PhoneBoardType = value;
				this._PhoneBoardTypeInited = false;
			}
		}

		// Token: 0x04005F44 RID: 24388
		[Nullable(2)]
		protected new IOpenPhoneMessageBoard FbInstance;

		// Token: 0x04005F45 RID: 24389
		[Nullable(2)]
		protected new IOpenPhoneMessageBoard_SetValue PocoInterface;

		// Token: 0x04005F46 RID: 24390
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x04005F47 RID: 24391
		private bool _PhoneBoardTypeInited;
	}
}
