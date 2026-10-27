using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FC3 RID: 4035
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationViewType
	{
		// Token: 0x060059F0 RID: 23024 RVA: 0x000DADA0 File Offset: 0x000D8FA0
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

		// Token: 0x060059F1 RID: 23025 RVA: 0x000DADD8 File Offset: 0x000D8FD8
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

		// Token: 0x060059F2 RID: 23026 RVA: 0x000DADEB File Offset: 0x000D8FEB
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

		// Token: 0x060059F3 RID: 23027 RVA: 0x000DADFE File Offset: 0x000D8FFE
		public IInformationViewType_SetValue ToSetValue()
		{
			return new IInformationViewType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x060059F4 RID: 23028 RVA: 0x000DAE11 File Offset: 0x000D9011
		// (set) Token: 0x060059F5 RID: 23029 RVA: 0x000DAE3C File Offset: 0x000D903C
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

		// Token: 0x0400363E RID: 13886
		[Nullable(2)]
		protected IInformationViewType FbInstance;

		// Token: 0x0400363F RID: 13887
		[Nullable(2)]
		protected IInformationViewType_SetValue PocoInterface;
	}
}
