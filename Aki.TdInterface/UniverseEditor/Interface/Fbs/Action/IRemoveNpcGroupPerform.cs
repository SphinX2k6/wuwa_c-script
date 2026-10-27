using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E52 RID: 28242
	public struct IRemoveNpcGroupPerform : IFlatbufferObject
	{
		// Token: 0x1700D266 RID: 53862
		// (get) Token: 0x06031E7A RID: 204410 RVA: 0x006C0A5D File Offset: 0x006BEC5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E7B RID: 204411 RVA: 0x006C0A6A File Offset: 0x006BEC6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E7C RID: 204412 RVA: 0x006C0A74 File Offset: 0x006BEC74
		public static IRemoveNpcGroupPerform GetRootAsIRemoveNpcGroupPerform(ByteBuffer _bb)
		{
			return IRemoveNpcGroupPerform.GetRootAsIRemoveNpcGroupPerform(_bb, default(IRemoveNpcGroupPerform));
		}

		// Token: 0x06031E7D RID: 204413 RVA: 0x006C0A90 File Offset: 0x006BEC90
		public static IRemoveNpcGroupPerform GetRootAsIRemoveNpcGroupPerform(ByteBuffer _bb, IRemoveNpcGroupPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E7E RID: 204414 RVA: 0x006C0AAD File Offset: 0x006BECAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E7F RID: 204415 RVA: 0x006C0ABC File Offset: 0x006BECBC
		public IRemoveNpcGroupPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D267 RID: 53863
		// (get) Token: 0x06031E80 RID: 204416 RVA: 0x006C0ACC File Offset: 0x006BECCC
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

		// Token: 0x06031E81 RID: 204417 RVA: 0x006C0B03 File Offset: 0x006BED03
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031E82 RID: 204418 RVA: 0x006C0B12 File Offset: 0x006BED12
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06031E83 RID: 204419 RVA: 0x006C0B20 File Offset: 0x006BED20
		public static Offset<IRemoveNpcGroupPerform> CreateIRemoveNpcGroupPerform(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IRemoveNpcGroupPerform.AddKey(builder, KeyOffset);
			return IRemoveNpcGroupPerform.EndIRemoveNpcGroupPerform(builder);
		}

		// Token: 0x06031E84 RID: 204420 RVA: 0x006C0B36 File Offset: 0x006BED36
		public static void StartIRemoveNpcGroupPerform(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031E85 RID: 204421 RVA: 0x006C0B3F File Offset: 0x006BED3F
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06031E86 RID: 204422 RVA: 0x006C0B4F File Offset: 0x006BED4F
		public static Offset<IRemoveNpcGroupPerform> EndIRemoveNpcGroupPerform(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveNpcGroupPerform>(builder.EndTable());
		}

		// Token: 0x06031E87 RID: 204423 RVA: 0x006C0B5C File Offset: 0x006BED5C
		public IRemoveNpcGroupPerformT UnPack()
		{
			IRemoveNpcGroupPerformT removeNpcGroupPerformT = new IRemoveNpcGroupPerformT();
			this.UnPackTo(removeNpcGroupPerformT);
			return removeNpcGroupPerformT;
		}

		// Token: 0x06031E88 RID: 204424 RVA: 0x006C0B77 File Offset: 0x006BED77
		public void UnPackTo(IRemoveNpcGroupPerformT _o)
		{
			_o.Key = this.Key;
		}

		// Token: 0x06031E89 RID: 204425 RVA: 0x006C0B88 File Offset: 0x006BED88
		public static Offset<IRemoveNpcGroupPerform> Pack(FlatBufferBuilder builder, IRemoveNpcGroupPerformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveNpcGroupPerform>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IRemoveNpcGroupPerform.CreateIRemoveNpcGroupPerform(builder, keyOffset);
		}

		// Token: 0x04011838 RID: 71736
		private Table __p;
	}
}
