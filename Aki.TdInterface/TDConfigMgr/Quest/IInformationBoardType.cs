using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FB9 RID: 4025
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationBoardType
	{
		// Token: 0x060059BC RID: 22972 RVA: 0x000DA844 File Offset: 0x000D8A44
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

		// Token: 0x060059BD RID: 22973 RVA: 0x000DA87C File Offset: 0x000D8A7C
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

		// Token: 0x060059BE RID: 22974 RVA: 0x000DA88F File Offset: 0x000D8A8F
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

		// Token: 0x060059BF RID: 22975 RVA: 0x000DA8A2 File Offset: 0x000D8AA2
		public IInformationBoardType_SetValue ToSetValue()
		{
			return new IInformationBoardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x000DA8B5 File Offset: 0x000D8AB5
		// (set) Token: 0x060059C1 RID: 22977 RVA: 0x000DA8E0 File Offset: 0x000D8AE0
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

		// Token: 0x04003627 RID: 13863
		[Nullable(2)]
		protected IInformationBoardType FbInstance;

		// Token: 0x04003628 RID: 13864
		[Nullable(2)]
		protected IInformationBoardType_SetValue PocoInterface;
	}
}
