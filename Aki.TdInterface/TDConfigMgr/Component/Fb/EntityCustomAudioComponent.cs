using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BAC RID: 2988
	public class EntityCustomAudioComponent : EntityAudioComponent
	{
		// Token: 0x0600444F RID: 17487 RVA: 0x000AD2CD File Offset: 0x000AB4CD
		public static EntityCustomAudioComponent Create(IEntityCustomAudioComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityCustomAudioComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x000AD2EC File Offset: 0x000AB4EC
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x000AD322 File Offset: 0x000AB522
		public override IAkEventTypeConfig AkEventType
		{
			get
			{
				if (this._AkEventTypeInited)
				{
					return this._AkEventTypeCache;
				}
				this._AkEventTypeInited = true;
				this._AkEventTypeCache = ComponentReadHelper.ReadEntityCustomAudioComponent_AkEventType(this.Instance);
				return this._AkEventTypeCache;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x000AD351 File Offset: 0x000AB551
		public override EAudioRangeType AudioRangeType
		{
			get
			{
				return (EAudioRangeType)this.Instance.AudioRangeType;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x000AD360 File Offset: 0x000AB560
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x000AD376 File Offset: 0x000AB576
		public virtual IAudioControlType AudioControlType
		{
			get
			{
				if (this._AudioControlTypeInited)
				{
					return this._AudioControlTypeCache;
				}
				this._AudioControlTypeInited = true;
				this._AudioControlTypeCache = ComponentReadHelper.ReadEntityCustomAudioComponent_AudioControlType(this.Instance);
				return this._AudioControlTypeCache;
			}
		}

		// Token: 0x040025CB RID: 9675
		private IEntityCustomAudioComponent Instance;

		// Token: 0x040025CC RID: 9676
		private IAkEventTypeConfig _AkEventTypeCache;

		// Token: 0x040025CD RID: 9677
		private bool _AkEventTypeInited;

		// Token: 0x040025CE RID: 9678
		private IAudioControlType _AudioControlTypeCache;

		// Token: 0x040025CF RID: 9679
		private bool _AudioControlTypeInited;
	}
}
