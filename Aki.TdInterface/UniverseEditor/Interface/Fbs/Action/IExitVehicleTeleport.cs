using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006735 RID: 26421
	public struct IExitVehicleTeleport : IFlatbufferObject
	{
		// Token: 0x1700C432 RID: 50226
		// (get) Token: 0x0602DF51 RID: 188241 RVA: 0x006482C9 File Offset: 0x006464C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF52 RID: 188242 RVA: 0x006482D6 File Offset: 0x006464D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF53 RID: 188243 RVA: 0x006482E0 File Offset: 0x006464E0
		public static IExitVehicleTeleport GetRootAsIExitVehicleTeleport(ByteBuffer _bb)
		{
			return IExitVehicleTeleport.GetRootAsIExitVehicleTeleport(_bb, default(IExitVehicleTeleport));
		}

		// Token: 0x0602DF54 RID: 188244 RVA: 0x006482FC File Offset: 0x006464FC
		public static IExitVehicleTeleport GetRootAsIExitVehicleTeleport(ByteBuffer _bb, IExitVehicleTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF55 RID: 188245 RVA: 0x00648319 File Offset: 0x00646519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF56 RID: 188246 RVA: 0x00648328 File Offset: 0x00646528
		public IExitVehicleTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C433 RID: 50227
		// (get) Token: 0x0602DF57 RID: 188247 RVA: 0x00648338 File Offset: 0x00646538
		public EExitVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExitVehicleType.Launch;
				}
				return (EExitVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C434 RID: 50228
		// (get) Token: 0x0602DF58 RID: 188248 RVA: 0x00648374 File Offset: 0x00646574
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C435 RID: 50229
		// (get) Token: 0x0602DF59 RID: 188249 RVA: 0x006483D4 File Offset: 0x006465D4
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602DF5A RID: 188250 RVA: 0x00648431 File Offset: 0x00646631
		public static Offset<IExitVehicleTeleport> CreateIExitVehicleTeleport(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IExitVehicleTeleport.AddRot(builder, RotOffset);
			IExitVehicleTeleport.AddPos(builder, PosOffset);
			IExitVehicleTeleport.AddType(builder, Type);
			return IExitVehicleTeleport.EndIExitVehicleTeleport(builder);
		}

		// Token: 0x0602DF5B RID: 188251 RVA: 0x00648455 File Offset: 0x00646655
		public static void StartIExitVehicleTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DF5C RID: 188252 RVA: 0x0064845E File Offset: 0x0064665E
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DF5D RID: 188253 RVA: 0x00648469 File Offset: 0x00646669
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602DF5E RID: 188254 RVA: 0x00648479 File Offset: 0x00646679
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x0602DF5F RID: 188255 RVA: 0x00648489 File Offset: 0x00646689
		public static Offset<IExitVehicleTeleport> EndIExitVehicleTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleTeleport>(builder.EndTable());
		}

		// Token: 0x0602DF60 RID: 188256 RVA: 0x00648498 File Offset: 0x00646698
		public IExitVehicleTeleportT UnPack()
		{
			IExitVehicleTeleportT exitVehicleTeleportT = new IExitVehicleTeleportT();
			this.UnPackTo(exitVehicleTeleportT);
			return exitVehicleTeleportT;
		}

		// Token: 0x0602DF61 RID: 188257 RVA: 0x006484B4 File Offset: 0x006466B4
		public void UnPackTo(IExitVehicleTeleportT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x0602DF62 RID: 188258 RVA: 0x0064852C File Offset: 0x0064672C
		public static Offset<IExitVehicleTeleport> Pack(FlatBufferBuilder builder, IExitVehicleTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleTeleport>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IExitVehicleTeleport.CreateIExitVehicleTeleport(builder, _o.Type, posOffset, rotOffset);
		}

		// Token: 0x04010E17 RID: 69143
		private Table __p;
	}
}
