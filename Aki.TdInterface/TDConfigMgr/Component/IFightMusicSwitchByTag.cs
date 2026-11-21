using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C9 RID: 969
	public class IFightMusicSwitchByTag
	{
		// Token: 0x0600130B RID: 4875 RVA: 0x0003EB80 File Offset: 0x0003CD80
		private IFightMusicSwitchByTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFightMusicSwitchByTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFightMusicSwitchByTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFightMusicSwitchByTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0003EBB8 File Offset: 0x0003CDB8
		public static IFightMusicSwitchByTag Create([Nullable(2)] IFightMusicSwitchByTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFightMusicSwitchByTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0003EBCB File Offset: 0x0003CDCB
		public static IFightMusicSwitchByTag CreateFromSetValue([Nullable(2)] IFightMusicSwitchByTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFightMusicSwitchByTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0003EBDE File Offset: 0x0003CDDE
		public IFightMusicSwitchByTag_SetValue ToSetValue()
		{
			return new IFightMusicSwitchByTag_SetValue
			{
				FightMusic = this.FightMusic,
				ActivateTag = this.ActivateTag
			};
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x0003EBFD File Offset: 0x0003CDFD
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x0003EC28 File Offset: 0x0003CE28
		public virtual string FightMusic
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FightMusic;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FightMusic;
			}
			set
			{
				this.GetOrCreatePoco().FightMusic = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x0003EC36 File Offset: 0x0003CE36
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x0003EC5D File Offset: 0x0003CE5D
		[Nullable(2)]
		public virtual string ActivateTag
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActivateTag;
				}
				IFightMusicSwitchByTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ActivateTag;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ActivateTag = value;
			}
		}

		// Token: 0x04000F75 RID: 3957
		[Nullable(2)]
		protected IFightMusicSwitchByTag FbInstance;

		// Token: 0x04000F76 RID: 3958
		[Nullable(2)]
		protected IFightMusicSwitchByTag_SetValue PocoInterface;
	}
}
