using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001191 RID: 4497
	public class IProgressBarLeftType
	{
		// Token: 0x060063EE RID: 25582 RVA: 0x000F0568 File Offset: 0x000EE768
		private IProgressBarLeftType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProgressBarLeftType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProgressBarLeftType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProgressBarLeftType_SetValue());
			}
			return result;
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x000F05A0 File Offset: 0x000EE7A0
		public static IProgressBarLeftType Create([Nullable(2)] IProgressBarLeftType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgressBarLeftType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x000F05B3 File Offset: 0x000EE7B3
		public static IProgressBarLeftType CreateFromSetValue([Nullable(2)] IProgressBarLeftType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProgressBarLeftType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x000F05C6 File Offset: 0x000EE7C6
		public IProgressBarLeftType_SetValue ToSetValue()
		{
			return new IProgressBarLeftType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x060063F2 RID: 25586 RVA: 0x000F05D9 File Offset: 0x000EE7D9
		// (set) Token: 0x060063F3 RID: 25587 RVA: 0x000F0604 File Offset: 0x000EE804
		public virtual EProgressBarLeftType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarLeftType.UseCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003BDE RID: 15326
		[Nullable(2)]
		protected IProgressBarLeftType FbInstance;

		// Token: 0x04003BDF RID: 15327
		[Nullable(2)]
		protected IProgressBarLeftType_SetValue PocoInterface;
	}
}
