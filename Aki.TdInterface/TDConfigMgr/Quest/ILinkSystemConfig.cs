using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001125 RID: 4389
	public class ILinkSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060060D6 RID: 24790 RVA: 0x000E974C File Offset: 0x000E794C
		private ILinkSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILinkSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILinkSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILinkSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x000E9784 File Offset: 0x000E7984
		public static ILinkSystemConfig Create([Nullable(2)] ILinkSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILinkSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x000E9797 File Offset: 0x000E7997
		public static ILinkSystemConfig CreateFromSetValue([Nullable(2)] ILinkSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILinkSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x000E97AA File Offset: 0x000E79AA
		public new ILinkSystemConfig_SetValue ToSetValue()
		{
			return new ILinkSystemConfig_SetValue
			{
				Type = this.Type,
				LinkDataId = this.LinkDataId
			};
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x060060DA RID: 24794 RVA: 0x000E97C9 File Offset: 0x000E79C9
		// (set) Token: 0x060060DB RID: 24795 RVA: 0x000E97F4 File Offset: 0x000E79F4
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x060060DC RID: 24796 RVA: 0x000E9802 File Offset: 0x000E7A02
		// (set) Token: 0x060060DD RID: 24797 RVA: 0x000E982D File Offset: 0x000E7A2D
		public virtual int LinkDataId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LinkDataId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LinkDataId;
			}
			set
			{
				this.GetOrCreatePoco().LinkDataId = value;
			}
		}

		// Token: 0x040039F2 RID: 14834
		[Nullable(2)]
		protected new ILinkSystemConfig FbInstance;

		// Token: 0x040039F3 RID: 14835
		[Nullable(2)]
		protected new ILinkSystemConfig_SetValue PocoInterface;
	}
}
