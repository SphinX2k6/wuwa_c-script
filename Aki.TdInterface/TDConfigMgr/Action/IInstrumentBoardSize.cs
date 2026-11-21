using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE6 RID: 7398
	public class IInstrumentBoardSize
	{
		// Token: 0x06009D00 RID: 40192 RVA: 0x0016993C File Offset: 0x00167B3C
		private IInstrumentBoardSize_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInstrumentBoardSize 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInstrumentBoardSize_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInstrumentBoardSize_SetValue());
			}
			return result;
		}

		// Token: 0x06009D01 RID: 40193 RVA: 0x00169974 File Offset: 0x00167B74
		public static IInstrumentBoardSize Create([Nullable(2)] IInstrumentBoardSize instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentBoardSize
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D02 RID: 40194 RVA: 0x00169987 File Offset: 0x00167B87
		public static IInstrumentBoardSize CreateFromSetValue([Nullable(2)] IInstrumentBoardSize_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInstrumentBoardSize
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D03 RID: 40195 RVA: 0x0016999A File Offset: 0x00167B9A
		public IInstrumentBoardSize_SetValue ToSetValue()
		{
			return new IInstrumentBoardSize_SetValue
			{
				X = this.X,
				Y = this.Y
			};
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x06009D04 RID: 40196 RVA: 0x001699B9 File Offset: 0x00167BB9
		// (set) Token: 0x06009D05 RID: 40197 RVA: 0x001699E4 File Offset: 0x00167BE4
		public virtual int X
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.X;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.X;
			}
			set
			{
				this.GetOrCreatePoco().X = value;
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06009D06 RID: 40198 RVA: 0x001699F2 File Offset: 0x00167BF2
		// (set) Token: 0x06009D07 RID: 40199 RVA: 0x00169A1D File Offset: 0x00167C1D
		public virtual int Y
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Y;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Y;
			}
			set
			{
				this.GetOrCreatePoco().Y = value;
			}
		}

		// Token: 0x04005FE1 RID: 24545
		[Nullable(2)]
		protected IInstrumentBoardSize FbInstance;

		// Token: 0x04005FE2 RID: 24546
		[Nullable(2)]
		protected IInstrumentBoardSize_SetValue PocoInterface;
	}
}
