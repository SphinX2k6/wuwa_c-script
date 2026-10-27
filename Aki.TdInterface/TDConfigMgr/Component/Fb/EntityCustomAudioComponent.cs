using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AE2 RID: 2786
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityCustomAudioComponent : EntityAudioComponent
	{
		// Token: 0x06004025 RID: 16421 RVA: 0x000A3CD9 File Offset: 0x000A1ED9
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

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x000A3CF8 File Offset: 0x000A1EF8
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

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x000A3D2E File Offset: 0x000A1F2E
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

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x000A3D5D File Offset: 0x000A1F5D
		public override EAudioRangeType AudioRangeType
		{
			get
			{
				return (EAudioRangeType)this.Instance.AudioRangeType;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x000A3D6C File Offset: 0x000A1F6C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x000A3D82 File Offset: 0x000A1F82
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

		// Token: 0x040023AF RID: 9135
		private IEntityCustomAudioComponent Instance;

		// Token: 0x040023B0 RID: 9136
		private IAkEventTypeConfig _AkEventTypeCache;

		// Token: 0x040023B1 RID: 9137
		private bool _AkEventTypeInited;

		// Token: 0x040023B2 RID: 9138
		private IAudioControlType _AudioControlTypeCache;

		// Token: 0x040023B3 RID: 9139
		private bool _AudioControlTypeInited;
	}
}
