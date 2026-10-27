using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702E RID: 28718
	public struct ISetNpcGroupPerform : IFlatbufferObject
	{
		// Token: 0x1700D53F RID: 54591
		// (get) Token: 0x06032CC9 RID: 208073 RVA: 0x006DA431 File Offset: 0x006D8631
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032CCA RID: 208074 RVA: 0x006DA43E File Offset: 0x006D863E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032CCB RID: 208075 RVA: 0x006DA448 File Offset: 0x006D8648
		public static ISetNpcGroupPerform GetRootAsISetNpcGroupPerform(ByteBuffer _bb)
		{
			return ISetNpcGroupPerform.GetRootAsISetNpcGroupPerform(_bb, default(ISetNpcGroupPerform));
		}

		// Token: 0x06032CCC RID: 208076 RVA: 0x006DA464 File Offset: 0x006D8664
		public static ISetNpcGroupPerform GetRootAsISetNpcGroupPerform(ByteBuffer _bb, ISetNpcGroupPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032CCD RID: 208077 RVA: 0x006DA481 File Offset: 0x006D8681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032CCE RID: 208078 RVA: 0x006DA490 File Offset: 0x006D8690
		public ISetNpcGroupPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D540 RID: 54592
		// (get) Token: 0x06032CCF RID: 208079 RVA: 0x006DA4A0 File Offset: 0x006D86A0
		public string Key
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

		// Token: 0x06032CD0 RID: 208080 RVA: 0x006DA4D7 File Offset: 0x006D86D7
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06032CD1 RID: 208081 RVA: 0x006DA4E6 File Offset: 0x006D86E6
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D541 RID: 54593
		// (get) Token: 0x06032CD2 RID: 208082 RVA: 0x006DA4F4 File Offset: 0x006D86F4
		public TSetNpcGroupPerformType PerformTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TSetNpcGroupPerformType.NONE;
				}
				return (TSetNpcGroupPerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032CD3 RID: 208083 RVA: 0x006DA530 File Offset: 0x006D8730
		public TTable? PerformType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032CD4 RID: 208084 RVA: 0x006DA574 File Offset: 0x006D8774
		public ISetNpcHandInHandPerform PerformTypeAsISetNpcHandInHandPerform()
		{
			return this.PerformType<ISetNpcHandInHandPerform>().Value;
		}

		// Token: 0x06032CD5 RID: 208085 RVA: 0x006DA590 File Offset: 0x006D8790
		public ISetNpcHighFivePerform PerformTypeAsISetNpcHighFivePerform()
		{
			return this.PerformType<ISetNpcHighFivePerform>().Value;
		}

		// Token: 0x06032CD6 RID: 208086 RVA: 0x006DA5AC File Offset: 0x006D87AC
		public ISetNpcHuggingBearPerform PerformTypeAsISetNpcHuggingBearPerform()
		{
			return this.PerformType<ISetNpcHuggingBearPerform>().Value;
		}

		// Token: 0x06032CD7 RID: 208087 RVA: 0x006DA5C8 File Offset: 0x006D87C8
		public ISetNpcSupportedWalkingPerform PerformTypeAsISetNpcSupportedWalkingPerform()
		{
			return this.PerformType<ISetNpcSupportedWalkingPerform>().Value;
		}

		// Token: 0x06032CD8 RID: 208088 RVA: 0x006DA5E4 File Offset: 0x006D87E4
		public ISetNpcTwoPersonPerform PerformTypeAsISetNpcTwoPersonPerform()
		{
			return this.PerformType<ISetNpcTwoPersonPerform>().Value;
		}

		// Token: 0x1700D542 RID: 54594
		// (get) Token: 0x06032CD9 RID: 208089 RVA: 0x006DA600 File Offset: 0x006D8800
		public bool IsWaitActionFinish
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D543 RID: 54595
		// (get) Token: 0x06032CDA RID: 208090 RVA: 0x006DA640 File Offset: 0x006D8840
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032CDB RID: 208091 RVA: 0x006DA67D File Offset: 0x006D887D
		public static Offset<ISetNpcGroupPerform> CreateISetNpcGroupPerform(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), TSetNpcGroupPerformType PerformType_type = TSetNpcGroupPerformType.NONE, int PerformTypeOffset = 0, bool IsWaitActionFinish = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISetNpcGroupPerform.AddPerformType(builder, PerformTypeOffset);
			ISetNpcGroupPerform.AddKey(builder, KeyOffset);
			ISetNpcGroupPerform.AddNullMask(builder, NullMask);
			ISetNpcGroupPerform.AddIsWaitActionFinish(builder, IsWaitActionFinish);
			ISetNpcGroupPerform.AddPerformTypeType(builder, PerformType_type);
			return ISetNpcGroupPerform.EndISetNpcGroupPerform(builder);
		}

		// Token: 0x06032CDC RID: 208092 RVA: 0x006DA6B1 File Offset: 0x006D88B1
		public static void StartISetNpcGroupPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06032CDD RID: 208093 RVA: 0x006DA6BA File Offset: 0x006D88BA
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06032CDE RID: 208094 RVA: 0x006DA6CA File Offset: 0x006D88CA
		public static void AddPerformTypeType(FlatBufferBuilder builder, TSetNpcGroupPerformType performTypeType)
		{
			builder.AddByte(1, (byte)performTypeType, 0);
		}

		// Token: 0x06032CDF RID: 208095 RVA: 0x006DA6D5 File Offset: 0x006D88D5
		public static void AddPerformType(FlatBufferBuilder builder, int performTypeOffset)
		{
			builder.AddOffset(2, performTypeOffset, 0);
		}

		// Token: 0x06032CE0 RID: 208096 RVA: 0x006DA6E0 File Offset: 0x006D88E0
		public static void AddIsWaitActionFinish(FlatBufferBuilder builder, bool isWaitActionFinish)
		{
			builder.AddBool(3, isWaitActionFinish, false);
		}

		// Token: 0x06032CE1 RID: 208097 RVA: 0x006DA6EB File Offset: 0x006D88EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06032CE2 RID: 208098 RVA: 0x006DA6F6 File Offset: 0x006D88F6
		public static Offset<ISetNpcGroupPerform> EndISetNpcGroupPerform(FlatBufferBuilder builder)
		{
			return new Offset<ISetNpcGroupPerform>(builder.EndTable());
		}

		// Token: 0x06032CE3 RID: 208099 RVA: 0x006DA704 File Offset: 0x006D8904
		public ISetNpcGroupPerformT UnPack()
		{
			ISetNpcGroupPerformT setNpcGroupPerformT = new ISetNpcGroupPerformT();
			this.UnPackTo(setNpcGroupPerformT);
			return setNpcGroupPerformT;
		}

		// Token: 0x06032CE4 RID: 208100 RVA: 0x006DA720 File Offset: 0x006D8920
		public void UnPackTo(ISetNpcGroupPerformT _o)
		{
			_o.Key = this.Key;
			_o.PerformType = new TSetNpcGroupPerformTypeUnion();
			_o.PerformType.Type = this.PerformTypeType;
			switch (this.PerformTypeType)
			{
			case TSetNpcGroupPerformType.ISetNpcHandInHandPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcHandInHandPerform>() != null) ? this.PerformType<ISetNpcHandInHandPerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcHighFivePerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcHighFivePerform>() != null) ? this.PerformType<ISetNpcHighFivePerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcHuggingBearPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcHuggingBearPerform>() != null) ? this.PerformType<ISetNpcHuggingBearPerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcSupportedWalkingPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcSupportedWalkingPerform>() != null) ? this.PerformType<ISetNpcSupportedWalkingPerform>().Value.UnPack() : null);
				break;
			case TSetNpcGroupPerformType.ISetNpcTwoPersonPerform:
				_o.PerformType.Value = ((this.PerformType<ISetNpcTwoPersonPerform>() != null) ? this.PerformType<ISetNpcTwoPersonPerform>().Value.UnPack() : null);
				break;
			}
			_o.IsWaitActionFinish = this.IsWaitActionFinish;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032CE5 RID: 208101 RVA: 0x006DA8B4 File Offset: 0x006D8AB4
		public static Offset<ISetNpcGroupPerform> Pack(FlatBufferBuilder builder, ISetNpcGroupPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetNpcGroupPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			TSetNpcGroupPerformType performType_type = (_o.PerformType == null) ? TSetNpcGroupPerformType.NONE : _o.PerformType.Type;
			int performTypeOffset = (_o.PerformType == null) ? 0 : TSetNpcGroupPerformTypeUnion.Pack(builder, _o.PerformType);
			return ISetNpcGroupPerform.CreateISetNpcGroupPerform(builder, keyOffset, performType_type, performTypeOffset, _o.IsWaitActionFinish, _o.NullMask);
		}

		// Token: 0x04011A5D RID: 72285
		private Table __p;
	}
}
