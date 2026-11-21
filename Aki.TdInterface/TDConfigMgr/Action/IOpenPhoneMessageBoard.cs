using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EAB RID: 7851
	public class IOpenPhoneMessageBoard : IPhoneSystemInteractBase
	{
		// Token: 0x0600A70B RID: 42763 RVA: 0x0017C364 File Offset: 0x0017A564
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

		// Token: 0x0600A70C RID: 42764 RVA: 0x0017C39C File Offset: 0x0017A59C
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

		// Token: 0x0600A70D RID: 42765 RVA: 0x0017C3AF File Offset: 0x0017A5AF
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

		// Token: 0x0600A70E RID: 42766 RVA: 0x0017C3C2 File Offset: 0x0017A5C2
		public new IOpenPhoneMessageBoard_SetValue ToSetValue()
		{
			return new IOpenPhoneMessageBoard_SetValue
			{
				Type = this.Type,
				PhoneBoardType = this.PhoneBoardType
			};
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600A70F RID: 42767 RVA: 0x0017C3E1 File Offset: 0x0017A5E1
		// (set) Token: 0x0600A710 RID: 42768 RVA: 0x0017C40C File Offset: 0x0017A60C
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

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600A711 RID: 42769 RVA: 0x0017C41C File Offset: 0x0017A61C
		// (set) Token: 0x0600A712 RID: 42770 RVA: 0x0017C47D File Offset: 0x0017A67D
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

		// Token: 0x040064A0 RID: 25760
		[Nullable(2)]
		protected new IOpenPhoneMessageBoard FbInstance;

		// Token: 0x040064A1 RID: 25761
		[Nullable(2)]
		protected new IOpenPhoneMessageBoard_SetValue PocoInterface;

		// Token: 0x040064A2 RID: 25762
		private IMessageBoard _PhoneBoardTypeCache;

		// Token: 0x040064A3 RID: 25763
		private bool _PhoneBoardTypeInited;
	}
}
