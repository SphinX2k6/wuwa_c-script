using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564D RID: 22093
	public struct INpcSpecialMarkBase : IFlatbufferObject
	{
		// Token: 0x1700A3A7 RID: 41895
		// (get) Token: 0x06024BA5 RID: 150437 RVA: 0x0051179C File Offset: 0x0050F99C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BA6 RID: 150438 RVA: 0x005117A9 File Offset: 0x0050F9A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BA7 RID: 150439 RVA: 0x005117B0 File Offset: 0x0050F9B0
		public static INpcSpecialMarkBase GetRootAsINpcSpecialMarkBase(ByteBuffer _bb)
		{
			return INpcSpecialMarkBase.GetRootAsINpcSpecialMarkBase(_bb, default(INpcSpecialMarkBase));
		}

		// Token: 0x06024BA8 RID: 150440 RVA: 0x005117CC File Offset: 0x0050F9CC
		public static INpcSpecialMarkBase GetRootAsINpcSpecialMarkBase(ByteBuffer _bb, INpcSpecialMarkBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BA9 RID: 150441 RVA: 0x005117E9 File Offset: 0x0050F9E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BAA RID: 150442 RVA: 0x005117F8 File Offset: 0x0050F9F8
		public INpcSpecialMarkBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3A8 RID: 41896
		// (get) Token: 0x06024BAB RID: 150443 RVA: 0x00511808 File Offset: 0x0050FA08
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

		// Token: 0x06024BAC RID: 150444 RVA: 0x00511844 File Offset: 0x0050FA44
		public static Offset<INpcSpecialMarkBase> CreateINpcSpecialMarkBase(FlatBufferBuilder builder, ESpecialNpcMarkType Type = ESpecialNpcMarkType.TrafficLight)
		{
			builder.StartTable(1);
			INpcSpecialMarkBase.AddType(builder, Type);
			return INpcSpecialMarkBase.EndINpcSpecialMarkBase(builder);
		}

		// Token: 0x06024BAD RID: 150445 RVA: 0x0051185A File Offset: 0x0050FA5A
		public static void StartINpcSpecialMarkBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024BAE RID: 150446 RVA: 0x00511863 File Offset: 0x0050FA63
		public static void AddType(FlatBufferBuilder builder, ESpecialNpcMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024BAF RID: 150447 RVA: 0x0051186E File Offset: 0x0050FA6E
		public static Offset<INpcSpecialMarkBase> EndINpcSpecialMarkBase(FlatBufferBuilder builder)
		{
			return new Offset<INpcSpecialMarkBase>(builder.EndTable());
		}

		// Token: 0x06024BB0 RID: 150448 RVA: 0x0051187C File Offset: 0x0050FA7C
		public INpcSpecialMarkBaseT UnPack()
		{
			INpcSpecialMarkBaseT npcSpecialMarkBaseT = new INpcSpecialMarkBaseT();
			this.UnPackTo(npcSpecialMarkBaseT);
			return npcSpecialMarkBaseT;
		}

		// Token: 0x06024BB1 RID: 150449 RVA: 0x00511897 File Offset: 0x0050FA97
		public void UnPackTo(INpcSpecialMarkBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024BB2 RID: 150450 RVA: 0x005118A8 File Offset: 0x0050FAA8
		public static Offset<INpcSpecialMarkBase> Pack(FlatBufferBuilder builder, INpcSpecialMarkBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcSpecialMarkBase>);
			}
			return INpcSpecialMarkBase.CreateINpcSpecialMarkBase(builder, _o.Type);
		}

		// Token: 0x0400E9FA RID: 59898
		private Table __p;
	}
}
