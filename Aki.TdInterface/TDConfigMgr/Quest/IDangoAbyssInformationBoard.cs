using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F34 RID: 3892
	[NullableContext(1)]
	[Nullable(0)]
	public class IDangoAbyssInformationBoard : IInformationBoardType
	{
		// Token: 0x0600567E RID: 22142 RVA: 0x000D3F70 File Offset: 0x000D2170
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

		// Token: 0x0600567F RID: 22143 RVA: 0x000D3FA8 File Offset: 0x000D21A8
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

		// Token: 0x06005680 RID: 22144 RVA: 0x000D3FBB File Offset: 0x000D21BB
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

		// Token: 0x06005681 RID: 22145 RVA: 0x000D3FCE File Offset: 0x000D21CE
		public new IDangoAbyssInformationBoard_SetValue ToSetValue()
		{
			return new IDangoAbyssInformationBoard_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x000D3FE1 File Offset: 0x000D21E1
		// (set) Token: 0x06005683 RID: 22147 RVA: 0x000D400C File Offset: 0x000D220C
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

		// Token: 0x0400346F RID: 13423
		[Nullable(2)]
		protected new IDangoAbyssInformationBoard FbInstance;

		// Token: 0x04003470 RID: 13424
		[Nullable(2)]
		protected new IDangoAbyssInformationBoard_SetValue PocoInterface;
	}
}
