using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F1D RID: 7965
	public class IPlayerSlideRailEnd : ISlideRailEndType
	{
		// Token: 0x0600A97B RID: 43387 RVA: 0x00180AAC File Offset: 0x0017ECAC
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

		// Token: 0x0600A97C RID: 43388 RVA: 0x00180AE4 File Offset: 0x0017ECE4
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

		// Token: 0x0600A97D RID: 43389 RVA: 0x00180AF7 File Offset: 0x0017ECF7
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

		// Token: 0x0600A97E RID: 43390 RVA: 0x00180B0A File Offset: 0x0017ED0A
		public new IPlayerSlideRailEnd_SetValue ToSetValue()
		{
			return new IPlayerSlideRailEnd_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600A97F RID: 43391 RVA: 0x00180B1D File Offset: 0x0017ED1D
		// (set) Token: 0x0600A980 RID: 43392 RVA: 0x00180B48 File Offset: 0x0017ED48
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

		// Token: 0x040065C3 RID: 26051
		[Nullable(2)]
		protected new IPlayerSlideRailEnd FbInstance;

		// Token: 0x040065C4 RID: 26052
		[Nullable(2)]
		protected new IPlayerSlideRailEnd_SetValue PocoInterface;
	}
}
