using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694E RID: 26958
	public struct IInfrActivityInfrastructureStage : IFlatbufferObject
	{
		// Token: 0x1700C7F9 RID: 51193
		// (get) Token: 0x0602F118 RID: 192792 RVA: 0x0066A428 File Offset: 0x00668628
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F119 RID: 192793 RVA: 0x0066A435 File Offset: 0x00668635
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F11A RID: 192794 RVA: 0x0066A43C File Offset: 0x0066863C
		public static IInfrActivityInfrastructureStage GetRootAsIInfrActivityInfrastructureStage(ByteBuffer _bb)
		{
			return IInfrActivityInfrastructureStage.GetRootAsIInfrActivityInfrastructureStage(_bb, default(IInfrActivityInfrastructureStage));
		}

		// Token: 0x0602F11B RID: 192795 RVA: 0x0066A458 File Offset: 0x00668658
		public static IInfrActivityInfrastructureStage GetRootAsIInfrActivityInfrastructureStage(ByteBuffer _bb, IInfrActivityInfrastructureStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F11C RID: 192796 RVA: 0x0066A475 File Offset: 0x00668675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F11D RID: 192797 RVA: 0x0066A484 File Offset: 0x00668684
		public IInfrActivityInfrastructureStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7FA RID: 51194
		// (get) Token: 0x0602F11E RID: 192798 RVA: 0x0066A494 File Offset: 0x00668694
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

		// Token: 0x1700C7FB RID: 51195
		// (get) Token: 0x0602F11F RID: 192799 RVA: 0x0066A4D0 File Offset: 0x006686D0
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

		// Token: 0x0602F120 RID: 192800 RVA: 0x0066A50C File Offset: 0x0066870C
		public static Offset<IInfrActivityInfrastructureStage> CreateIInfrActivityInfrastructureStage(FlatBufferBuilder builder, EInfrActivityBuildStageType Type = EInfrActivityBuildStageType.Infrastructure, int Stage = 0)
		{
			builder.StartTable(2);
			IInfrActivityInfrastructureStage.AddStage(builder, Stage);
			IInfrActivityInfrastructureStage.AddType(builder, Type);
			return IInfrActivityInfrastructureStage.EndIInfrActivityInfrastructureStage(builder);
		}

		// Token: 0x0602F121 RID: 192801 RVA: 0x0066A529 File Offset: 0x00668729
		public static void StartIInfrActivityInfrastructureStage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F122 RID: 192802 RVA: 0x0066A532 File Offset: 0x00668732
		public static void AddType(FlatBufferBuilder builder, EInfrActivityBuildStageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F123 RID: 192803 RVA: 0x0066A53D File Offset: 0x0066873D
		public static void AddStage(FlatBufferBuilder builder, int stage)
		{
			builder.AddInt(1, stage, 0);
		}

		// Token: 0x0602F124 RID: 192804 RVA: 0x0066A548 File Offset: 0x00668748
		public static Offset<IInfrActivityInfrastructureStage> EndIInfrActivityInfrastructureStage(FlatBufferBuilder builder)
		{
			return new Offset<IInfrActivityInfrastructureStage>(builder.EndTable());
		}

		// Token: 0x0602F125 RID: 192805 RVA: 0x0066A558 File Offset: 0x00668758
		public IInfrActivityInfrastructureStageT UnPack()
		{
			IInfrActivityInfrastructureStageT infrActivityInfrastructureStageT = new IInfrActivityInfrastructureStageT();
			this.UnPackTo(infrActivityInfrastructureStageT);
			return infrActivityInfrastructureStageT;
		}

		// Token: 0x0602F126 RID: 192806 RVA: 0x0066A573 File Offset: 0x00668773
		public void UnPackTo(IInfrActivityInfrastructureStageT _o)
		{
			_o.Type = this.Type;
			_o.Stage = this.Stage;
		}

		// Token: 0x0602F127 RID: 192807 RVA: 0x0066A590 File Offset: 0x00668790
		public static Offset<IInfrActivityInfrastructureStage> Pack(FlatBufferBuilder builder, IInfrActivityInfrastructureStageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInfrActivityInfrastructureStage>);
			}
			return IInfrActivityInfrastructureStage.CreateIInfrActivityInfrastructureStage(builder, _o.Type, _o.Stage);
		}

		// Token: 0x040110CF RID: 69839
		private Table __p;
	}
}
