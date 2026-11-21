using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E5 RID: 4325
	public class IInformationBoardType
	{
		// Token: 0x06005F9A RID: 24474 RVA: 0x000E73D0 File Offset: 0x000E55D0
		private IInformationBoardType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInformationBoardType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInformationBoardType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInformationBoardType_SetValue());
			}
			return result;
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x000E7408 File Offset: 0x000E5608
		public static IInformationBoardType Create([Nullable(2)] IInformationBoardType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationBoardType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x000E741B File Offset: 0x000E561B
		public static IInformationBoardType CreateFromSetValue([Nullable(2)] IInformationBoardType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInformationBoardType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x000E742E File Offset: 0x000E562E
		public IInformationBoardType_SetValue ToSetValue()
		{
			return new IInformationBoardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06005F9E RID: 24478 RVA: 0x000E7441 File Offset: 0x000E5641
		// (set) Token: 0x06005F9F RID: 24479 RVA: 0x000E746C File Offset: 0x000E566C
		public virtual EInformationBoardType Type
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

		// Token: 0x0400395C RID: 14684
		[Nullable(2)]
		protected IInformationBoardType FbInstance;

		// Token: 0x0400395D RID: 14685
		[Nullable(2)]
		protected IInformationBoardType_SetValue PocoInterface;
	}
}
