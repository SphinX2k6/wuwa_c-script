using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ADD RID: 2781
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityAudioComponent : IComponentBase
	{
		// Token: 0x0600400B RID: 16395 RVA: 0x000A3A38 File Offset: 0x000A1C38
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

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600400C RID: 16396 RVA: 0x000A3A58 File Offset: 0x000A1C58
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

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600400D RID: 16397 RVA: 0x000A3A90 File Offset: 0x000A1C90
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600400E RID: 16398 RVA: 0x000A3AA6 File Offset: 0x000A1CA6
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

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x000A3AD5 File Offset: 0x000A1CD5
		public virtual EAudioRangeType AudioRangeType
		{
			get
			{
				return (EAudioRangeType)this.Instance.AudioRangeType;
			}
		}

		// Token: 0x040023A4 RID: 9124
		private IEntityAudioComponent Instance;

		// Token: 0x040023A5 RID: 9125
		private IAkEventTypeConfig _AkEventTypeCache;

		// Token: 0x040023A6 RID: 9126
		private bool _AkEventTypeInited;
	}
}
