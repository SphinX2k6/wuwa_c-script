using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200473F RID: 18239
	public struct IMontageConfig : IFlatbufferObject
	{
		// Token: 0x170082D3 RID: 33491
		// (get) Token: 0x0601C0E3 RID: 114915 RVA: 0x003F9BB6 File Offset: 0x003F7DB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C0E4 RID: 114916 RVA: 0x003F9BC3 File Offset: 0x003F7DC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C0E5 RID: 114917 RVA: 0x003F9BCC File Offset: 0x003F7DCC
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb)
		{
			return IMontageConfig.GetRootAsIMontageConfig(_bb, default(IMontageConfig));
		}

		// Token: 0x0601C0E6 RID: 114918 RVA: 0x003F9BE8 File Offset: 0x003F7DE8
		public static IMontageConfig GetRootAsIMontageConfig(ByteBuffer _bb, IMontageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C0E7 RID: 114919 RVA: 0x003F9C05 File Offset: 0x003F7E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C0E8 RID: 114920 RVA: 0x003F9C14 File Offset: 0x003F7E14
		public IMontageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082D4 RID: 33492
		// (get) Token: 0x0601C0E9 RID: 114921 RVA: 0x003F9C24 File Offset: 0x003F7E24
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

		// Token: 0x170082D5 RID: 33493
		// (get) Token: 0x0601C0EA RID: 114922 RVA: 0x003F9C60 File Offset: 0x003F7E60
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

		// Token: 0x0601C0EB RID: 114923 RVA: 0x003F9C97 File Offset: 0x003F7E97
		public Span<byte> GetActionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C0EC RID: 114924 RVA: 0x003F9CA6 File Offset: 0x003F7EA6
		public byte[] GetActionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170082D6 RID: 33494
		// (get) Token: 0x0601C0ED RID: 114925 RVA: 0x003F9CB4 File Offset: 0x003F7EB4
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

		// Token: 0x0601C0EE RID: 114926 RVA: 0x003F9CEB File Offset: 0x003F7EEB
		public Span<byte> GetExpressionMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601C0EF RID: 114927 RVA: 0x003F9CFA File Offset: 0x003F7EFA
		public byte[] GetExpressionMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170082D7 RID: 33495
		// (get) Token: 0x0601C0F0 RID: 114928 RVA: 0x003F9D08 File Offset: 0x003F7F08
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

		// Token: 0x0601C0F1 RID: 114929 RVA: 0x003F9D40 File Offset: 0x003F7F40
		public Span<byte> GetMouthSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601C0F2 RID: 114930 RVA: 0x003F9D50 File Offset: 0x003F7F50
		public byte[] GetMouthSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170082D8 RID: 33496
		// (get) Token: 0x0601C0F3 RID: 114931 RVA: 0x003F9D60 File Offset: 0x003F7F60
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

		// Token: 0x0601C0F4 RID: 114932 RVA: 0x003F9D98 File Offset: 0x003F7F98
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601C0F5 RID: 114933 RVA: 0x003F9DA8 File Offset: 0x003F7FA8
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170082D9 RID: 33497
		// (get) Token: 0x0601C0F6 RID: 114934 RVA: 0x003F9DB8 File Offset: 0x003F7FB8
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

		// Token: 0x0601C0F7 RID: 114935 RVA: 0x003F9DF0 File Offset: 0x003F7FF0
		public Span<byte> GetEndStateBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601C0F8 RID: 114936 RVA: 0x003F9E00 File Offset: 0x003F8000
		public byte[] GetEndStateArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170082DA RID: 33498
		// (get) Token: 0x0601C0F9 RID: 114937 RVA: 0x003F9E10 File Offset: 0x003F8010
		public bool DisableBlinkCurve
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170082DB RID: 33499
		// (get) Token: 0x0601C0FA RID: 114938 RVA: 0x003F9E50 File Offset: 0x003F8050
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

		// Token: 0x0601C0FB RID: 114939 RVA: 0x003F9E88 File Offset: 0x003F8088
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601C0FC RID: 114940 RVA: 0x003F9E98 File Offset: 0x003F8098
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x170082DC RID: 33500
		// (get) Token: 0x0601C0FD RID: 114941 RVA: 0x003F9EA8 File Offset: 0x003F80A8
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

		// Token: 0x0601C0FE RID: 114942 RVA: 0x003F9EE8 File Offset: 0x003F80E8
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

		// Token: 0x0601C0FF RID: 114943 RVA: 0x003F9F48 File Offset: 0x003F8148
		public static void StartIMontageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0601C100 RID: 114944 RVA: 0x003F9F52 File Offset: 0x003F8152
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C101 RID: 114945 RVA: 0x003F9F5D File Offset: 0x003F815D
		public static void AddActionMontage(FlatBufferBuilder builder, StringOffset actionMontageOffset)
		{
			builder.AddOffset(1, actionMontageOffset.Value, 0);
		}

		// Token: 0x0601C102 RID: 114946 RVA: 0x003F9F6D File Offset: 0x003F816D
		public static void AddExpressionMontage(FlatBufferBuilder builder, StringOffset expressionMontageOffset)
		{
			builder.AddOffset(2, expressionMontageOffset.Value, 0);
		}

		// Token: 0x0601C103 RID: 114947 RVA: 0x003F9F7D File Offset: 0x003F817D
		public static void AddMouthSequence(FlatBufferBuilder builder, StringOffset mouthSequenceOffset)
		{
			builder.AddOffset(3, mouthSequenceOffset.Value, 0);
		}

		// Token: 0x0601C104 RID: 114948 RVA: 0x003F9F8D File Offset: 0x003F818D
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(4, initStateOffset.Value, 0);
		}

		// Token: 0x0601C105 RID: 114949 RVA: 0x003F9F9D File Offset: 0x003F819D
		public static void AddEndState(FlatBufferBuilder builder, StringOffset endStateOffset)
		{
			builder.AddOffset(5, endStateOffset.Value, 0);
		}

		// Token: 0x0601C106 RID: 114950 RVA: 0x003F9FAD File Offset: 0x003F81AD
		public static void AddDisableBlinkCurve(FlatBufferBuilder builder, bool disableBlinkCurve)
		{
			builder.AddBool(6, disableBlinkCurve, false);
		}

		// Token: 0x0601C107 RID: 114951 RVA: 0x003F9FB8 File Offset: 0x003F81B8
		public static void AddMaleVariant(FlatBufferBuilder builder, StringOffset maleVariantOffset)
		{
			builder.AddOffset(7, maleVariantOffset.Value, 0);
		}

		// Token: 0x0601C108 RID: 114952 RVA: 0x003F9FC8 File Offset: 0x003F81C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0601C109 RID: 114953 RVA: 0x003F9FD3 File Offset: 0x003F81D3
		public static Offset<IMontageConfig> EndIMontageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMontageConfig>(builder.EndTable());
		}

		// Token: 0x0601C10A RID: 114954 RVA: 0x003F9FE0 File Offset: 0x003F81E0
		public IMontageConfigT UnPack()
		{
			IMontageConfigT montageConfigT = new IMontageConfigT();
			this.UnPackTo(montageConfigT);
			return montageConfigT;
		}

		// Token: 0x0601C10B RID: 114955 RVA: 0x003F9FFC File Offset: 0x003F81FC
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

		// Token: 0x0601C10C RID: 114956 RVA: 0x003FA078 File Offset: 0x003F8278
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

		// Token: 0x0400CA27 RID: 51751
		private Table __p;
	}
}
