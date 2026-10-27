using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686A RID: 26730
	public struct IGamePadInteractVibration : IFlatbufferObject
	{
		// Token: 0x1700C690 RID: 50832
		// (get) Token: 0x0602E9DB RID: 190939 RVA: 0x0065BA8C File Offset: 0x00659C8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E9DC RID: 190940 RVA: 0x0065BA99 File Offset: 0x00659C99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E9DD RID: 190941 RVA: 0x0065BAA0 File Offset: 0x00659CA0
		public static IGamePadInteractVibration GetRootAsIGamePadInteractVibration(ByteBuffer _bb)
		{
			return IGamePadInteractVibration.GetRootAsIGamePadInteractVibration(_bb, default(IGamePadInteractVibration));
		}

		// Token: 0x0602E9DE RID: 190942 RVA: 0x0065BABC File Offset: 0x00659CBC
		public static IGamePadInteractVibration GetRootAsIGamePadInteractVibration(ByteBuffer _bb, IGamePadInteractVibration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E9DF RID: 190943 RVA: 0x0065BAD9 File Offset: 0x00659CD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E9E0 RID: 190944 RVA: 0x0065BAE8 File Offset: 0x00659CE8
		public IGamePadInteractVibration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C691 RID: 50833
		// (get) Token: 0x0602E9E1 RID: 190945 RVA: 0x0065BAF8 File Offset: 0x00659CF8
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

		// Token: 0x0602E9E2 RID: 190946 RVA: 0x0065BB2F File Offset: 0x00659D2F
		public Span<byte> GetLongPressingEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E9E3 RID: 190947 RVA: 0x0065BB3E File Offset: 0x00659D3E
		public byte[] GetLongPressingEffectArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C692 RID: 50834
		// (get) Token: 0x0602E9E4 RID: 190948 RVA: 0x0065BB4C File Offset: 0x00659D4C
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

		// Token: 0x0602E9E5 RID: 190949 RVA: 0x0065BB83 File Offset: 0x00659D83
		public Span<byte> GetLongPressFinishedEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E9E6 RID: 190950 RVA: 0x0065BB92 File Offset: 0x00659D92
		public byte[] GetLongPressFinishedEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E9E7 RID: 190951 RVA: 0x0065BBA0 File Offset: 0x00659DA0
		public static Offset<IGamePadInteractVibration> CreateIGamePadInteractVibration(FlatBufferBuilder builder, StringOffset LongPressingEffectOffset = default(StringOffset), StringOffset LongPressFinishedEffectOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IGamePadInteractVibration.AddLongPressFinishedEffect(builder, LongPressFinishedEffectOffset);
			IGamePadInteractVibration.AddLongPressingEffect(builder, LongPressingEffectOffset);
			return IGamePadInteractVibration.EndIGamePadInteractVibration(builder);
		}

		// Token: 0x0602E9E8 RID: 190952 RVA: 0x0065BBBD File Offset: 0x00659DBD
		public static void StartIGamePadInteractVibration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E9E9 RID: 190953 RVA: 0x0065BBC6 File Offset: 0x00659DC6
		public static void AddLongPressingEffect(FlatBufferBuilder builder, StringOffset longPressingEffectOffset)
		{
			builder.AddOffset(0, longPressingEffectOffset.Value, 0);
		}

		// Token: 0x0602E9EA RID: 190954 RVA: 0x0065BBD6 File Offset: 0x00659DD6
		public static void AddLongPressFinishedEffect(FlatBufferBuilder builder, StringOffset longPressFinishedEffectOffset)
		{
			builder.AddOffset(1, longPressFinishedEffectOffset.Value, 0);
		}

		// Token: 0x0602E9EB RID: 190955 RVA: 0x0065BBE6 File Offset: 0x00659DE6
		public static Offset<IGamePadInteractVibration> EndIGamePadInteractVibration(FlatBufferBuilder builder)
		{
			return new Offset<IGamePadInteractVibration>(builder.EndTable());
		}

		// Token: 0x0602E9EC RID: 190956 RVA: 0x0065BBF4 File Offset: 0x00659DF4
		public IGamePadInteractVibrationT UnPack()
		{
			IGamePadInteractVibrationT gamePadInteractVibrationT = new IGamePadInteractVibrationT();
			this.UnPackTo(gamePadInteractVibrationT);
			return gamePadInteractVibrationT;
		}

		// Token: 0x0602E9ED RID: 190957 RVA: 0x0065BC0F File Offset: 0x00659E0F
		public void UnPackTo(IGamePadInteractVibrationT _o)
		{
			_o.LongPressingEffect = this.LongPressingEffect;
			_o.LongPressFinishedEffect = this.LongPressFinishedEffect;
		}

		// Token: 0x0602E9EE RID: 190958 RVA: 0x0065BC2C File Offset: 0x00659E2C
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

		// Token: 0x04010FBC RID: 69564
		private Table __p;
	}
}
