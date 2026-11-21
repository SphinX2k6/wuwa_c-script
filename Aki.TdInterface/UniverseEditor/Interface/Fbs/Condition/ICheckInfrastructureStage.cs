using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F3E RID: 20286
	public struct ICheckInfrastructureStage : IFlatbufferObject
	{
		// Token: 0x170090F0 RID: 37104
		// (get) Token: 0x0601F8B1 RID: 129201 RVA: 0x004637E4 File Offset: 0x004619E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F8B2 RID: 129202 RVA: 0x004637F1 File Offset: 0x004619F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F8B3 RID: 129203 RVA: 0x004637F8 File Offset: 0x004619F8
		public static ICheckInfrastructureStage GetRootAsICheckInfrastructureStage(ByteBuffer _bb)
		{
			return ICheckInfrastructureStage.GetRootAsICheckInfrastructureStage(_bb, default(ICheckInfrastructureStage));
		}

		// Token: 0x0601F8B4 RID: 129204 RVA: 0x00463814 File Offset: 0x00461A14
		public static ICheckInfrastructureStage GetRootAsICheckInfrastructureStage(ByteBuffer _bb, ICheckInfrastructureStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F8B5 RID: 129205 RVA: 0x00463831 File Offset: 0x00461A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F8B6 RID: 129206 RVA: 0x00463840 File Offset: 0x00461A40
		public ICheckInfrastructureStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090F1 RID: 37105
		// (get) Token: 0x0601F8B7 RID: 129207 RVA: 0x00463850 File Offset: 0x00461A50
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170090F2 RID: 37106
		// (get) Token: 0x0601F8B8 RID: 129208 RVA: 0x0046388C File Offset: 0x00461A8C
		public EInfrastructureStage InfrastructureStage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EInfrastructureStage.None;
				}
				return (EInfrastructureStage)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F8B9 RID: 129209 RVA: 0x004638C8 File Offset: 0x00461AC8
		public static Offset<ICheckInfrastructureStage> CreateICheckInfrastructureStage(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, EInfrastructureStage InfrastructureStage = EInfrastructureStage.None)
		{
			builder.StartTable(2);
			ICheckInfrastructureStage.AddInfrastructureStage(builder, InfrastructureStage);
			ICheckInfrastructureStage.AddType(builder, Type);
			return ICheckInfrastructureStage.EndICheckInfrastructureStage(builder);
		}

		// Token: 0x0601F8BA RID: 129210 RVA: 0x004638E5 File Offset: 0x00461AE5
		public static void StartICheckInfrastructureStage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F8BB RID: 129211 RVA: 0x004638EE File Offset: 0x00461AEE
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F8BC RID: 129212 RVA: 0x004638F9 File Offset: 0x00461AF9
		public static void AddInfrastructureStage(FlatBufferBuilder builder, EInfrastructureStage infrastructureStage)
		{
			builder.AddByte(1, (byte)infrastructureStage, 0);
		}

		// Token: 0x0601F8BD RID: 129213 RVA: 0x00463904 File Offset: 0x00461B04
		public static Offset<ICheckInfrastructureStage> EndICheckInfrastructureStage(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInfrastructureStage>(builder.EndTable());
		}

		// Token: 0x0601F8BE RID: 129214 RVA: 0x00463914 File Offset: 0x00461B14
		public ICheckInfrastructureStageT UnPack()
		{
			ICheckInfrastructureStageT checkInfrastructureStageT = new ICheckInfrastructureStageT();
			this.UnPackTo(checkInfrastructureStageT);
			return checkInfrastructureStageT;
		}

		// Token: 0x0601F8BF RID: 129215 RVA: 0x0046392F File Offset: 0x00461B2F
		public void UnPackTo(ICheckInfrastructureStageT _o)
		{
			_o.Type = this.Type;
			_o.InfrastructureStage = this.InfrastructureStage;
		}

		// Token: 0x0601F8C0 RID: 129216 RVA: 0x0046394C File Offset: 0x00461B4C
		public static Offset<ICheckInfrastructureStage> Pack(FlatBufferBuilder builder, ICheckInfrastructureStageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckInfrastructureStage>);
			}
			return ICheckInfrastructureStage.CreateICheckInfrastructureStage(builder, _o.Type, _o.InfrastructureStage);
		}

		// Token: 0x0400DDBC RID: 56764
		private Table __p;
	}
}
