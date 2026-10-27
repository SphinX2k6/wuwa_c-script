using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A15 RID: 14869
	public struct IBlackBoardFloat : IFlatbufferObject
	{
		// Token: 0x170065E8 RID: 26088
		// (get) Token: 0x06014187 RID: 82311 RVA: 0x002F0EFE File Offset: 0x002EF0FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014188 RID: 82312 RVA: 0x002F0F0B File Offset: 0x002EF10B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014189 RID: 82313 RVA: 0x002F0F14 File Offset: 0x002EF114
		public static IBlackBoardFloat GetRootAsIBlackBoardFloat(ByteBuffer _bb)
		{
			return IBlackBoardFloat.GetRootAsIBlackBoardFloat(_bb, default(IBlackBoardFloat));
		}

		// Token: 0x0601418A RID: 82314 RVA: 0x002F0F30 File Offset: 0x002EF130
		public static IBlackBoardFloat GetRootAsIBlackBoardFloat(ByteBuffer _bb, IBlackBoardFloat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601418B RID: 82315 RVA: 0x002F0F4D File Offset: 0x002EF14D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601418C RID: 82316 RVA: 0x002F0F5C File Offset: 0x002EF15C
		public IBlackBoardFloat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065E9 RID: 26089
		// (get) Token: 0x0601418D RID: 82317 RVA: 0x002F0F6C File Offset: 0x002EF16C
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

		// Token: 0x170065EA RID: 26090
		// (get) Token: 0x0601418E RID: 82318 RVA: 0x002F0FA8 File Offset: 0x002EF1A8
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

		// Token: 0x0601418F RID: 82319 RVA: 0x002F0FDF File Offset: 0x002EF1DF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014190 RID: 82320 RVA: 0x002F0FEE File Offset: 0x002EF1EE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170065EB RID: 26091
		// (get) Token: 0x06014191 RID: 82321 RVA: 0x002F0FFC File Offset: 0x002EF1FC
		public float Value
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014192 RID: 82322 RVA: 0x002F103C File Offset: 0x002EF23C
		public static Offset<IBlackBoardFloat> CreateIBlackBoardFloat(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), float Value = 0f)
		{
			builder.StartTable(3);
			IBlackBoardFloat.AddValue(builder, Value);
			IBlackBoardFloat.AddKey(builder, KeyOffset);
			IBlackBoardFloat.AddType(builder, Type);
			return IBlackBoardFloat.EndIBlackBoardFloat(builder);
		}

		// Token: 0x06014193 RID: 82323 RVA: 0x002F1060 File Offset: 0x002EF260
		public static void StartIBlackBoardFloat(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014194 RID: 82324 RVA: 0x002F1069 File Offset: 0x002EF269
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014195 RID: 82325 RVA: 0x002F1074 File Offset: 0x002EF274
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06014196 RID: 82326 RVA: 0x002F1084 File Offset: 0x002EF284
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(2, value, 0.0);
		}

		// Token: 0x06014197 RID: 82327 RVA: 0x002F1097 File Offset: 0x002EF297
		public static Offset<IBlackBoardFloat> EndIBlackBoardFloat(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardFloat>(builder.EndTable());
		}

		// Token: 0x06014198 RID: 82328 RVA: 0x002F10A4 File Offset: 0x002EF2A4
		public IBlackBoardFloatT UnPack()
		{
			IBlackBoardFloatT blackBoardFloatT = new IBlackBoardFloatT();
			this.UnPackTo(blackBoardFloatT);
			return blackBoardFloatT;
		}

		// Token: 0x06014199 RID: 82329 RVA: 0x002F10BF File Offset: 0x002EF2BF
		public void UnPackTo(IBlackBoardFloatT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x0601419A RID: 82330 RVA: 0x002F10E8 File Offset: 0x002EF2E8
		public static Offset<IBlackBoardFloat> Pack(FlatBufferBuilder builder, IBlackBoardFloatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardFloat>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardFloat.CreateIBlackBoardFloat(builder, _o.Type, keyOffset, _o.Value);
		}

		// Token: 0x0400AE80 RID: 44672
		private Table __p;
	}
}
