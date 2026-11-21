using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007001 RID: 28673
	public struct IInfrActivityInfrastructureStage : IFlatbufferObject
	{
		// Token: 0x1700D1FC RID: 53756
		// (get) Token: 0x06031AE8 RID: 203496 RVA: 0x006BA910 File Offset: 0x006B8B10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031AE9 RID: 203497 RVA: 0x006BA91D File Offset: 0x006B8B1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031AEA RID: 203498 RVA: 0x006BA924 File Offset: 0x006B8B24
		public static IInfrActivityInfrastructureStage GetRootAsIInfrActivityInfrastructureStage(ByteBuffer _bb)
		{
			return IInfrActivityInfrastructureStage.GetRootAsIInfrActivityInfrastructureStage(_bb, default(IInfrActivityInfrastructureStage));
		}

		// Token: 0x06031AEB RID: 203499 RVA: 0x006BA940 File Offset: 0x006B8B40
		public static IInfrActivityInfrastructureStage GetRootAsIInfrActivityInfrastructureStage(ByteBuffer _bb, IInfrActivityInfrastructureStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031AEC RID: 203500 RVA: 0x006BA95D File Offset: 0x006B8B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031AED RID: 203501 RVA: 0x006BA96C File Offset: 0x006B8B6C
		public IInfrActivityInfrastructureStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D1FD RID: 53757
		// (get) Token: 0x06031AEE RID: 203502 RVA: 0x006BA97C File Offset: 0x006B8B7C
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

		// Token: 0x1700D1FE RID: 53758
		// (get) Token: 0x06031AEF RID: 203503 RVA: 0x006BA9B8 File Offset: 0x006B8BB8
		public int Stage
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

		// Token: 0x06031AF0 RID: 203504 RVA: 0x006BA9F4 File Offset: 0x006B8BF4
		public static Offset<IInfrActivityInfrastructureStage> CreateIInfrActivityInfrastructureStage(FlatBufferBuilder builder, EInfrActivityBuildStageType Type = EInfrActivityBuildStageType.Infrastructure, int Stage = 0)
		{
			builder.StartTable(2);
			IInfrActivityInfrastructureStage.AddStage(builder, Stage);
			IInfrActivityInfrastructureStage.AddType(builder, Type);
			return IInfrActivityInfrastructureStage.EndIInfrActivityInfrastructureStage(builder);
		}

		// Token: 0x06031AF1 RID: 203505 RVA: 0x006BAA11 File Offset: 0x006B8C11
		public static void StartIInfrActivityInfrastructureStage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031AF2 RID: 203506 RVA: 0x006BAA1A File Offset: 0x006B8C1A
		public static void AddType(FlatBufferBuilder builder, EInfrActivityBuildStageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031AF3 RID: 203507 RVA: 0x006BAA25 File Offset: 0x006B8C25
		public static void AddStage(FlatBufferBuilder builder, int stage)
		{
			builder.AddInt(1, stage, 0);
		}

		// Token: 0x06031AF4 RID: 203508 RVA: 0x006BAA30 File Offset: 0x006B8C30
		public static Offset<IInfrActivityInfrastructureStage> EndIInfrActivityInfrastructureStage(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityInfrastructureStage>(builder.EndTable());
		}

		// Token: 0x06031AF5 RID: 203509 RVA: 0x006BAA40 File Offset: 0x006B8C40
		public IInfrActivityInfrastructureStageT UnPack()
		{
			IInfrActivityInfrastructureStageT infrActivityInfrastructureStageT = new IInfrActivityInfrastructureStageT();
			this.UnPackTo(infrActivityInfrastructureStageT);
			return infrActivityInfrastructureStageT;
		}

		// Token: 0x06031AF6 RID: 203510 RVA: 0x006BAA5B File Offset: 0x006B8C5B
		public void UnPackTo(IInfrActivityInfrastructureStageT _o)
		{
			_o.Type = this.Type;
			_o.Stage = this.Stage;
		}

		// Token: 0x06031AF7 RID: 203511 RVA: 0x006BAA78 File Offset: 0x006B8C78
		public static Offset<IInfrActivityInfrastructureStage> Pack(FlatBufferBuilder builder, IInfrActivityInfrastructureStageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityInfrastructureStage>);
			}
			return IInfrActivityInfrastructureStage.CreateIInfrActivityInfrastructureStage(builder, _o.Type, _o.Stage);
		}

		// Token: 0x04011F3B RID: 73531
		private Table __p;
	}
}
