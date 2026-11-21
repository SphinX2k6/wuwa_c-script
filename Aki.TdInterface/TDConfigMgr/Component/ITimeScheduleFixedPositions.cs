using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000828 RID: 2088
	public class ITimeScheduleFixedPositions : ITimeScheduleRefreshPosition
	{
		// Token: 0x06002CF4 RID: 11508 RVA: 0x00075434 File Offset: 0x00073634
		private ITimeScheduleFixedPositions_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleFixedPositions 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleFixedPositions_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleFixedPositions_SetValue());
			}
			return result;
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0007546C File Offset: 0x0007366C
		public static ITimeScheduleFixedPositions Create([Nullable(2)] ITimeScheduleFixedPositions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleFixedPositions
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0007547F File Offset: 0x0007367F
		public static ITimeScheduleFixedPositions CreateFromSetValue([Nullable(2)] ITimeScheduleFixedPositions_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleFixedPositions
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00075492 File Offset: 0x00073692
		public new ITimeScheduleFixedPositions_SetValue ToSetValue()
		{
			return new ITimeScheduleFixedPositions_SetValue
			{
				Type = this.Type,
				Positions = this.Positions
			};
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000754B1 File Offset: 0x000736B1
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x000754DC File Offset: 0x000736DC
		public override ETimeScheduleRefreshPositionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleRefreshPositionType.FixedPositions;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x000754EC File Offset: 0x000736EC
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x0007557F File Offset: 0x0007377F
		public virtual List<Aki.TDConfigMgr.Action.PosA> Positions
		{
			get
			{
				if (this._PositionsInited)
				{
					return this._PositionsCache;
				}
				this._PositionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.PosA> positions = this.FbInstance.Positions;
					if (positions != null)
					{
						this._PositionsCache = new List<Aki.TDConfigMgr.Action.PosA>(positions.Count);
						for (int i = 0; i < positions.Count; i++)
						{
							this._PositionsCache.Add(Aki.TDConfigMgr.Action.PosA.Create(positions[i]));
						}
					}
				}
				else
				{
					ITimeScheduleFixedPositions_SetValue pocoInterface = this.PocoInterface;
					this._PositionsCache = ((pocoInterface != null) ? pocoInterface.Positions : null);
				}
				return this._PositionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Positions = value;
				this._PositionsInited = false;
			}
		}

		// Token: 0x04001E0B RID: 7691
		[Nullable(2)]
		protected new ITimeScheduleFixedPositions FbInstance;

		// Token: 0x04001E0C RID: 7692
		[Nullable(2)]
		protected new ITimeScheduleFixedPositions_SetValue PocoInterface;

		// Token: 0x04001E0D RID: 7693
		private List<Aki.TDConfigMgr.Action.PosA> _PositionsCache;

		// Token: 0x04001E0E RID: 7694
		private bool _PositionsInited;
	}
}
