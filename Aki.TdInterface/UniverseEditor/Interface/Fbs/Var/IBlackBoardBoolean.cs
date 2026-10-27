using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A0C RID: 14860
	public struct IBlackBoardBoolean : IFlatbufferObject
	{
		// Token: 0x170065D3 RID: 26067
		// (get) Token: 0x06014133 RID: 82227 RVA: 0x002F06D1 File Offset: 0x002EE8D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014134 RID: 82228 RVA: 0x002F06DE File Offset: 0x002EE8DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014135 RID: 82229 RVA: 0x002F06E8 File Offset: 0x002EE8E8
		public static IBlackBoardBoolean GetRootAsIBlackBoardBoolean(ByteBuffer _bb)
		{
			return IBlackBoardBoolean.GetRootAsIBlackBoardBoolean(_bb, default(IBlackBoardBoolean));
		}

		// Token: 0x06014136 RID: 82230 RVA: 0x002F0704 File Offset: 0x002EE904
		public static IBlackBoardBoolean GetRootAsIBlackBoardBoolean(ByteBuffer _bb, IBlackBoardBoolean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014137 RID: 82231 RVA: 0x002F0721 File Offset: 0x002EE921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014138 RID: 82232 RVA: 0x002F0730 File Offset: 0x002EE930
		public IBlackBoardBoolean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065D4 RID: 26068
		// (get) Token: 0x06014139 RID: 82233 RVA: 0x002F0740 File Offset: 0x002EE940
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170065D5 RID: 26069
		// (get) Token: 0x0601413A RID: 82234 RVA: 0x002F077C File Offset: 0x002EE97C
		public string Key
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

		// Token: 0x0601413B RID: 82235 RVA: 0x002F07B3 File Offset: 0x002EE9B3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601413C RID: 82236 RVA: 0x002F07C2 File Offset: 0x002EE9C2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170065D6 RID: 26070
		// (get) Token: 0x0601413D RID: 82237 RVA: 0x002F07D0 File Offset: 0x002EE9D0
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601413E RID: 82238 RVA: 0x002F080F File Offset: 0x002EEA0F
		public static Offset<IBlackBoardBoolean> CreateIBlackBoardBoolean(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), bool Value = false)
		{
			builder.StartTable(3);
			IBlackBoardBoolean.AddKey(builder, KeyOffset);
			IBlackBoardBoolean.AddValue(builder, Value);
			IBlackBoardBoolean.AddType(builder, Type);
			return IBlackBoardBoolean.EndIBlackBoardBoolean(builder);
		}

		// Token: 0x0601413F RID: 82239 RVA: 0x002F0833 File Offset: 0x002EEA33
		public static void StartIBlackBoardBoolean(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014140 RID: 82240 RVA: 0x002F083C File Offset: 0x002EEA3C
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014141 RID: 82241 RVA: 0x002F0847 File Offset: 0x002EEA47
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06014142 RID: 82242 RVA: 0x002F0857 File Offset: 0x002EEA57
		public static void AddValue(FlatBufferBuilder builder, bool value)
		{
			builder.AddBool(2, value, false);
		}

		// Token: 0x06014143 RID: 82243 RVA: 0x002F0862 File Offset: 0x002EEA62
		public static Offset<IBlackBoardBoolean> EndIBlackBoardBoolean(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardBoolean>(builder.EndTable());
		}

		// Token: 0x06014144 RID: 82244 RVA: 0x002F0870 File Offset: 0x002EEA70
		public IBlackBoardBooleanT UnPack()
		{
			IBlackBoardBooleanT blackBoardBooleanT = new IBlackBoardBooleanT();
			this.UnPackTo(blackBoardBooleanT);
			return blackBoardBooleanT;
		}

		// Token: 0x06014145 RID: 82245 RVA: 0x002F088B File Offset: 0x002EEA8B
		public void UnPackTo(IBlackBoardBooleanT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x06014146 RID: 82246 RVA: 0x002F08B4 File Offset: 0x002EEAB4
		public static Offset<IBlackBoardBoolean> Pack(FlatBufferBuilder builder, IBlackBoardBooleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardBoolean>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardBoolean.CreateIBlackBoardBoolean(builder, _o.Type, keyOffset, _o.Value);
		}

		// Token: 0x0400AE74 RID: 44660
		private Table __p;
	}
}
