using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017CA RID: 6090
	[NullableContext(1)]
	[Nullable(0)]
	public class IAiFollowerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x060082BF RID: 33471 RVA: 0x001389EC File Offset: 0x00136BEC
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

		// Token: 0x060082C0 RID: 33472 RVA: 0x00138A24 File Offset: 0x00136C24
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

		// Token: 0x060082C1 RID: 33473 RVA: 0x00138A37 File Offset: 0x00136C37
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

		// Token: 0x060082C2 RID: 33474 RVA: 0x00138A4A File Offset: 0x00136C4A
		public new IAiFollowerSlideRailEnd_SetValue ToSetValue()
		{
			return new IAiFollowerSlideRailEnd_SetValue
			{
				Type = this.Type,
				AiEntityId = this.AiEntityId
			};
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x060082C3 RID: 33475 RVA: 0x00138A69 File Offset: 0x00136C69
		// (set) Token: 0x060082C4 RID: 33476 RVA: 0x00138A94 File Offset: 0x00136C94
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

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x060082C5 RID: 33477 RVA: 0x00138AA2 File Offset: 0x00136CA2
		// (set) Token: 0x060082C6 RID: 33478 RVA: 0x00138ACD File Offset: 0x00136CCD
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

		// Token: 0x0400531A RID: 21274
		[Nullable(2)]
		protected new IAiFollowerSlideRailEnd FbInstance;

		// Token: 0x0400531B RID: 21275
		[Nullable(2)]
		protected new IAiFollowerSlideRailEnd_SetValue PocoInterface;
	}
}
