using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C5 RID: 8389
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoGame : IUiGame
	{
		// Token: 0x0600B866 RID: 47206 RVA: 0x001AAB7C File Offset: 0x001A8D7C
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

		// Token: 0x0600B867 RID: 47207 RVA: 0x001AABB4 File Offset: 0x001A8DB4
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

		// Token: 0x0600B868 RID: 47208 RVA: 0x001AABC7 File Offset: 0x001A8DC7
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

		// Token: 0x0600B869 RID: 47209 RVA: 0x001AABDA File Offset: 0x001A8DDA
		public new IWuWaGoGame_SetValue ToSetValue()
		{
			return new IWuWaGoGame_SetValue
			{
				Type = this.Type,
				LevelCenterId = this.LevelCenterId
			};
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600B86A RID: 47210 RVA: 0x001AABF9 File Offset: 0x001A8DF9
		// (set) Token: 0x0600B86B RID: 47211 RVA: 0x001AAC24 File Offset: 0x001A8E24
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

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600B86C RID: 47212 RVA: 0x001AAC32 File Offset: 0x001A8E32
		// (set) Token: 0x0600B86D RID: 47213 RVA: 0x001AAC5D File Offset: 0x001A8E5D
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

		// Token: 0x04006E87 RID: 28295
		[Nullable(2)]
		protected new IWuWaGoGame FbInstance;

		// Token: 0x04006E88 RID: 28296
		[Nullable(2)]
		protected new IWuWaGoGame_SetValue PocoInterface;
	}
}
