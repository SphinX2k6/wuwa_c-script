using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001134 RID: 4404
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowUi
	{
		// Token: 0x06006404 RID: 25604 RVA: 0x000F0BF0 File Offset: 0x000EEDF0
		private IShowUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUi_SetValue());
			}
			return result;
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x000F0C28 File Offset: 0x000EEE28
		public static IShowUi Create([Nullable(2)] IShowUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x000F0C3B File Offset: 0x000EEE3B
		public static IShowUi CreateFromSetValue([Nullable(2)] IShowUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x000F0C4E File Offset: 0x000EEE4E
		public IShowUi_SetValue ToSetValue()
		{
			return new IShowUi_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06006408 RID: 25608 RVA: 0x000F0C61 File Offset: 0x000EEE61
		// (set) Token: 0x06006409 RID: 25609 RVA: 0x000F0C8C File Offset: 0x000EEE8C
		public virtual EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003C28 RID: 15400
		[Nullable(2)]
		protected IShowUi FbInstance;

		// Token: 0x04003C29 RID: 15401
		[Nullable(2)]
		protected IShowUi_SetValue PocoInterface;
	}
}
