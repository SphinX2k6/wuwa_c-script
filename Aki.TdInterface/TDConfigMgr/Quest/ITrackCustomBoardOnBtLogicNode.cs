using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011B2 RID: 4530
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoardOnBtLogicNode
	{
		// Token: 0x060066E8 RID: 26344 RVA: 0x000F686C File Offset: 0x000F4A6C
		[NullableContext(1)]
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

		// Token: 0x060066E9 RID: 26345 RVA: 0x000F68A4 File Offset: 0x000F4AA4
		[NullableContext(1)]
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

		// Token: 0x060066EA RID: 26346 RVA: 0x000F68B7 File Offset: 0x000F4AB7
		[NullableContext(1)]
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

		// Token: 0x060066EB RID: 26347 RVA: 0x000F68CA File Offset: 0x000F4ACA
		[NullableContext(1)]
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

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x000F6904 File Offset: 0x000F4B04
		// (set) Token: 0x060066ED RID: 26349 RVA: 0x000F6965 File Offset: 0x000F4B65
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

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x000F697C File Offset: 0x000F4B7C
		// (set) Token: 0x060066EF RID: 26351 RVA: 0x000F69DD File Offset: 0x000F4BDD
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

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x000F69F4 File Offset: 0x000F4BF4
		// (set) Token: 0x060066F1 RID: 26353 RVA: 0x000F6A55 File Offset: 0x000F4C55
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

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x000F6A6C File Offset: 0x000F4C6C
		// (set) Token: 0x060066F3 RID: 26355 RVA: 0x000F6ACD File Offset: 0x000F4CCD
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

		// Token: 0x04003DC7 RID: 15815
		protected ITrackCustomBoardOnBtLogicNode FbInstance;

		// Token: 0x04003DC8 RID: 15816
		protected ITrackCustomBoardOnBtLogicNode_SetValue PocoInterface;

		// Token: 0x04003DC9 RID: 15817
		[Nullable(1)]
		private IFastReturnMapPos _FastReturnMapPosCache;

		// Token: 0x04003DCA RID: 15818
		private bool _FastReturnMapPosInited;

		// Token: 0x04003DCB RID: 15819
		[Nullable(1)]
		private ISheriffAnomalyProgressBoardConfig _SheriffAnomalyProgressBoardCache;

		// Token: 0x04003DCC RID: 15820
		private bool _SheriffAnomalyProgressBoardInited;

		// Token: 0x04003DCD RID: 15821
		[Nullable(1)]
		private ISheriffMainBoardConfig _SheriffMainBoardCache;

		// Token: 0x04003DCE RID: 15822
		private bool _SheriffMainBoardInited;

		// Token: 0x04003DCF RID: 15823
		[Nullable(1)]
		private ISheriffClueDetailBoardConfig _SheriffClueDetailBoardCache;

		// Token: 0x04003DD0 RID: 15824
		private bool _SheriffClueDetailBoardInited;
	}
}
