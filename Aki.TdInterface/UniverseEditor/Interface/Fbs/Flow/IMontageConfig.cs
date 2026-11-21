using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA7 RID: 19367
	public struct IMontageConfig : IFlatbufferObject
	{
		// Token: 0x17008914 RID: 35092
		// (get) Token: 0x0601D8B8 RID: 121016 RVA: 0x00425E52 File Offset: 0x00424052
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D8B9 RID: 121017 RVA: 0x00425E5F File Offset: 0x0042405F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D8BA RID: 121018 RVA: 0x00425E68 File Offset: 0x00424068
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb)
		{
			return IMontageConfig.GetRootAsIMontageConfig(_bb, default(IMontageConfig));
		}

		// Token: 0x0601D8BB RID: 121019 RVA: 0x00425E84 File Offset: 0x00424084
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb, IMontageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D8BC RID: 121020 RVA: 0x00425EA1 File Offset: 0x004240A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D8BD RID: 121021 RVA: 0x00425EB0 File Offset: 0x004240B0
		public IMontageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008915 RID: 35093
		// (get) Token: 0x0601D8BE RID: 121022 RVA: 0x00425EC0 File Offset: 0x004240C0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008916 RID: 35094
		// (get) Token: 0x0601D8BF RID: 121023 RVA: 0x00425EFC File Offset: 0x004240FC
		public string ActionMontage
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

		// Token: 0x0601D8C0 RID: 121024 RVA: 0x00425F33 File Offset: 0x00424133
		public Span<byte> GetActionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D8C1 RID: 121025 RVA: 0x00425F42 File Offset: 0x00424142
		public byte[] GetActionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008917 RID: 35095
		// (get) Token: 0x0601D8C2 RID: 121026 RVA: 0x00425F50 File Offset: 0x00424150
		public string ExpressionMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8C3 RID: 121027 RVA: 0x00425F87 File Offset: 0x00424187
		public Span<byte> GetExpressionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D8C4 RID: 121028 RVA: 0x00425F96 File Offset: 0x00424196
		public byte[] GetExpressionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008918 RID: 35096
		// (get) Token: 0x0601D8C5 RID: 121029 RVA: 0x00425FA4 File Offset: 0x004241A4
		public string MouthSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8C6 RID: 121030 RVA: 0x00425FDC File Offset: 0x004241DC
		public Span<byte> GetMouthSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601D8C7 RID: 121031 RVA: 0x00425FEC File Offset: 0x004241EC
		public byte[] GetMouthSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008919 RID: 35097
		// (get) Token: 0x0601D8C8 RID: 121032 RVA: 0x00425FFC File Offset: 0x004241FC
		public string InitState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8C9 RID: 121033 RVA: 0x00426034 File Offset: 0x00424234
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601D8CA RID: 121034 RVA: 0x00426044 File Offset: 0x00424244
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700891A RID: 35098
		// (get) Token: 0x0601D8CB RID: 121035 RVA: 0x00426054 File Offset: 0x00424254
		public string EndState
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8CC RID: 121036 RVA: 0x0042608C File Offset: 0x0042428C
		public Span<byte> GetEndStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601D8CD RID: 121037 RVA: 0x0042609C File Offset: 0x0042429C
		public byte[] GetEndStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700891B RID: 35099
		// (get) Token: 0x0601D8CE RID: 121038 RVA: 0x004260AC File Offset: 0x004242AC
		public bool DisableBlinkCurve
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700891C RID: 35100
		// (get) Token: 0x0601D8CF RID: 121039 RVA: 0x004260EC File Offset: 0x004242EC
		public string MaleVariant
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8D0 RID: 121040 RVA: 0x00426124 File Offset: 0x00424324
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601D8D1 RID: 121041 RVA: 0x00426134 File Offset: 0x00424334
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700891D RID: 35101
		// (get) Token: 0x0601D8D2 RID: 121042 RVA: 0x00426144 File Offset: 0x00424344
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D8D3 RID: 121043 RVA: 0x00426184 File Offset: 0x00424384
		public static Offset<IMontageConfig> CreateIMontageConfig(FlatBufferBuilder builder, int Id = 0, StringOffset ActionMontageOffset = default(StringOffset), StringOffset ExpressionMontageOffset = default(StringOffset), StringOffset MouthSequenceOffset = default(StringOffset), StringOffset InitStateOffset = default(StringOffset), StringOffset EndStateOffset = default(StringOffset), bool DisableBlinkCurve = false, StringOffset MaleVariantOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(9);
			IMontageConfig.AddMaleVariant(builder, MaleVariantOffset);
			IMontageConfig.AddEndState(builder, EndStateOffset);
			IMontageConfig.AddInitState(builder, InitStateOffset);
			IMontageConfig.AddMouthSequence(builder, MouthSequenceOffset);
			IMontageConfig.AddExpressionMontage(builder, ExpressionMontageOffset);
			IMontageConfig.AddActionMontage(builder, ActionMontageOffset);
			IMontageConfig.AddId(builder, Id);
			IMontageConfig.AddNullMask(builder, NullMask);
			IMontageConfig.AddDisableBlinkCurve(builder, DisableBlinkCurve);
			return IMontageConfig.EndIMontageConfig(builder);
		}

		// Token: 0x0601D8D4 RID: 121044 RVA: 0x004261E4 File Offset: 0x004243E4
		public static void StartIMontageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601D8D5 RID: 121045 RVA: 0x004261EE File Offset: 0x004243EE
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D8D6 RID: 121046 RVA: 0x004261F9 File Offset: 0x004243F9
		public static void AddActionMontage(FlatBufferBuilder builder, StringOffset actionMontageOffset)
		{
			builder.AddOffset(1, actionMontageOffset.Value, 0);
		}

		// Token: 0x0601D8D7 RID: 121047 RVA: 0x00426209 File Offset: 0x00424409
		public static void AddExpressionMontage(FlatBufferBuilder builder, StringOffset expressionMontageOffset)
		{
			builder.AddOffset(2, expressionMontageOffset.Value, 0);
		}

		// Token: 0x0601D8D8 RID: 121048 RVA: 0x00426219 File Offset: 0x00424419
		public static void AddMouthSequence(FlatBufferBuilder builder, StringOffset mouthSequenceOffset)
		{
			builder.AddOffset(3, mouthSequenceOffset.Value, 0);
		}

		// Token: 0x0601D8D9 RID: 121049 RVA: 0x00426229 File Offset: 0x00424429
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(4, initStateOffset.Value, 0);
		}

		// Token: 0x0601D8DA RID: 121050 RVA: 0x00426239 File Offset: 0x00424439
		public static void AddEndState(FlatBufferBuilder builder, StringOffset endStateOffset)
		{
			builder.AddOffset(5, endStateOffset.Value, 0);
		}

		// Token: 0x0601D8DB RID: 121051 RVA: 0x00426249 File Offset: 0x00424449
		public static void AddDisableBlinkCurve(FlatBufferBuilder builder, bool disableBlinkCurve)
		{
			builder.AddBool(6, disableBlinkCurve, false);
		}

		// Token: 0x0601D8DC RID: 121052 RVA: 0x00426254 File Offset: 0x00424454
		public static void AddMaleVariant(FlatBufferBuilder builder, StringOffset maleVariantOffset)
		{
			builder.AddOffset(7, maleVariantOffset.Value, 0);
		}

		// Token: 0x0601D8DD RID: 121053 RVA: 0x00426264 File Offset: 0x00424464
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601D8DE RID: 121054 RVA: 0x0042626F File Offset: 0x0042446F
		public static Offset<IMontageConfig> EndIMontageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMontageConfig>(builder.EndTable());
		}

		// Token: 0x0601D8DF RID: 121055 RVA: 0x0042627C File Offset: 0x0042447C
		public IMontageConfigT UnPack()
		{
			IMontageConfigT montageConfigT = new IMontageConfigT();
			this.UnPackTo(montageConfigT);
			return montageConfigT;
		}

		// Token: 0x0601D8E0 RID: 121056 RVA: 0x00426298 File Offset: 0x00424498
		public void UnPackTo(IMontageConfigT _o)
		{
			_o.Id = this.Id;
			_o.ActionMontage = this.ActionMontage;
			_o.ExpressionMontage = this.ExpressionMontage;
			_o.MouthSequence = this.MouthSequence;
			_o.InitState = this.InitState;
			_o.EndState = this.EndState;
			_o.DisableBlinkCurve = this.DisableBlinkCurve;
			_o.MaleVariant = this.MaleVariant;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D8E1 RID: 121057 RVA: 0x00426314 File Offset: 0x00424514
		public static Offset<IMontageConfig> Pack(FlatBufferBuilder builder, IMontageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMontageConfig>);
			}
			StringOffset actionMontageOffset = (_o.ActionMontage == null) ? default(StringOffset) : builder.CreateString(_o.ActionMontage);
			StringOffset expressionMontageOffset = (_o.ExpressionMontage == null) ? default(StringOffset) : builder.CreateString(_o.ExpressionMontage);
			StringOffset mouthSequenceOffset = (_o.MouthSequence == null) ? default(StringOffset) : builder.CreateString(_o.MouthSequence);
			StringOffset initStateOffset = (_o.InitState == null) ? default(StringOffset) : builder.CreateString(_o.InitState);
			StringOffset endStateOffset = (_o.EndState == null) ? default(StringOffset) : builder.CreateString(_o.EndState);
			StringOffset maleVariantOffset = (_o.MaleVariant == null) ? default(StringOffset) : builder.CreateString(_o.MaleVariant);
			return IMontageConfig.CreateIMontageConfig(builder, _o.Id, actionMontageOffset, expressionMontageOffset, mouthSequenceOffset, initStateOffset, endStateOffset, _o.DisableBlinkCurve, maleVariantOffset, _o.NullMask);
		}

		// Token: 0x0400D456 RID: 54358
		private Table __p;
	}
}
