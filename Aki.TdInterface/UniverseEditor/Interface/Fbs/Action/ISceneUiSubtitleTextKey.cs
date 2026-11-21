using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FF RID: 30463
	public struct ISceneUiSubtitleTextKey : IFlatbufferObject
	{
		// Token: 0x1700DF6E RID: 57198
		// (get) Token: 0x06035731 RID: 218929 RVA: 0x0072AF8C File Offset: 0x0072918C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035732 RID: 218930 RVA: 0x0072AF99 File Offset: 0x00729199
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035733 RID: 218931 RVA: 0x0072AFA0 File Offset: 0x007291A0
		public static ISceneUiSubtitleTextKey GetRootAsISceneUiSubtitleTextKey(ByteBuffer _bb)
		{
			return ISceneUiSubtitleTextKey.GetRootAsISceneUiSubtitleTextKey(_bb, default(ISceneUiSubtitleTextKey));
		}

		// Token: 0x06035734 RID: 218932 RVA: 0x0072AFBC File Offset: 0x007291BC
		public static ISceneUiSubtitleTextKey GetRootAsISceneUiSubtitleTextKey(ByteBuffer _bb, ISceneUiSubtitleTextKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035735 RID: 218933 RVA: 0x0072AFD9 File Offset: 0x007291D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035736 RID: 218934 RVA: 0x0072AFE8 File Offset: 0x007291E8
		public ISceneUiSubtitleTextKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF6F RID: 57199
		// (get) Token: 0x06035737 RID: 218935 RVA: 0x0072AFF8 File Offset: 0x007291F8
		public ESceneUiSubtitleTextType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneUiSubtitleTextType.Flow;
				}
				return (ESceneUiSubtitleTextType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF70 RID: 57200
		// (get) Token: 0x06035738 RID: 218936 RVA: 0x0072B034 File Offset: 0x00729234
		public string TextKey
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

		// Token: 0x06035739 RID: 218937 RVA: 0x0072B06B File Offset: 0x0072926B
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603573A RID: 218938 RVA: 0x0072B07A File Offset: 0x0072927A
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603573B RID: 218939 RVA: 0x0072B088 File Offset: 0x00729288
		public static Offset<ISceneUiSubtitleTextKey> CreateISceneUiSubtitleTextKey(FlatBufferBuilder builder, ESceneUiSubtitleTextType Type = ESceneUiSubtitleTextType.Flow, StringOffset TextKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISceneUiSubtitleTextKey.AddTextKey(builder, TextKeyOffset);
			ISceneUiSubtitleTextKey.AddType(builder, Type);
			return ISceneUiSubtitleTextKey.EndISceneUiSubtitleTextKey(builder);
		}

		// Token: 0x0603573C RID: 218940 RVA: 0x0072B0A5 File Offset: 0x007292A5
		public static void StartISceneUiSubtitleTextKey(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603573D RID: 218941 RVA: 0x0072B0AE File Offset: 0x007292AE
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleTextType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603573E RID: 218942 RVA: 0x0072B0B9 File Offset: 0x007292B9
		public static void AddTextKey(FlatBufferBuilder builder, StringOffset textKeyOffset)
		{
			builder.AddOffset(1, textKeyOffset.Value, 0);
		}

		// Token: 0x0603573F RID: 218943 RVA: 0x0072B0C9 File Offset: 0x007292C9
		public static Offset<ISceneUiSubtitleTextKey> EndISceneUiSubtitleTextKey(FlatBufferBuilder builder)
		{
			return new Offset<ISceneUiSubtitleTextKey>(builder.EndTable());
		}

		// Token: 0x06035740 RID: 218944 RVA: 0x0072B0D8 File Offset: 0x007292D8
		public ISceneUiSubtitleTextKeyT UnPack()
		{
			ISceneUiSubtitleTextKeyT sceneUiSubtitleTextKeyT = new ISceneUiSubtitleTextKeyT();
			this.UnPackTo(sceneUiSubtitleTextKeyT);
			return sceneUiSubtitleTextKeyT;
		}

		// Token: 0x06035741 RID: 218945 RVA: 0x0072B0F3 File Offset: 0x007292F3
		public void UnPackTo(ISceneUiSubtitleTextKeyT _o)
		{
			_o.Type = this.Type;
			_o.TextKey = this.TextKey;
		}

		// Token: 0x06035742 RID: 218946 RVA: 0x0072B110 File Offset: 0x00729310
		public static Offset<ISceneUiSubtitleTextKey> Pack(FlatBufferBuilder builder, ISceneUiSubtitleTextKeyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneUiSubtitleTextKey>);
			}
			StringOffset textKeyOffset = (_o.TextKey == null) ? default(StringOffset) : builder.CreateString(_o.TextKey);
			return ISceneUiSubtitleTextKey.CreateISceneUiSubtitleTextKey(builder, _o.Type, textKeyOffset);
		}

		// Token: 0x04012914 RID: 76052
		private Table __p;
	}
}
