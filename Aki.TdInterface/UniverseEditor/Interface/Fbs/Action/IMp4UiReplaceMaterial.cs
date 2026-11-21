using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072CE RID: 29390
	public struct IMp4UiReplaceMaterial : IFlatbufferObject
	{
		// Token: 0x1700D789 RID: 55177
		// (get) Token: 0x060333E1 RID: 209889 RVA: 0x006E9D80 File Offset: 0x006E7F80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060333E2 RID: 209890 RVA: 0x006E9D8D File Offset: 0x006E7F8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060333E3 RID: 209891 RVA: 0x006E9D94 File Offset: 0x006E7F94
		public static IMp4UiReplaceMaterial GetRootAsIMp4UiReplaceMaterial(ByteBuffer _bb)
		{
			return IMp4UiReplaceMaterial.GetRootAsIMp4UiReplaceMaterial(_bb, default(IMp4UiReplaceMaterial));
		}

		// Token: 0x060333E4 RID: 209892 RVA: 0x006E9DB0 File Offset: 0x006E7FB0
		public static IMp4UiReplaceMaterial GetRootAsIMp4UiReplaceMaterial(ByteBuffer _bb, IMp4UiReplaceMaterial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060333E5 RID: 209893 RVA: 0x006E9DCD File Offset: 0x006E7FCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060333E6 RID: 209894 RVA: 0x006E9DDC File Offset: 0x006E7FDC
		public IMp4UiReplaceMaterial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D78A RID: 55178
		// (get) Token: 0x060333E7 RID: 209895 RVA: 0x006E9DEC File Offset: 0x006E7FEC
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

		// Token: 0x1700D78B RID: 55179
		// (get) Token: 0x060333E8 RID: 209896 RVA: 0x006E9E28 File Offset: 0x006E8028
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

		// Token: 0x060333E9 RID: 209897 RVA: 0x006E9E5F File Offset: 0x006E805F
		public Span<byte> GetMp4UiReplaceMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060333EA RID: 209898 RVA: 0x006E9E6E File Offset: 0x006E806E
		public byte[] GetMp4UiReplaceMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060333EB RID: 209899 RVA: 0x006E9E7C File Offset: 0x006E807C
		public static Offset<IMp4UiReplaceMaterial> CreateIMp4UiReplaceMaterial(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType Type = EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial, StringOffset Mp4UiReplaceMaterialOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IMp4UiReplaceMaterial.AddMp4UiReplaceMaterial(builder, Mp4UiReplaceMaterialOffset);
			IMp4UiReplaceMaterial.AddType(builder, Type);
			return IMp4UiReplaceMaterial.EndIMp4UiReplaceMaterial(builder);
		}

		// Token: 0x060333EC RID: 209900 RVA: 0x006E9E99 File Offset: 0x006E8099
		public static void StartIMp4UiReplaceMaterial(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060333ED RID: 209901 RVA: 0x006E9EA2 File Offset: 0x006E80A2
		public static void AddType(FlatBufferBuilder builder, EPlayMovieProgramSpecialConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060333EE RID: 209902 RVA: 0x006E9EAD File Offset: 0x006E80AD
		public static void AddMp4UiReplaceMaterial(FlatBufferBuilder builder, StringOffset mp4UiReplaceMaterialOffset)
		{
			builder.AddOffset(1, mp4UiReplaceMaterialOffset.Value, 0);
		}

		// Token: 0x060333EF RID: 209903 RVA: 0x006E9EBD File Offset: 0x006E80BD
		public static Offset<IMp4UiReplaceMaterial> EndIMp4UiReplaceMaterial(FlatBufferBuilder builder)
		{
			return new Offset<IMp4UiReplaceMaterial>(builder.EndTable());
		}

		// Token: 0x060333F0 RID: 209904 RVA: 0x006E9ECC File Offset: 0x006E80CC
		public IMp4UiReplaceMaterialT UnPack()
		{
			IMp4UiReplaceMaterialT mp4UiReplaceMaterialT = new IMp4UiReplaceMaterialT();
			this.UnPackTo(mp4UiReplaceMaterialT);
			return mp4UiReplaceMaterialT;
		}

		// Token: 0x060333F1 RID: 209905 RVA: 0x006E9EE7 File Offset: 0x006E80E7
		public void UnPackTo(IMp4UiReplaceMaterialT _o)
		{
			_o.Type = this.Type;
			_o.Mp4UiReplaceMaterial = this.Mp4UiReplaceMaterial;
		}

		// Token: 0x060333F2 RID: 209906 RVA: 0x006E9F04 File Offset: 0x006E8104
		public static Offset<IMp4UiReplaceMaterial> Pack(FlatBufferBuilder builder, IMp4UiReplaceMaterialT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4UiReplaceMaterial>);
			}
			StringOffset mp4UiReplaceMaterialOffset = (_o.Mp4UiReplaceMaterial == null) ? default(StringOffset) : builder.CreateString(_o.Mp4UiReplaceMaterial);
			return IMp4UiReplaceMaterial.CreateIMp4UiReplaceMaterial(builder, _o.Type, mp4UiReplaceMaterialOffset);
		}

		// Token: 0x04012371 RID: 74609
		private Table __p;
	}
}
