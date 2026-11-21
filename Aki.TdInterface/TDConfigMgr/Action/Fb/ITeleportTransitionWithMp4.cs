using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002952 RID: 10578
	public class ITeleportTransitionWithMp4 : ITeleportTransitionType
	{
		// Token: 0x0600EAD8 RID: 60120 RVA: 0x0022A186 File Offset: 0x00228386
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

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x0600EAD9 RID: 60121 RVA: 0x0022A1A5 File Offset: 0x002283A5
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x0600EADA RID: 60122 RVA: 0x0022A1B2 File Offset: 0x002283B2
		public virtual string Mp4Path
		{
			get
			{
				return this.Instance.Mp4Path;
			}
		}

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x0600EADB RID: 60123 RVA: 0x0022A1C0 File Offset: 0x002283C0
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

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x0600EADC RID: 60124 RVA: 0x0022A1F8 File Offset: 0x002283F8
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

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x0600EADD RID: 60125 RVA: 0x0022A22E File Offset: 0x0022842E
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

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x0600EADE RID: 60126 RVA: 0x0022A264 File Offset: 0x00228464
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

		// Token: 0x04008162 RID: 33122
		private ITeleportTransitionWithMp4 Instance;

		// Token: 0x04008163 RID: 33123
		[Nullable(2)]
		private IMp4BackgroundColor _BackgroundColorCache;

		// Token: 0x04008164 RID: 33124
		private bool _BackgroundColorInited;
	}
}
