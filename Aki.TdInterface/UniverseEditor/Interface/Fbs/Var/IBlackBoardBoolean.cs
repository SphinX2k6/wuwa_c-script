using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DE7 RID: 15847
	public struct IBlackBoardBoolean : IFlatbufferObject
	{
		// Token: 0x17006B03 RID: 27395
		// (get) Token: 0x0601544F RID: 87119 RVA: 0x003138BD File Offset: 0x00311ABD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015450 RID: 87120 RVA: 0x003138CA File Offset: 0x00311ACA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015451 RID: 87121 RVA: 0x003138D4 File Offset: 0x00311AD4
		public static IBlackBoardBoolean GetRootAsIBlackBoardBoolean(ByteBuffer _bb)
		{
			return IBlackBoardBoolean.GetRootAsIBlackBoardBoolean(_bb, default(IBlackBoardBoolean));
		}

		// Token: 0x06015452 RID: 87122 RVA: 0x003138F0 File Offset: 0x00311AF0
		public static IBlackBoardBoolean GetRootAsIBlackBoardBoolean(ByteBuffer _bb, IBlackBoardBoolean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015453 RID: 87123 RVA: 0x0031390D File Offset: 0x00311B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015454 RID: 87124 RVA: 0x0031391C File Offset: 0x00311B1C
		public IBlackBoardBoolean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B04 RID: 27396
		// (get) Token: 0x06015455 RID: 87125 RVA: 0x0031392C File Offset: 0x00311B2C
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

		// Token: 0x17006B05 RID: 27397
		// (get) Token: 0x06015456 RID: 87126 RVA: 0x00313968 File Offset: 0x00311B68
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

		// Token: 0x06015457 RID: 87127 RVA: 0x0031399F File Offset: 0x00311B9F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015458 RID: 87128 RVA: 0x003139AE File Offset: 0x00311BAE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006B06 RID: 27398
		// (get) Token: 0x06015459 RID: 87129 RVA: 0x003139BC File Offset: 0x00311BBC
		public bool Value
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601545A RID: 87130 RVA: 0x003139FB File Offset: 0x00311BFB
		public static Offset<IBlackBoardBoolean> CreateIBlackBoardBoolean(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), bool Value = false)
		{
			builder.StartTable(3);
			IBlackBoardBoolean.AddKey(builder, KeyOffset);
			IBlackBoardBoolean.AddValue(builder, Value);
			IBlackBoardBoolean.AddType(builder, Type);
			return IBlackBoardBoolean.EndIBlackBoardBoolean(builder);
		}

		// Token: 0x0601545B RID: 87131 RVA: 0x00313A1F File Offset: 0x00311C1F
		public static void StartIBlackBoardBoolean(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601545C RID: 87132 RVA: 0x00313A28 File Offset: 0x00311C28
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601545D RID: 87133 RVA: 0x00313A33 File Offset: 0x00311C33
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x0601545E RID: 87134 RVA: 0x00313A43 File Offset: 0x00311C43
		public static void AddValue(FlatBufferBuilder builder, bool value)
		{
			builder.AddBool(2, value, false);
		}

		// Token: 0x0601545F RID: 87135 RVA: 0x00313A4E File Offset: 0x00311C4E
		public static Offset<IBlackBoardBoolean> EndIBlackBoardBoolean(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardBoolean>(builder.EndTable());
		}

		// Token: 0x06015460 RID: 87136 RVA: 0x00313A5C File Offset: 0x00311C5C
		public IBlackBoardBooleanT UnPack()
		{
			IBlackBoardBooleanT blackBoardBooleanT = new IBlackBoardBooleanT();
			this.UnPackTo(blackBoardBooleanT);
			return blackBoardBooleanT;
		}

		// Token: 0x06015461 RID: 87137 RVA: 0x00313A77 File Offset: 0x00311C77
		public void UnPackTo(IBlackBoardBooleanT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x06015462 RID: 87138 RVA: 0x00313AA0 File Offset: 0x00311CA0
		public static Offset<IBlackBoardBoolean> Pack(FlatBufferBuilder builder, IBlackBoardBooleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardBoolean>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardBoolean.CreateIBlackBoardBoolean(builder, _o.Type, keyOffset, _o.Value);
		}

		// Token: 0x0400B796 RID: 46998
		private Table __p;
	}
}
