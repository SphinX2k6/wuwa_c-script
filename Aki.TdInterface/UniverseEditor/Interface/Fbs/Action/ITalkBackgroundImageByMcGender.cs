using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200729E RID: 29342
	public struct ITalkBackgroundImageByMcGender : IFlatbufferObject
	{
		// Token: 0x1700D99D RID: 55709
		// (get) Token: 0x060340E7 RID: 213223 RVA: 0x006FF801 File Offset: 0x006FDA01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060340E8 RID: 213224 RVA: 0x006FF80E File Offset: 0x006FDA0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060340E9 RID: 213225 RVA: 0x006FF818 File Offset: 0x006FDA18
		public static ITalkBackgroundImageByMcGender GetRootAsITalkBackgroundImageByMcGender(ByteBuffer _bb)
		{
			return ITalkBackgroundImageByMcGender.GetRootAsITalkBackgroundImageByMcGender(_bb, default(ITalkBackgroundImageByMcGender));
		}

		// Token: 0x060340EA RID: 213226 RVA: 0x006FF834 File Offset: 0x006FDA34
		public static ITalkBackgroundImageByMcGender GetRootAsITalkBackgroundImageByMcGender(ByteBuffer _bb, ITalkBackgroundImageByMcGender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060340EB RID: 213227 RVA: 0x006FF851 File Offset: 0x006FDA51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060340EC RID: 213228 RVA: 0x006FF860 File Offset: 0x006FDA60
		public ITalkBackgroundImageByMcGender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D99E RID: 55710
		// (get) Token: 0x060340ED RID: 213229 RVA: 0x006FF870 File Offset: 0x006FDA70
		public ETalkBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkBackgroundType.Clean;
				}
				return (ETalkBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D99F RID: 55711
		// (get) Token: 0x060340EE RID: 213230 RVA: 0x006FF8AC File Offset: 0x006FDAAC
		public string ImageAssetMale
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

		// Token: 0x060340EF RID: 213231 RVA: 0x006FF8E3 File Offset: 0x006FDAE3
		public Span<byte> GetImageAssetMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060340F0 RID: 213232 RVA: 0x006FF8F2 File Offset: 0x006FDAF2
		public byte[] GetImageAssetMaleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D9A0 RID: 55712
		// (get) Token: 0x060340F1 RID: 213233 RVA: 0x006FF900 File Offset: 0x006FDB00
		public string ImageAssetFemale
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060340F2 RID: 213234 RVA: 0x006FF937 File Offset: 0x006FDB37
		public Span<byte> GetImageAssetFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060340F3 RID: 213235 RVA: 0x006FF946 File Offset: 0x006FDB46
		public byte[] GetImageAssetFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060340F4 RID: 213236 RVA: 0x006FF954 File Offset: 0x006FDB54
		public static Offset<ITalkBackgroundImageByMcGender> CreateITalkBackgroundImageByMcGender(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, StringOffset ImageAssetMaleOffset = default(StringOffset), StringOffset ImageAssetFemaleOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITalkBackgroundImageByMcGender.AddImageAssetFemale(builder, ImageAssetFemaleOffset);
			ITalkBackgroundImageByMcGender.AddImageAssetMale(builder, ImageAssetMaleOffset);
			ITalkBackgroundImageByMcGender.AddType(builder, Type);
			return ITalkBackgroundImageByMcGender.EndITalkBackgroundImageByMcGender(builder);
		}

		// Token: 0x060340F5 RID: 213237 RVA: 0x006FF978 File Offset: 0x006FDB78
		public static void StartITalkBackgroundImageByMcGender(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060340F6 RID: 213238 RVA: 0x006FF981 File Offset: 0x006FDB81
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060340F7 RID: 213239 RVA: 0x006FF98C File Offset: 0x006FDB8C
		public static void AddImageAssetMale(FlatBufferBuilder builder, StringOffset imageAssetMaleOffset)
		{
			builder.AddOffset(1, imageAssetMaleOffset.Value, 0);
		}

		// Token: 0x060340F8 RID: 213240 RVA: 0x006FF99C File Offset: 0x006FDB9C
		public static void AddImageAssetFemale(FlatBufferBuilder builder, StringOffset imageAssetFemaleOffset)
		{
			builder.AddOffset(2, imageAssetFemaleOffset.Value, 0);
		}

		// Token: 0x060340F9 RID: 213241 RVA: 0x006FF9AC File Offset: 0x006FDBAC
		public static Offset<ITalkBackgroundImageByMcGender> EndITalkBackgroundImageByMcGender(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundImageByMcGender>(builder.EndTable());
		}

		// Token: 0x060340FA RID: 213242 RVA: 0x006FF9BC File Offset: 0x006FDBBC
		public ITalkBackgroundImageByMcGenderT UnPack()
		{
			ITalkBackgroundImageByMcGenderT talkBackgroundImageByMcGenderT = new ITalkBackgroundImageByMcGenderT();
			this.UnPackTo(talkBackgroundImageByMcGenderT);
			return talkBackgroundImageByMcGenderT;
		}

		// Token: 0x060340FB RID: 213243 RVA: 0x006FF9D7 File Offset: 0x006FDBD7
		public void UnPackTo(ITalkBackgroundImageByMcGenderT _o)
		{
			_o.Type = this.Type;
			_o.ImageAssetMale = this.ImageAssetMale;
			_o.ImageAssetFemale = this.ImageAssetFemale;
		}

		// Token: 0x060340FC RID: 213244 RVA: 0x006FFA00 File Offset: 0x006FDC00
		public static Offset<ITalkBackgroundImageByMcGender> Pack(FlatBufferBuilder builder, ITalkBackgroundImageByMcGenderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundImageByMcGender>);
			}
			StringOffset imageAssetMaleOffset = (_o.ImageAssetMale == null) ? default(StringOffset) : builder.CreateString(_o.ImageAssetMale);
			StringOffset imageAssetFemaleOffset = (_o.ImageAssetFemale == null) ? default(StringOffset) : builder.CreateString(_o.ImageAssetFemale);
			return ITalkBackgroundImageByMcGender.CreateITalkBackgroundImageByMcGender(builder, _o.Type, imageAssetMaleOffset, imageAssetFemaleOffset);
		}

		// Token: 0x04011DA8 RID: 73128
		private Table __p;
	}
}
