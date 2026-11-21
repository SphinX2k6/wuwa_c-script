using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CFB RID: 31995
	public struct IVehicleEnteringNpcTarget : IFlatbufferObject
	{
		// Token: 0x1700EF79 RID: 61305
		// (get) Token: 0x06039BB9 RID: 236473 RVA: 0x007C9C66 File Offset: 0x007C7E66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039BBA RID: 236474 RVA: 0x007C9C73 File Offset: 0x007C7E73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039BBB RID: 236475 RVA: 0x007C9C7C File Offset: 0x007C7E7C
		public static IVehicleEnteringNpcTarget GetRootAsIVehicleEnteringNpcTarget(ByteBuffer _bb)
		{
			return IVehicleEnteringNpcTarget.GetRootAsIVehicleEnteringNpcTarget(_bb, default(IVehicleEnteringNpcTarget));
		}

		// Token: 0x06039BBC RID: 236476 RVA: 0x007C9C98 File Offset: 0x007C7E98
		public static IVehicleEnteringNpcTarget GetRootAsIVehicleEnteringNpcTarget(ByteBuffer _bb, IVehicleEnteringNpcTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039BBD RID: 236477 RVA: 0x007C9CB5 File Offset: 0x007C7EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039BBE RID: 236478 RVA: 0x007C9CC4 File Offset: 0x007C7EC4
		public IVehicleEnteringNpcTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF7A RID: 61306
		// (get) Token: 0x06039BBF RID: 236479 RVA: 0x007C9CD4 File Offset: 0x007C7ED4
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

		// Token: 0x1700EF7B RID: 61307
		// (get) Token: 0x06039BC0 RID: 236480 RVA: 0x007C9D10 File Offset: 0x007C7F10
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

		// Token: 0x1700EF7C RID: 61308
		// (get) Token: 0x06039BC1 RID: 236481 RVA: 0x007C9D4C File Offset: 0x007C7F4C
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

		// Token: 0x1700EF7D RID: 61309
		// (get) Token: 0x06039BC2 RID: 236482 RVA: 0x007C9D88 File Offset: 0x007C7F88
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

		// Token: 0x06039BC3 RID: 236483 RVA: 0x007C9DC5 File Offset: 0x007C7FC5
		public static Offset<IVehicleEnteringNpcTarget> CreateIVehicleEnteringNpcTarget(FlatBufferBuilder builder, EVehicleEnteringTarget Type = EVehicleEnteringTarget.Player, int TargetVehicle = 0, int TargetNpc = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehicleEnteringNpcTarget.AddTargetNpc(builder, TargetNpc);
			IVehicleEnteringNpcTarget.AddTargetVehicle(builder, TargetVehicle);
			IVehicleEnteringNpcTarget.AddNullMask(builder, NullMask);
			IVehicleEnteringNpcTarget.AddType(builder, Type);
			return IVehicleEnteringNpcTarget.EndIVehicleEnteringNpcTarget(builder);
		}

		// Token: 0x06039BC4 RID: 236484 RVA: 0x007C9DF1 File Offset: 0x007C7FF1
		public static void StartIVehicleEnteringNpcTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039BC5 RID: 236485 RVA: 0x007C9DFA File Offset: 0x007C7FFA
		public static void AddType(FlatBufferBuilder builder, EVehicleEnteringTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039BC6 RID: 236486 RVA: 0x007C9E05 File Offset: 0x007C8005
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicle)
		{
			builder.AddInt(1, targetVehicle, 0);
		}

		// Token: 0x06039BC7 RID: 236487 RVA: 0x007C9E10 File Offset: 0x007C8010
		public static void AddTargetNpc(FlatBufferBuilder builder, int targetNpc)
		{
			builder.AddInt(2, targetNpc, 0);
		}

		// Token: 0x06039BC8 RID: 236488 RVA: 0x007C9E1B File Offset: 0x007C801B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06039BC9 RID: 236489 RVA: 0x007C9E26 File Offset: 0x007C8026
		public static Offset<IVehicleEnteringNpcTarget> EndIVehicleEnteringNpcTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleEnteringNpcTarget>(builder.EndTable());
		}

		// Token: 0x06039BCA RID: 236490 RVA: 0x007C9E34 File Offset: 0x007C8034
		public IVehicleEnteringNpcTargetT UnPack()
		{
			IVehicleEnteringNpcTargetT vehicleEnteringNpcTargetT = new IVehicleEnteringNpcTargetT();
			this.UnPackTo(vehicleEnteringNpcTargetT);
			return vehicleEnteringNpcTargetT;
		}

		// Token: 0x06039BCB RID: 236491 RVA: 0x007C9E4F File Offset: 0x007C804F
		public void UnPackTo(IVehicleEnteringNpcTargetT _o)
		{
			_o.Type = this.Type;
			_o.TargetVehicle = this.TargetVehicle;
			_o.TargetNpc = this.TargetNpc;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039BCC RID: 236492 RVA: 0x007C9E84 File Offset: 0x007C8084
		public static Offset<IVehicleEnteringNpcTarget> Pack(FlatBufferBuilder builder, IVehicleEnteringNpcTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleEnteringNpcTarget>);
			}
			return IVehicleEnteringNpcTarget.CreateIVehicleEnteringNpcTarget(builder, _o.Type, _o.TargetVehicle, _o.TargetNpc, _o.NullMask);
		}

		// Token: 0x0401341B RID: 78875
		private Table __p;
	}
}
