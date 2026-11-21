using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB5 RID: 28085
	public struct IExitVehicleTeleport : IFlatbufferObject
	{
		// Token: 0x1700CDE8 RID: 52712
		// (get) Token: 0x06030797 RID: 198551 RVA: 0x00695A0D File Offset: 0x00693C0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030798 RID: 198552 RVA: 0x00695A1A File Offset: 0x00693C1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030799 RID: 198553 RVA: 0x00695A24 File Offset: 0x00693C24
		public static IExitVehicleTeleport GetRootAsIExitVehicleTeleport(ByteBuffer _bb)
		{
			return IExitVehicleTeleport.GetRootAsIExitVehicleTeleport(_bb, default(IExitVehicleTeleport));
		}

		// Token: 0x0603079A RID: 198554 RVA: 0x00695A40 File Offset: 0x00693C40
		public static IExitVehicleTeleport GetRootAsIExitVehicleTeleport(ByteBuffer _bb, IExitVehicleTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603079B RID: 198555 RVA: 0x00695A5D File Offset: 0x00693C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603079C RID: 198556 RVA: 0x00695A6C File Offset: 0x00693C6C
		public IExitVehicleTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDE9 RID: 52713
		// (get) Token: 0x0603079D RID: 198557 RVA: 0x00695A7C File Offset: 0x00693C7C
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

		// Token: 0x1700CDEA RID: 52714
		// (get) Token: 0x0603079E RID: 198558 RVA: 0x00695AB8 File Offset: 0x00693CB8
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

		// Token: 0x1700CDEB RID: 52715
		// (get) Token: 0x0603079F RID: 198559 RVA: 0x00695B18 File Offset: 0x00693D18
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

		// Token: 0x060307A0 RID: 198560 RVA: 0x00695B75 File Offset: 0x00693D75
		public static Offset<IExitVehicleTeleport> CreateIExitVehicleTeleport(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IExitVehicleTeleport.AddRot(builder, RotOffset);
			IExitVehicleTeleport.AddPos(builder, PosOffset);
			IExitVehicleTeleport.AddType(builder, Type);
			return IExitVehicleTeleport.EndIExitVehicleTeleport(builder);
		}

		// Token: 0x060307A1 RID: 198561 RVA: 0x00695B99 File Offset: 0x00693D99
		public static void StartIExitVehicleTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060307A2 RID: 198562 RVA: 0x00695BA2 File Offset: 0x00693DA2
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060307A3 RID: 198563 RVA: 0x00695BAD File Offset: 0x00693DAD
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060307A4 RID: 198564 RVA: 0x00695BBD File Offset: 0x00693DBD
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(2, rotOffset.Value, 0);
		}

		// Token: 0x060307A5 RID: 198565 RVA: 0x00695BCD File Offset: 0x00693DCD
		public static Offset<IExitVehicleTeleport> EndIExitVehicleTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleTeleport>(builder.EndTable());
		}

		// Token: 0x060307A6 RID: 198566 RVA: 0x00695BDC File Offset: 0x00693DDC
		public IExitVehicleTeleportT UnPack()
		{
			IExitVehicleTeleportT exitVehicleTeleportT = new IExitVehicleTeleportT();
			this.UnPackTo(exitVehicleTeleportT);
			return exitVehicleTeleportT;
		}

		// Token: 0x060307A7 RID: 198567 RVA: 0x00695BF8 File Offset: 0x00693DF8
		public void UnPackTo(IExitVehicleTeleportT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x060307A8 RID: 198568 RVA: 0x00695C70 File Offset: 0x00693E70
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

		// Token: 0x04011C49 RID: 72777
		private Table __p;
	}
}
