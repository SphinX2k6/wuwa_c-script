using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231A RID: 8986
	public class IWuWaGoGame : IUiGame
	{
		// Token: 0x0600C3BE RID: 50110 RVA: 0x001C17C4 File Offset: 0x001BF9C4
		private IWuWaGoGame_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoGame 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoGame_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoGame_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3BF RID: 50111 RVA: 0x001C17FC File Offset: 0x001BF9FC
		public static IWuWaGoGame Create([Nullable(2)] IWuWaGoGame instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGame
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3C0 RID: 50112 RVA: 0x001C180F File Offset: 0x001BFA0F
		public static IWuWaGoGame CreateFromSetValue([Nullable(2)] IWuWaGoGame_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoGame
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3C1 RID: 50113 RVA: 0x001C1822 File Offset: 0x001BFA22
		public new IWuWaGoGame_SetValue ToSetValue()
		{
			return new IWuWaGoGame_SetValue
			{
				Type = this.Type,
				LevelCenterId = this.LevelCenterId
			};
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0600C3C2 RID: 50114 RVA: 0x001C1841 File Offset: 0x001BFA41
		// (set) Token: 0x0600C3C3 RID: 50115 RVA: 0x001C186C File Offset: 0x001BFA6C
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x0600C3C4 RID: 50116 RVA: 0x001C187A File Offset: 0x001BFA7A
		// (set) Token: 0x0600C3C5 RID: 50117 RVA: 0x001C18A5 File Offset: 0x001BFAA5
		public virtual int LevelCenterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelCenterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LevelCenterId;
			}
			set
			{
				this.GetOrCreatePoco().LevelCenterId = value;
			}
		}

		// Token: 0x040074A5 RID: 29861
		[Nullable(2)]
		protected new IWuWaGoGame FbInstance;

		// Token: 0x040074A6 RID: 29862
		[Nullable(2)]
		protected new IWuWaGoGame_SetValue PocoInterface;
	}
}
