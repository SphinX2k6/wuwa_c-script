using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC4 RID: 27332
	public struct ICommonBtActionContext : IFlatbufferObject
	{
		// Token: 0x1700C8B7 RID: 51383
		// (get) Token: 0x0602EE9D RID: 192157 RVA: 0x0066406A File Offset: 0x0066226A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE9E RID: 192158 RVA: 0x00664077 File Offset: 0x00662277
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE9F RID: 192159 RVA: 0x00664080 File Offset: 0x00662280
		public static ICommonBtActionContext GetRootAsICommonBtActionContext(ByteBuffer _bb)
		{
			return ICommonBtActionContext.GetRootAsICommonBtActionContext(_bb, default(ICommonBtActionContext));
		}

		// Token: 0x0602EEA0 RID: 192160 RVA: 0x0066409C File Offset: 0x0066229C
		public static ICommonBtActionContext GetRootAsICommonBtActionContext(ByteBuffer _bb, ICommonBtActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EEA1 RID: 192161 RVA: 0x006640B9 File Offset: 0x006622B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EEA2 RID: 192162 RVA: 0x006640C8 File Offset: 0x006622C8
		public ICommonBtActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8B8 RID: 51384
		// (get) Token: 0x0602EEA3 RID: 192163 RVA: 0x006640D8 File Offset: 0x006622D8
		public string Type
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

		// Token: 0x0602EEA4 RID: 192164 RVA: 0x0066410F File Offset: 0x0066230F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602EEA5 RID: 192165 RVA: 0x0066411E File Offset: 0x0066231E
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602EEA6 RID: 192166 RVA: 0x0066412C File Offset: 0x0066232C
		public static Offset<ICommonBtActionContext> CreateICommonBtActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ICommonBtActionContext.AddType(builder, TypeOffset);
			return ICommonBtActionContext.EndICommonBtActionContext(builder);
		}

		// Token: 0x0602EEA7 RID: 192167 RVA: 0x00664142 File Offset: 0x00662342
		public static void StartICommonBtActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EEA8 RID: 192168 RVA: 0x0066414B File Offset: 0x0066234B
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602EEA9 RID: 192169 RVA: 0x0066415B File Offset: 0x0066235B
		public static Offset<ICommonBtActionContext> EndICommonBtActionContext(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtActionContext>(builder.EndTable());
		}

		// Token: 0x0602EEAA RID: 192170 RVA: 0x00664168 File Offset: 0x00662368
		public ICommonBtActionContextT UnPack()
		{
			ICommonBtActionContextT commonBtActionContextT = new ICommonBtActionContextT();
			this.UnPackTo(commonBtActionContextT);
			return commonBtActionContextT;
		}

		// Token: 0x0602EEAB RID: 192171 RVA: 0x00664183 File Offset: 0x00662383
		public void UnPackTo(ICommonBtActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EEAC RID: 192172 RVA: 0x00664194 File Offset: 0x00662394
		public static Offset<ICommonBtActionContext> Pack(FlatBufferBuilder builder, ICommonBtActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return ICommonBtActionContext.CreateICommonBtActionContext(builder, typeOffset);
		}

		// Token: 0x04011865 RID: 71781
		private Table __p;
	}
}
