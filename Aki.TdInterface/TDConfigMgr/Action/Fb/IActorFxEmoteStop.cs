using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002534 RID: 9524
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmoteStop : IActorFxEmoteType
	{
		// Token: 0x0600D449 RID: 54345 RVA: 0x001F6E02 File Offset: 0x001F5002
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

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x0600D44A RID: 54346 RVA: 0x001F6E21 File Offset: 0x001F5021
		public override EActorFxEmoteType Type
		{
			get
			{
				return (EActorFxEmoteType)this.Instance.Type;
			}
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x0600D44B RID: 54347 RVA: 0x001F6E2E File Offset: 0x001F502E
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

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x0600D44C RID: 54348 RVA: 0x001F6E60 File Offset: 0x001F5060
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

		// Token: 0x0400744A RID: 29770
		private IActorFxEmoteStop Instance;

		// Token: 0x0400744B RID: 29771
		private IActorFxEmoteStopSubType _StopTypeCache;

		// Token: 0x0400744C RID: 29772
		private bool _StopTypeInited;
	}
}
