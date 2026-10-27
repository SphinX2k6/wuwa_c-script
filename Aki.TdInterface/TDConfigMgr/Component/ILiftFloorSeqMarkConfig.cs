using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004CA RID: 1226
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftFloorSeqMarkConfig
	{
		// Token: 0x060018E6 RID: 6374 RVA: 0x0004A248 File Offset: 0x00048448
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

		// Token: 0x060018E7 RID: 6375 RVA: 0x0004A280 File Offset: 0x00048480
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

		// Token: 0x060018E8 RID: 6376 RVA: 0x0004A293 File Offset: 0x00048493
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

		// Token: 0x060018E9 RID: 6377 RVA: 0x0004A2A6 File Offset: 0x000484A6
		public ILiftFloorSeqMarkConfig_SetValue ToSetValue()
		{
			return new ILiftFloorSeqMarkConfig_SetValue
			{
				SequencePath = this.SequencePath,
				FloorMarks = this.FloorMarks
			};
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x0004A2C5 File Offset: 0x000484C5
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x0004A2F0 File Offset: 0x000484F0
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

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x0004A300 File Offset: 0x00048500
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x0004A393 File Offset: 0x00048593
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

		// Token: 0x04001265 RID: 4709
		[Nullable(2)]
		protected ILiftFloorSeqMarkConfig FbInstance;

		// Token: 0x04001266 RID: 4710
		[Nullable(2)]
		protected ILiftFloorSeqMarkConfig_SetValue PocoInterface;

		// Token: 0x04001267 RID: 4711
		private List<ILiftFloorSeqMark> _FloorMarksCache;

		// Token: 0x04001268 RID: 4712
		private bool _FloorMarksInited;
	}
}
