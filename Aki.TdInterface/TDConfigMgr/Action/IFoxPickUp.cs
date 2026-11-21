using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C58 RID: 7256
	public class IFoxPickUp : ILeisureInteractType
	{
		// Token: 0x06009A48 RID: 39496 RVA: 0x00165238 File Offset: 0x00163438
		private IFoxPickUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxPickUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxPickUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxPickUp_SetValue());
			}
			return result;
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x00165270 File Offset: 0x00163470
		public static IFoxPickUp Create([Nullable(2)] IFoxPickUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPickUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x00165283 File Offset: 0x00163483
		public static IFoxPickUp CreateFromSetValue([Nullable(2)] IFoxPickUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxPickUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x00165296 File Offset: 0x00163496
		public new IFoxPickUp_SetValue ToSetValue()
		{
			return new IFoxPickUp_SetValue
			{
				Type = this.Type,
				DataTableIndex = this.DataTableIndex,
				MouthOpen = this.MouthOpen
			};
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x06009A4C RID: 39500 RVA: 0x001652C1 File Offset: 0x001634C1
		// (set) Token: 0x06009A4D RID: 39501 RVA: 0x001652EC File Offset: 0x001634EC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x06009A4E RID: 39502 RVA: 0x001652FA File Offset: 0x001634FA
		// (set) Token: 0x06009A4F RID: 39503 RVA: 0x00165325 File Offset: 0x00163525
		public virtual int DataTableIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DataTableIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DataTableIndex;
			}
			set
			{
				this.GetOrCreatePoco().DataTableIndex = value;
			}
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x06009A50 RID: 39504 RVA: 0x00165334 File Offset: 0x00163534
		// (set) Token: 0x06009A51 RID: 39505 RVA: 0x0016536E File Offset: 0x0016356E
		public virtual bool? MouthOpen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MouthOpen;
				}
				IFoxPickUp_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MouthOpen;
			}
			set
			{
				this.GetOrCreatePoco().MouthOpen = value;
			}
		}

		// Token: 0x04005EC2 RID: 24258
		[Nullable(2)]
		protected new IFoxPickUp FbInstance;

		// Token: 0x04005EC3 RID: 24259
		[Nullable(2)]
		protected new IFoxPickUp_SetValue PocoInterface;
	}
}
