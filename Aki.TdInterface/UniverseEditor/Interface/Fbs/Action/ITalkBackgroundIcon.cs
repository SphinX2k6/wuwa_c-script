using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A6D RID: 31341
	public struct ITalkBackgroundIcon : IFlatbufferObject
	{
		// Token: 0x1700E58C RID: 58764
		// (get) Token: 0x060373BB RID: 226235 RVA: 0x00760735 File Offset: 0x0075E935
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060373BC RID: 226236 RVA: 0x00760742 File Offset: 0x0075E942
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060373BD RID: 226237 RVA: 0x0076074C File Offset: 0x0075E94C
		public static ITalkBackgroundIcon GetRootAsITalkBackgroundIcon(ByteBuffer _bb)
		{
			return ITalkBackgroundIcon.GetRootAsITalkBackgroundIcon(_bb, default(ITalkBackgroundIcon));
		}

		// Token: 0x060373BE RID: 226238 RVA: 0x00760768 File Offset: 0x0075E968
		public static ITalkBackgroundIcon GetRootAsITalkBackgroundIcon(ByteBuffer _bb, ITalkBackgroundIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060373BF RID: 226239 RVA: 0x00760785 File Offset: 0x0075E985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060373C0 RID: 226240 RVA: 0x00760794 File Offset: 0x0075E994
		public ITalkBackgroundIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E58D RID: 58765
		// (get) Token: 0x060373C1 RID: 226241 RVA: 0x007607A4 File Offset: 0x0075E9A4
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

		// Token: 0x1700E58E RID: 58766
		// (get) Token: 0x060373C2 RID: 226242 RVA: 0x007607E0 File Offset: 0x0075E9E0
		public string ImageAsset
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

		// Token: 0x060373C3 RID: 226243 RVA: 0x00760817 File Offset: 0x0075EA17
		public Span<byte> GetImageAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060373C4 RID: 226244 RVA: 0x00760826 File Offset: 0x0075EA26
		public byte[] GetImageAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060373C5 RID: 226245 RVA: 0x00760834 File Offset: 0x0075EA34
		public static Offset<ITalkBackgroundIcon> CreateITalkBackgroundIcon(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, StringOffset ImageAssetOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITalkBackgroundIcon.AddImageAsset(builder, ImageAssetOffset);
			ITalkBackgroundIcon.AddType(builder, Type);
			return ITalkBackgroundIcon.EndITalkBackgroundIcon(builder);
		}

		// Token: 0x060373C6 RID: 226246 RVA: 0x00760851 File Offset: 0x0075EA51
		public static void StartITalkBackgroundIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060373C7 RID: 226247 RVA: 0x0076085A File Offset: 0x0075EA5A
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060373C8 RID: 226248 RVA: 0x00760865 File Offset: 0x0075EA65
		public static void AddImageAsset(FlatBufferBuilder builder, StringOffset imageAssetOffset)
		{
			builder.AddOffset(1, imageAssetOffset.Value, 0);
		}

		// Token: 0x060373C9 RID: 226249 RVA: 0x00760875 File Offset: 0x0075EA75
		public static Offset<ITalkBackgroundIcon> EndITalkBackgroundIcon(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundIcon>(builder.EndTable());
		}

		// Token: 0x060373CA RID: 226250 RVA: 0x00760884 File Offset: 0x0075EA84
		public ITalkBackgroundIconT UnPack()
		{
			ITalkBackgroundIconT talkBackgroundIconT = new ITalkBackgroundIconT();
			this.UnPackTo(talkBackgroundIconT);
			return talkBackgroundIconT;
		}

		// Token: 0x060373CB RID: 226251 RVA: 0x0076089F File Offset: 0x0075EA9F
		public void UnPackTo(ITalkBackgroundIconT _o)
		{
			_o.Type = this.Type;
			_o.ImageAsset = this.ImageAsset;
		}

		// Token: 0x060373CC RID: 226252 RVA: 0x007608BC File Offset: 0x0075EABC
		public static Offset<ITalkBackgroundIcon> Pack(FlatBufferBuilder builder, ITalkBackgroundIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundIcon>);
			}
			StringOffset imageAssetOffset = (_o.ImageAsset == null) ? default(StringOffset) : builder.CreateString(_o.ImageAsset);
			return ITalkBackgroundIcon.CreateITalkBackgroundIcon(builder, _o.Type, imageAssetOffset);
		}

		// Token: 0x04012DA5 RID: 77221
		private Table __p;
	}
}
