using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1A RID: 7450
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayPianoGameplay : IUiGame
	{
		// Token: 0x06009FD1 RID: 40913 RVA: 0x0016CDEC File Offset: 0x0016AFEC
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

		// Token: 0x06009FD2 RID: 40914 RVA: 0x0016CE24 File Offset: 0x0016B024
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

		// Token: 0x06009FD3 RID: 40915 RVA: 0x0016CE37 File Offset: 0x0016B037
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

		// Token: 0x06009FD4 RID: 40916 RVA: 0x0016CE4A File Offset: 0x0016B04A
		public new IPlayPianoGameplay_SetValue ToSetValue()
		{
			return new IPlayPianoGameplay_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId,
				RangeEntityId = this.RangeEntityId
			};
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x06009FD5 RID: 40917 RVA: 0x0016CE75 File Offset: 0x0016B075
		// (set) Token: 0x06009FD6 RID: 40918 RVA: 0x0016CEA0 File Offset: 0x0016B0A0
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

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x06009FD7 RID: 40919 RVA: 0x0016CEAE File Offset: 0x0016B0AE
		// (set) Token: 0x06009FD8 RID: 40920 RVA: 0x0016CED9 File Offset: 0x0016B0D9
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

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x06009FD9 RID: 40921 RVA: 0x0016CEE7 File Offset: 0x0016B0E7
		// (set) Token: 0x06009FDA RID: 40922 RVA: 0x0016CF12 File Offset: 0x0016B112
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

		// Token: 0x04006067 RID: 24679
		[Nullable(2)]
		protected new IPlayPianoGameplay FbInstance;

		// Token: 0x04006068 RID: 24680
		[Nullable(2)]
		protected new IPlayPianoGameplay_SetValue PocoInterface;
	}
}
