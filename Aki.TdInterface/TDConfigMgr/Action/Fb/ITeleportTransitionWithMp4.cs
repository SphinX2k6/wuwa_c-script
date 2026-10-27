using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200268F RID: 9871
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithMp4 : ITeleportTransitionType
	{
		// Token: 0x0600DD01 RID: 56577 RVA: 0x0020D9E6 File Offset: 0x0020BBE6
		public static ITeleportTransitionWithMp4 Create(ITeleportTransitionWithMp4? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithMp4
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x0600DD02 RID: 56578 RVA: 0x0020DA05 File Offset: 0x0020BC05
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x0600DD03 RID: 56579 RVA: 0x0020DA12 File Offset: 0x0020BC12
		public virtual string Mp4Path
		{
			get
			{
				return this.Instance.Mp4Path;
			}
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x0020DA20 File Offset: 0x0020BC20
		public virtual bool? IsFadeInScreenAfterTeleport
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFadeInScreenAfterTeleport);
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x0600DD05 RID: 56581 RVA: 0x0020DA58 File Offset: 0x0020BC58
		public virtual bool? ReplayWhenReLogin
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ReplayWhenReLogin);
			}
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x0600DD06 RID: 56582 RVA: 0x0020DA8E File Offset: 0x0020BC8E
		[Nullable(2)]
		public virtual IMp4BackgroundColor BackgroundColor
		{
			[NullableContext(2)]
			get
			{
				if (this._BackgroundColorInited)
				{
					return this._BackgroundColorCache;
				}
				this._BackgroundColorInited = true;
				this._BackgroundColorCache = IMp4BackgroundColor.Create(this.Instance.BackgroundColor);
				return this._BackgroundColorCache;
			}
		}

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x0600DD07 RID: 56583 RVA: 0x0020DAC4 File Offset: 0x0020BCC4
		public virtual EAfterTeleportScreenColor? AfterTeleportScreenColor
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new EAfterTeleportScreenColor?((EAfterTeleportScreenColor)this.Instance.AfterTeleportScreenColor);
			}
		}

		// Token: 0x04007AC5 RID: 31429
		private ITeleportTransitionWithMp4 Instance;

		// Token: 0x04007AC6 RID: 31430
		[Nullable(2)]
		private IMp4BackgroundColor _BackgroundColorCache;

		// Token: 0x04007AC7 RID: 31431
		private bool _BackgroundColorInited;
	}
}
