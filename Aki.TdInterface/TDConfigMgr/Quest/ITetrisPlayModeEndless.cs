using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012CE RID: 4814
	public class ITetrisPlayModeEndless : ITetrisPlayModeBase
	{
		// Token: 0x06006C65 RID: 27749 RVA: 0x001027D4 File Offset: 0x001009D4
		private ITetrisPlayModeEndless_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisPlayModeEndless 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisPlayModeEndless_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisPlayModeEndless_SetValue());
			}
			return result;
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x0010280C File Offset: 0x00100A0C
		public static ITetrisPlayModeEndless Create([Nullable(2)] ITetrisPlayModeEndless instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeEndless
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x0010281F File Offset: 0x00100A1F
		public static ITetrisPlayModeEndless CreateFromSetValue([Nullable(2)] ITetrisPlayModeEndless_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisPlayModeEndless
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x00102832 File Offset: 0x00100A32
		public new ITetrisPlayModeEndless_SetValue ToSetValue()
		{
			return new ITetrisPlayModeEndless_SetValue
			{
				Type = this.Type,
				SpeedLevel = this.SpeedLevel
			};
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06006C69 RID: 27753 RVA: 0x00102851 File Offset: 0x00100A51
		// (set) Token: 0x06006C6A RID: 27754 RVA: 0x0010287C File Offset: 0x00100A7C
		public override ETetrisPlayMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETetrisPlayMode.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x0010288C File Offset: 0x00100A8C
		// (set) Token: 0x06006C6C RID: 27756 RVA: 0x001028C6 File Offset: 0x00100AC6
		public virtual int? SpeedLevel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedLevel;
				}
				ITetrisPlayModeEndless_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpeedLevel;
			}
			set
			{
				this.GetOrCreatePoco().SpeedLevel = value;
			}
		}

		// Token: 0x040040BD RID: 16573
		[Nullable(2)]
		protected new ITetrisPlayModeEndless FbInstance;

		// Token: 0x040040BE RID: 16574
		[Nullable(2)]
		protected new ITetrisPlayModeEndless_SetValue PocoInterface;
	}
}
