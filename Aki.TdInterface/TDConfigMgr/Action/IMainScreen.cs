using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA1 RID: 7585
	public class IMainScreen : IScreenType
	{
		// Token: 0x0600A105 RID: 41221 RVA: 0x001712D4 File Offset: 0x0016F4D4
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

		// Token: 0x0600A106 RID: 41222 RVA: 0x0017130C File Offset: 0x0016F50C
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

		// Token: 0x0600A107 RID: 41223 RVA: 0x0017131F File Offset: 0x0016F51F
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

		// Token: 0x0600A108 RID: 41224 RVA: 0x00171332 File Offset: 0x0016F532
		public new IMainScreen_SetValue ToSetValue()
		{
			return new IMainScreen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600A109 RID: 41225 RVA: 0x00171345 File Offset: 0x0016F545
		// (set) Token: 0x0600A10A RID: 41226 RVA: 0x00171370 File Offset: 0x0016F570
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

		// Token: 0x040061D8 RID: 25048
		[Nullable(2)]
		protected new IMainScreen FbInstance;

		// Token: 0x040061D9 RID: 25049
		[Nullable(2)]
		protected new IMainScreen_SetValue PocoInterface;
	}
}
