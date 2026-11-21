using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B3F RID: 31551
	public struct ITargetVehicle : IFlatbufferObject
	{
		// Token: 0x1700EC50 RID: 60496
		// (get) Token: 0x06038D1F RID: 232735 RVA: 0x007AF0D6 File Offset: 0x007AD2D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038D20 RID: 232736 RVA: 0x007AF0E3 File Offset: 0x007AD2E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038D21 RID: 232737 RVA: 0x007AF0EC File Offset: 0x007AD2EC
		public static ITargetVehicle GetRootAsITargetVehicle(ByteBuffer _bb)
		{
			return ITargetVehicle.GetRootAsITargetVehicle(_bb, default(ITargetVehicle));
		}

		// Token: 0x06038D22 RID: 232738 RVA: 0x007AF108 File Offset: 0x007AD308
		public static ITargetVehicle GetRootAsITargetVehicle(ByteBuffer _bb, ITargetVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038D23 RID: 232739 RVA: 0x007AF125 File Offset: 0x007AD325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038D24 RID: 232740 RVA: 0x007AF134 File Offset: 0x007AD334
		public ITargetVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC51 RID: 60497
		// (get) Token: 0x06038D25 RID: 232741 RVA: 0x007AF144 File Offset: 0x007AD344
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038D26 RID: 232742 RVA: 0x007AF180 File Offset: 0x007AD380
		public static Offset<ITargetVehicle> CreateITargetVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ITargetVehicle.AddType(builder, Type);
			return ITargetVehicle.EndITargetVehicle(builder);
		}

		// Token: 0x06038D27 RID: 232743 RVA: 0x007AF196 File Offset: 0x007AD396
		public static void StartITargetVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038D28 RID: 232744 RVA: 0x007AF19F File Offset: 0x007AD39F
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038D29 RID: 232745 RVA: 0x007AF1AA File Offset: 0x007AD3AA
		public static Offset<ITargetVehicle> EndITargetVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITargetVehicle>(builder.EndTable());
		}

		// Token: 0x06038D2A RID: 232746 RVA: 0x007AF1B8 File Offset: 0x007AD3B8
		public ITargetVehicleT UnPack()
		{
			ITargetVehicleT targetVehicleT = new ITargetVehicleT();
			this.UnPackTo(targetVehicleT);
			return targetVehicleT;
		}

		// Token: 0x06038D2B RID: 232747 RVA: 0x007AF1D3 File Offset: 0x007AD3D3
		public void UnPackTo(ITargetVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038D2C RID: 232748 RVA: 0x007AF1E4 File Offset: 0x007AD3E4
		public static Offset<ITargetVehicle> Pack(FlatBufferBuilder builder, ITargetVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetVehicle>);
			}
			return ITargetVehicle.CreateITargetVehicle(builder, _o.Type);
		}

		// Token: 0x04013172 RID: 78194
		private Table __p;
	}
}
