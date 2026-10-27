using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037E RID: 894
	[NullableContext(1)]
	[Nullable(0)]
	public class IFightMusicsSwitchType
	{
		// Token: 0x060011BF RID: 4543 RVA: 0x0003B7E0 File Offset: 0x000399E0
		private IFightMusicsSwitchType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFightMusicsSwitchType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFightMusicsSwitchType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFightMusicsSwitchType_SetValue());
			}
			return result;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0003B818 File Offset: 0x00039A18
		public static IFightMusicsSwitchType Create([Nullable(2)] IFightMusicsSwitchType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFightMusicsSwitchType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0003B82B File Offset: 0x00039A2B
		public static IFightMusicsSwitchType CreateFromSetValue([Nullable(2)] IFightMusicsSwitchType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFightMusicsSwitchType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0003B83E File Offset: 0x00039A3E
		public IFightMusicsSwitchType_SetValue ToSetValue()
		{
			return new IFightMusicsSwitchType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0003B851 File Offset: 0x00039A51
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0003B87C File Offset: 0x00039A7C
		public virtual EFightMusicsSwitchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFightMusicsSwitchType.SwitchByTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E7B RID: 3707
		[Nullable(2)]
		protected IFightMusicsSwitchType FbInstance;

		// Token: 0x04000E7C RID: 3708
		[Nullable(2)]
		protected IFightMusicsSwitchType_SetValue PocoInterface;
	}
}
