using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714B RID: 29003
	public struct ILiveUiShowConfig : IFlatbufferObject
	{
		// Token: 0x1700D446 RID: 54342
		// (get) Token: 0x06032622 RID: 206370 RVA: 0x006CF97D File Offset: 0x006CDB7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032623 RID: 206371 RVA: 0x006CF98A File Offset: 0x006CDB8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032624 RID: 206372 RVA: 0x006CF994 File Offset: 0x006CDB94
		public static ILiveUiShowConfig GetRootAsILiveUiShowConfig(ByteBuffer _bb)
		{
			return ILiveUiShowConfig.GetRootAsILiveUiShowConfig(_bb, default(ILiveUiShowConfig));
		}

		// Token: 0x06032625 RID: 206373 RVA: 0x006CF9B0 File Offset: 0x006CDBB0
		public static ILiveUiShowConfig GetRootAsILiveUiShowConfig(ByteBuffer _bb, ILiveUiShowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032626 RID: 206374 RVA: 0x006CF9CD File Offset: 0x006CDBCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032627 RID: 206375 RVA: 0x006CF9DC File Offset: 0x006CDBDC
		public ILiveUiShowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D447 RID: 54343
		// (get) Token: 0x06032628 RID: 206376 RVA: 0x006CF9EC File Offset: 0x006CDBEC
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

		// Token: 0x06032629 RID: 206377 RVA: 0x006CFA28 File Offset: 0x006CDC28
		public static Offset<ILiveUiShowConfig> CreateILiveUiShowConfig(FlatBufferBuilder builder, ELiveUiType Type = ELiveUiType.Start)
		{
			builder.StartTable(1);
			ILiveUiShowConfig.AddType(builder, Type);
			return ILiveUiShowConfig.EndILiveUiShowConfig(builder);
		}

		// Token: 0x0603262A RID: 206378 RVA: 0x006CFA3E File Offset: 0x006CDC3E
		public static void StartILiveUiShowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603262B RID: 206379 RVA: 0x006CFA47 File Offset: 0x006CDC47
		public static void AddType(FlatBufferBuilder builder, ELiveUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603262C RID: 206380 RVA: 0x006CFA52 File Offset: 0x006CDC52
		public static Offset<ILiveUiShowConfig> EndILiveUiShowConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveUiShowConfig>(builder.EndTable());
		}

		// Token: 0x0603262D RID: 206381 RVA: 0x006CFA60 File Offset: 0x006CDC60
		public ILiveUiShowConfigT UnPack()
		{
			ILiveUiShowConfigT liveUiShowConfigT = new ILiveUiShowConfigT();
			this.UnPackTo(liveUiShowConfigT);
			return liveUiShowConfigT;
		}

		// Token: 0x0603262E RID: 206382 RVA: 0x006CFA7B File Offset: 0x006CDC7B
		public void UnPackTo(ILiveUiShowConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603262F RID: 206383 RVA: 0x006CFA8C File Offset: 0x006CDC8C
		public static Offset<ILiveUiShowConfig> Pack(FlatBufferBuilder builder, ILiveUiShowConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveUiShowConfig>);
			}
			return ILiveUiShowConfig.CreateILiveUiShowConfig(builder, _o.Type);
		}

		// Token: 0x04012133 RID: 74035
		private Table __p;
	}
}
