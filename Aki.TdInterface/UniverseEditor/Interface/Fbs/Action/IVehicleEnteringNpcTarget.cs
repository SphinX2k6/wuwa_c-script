using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007505 RID: 29957
	public struct IVehicleEnteringNpcTarget : IFlatbufferObject
	{
		// Token: 0x1700E34F RID: 58191
		// (get) Token: 0x060367A4 RID: 223140 RVA: 0x00766A16 File Offset: 0x00764C16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060367A5 RID: 223141 RVA: 0x00766A23 File Offset: 0x00764C23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060367A6 RID: 223142 RVA: 0x00766A2C File Offset: 0x00764C2C
		public static IVehicleEnteringNpcTarget GetRootAsIVehicleEnteringNpcTarget(ByteBuffer _bb)
		{
			return IVehicleEnteringNpcTarget.GetRootAsIVehicleEnteringNpcTarget(_bb, default(IVehicleEnteringNpcTarget));
		}

		// Token: 0x060367A7 RID: 223143 RVA: 0x00766A48 File Offset: 0x00764C48
		public static IVehicleEnteringNpcTarget GetRootAsIVehicleEnteringNpcTarget(ByteBuffer _bb, IVehicleEnteringNpcTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060367A8 RID: 223144 RVA: 0x00766A65 File Offset: 0x00764C65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060367A9 RID: 223145 RVA: 0x00766A74 File Offset: 0x00764C74
		public IVehicleEnteringNpcTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E350 RID: 58192
		// (get) Token: 0x060367AA RID: 223146 RVA: 0x00766A84 File Offset: 0x00764C84
		public EVehicleEnteringTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleEnteringTarget.Player;
				}
				return (EVehicleEnteringTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E351 RID: 58193
		// (get) Token: 0x060367AB RID: 223147 RVA: 0x00766AC0 File Offset: 0x00764CC0
		public int TargetVehicle
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

		// Token: 0x1700E352 RID: 58194
		// (get) Token: 0x060367AC RID: 223148 RVA: 0x00766AFC File Offset: 0x00764CFC
		public int TargetNpc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E353 RID: 58195
		// (get) Token: 0x060367AD RID: 223149 RVA: 0x00766B38 File Offset: 0x00764D38
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060367AE RID: 223150 RVA: 0x00766B75 File Offset: 0x00764D75
		public static Offset<IVehicleEnteringNpcTarget> CreateIVehicleEnteringNpcTarget(FlatBufferBuilder builder, EVehicleEnteringTarget Type = EVehicleEnteringTarget.Player, int TargetVehicle = 0, int TargetNpc = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehicleEnteringNpcTarget.AddTargetNpc(builder, TargetNpc);
			IVehicleEnteringNpcTarget.AddTargetVehicle(builder, TargetVehicle);
			IVehicleEnteringNpcTarget.AddNullMask(builder, NullMask);
			IVehicleEnteringNpcTarget.AddType(builder, Type);
			return IVehicleEnteringNpcTarget.EndIVehicleEnteringNpcTarget(builder);
		}

		// Token: 0x060367AF RID: 223151 RVA: 0x00766BA1 File Offset: 0x00764DA1
		public static void StartIVehicleEnteringNpcTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060367B0 RID: 223152 RVA: 0x00766BAA File Offset: 0x00764DAA
		public static void AddType(FlatBufferBuilder builder, EVehicleEnteringTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060367B1 RID: 223153 RVA: 0x00766BB5 File Offset: 0x00764DB5
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x060367B2 RID: 223154 RVA: 0x00766BC0 File Offset: 0x00764DC0
		public static void AddTargetNpc(FlatBufferBuilder builder, int targetNpc)
		{
			builder.AddInt(2, targetNpc, 0);
		}

		// Token: 0x060367B3 RID: 223155 RVA: 0x00766BCB File Offset: 0x00764DCB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060367B4 RID: 223156 RVA: 0x00766BD6 File Offset: 0x00764DD6
		public static Offset<IVehicleEnteringNpcTarget> EndIVehicleEnteringNpcTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnteringNpcTarget>(builder.EndTable());
		}

		// Token: 0x060367B5 RID: 223157 RVA: 0x00766BE4 File Offset: 0x00764DE4
		public IVehicleEnteringNpcTargetT UnPack()
		{
			IVehicleEnteringNpcTargetT vehicleEnteringNpcTargetT = new IVehicleEnteringNpcTargetT();
			this.UnPackTo(vehicleEnteringNpcTargetT);
			return vehicleEnteringNpcTargetT;
		}

		// Token: 0x060367B6 RID: 223158 RVA: 0x00766BFF File Offset: 0x00764DFF
		public void UnPackTo(IVehicleEnteringNpcTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.TargetNpc = this.TargetNpc;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060367B7 RID: 223159 RVA: 0x00766C34 File Offset: 0x00764E34
		public static Offset<IVehicleEnteringNpcTarget> Pack(FlatBufferBuilder builder, IVehicleEnteringNpcTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnteringNpcTarget>);
			}
			return IVehicleEnteringNpcTarget.CreateIVehicleEnteringNpcTarget(builder, _o.Type, _o.TargetVehicle, _o.TargetNpc, _o.NullMask);
		}

		// Token: 0x040123EA RID: 74730
		private Table __p;
	}
}
