using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010EF RID: 4335
	public class IInformationViewType
	{
		// Token: 0x06005FCE RID: 24526 RVA: 0x000E792C File Offset: 0x000E5B2C
		private IInformationViewType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInformationViewType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInformationViewType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInformationViewType_SetValue());
			}
			return result;
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x000E7964 File Offset: 0x000E5B64
		public static IInformationViewType Create([Nullable(2)] IInformationViewType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationViewType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x000E7977 File Offset: 0x000E5B77
		public static IInformationViewType CreateFromSetValue([Nullable(2)] IInformationViewType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInformationViewType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x000E798A File Offset: 0x000E5B8A
		public IInformationViewType_SetValue ToSetValue()
		{
			return new IInformationViewType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06005FD2 RID: 24530 RVA: 0x000E799D File Offset: 0x000E5B9D
		// (set) Token: 0x06005FD3 RID: 24531 RVA: 0x000E79C8 File Offset: 0x000E5BC8
		public virtual EInformationViewType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInformationViewType.LevelPlay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003973 RID: 14707
		[Nullable(2)]
		protected IInformationViewType FbInstance;

		// Token: 0x04003974 RID: 14708
		[Nullable(2)]
		protected IInformationViewType_SetValue PocoInterface;
	}
}
