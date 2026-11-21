using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C71 RID: 31857
	public struct ITriggeredVehicle : IFlatbufferObject
	{
		// Token: 0x1700EE84 RID: 61060
		// (get) Token: 0x06039701 RID: 235265 RVA: 0x007C113D File Offset: 0x007BF33D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039702 RID: 235266 RVA: 0x007C114A File Offset: 0x007BF34A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039703 RID: 235267 RVA: 0x007C1154 File Offset: 0x007BF354
		public static ITriggeredVehicle GetRootAsITriggeredVehicle(ByteBuffer _bb)
		{
			return ITriggeredVehicle.GetRootAsITriggeredVehicle(_bb, default(ITriggeredVehicle));
		}

		// Token: 0x06039704 RID: 235268 RVA: 0x007C1170 File Offset: 0x007BF370
		public static ITriggeredVehicle GetRootAsITriggeredVehicle(ByteBuffer _bb, ITriggeredVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039705 RID: 235269 RVA: 0x007C118D File Offset: 0x007BF38D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039706 RID: 235270 RVA: 0x007C119C File Offset: 0x007BF39C
		public ITriggeredVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE85 RID: 61061
		// (get) Token: 0x06039707 RID: 235271 RVA: 0x007C11AC File Offset: 0x007BF3AC
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

		// Token: 0x06039708 RID: 235272 RVA: 0x007C11E8 File Offset: 0x007BF3E8
		public static Offset<ITriggeredVehicle> CreateITriggeredVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			ITriggeredVehicle.AddType(builder, Type);
			return ITriggeredVehicle.EndITriggeredVehicle(builder);
		}

		// Token: 0x06039709 RID: 235273 RVA: 0x007C11FE File Offset: 0x007BF3FE
		public static void StartITriggeredVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603970A RID: 235274 RVA: 0x007C1207 File Offset: 0x007BF407
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603970B RID: 235275 RVA: 0x007C1212 File Offset: 0x007BF412
		public static Offset<ITriggeredVehicle> EndITriggeredVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredVehicle>(builder.EndTable());
		}

		// Token: 0x0603970C RID: 235276 RVA: 0x007C1220 File Offset: 0x007BF420
		public ITriggeredVehicleT UnPack()
		{
			ITriggeredVehicleT triggeredVehicleT = new ITriggeredVehicleT();
			this.UnPackTo(triggeredVehicleT);
			return triggeredVehicleT;
		}

		// Token: 0x0603970D RID: 235277 RVA: 0x007C123B File Offset: 0x007BF43B
		public void UnPackTo(ITriggeredVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603970E RID: 235278 RVA: 0x007C124C File Offset: 0x007BF44C
		public static Offset<ITriggeredVehicle> Pack(FlatBufferBuilder builder, ITriggeredVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredVehicle>);
			}
			return ITriggeredVehicle.CreateITriggeredVehicle(builder, _o.Type);
		}

		// Token: 0x0401333B RID: 78651
		private Table __p;
	}
}
