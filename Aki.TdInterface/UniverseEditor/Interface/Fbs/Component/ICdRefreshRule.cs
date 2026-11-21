using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A2 RID: 21666
	public struct ICdRefreshRule : IFlatbufferObject
	{
		// Token: 0x17009A76 RID: 39542
		// (get) Token: 0x060221D5 RID: 139733 RVA: 0x004B3F81 File Offset: 0x004B2181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060221D6 RID: 139734 RVA: 0x004B3F8E File Offset: 0x004B218E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060221D7 RID: 139735 RVA: 0x004B3F98 File Offset: 0x004B2198
		public static ICdRefreshRule GetRootAsICdRefreshRule(ByteBuffer _bb)
		{
			return ICdRefreshRule.GetRootAsICdRefreshRule(_bb, default(ICdRefreshRule));
		}

		// Token: 0x060221D8 RID: 139736 RVA: 0x004B3FB4 File Offset: 0x004B21B4
		public static ICdRefreshRule GetRootAsICdRefreshRule(ByteBuffer _bb, ICdRefreshRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060221D9 RID: 139737 RVA: 0x004B3FD1 File Offset: 0x004B21D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060221DA RID: 139738 RVA: 0x004B3FE0 File Offset: 0x004B21E0
		public ICdRefreshRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A77 RID: 39543
		// (get) Token: 0x060221DB RID: 139739 RVA: 0x004B3FF0 File Offset: 0x004B21F0
		public ERefreshRule Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefreshRule.CD;
				}
				return (ERefreshRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009A78 RID: 39544
		// (get) Token: 0x060221DC RID: 139740 RVA: 0x004B402C File Offset: 0x004B222C
		public int Cd
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

		// Token: 0x060221DD RID: 139741 RVA: 0x004B4068 File Offset: 0x004B2268
		public static Offset<ICdRefreshRule> CreateICdRefreshRule(FlatBufferBuilder builder, ERefreshRule Type = ERefreshRule.CD, int Cd = 0)
		{
			builder.StartTable(2);
			ICdRefreshRule.AddCd(builder, Cd);
			ICdRefreshRule.AddType(builder, Type);
			return ICdRefreshRule.EndICdRefreshRule(builder);
		}

		// Token: 0x060221DE RID: 139742 RVA: 0x004B4085 File Offset: 0x004B2285
		public static void StartICdRefreshRule(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060221DF RID: 139743 RVA: 0x004B408E File Offset: 0x004B228E
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060221E0 RID: 139744 RVA: 0x004B4099 File Offset: 0x004B2299
		public static void AddCd(FlatBufferBuilder builder, int cd)
		{
			builder.AddInt(1, cd, 0);
		}

		// Token: 0x060221E1 RID: 139745 RVA: 0x004B40A4 File Offset: 0x004B22A4
		public static Offset<ICdRefreshRule> EndICdRefreshRule(FlatBufferBuilder builder)
		{
			return new Offset<ICdRefreshRule>(builder.EndTable());
		}

		// Token: 0x060221E2 RID: 139746 RVA: 0x004B40B4 File Offset: 0x004B22B4
		public ICdRefreshRuleT UnPack()
		{
			ICdRefreshRuleT cdRefreshRuleT = new ICdRefreshRuleT();
			this.UnPackTo(cdRefreshRuleT);
			return cdRefreshRuleT;
		}

		// Token: 0x060221E3 RID: 139747 RVA: 0x004B40CF File Offset: 0x004B22CF
		public void UnPackTo(ICdRefreshRuleT _o)
		{
			_o.Type = this.Type;
			_o.Cd = this.Cd;
		}

		// Token: 0x060221E4 RID: 139748 RVA: 0x004B40EC File Offset: 0x004B22EC
		public static Offset<ICdRefreshRule> Pack(FlatBufferBuilder builder, ICdRefreshRuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICdRefreshRule>);
			}
			return ICdRefreshRule.CreateICdRefreshRule(builder, _o.Type, _o.Cd);
		}

		// Token: 0x0400E9C3 RID: 59843
		private Table __p;
	}
}
