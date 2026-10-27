using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000829 RID: 2089
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelSequenceFrameEventComponent : IComponentBase
	{
		// Token: 0x06002D79 RID: 11641 RVA: 0x00075CAC File Offset: 0x00073EAC
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

		// Token: 0x06002D7A RID: 11642 RVA: 0x00075CE4 File Offset: 0x00073EE4
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

		// Token: 0x06002D7B RID: 11643 RVA: 0x00075CF7 File Offset: 0x00073EF7
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

		// Token: 0x06002D7C RID: 11644 RVA: 0x00075D0A File Offset: 0x00073F0A
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x00075D44 File Offset: 0x00073F44
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x00075D7E File Offset: 0x00073F7E
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

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x00075D8C File Offset: 0x00073F8C
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x00075DB6 File Offset: 0x00073FB6
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

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x00075DC4 File Offset: 0x00073FC4
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x00075E57 File Offset: 0x00074057
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00075E6C File Offset: 0x0007406C
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x00075EFF File Offset: 0x000740FF
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

		// Token: 0x04001E18 RID: 7704
		[Nullable(2)]
		protected new LevelSequenceFrameEventComponent FbInstance;

		// Token: 0x04001E19 RID: 7705
		[Nullable(2)]
		protected new LevelSequenceFrameEventComponent_SetValue PocoInterface;

		// Token: 0x04001E1A RID: 7706
		private List<ILevelSequenceSectionInfo> _ForwardSectionsCache;

		// Token: 0x04001E1B RID: 7707
		private bool _ForwardSectionsInited;

		// Token: 0x04001E1C RID: 7708
		private List<ILevelSequenceSectionInfo> _BackWardSectionsCache;

		// Token: 0x04001E1D RID: 7709
		private bool _BackWardSectionsInited;
	}
}
