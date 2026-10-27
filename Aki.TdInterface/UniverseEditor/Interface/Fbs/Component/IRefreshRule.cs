using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005832 RID: 22578
	public struct IRefreshRule : IFlatbufferObject
	{
		// Token: 0x1700A8A7 RID: 43175
		// (get) Token: 0x06025F97 RID: 155543 RVA: 0x0053C491 File Offset: 0x0053A691
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F98 RID: 155544 RVA: 0x0053C49E File Offset: 0x0053A69E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F99 RID: 155545 RVA: 0x0053C4A8 File Offset: 0x0053A6A8
		public static IRefreshRule GetRootAsIRefreshRule(ByteBuffer _bb)
		{
			return IRefreshRule.GetRootAsIRefreshRule(_bb, default(IRefreshRule));
		}

		// Token: 0x06025F9A RID: 155546 RVA: 0x0053C4C4 File Offset: 0x0053A6C4
		public static IRefreshRule GetRootAsIRefreshRule(ByteBuffer _bb, IRefreshRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F9B RID: 155547 RVA: 0x0053C4E1 File Offset: 0x0053A6E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F9C RID: 155548 RVA: 0x0053C4F0 File Offset: 0x0053A6F0
		public IRefreshRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A8A8 RID: 43176
		// (get) Token: 0x06025F9D RID: 155549 RVA: 0x0053C500 File Offset: 0x0053A700
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

		// Token: 0x06025F9E RID: 155550 RVA: 0x0053C53C File Offset: 0x0053A73C
		public static Offset<IRefreshRule> CreateIRefreshRule(FlatBufferBuilder builder, ERefreshRule Type = ERefreshRule.CD)
		{
			builder.StartTable(1);
			IRefreshRule.AddType(builder, Type);
			return IRefreshRule.EndIRefreshRule(builder);
		}

		// Token: 0x06025F9F RID: 155551 RVA: 0x0053C552 File Offset: 0x0053A752
		public static void StartIRefreshRule(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025FA0 RID: 155552 RVA: 0x0053C55B File Offset: 0x0053A75B
		public static void AddType(FlatBufferBuilder builder, ERefreshRule type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025FA1 RID: 155553 RVA: 0x0053C566 File Offset: 0x0053A766
		public static Offset<IRefreshRule> EndIRefreshRule(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshRule>(builder.EndTable());
		}

		// Token: 0x06025FA2 RID: 155554 RVA: 0x0053C574 File Offset: 0x0053A774
		public IRefreshRuleT UnPack()
		{
			IRefreshRuleT refreshRuleT = new IRefreshRuleT();
			this.UnPackTo(refreshRuleT);
			return refreshRuleT;
		}

		// Token: 0x06025FA3 RID: 155555 RVA: 0x0053C58F File Offset: 0x0053A78F
		public void UnPackTo(IRefreshRuleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025FA4 RID: 155556 RVA: 0x0053C5A0 File Offset: 0x0053A7A0
		public static Offset<IRefreshRule> Pack(FlatBufferBuilder builder, IRefreshRuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshRule>);
			}
			return IRefreshRule.CreateIRefreshRule(builder, _o.Type);
		}

		// Token: 0x0400ED43 RID: 60739
		private Table __p;
	}
}
