using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A73 RID: 31347
	public struct ITalkBackgroundImageByMcGender : IFlatbufferObject
	{
		// Token: 0x1700E596 RID: 58774
		// (get) Token: 0x060373EB RID: 226283 RVA: 0x00760B9D File Offset: 0x0075ED9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060373EC RID: 226284 RVA: 0x00760BAA File Offset: 0x0075EDAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060373ED RID: 226285 RVA: 0x00760BB4 File Offset: 0x0075EDB4
		public static ITalkBackgroundImageByMcGender GetRootAsITalkBackgroundImageByMcGender(ByteBuffer _bb)
		{
			return ITalkBackgroundImageByMcGender.GetRootAsITalkBackgroundImageByMcGender(_bb, default(ITalkBackgroundImageByMcGender));
		}

		// Token: 0x060373EE RID: 226286 RVA: 0x00760BD0 File Offset: 0x0075EDD0
		public static ITalkBackgroundImageByMcGender GetRootAsITalkBackgroundImageByMcGender(ByteBuffer _bb, ITalkBackgroundImageByMcGender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060373EF RID: 226287 RVA: 0x00760BED File Offset: 0x0075EDED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060373F0 RID: 226288 RVA: 0x00760BFC File Offset: 0x0075EDFC
		public ITalkBackgroundImageByMcGender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E597 RID: 58775
		// (get) Token: 0x060373F1 RID: 226289 RVA: 0x00760C0C File Offset: 0x0075EE0C
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

		// Token: 0x1700E598 RID: 58776
		// (get) Token: 0x060373F2 RID: 226290 RVA: 0x00760C48 File Offset: 0x0075EE48
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

		// Token: 0x060373F3 RID: 226291 RVA: 0x00760C7F File Offset: 0x0075EE7F
		public Span<byte> GetImageAssetMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060373F4 RID: 226292 RVA: 0x00760C8E File Offset: 0x0075EE8E
		public byte[] GetImageAssetMaleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E599 RID: 58777
		// (get) Token: 0x060373F5 RID: 226293 RVA: 0x00760C9C File Offset: 0x0075EE9C
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

		// Token: 0x060373F6 RID: 226294 RVA: 0x00760CD3 File Offset: 0x0075EED3
		public Span<byte> GetImageAssetFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060373F7 RID: 226295 RVA: 0x00760CE2 File Offset: 0x0075EEE2
		public byte[] GetImageAssetFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060373F8 RID: 226296 RVA: 0x00760CF0 File Offset: 0x0075EEF0
		public static Offset<ITalkBackgroundImageByMcGender> CreateITalkBackgroundImageByMcGender(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, StringOffset ImageAssetMaleOffset = default(StringOffset), StringOffset ImageAssetFemaleOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITalkBackgroundImageByMcGender.AddImageAssetFemale(builder, ImageAssetFemaleOffset);
			ITalkBackgroundImageByMcGender.AddImageAssetMale(builder, ImageAssetMaleOffset);
			ITalkBackgroundImageByMcGender.AddType(builder, Type);
			return ITalkBackgroundImageByMcGender.EndITalkBackgroundImageByMcGender(builder);
		}

		// Token: 0x060373F9 RID: 226297 RVA: 0x00760D14 File Offset: 0x0075EF14
		public static void StartITalkBackgroundImageByMcGender(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060373FA RID: 226298 RVA: 0x00760D1D File Offset: 0x0075EF1D
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060373FB RID: 226299 RVA: 0x00760D28 File Offset: 0x0075EF28
		public static void AddImageAssetMale(FlatBufferBuilder builder, StringOffset imageAssetMaleOffset)
		{
			builder.AddOffset(1, imageAssetMaleOffset.Value, 0);
		}

		// Token: 0x060373FC RID: 226300 RVA: 0x00760D38 File Offset: 0x0075EF38
		public static void AddImageAssetFemale(FlatBufferBuilder builder, StringOffset imageAssetFemaleOffset)
		{
			builder.AddOffset(2, imageAssetFemaleOffset.Value, 0);
		}

		// Token: 0x060373FD RID: 226301 RVA: 0x00760D48 File Offset: 0x0075EF48
		public static Offset<ITalkBackgroundImageByMcGender> EndITalkBackgroundImageByMcGender(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundImageByMcGender>(builder.EndTable());
		}

		// Token: 0x060373FE RID: 226302 RVA: 0x00760D58 File Offset: 0x0075EF58
		public ITalkBackgroundImageByMcGenderT UnPack()
		{
			ITalkBackgroundImageByMcGenderT talkBackgroundImageByMcGenderT = new ITalkBackgroundImageByMcGenderT();
			this.UnPackTo(talkBackgroundImageByMcGenderT);
			return talkBackgroundImageByMcGenderT;
		}

		// Token: 0x060373FF RID: 226303 RVA: 0x00760D73 File Offset: 0x0075EF73
		public void UnPackTo(ITalkBackgroundImageByMcGenderT _o)
		{
			_o.Type = this.Type;
			_o.ImageAssetMale = this.ImageAssetMale;
			_o.ImageAssetFemale = this.ImageAssetFemale;
		}

		// Token: 0x06037400 RID: 226304 RVA: 0x00760D9C File Offset: 0x0075EF9C
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

		// Token: 0x04012DAB RID: 77227
		private Table __p;
	}
}
