using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D0D RID: 32013
	public struct IVehicleExitNpc : IFlatbufferObject
	{
		// Token: 0x1700EF9E RID: 61342
		// (get) Token: 0x06039C5B RID: 236635 RVA: 0x007CB178 File Offset: 0x007C9378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039C5C RID: 236636 RVA: 0x007CB185 File Offset: 0x007C9385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039C5D RID: 236637 RVA: 0x007CB18C File Offset: 0x007C938C
		public static IVehicleExitNpc GetRootAsIVehicleExitNpc(ByteBuffer _bb)
		{
			return IVehicleExitNpc.GetRootAsIVehicleExitNpc(_bb, default(IVehicleExitNpc));
		}

		// Token: 0x06039C5E RID: 236638 RVA: 0x007CB1A8 File Offset: 0x007C93A8
		public static IVehicleExitNpc GetRootAsIVehicleExitNpc(ByteBuffer _bb, IVehicleExitNpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039C5F RID: 236639 RVA: 0x007CB1C5 File Offset: 0x007C93C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039C60 RID: 236640 RVA: 0x007CB1D4 File Offset: 0x007C93D4
		public IVehicleExitNpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF9F RID: 61343
		// (get) Token: 0x06039C61 RID: 236641 RVA: 0x007CB1E4 File Offset: 0x007C93E4
		public int TargetNpc
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EFA0 RID: 61344
		// (get) Token: 0x06039C62 RID: 236642 RVA: 0x007CB220 File Offset: 0x007C9420
		public TExitVehicleType ExitTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TExitVehicleType.NONE;
				}
				return (TExitVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039C63 RID: 236643 RVA: 0x007CB25C File Offset: 0x007C945C
		public TTable? ExitType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039C64 RID: 236644 RVA: 0x007CB2A0 File Offset: 0x007C94A0
		public IExitVehicleLaunch ExitTypeAsIExitVehicleLaunch()
		{
			return this.ExitType<IExitVehicleLaunch>().Value;
		}

		// Token: 0x06039C65 RID: 236645 RVA: 0x007CB2BC File Offset: 0x007C94BC
		public IExitVehicleSeatStandUp ExitTypeAsIExitVehicleSeatStandUp()
		{
			return this.ExitType<IExitVehicleSeatStandUp>().Value;
		}

		// Token: 0x06039C66 RID: 236646 RVA: 0x007CB2D8 File Offset: 0x007C94D8
		public IExitVehicleStandUp ExitTypeAsIExitVehicleStandUp()
		{
			return this.ExitType<IExitVehicleStandUp>().Value;
		}

		// Token: 0x06039C67 RID: 236647 RVA: 0x007CB2F4 File Offset: 0x007C94F4
		public IExitVehicleTeleport ExitTypeAsIExitVehicleTeleport()
		{
			return this.ExitType<IExitVehicleTeleport>().Value;
		}

		// Token: 0x06039C68 RID: 236648 RVA: 0x007CB30F File Offset: 0x007C950F
		public static Offset<IVehicleExitNpc> CreateIVehicleExitNpc(FlatBufferBuilder builder, int TargetNpc = 0, TExitVehicleType ExitType_type = TExitVehicleType.NONE, int ExitTypeOffset = 0)
		{
			builder.StartTable(3);
			IVehicleExitNpc.AddExitType(builder, ExitTypeOffset);
			IVehicleExitNpc.AddTargetNpc(builder, TargetNpc);
			IVehicleExitNpc.AddExitTypeType(builder, ExitType_type);
			return IVehicleExitNpc.EndIVehicleExitNpc(builder);
		}

		// Token: 0x06039C69 RID: 236649 RVA: 0x007CB333 File Offset: 0x007C9533
		public static void StartIVehicleExitNpc(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039C6A RID: 236650 RVA: 0x007CB33C File Offset: 0x007C953C
		public static void AddTargetNpc(FlatBufferBuilder builder, int targetNpc)
		{
			builder.AddInt(0, targetNpc, 0);
		}

		// Token: 0x06039C6B RID: 236651 RVA: 0x007CB347 File Offset: 0x007C9547
		public static void AddExitTypeType(FlatBufferBuilder builder, TExitVehicleType exitTypeType)
		{
			builder.AddByte(1, (byte)exitTypeType, 0);
		}

		// Token: 0x06039C6C RID: 236652 RVA: 0x007CB352 File Offset: 0x007C9552
		public static void AddExitType(FlatBufferBuilder builder, int exitTypeOffset)
		{
			builder.AddOffset(2, exitTypeOffset, 0);
		}

		// Token: 0x06039C6D RID: 236653 RVA: 0x007CB35D File Offset: 0x007C955D
		public static Offset<IVehicleExitNpc> EndIVehicleExitNpc(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleExitNpc>(builder.EndTable());
		}

		// Token: 0x06039C6E RID: 236654 RVA: 0x007CB36C File Offset: 0x007C956C
		public IVehicleExitNpcT UnPack()
		{
			IVehicleExitNpcT vehicleExitNpcT = new IVehicleExitNpcT();
			this.UnPackTo(vehicleExitNpcT);
			return vehicleExitNpcT;
		}

		// Token: 0x06039C6F RID: 236655 RVA: 0x007CB388 File Offset: 0x007C9588
		public void UnPackTo(IVehicleExitNpcT _o)
		{
			_o.TargetNpc = this.TargetNpc;
			_o.ExitType = new TExitVehicleTypeUnion();
			_o.ExitType.Type = this.ExitTypeType;
			switch (this.ExitTypeType)
			{
			case TExitVehicleType.IExitVehicleLaunch:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleLaunch>() != null) ? this.ExitType<IExitVehicleLaunch>().Value.UnPack() : null);
				return;
			case TExitVehicleType.IExitVehicleSeatStandUp:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleSeatStandUp>() != null) ? this.ExitType<IExitVehicleSeatStandUp>().Value.UnPack() : null);
				return;
			case TExitVehicleType.IExitVehicleStandUp:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleStandUp>() != null) ? this.ExitType<IExitVehicleStandUp>().Value.UnPack() : null);
				return;
			case TExitVehicleType.IExitVehicleTeleport:
				_o.ExitType.Value = ((this.ExitType<IExitVehicleTeleport>() != null) ? this.ExitType<IExitVehicleTeleport>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06039C70 RID: 236656 RVA: 0x007CB4B8 File Offset: 0x007C96B8
		public static Offset<IVehicleExitNpc> Pack(FlatBufferBuilder builder, IVehicleExitNpcT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleExitNpc>);
			}
			TExitVehicleType exitType_type = (_o.ExitType == null) ? TExitVehicleType.NONE : _o.ExitType.Type;
			int exitTypeOffset = (_o.ExitType == null) ? 0 : TExitVehicleTypeUnion.Pack(builder, _o.ExitType);
			return IVehicleExitNpc.CreateIVehicleExitNpc(builder, _o.TargetNpc, exitType_type, exitTypeOffset);
		}

		// Token: 0x04013436 RID: 78902
		private Table __p;
	}
}
