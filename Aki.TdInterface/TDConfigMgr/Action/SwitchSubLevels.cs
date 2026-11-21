using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002495 RID: 9365
	public class SwitchSubLevels : ActionParams
	{
		// Token: 0x0600CBB8 RID: 52152 RVA: 0x001D09F0 File Offset: 0x001CEBF0
		private SwitchSubLevels_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SwitchSubLevels 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SwitchSubLevels_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SwitchSubLevels_SetValue());
			}
			return result;
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x001D0A28 File Offset: 0x001CEC28
		public static SwitchSubLevels Create([Nullable(2)] SwitchSubLevels instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitchSubLevels
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x001D0A3B File Offset: 0x001CEC3B
		public static SwitchSubLevels CreateFromSetValue([Nullable(2)] SwitchSubLevels_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SwitchSubLevels
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x001D0A4E File Offset: 0x001CEC4E
		public SwitchSubLevels_SetValue ToSetValue()
		{
			return new SwitchSubLevels_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x0600CBBC RID: 52156 RVA: 0x001D0A61 File Offset: 0x001CEC61
		// (set) Token: 0x0600CBBD RID: 52157 RVA: 0x001D0A8C File Offset: 0x001CEC8C
		public virtual ESwitchSubLevelsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040078C1 RID: 30913
		[Nullable(2)]
		protected new SwitchSubLevels FbInstance;

		// Token: 0x040078C2 RID: 30914
		[Nullable(2)]
		protected SwitchSubLevels_SetValue PocoInterface;
	}
}
