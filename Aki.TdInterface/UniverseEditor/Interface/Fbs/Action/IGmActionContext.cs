using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F38 RID: 28472
	public struct IGmActionContext : IFlatbufferObject
	{
		// Token: 0x1700D0AD RID: 53421
		// (get) Token: 0x06031458 RID: 201816 RVA: 0x006ACD61 File Offset: 0x006AAF61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031459 RID: 201817 RVA: 0x006ACD6E File Offset: 0x006AAF6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603145A RID: 201818 RVA: 0x006ACD78 File Offset: 0x006AAF78
		public static IGmActionContext GetRootAsIGmActionContext(ByteBuffer _bb)
		{
			return IGmActionContext.GetRootAsIGmActionContext(_bb, default(IGmActionContext));
		}

		// Token: 0x0603145B RID: 201819 RVA: 0x006ACD94 File Offset: 0x006AAF94
		public static IGmActionContext GetRootAsIGmActionContext(ByteBuffer _bb, IGmActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603145C RID: 201820 RVA: 0x006ACDB1 File Offset: 0x006AAFB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603145D RID: 201821 RVA: 0x006ACDC0 File Offset: 0x006AAFC0
		public IGmActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0AE RID: 53422
		// (get) Token: 0x0603145E RID: 201822 RVA: 0x006ACDD0 File Offset: 0x006AAFD0
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

		// Token: 0x0603145F RID: 201823 RVA: 0x006ACE07 File Offset: 0x006AB007
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031460 RID: 201824 RVA: 0x006ACE16 File Offset: 0x006AB016
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06031461 RID: 201825 RVA: 0x006ACE24 File Offset: 0x006AB024
		public static Offset<IGmActionContext> CreateIGmActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IGmActionContext.AddType(builder, TypeOffset);
			return IGmActionContext.EndIGmActionContext(builder);
		}

		// Token: 0x06031462 RID: 201826 RVA: 0x006ACE3A File Offset: 0x006AB03A
		public static void StartIGmActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031463 RID: 201827 RVA: 0x006ACE43 File Offset: 0x006AB043
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06031464 RID: 201828 RVA: 0x006ACE53 File Offset: 0x006AB053
		public static Offset<IGmActionContext> EndIGmActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IGmActionContext>(builder.EndTable());
		}

		// Token: 0x06031465 RID: 201829 RVA: 0x006ACE60 File Offset: 0x006AB060
		public IGmActionContextT UnPack()
		{
			IGmActionContextT gmActionContextT = new IGmActionContextT();
			this.UnPackTo(gmActionContextT);
			return gmActionContextT;
		}

		// Token: 0x06031466 RID: 201830 RVA: 0x006ACE7B File Offset: 0x006AB07B
		public void UnPackTo(IGmActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031467 RID: 201831 RVA: 0x006ACE8C File Offset: 0x006AB08C
		public static Offset<IGmActionContext> Pack(FlatBufferBuilder builder, IGmActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGmActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IGmActionContext.CreateIGmActionContext(builder, typeOffset);
		}

		// Token: 0x04011E3B RID: 73275
		private Table __p;
	}
}
