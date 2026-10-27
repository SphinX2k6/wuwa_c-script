using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ADE RID: 2782
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityStateAudioComponent : EntityAudioComponent
	{
		// Token: 0x06004011 RID: 16401 RVA: 0x000A3AEA File Offset: 0x000A1CEA
		public static EntityStateAudioComponent Create(IEntityStateAudioComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityStateAudioComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06004012 RID: 16402 RVA: 0x000A3B0C File Offset: 0x000A1D0C
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

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06004013 RID: 16403 RVA: 0x000A3B42 File Offset: 0x000A1D42
		public override IAkEventTypeConfig AkEventType
		{
			get
			{
				if (this._AkEventTypeInited)
				{
					return this._AkEventTypeCache;
				}
				this._AkEventTypeInited = true;
				this._AkEventTypeCache = ComponentReadHelper.ReadEntityStateAudioComponent_AkEventType(this.Instance);
				return this._AkEventTypeCache;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06004014 RID: 16404 RVA: 0x000A3B71 File Offset: 0x000A1D71
		public override EAudioRangeType AudioRangeType
		{
			get
			{
				return (EAudioRangeType)this.Instance.AudioRangeType;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x000A3B80 File Offset: 0x000A1D80
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x000A3B98 File Offset: 0x000A1D98
		public virtual List<IEntityStateAudioConfig> Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				int configLength = this.Instance.ConfigLength;
				this._ConfigCache = new List<IEntityStateAudioConfig>(configLength);
				for (int i = 0; i < configLength; i++)
				{
					this._ConfigCache.Add(IEntityStateAudioConfig.Create(this.Instance.Config(i)));
				}
				return this._ConfigCache;
			}
		}

		// Token: 0x040023A7 RID: 9127
		private IEntityStateAudioComponent Instance;

		// Token: 0x040023A8 RID: 9128
		private IAkEventTypeConfig _AkEventTypeCache;

		// Token: 0x040023A9 RID: 9129
		private bool _AkEventTypeInited;

		// Token: 0x040023AA RID: 9130
		private List<IEntityStateAudioConfig> _ConfigCache;

		// Token: 0x040023AB RID: 9131
		private bool _ConfigInited;
	}
}
