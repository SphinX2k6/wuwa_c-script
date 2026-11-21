using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4A RID: 3402
	public class ILiftFloorSeqMarkConfig
	{
		// Token: 0x06004D7D RID: 19837 RVA: 0x000C16D2 File Offset: 0x000BF8D2
		public static ILiftFloorSeqMarkConfig Create(ILiftFloorSeqMarkConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftFloorSeqMarkConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x000C16F1 File Offset: 0x000BF8F1
		public virtual string SequencePath
		{
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x000C1700 File Offset: 0x000BF900
		public virtual List<ILiftFloorSeqMark> FloorMarks
		{
			get
			{
				if (this._FloorMarksInited)
				{
					return this._FloorMarksCache;
				}
				this._FloorMarksInited = true;
				int floorMarksLength = this.Instance.FloorMarksLength;
				this._FloorMarksCache = new List<ILiftFloorSeqMark>(floorMarksLength);
				for (int i = 0; i < floorMarksLength; i++)
				{
					this._FloorMarksCache.Add(ILiftFloorSeqMark.Create(this.Instance.FloorMarks(i)));
				}
				return this._FloorMarksCache;
			}
		}

		// Token: 0x04002BF7 RID: 11255
		private ILiftFloorSeqMarkConfig Instance;

		// Token: 0x04002BF8 RID: 11256
		private List<ILiftFloorSeqMark> _FloorMarksCache;

		// Token: 0x04002BF9 RID: 11257
		private bool _FloorMarksInited;
	}
}
