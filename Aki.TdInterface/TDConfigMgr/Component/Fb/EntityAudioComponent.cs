using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA7 RID: 2983
	public class EntityAudioComponent : IComponentBase
	{
		// Token: 0x06004435 RID: 17461 RVA: 0x000AD02C File Offset: 0x000AB22C
		public static EntityAudioComponent Create(IEntityAudioComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityAudioComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x000AD04C File Offset: 0x000AB24C
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

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x000AD084 File Offset: 0x000AB284
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x000AD09A File Offset: 0x000AB29A
		public virtual IAkEventTypeConfig AkEventType
		{
			get
			{
				if (this._AkEventTypeInited)
				{
					return this._AkEventTypeCache;
				}
				this._AkEventTypeInited = true;
				this._AkEventTypeCache = ComponentReadHelper.ReadEntityAudioComponent_AkEventType(this.Instance);
				return this._AkEventTypeCache;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x000AD0C9 File Offset: 0x000AB2C9
		public virtual EAudioRangeType AudioRangeType
		{
			get
			{
				return (EAudioRangeType)this.Instance.AudioRangeType;
			}
		}

		// Token: 0x040025C0 RID: 9664
		private IEntityAudioComponent Instance;

		// Token: 0x040025C1 RID: 9665
		private IAkEventTypeConfig _AkEventTypeCache;

		// Token: 0x040025C2 RID: 9666
		private bool _AkEventTypeInited;
	}
}
