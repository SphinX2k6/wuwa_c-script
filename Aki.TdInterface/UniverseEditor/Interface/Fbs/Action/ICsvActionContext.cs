using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064EC RID: 25836
	public struct ICsvActionContext : IFlatbufferObject
	{
		// Token: 0x1700C030 RID: 49200
		// (get) Token: 0x0602CD17 RID: 183575 RVA: 0x0062892C File Offset: 0x00626B2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD18 RID: 183576 RVA: 0x00628939 File Offset: 0x00626B39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD19 RID: 183577 RVA: 0x00628940 File Offset: 0x00626B40
		public static ICsvActionContext GetRootAsICsvActionContext(ByteBuffer _bb)
		{
			return ICsvActionContext.GetRootAsICsvActionContext(_bb, default(ICsvActionContext));
		}

		// Token: 0x0602CD1A RID: 183578 RVA: 0x0062895C File Offset: 0x00626B5C
		public static ICsvActionContext GetRootAsICsvActionContext(ByteBuffer _bb, ICsvActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD1B RID: 183579 RVA: 0x00628979 File Offset: 0x00626B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD1C RID: 183580 RVA: 0x00628988 File Offset: 0x00626B88
		public ICsvActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C031 RID: 49201
		// (get) Token: 0x0602CD1D RID: 183581 RVA: 0x00628998 File Offset: 0x00626B98
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

		// Token: 0x0602CD1E RID: 183582 RVA: 0x006289CF File Offset: 0x00626BCF
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602CD1F RID: 183583 RVA: 0x006289DE File Offset: 0x00626BDE
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602CD20 RID: 183584 RVA: 0x006289EC File Offset: 0x00626BEC
		public static Offset<ICsvActionContext> CreateICsvActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ICsvActionContext.AddType(builder, TypeOffset);
			return ICsvActionContext.EndICsvActionContext(builder);
		}

		// Token: 0x0602CD21 RID: 183585 RVA: 0x00628A02 File Offset: 0x00626C02
		public static void StartICsvActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CD22 RID: 183586 RVA: 0x00628A0B File Offset: 0x00626C0B
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602CD23 RID: 183587 RVA: 0x00628A1B File Offset: 0x00626C1B
		public static Offset<ICsvActionContext> EndICsvActionContext(FlatBufferBuilder builder)
		{
			return new Offset<ICsvActionContext>(builder.EndTable());
		}

		// Token: 0x0602CD24 RID: 183588 RVA: 0x00628A28 File Offset: 0x00626C28
		public ICsvActionContextT UnPack()
		{
			ICsvActionContextT csvActionContextT = new ICsvActionContextT();
			this.UnPackTo(csvActionContextT);
			return csvActionContextT;
		}

		// Token: 0x0602CD25 RID: 183589 RVA: 0x00628A43 File Offset: 0x00626C43
		public void UnPackTo(ICsvActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CD26 RID: 183590 RVA: 0x00628A54 File Offset: 0x00626C54
		public static Offset<ICsvActionContext> Pack(FlatBufferBuilder builder, ICsvActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICsvActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return ICsvActionContext.CreateICsvActionContext(builder, typeOffset);
		}

		// Token: 0x04010B31 RID: 68401
		private Table __p;
	}
}
