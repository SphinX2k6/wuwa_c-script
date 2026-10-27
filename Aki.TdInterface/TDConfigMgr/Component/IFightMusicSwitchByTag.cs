using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000380 RID: 896
	[NullableContext(1)]
	[Nullable(0)]
	public class IFightMusicSwitchByTag
	{
		// Token: 0x060011C7 RID: 4551 RVA: 0x0003B89C File Offset: 0x00039A9C
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

		// Token: 0x060011C8 RID: 4552 RVA: 0x0003B8D4 File Offset: 0x00039AD4
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

		// Token: 0x060011C9 RID: 4553 RVA: 0x0003B8E7 File Offset: 0x00039AE7
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

		// Token: 0x060011CA RID: 4554 RVA: 0x0003B8FA File Offset: 0x00039AFA
		public IFightMusicSwitchByTag_SetValue ToSetValue()
		{
			return new IFightMusicSwitchByTag_SetValue
			{
				FightMusic = this.FightMusic,
				ActivateTag = this.ActivateTag
			};
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0003B919 File Offset: 0x00039B19
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0003B944 File Offset: 0x00039B44
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0003B952 File Offset: 0x00039B52
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x0003B979 File Offset: 0x00039B79
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

		// Token: 0x04000E7E RID: 3710
		[Nullable(2)]
		protected IFightMusicSwitchByTag FbInstance;

		// Token: 0x04000E7F RID: 3711
		[Nullable(2)]
		protected IFightMusicSwitchByTag_SetValue PocoInterface;
	}
}
