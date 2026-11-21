using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF1 RID: 23537
	public struct INpcSpecialMarkIgnoreCameraHideNpc : IFlatbufferObject
	{
		// Token: 0x1700AC36 RID: 44086
		// (get) Token: 0x06026DE6 RID: 159206 RVA: 0x005523C2 File Offset: 0x005505C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026DE7 RID: 159207 RVA: 0x005523CF File Offset: 0x005505CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026DE8 RID: 159208 RVA: 0x005523D8 File Offset: 0x005505D8
		public static INpcSpecialMarkIgnoreCameraHideNpc GetRootAsINpcSpecialMarkIgnoreCameraHideNpc(ByteBuffer _bb)
		{
			return INpcSpecialMarkIgnoreCameraHideNpc.GetRootAsINpcSpecialMarkIgnoreCameraHideNpc(_bb, default(INpcSpecialMarkIgnoreCameraHideNpc));
		}

		// Token: 0x06026DE9 RID: 159209 RVA: 0x005523F4 File Offset: 0x005505F4
		public static INpcSpecialMarkIgnoreCameraHideNpc GetRootAsINpcSpecialMarkIgnoreCameraHideNpc(ByteBuffer _bb, INpcSpecialMarkIgnoreCameraHideNpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026DEA RID: 159210 RVA: 0x00552411 File Offset: 0x00550611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026DEB RID: 159211 RVA: 0x00552420 File Offset: 0x00550620
		public INpcSpecialMarkIgnoreCameraHideNpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC37 RID: 44087
		// (get) Token: 0x06026DEC RID: 159212 RVA: 0x00552430 File Offset: 0x00550630
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

		// Token: 0x06026DED RID: 159213 RVA: 0x0055246C File Offset: 0x0055066C
		public static Offset<INpcSpecialMarkIgnoreCameraHideNpc> CreateINpcSpecialMarkIgnoreCameraHideNpc(FlatBufferBuilder builder, ESpecialNpcMarkType Type = ESpecialNpcMarkType.TrafficLight)
		{
			builder.StartTable(1);
			INpcSpecialMarkIgnoreCameraHideNpc.AddType(builder, Type);
			return INpcSpecialMarkIgnoreCameraHideNpc.EndINpcSpecialMarkIgnoreCameraHideNpc(builder);
		}

		// Token: 0x06026DEE RID: 159214 RVA: 0x00552482 File Offset: 0x00550682
		public static void StartINpcSpecialMarkIgnoreCameraHideNpc(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026DEF RID: 159215 RVA: 0x0055248B File Offset: 0x0055068B
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026DF0 RID: 159216 RVA: 0x00552496 File Offset: 0x00550696
		public static Offset<INpcSpecialMarkIgnoreCameraHideNpc> EndINpcSpecialMarkIgnoreCameraHideNpc(FlatBufferBuilder builder)
		{
			return new Offset<INpcSpecialMarkIgnoreCameraHideNpc>(builder.EndTable());
		}

		// Token: 0x06026DF1 RID: 159217 RVA: 0x005524A4 File Offset: 0x005506A4
		public INpcSpecialMarkIgnoreCameraHideNpcT UnPack()
		{
			INpcSpecialMarkIgnoreCameraHideNpcT npcSpecialMarkIgnoreCameraHideNpcT = new INpcSpecialMarkIgnoreCameraHideNpcT();
			this.UnPackTo(npcSpecialMarkIgnoreCameraHideNpcT);
			return npcSpecialMarkIgnoreCameraHideNpcT;
		}

		// Token: 0x06026DF2 RID: 159218 RVA: 0x005524BF File Offset: 0x005506BF
		public void UnPackTo(INpcSpecialMarkIgnoreCameraHideNpcT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026DF3 RID: 159219 RVA: 0x005524D0 File Offset: 0x005506D0
		public static Offset<INpcSpecialMarkIgnoreCameraHideNpc> Pack(FlatBufferBuilder builder, INpcSpecialMarkIgnoreCameraHideNpcT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSpecialMarkIgnoreCameraHideNpc>);
			}
			return INpcSpecialMarkIgnoreCameraHideNpc.CreateINpcSpecialMarkIgnoreCameraHideNpc(builder, _o.Type);
		}

		// Token: 0x0400F669 RID: 63081
		private Table __p;
	}
}
