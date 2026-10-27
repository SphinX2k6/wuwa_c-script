using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A78 RID: 19064
	public struct ICheckInfrastructureStage : IFlatbufferObject
	{
		// Token: 0x17008A14 RID: 35348
		// (get) Token: 0x0601DE0E RID: 122382 RVA: 0x00432658 File Offset: 0x00430858
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE0F RID: 122383 RVA: 0x00432665 File Offset: 0x00430865
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE10 RID: 122384 RVA: 0x0043266C File Offset: 0x0043086C
		public static ICheckInfrastructureStage GetRootAsICheckInfrastructureStage(ByteBuffer _bb)
		{
			return ICheckInfrastructureStage.GetRootAsICheckInfrastructureStage(_bb, default(ICheckInfrastructureStage));
		}

		// Token: 0x0601DE11 RID: 122385 RVA: 0x00432688 File Offset: 0x00430888
		public static ICheckInfrastructureStage GetRootAsICheckInfrastructureStage(ByteBuffer _bb, ICheckInfrastructureStage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE12 RID: 122386 RVA: 0x004326A5 File Offset: 0x004308A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE13 RID: 122387 RVA: 0x004326B4 File Offset: 0x004308B4
		public ICheckInfrastructureStage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A15 RID: 35349
		// (get) Token: 0x0601DE14 RID: 122388 RVA: 0x004326C4 File Offset: 0x004308C4
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

		// Token: 0x17008A16 RID: 35350
		// (get) Token: 0x0601DE15 RID: 122389 RVA: 0x00432700 File Offset: 0x00430900
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

		// Token: 0x0601DE16 RID: 122390 RVA: 0x0043273C File Offset: 0x0043093C
		public static Offset<ICheckInfrastructureStage> CreateICheckInfrastructureStage(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, EInfrastructureStage InfrastructureStage = EInfrastructureStage.None)
		{
			builder.StartTable(2);
			ICheckInfrastructureStage.AddInfrastructureStage(builder, InfrastructureStage);
			ICheckInfrastructureStage.AddType(builder, Type);
			return ICheckInfrastructureStage.EndICheckInfrastructureStage(builder);
		}

		// Token: 0x0601DE17 RID: 122391 RVA: 0x00432759 File Offset: 0x00430959
		public static void StartICheckInfrastructureStage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DE18 RID: 122392 RVA: 0x00432762 File Offset: 0x00430962
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DE19 RID: 122393 RVA: 0x0043276D File Offset: 0x0043096D
		public static void AddInfrastructureStage(FlatBufferBuilder builder, EInfrastructureStage infrastructureStage)
		{
			builder.AddByte(1, (byte)infrastructureStage, 0);
		}

		// Token: 0x0601DE1A RID: 122394 RVA: 0x00432778 File Offset: 0x00430978
		public static Offset<ICheckInfrastructureStage> EndICheckInfrastructureStage(FlatBufferBuilder builder)
		{
			return new Offset<ICheckInfrastructureStage>(builder.EndTable());
		}

		// Token: 0x0601DE1B RID: 122395 RVA: 0x00432788 File Offset: 0x00430988
		public ICheckInfrastructureStageT UnPack()
		{
			ICheckInfrastructureStageT checkInfrastructureStageT = new ICheckInfrastructureStageT();
			this.UnPackTo(checkInfrastructureStageT);
			return checkInfrastructureStageT;
		}

		// Token: 0x0601DE1C RID: 122396 RVA: 0x004327A3 File Offset: 0x004309A3
		public void UnPackTo(ICheckInfrastructureStageT _o)
		{
			_o.Type = this.Type;
			_o.InfrastructureStage = this.InfrastructureStage;
		}

		// Token: 0x0601DE1D RID: 122397 RVA: 0x004327C0 File Offset: 0x004309C0
		public static Offset<ICheckInfrastructureStage> Pack(FlatBufferBuilder builder, ICheckInfrastructureStageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckInfrastructureStage>);
			}
			return ICheckInfrastructureStage.CreateICheckInfrastructureStage(builder, _o.Type, _o.InfrastructureStage);
		}

		// Token: 0x0400D2E1 RID: 53985
		private Table __p;
	}
}
