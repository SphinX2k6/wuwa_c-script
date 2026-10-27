using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2D RID: 27437
	public struct IMotorRadioUiFunction : IFlatbufferObject
	{
		// Token: 0x1700CBE4 RID: 52196
		// (get) Token: 0x0603027D RID: 197245 RVA: 0x0068B96C File Offset: 0x00689B6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603027E RID: 197246 RVA: 0x0068B979 File Offset: 0x00689B79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603027F RID: 197247 RVA: 0x0068B980 File Offset: 0x00689B80
		public static IMotorRadioUiFunction GetRootAsIMotorRadioUiFunction(ByteBuffer _bb)
		{
			return IMotorRadioUiFunction.GetRootAsIMotorRadioUiFunction(_bb, default(IMotorRadioUiFunction));
		}

		// Token: 0x06030280 RID: 197248 RVA: 0x0068B99C File Offset: 0x00689B9C
		public static IMotorRadioUiFunction GetRootAsIMotorRadioUiFunction(ByteBuffer _bb, IMotorRadioUiFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030281 RID: 197249 RVA: 0x0068B9B9 File Offset: 0x00689BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030282 RID: 197250 RVA: 0x0068B9C8 File Offset: 0x00689BC8
		public IMotorRadioUiFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBE5 RID: 52197
		// (get) Token: 0x06030283 RID: 197251 RVA: 0x0068B9D8 File Offset: 0x00689BD8
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

		// Token: 0x1700CBE6 RID: 52198
		// (get) Token: 0x06030284 RID: 197252 RVA: 0x0068BA14 File Offset: 0x00689C14
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

		// Token: 0x06030285 RID: 197253 RVA: 0x0068BA50 File Offset: 0x00689C50
		public TTable? DisplayMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030286 RID: 197254 RVA: 0x0068BA94 File Offset: 0x00689C94
		public IDisableAllMotorRadioOperation DisplayModeAsIDisableAllMotorRadioOperation()
		{
			return this.DisplayMode<IDisableAllMotorRadioOperation>().Value;
		}

		// Token: 0x06030287 RID: 197255 RVA: 0x0068BAB0 File Offset: 0x00689CB0
		public IEnableAllMotorRadioOperation DisplayModeAsIEnableAllMotorRadioOperation()
		{
			return this.DisplayMode<IEnableAllMotorRadioOperation>().Value;
		}

		// Token: 0x06030288 RID: 197256 RVA: 0x0068BACB File Offset: 0x00689CCB
		public static Offset<IMotorRadioUiFunction> CreateIMotorRadioUiFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon, TMotorRadioOperationRestriction DisplayMode_type = TMotorRadioOperationRestriction.NONE, int DisplayModeOffset = 0)
		{
			builder.StartTable(3);
			IMotorRadioUiFunction.AddDisplayMode(builder, DisplayModeOffset);
			IMotorRadioUiFunction.AddDisplayModeType(builder, DisplayMode_type);
			IMotorRadioUiFunction.AddType(builder, Type);
			return IMotorRadioUiFunction.EndIMotorRadioUiFunction(builder);
		}

		// Token: 0x06030289 RID: 197257 RVA: 0x0068BAEF File Offset: 0x00689CEF
		public static void StartIMotorRadioUiFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603028A RID: 197258 RVA: 0x0068BAF8 File Offset: 0x00689CF8
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603028B RID: 197259 RVA: 0x0068BB03 File Offset: 0x00689D03
		public static void AddDisplayModeType(FlatBufferBuilder builder, TMotorRadioOperationRestriction displayModeType)
		{
			builder.AddByte(1, (byte)displayModeType, 0);
		}

		// Token: 0x0603028C RID: 197260 RVA: 0x0068BB0E File Offset: 0x00689D0E
		public static void AddDisplayMode(FlatBufferBuilder builder, int displayModeOffset)
		{
			builder.AddOffset(2, displayModeOffset, 0);
		}

		// Token: 0x0603028D RID: 197261 RVA: 0x0068BB19 File Offset: 0x00689D19
		public static Offset<IMotorRadioUiFunction> EndIMotorRadioUiFunction(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioUiFunction>(builder.EndTable());
		}

		// Token: 0x0603028E RID: 197262 RVA: 0x0068BB28 File Offset: 0x00689D28
		public IMotorRadioUiFunctionT UnPack()
		{
			IMotorRadioUiFunctionT motorRadioUiFunctionT = new IMotorRadioUiFunctionT();
			this.UnPackTo(motorRadioUiFunctionT);
			return motorRadioUiFunctionT;
		}

		// Token: 0x0603028F RID: 197263 RVA: 0x0068BB44 File Offset: 0x00689D44
		public void UnPackTo(IMotorRadioUiFunctionT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = new TMotorRadioOperationRestrictionUnion();
			_o.DisplayMode.Type = this.DisplayModeType;
			TMotorRadioOperationRestriction displayModeType = this.DisplayModeType;
			if (displayModeType == TMotorRadioOperationRestriction.IDisableAllMotorRadioOperation)
			{
				_o.DisplayMode.Value = ((this.DisplayMode<IDisableAllMotorRadioOperation>() != null) ? this.DisplayMode<IDisableAllMotorRadioOperation>().Value.UnPack() : null);
				return;
			}
			if (displayModeType != TMotorRadioOperationRestriction.IEnableAllMotorRadioOperation)
			{
				return;
			}
			_o.DisplayMode.Value = ((this.DisplayMode<IEnableAllMotorRadioOperation>() != null) ? this.DisplayMode<IEnableAllMotorRadioOperation>().Value.UnPack() : null);
		}

		// Token: 0x06030290 RID: 197264 RVA: 0x0068BBF4 File Offset: 0x00689DF4
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

		// Token: 0x040113C6 RID: 70598
		private Table __p;
	}
}
