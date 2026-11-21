using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027DB RID: 10203
	public class IActorFxEmoteStop : IActorFxEmoteType
	{
		// Token: 0x0600E1A9 RID: 57769 RVA: 0x00212862 File Offset: 0x00210A62
		public static IActorFxEmoteStop Create(IActorFxEmoteStop? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStop
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x0600E1AA RID: 57770 RVA: 0x00212881 File Offset: 0x00210A81
		public override EActorFxEmoteType Type
		{
			get
			{
				return (EActorFxEmoteType)this.Instance.Type;
			}
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x0600E1AB RID: 57771 RVA: 0x0021288E File Offset: 0x00210A8E
		public virtual IActorFxEmoteStopSubType StopType
		{
			get
			{
				if (this._StopTypeInited)
				{
					return this._StopTypeCache;
				}
				this._StopTypeInited = true;
				this._StopTypeCache = ActionReadHelper.ReadIActorFxEmoteStop_StopType(this.Instance);
				return this._StopTypeCache;
			}
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x0600E1AC RID: 57772 RVA: 0x002128C0 File Offset: 0x00210AC0
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

		// Token: 0x04007A9F RID: 31391
		private IActorFxEmoteStop Instance;

		// Token: 0x04007AA0 RID: 31392
		private IActorFxEmoteStopSubType _StopTypeCache;

		// Token: 0x04007AA1 RID: 31393
		private bool _StopTypeInited;
	}
}
