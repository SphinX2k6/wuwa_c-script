using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BBA RID: 7098
	[NullableContext(1)]
	[Nullable(0)]
	public class IMainScreen : IScreenType
	{
		// Token: 0x06009801 RID: 38913 RVA: 0x0015E814 File Offset: 0x0015CA14
		private IMainScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMainScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMainScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMainScreen_SetValue());
			}
			return result;
		}

		// Token: 0x06009802 RID: 38914 RVA: 0x0015E84C File Offset: 0x0015CA4C
		public static IMainScreen Create([Nullable(2)] IMainScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMainScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009803 RID: 38915 RVA: 0x0015E85F File Offset: 0x0015CA5F
		public static IMainScreen CreateFromSetValue([Nullable(2)] IMainScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMainScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009804 RID: 38916 RVA: 0x0015E872 File Offset: 0x0015CA72
		public new IMainScreen_SetValue ToSetValue()
		{
			return new IMainScreen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x06009805 RID: 38917 RVA: 0x0015E885 File Offset: 0x0015CA85
		// (set) Token: 0x06009806 RID: 38918 RVA: 0x0015E8B0 File Offset: 0x0015CAB0
		public override EScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EScreenType.Main;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005CC3 RID: 23747
		[Nullable(2)]
		protected new IMainScreen FbInstance;

		// Token: 0x04005CC4 RID: 23748
		[Nullable(2)]
		protected new IMainScreen_SetValue PocoInterface;
	}
}
