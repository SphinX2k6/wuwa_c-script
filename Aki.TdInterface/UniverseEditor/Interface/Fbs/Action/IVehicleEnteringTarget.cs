using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750B RID: 29963
	public struct IVehicleEnteringTarget : IFlatbufferObject
	{
		// Token: 0x1700E35F RID: 58207
		// (get) Token: 0x060367DC RID: 223196 RVA: 0x00766FC0 File Offset: 0x007651C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060367DD RID: 223197 RVA: 0x00766FCD File Offset: 0x007651CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060367DE RID: 223198 RVA: 0x00766FD4 File Offset: 0x007651D4
		public static IVehicleEnteringTarget GetRootAsIVehicleEnteringTarget(ByteBuffer _bb)
		{
			return IVehicleEnteringTarget.GetRootAsIVehicleEnteringTarget(_bb, default(IVehicleEnteringTarget));
		}

		// Token: 0x060367DF RID: 223199 RVA: 0x00766FF0 File Offset: 0x007651F0
		public static IVehicleEnteringTarget GetRootAsIVehicleEnteringTarget(ByteBuffer _bb, IVehicleEnteringTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060367E0 RID: 223200 RVA: 0x0076700D File Offset: 0x0076520D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060367E1 RID: 223201 RVA: 0x0076701C File Offset: 0x0076521C
		public IVehicleEnteringTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E360 RID: 58208
		// (get) Token: 0x060367E2 RID: 223202 RVA: 0x0076702C File Offset: 0x0076522C
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

		// Token: 0x1700E361 RID: 58209
		// (get) Token: 0x060367E3 RID: 223203 RVA: 0x00767068 File Offset: 0x00765268
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

		// Token: 0x1700E362 RID: 58210
		// (get) Token: 0x060367E4 RID: 223204 RVA: 0x007670A4 File Offset: 0x007652A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060367E5 RID: 223205 RVA: 0x007670E0 File Offset: 0x007652E0
		public static Offset<IVehicleEnteringTarget> CreateIVehicleEnteringTarget(FlatBufferBuilder builder, EVehicleEnteringTarget Type = EVehicleEnteringTarget.Player, int TargetVehicle = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IVehicleEnteringTarget.AddTargetVehicle(builder, TargetVehicle);
			IVehicleEnteringTarget.AddNullMask(builder, NullMask);
			IVehicleEnteringTarget.AddType(builder, Type);
			return IVehicleEnteringTarget.EndIVehicleEnteringTarget(builder);
		}

		// Token: 0x060367E6 RID: 223206 RVA: 0x00767104 File Offset: 0x00765304
		public static void StartIVehicleEnteringTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060367E7 RID: 223207 RVA: 0x0076710D File Offset: 0x0076530D
		public static void AddType(FlatBufferBuilder builder, EVehicleEnteringTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060367E8 RID: 223208 RVA: 0x00767118 File Offset: 0x00765318
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x060367E9 RID: 223209 RVA: 0x00767123 File Offset: 0x00765323
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060367EA RID: 223210 RVA: 0x0076712E File Offset: 0x0076532E
		public static Offset<IVehicleEnteringTarget> EndIVehicleEnteringTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnteringTarget>(builder.EndTable());
		}

		// Token: 0x060367EB RID: 223211 RVA: 0x0076713C File Offset: 0x0076533C
		public IVehicleEnteringTargetT UnPack()
		{
			IVehicleEnteringTargetT vehicleEnteringTargetT = new IVehicleEnteringTargetT();
			this.UnPackTo(vehicleEnteringTargetT);
			return vehicleEnteringTargetT;
		}

		// Token: 0x060367EC RID: 223212 RVA: 0x00767157 File Offset: 0x00765357
		public void UnPackTo(IVehicleEnteringTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060367ED RID: 223213 RVA: 0x00767180 File Offset: 0x00765380
		public static Offset<IVehicleEnteringTarget> Pack(FlatBufferBuilder builder, IVehicleEnteringTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnteringTarget>);
			}
			return IVehicleEnteringTarget.CreateIVehicleEnteringTarget(builder, _o.Type, _o.TargetVehicle, _o.NullMask);
		}

		// Token: 0x040123F3 RID: 74739
		private Table __p;
	}
}
