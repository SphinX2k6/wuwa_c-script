using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E77 RID: 3703
	public class LevelSequenceFrameEventComponent : IComponentBase
	{
		// Token: 0x060053AB RID: 21419 RVA: 0x000CE4F6 File Offset: 0x000CC6F6
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

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x000CE518 File Offset: 0x000CC718
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

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x060053AD RID: 21421 RVA: 0x000CE550 File Offset: 0x000CC750
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x000CE568 File Offset: 0x000CC768
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

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x060053AF RID: 21423 RVA: 0x000CE5D4 File Offset: 0x000CC7D4
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

		// Token: 0x04002FD8 RID: 12248
		private ILevelSequenceFrameEventComponent Instance;

		// Token: 0x04002FD9 RID: 12249
		private List<ILevelSequenceSectionInfo> _ForwardSectionsCache;

		// Token: 0x04002FDA RID: 12250
		private bool _ForwardSectionsInited;

		// Token: 0x04002FDB RID: 12251
		private List<ILevelSequenceSectionInfo> _BackWardSectionsCache;

		// Token: 0x04002FDC RID: 12252
		private bool _BackWardSectionsInited;
	}
}
