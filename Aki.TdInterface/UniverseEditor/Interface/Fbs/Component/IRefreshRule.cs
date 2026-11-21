using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E39 RID: 24121
	public struct IRefreshRule : IFlatbufferObject
	{
		// Token: 0x1700B1CB RID: 45515
		// (get) Token: 0x060284B7 RID: 165047 RVA: 0x0058261D File Offset: 0x0058081D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060284B8 RID: 165048 RVA: 0x0058262A File Offset: 0x0058082A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060284B9 RID: 165049 RVA: 0x00582634 File Offset: 0x00580834
		public static IRefreshRule GetRootAsIRefreshRule(ByteBuffer _bb)
		{
			return IRefreshRule.GetRootAsIRefreshRule(_bb, default(IRefreshRule));
		}

		// Token: 0x060284BA RID: 165050 RVA: 0x00582650 File Offset: 0x00580850
		public static IRefreshRule GetRootAsIRefreshRule(ByteBuffer _bb, IRefreshRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060284BB RID: 165051 RVA: 0x0058266D File Offset: 0x0058086D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060284BC RID: 165052 RVA: 0x0058267C File Offset: 0x0058087C
		public IRefreshRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1CC RID: 45516
		// (get) Token: 0x060284BD RID: 165053 RVA: 0x0058268C File Offset: 0x0058088C
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

		// Token: 0x060284BE RID: 165054 RVA: 0x005826C8 File Offset: 0x005808C8
		public static Offset<IRefreshRule> CreateIRefreshRule(FlatBufferBuilder builder, ERefreshRule Type = ERefreshRule.CD)
		{
			builder.StartTable(1);
			IRefreshRule.AddType(builder, Type);
			return IRefreshRule.EndIRefreshRule(builder);
		}

		// Token: 0x060284BF RID: 165055 RVA: 0x005826DE File Offset: 0x005808DE
		public static void StartIRefreshRule(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060284C0 RID: 165056 RVA: 0x005826E7 File Offset: 0x005808E7
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060284C1 RID: 165057 RVA: 0x005826F2 File Offset: 0x005808F2
		public static Offset<IRefreshRule> EndIRefreshRule(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshRule>(builder.EndTable());
		}

		// Token: 0x060284C2 RID: 165058 RVA: 0x00582700 File Offset: 0x00580900
		public IRefreshRuleT UnPack()
		{
			IRefreshRuleT refreshRuleT = new IRefreshRuleT();
			this.UnPackTo(refreshRuleT);
			return refreshRuleT;
		}

		// Token: 0x060284C3 RID: 165059 RVA: 0x0058271B File Offset: 0x0058091B
		public void UnPackTo(IRefreshRuleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060284C4 RID: 165060 RVA: 0x0058272C File Offset: 0x0058092C
		public static Offset<IRefreshRule> Pack(FlatBufferBuilder builder, IRefreshRuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshRule>);
			}
			return IRefreshRule.CreateIRefreshRule(builder, _o.Type);
		}

		// Token: 0x0400FA2E RID: 64046
		private Table __p;
	}
}
