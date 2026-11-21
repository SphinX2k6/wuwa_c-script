using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0B RID: 28427
	public struct IGamePadInteractVibration : IFlatbufferObject
	{
		// Token: 0x1700D076 RID: 53366
		// (get) Token: 0x06031315 RID: 201493 RVA: 0x006AAB0C File Offset: 0x006A8D0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031316 RID: 201494 RVA: 0x006AAB19 File Offset: 0x006A8D19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031317 RID: 201495 RVA: 0x006AAB20 File Offset: 0x006A8D20
		public static IGamePadInteractVibration GetRootAsIGamePadInteractVibration(ByteBuffer _bb)
		{
			return IGamePadInteractVibration.GetRootAsIGamePadInteractVibration(_bb, default(IGamePadInteractVibration));
		}

		// Token: 0x06031318 RID: 201496 RVA: 0x006AAB3C File Offset: 0x006A8D3C
		public static IGamePadInteractVibration GetRootAsIGamePadInteractVibration(ByteBuffer _bb, IGamePadInteractVibration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031319 RID: 201497 RVA: 0x006AAB59 File Offset: 0x006A8D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603131A RID: 201498 RVA: 0x006AAB68 File Offset: 0x006A8D68
		public IGamePadInteractVibration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D077 RID: 53367
		// (get) Token: 0x0603131B RID: 201499 RVA: 0x006AAB78 File Offset: 0x006A8D78
		public string LongPressingEffect
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

		// Token: 0x0603131C RID: 201500 RVA: 0x006AABAF File Offset: 0x006A8DAF
		public Span<byte> GetLongPressingEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603131D RID: 201501 RVA: 0x006AABBE File Offset: 0x006A8DBE
		public byte[] GetLongPressingEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D078 RID: 53368
		// (get) Token: 0x0603131E RID: 201502 RVA: 0x006AABCC File Offset: 0x006A8DCC
		public string LongPressFinishedEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603131F RID: 201503 RVA: 0x006AAC03 File Offset: 0x006A8E03
		public Span<byte> GetLongPressFinishedEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031320 RID: 201504 RVA: 0x006AAC12 File Offset: 0x006A8E12
		public byte[] GetLongPressFinishedEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06031321 RID: 201505 RVA: 0x006AAC20 File Offset: 0x006A8E20
		public static Offset<IGamePadInteractVibration> CreateIGamePadInteractVibration(FlatBufferBuilder builder, StringOffset LongPressingEffectOffset = default(StringOffset), StringOffset LongPressFinishedEffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IGamePadInteractVibration.AddLongPressFinishedEffect(builder, LongPressFinishedEffectOffset);
			IGamePadInteractVibration.AddLongPressingEffect(builder, LongPressingEffectOffset);
			return IGamePadInteractVibration.EndIGamePadInteractVibration(builder);
		}

		// Token: 0x06031322 RID: 201506 RVA: 0x006AAC3D File Offset: 0x006A8E3D
		public static void StartIGamePadInteractVibration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031323 RID: 201507 RVA: 0x006AAC46 File Offset: 0x006A8E46
		public static void AddLongPressingEffect(FlatBufferBuilder builder, StringOffset longPressingEffectOffset)
		{
			builder.AddOffset(0, longPressingEffectOffset.Value, 0);
		}

		// Token: 0x06031324 RID: 201508 RVA: 0x006AAC56 File Offset: 0x006A8E56
		public static void AddLongPressFinishedEffect(FlatBufferBuilder builder, StringOffset longPressFinishedEffectOffset)
		{
			builder.AddOffset(1, longPressFinishedEffectOffset.Value, 0);
		}

		// Token: 0x06031325 RID: 201509 RVA: 0x006AAC66 File Offset: 0x006A8E66
		public static Offset<IGamePadInteractVibration> EndIGamePadInteractVibration(FlatBufferBuilder builder)
		{
			return new Offset<IGamePadInteractVibration>(builder.EndTable());
		}

		// Token: 0x06031326 RID: 201510 RVA: 0x006AAC74 File Offset: 0x006A8E74
		public IGamePadInteractVibrationT UnPack()
		{
			IGamePadInteractVibrationT gamePadInteractVibrationT = new IGamePadInteractVibrationT();
			this.UnPackTo(gamePadInteractVibrationT);
			return gamePadInteractVibrationT;
		}

		// Token: 0x06031327 RID: 201511 RVA: 0x006AAC8F File Offset: 0x006A8E8F
		public void UnPackTo(IGamePadInteractVibrationT _o)
		{
			_o.LongPressingEffect = this.LongPressingEffect;
			_o.LongPressFinishedEffect = this.LongPressFinishedEffect;
		}

		// Token: 0x06031328 RID: 201512 RVA: 0x006AACAC File Offset: 0x006A8EAC
		public static Offset<IGamePadInteractVibration> Pack(FlatBufferBuilder builder, IGamePadInteractVibrationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGamePadInteractVibration>);
			}
			StringOffset longPressingEffectOffset = (_o.LongPressingEffect == null) ? default(StringOffset) : builder.CreateString(_o.LongPressingEffect);
			StringOffset longPressFinishedEffectOffset = (_o.LongPressFinishedEffect == null) ? default(StringOffset) : builder.CreateString(_o.LongPressFinishedEffect);
			return IGamePadInteractVibration.CreateIGamePadInteractVibration(builder, longPressingEffectOffset, longPressFinishedEffectOffset);
		}

		// Token: 0x04011E11 RID: 73233
		private Table __p;
	}
}
