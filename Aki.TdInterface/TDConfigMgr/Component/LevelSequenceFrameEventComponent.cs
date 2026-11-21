using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008CC RID: 2252
	public class LevelSequenceFrameEventComponent : IComponentBase
	{
		// Token: 0x060030A9 RID: 12457 RVA: 0x0007D010 File Offset: 0x0007B210
		private LevelSequenceFrameEventComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LevelSequenceFrameEventComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LevelSequenceFrameEventComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LevelSequenceFrameEventComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x0007D048 File Offset: 0x0007B248
		public static LevelSequenceFrameEventComponent Create([Nullable(2)] LevelSequenceFrameEventComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelSequenceFrameEventComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0007D05B File Offset: 0x0007B25B
		public static LevelSequenceFrameEventComponent CreateFromSetValue([Nullable(2)] LevelSequenceFrameEventComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LevelSequenceFrameEventComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0007D06E File Offset: 0x0007B26E
		public new LevelSequenceFrameEventComponent_SetValue ToSetValue()
		{
			return new LevelSequenceFrameEventComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ForwardSections = this.ForwardSections,
				BackWardSections = this.BackWardSections
			};
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x0007D0A8 File Offset: 0x0007B2A8
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x0007D0E2 File Offset: 0x0007B2E2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LevelSequenceFrameEventComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x0007D0F0 File Offset: 0x0007B2F0
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x0007D11A File Offset: 0x0007B31A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x0007D128 File Offset: 0x0007B328
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x0007D1BB File Offset: 0x0007B3BB
		public virtual List<ILevelSequenceSectionInfo> ForwardSections
		{
			get
			{
				if (this._ForwardSectionsInited)
				{
					return this._ForwardSectionsCache;
				}
				this._ForwardSectionsInited = true;
				if (this.FbInstance != null)
				{
					List<ILevelSequenceSectionInfo> forwardSections = this.FbInstance.ForwardSections;
					if (forwardSections != null)
					{
						this._ForwardSectionsCache = new List<ILevelSequenceSectionInfo>(forwardSections.Count);
						for (int i = 0; i < forwardSections.Count; i++)
						{
							this._ForwardSectionsCache.Add(ILevelSequenceSectionInfo.Create(forwardSections[i]));
						}
					}
				}
				else
				{
					LevelSequenceFrameEventComponent_SetValue pocoInterface = this.PocoInterface;
					this._ForwardSectionsCache = ((pocoInterface != null) ? pocoInterface.ForwardSections : null);
				}
				return this._ForwardSectionsCache;
			}
			set
			{
				this.GetOrCreatePoco().ForwardSections = value;
				this._ForwardSectionsInited = false;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x0007D1D0 File Offset: 0x0007B3D0
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x0007D263 File Offset: 0x0007B463
		public virtual List<ILevelSequenceSectionInfo> BackWardSections
		{
			get
			{
				if (this._BackWardSectionsInited)
				{
					return this._BackWardSectionsCache;
				}
				this._BackWardSectionsInited = true;
				if (this.FbInstance != null)
				{
					List<ILevelSequenceSectionInfo> backWardSections = this.FbInstance.BackWardSections;
					if (backWardSections != null)
					{
						this._BackWardSectionsCache = new List<ILevelSequenceSectionInfo>(backWardSections.Count);
						for (int i = 0; i < backWardSections.Count; i++)
						{
							this._BackWardSectionsCache.Add(ILevelSequenceSectionInfo.Create(backWardSections[i]));
						}
					}
				}
				else
				{
					LevelSequenceFrameEventComponent_SetValue pocoInterface = this.PocoInterface;
					this._BackWardSectionsCache = ((pocoInterface != null) ? pocoInterface.BackWardSections : null);
				}
				return this._BackWardSectionsCache;
			}
			set
			{
				this.GetOrCreatePoco().BackWardSections = value;
				this._BackWardSectionsInited = false;
			}
		}

		// Token: 0x04002024 RID: 8228
		[Nullable(2)]
		protected new LevelSequenceFrameEventComponent FbInstance;

		// Token: 0x04002025 RID: 8229
		[Nullable(2)]
		protected new LevelSequenceFrameEventComponent_SetValue PocoInterface;

		// Token: 0x04002026 RID: 8230
		private List<ILevelSequenceSectionInfo> _ForwardSectionsCache;

		// Token: 0x04002027 RID: 8231
		private bool _ForwardSectionsInited;

		// Token: 0x04002028 RID: 8232
		private List<ILevelSequenceSectionInfo> _BackWardSectionsCache;

		// Token: 0x04002029 RID: 8233
		private bool _BackWardSectionsInited;
	}
}
