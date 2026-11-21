using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007004 RID: 28676
	public struct IInfrActivityRoadProcess : IFlatbufferObject
	{
		// Token: 0x1700D201 RID: 53761
		// (get) Token: 0x06031AFE RID: 203518 RVA: 0x006BAB0E File Offset: 0x006B8D0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031AFF RID: 203519 RVA: 0x006BAB1B File Offset: 0x006B8D1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B00 RID: 203520 RVA: 0x006BAB24 File Offset: 0x006B8D24
		public static IInfrActivityRoadProcess GetRootAsIInfrActivityRoadProcess(ByteBuffer _bb)
		{
			return IInfrActivityRoadProcess.GetRootAsIInfrActivityRoadProcess(_bb, default(IInfrActivityRoadProcess));
		}

		// Token: 0x06031B01 RID: 203521 RVA: 0x006BAB40 File Offset: 0x006B8D40
		public static IInfrActivityRoadProcess GetRootAsIInfrActivityRoadProcess(ByteBuffer _bb, IInfrActivityRoadProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B02 RID: 203522 RVA: 0x006BAB5D File Offset: 0x006B8D5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B03 RID: 203523 RVA: 0x006BAB6C File Offset: 0x006B8D6C
		public IInfrActivityRoadProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D202 RID: 53762
		// (get) Token: 0x06031B04 RID: 203524 RVA: 0x006BAB7C File Offset: 0x006B8D7C
		public EInfrActivityBuildStageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return (EInfrActivityBuildStageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D203 RID: 53763
		// (get) Token: 0x06031B05 RID: 203525 RVA: 0x006BABB8 File Offset: 0x006B8DB8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031B06 RID: 203526 RVA: 0x006BABF4 File Offset: 0x006B8DF4
		public static Offset<IInfrActivityRoadProcess> CreateIInfrActivityRoadProcess(FlatBufferBuilder builder, EInfrActivityBuildStageType Type = EInfrActivityBuildStageType.Infrastructure, int Id = 0)
		{
			builder.StartTable(2);
			IInfrActivityRoadProcess.AddId(builder, Id);
			IInfrActivityRoadProcess.AddType(builder, Type);
			return IInfrActivityRoadProcess.EndIInfrActivityRoadProcess(builder);
		}

		// Token: 0x06031B07 RID: 203527 RVA: 0x006BAC11 File Offset: 0x006B8E11
		public static void StartIInfrActivityRoadProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031B08 RID: 203528 RVA: 0x006BAC1A File Offset: 0x006B8E1A
		public static void AddType(FlatBufferBuilder builder, EInfrActivityBuildStageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031B09 RID: 203529 RVA: 0x006BAC25 File Offset: 0x006B8E25
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06031B0A RID: 203530 RVA: 0x006BAC30 File Offset: 0x006B8E30
		public static Offset<IInfrActivityRoadProcess> EndIInfrActivityRoadProcess(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityRoadProcess>(builder.EndTable());
		}

		// Token: 0x06031B0B RID: 203531 RVA: 0x006BAC40 File Offset: 0x006B8E40
		public IInfrActivityRoadProcessT UnPack()
		{
			IInfrActivityRoadProcessT infrActivityRoadProcessT = new IInfrActivityRoadProcessT();
			this.UnPackTo(infrActivityRoadProcessT);
			return infrActivityRoadProcessT;
		}

		// Token: 0x06031B0C RID: 203532 RVA: 0x006BAC5B File Offset: 0x006B8E5B
		public void UnPackTo(IInfrActivityRoadProcessT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06031B0D RID: 203533 RVA: 0x006BAC78 File Offset: 0x006B8E78
		public static Offset<IInfrActivityRoadProcess> Pack(FlatBufferBuilder builder, IInfrActivityRoadProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityRoadProcess>);
			}
			return IInfrActivityRoadProcess.CreateIInfrActivityRoadProcess(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011F3E RID: 73534
		private Table __p;
	}
}
