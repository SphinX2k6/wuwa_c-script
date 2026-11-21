using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012EC RID: 4844
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoardOnBtLogicNode
	{
		// Token: 0x06006D21 RID: 27937 RVA: 0x001040BC File Offset: 0x001022BC
		[NullableContext(0)]
		private ITrackCustomBoardOnBtLogicNode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackCustomBoardOnBtLogicNode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackCustomBoardOnBtLogicNode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackCustomBoardOnBtLogicNode_SetValue());
			}
			return result;
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x001040F4 File Offset: 0x001022F4
		[NullableContext(0)]
		public static ITrackCustomBoardOnBtLogicNode Create([Nullable(2)] ITrackCustomBoardOnBtLogicNode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackCustomBoardOnBtLogicNode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00104107 File Offset: 0x00102307
		[NullableContext(0)]
		public static ITrackCustomBoardOnBtLogicNode CreateFromSetValue([Nullable(2)] ITrackCustomBoardOnBtLogicNode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackCustomBoardOnBtLogicNode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x0010411A File Offset: 0x0010231A
		[NullableContext(0)]
		public ITrackCustomBoardOnBtLogicNode_SetValue ToSetValue()
		{
			return new ITrackCustomBoardOnBtLogicNode_SetValue
			{
				FastReturnMapPos = this.FastReturnMapPos,
				SheriffAnomalyProgressBoard = this.SheriffAnomalyProgressBoard,
				SheriffMainBoard = this.SheriffMainBoard,
				SheriffClueDetailBoard = this.SheriffClueDetailBoard
			};
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x06006D25 RID: 27941 RVA: 0x00104154 File Offset: 0x00102354
		// (set) Token: 0x06006D26 RID: 27942 RVA: 0x001041B5 File Offset: 0x001023B5
		public virtual IFastReturnMapPos FastReturnMapPos
		{
			get
			{
				if (this._FastReturnMapPosInited)
				{
					return this._FastReturnMapPosCache;
				}
				this._FastReturnMapPosInited = true;
				if (this.FbInstance != null)
				{
					this._FastReturnMapPosCache = IFastReturnMapPos.Create(this.FbInstance.FastReturnMapPos);
				}
				else
				{
					ITrackCustomBoardOnBtLogicNode_SetValue pocoInterface = this.PocoInterface;
					this._FastReturnMapPosCache = ((pocoInterface != null) ? pocoInterface.FastReturnMapPos : null);
				}
				return this._FastReturnMapPosCache;
			}
			set
			{
				this.GetOrCreatePoco().FastReturnMapPos = value;
				this._FastReturnMapPosInited = false;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06006D27 RID: 27943 RVA: 0x001041CC File Offset: 0x001023CC
		// (set) Token: 0x06006D28 RID: 27944 RVA: 0x0010422D File Offset: 0x0010242D
		public virtual ISheriffAnomalyProgressBoardConfig SheriffAnomalyProgressBoard
		{
			get
			{
				if (this._SheriffAnomalyProgressBoardInited)
				{
					return this._SheriffAnomalyProgressBoardCache;
				}
				this._SheriffAnomalyProgressBoardInited = true;
				if (this.FbInstance != null)
				{
					this._SheriffAnomalyProgressBoardCache = ISheriffAnomalyProgressBoardConfig.Create(this.FbInstance.SheriffAnomalyProgressBoard);
				}
				else
				{
					ITrackCustomBoardOnBtLogicNode_SetValue pocoInterface = this.PocoInterface;
					this._SheriffAnomalyProgressBoardCache = ((pocoInterface != null) ? pocoInterface.SheriffAnomalyProgressBoard : null);
				}
				return this._SheriffAnomalyProgressBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().SheriffAnomalyProgressBoard = value;
				this._SheriffAnomalyProgressBoardInited = false;
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06006D29 RID: 27945 RVA: 0x00104244 File Offset: 0x00102444
		// (set) Token: 0x06006D2A RID: 27946 RVA: 0x001042A5 File Offset: 0x001024A5
		public virtual ISheriffMainBoardConfig SheriffMainBoard
		{
			get
			{
				if (this._SheriffMainBoardInited)
				{
					return this._SheriffMainBoardCache;
				}
				this._SheriffMainBoardInited = true;
				if (this.FbInstance != null)
				{
					this._SheriffMainBoardCache = ISheriffMainBoardConfig.Create(this.FbInstance.SheriffMainBoard);
				}
				else
				{
					ITrackCustomBoardOnBtLogicNode_SetValue pocoInterface = this.PocoInterface;
					this._SheriffMainBoardCache = ((pocoInterface != null) ? pocoInterface.SheriffMainBoard : null);
				}
				return this._SheriffMainBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().SheriffMainBoard = value;
				this._SheriffMainBoardInited = false;
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x06006D2B RID: 27947 RVA: 0x001042BC File Offset: 0x001024BC
		// (set) Token: 0x06006D2C RID: 27948 RVA: 0x0010431D File Offset: 0x0010251D
		public virtual ISheriffClueDetailBoardConfig SheriffClueDetailBoard
		{
			get
			{
				if (this._SheriffClueDetailBoardInited)
				{
					return this._SheriffClueDetailBoardCache;
				}
				this._SheriffClueDetailBoardInited = true;
				if (this.FbInstance != null)
				{
					this._SheriffClueDetailBoardCache = ISheriffClueDetailBoardConfig.Create(this.FbInstance.SheriffClueDetailBoard);
				}
				else
				{
					ITrackCustomBoardOnBtLogicNode_SetValue pocoInterface = this.PocoInterface;
					this._SheriffClueDetailBoardCache = ((pocoInterface != null) ? pocoInterface.SheriffClueDetailBoard : null);
				}
				return this._SheriffClueDetailBoardCache;
			}
			set
			{
				this.GetOrCreatePoco().SheriffClueDetailBoard = value;
				this._SheriffClueDetailBoardInited = false;
			}
		}

		// Token: 0x04004132 RID: 16690
		protected ITrackCustomBoardOnBtLogicNode FbInstance;

		// Token: 0x04004133 RID: 16691
		protected ITrackCustomBoardOnBtLogicNode_SetValue PocoInterface;

		// Token: 0x04004134 RID: 16692
		[Nullable(0)]
		private IFastReturnMapPos _FastReturnMapPosCache;

		// Token: 0x04004135 RID: 16693
		private bool _FastReturnMapPosInited;

		// Token: 0x04004136 RID: 16694
		[Nullable(0)]
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x04004137 RID: 16695
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x04004138 RID: 16696
		[Nullable(0)]
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x04004139 RID: 16697
		private bool _SheriffMainBoardInited;

		// Token: 0x0400413A RID: 16698
		[Nullable(0)]
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x0400413B RID: 16699
		private bool _SheriffClueDetailBoardInited;
	}
}
