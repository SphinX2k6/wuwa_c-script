using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001025 RID: 4133
	[NullableContext(1)]
	[Nullable(0)]
	public class INewHandInItemsBase
	{
		// Token: 0x06005C34 RID: 23604 RVA: 0x000DF67C File Offset: 0x000DD87C
		private INewHandInItemsBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewHandInItemsBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewHandInItemsBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewHandInItemsBase_SetValue());
			}
			return result;
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x000DF6B4 File Offset: 0x000DD8B4
		public static INewHandInItemsBase Create([Nullable(2)] INewHandInItemsBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewHandInItemsBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x000DF6C7 File Offset: 0x000DD8C7
		public static INewHandInItemsBase CreateFromSetValue([Nullable(2)] INewHandInItemsBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewHandInItemsBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x000DF6DA File Offset: 0x000DD8DA
		public INewHandInItemsBase_SetValue ToSetValue()
		{
			return new INewHandInItemsBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06005C38 RID: 23608 RVA: 0x000DF6ED File Offset: 0x000DD8ED
		// (set) Token: 0x06005C39 RID: 23609 RVA: 0x000DF718 File Offset: 0x000DD918
		public virtual ENewHandInItemsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewHandInItemsType.ProjectionMachine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003779 RID: 14201
		[Nullable(2)]
		protected INewHandInItemsBase FbInstance;

		// Token: 0x0400377A RID: 14202
		[Nullable(2)]
		protected INewHandInItemsBase_SetValue PocoInterface;
	}
}
