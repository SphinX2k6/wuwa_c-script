using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BEB RID: 23531
	public struct INpcSpecialMarkBase : IFlatbufferObject
	{
		// Token: 0x1700AC31 RID: 44081
		// (get) Token: 0x06026DC4 RID: 159172 RVA: 0x005520C0 File Offset: 0x005502C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026DC5 RID: 159173 RVA: 0x005520CD File Offset: 0x005502CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026DC6 RID: 159174 RVA: 0x005520D4 File Offset: 0x005502D4
		public static INpcSpecialMarkBase GetRootAsINpcSpecialMarkBase(ByteBuffer _bb)
		{
			return INpcSpecialMarkBase.GetRootAsINpcSpecialMarkBase(_bb, default(INpcSpecialMarkBase));
		}

		// Token: 0x06026DC7 RID: 159175 RVA: 0x005520F0 File Offset: 0x005502F0
		public static INpcSpecialMarkBase GetRootAsINpcSpecialMarkBase(ByteBuffer _bb, INpcSpecialMarkBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026DC8 RID: 159176 RVA: 0x0055210D File Offset: 0x0055030D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026DC9 RID: 159177 RVA: 0x0055211C File Offset: 0x0055031C
		public INpcSpecialMarkBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC32 RID: 44082
		// (get) Token: 0x06026DCA RID: 159178 RVA: 0x0055212C File Offset: 0x0055032C
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

		// Token: 0x06026DCB RID: 159179 RVA: 0x00552168 File Offset: 0x00550368
		public static Offset<INpcSpecialMarkBase> CreateINpcSpecialMarkBase(FlatBufferBuilder builder, ESpecialNpcMarkType Type = ESpecialNpcMarkType.TrafficLight)
		{
			builder.StartTable(1);
			INpcSpecialMarkBase.AddType(builder, Type);
			return INpcSpecialMarkBase.EndINpcSpecialMarkBase(builder);
		}

		// Token: 0x06026DCC RID: 159180 RVA: 0x0055217E File Offset: 0x0055037E
		public static void StartINpcSpecialMarkBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026DCD RID: 159181 RVA: 0x00552187 File Offset: 0x00550387
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026DCE RID: 159182 RVA: 0x00552192 File Offset: 0x00550392
		public static Offset<INpcSpecialMarkBase> EndINpcSpecialMarkBase(FlatBufferBuilder builder)
		{
			return new Offset<INpcSpecialMarkBase>(builder.EndTable());
		}

		// Token: 0x06026DCF RID: 159183 RVA: 0x005521A0 File Offset: 0x005503A0
		public INpcSpecialMarkBaseT UnPack()
		{
			INpcSpecialMarkBaseT npcSpecialMarkBaseT = new INpcSpecialMarkBaseT();
			this.UnPackTo(npcSpecialMarkBaseT);
			return npcSpecialMarkBaseT;
		}

		// Token: 0x06026DD0 RID: 159184 RVA: 0x005521BB File Offset: 0x005503BB
		public void UnPackTo(INpcSpecialMarkBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026DD1 RID: 159185 RVA: 0x005521CC File Offset: 0x005503CC
		public static Offset<INpcSpecialMarkBase> Pack(FlatBufferBuilder builder, INpcSpecialMarkBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSpecialMarkBase>);
			}
			return INpcSpecialMarkBase.CreateINpcSpecialMarkBase(builder, _o.Type);
		}

		// Token: 0x0400F65F RID: 63071
		private Table __p;
	}
}
