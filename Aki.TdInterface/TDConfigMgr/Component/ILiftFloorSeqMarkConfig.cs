using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000523 RID: 1315
	public class ILiftFloorSeqMarkConfig
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x0004DF90 File Offset: 0x0004C190
		private ILiftFloorSeqMarkConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftFloorSeqMarkConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftFloorSeqMarkConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftFloorSeqMarkConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0004DFC8 File Offset: 0x0004C1C8
		public static ILiftFloorSeqMarkConfig Create([Nullable(2)] ILiftFloorSeqMarkConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftFloorSeqMarkConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0004DFDB File Offset: 0x0004C1DB
		public static ILiftFloorSeqMarkConfig CreateFromSetValue([Nullable(2)] ILiftFloorSeqMarkConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftFloorSeqMarkConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0004DFEE File Offset: 0x0004C1EE
		public ILiftFloorSeqMarkConfig_SetValue ToSetValue()
		{
			return new ILiftFloorSeqMarkConfig_SetValue
			{
				SequencePath = this.SequencePath,
				FloorMarks = this.FloorMarks
			};
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0004E00D File Offset: 0x0004C20D
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0004E038 File Offset: 0x0004C238
		public virtual string SequencePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SequencePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SequencePath;
			}
			set
			{
				this.GetOrCreatePoco().SequencePath = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0004E048 File Offset: 0x0004C248
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0004E0DB File Offset: 0x0004C2DB
		public virtual List<ILiftFloorSeqMark> FloorMarks
		{
			get
			{
				if (this._FloorMarksInited)
				{
					return this._FloorMarksCache;
				}
				this._FloorMarksInited = true;
				if (this.FbInstance != null)
				{
					List<ILiftFloorSeqMark> floorMarks = this.FbInstance.FloorMarks;
					if (floorMarks != null)
					{
						this._FloorMarksCache = new List<ILiftFloorSeqMark>(floorMarks.Count);
						for (int i = 0; i < floorMarks.Count; i++)
						{
							this._FloorMarksCache.Add(ILiftFloorSeqMark.Create(floorMarks[i]));
						}
					}
				}
				else
				{
					ILiftFloorSeqMarkConfig_SetValue pocoInterface = this.PocoInterface;
					this._FloorMarksCache = ((pocoInterface != null) ? pocoInterface.FloorMarks : null);
				}
				return this._FloorMarksCache;
			}
			set
			{
				this.GetOrCreatePoco().FloorMarks = value;
				this._FloorMarksInited = false;
			}
		}

		// Token: 0x04001387 RID: 4999
		[Nullable(2)]
		protected ILiftFloorSeqMarkConfig FbInstance;

		// Token: 0x04001388 RID: 5000
		[Nullable(2)]
		protected ILiftFloorSeqMarkConfig_SetValue PocoInterface;

		// Token: 0x04001389 RID: 5001
		private List<ILiftFloorSeqMark> _FloorMarksCache;

		// Token: 0x0400138A RID: 5002
		private bool _FloorMarksInited;
	}
}
