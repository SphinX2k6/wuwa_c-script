using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B86 RID: 19334
	public struct ICompareCalabashLevelCondition : IFlatbufferObject
	{
		// Token: 0x17008C50 RID: 35920
		// (get) Token: 0x0601E790 RID: 124816 RVA: 0x004442C9 File Offset: 0x004424C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E791 RID: 124817 RVA: 0x004442D6 File Offset: 0x004424D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E792 RID: 124818 RVA: 0x004442E0 File Offset: 0x004424E0
		public static ICompareCalabashLevelCondition GetRootAsICompareCalabashLevelCondition(ByteBuffer _bb)
		{
			return ICompareCalabashLevelCondition.GetRootAsICompareCalabashLevelCondition(_bb, default(ICompareCalabashLevelCondition));
		}

		// Token: 0x0601E793 RID: 124819 RVA: 0x004442FC File Offset: 0x004424FC
		public static ICompareCalabashLevelCondition GetRootAsICompareCalabashLevelCondition(ByteBuffer _bb, ICompareCalabashLevelCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E794 RID: 124820 RVA: 0x00444319 File Offset: 0x00442519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E795 RID: 124821 RVA: 0x00444328 File Offset: 0x00442528
		public ICompareCalabashLevelCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C51 RID: 35921
		// (get) Token: 0x0601E796 RID: 124822 RVA: 0x00444338 File Offset: 0x00442538
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C52 RID: 35922
		// (get) Token: 0x0601E797 RID: 124823 RVA: 0x00444374 File Offset: 0x00442574
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C53 RID: 35923
		// (get) Token: 0x0601E798 RID: 124824 RVA: 0x004443B0 File Offset: 0x004425B0
		public int CalabashLevel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E799 RID: 124825 RVA: 0x004443EC File Offset: 0x004425EC
		public static Offset<ICompareCalabashLevelCondition> CreateICompareCalabashLevelCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int CalabashLevel = 0)
		{
			builder.StartTable(3);
			ICompareCalabashLevelCondition.AddCalabashLevel(builder, CalabashLevel);
			ICompareCalabashLevelCondition.AddCompare(builder, Compare);
			ICompareCalabashLevelCondition.AddType(builder, Type);
			return ICompareCalabashLevelCondition.EndICompareCalabashLevelCondition(builder);
		}

		// Token: 0x0601E79A RID: 124826 RVA: 0x00444410 File Offset: 0x00442610
		public static void StartICompareCalabashLevelCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E79B RID: 124827 RVA: 0x00444419 File Offset: 0x00442619
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E79C RID: 124828 RVA: 0x00444424 File Offset: 0x00442624
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E79D RID: 124829 RVA: 0x0044442F File Offset: 0x0044262F
		public static void AddCalabashLevel(FlatBufferBuilder builder, int calabashLevel)
		{
			builder.AddInt(2, calabashLevel, 0);
		}

		// Token: 0x0601E79E RID: 124830 RVA: 0x0044443A File Offset: 0x0044263A
		public static Offset<ICompareCalabashLevelCondition> EndICompareCalabashLevelCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareCalabashLevelCondition>(builder.EndTable());
		}

		// Token: 0x0601E79F RID: 124831 RVA: 0x00444448 File Offset: 0x00442648
		public ICompareCalabashLevelConditionT UnPack()
		{
			ICompareCalabashLevelConditionT compareCalabashLevelConditionT = new ICompareCalabashLevelConditionT();
			this.UnPackTo(compareCalabashLevelConditionT);
			return compareCalabashLevelConditionT;
		}

		// Token: 0x0601E7A0 RID: 124832 RVA: 0x00444463 File Offset: 0x00442663
		public void UnPackTo(ICompareCalabashLevelConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.CalabashLevel = this.CalabashLevel;
		}

		// Token: 0x0601E7A1 RID: 124833 RVA: 0x0044448C File Offset: 0x0044268C
		public static Offset<ICompareCalabashLevelCondition> Pack(FlatBufferBuilder builder, ICompareCalabashLevelConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareCalabashLevelCondition>);
			}
			return ICompareCalabashLevelCondition.CreateICompareCalabashLevelCondition(builder, _o.Type, _o.Compare, _o.CalabashLevel);
		}

		// Token: 0x0400D458 RID: 54360
		private Table __p;
	}
}
