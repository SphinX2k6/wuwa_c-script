using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B88 RID: 27528
	public struct IMp4UiReplaceMaterial : IFlatbufferObject
	{
		// Token: 0x1700CCA4 RID: 52388
		// (get) Token: 0x06030589 RID: 198025 RVA: 0x00691760 File Offset: 0x0068F960
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603058A RID: 198026 RVA: 0x0069176D File Offset: 0x0068F96D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603058B RID: 198027 RVA: 0x00691774 File Offset: 0x0068F974
		public static IMp4UiReplaceMaterial GetRootAsIMp4UiReplaceMaterial(ByteBuffer _bb)
		{
			return IMp4UiReplaceMaterial.GetRootAsIMp4UiReplaceMaterial(_bb, default(IMp4UiReplaceMaterial));
		}

		// Token: 0x0603058C RID: 198028 RVA: 0x00691790 File Offset: 0x0068F990
		public static IMp4UiReplaceMaterial GetRootAsIMp4UiReplaceMaterial(ByteBuffer _bb, IMp4UiReplaceMaterial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603058D RID: 198029 RVA: 0x006917AD File Offset: 0x0068F9AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603058E RID: 198030 RVA: 0x006917BC File Offset: 0x0068F9BC
		public IMp4UiReplaceMaterial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCA5 RID: 52389
		// (get) Token: 0x0603058F RID: 198031 RVA: 0x006917CC File Offset: 0x0068F9CC
		public EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				}
				return (EPlayMovieProgramSpecialConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCA6 RID: 52390
		// (get) Token: 0x06030590 RID: 198032 RVA: 0x00691808 File Offset: 0x0068FA08
		public string Mp4UiReplaceMaterial
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

		// Token: 0x06030591 RID: 198033 RVA: 0x0069183F File Offset: 0x0068FA3F
		public Span<byte> GetMp4UiReplaceMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030592 RID: 198034 RVA: 0x0069184E File Offset: 0x0068FA4E
		public byte[] GetMp4UiReplaceMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030593 RID: 198035 RVA: 0x0069185C File Offset: 0x0068FA5C
		public static Offset<IMp4UiReplaceMaterial> CreateIMp4UiReplaceMaterial(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial, StringOffset Mp4UiReplaceMaterialOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMp4UiReplaceMaterial.AddMp4UiReplaceMaterial(builder, Mp4UiReplaceMaterialOffset);
			IMp4UiReplaceMaterial.AddType(builder, Type);
			return IMp4UiReplaceMaterial.EndIMp4UiReplaceMaterial(builder);
		}

		// Token: 0x06030594 RID: 198036 RVA: 0x00691879 File Offset: 0x0068FA79
		public static void StartIMp4UiReplaceMaterial(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030595 RID: 198037 RVA: 0x00691882 File Offset: 0x0068FA82
		public static void AddType(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030596 RID: 198038 RVA: 0x0069188D File Offset: 0x0068FA8D
		public static void AddMp4UiReplaceMaterial(FlatBufferBuilder builder, StringOffset mp4UiReplaceMaterialOffset)
		{
			builder.AddOffset(1, mp4UiReplaceMaterialOffset.Value, 0);
		}

		// Token: 0x06030597 RID: 198039 RVA: 0x0069189D File Offset: 0x0068FA9D
		public static Offset<IMp4UiReplaceMaterial> EndIMp4UiReplaceMaterial(FlatBufferBuilder builder)
		{
			return new Offset<IMp4UiReplaceMaterial>(builder.EndTable());
		}

		// Token: 0x06030598 RID: 198040 RVA: 0x006918AC File Offset: 0x0068FAAC
		public IMp4UiReplaceMaterialT UnPack()
		{
			IMp4UiReplaceMaterialT mp4UiReplaceMaterialT = new IMp4UiReplaceMaterialT();
			this.UnPackTo(mp4UiReplaceMaterialT);
			return mp4UiReplaceMaterialT;
		}

		// Token: 0x06030599 RID: 198041 RVA: 0x006918C7 File Offset: 0x0068FAC7
		public void UnPackTo(IMp4UiReplaceMaterialT _o)
		{
			_o.Type = this.Type;
			_o.Mp4UiReplaceMaterial = this.Mp4UiReplaceMaterial;
		}

		// Token: 0x0603059A RID: 198042 RVA: 0x006918E4 File Offset: 0x0068FAE4
		public static Offset<IMp4UiReplaceMaterial> Pack(FlatBufferBuilder builder, IMp4UiReplaceMaterialT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4UiReplaceMaterial>);
			}
			StringOffset mp4UiReplaceMaterialOffset = (_o.Mp4UiReplaceMaterial == null) ? default(StringOffset) : builder.CreateString(_o.Mp4UiReplaceMaterial);
			return IMp4UiReplaceMaterial.CreateIMp4UiReplaceMaterial(builder, _o.Type, mp4UiReplaceMaterialOffset);
		}

		// Token: 0x04011448 RID: 70728
		private Table __p;
	}
}
