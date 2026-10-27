using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006897 RID: 26775
	public struct IGmActionContext : IFlatbufferObject
	{
		// Token: 0x1700C6C7 RID: 50887
		// (get) Token: 0x0602EB1E RID: 191262 RVA: 0x0065DCE1 File Offset: 0x0065BEE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB1F RID: 191263 RVA: 0x0065DCEE File Offset: 0x0065BEEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB20 RID: 191264 RVA: 0x0065DCF8 File Offset: 0x0065BEF8
		public static IGmActionContext GetRootAsIGmActionContext(ByteBuffer _bb)
		{
			return IGmActionContext.GetRootAsIGmActionContext(_bb, default(IGmActionContext));
		}

		// Token: 0x0602EB21 RID: 191265 RVA: 0x0065DD14 File Offset: 0x0065BF14
		public static IGmActionContext GetRootAsIGmActionContext(ByteBuffer _bb, IGmActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB22 RID: 191266 RVA: 0x0065DD31 File Offset: 0x0065BF31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB23 RID: 191267 RVA: 0x0065DD40 File Offset: 0x0065BF40
		public IGmActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6C8 RID: 50888
		// (get) Token: 0x0602EB24 RID: 191268 RVA: 0x0065DD50 File Offset: 0x0065BF50
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

		// Token: 0x0602EB25 RID: 191269 RVA: 0x0065DD87 File Offset: 0x0065BF87
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602EB26 RID: 191270 RVA: 0x0065DD96 File Offset: 0x0065BF96
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602EB27 RID: 191271 RVA: 0x0065DDA4 File Offset: 0x0065BFA4
		public static Offset<IGmActionContext> CreateIGmActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IGmActionContext.AddType(builder, TypeOffset);
			return IGmActionContext.EndIGmActionContext(builder);
		}

		// Token: 0x0602EB28 RID: 191272 RVA: 0x0065DDBA File Offset: 0x0065BFBA
		public static void StartIGmActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EB29 RID: 191273 RVA: 0x0065DDC3 File Offset: 0x0065BFC3
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602EB2A RID: 191274 RVA: 0x0065DDD3 File Offset: 0x0065BFD3
		public static Offset<IGmActionContext> EndIGmActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IGmActionContext>(builder.EndTable());
		}

		// Token: 0x0602EB2B RID: 191275 RVA: 0x0065DDE0 File Offset: 0x0065BFE0
		public IGmActionContextT UnPack()
		{
			IGmActionContextT gmActionContextT = new IGmActionContextT();
			this.UnPackTo(gmActionContextT);
			return gmActionContextT;
		}

		// Token: 0x0602EB2C RID: 191276 RVA: 0x0065DDFB File Offset: 0x0065BFFB
		public void UnPackTo(IGmActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EB2D RID: 191277 RVA: 0x0065DE0C File Offset: 0x0065C00C
		public static Offset<IGmActionContext> Pack(FlatBufferBuilder builder, IGmActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IGmActionContext.CreateIGmActionContext(builder, typeOffset);
		}

		// Token: 0x04010FE6 RID: 69606
		private Table __p;
	}
}
