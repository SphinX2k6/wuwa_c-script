using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F73 RID: 20339
	public struct ICdRefreshRule : IFlatbufferObject
	{
		// Token: 0x170092FD RID: 37629
		// (get) Token: 0x06020483 RID: 132227 RVA: 0x0047DF91 File Offset: 0x0047C191
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020484 RID: 132228 RVA: 0x0047DF9E File Offset: 0x0047C19E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020485 RID: 132229 RVA: 0x0047DFA8 File Offset: 0x0047C1A8
		public static ICdRefreshRule GetRootAsICdRefreshRule(ByteBuffer _bb)
		{
			return ICdRefreshRule.GetRootAsICdRefreshRule(_bb, default(ICdRefreshRule));
		}

		// Token: 0x06020486 RID: 132230 RVA: 0x0047DFC4 File Offset: 0x0047C1C4
		public static ICdRefreshRule GetRootAsICdRefreshRule(ByteBuffer _bb, ICdRefreshRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020487 RID: 132231 RVA: 0x0047DFE1 File Offset: 0x0047C1E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020488 RID: 132232 RVA: 0x0047DFF0 File Offset: 0x0047C1F0
		public ICdRefreshRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092FE RID: 37630
		// (get) Token: 0x06020489 RID: 132233 RVA: 0x0047E000 File Offset: 0x0047C200
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

		// Token: 0x170092FF RID: 37631
		// (get) Token: 0x0602048A RID: 132234 RVA: 0x0047E03C File Offset: 0x0047C23C
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

		// Token: 0x0602048B RID: 132235 RVA: 0x0047E078 File Offset: 0x0047C278
		public static Offset<ICdRefreshRule> CreateICdRefreshRule(FlatBufferBuilder builder, ERefreshRule Type = ERefreshRule.CD, int Cd = 0)
		{
			builder.StartTable(2);
			ICdRefreshRule.AddCd(builder, Cd);
			ICdRefreshRule.AddType(builder, Type);
			return ICdRefreshRule.EndICdRefreshRule(builder);
		}

		// Token: 0x0602048C RID: 132236 RVA: 0x0047E095 File Offset: 0x0047C295
		public static void StartICdRefreshRule(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602048D RID: 132237 RVA: 0x0047E09E File Offset: 0x0047C29E
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602048E RID: 132238 RVA: 0x0047E0A9 File Offset: 0x0047C2A9
		public static void AddCd(FlatBufferBuilder builder, int cd)
		{
			builder.AddInt(1, cd, 0);
		}

		// Token: 0x0602048F RID: 132239 RVA: 0x0047E0B4 File Offset: 0x0047C2B4
		public static Offset<ICdRefreshRule> EndICdRefreshRule(FlatBufferBuilder builder)
		{
			return new Offset<ICdRefreshRule>(builder.EndTable());
		}

		// Token: 0x06020490 RID: 132240 RVA: 0x0047E0C4 File Offset: 0x0047C2C4
		public ICdRefreshRuleT UnPack()
		{
			ICdRefreshRuleT cdRefreshRuleT = new ICdRefreshRuleT();
			this.UnPackTo(cdRefreshRuleT);
			return cdRefreshRuleT;
		}

		// Token: 0x06020491 RID: 132241 RVA: 0x0047E0DF File Offset: 0x0047C2DF
		public void UnPackTo(ICdRefreshRuleT _o)
		{
			_o.Type = this.Type;
			_o.Cd = this.Cd;
		}

		// Token: 0x06020492 RID: 132242 RVA: 0x0047E0FC File Offset: 0x0047C2FC
		public static Offset<ICdRefreshRule> Pack(FlatBufferBuilder builder, ICdRefreshRuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICdRefreshRule>);
			}
			return ICdRefreshRule.CreateICdRefreshRule(builder, _o.Type, _o.Cd);
		}

		// Token: 0x0400DE19 RID: 56857
		private Table __p;
	}
}
