using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B57 RID: 27479
	public struct ICsvActionContext : IFlatbufferObject
	{
		// Token: 0x1700C9BD RID: 51645
		// (get) Token: 0x0602F49B RID: 193691 RVA: 0x00674A54 File Offset: 0x00672C54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F49C RID: 193692 RVA: 0x00674A61 File Offset: 0x00672C61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F49D RID: 193693 RVA: 0x00674A68 File Offset: 0x00672C68
		public static ICsvActionContext GetRootAsICsvActionContext(ByteBuffer _bb)
		{
			return ICsvActionContext.GetRootAsICsvActionContext(_bb, default(ICsvActionContext));
		}

		// Token: 0x0602F49E RID: 193694 RVA: 0x00674A84 File Offset: 0x00672C84
		public static ICsvActionContext GetRootAsICsvActionContext(ByteBuffer _bb, ICsvActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F49F RID: 193695 RVA: 0x00674AA1 File Offset: 0x00672CA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4A0 RID: 193696 RVA: 0x00674AB0 File Offset: 0x00672CB0
		public ICsvActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9BE RID: 51646
		// (get) Token: 0x0602F4A1 RID: 193697 RVA: 0x00674AC0 File Offset: 0x00672CC0
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

		// Token: 0x0602F4A2 RID: 193698 RVA: 0x00674AF7 File Offset: 0x00672CF7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F4A3 RID: 193699 RVA: 0x00674B06 File Offset: 0x00672D06
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602F4A4 RID: 193700 RVA: 0x00674B14 File Offset: 0x00672D14
		public static Offset<ICsvActionContext> CreateICsvActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ICsvActionContext.AddType(builder, TypeOffset);
			return ICsvActionContext.EndICsvActionContext(builder);
		}

		// Token: 0x0602F4A5 RID: 193701 RVA: 0x00674B2A File Offset: 0x00672D2A
		public static void StartICsvActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F4A6 RID: 193702 RVA: 0x00674B33 File Offset: 0x00672D33
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x0602F4A7 RID: 193703 RVA: 0x00674B43 File Offset: 0x00672D43
		public static Offset<ICsvActionContext> EndICsvActionContext(FlatBufferBuilder builder)
		{
			return new Offset<ICsvActionContext>(builder.EndTable());
		}

		// Token: 0x0602F4A8 RID: 193704 RVA: 0x00674B50 File Offset: 0x00672D50
		public ICsvActionContextT UnPack()
		{
			ICsvActionContextT csvActionContextT = new ICsvActionContextT();
			this.UnPackTo(csvActionContextT);
			return csvActionContextT;
		}

		// Token: 0x0602F4A9 RID: 193705 RVA: 0x00674B6B File Offset: 0x00672D6B
		public void UnPackTo(ICsvActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F4AA RID: 193706 RVA: 0x00674B7C File Offset: 0x00672D7C
		public static Offset<ICsvActionContext> Pack(FlatBufferBuilder builder, ICsvActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICsvActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return ICsvActionContext.CreateICsvActionContext(builder, typeOffset);
		}

		// Token: 0x04011947 RID: 72007
		private Table __p;
	}
}
