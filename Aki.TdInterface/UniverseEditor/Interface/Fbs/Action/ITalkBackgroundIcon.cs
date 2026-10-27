using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007298 RID: 29336
	public struct ITalkBackgroundIcon : IFlatbufferObject
	{
		// Token: 0x1700D993 RID: 55699
		// (get) Token: 0x060340B7 RID: 213175 RVA: 0x006FF399 File Offset: 0x006FD599
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060340B8 RID: 213176 RVA: 0x006FF3A6 File Offset: 0x006FD5A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060340B9 RID: 213177 RVA: 0x006FF3B0 File Offset: 0x006FD5B0
		public static ITalkBackgroundIcon GetRootAsITalkBackgroundIcon(ByteBuffer _bb)
		{
			return ITalkBackgroundIcon.GetRootAsITalkBackgroundIcon(_bb, default(ITalkBackgroundIcon));
		}

		// Token: 0x060340BA RID: 213178 RVA: 0x006FF3CC File Offset: 0x006FD5CC
		public static ITalkBackgroundIcon GetRootAsITalkBackgroundIcon(ByteBuffer _bb, ITalkBackgroundIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060340BB RID: 213179 RVA: 0x006FF3E9 File Offset: 0x006FD5E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060340BC RID: 213180 RVA: 0x006FF3F8 File Offset: 0x006FD5F8
		public ITalkBackgroundIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D994 RID: 55700
		// (get) Token: 0x060340BD RID: 213181 RVA: 0x006FF408 File Offset: 0x006FD608
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

		// Token: 0x1700D995 RID: 55701
		// (get) Token: 0x060340BE RID: 213182 RVA: 0x006FF444 File Offset: 0x006FD644
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

		// Token: 0x060340BF RID: 213183 RVA: 0x006FF47B File Offset: 0x006FD67B
		public Span<byte> GetImageAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060340C0 RID: 213184 RVA: 0x006FF48A File Offset: 0x006FD68A
		public byte[] GetImageAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060340C1 RID: 213185 RVA: 0x006FF498 File Offset: 0x006FD698
		public static Offset<ITalkBackgroundIcon> CreateITalkBackgroundIcon(FlatBufferBuilder builder, ETalkBackgroundType Type = ETalkBackgroundType.Clean, StringOffset ImageAssetOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITalkBackgroundIcon.AddImageAsset(builder, ImageAssetOffset);
			ITalkBackgroundIcon.AddType(builder, Type);
			return ITalkBackgroundIcon.EndITalkBackgroundIcon(builder);
		}

		// Token: 0x060340C2 RID: 213186 RVA: 0x006FF4B5 File Offset: 0x006FD6B5
		public static void StartITalkBackgroundIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060340C3 RID: 213187 RVA: 0x006FF4BE File Offset: 0x006FD6BE
		public static void AddType(FlatBufferBuilder builder, ETalkBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060340C4 RID: 213188 RVA: 0x006FF4C9 File Offset: 0x006FD6C9
		public static void AddImageAsset(FlatBufferBuilder builder, StringOffset imageAssetOffset)
		{
			builder.AddOffset(1, imageAssetOffset.Value, 0);
		}

		// Token: 0x060340C5 RID: 213189 RVA: 0x006FF4D9 File Offset: 0x006FD6D9
		public static Offset<ITalkBackgroundIcon> EndITalkBackgroundIcon(FlatBufferBuilder builder)
		{
			return new Offset<ITalkBackgroundIcon>(builder.EndTable());
		}

		// Token: 0x060340C6 RID: 213190 RVA: 0x006FF4E8 File Offset: 0x006FD6E8
		public ITalkBackgroundIconT UnPack()
		{
			ITalkBackgroundIconT talkBackgroundIconT = new ITalkBackgroundIconT();
			this.UnPackTo(talkBackgroundIconT);
			return talkBackgroundIconT;
		}

		// Token: 0x060340C7 RID: 213191 RVA: 0x006FF503 File Offset: 0x006FD703
		public void UnPackTo(ITalkBackgroundIconT _o)
		{
			_o.Type = this.Type;
			_o.ImageAsset = this.ImageAsset;
		}

		// Token: 0x060340C8 RID: 213192 RVA: 0x006FF520 File Offset: 0x006FD720
		public static Offset<ITalkBackgroundIcon> Pack(FlatBufferBuilder builder, ITalkBackgroundIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkBackgroundIcon>);
			}
			StringOffset imageAssetOffset = (_o.ImageAsset == null) ? default(StringOffset) : builder.CreateString(_o.ImageAsset);
			return ITalkBackgroundIcon.CreateITalkBackgroundIcon(builder, _o.Type, imageAssetOffset);
		}

		// Token: 0x04011DA2 RID: 73122
		private Table __p;
	}
}
