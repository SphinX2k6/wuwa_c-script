using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DA RID: 10202
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorFxEmotePlay : IActorFxEmoteType
	{
		// Token: 0x0600E1A1 RID: 57761 RVA: 0x00212744 File Offset: 0x00210944
		[NullableContext(0)]
		public static IActorFxEmotePlay Create(IActorFxEmotePlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmotePlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x0600E1A2 RID: 57762 RVA: 0x00212763 File Offset: 0x00210963
		public override EActorFxEmoteType Type
		{
			get
			{
				return (EActorFxEmoteType)this.Instance.Type;
			}
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x0600E1A3 RID: 57763 RVA: 0x00212770 File Offset: 0x00210970
		public virtual long FxEmoteId
		{
			get
			{
				return this.Instance.FxEmoteId;
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x0600E1A4 RID: 57764 RVA: 0x0021277D File Offset: 0x0021097D
		public virtual IActorFxEmoteOverrideConfig OverrideConfig
		{
			get
			{
				if (this._OverrideConfigInited)
				{
					return this._OverrideConfigCache;
				}
				this._OverrideConfigInited = true;
				this._OverrideConfigCache = IActorFxEmoteOverrideConfig.Create(this.Instance.OverrideConfig);
				return this._OverrideConfigCache;
			}
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x002127B4 File Offset: 0x002109B4
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x0600E1A6 RID: 57766 RVA: 0x002127EC File Offset: 0x002109EC
		public virtual bool? LoopPlay
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.LoopPlay);
			}
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x0600E1A7 RID: 57767 RVA: 0x00212824 File Offset: 0x00210A24
		public virtual bool? KeepPlay
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPlay);
			}
		}

		// Token: 0x04007A9C RID: 31388
		private IActorFxEmotePlay Instance;

		// Token: 0x04007A9D RID: 31389
		private IActorFxEmoteOverrideConfig _OverrideConfigCache;

		// Token: 0x04007A9E RID: 31390
		private bool _OverrideConfigInited;
	}
}
