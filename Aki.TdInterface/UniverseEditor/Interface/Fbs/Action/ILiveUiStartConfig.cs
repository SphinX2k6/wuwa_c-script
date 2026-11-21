using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714E RID: 29006
	public struct ILiveUiStartConfig : IFlatbufferObject
	{
		// Token: 0x1700D449 RID: 54345
		// (get) Token: 0x06032634 RID: 206388 RVA: 0x006CFAF5 File Offset: 0x006CDCF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032635 RID: 206389 RVA: 0x006CFB02 File Offset: 0x006CDD02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032636 RID: 206390 RVA: 0x006CFB0C File Offset: 0x006CDD0C
		public static ILiveUiStartConfig GetRootAsILiveUiStartConfig(ByteBuffer _bb)
		{
			return ILiveUiStartConfig.GetRootAsILiveUiStartConfig(_bb, default(ILiveUiStartConfig));
		}

		// Token: 0x06032637 RID: 206391 RVA: 0x006CFB28 File Offset: 0x006CDD28
		public static ILiveUiStartConfig GetRootAsILiveUiStartConfig(ByteBuffer _bb, ILiveUiStartConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032638 RID: 206392 RVA: 0x006CFB45 File Offset: 0x006CDD45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032639 RID: 206393 RVA: 0x006CFB54 File Offset: 0x006CDD54
		public ILiveUiStartConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D44A RID: 54346
		// (get) Token: 0x0603263A RID: 206394 RVA: 0x006CFB64 File Offset: 0x006CDD64
		public ELiveUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveUiType.Start;
				}
				return (ELiveUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603263B RID: 206395 RVA: 0x006CFBA0 File Offset: 0x006CDDA0
		public static Offset<ILiveUiStartConfig> CreateILiveUiStartConfig(FlatBufferBuilder builder, ELiveUiType Type = ELiveUiType.Start)
		{
			builder.StartTable(1);
			ILiveUiStartConfig.AddType(builder, Type);
			return ILiveUiStartConfig.EndILiveUiStartConfig(builder);
		}

		// Token: 0x0603263C RID: 206396 RVA: 0x006CFBB6 File Offset: 0x006CDDB6
		public static void StartILiveUiStartConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603263D RID: 206397 RVA: 0x006CFBBF File Offset: 0x006CDDBF
		public static void AddType(FlatBufferBuilder builder, ELiveUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603263E RID: 206398 RVA: 0x006CFBCA File Offset: 0x006CDDCA
		public static Offset<ILiveUiStartConfig> EndILiveUiStartConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUiStartConfig>(builder.EndTable());
		}

		// Token: 0x0603263F RID: 206399 RVA: 0x006CFBD8 File Offset: 0x006CDDD8
		public ILiveUiStartConfigT UnPack()
		{
			ILiveUiStartConfigT liveUiStartConfigT = new ILiveUiStartConfigT();
			this.UnPackTo(liveUiStartConfigT);
			return liveUiStartConfigT;
		}

		// Token: 0x06032640 RID: 206400 RVA: 0x006CFBF3 File Offset: 0x006CDDF3
		public void UnPackTo(ILiveUiStartConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032641 RID: 206401 RVA: 0x006CFC04 File Offset: 0x006CDE04
		public static Offset<ILiveUiStartConfig> Pack(FlatBufferBuilder builder, ILiveUiStartConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUiStartConfig>);
			}
			return ILiveUiStartConfig.CreateILiveUiStartConfig(builder, _o.Type);
		}

		// Token: 0x04012135 RID: 74037
		private Table __p;
	}
}
