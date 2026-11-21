using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002454 RID: 9300
	public class SetupMoraleSystem : ActionParams
	{
		// Token: 0x0600CA6B RID: 51819 RVA: 0x001CE434 File Offset: 0x001CC634
		private SetupMoraleSystem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetupMoraleSystem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetupMoraleSystem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetupMoraleSystem_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x001CE46C File Offset: 0x001CC66C
		public static SetupMoraleSystem Create([Nullable(2)] SetupMoraleSystem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetupMoraleSystem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x001CE47F File Offset: 0x001CC67F
		public static SetupMoraleSystem CreateFromSetValue([Nullable(2)] SetupMoraleSystem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetupMoraleSystem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x001CE492 File Offset: 0x001CC692
		public SetupMoraleSystem_SetValue ToSetValue()
		{
			return new SetupMoraleSystem_SetValue
			{
				MoralePlayId = this.MoralePlayId,
				IsOn = this.IsOn
			};
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0600CA6F RID: 51823 RVA: 0x001CE4B1 File Offset: 0x001CC6B1
		// (set) Token: 0x0600CA70 RID: 51824 RVA: 0x001CE4DC File Offset: 0x001CC6DC
		public virtual int MoralePlayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoralePlayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MoralePlayId;
			}
			set
			{
				this.GetOrCreatePoco().MoralePlayId = value;
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0600CA71 RID: 51825 RVA: 0x001CE4EA File Offset: 0x001CC6EA
		// (set) Token: 0x0600CA72 RID: 51826 RVA: 0x001CE515 File Offset: 0x001CC715
		public virtual bool IsOn
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOn;
				}
				return this.PocoInterface != null && this.PocoInterface.IsOn;
			}
			set
			{
				this.GetOrCreatePoco().IsOn = value;
			}
		}

		// Token: 0x0400780C RID: 30732
		[Nullable(2)]
		protected new SetupMoraleSystem FbInstance;

		// Token: 0x0400780D RID: 30733
		[Nullable(2)]
		protected SetupMoraleSystem_SetValue PocoInterface;
	}
}
