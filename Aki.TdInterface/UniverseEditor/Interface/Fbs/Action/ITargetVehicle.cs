using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007364 RID: 29540
	public struct ITargetVehicle : IFlatbufferObject
	{
		// Token: 0x1700E04F RID: 57423
		// (get) Token: 0x060359D6 RID: 219606 RVA: 0x0074D302 File Offset: 0x0074B502
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060359D7 RID: 219607 RVA: 0x0074D30F File Offset: 0x0074B50F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060359D8 RID: 219608 RVA: 0x0074D318 File Offset: 0x0074B518
		public static ITargetVehicle GetRootAsITargetVehicle(ByteBuffer _bb)
		{
			return ITargetVehicle.GetRootAsITargetVehicle(_bb, default(ITargetVehicle));
		}

		// Token: 0x060359D9 RID: 219609 RVA: 0x0074D334 File Offset: 0x0074B534
		public static ITargetVehicle GetRootAsITargetVehicle(ByteBuffer _bb, ITargetVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060359DA RID: 219610 RVA: 0x0074D351 File Offset: 0x0074B551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060359DB RID: 219611 RVA: 0x0074D360 File Offset: 0x0074B560
		public ITargetVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E050 RID: 57424
		// (get) Token: 0x060359DC RID: 219612 RVA: 0x0074D370 File Offset: 0x0074B570
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

		// Token: 0x060359DD RID: 219613 RVA: 0x0074D3AC File Offset: 0x0074B5AC
		public static Offset<ITargetVehicle> CreateITargetVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ITargetVehicle.AddType(builder, Type);
			return ITargetVehicle.EndITargetVehicle(builder);
		}

		// Token: 0x060359DE RID: 219614 RVA: 0x0074D3C2 File Offset: 0x0074B5C2
		public static void StartITargetVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060359DF RID: 219615 RVA: 0x0074D3CB File Offset: 0x0074B5CB
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060359E0 RID: 219616 RVA: 0x0074D3D6 File Offset: 0x0074B5D6
		public static Offset<ITargetVehicle> EndITargetVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITargetVehicle>(builder.EndTable());
		}

		// Token: 0x060359E1 RID: 219617 RVA: 0x0074D3E4 File Offset: 0x0074B5E4
		public ITargetVehicleT UnPack()
		{
			ITargetVehicleT targetVehicleT = new ITargetVehicleT();
			this.UnPackTo(targetVehicleT);
			return targetVehicleT;
		}

		// Token: 0x060359E2 RID: 219618 RVA: 0x0074D3FF File Offset: 0x0074B5FF
		public void UnPackTo(ITargetVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060359E3 RID: 219619 RVA: 0x0074D410 File Offset: 0x0074B610
		public static Offset<ITargetVehicle> Pack(FlatBufferBuilder builder, ITargetVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetVehicle>);
			}
			return ITargetVehicle.CreateITargetVehicle(builder, _o.Type);
		}

		// Token: 0x04012169 RID: 74089
		private Table __p;
	}
}
