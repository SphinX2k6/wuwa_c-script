using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED1 RID: 7889
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreen : IScreenType
	{
		// Token: 0x0600A8CE RID: 43214 RVA: 0x0017CED4 File Offset: 0x0017B0D4
		private ISubScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubScreen_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x0017CF0C File Offset: 0x0017B10C
		public static ISubScreen Create([Nullable(2)] ISubScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x0017CF1F File Offset: 0x0017B11F
		public static ISubScreen CreateFromSetValue([Nullable(2)] ISubScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x0017CF32 File Offset: 0x0017B132
		public new ISubScreen_SetValue ToSetValue()
		{
			return new ISubScreen_SetValue
			{
				Type = this.Type,
				SubScreenKey = this.SubScreenKey
			};
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x0017CF51 File Offset: 0x0017B151
		// (set) Token: 0x0600A8D3 RID: 43219 RVA: 0x0017CF7C File Offset: 0x0017B17C
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

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x0017CF8A File Offset: 0x0017B18A
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x0017CFB5 File Offset: 0x0017B1B5
		public virtual string SubScreenKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubScreenKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubScreenKey;
			}
			set
			{
				this.GetOrCreatePoco().SubScreenKey = value;
			}
		}

		// Token: 0x04006482 RID: 25730
		[Nullable(2)]
		protected new ISubScreen FbInstance;

		// Token: 0x04006483 RID: 25731
		[Nullable(2)]
		protected new ISubScreen_SetValue PocoInterface;
	}
}
