using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002071 RID: 8305
	public class ISetPieceState : ISetJigsawFoundationType
	{
		// Token: 0x0600B055 RID: 45141 RVA: 0x0018CF04 File Offset: 0x0018B104
		private ISetPieceState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetPieceState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetPieceState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetPieceState_SetValue());
			}
			return result;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x0018CF3C File Offset: 0x0018B13C
		public static ISetPieceState Create([Nullable(2)] ISetPieceState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetPieceState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x0018CF4F File Offset: 0x0018B14F
		public static ISetPieceState CreateFromSetValue([Nullable(2)] ISetPieceState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetPieceState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x0018CF62 File Offset: 0x0018B162
		public new ISetPieceState_SetValue ToSetValue()
		{
			return new ISetPieceState_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PieceState = this.PieceState
			};
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600B059 RID: 45145 RVA: 0x0018CF8D File Offset: 0x0018B18D
		// (set) Token: 0x0600B05A RID: 45146 RVA: 0x0018CFB8 File Offset: 0x0018B1B8
		public override ESetJigsawFoundationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetJigsawFoundationType.SetPieceState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600B05B RID: 45147 RVA: 0x0018CFC6 File Offset: 0x0018B1C6
		// (set) Token: 0x0600B05C RID: 45148 RVA: 0x0018CFF1 File Offset: 0x0018B1F1
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600B05D RID: 45149 RVA: 0x0018D000 File Offset: 0x0018B200
		// (set) Token: 0x0600B05E RID: 45150 RVA: 0x0018D093 File Offset: 0x0018B293
		public virtual List<IJigsawPiece> PieceState
		{
			get
			{
				if (this._PieceStateInited)
				{
					return this._PieceStateCache;
				}
				this._PieceStateInited = true;
				if (this.FbInstance != null)
				{
					List<IJigsawPiece> pieceState = this.FbInstance.PieceState;
					if (pieceState != null)
					{
						this._PieceStateCache = new List<IJigsawPiece>(pieceState.Count);
						for (int i = 0; i < pieceState.Count; i++)
						{
							this._PieceStateCache.Add(IJigsawPiece.Create(pieceState[i]));
						}
					}
				}
				else
				{
					ISetPieceState_SetValue pocoInterface = this.PocoInterface;
					this._PieceStateCache = ((pocoInterface != null) ? pocoInterface.PieceState : null);
				}
				return this._PieceStateCache;
			}
			set
			{
				this.GetOrCreatePoco().PieceState = value;
				this._PieceStateInited = false;
			}
		}

		// Token: 0x040068EA RID: 26858
		[Nullable(2)]
		protected new ISetPieceState FbInstance;

		// Token: 0x040068EB RID: 26859
		[Nullable(2)]
		protected new ISetPieceState_SetValue PocoInterface;

		// Token: 0x040068EC RID: 26860
		private List<IJigsawPiece> _PieceStateCache;

		// Token: 0x040068ED RID: 26861
		private bool _PieceStateInited;
	}
}
