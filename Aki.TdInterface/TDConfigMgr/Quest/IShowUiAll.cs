using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001136 RID: 4406
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowUiAll : IShowUi
	{
		// Token: 0x0600640C RID: 25612 RVA: 0x000F0CAC File Offset: 0x000EEEAC
		private IShowUiAll_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowUiAll 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowUiAll_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowUiAll_SetValue());
			}
			return result;
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x000F0CE4 File Offset: 0x000EEEE4
		public static IShowUiAll Create([Nullable(2)] IShowUiAll instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowUiAll
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x000F0CF7 File Offset: 0x000EEEF7
		public static IShowUiAll CreateFromSetValue([Nullable(2)] IShowUiAll_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowUiAll
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x000F0D0A File Offset: 0x000EEF0A
		public new IShowUiAll_SetValue ToSetValue()
		{
			return new IShowUiAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06006410 RID: 25616 RVA: 0x000F0D1D File Offset: 0x000EEF1D
		// (set) Token: 0x06006411 RID: 25617 RVA: 0x000F0D48 File Offset: 0x000EEF48
		public override EShowUiType Type
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

		// Token: 0x04003C2B RID: 15403
		[Nullable(2)]
		protected new IShowUiAll FbInstance;

		// Token: 0x04003C2C RID: 15404
		[Nullable(2)]
		protected new IShowUiAll_SetValue PocoInterface;
	}
}
