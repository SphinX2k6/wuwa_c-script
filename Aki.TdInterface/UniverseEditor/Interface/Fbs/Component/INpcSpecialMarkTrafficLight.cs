using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF4 RID: 23540
	public struct INpcSpecialMarkTrafficLight : IFlatbufferObject
	{
		// Token: 0x1700AC39 RID: 44089
		// (get) Token: 0x06026DF8 RID: 159224 RVA: 0x00552539 File Offset: 0x00550739
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026DF9 RID: 159225 RVA: 0x00552546 File Offset: 0x00550746
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026DFA RID: 159226 RVA: 0x00552550 File Offset: 0x00550750
		public static INpcSpecialMarkTrafficLight GetRootAsINpcSpecialMarkTrafficLight(ByteBuffer _bb)
		{
			return INpcSpecialMarkTrafficLight.GetRootAsINpcSpecialMarkTrafficLight(_bb, default(INpcSpecialMarkTrafficLight));
		}

		// Token: 0x06026DFB RID: 159227 RVA: 0x0055256C File Offset: 0x0055076C
		public static INpcSpecialMarkTrafficLight GetRootAsINpcSpecialMarkTrafficLight(ByteBuffer _bb, INpcSpecialMarkTrafficLight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026DFC RID: 159228 RVA: 0x00552589 File Offset: 0x00550789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026DFD RID: 159229 RVA: 0x00552598 File Offset: 0x00550798
		public INpcSpecialMarkTrafficLight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC3A RID: 44090
		// (get) Token: 0x06026DFE RID: 159230 RVA: 0x005525A8 File Offset: 0x005507A8
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

		// Token: 0x06026DFF RID: 159231 RVA: 0x005525E4 File Offset: 0x005507E4
		public static Offset<INpcSpecialMarkTrafficLight> CreateINpcSpecialMarkTrafficLight(FlatBufferBuilder builder, ESpecialNpcMarkType Type = ESpecialNpcMarkType.TrafficLight)
		{
			builder.StartTable(1);
			INpcSpecialMarkTrafficLight.AddType(builder, Type);
			return INpcSpecialMarkTrafficLight.EndINpcSpecialMarkTrafficLight(builder);
		}

		// Token: 0x06026E00 RID: 159232 RVA: 0x005525FA File Offset: 0x005507FA
		public static void StartINpcSpecialMarkTrafficLight(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026E01 RID: 159233 RVA: 0x00552603 File Offset: 0x00550803
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026E02 RID: 159234 RVA: 0x0055260E File Offset: 0x0055080E
		public static Offset<INpcSpecialMarkTrafficLight> EndINpcSpecialMarkTrafficLight(FlatBufferBuilder builder)
		{
			return new Offset<INpcSpecialMarkTrafficLight>(builder.EndTable());
		}

		// Token: 0x06026E03 RID: 159235 RVA: 0x0055261C File Offset: 0x0055081C
		public INpcSpecialMarkTrafficLightT UnPack()
		{
			INpcSpecialMarkTrafficLightT npcSpecialMarkTrafficLightT = new INpcSpecialMarkTrafficLightT();
			this.UnPackTo(npcSpecialMarkTrafficLightT);
			return npcSpecialMarkTrafficLightT;
		}

		// Token: 0x06026E04 RID: 159236 RVA: 0x00552637 File Offset: 0x00550837
		public void UnPackTo(INpcSpecialMarkTrafficLightT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026E05 RID: 159237 RVA: 0x00552648 File Offset: 0x00550848
		public static Offset<INpcSpecialMarkTrafficLight> Pack(FlatBufferBuilder builder, INpcSpecialMarkTrafficLightT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSpecialMarkTrafficLight>);
			}
			return INpcSpecialMarkTrafficLight.CreateINpcSpecialMarkTrafficLight(builder, _o.Type);
		}

		// Token: 0x0400F66B RID: 63083
		private Table __p;
	}
}
