using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005656 RID: 22102
	public struct INpcSpecialMarkTrafficLight : IFlatbufferObject
	{
		// Token: 0x1700A3AF RID: 41903
		// (get) Token: 0x06024BD7 RID: 150487 RVA: 0x00511BD1 File Offset: 0x0050FDD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BD8 RID: 150488 RVA: 0x00511BDE File Offset: 0x0050FDDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BD9 RID: 150489 RVA: 0x00511BE8 File Offset: 0x0050FDE8
		public static INpcSpecialMarkTrafficLight GetRootAsINpcSpecialMarkTrafficLight(ByteBuffer _bb)
		{
			return INpcSpecialMarkTrafficLight.GetRootAsINpcSpecialMarkTrafficLight(_bb, default(INpcSpecialMarkTrafficLight));
		}

		// Token: 0x06024BDA RID: 150490 RVA: 0x00511C04 File Offset: 0x0050FE04
		public static INpcSpecialMarkTrafficLight GetRootAsINpcSpecialMarkTrafficLight(ByteBuffer _bb, INpcSpecialMarkTrafficLight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BDB RID: 150491 RVA: 0x00511C21 File Offset: 0x0050FE21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BDC RID: 150492 RVA: 0x00511C30 File Offset: 0x0050FE30
		public INpcSpecialMarkTrafficLight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3B0 RID: 41904
		// (get) Token: 0x06024BDD RID: 150493 RVA: 0x00511C40 File Offset: 0x0050FE40
		public ESpecialNpcMarkType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialNpcMarkType.TrafficLight;
				}
				return (ESpecialNpcMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024BDE RID: 150494 RVA: 0x00511C7C File Offset: 0x0050FE7C
		public static Offset<INpcSpecialMarkTrafficLight> CreateINpcSpecialMarkTrafficLight(FlatBufferBuilder builder, ESpecialNpcMarkType Type = ESpecialNpcMarkType.TrafficLight)
		{
			builder.StartTable(1);
			INpcSpecialMarkTrafficLight.AddType(builder, Type);
			return INpcSpecialMarkTrafficLight.EndINpcSpecialMarkTrafficLight(builder);
		}

		// Token: 0x06024BDF RID: 150495 RVA: 0x00511C92 File Offset: 0x0050FE92
		public static void StartINpcSpecialMarkTrafficLight(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024BE0 RID: 150496 RVA: 0x00511C9B File Offset: 0x0050FE9B
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024BE1 RID: 150497 RVA: 0x00511CA6 File Offset: 0x0050FEA6
		public static Offset<INpcSpecialMarkTrafficLight> EndINpcSpecialMarkTrafficLight(FlatBufferBuilder builder)
		{
			return new Offset<INpcSpecialMarkTrafficLight>(builder.EndTable());
		}

		// Token: 0x06024BE2 RID: 150498 RVA: 0x00511CB4 File Offset: 0x0050FEB4
		public INpcSpecialMarkTrafficLightT UnPack()
		{
			INpcSpecialMarkTrafficLightT npcSpecialMarkTrafficLightT = new INpcSpecialMarkTrafficLightT();
			this.UnPackTo(npcSpecialMarkTrafficLightT);
			return npcSpecialMarkTrafficLightT;
		}

		// Token: 0x06024BE3 RID: 150499 RVA: 0x00511CCF File Offset: 0x0050FECF
		public void UnPackTo(INpcSpecialMarkTrafficLightT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024BE4 RID: 150500 RVA: 0x00511CE0 File Offset: 0x0050FEE0
		public static Offset<INpcSpecialMarkTrafficLight> Pack(FlatBufferBuilder builder, INpcSpecialMarkTrafficLightT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSpecialMarkTrafficLight>);
			}
			return INpcSpecialMarkTrafficLight.CreateINpcSpecialMarkTrafficLight(builder, _o.Type);
		}

		// Token: 0x0400EA05 RID: 59909
		private Table __p;
	}
}
