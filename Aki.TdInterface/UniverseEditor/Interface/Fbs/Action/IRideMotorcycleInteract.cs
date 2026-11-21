using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007654 RID: 30292
	public struct IRideMotorcycleInteract : IFlatbufferObject
	{
		// Token: 0x1700DE72 RID: 56946
		// (get) Token: 0x06035263 RID: 217699 RVA: 0x00722C0C File Offset: 0x00720E0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035264 RID: 217700 RVA: 0x00722C19 File Offset: 0x00720E19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035265 RID: 217701 RVA: 0x00722C20 File Offset: 0x00720E20
		public static IRideMotorcycleInteract GetRootAsIRideMotorcycleInteract(ByteBuffer _bb)
		{
			return IRideMotorcycleInteract.GetRootAsIRideMotorcycleInteract(_bb, default(IRideMotorcycleInteract));
		}

		// Token: 0x06035266 RID: 217702 RVA: 0x00722C3C File Offset: 0x00720E3C
		public static IRideMotorcycleInteract GetRootAsIRideMotorcycleInteract(ByteBuffer _bb, IRideMotorcycleInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035267 RID: 217703 RVA: 0x00722C59 File Offset: 0x00720E59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035268 RID: 217704 RVA: 0x00722C68 File Offset: 0x00720E68
		public IRideMotorcycleInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE73 RID: 56947
		// (get) Token: 0x06035269 RID: 217705 RVA: 0x00722C78 File Offset: 0x00720E78
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DE74 RID: 56948
		// (get) Token: 0x0603526A RID: 217706 RVA: 0x00722CB4 File Offset: 0x00720EB4
		public int MotorcycleEntityId
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

		// Token: 0x0603526B RID: 217707 RVA: 0x00722CF0 File Offset: 0x00720EF0
		public static Offset<IRideMotorcycleInteract> CreateIRideMotorcycleInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int MotorcycleEntityId = 0)
		{
			builder.StartTable(2);
			IRideMotorcycleInteract.AddMotorcycleEntityId(builder, MotorcycleEntityId);
			IRideMotorcycleInteract.AddType(builder, Type);
			return IRideMotorcycleInteract.EndIRideMotorcycleInteract(builder);
		}

		// Token: 0x0603526C RID: 217708 RVA: 0x00722D0D File Offset: 0x00720F0D
		public static void StartIRideMotorcycleInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603526D RID: 217709 RVA: 0x00722D16 File Offset: 0x00720F16
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603526E RID: 217710 RVA: 0x00722D21 File Offset: 0x00720F21
		public static void AddMotorcycleEntityId(FlatBufferBuilder builder, int motorcycleEntityId)
		{
			builder.AddInt(1, motorcycleEntityId, 0);
		}

		// Token: 0x0603526F RID: 217711 RVA: 0x00722D2C File Offset: 0x00720F2C
		public static Offset<IRideMotorcycleInteract> EndIRideMotorcycleInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRideMotorcycleInteract>(builder.EndTable());
		}

		// Token: 0x06035270 RID: 217712 RVA: 0x00722D3C File Offset: 0x00720F3C
		public IRideMotorcycleInteractT UnPack()
		{
			IRideMotorcycleInteractT rideMotorcycleInteractT = new IRideMotorcycleInteractT();
			this.UnPackTo(rideMotorcycleInteractT);
			return rideMotorcycleInteractT;
		}

		// Token: 0x06035271 RID: 217713 RVA: 0x00722D57 File Offset: 0x00720F57
		public void UnPackTo(IRideMotorcycleInteractT _o)
		{
			_o.Type = this.Type;
			_o.MotorcycleEntityId = this.MotorcycleEntityId;
		}

		// Token: 0x06035272 RID: 217714 RVA: 0x00722D74 File Offset: 0x00720F74
		public static Offset<IRideMotorcycleInteract> Pack(FlatBufferBuilder builder, IRideMotorcycleInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRideMotorcycleInteract>);
			}
			return IRideMotorcycleInteract.CreateIRideMotorcycleInteract(builder, _o.Type, _o.MotorcycleEntityId);
		}

		// Token: 0x04012849 RID: 75849
		private Table __p;
	}
}
