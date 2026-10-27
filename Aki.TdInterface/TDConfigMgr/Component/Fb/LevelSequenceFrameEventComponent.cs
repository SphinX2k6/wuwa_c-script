using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7B RID: 3451
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelSequenceFrameEventComponent : IComponentBase
	{
		// Token: 0x06004E86 RID: 20102 RVA: 0x000C2CA6 File Offset: 0x000C0EA6
		public static LevelSequenceFrameEventComponent Create(ILevelSequenceFrameEventComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevelSequenceFrameEventComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06004E87 RID: 20103 RVA: 0x000C2CC8 File Offset: 0x000C0EC8
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

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06004E88 RID: 20104 RVA: 0x000C2D00 File Offset: 0x000C0F00
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06004E89 RID: 20105 RVA: 0x000C2D18 File Offset: 0x000C0F18
		public virtual List<ILevelSequenceSectionInfo> ForwardSections
		{
			get
			{
				if (this._ForwardSectionsInited)
				{
					return this._ForwardSectionsCache;
				}
				this._ForwardSectionsInited = true;
				int forwardSectionsLength = this.Instance.ForwardSectionsLength;
				this._ForwardSectionsCache = new List<ILevelSequenceSectionInfo>(forwardSectionsLength);
				for (int i = 0; i < forwardSectionsLength; i++)
				{
					this._ForwardSectionsCache.Add(ILevelSequenceSectionInfo.Create(this.Instance.ForwardSections(i)));
				}
				return this._ForwardSectionsCache;
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x000C2D84 File Offset: 0x000C0F84
		public virtual List<ILevelSequenceSectionInfo> BackWardSections
		{
			get
			{
				if (this._BackWardSectionsInited)
				{
					return this._BackWardSectionsCache;
				}
				this._BackWardSectionsInited = true;
				int backWardSectionsLength = this.Instance.BackWardSectionsLength;
				this._BackWardSectionsCache = new List<ILevelSequenceSectionInfo>(backWardSectionsLength);
				for (int i = 0; i < backWardSectionsLength; i++)
				{
					this._BackWardSectionsCache.Add(ILevelSequenceSectionInfo.Create(this.Instance.BackWardSections(i)));
				}
				return this._BackWardSectionsCache;
			}
		}

		// Token: 0x04002D12 RID: 11538
		private ILevelSequenceFrameEventComponent Instance;

		// Token: 0x04002D13 RID: 11539
		private List<ILevelSequenceSectionInfo> _ForwardSectionsCache;

		// Token: 0x04002D14 RID: 11540
		private bool _ForwardSectionsInited;

		// Token: 0x04002D15 RID: 11541
		private List<ILevelSequenceSectionInfo> _BackWardSectionsCache;

		// Token: 0x04002D16 RID: 11542
		private bool _BackWardSectionsInited;
	}
}
