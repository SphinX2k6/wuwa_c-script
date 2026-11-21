using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007273 RID: 29299
	public struct IMotorRadioUiFunction : IFlatbufferObject
	{
		// Token: 0x1700D6C9 RID: 54985
		// (get) Token: 0x060330D2 RID: 209106 RVA: 0x006E3E70 File Offset: 0x006E2070
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060330D3 RID: 209107 RVA: 0x006E3E7D File Offset: 0x006E207D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060330D4 RID: 209108 RVA: 0x006E3E84 File Offset: 0x006E2084
		public static IMotorRadioUiFunction GetRootAsIMotorRadioUiFunction(ByteBuffer _bb)
		{
			return IMotorRadioUiFunction.GetRootAsIMotorRadioUiFunction(_bb, default(IMotorRadioUiFunction));
		}

		// Token: 0x060330D5 RID: 209109 RVA: 0x006E3EA0 File Offset: 0x006E20A0
		public static IMotorRadioUiFunction GetRootAsIMotorRadioUiFunction(ByteBuffer _bb, IMotorRadioUiFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330D6 RID: 209110 RVA: 0x006E3EBD File Offset: 0x006E20BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330D7 RID: 209111 RVA: 0x006E3ECC File Offset: 0x006E20CC
		public IMotorRadioUiFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6CA RID: 54986
		// (get) Token: 0x060330D8 RID: 209112 RVA: 0x006E3EDC File Offset: 0x006E20DC
		public EEnableFunctionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return (EEnableFunctionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D6CB RID: 54987
		// (get) Token: 0x060330D9 RID: 209113 RVA: 0x006E3F18 File Offset: 0x006E2118
		public TMotorRadioOperationRestriction DisplayModeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TMotorRadioOperationRestriction.NONE;
				}
				return (TMotorRadioOperationRestriction)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060330DA RID: 209114 RVA: 0x006E3F54 File Offset: 0x006E2154
		public TTable? DisplayMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060330DB RID: 209115 RVA: 0x006E3F98 File Offset: 0x006E2198
		public IDisableAllMotorRadioOperation DisplayModeAsIDisableAllMotorRadioOperation()
		{
			return this.DisplayMode<IDisableAllMotorRadioOperation>().Value;
		}

		// Token: 0x060330DC RID: 209116 RVA: 0x006E3FB4 File Offset: 0x006E21B4
		public IDisableInRangeMotorRadioOperation DisplayModeAsIDisableInRangeMotorRadioOperation()
		{
			return this.DisplayMode<IDisableInRangeMotorRadioOperation>().Value;
		}

		// Token: 0x060330DD RID: 209117 RVA: 0x006E3FD0 File Offset: 0x006E21D0
		public IEnableAllMotorRadioOperation DisplayModeAsIEnableAllMotorRadioOperation()
		{
			return this.DisplayMode<IEnableAllMotorRadioOperation>().Value;
		}

		// Token: 0x060330DE RID: 209118 RVA: 0x006E3FEC File Offset: 0x006E21EC
		public IEnableInRangeMotorRadioOperation DisplayModeAsIEnableInRangeMotorRadioOperation()
		{
			return this.DisplayMode<IEnableInRangeMotorRadioOperation>().Value;
		}

		// Token: 0x060330DF RID: 209119 RVA: 0x006E4007 File Offset: 0x006E2207
		public static Offset<IMotorRadioUiFunction> CreateIMotorRadioUiFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon, TMotorRadioOperationRestriction DisplayMode_type = TMotorRadioOperationRestriction.NONE, int DisplayModeOffset = 0)
		{
			builder.StartTable(3);
			IMotorRadioUiFunction.AddDisplayMode(builder, DisplayModeOffset);
			IMotorRadioUiFunction.AddDisplayModeType(builder, DisplayMode_type);
			IMotorRadioUiFunction.AddType(builder, Type);
			return IMotorRadioUiFunction.EndIMotorRadioUiFunction(builder);
		}

		// Token: 0x060330E0 RID: 209120 RVA: 0x006E402B File Offset: 0x006E222B
		public static void StartIMotorRadioUiFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060330E1 RID: 209121 RVA: 0x006E4034 File Offset: 0x006E2234
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060330E2 RID: 209122 RVA: 0x006E403F File Offset: 0x006E223F
		public static void AddDisplayModeType(FlatBufferBuilder builder, TMotorRadioOperationRestriction displayModeType)
		{
			builder.AddByte(1, (byte)displayModeType, 0);
		}

		// Token: 0x060330E3 RID: 209123 RVA: 0x006E404A File Offset: 0x006E224A
		public static void AddDisplayMode(FlatBufferBuilder builder, int displayModeOffset)
		{
			builder.AddOffset(2, displayModeOffset, 0);
		}

		// Token: 0x060330E4 RID: 209124 RVA: 0x006E4055 File Offset: 0x006E2255
		public static Offset<IMotorRadioUiFunction> EndIMotorRadioUiFunction(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioUiFunction>(builder.EndTable());
		}

		// Token: 0x060330E5 RID: 209125 RVA: 0x006E4064 File Offset: 0x006E2264
		public IMotorRadioUiFunctionT UnPack()
		{
			IMotorRadioUiFunctionT motorRadioUiFunctionT = new IMotorRadioUiFunctionT();
			this.UnPackTo(motorRadioUiFunctionT);
			return motorRadioUiFunctionT;
		}

		// Token: 0x060330E6 RID: 209126 RVA: 0x006E4080 File Offset: 0x006E2280
		public void UnPackTo(IMotorRadioUiFunctionT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = new TMotorRadioOperationRestrictionUnion();
			_o.DisplayMode.Type = this.DisplayModeType;
			switch (this.DisplayModeType)
			{
			case TMotorRadioOperationRestriction.IDisableAllMotorRadioOperation:
				_o.DisplayMode.Value = ((this.DisplayMode<IDisableAllMotorRadioOperation>() != null) ? this.DisplayMode<IDisableAllMotorRadioOperation>().Value.UnPack() : null);
				return;
			case TMotorRadioOperationRestriction.IDisableInRangeMotorRadioOperation:
				_o.DisplayMode.Value = ((this.DisplayMode<IDisableInRangeMotorRadioOperation>() != null) ? this.DisplayMode<IDisableInRangeMotorRadioOperation>().Value.UnPack() : null);
				return;
			case TMotorRadioOperationRestriction.IEnableAllMotorRadioOperation:
				_o.DisplayMode.Value = ((this.DisplayMode<IEnableAllMotorRadioOperation>() != null) ? this.DisplayMode<IEnableAllMotorRadioOperation>().Value.UnPack() : null);
				return;
			case TMotorRadioOperationRestriction.IEnableInRangeMotorRadioOperation:
				_o.DisplayMode.Value = ((this.DisplayMode<IEnableInRangeMotorRadioOperation>() != null) ? this.DisplayMode<IEnableInRangeMotorRadioOperation>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060330E7 RID: 209127 RVA: 0x006E41B0 File Offset: 0x006E23B0
		public static Offset<IMotorRadioUiFunction> Pack(FlatBufferBuilder builder, IMotorRadioUiFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRadioUiFunction>);
			}
			TMotorRadioOperationRestriction displayMode_type = (_o.DisplayMode == null) ? TMotorRadioOperationRestriction.NONE : _o.DisplayMode.Type;
			int displayModeOffset = (_o.DisplayMode == null) ? 0 : TMotorRadioOperationRestrictionUnion.Pack(builder, _o.DisplayMode);
			return IMotorRadioUiFunction.CreateIMotorRadioUiFunction(builder, _o.Type, displayMode_type, displayModeOffset);
		}

		// Token: 0x040122EF RID: 74479
		private Table __p;
	}
}
