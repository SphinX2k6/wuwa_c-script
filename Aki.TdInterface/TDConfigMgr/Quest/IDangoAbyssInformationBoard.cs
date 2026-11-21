using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200104A RID: 4170
	public class IDangoAbyssInformationBoard : IInformationBoardType
	{
		// Token: 0x06005BFA RID: 23546 RVA: 0x000E0118 File Offset: 0x000DE318
		private IDangoAbyssInformationBoard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDangoAbyssInformationBoard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDangoAbyssInformationBoard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDangoAbyssInformationBoard_SetValue());
			}
			return result;
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x000E0150 File Offset: 0x000DE350
		public static IDangoAbyssInformationBoard Create([Nullable(2)] IDangoAbyssInformationBoard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDangoAbyssInformationBoard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x000E0163 File Offset: 0x000DE363
		public static IDangoAbyssInformationBoard CreateFromSetValue([Nullable(2)] IDangoAbyssInformationBoard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDangoAbyssInformationBoard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x000E0176 File Offset: 0x000DE376
		public new IDangoAbyssInformationBoard_SetValue ToSetValue()
		{
			return new IDangoAbyssInformationBoard_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06005BFE RID: 23550 RVA: 0x000E0189 File Offset: 0x000DE389
		// (set) Token: 0x06005BFF RID: 23551 RVA: 0x000E01B4 File Offset: 0x000DE3B4
		public override EInformationBoardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInformationBoardType.DangoAbyss;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400377C RID: 14204
		[Nullable(2)]
		protected new IDangoAbyssInformationBoard FbInstance;

		// Token: 0x0400377D RID: 14205
		[Nullable(2)]
		protected new IDangoAbyssInformationBoard_SetValue PocoInterface;
	}
}
