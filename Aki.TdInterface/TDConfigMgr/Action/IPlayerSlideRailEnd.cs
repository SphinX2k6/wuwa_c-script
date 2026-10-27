using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D0C RID: 7436
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x06009F91 RID: 40849 RVA: 0x0016C70C File Offset: 0x0016A90C
		private IPlayerSlideRailEnd_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerSlideRailEnd 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerSlideRailEnd_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerSlideRailEnd_SetValue());
			}
			return result;
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x0016C744 File Offset: 0x0016A944
		public static IPlayerSlideRailEnd Create([Nullable(2)] IPlayerSlideRailEnd instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerSlideRailEnd
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x0016C757 File Offset: 0x0016A957
		public static IPlayerSlideRailEnd CreateFromSetValue([Nullable(2)] IPlayerSlideRailEnd_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerSlideRailEnd
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x0016C76A File Offset: 0x0016A96A
		public new IPlayerSlideRailEnd_SetValue ToSetValue()
		{
			return new IPlayerSlideRailEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x06009F95 RID: 40853 RVA: 0x0016C77D File Offset: 0x0016A97D
		// (set) Token: 0x06009F96 RID: 40854 RVA: 0x0016C7A8 File Offset: 0x0016A9A8
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

		// Token: 0x0400604A RID: 24650
		[Nullable(2)]
		protected new IPlayerSlideRailEnd FbInstance;

		// Token: 0x0400604B RID: 24651
		[Nullable(2)]
		protected new IPlayerSlideRailEnd_SetValue PocoInterface;
	}
}
