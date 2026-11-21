using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFF RID: 23295
	public class IMonsterChooseType_UnionUnion
	{
		// Token: 0x1700AA04 RID: 43524
		// (get) Token: 0x06026476 RID: 156790 RVA: 0x0053EA01 File Offset: 0x0053CC01
		// (set) Token: 0x06026477 RID: 156791 RVA: 0x0053EA09 File Offset: 0x0053CC09
		public IMonsterChooseType_Union Type { get; set; }

		// Token: 0x1700AA05 RID: 43525
		// (get) Token: 0x06026478 RID: 156792 RVA: 0x0053EA12 File Offset: 0x0053CC12
		// (set) Token: 0x06026479 RID: 156793 RVA: 0x0053EA1A File Offset: 0x0053CC1A
		public object Value { get; set; }

		// Token: 0x0602647A RID: 156794 RVA: 0x0053EA23 File Offset: 0x0053CC23
		public IMonsterChooseType_UnionUnion()
		{
			this.Type = IMonsterChooseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602647B RID: 156795 RVA: 0x0053EA39 File Offset: 0x0053CC39
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602647C RID: 156796 RVA: 0x0053EA4B File Offset: 0x0053CC4B
		public IMonsterChooseTypeT AsIMonsterChooseType()
		{
			return this.As<IMonsterChooseTypeT>();
		}

		// Token: 0x0602647D RID: 156797 RVA: 0x0053EA53 File Offset: 0x0053CC53
		public static IMonsterChooseType_UnionUnion FromIMonsterChooseType(IMonsterChooseTypeT _imonsterchoosetype)
		{
			return new IMonsterChooseType_UnionUnion
			{
				Type = IMonsterChooseType_Union.IMonsterChooseType,
				Value = _imonsterchoosetype
			};
		}

		// Token: 0x0602647E RID: 156798 RVA: 0x0053EA68 File Offset: 0x0053CC68
		public IRandomPoolChooseT AsIRandomPoolChoose()
		{
			return this.As<IRandomPoolChooseT>();
		}

		// Token: 0x0602647F RID: 156799 RVA: 0x0053EA70 File Offset: 0x0053CC70
		public static IMonsterChooseType_UnionUnion FromIRandomPoolChoose(IRandomPoolChooseT _irandompoolchoose)
		{
			return new IMonsterChooseType_UnionUnion
			{
				Type = IMonsterChooseType_Union.IRandomPoolChoose,
				Value = _irandompoolchoose
			};
		}

		// Token: 0x06026480 RID: 156800 RVA: 0x0053EA88 File Offset: 0x0053CC88
		public static int Pack(FlatBufferBuilder builder, IMonsterChooseType_UnionUnion _o)
		{
			IMonsterChooseType_Union type = _o.Type;
			if (type == IMonsterChooseType_Union.IMonsterChooseType)
			{
				return IMonsterChooseType.Pack(builder, _o.AsIMonsterChooseType()).Value;
			}
			if (type != IMonsterChooseType_Union.IRandomPoolChoose)
			{
				return 0;
			}
			return IRandomPoolChoose.Pack(builder, _o.AsIRandomPoolChoose()).Value;
		}
	}
}
