using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EB RID: 30187
	public struct IRemoveSceneUiSubtitle : IFlatbufferObject
	{
		// Token: 0x1700DDD9 RID: 56793
		// (get) Token: 0x06034F56 RID: 216918 RVA: 0x0071D8C7 File Offset: 0x0071BAC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034F57 RID: 216919 RVA: 0x0071D8D4 File Offset: 0x0071BAD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034F58 RID: 216920 RVA: 0x0071D8DC File Offset: 0x0071BADC
		public static IRemoveSceneUiSubtitle GetRootAsIRemoveSceneUiSubtitle(ByteBuffer _bb)
		{
			return IRemoveSceneUiSubtitle.GetRootAsIRemoveSceneUiSubtitle(_bb, default(IRemoveSceneUiSubtitle));
		}

		// Token: 0x06034F59 RID: 216921 RVA: 0x0071D8F8 File Offset: 0x0071BAF8
		public static IRemoveSceneUiSubtitle GetRootAsIRemoveSceneUiSubtitle(ByteBuffer _bb, IRemoveSceneUiSubtitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034F5A RID: 216922 RVA: 0x0071D915 File Offset: 0x0071BB15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034F5B RID: 216923 RVA: 0x0071D924 File Offset: 0x0071BB24
		public IRemoveSceneUiSubtitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDDA RID: 56794
		// (get) Token: 0x06034F5C RID: 216924 RVA: 0x0071D934 File Offset: 0x0071BB34
		public ESceneUiSubtitleOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneUiSubtitleOperationType.Spawn;
				}
				return (ESceneUiSubtitleOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DDDB RID: 56795
		// (get) Token: 0x06034F5D RID: 216925 RVA: 0x0071D970 File Offset: 0x0071BB70
		public string Mark
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

		// Token: 0x06034F5E RID: 216926 RVA: 0x0071D9A7 File Offset: 0x0071BBA7
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06034F5F RID: 216927 RVA: 0x0071D9B6 File Offset: 0x0071BBB6
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06034F60 RID: 216928 RVA: 0x0071D9C4 File Offset: 0x0071BBC4
		public static Offset<IRemoveSceneUiSubtitle> CreateIRemoveSceneUiSubtitle(FlatBufferBuilder builder, ESceneUiSubtitleOperationType Type = ESceneUiSubtitleOperationType.Spawn, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRemoveSceneUiSubtitle.AddMark(builder, MarkOffset);
			IRemoveSceneUiSubtitle.AddType(builder, Type);
			return IRemoveSceneUiSubtitle.EndIRemoveSceneUiSubtitle(builder);
		}

		// Token: 0x06034F61 RID: 216929 RVA: 0x0071D9E1 File Offset: 0x0071BBE1
		public static void StartIRemoveSceneUiSubtitle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034F62 RID: 216930 RVA: 0x0071D9EA File Offset: 0x0071BBEA
		public static void AddType(FlatBufferBuilder builder, ESceneUiSubtitleOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034F63 RID: 216931 RVA: 0x0071D9F5 File Offset: 0x0071BBF5
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(1, markOffset.Value, 0);
		}

		// Token: 0x06034F64 RID: 216932 RVA: 0x0071DA05 File Offset: 0x0071BC05
		public static Offset<IRemoveSceneUiSubtitle> EndIRemoveSceneUiSubtitle(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveSceneUiSubtitle>(builder.EndTable());
		}

		// Token: 0x06034F65 RID: 216933 RVA: 0x0071DA14 File Offset: 0x0071BC14
		public IRemoveSceneUiSubtitleT UnPack()
		{
			IRemoveSceneUiSubtitleT removeSceneUiSubtitleT = new IRemoveSceneUiSubtitleT();
			this.UnPackTo(removeSceneUiSubtitleT);
			return removeSceneUiSubtitleT;
		}

		// Token: 0x06034F66 RID: 216934 RVA: 0x0071DA2F File Offset: 0x0071BC2F
		public void UnPackTo(IRemoveSceneUiSubtitleT _o)
		{
			_o.Type = this.Type;
			_o.Mark = this.Mark;
		}

		// Token: 0x06034F67 RID: 216935 RVA: 0x0071DA4C File Offset: 0x0071BC4C
		public static Offset<IRemoveSceneUiSubtitle> Pack(FlatBufferBuilder builder, IRemoveSceneUiSubtitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveSceneUiSubtitle>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return IRemoveSceneUiSubtitle.CreateIRemoveSceneUiSubtitle(builder, _o.Type, markOffset);
		}

		// Token: 0x040127D6 RID: 75734
		private Table __p;
	}
}
