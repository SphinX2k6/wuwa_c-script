using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA8 RID: 2984
	public class EntityStateAudioComponent : EntityAudioComponent
	{
		// Token: 0x0600443B RID: 17467 RVA: 0x000AD0DE File Offset: 0x000AB2DE
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

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x000AD100 File Offset: 0x000AB300
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

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x000AD136 File Offset: 0x000AB336
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

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x000AD165 File Offset: 0x000AB365
		public override EAudioRangeType AudioRangeType
		{
			get
			{
				return (EAudioRangeType)this.Instance.AudioRangeType;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x000AD174 File Offset: 0x000AB374
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x000AD18C File Offset: 0x000AB38C
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

		// Token: 0x040025C3 RID: 9667
		private IEntityStateAudioComponent Instance;

		// Token: 0x040025C4 RID: 9668
		private IAkEventTypeConfig _AkEventTypeCache;

		// Token: 0x040025C5 RID: 9669
		private bool _AkEventTypeInited;

		// Token: 0x040025C6 RID: 9670
		private List<IEntityStateAudioConfig> _ConfigCache;

		// Token: 0x040025C7 RID: 9671
		private bool _ConfigInited;
	}
}
