using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E2 RID: 28898
	public struct ILiveClearScConfig : IFlatbufferObject
	{
		// Token: 0x1700D3A6 RID: 54182
		// (get) Token: 0x060322F6 RID: 205558 RVA: 0x006CA108 File Offset: 0x006C8308
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060322F7 RID: 205559 RVA: 0x006CA115 File Offset: 0x006C8315
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060322F8 RID: 205560 RVA: 0x006CA11C File Offset: 0x006C831C
		public static ILiveClearScConfig GetRootAsILiveClearScConfig(ByteBuffer _bb)
		{
			return ILiveClearScConfig.GetRootAsILiveClearScConfig(_bb, default(ILiveClearScConfig));
		}

		// Token: 0x060322F9 RID: 205561 RVA: 0x006CA138 File Offset: 0x006C8338
		public static ILiveClearScConfig GetRootAsILiveClearScConfig(ByteBuffer _bb, ILiveClearScConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060322FA RID: 205562 RVA: 0x006CA155 File Offset: 0x006C8355
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060322FB RID: 205563 RVA: 0x006CA164 File Offset: 0x006C8364
		public ILiveClearScConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3A7 RID: 54183
		// (get) Token: 0x060322FC RID: 205564 RVA: 0x006CA174 File Offset: 0x006C8374
		public ELiveScOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELiveScOperationType.Send;
				}
				return (ELiveScOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060322FD RID: 205565 RVA: 0x006CA1B0 File Offset: 0x006C83B0
		public static Offset<ILiveClearScConfig> CreateILiveClearScConfig(FlatBufferBuilder builder, ELiveScOperationType Type = ELiveScOperationType.Send)
		{
			builder.StartTable(1);
			ILiveClearScConfig.AddType(builder, Type);
			return ILiveClearScConfig.EndILiveClearScConfig(builder);
		}

		// Token: 0x060322FE RID: 205566 RVA: 0x006CA1C6 File Offset: 0x006C83C6
		public static void StartILiveClearScConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060322FF RID: 205567 RVA: 0x006CA1CF File Offset: 0x006C83CF
		public static void AddType(FlatBufferBuilder builder, ELiveScOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032300 RID: 205568 RVA: 0x006CA1DA File Offset: 0x006C83DA
		public static Offset<ILiveClearScConfig> EndILiveClearScConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILiveClearScConfig>(builder.EndTable());
		}

		// Token: 0x06032301 RID: 205569 RVA: 0x006CA1E8 File Offset: 0x006C83E8
		public ILiveClearScConfigT UnPack()
		{
			ILiveClearScConfigT liveClearScConfigT = new ILiveClearScConfigT();
			this.UnPackTo(liveClearScConfigT);
			return liveClearScConfigT;
		}

		// Token: 0x06032302 RID: 205570 RVA: 0x006CA203 File Offset: 0x006C8403
		public void UnPackTo(ILiveClearScConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032303 RID: 205571 RVA: 0x006CA214 File Offset: 0x006C8414
		public static Offset<ILiveClearScConfig> Pack(FlatBufferBuilder builder, ILiveClearScConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveClearScConfig>);
			}
			return ILiveClearScConfig.CreateILiveClearScConfig(builder, _o.Type);
		}

		// Token: 0x040120AC RID: 73900
		private Table __p;
	}
}
