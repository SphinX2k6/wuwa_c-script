using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5D RID: 27485
	public struct ICurrentVehicle : IFlatbufferObject
	{
		// Token: 0x1700C9C3 RID: 51651
		// (get) Token: 0x0602F4C1 RID: 193729 RVA: 0x00674D71 File Offset: 0x00672F71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F4C2 RID: 193730 RVA: 0x00674D7E File Offset: 0x00672F7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F4C3 RID: 193731 RVA: 0x00674D88 File Offset: 0x00672F88
		public static ICurrentVehicle GetRootAsICurrentVehicle(ByteBuffer _bb)
		{
			return ICurrentVehicle.GetRootAsICurrentVehicle(_bb, default(ICurrentVehicle));
		}

		// Token: 0x0602F4C4 RID: 193732 RVA: 0x00674DA4 File Offset: 0x00672FA4
		public static ICurrentVehicle GetRootAsICurrentVehicle(ByteBuffer _bb, ICurrentVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F4C5 RID: 193733 RVA: 0x00674DC1 File Offset: 0x00672FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F4C6 RID: 193734 RVA: 0x00674DD0 File Offset: 0x00672FD0
		public ICurrentVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9C4 RID: 51652
		// (get) Token: 0x0602F4C7 RID: 193735 RVA: 0x00674DE0 File Offset: 0x00672FE0
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

		// Token: 0x0602F4C8 RID: 193736 RVA: 0x00674E1C File Offset: 0x0067301C
		public static Offset<ICurrentVehicle> CreateICurrentVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ICurrentVehicle.AddType(builder, Type);
			return ICurrentVehicle.EndICurrentVehicle(builder);
		}

		// Token: 0x0602F4C9 RID: 193737 RVA: 0x00674E32 File Offset: 0x00673032
		public static void StartICurrentVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F4CA RID: 193738 RVA: 0x00674E3B File Offset: 0x0067303B
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F4CB RID: 193739 RVA: 0x00674E46 File Offset: 0x00673046
		public static Offset<ICurrentVehicle> EndICurrentVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ICurrentVehicle>(builder.EndTable());
		}

		// Token: 0x0602F4CC RID: 193740 RVA: 0x00674E54 File Offset: 0x00673054
		public ICurrentVehicleT UnPack()
		{
			ICurrentVehicleT currentVehicleT = new ICurrentVehicleT();
			this.UnPackTo(currentVehicleT);
			return currentVehicleT;
		}

		// Token: 0x0602F4CD RID: 193741 RVA: 0x00674E6F File Offset: 0x0067306F
		public void UnPackTo(ICurrentVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F4CE RID: 193742 RVA: 0x00674E80 File Offset: 0x00673080
		public static Offset<ICurrentVehicle> Pack(FlatBufferBuilder builder, ICurrentVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICurrentVehicle>);
			}
			return ICurrentVehicle.CreateICurrentVehicle(builder, _o.Type);
		}

		// Token: 0x0401194B RID: 72011
		private Table __p;
	}
}
