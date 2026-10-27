using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C6B RID: 3179
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftFloorSeqMarkConfig
	{
		// Token: 0x060048DE RID: 18654 RVA: 0x000B6ECE File Offset: 0x000B50CE
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

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x000B6EED File Offset: 0x000B50ED
		public virtual string SequencePath
		{
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x000B6EFC File Offset: 0x000B50FC
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

		// Token: 0x0400298A RID: 10634
		private ILiftFloorSeqMarkConfig Instance;

		// Token: 0x0400298B RID: 10635
		private List<ILiftFloorSeqMark> _FloorMarksCache;

		// Token: 0x0400298C RID: 10636
		private bool _FloorMarksInited;
	}
}
