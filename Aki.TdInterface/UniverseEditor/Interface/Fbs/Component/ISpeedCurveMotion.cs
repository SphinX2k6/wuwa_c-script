using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F84 RID: 24452
	public struct ISpeedCurveMotion : IFlatbufferObject
	{
		// Token: 0x1700B50D RID: 46349
		// (get) Token: 0x060291A9 RID: 168361 RVA: 0x0059CEA2 File Offset: 0x0059B0A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060291AA RID: 168362 RVA: 0x0059CEAF File Offset: 0x0059B0AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060291AB RID: 168363 RVA: 0x0059CEB8 File Offset: 0x0059B0B8
		public static ISpeedCurveMotion GetRootAsISpeedCurveMotion(ByteBuffer _bb)
		{
			return ISpeedCurveMotion.GetRootAsISpeedCurveMotion(_bb, default(ISpeedCurveMotion));
		}

		// Token: 0x060291AC RID: 168364 RVA: 0x0059CED4 File Offset: 0x0059B0D4
		public static ISpeedCurveMotion GetRootAsISpeedCurveMotion(ByteBuffer _bb, ISpeedCurveMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060291AD RID: 168365 RVA: 0x0059CEF1 File Offset: 0x0059B0F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060291AE RID: 168366 RVA: 0x0059CF00 File Offset: 0x0059B100
		public ISpeedCurveMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B50E RID: 46350
		// (get) Token: 0x060291AF RID: 168367 RVA: 0x0059CF10 File Offset: 0x0059B110
		public string SpeedCurve
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060291B0 RID: 168368 RVA: 0x0059CF47 File Offset: 0x0059B147
		public Span<byte> GetSpeedCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060291B1 RID: 168369 RVA: 0x0059CF56 File Offset: 0x0059B156
		public byte[] GetSpeedCurveArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060291B2 RID: 168370 RVA: 0x0059CF64 File Offset: 0x0059B164
		public static Offset<ISpeedCurveMotion> CreateISpeedCurveMotion(FlatBufferBuilder builder, StringOffset SpeedCurveOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISpeedCurveMotion.AddSpeedCurve(builder, SpeedCurveOffset);
			return ISpeedCurveMotion.EndISpeedCurveMotion(builder);
		}

		// Token: 0x060291B3 RID: 168371 RVA: 0x0059CF7A File Offset: 0x0059B17A
		public static void StartISpeedCurveMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060291B4 RID: 168372 RVA: 0x0059CF83 File Offset: 0x0059B183
		public static void AddSpeedCurve(FlatBufferBuilder builder, StringOffset speedCurveOffset)
		{
			builder.AddOffset(0, speedCurveOffset.Value, 0);
		}

		// Token: 0x060291B5 RID: 168373 RVA: 0x0059CF93 File Offset: 0x0059B193
		public static Offset<ISpeedCurveMotion> EndISpeedCurveMotion(FlatBufferBuilder builder)
		{
			return new Offset<ISpeedCurveMotion>(builder.EndTable());
		}

		// Token: 0x060291B6 RID: 168374 RVA: 0x0059CFA0 File Offset: 0x0059B1A0
		public ISpeedCurveMotionT UnPack()
		{
			ISpeedCurveMotionT speedCurveMotionT = new ISpeedCurveMotionT();
			this.UnPackTo(speedCurveMotionT);
			return speedCurveMotionT;
		}

		// Token: 0x060291B7 RID: 168375 RVA: 0x0059CFBB File Offset: 0x0059B1BB
		public void UnPackTo(ISpeedCurveMotionT _o)
		{
			_o.SpeedCurve = this.SpeedCurve;
		}

		// Token: 0x060291B8 RID: 168376 RVA: 0x0059CFCC File Offset: 0x0059B1CC
		public static Offset<ISpeedCurveMotion> Pack(FlatBufferBuilder builder, ISpeedCurveMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpeedCurveMotion>);
			}
			StringOffset speedCurveOffset = (_o.SpeedCurve == null) ? default(StringOffset) : builder.CreateString(_o.SpeedCurve);
			return ISpeedCurveMotion.CreateISpeedCurveMotion(builder, speedCurveOffset);
		}

		// Token: 0x0400FC5A RID: 64602
		private Table __p;
	}
}
