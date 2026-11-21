using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2B RID: 7979
	public class IPlayPianoGameplay : IUiGame
	{
		// Token: 0x0600A9BD RID: 43453 RVA: 0x00181210 File Offset: 0x0017F410
		private IPlayPianoGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayPianoGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayPianoGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayPianoGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9BE RID: 43454 RVA: 0x00181248 File Offset: 0x0017F448
		public static IPlayPianoGameplay Create([Nullable(2)] IPlayPianoGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayPianoGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9BF RID: 43455 RVA: 0x0018125B File Offset: 0x0017F45B
		public static IPlayPianoGameplay CreateFromSetValue([Nullable(2)] IPlayPianoGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayPianoGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9C0 RID: 43456 RVA: 0x0018126E File Offset: 0x0017F46E
		public new IPlayPianoGameplay_SetValue ToSetValue()
		{
			return new IPlayPianoGameplay_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId,
				RangeEntityId = this.RangeEntityId
			};
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600A9C1 RID: 43457 RVA: 0x00181299 File Offset: 0x0017F499
		// (set) Token: 0x0600A9C2 RID: 43458 RVA: 0x001812C4 File Offset: 0x0017F4C4
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

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600A9C3 RID: 43459 RVA: 0x001812D2 File Offset: 0x0017F4D2
		// (set) Token: 0x0600A9C4 RID: 43460 RVA: 0x001812FD File Offset: 0x0017F4FD
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600A9C5 RID: 43461 RVA: 0x0018130B File Offset: 0x0017F50B
		// (set) Token: 0x0600A9C6 RID: 43462 RVA: 0x00181336 File Offset: 0x0017F536
		public virtual int RangeEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RangeEntityId;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntityId = value;
			}
		}

		// Token: 0x040065E3 RID: 26083
		[Nullable(2)]
		protected new IPlayPianoGameplay FbInstance;

		// Token: 0x040065E4 RID: 26084
		[Nullable(2)]
		protected new IPlayPianoGameplay_SetValue PocoInterface;
	}
}
