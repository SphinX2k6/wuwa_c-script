using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7B RID: 27771
	public struct IPerformerAiMoveConfig : IFlatbufferObject
	{
		// Token: 0x1700CED6 RID: 52950
		// (get) Token: 0x06030EFA RID: 200442 RVA: 0x006A5176 File Offset: 0x006A3376
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030EFB RID: 200443 RVA: 0x006A5183 File Offset: 0x006A3383
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030EFC RID: 200444 RVA: 0x006A518C File Offset: 0x006A338C
		public static IPerformerAiMoveConfig GetRootAsIPerformerAiMoveConfig(ByteBuffer _bb)
		{
			return IPerformerAiMoveConfig.GetRootAsIPerformerAiMoveConfig(_bb, default(IPerformerAiMoveConfig));
		}

		// Token: 0x06030EFD RID: 200445 RVA: 0x006A51A8 File Offset: 0x006A33A8
		public static IPerformerAiMoveConfig GetRootAsIPerformerAiMoveConfig(ByteBuffer _bb, IPerformerAiMoveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030EFE RID: 200446 RVA: 0x006A51C5 File Offset: 0x006A33C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030EFF RID: 200447 RVA: 0x006A51D4 File Offset: 0x006A33D4
		public IPerformerAiMoveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CED7 RID: 52951
		// (get) Token: 0x06030F00 RID: 200448 RVA: 0x006A51E4 File Offset: 0x006A33E4
		public EPerformerAiMoveToType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformerAiMoveToType.Position;
				}
				return (EPerformerAiMoveToType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F01 RID: 200449 RVA: 0x006A5220 File Offset: 0x006A3420
		public static Offset<IPerformerAiMoveConfig> CreateIPerformerAiMoveConfig(FlatBufferBuilder builder, EPerformerAiMoveToType Type = EPerformerAiMoveToType.Position)
		{
			builder.StartTable(1);
			IPerformerAiMoveConfig.AddType(builder, Type);
			return IPerformerAiMoveConfig.EndIPerformerAiMoveConfig(builder);
		}

		// Token: 0x06030F02 RID: 200450 RVA: 0x006A5236 File Offset: 0x006A3436
		public static void StartIPerformerAiMoveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030F03 RID: 200451 RVA: 0x006A523F File Offset: 0x006A343F
		public static void AddType(FlatBufferBuilder builder, EPerformerAiMoveToType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030F04 RID: 200452 RVA: 0x006A524A File Offset: 0x006A344A
		public static Offset<IPerformerAiMoveConfig> EndIPerformerAiMoveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiMoveConfig>(builder.EndTable());
		}

		// Token: 0x06030F05 RID: 200453 RVA: 0x006A5258 File Offset: 0x006A3458
		public IPerformerAiMoveConfigT UnPack()
		{
			IPerformerAiMoveConfigT performerAiMoveConfigT = new IPerformerAiMoveConfigT();
			this.UnPackTo(performerAiMoveConfigT);
			return performerAiMoveConfigT;
		}

		// Token: 0x06030F06 RID: 200454 RVA: 0x006A5273 File Offset: 0x006A3473
		public void UnPackTo(IPerformerAiMoveConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030F07 RID: 200455 RVA: 0x006A5284 File Offset: 0x006A3484
		public static Offset<IPerformerAiMoveConfig> Pack(FlatBufferBuilder builder, IPerformerAiMoveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiMoveConfig>);
			}
			return IPerformerAiMoveConfig.CreateIPerformerAiMoveConfig(builder, _o.Type);
		}

		// Token: 0x040115CB RID: 71115
		private Table __p;
	}
}
