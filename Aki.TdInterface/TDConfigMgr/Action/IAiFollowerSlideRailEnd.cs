using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001951 RID: 6481
	public class IAiFollowerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x060089D1 RID: 35281 RVA: 0x00147FD4 File Offset: 0x001461D4
		private IAiFollowerSlideRailEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAiFollowerSlideRailEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAiFollowerSlideRailEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAiFollowerSlideRailEnd_SetValue());
			}
			return result;
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x0014800C File Offset: 0x0014620C
		public static IAiFollowerSlideRailEnd Create([Nullable(2)] IAiFollowerSlideRailEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAiFollowerSlideRailEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089D3 RID: 35283 RVA: 0x0014801F File Offset: 0x0014621F
		public static IAiFollowerSlideRailEnd CreateFromSetValue([Nullable(2)] IAiFollowerSlideRailEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAiFollowerSlideRailEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089D4 RID: 35284 RVA: 0x00148032 File Offset: 0x00146232
		public new IAiFollowerSlideRailEnd_SetValue ToSetValue()
		{
			return new IAiFollowerSlideRailEnd_SetValue
			{
				Type = this.Type,
				AiEntityId = this.AiEntityId
			};
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x060089D5 RID: 35285 RVA: 0x00148051 File Offset: 0x00146251
		// (set) Token: 0x060089D6 RID: 35286 RVA: 0x0014807C File Offset: 0x0014627C
		public override ESlideRailEndType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlideRailEndType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x060089D7 RID: 35287 RVA: 0x0014808A File Offset: 0x0014628A
		// (set) Token: 0x060089D8 RID: 35288 RVA: 0x001480B5 File Offset: 0x001462B5
		public virtual int AiEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AiEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AiEntityId;
			}
			set
			{
				this.GetOrCreatePoco().AiEntityId = value;
			}
		}

		// Token: 0x0400575E RID: 22366
		[Nullable(2)]
		protected new IAiFollowerSlideRailEnd FbInstance;

		// Token: 0x0400575F RID: 22367
		[Nullable(2)]
		protected new IAiFollowerSlideRailEnd_SetValue PocoInterface;
	}
}
