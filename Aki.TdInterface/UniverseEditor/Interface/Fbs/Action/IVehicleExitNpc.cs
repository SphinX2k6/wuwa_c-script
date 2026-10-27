using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007517 RID: 29975
	public struct IVehicleExitNpc : IFlatbufferObject
	{
		// Token: 0x1700E374 RID: 58228
		// (get) Token: 0x06036845 RID: 223301 RVA: 0x00767ED0 File Offset: 0x007660D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036846 RID: 223302 RVA: 0x00767EDD File Offset: 0x007660DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036847 RID: 223303 RVA: 0x00767EE4 File Offset: 0x007660E4
		public static IVehicleExitNpc GetRootAsIVehicleExitNpc(ByteBuffer _bb)
		{
			return IVehicleExitNpc.GetRootAsIVehicleExitNpc(_bb, default(IVehicleExitNpc));
		}

		// Token: 0x06036848 RID: 223304 RVA: 0x00767F00 File Offset: 0x00766100
		public static IVehicleExitNpc GetRootAsIVehicleExitNpc(ByteBuffer _bb, IVehicleExitNpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036849 RID: 223305 RVA: 0x00767F1D File Offset: 0x0076611D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603684A RID: 223306 RVA: 0x00767F2C File Offset: 0x0076612C
		public IVehicleExitNpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E375 RID: 58229
		// (get) Token: 0x0603684B RID: 223307 RVA: 0x00767F3C File Offset: 0x0076613C
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

		// Token: 0x1700E376 RID: 58230
		// (get) Token: 0x0603684C RID: 223308 RVA: 0x00767F78 File Offset: 0x00766178
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

		// Token: 0x0603684D RID: 223309 RVA: 0x00767FB4 File Offset: 0x007661B4
		public TTable? ExitType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603684E RID: 223310 RVA: 0x00767FF8 File Offset: 0x007661F8
		public IExitVehicleLaunch ExitTypeAsIExitVehicleLaunch()
		{
			return this.ExitType<IExitVehicleLaunch>().Value;
		}

		// Token: 0x0603684F RID: 223311 RVA: 0x00768014 File Offset: 0x00766214
		public IExitVehicleSeatStandUp ExitTypeAsIExitVehicleSeatStandUp()
		{
			return this.ExitType<IExitVehicleSeatStandUp>().Value;
		}

		// Token: 0x06036850 RID: 223312 RVA: 0x00768030 File Offset: 0x00766230
		public IExitVehicleStandUp ExitTypeAsIExitVehicleStandUp()
		{
			return this.ExitType<IExitVehicleStandUp>().Value;
		}

		// Token: 0x06036851 RID: 223313 RVA: 0x0076804C File Offset: 0x0076624C
		public IExitVehicleTeleport ExitTypeAsIExitVehicleTeleport()
		{
			return this.ExitType<IExitVehicleTeleport>().Value;
		}

		// Token: 0x06036852 RID: 223314 RVA: 0x00768067 File Offset: 0x00766267
		public static Offset<IVehicleExitNpc> CreateIVehicleExitNpc(FlatBufferBuilder builder, int TargetNpc = 0, TExitVehicleType ExitType_type = TExitVehicleType.NONE, int ExitTypeOffset = 0)
		{
			builder.StartTable(3);
			IVehicleExitNpc.AddExitType(builder, ExitTypeOffset);
			IVehicleExitNpc.AddTargetNpc(builder, TargetNpc);
			IVehicleExitNpc.AddExitTypeType(builder, ExitType_type);
			return IVehicleExitNpc.EndIVehicleExitNpc(builder);
		}

		// Token: 0x06036853 RID: 223315 RVA: 0x0076808B File Offset: 0x0076628B
		public static void StartIVehicleExitNpc(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036854 RID: 223316 RVA: 0x00768094 File Offset: 0x00766294
		public static void AddTargetNpc(FlatBufferBuilder builder, int targetNpc)
		{
			builder.AddInt(0, targetNpc, 0);
		}

		// Token: 0x06036855 RID: 223317 RVA: 0x0076809F File Offset: 0x0076629F
		public static void AddExitTypeType(FlatBufferBuilder builder, TExitVehicleType exitTypeType)
		{
			builder.AddByte(1, (byte)exitTypeType, 0);
		}

		// Token: 0x06036856 RID: 223318 RVA: 0x007680AA File Offset: 0x007662AA
		public static void AddExitType(FlatBufferBuilder builder, int exitTypeOffset)
		{
			builder.AddOffset(2, exitTypeOffset, 0);
		}

		// Token: 0x06036857 RID: 223319 RVA: 0x007680B5 File Offset: 0x007662B5
		public static Offset<IVehicleExitNpc> EndIVehicleExitNpc(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleExitNpc>(builder.EndTable());
		}

		// Token: 0x06036858 RID: 223320 RVA: 0x007680C4 File Offset: 0x007662C4
		public IVehicleExitNpcT UnPack()
		{
			IVehicleExitNpcT vehicleExitNpcT = new IVehicleExitNpcT();
			this.UnPackTo(vehicleExitNpcT);
			return vehicleExitNpcT;
		}

		// Token: 0x06036859 RID: 223321 RVA: 0x007680E0 File Offset: 0x007662E0
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

		// Token: 0x0603685A RID: 223322 RVA: 0x00768210 File Offset: 0x00766410
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

		// Token: 0x04012405 RID: 74757
		private Table __p;
	}
}
