using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B9E RID: 19358
	public struct ICompareExploreLevelCondition : IFlatbufferObject
	{
		// Token: 0x17008C7D RID: 35965
		// (get) Token: 0x0601E84E RID: 125006 RVA: 0x00445594 File Offset: 0x00443794
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E84F RID: 125007 RVA: 0x004455A1 File Offset: 0x004437A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E850 RID: 125008 RVA: 0x004455A8 File Offset: 0x004437A8
		public static ICompareExploreLevelCondition GetRootAsICompareExploreLevelCondition(ByteBuffer _bb)
		{
			return ICompareExploreLevelCondition.GetRootAsICompareExploreLevelCondition(_bb, default(ICompareExploreLevelCondition));
		}

		// Token: 0x0601E851 RID: 125009 RVA: 0x004455C4 File Offset: 0x004437C4
		public static ICompareExploreLevelCondition GetRootAsICompareExploreLevelCondition(ByteBuffer _bb, ICompareExploreLevelCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E852 RID: 125010 RVA: 0x004455E1 File Offset: 0x004437E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E853 RID: 125011 RVA: 0x004455F0 File Offset: 0x004437F0
		public ICompareExploreLevelCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C7E RID: 35966
		// (get) Token: 0x0601E854 RID: 125012 RVA: 0x00445600 File Offset: 0x00443800
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

		// Token: 0x17008C7F RID: 35967
		// (get) Token: 0x0601E855 RID: 125013 RVA: 0x0044563C File Offset: 0x0044383C
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

		// Token: 0x17008C80 RID: 35968
		// (get) Token: 0x0601E856 RID: 125014 RVA: 0x00445678 File Offset: 0x00443878
		public int Level
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

		// Token: 0x0601E857 RID: 125015 RVA: 0x004456B4 File Offset: 0x004438B4
		public static Offset<ICompareExploreLevelCondition> CreateICompareExploreLevelCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(3);
			ICompareExploreLevelCondition.AddLevel(builder, Level);
			ICompareExploreLevelCondition.AddCompare(builder, Compare);
			ICompareExploreLevelCondition.AddType(builder, Type);
			return ICompareExploreLevelCondition.EndICompareExploreLevelCondition(builder);
		}

		// Token: 0x0601E858 RID: 125016 RVA: 0x004456D8 File Offset: 0x004438D8
		public static void StartICompareExploreLevelCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E859 RID: 125017 RVA: 0x004456E1 File Offset: 0x004438E1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E85A RID: 125018 RVA: 0x004456EC File Offset: 0x004438EC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E85B RID: 125019 RVA: 0x004456F7 File Offset: 0x004438F7
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		// Token: 0x0601E85C RID: 125020 RVA: 0x00445702 File Offset: 0x00443902
		public static Offset<ICompareExploreLevelCondition> EndICompareExploreLevelCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareExploreLevelCondition>(builder.EndTable());
		}

		// Token: 0x0601E85D RID: 125021 RVA: 0x00445710 File Offset: 0x00443910
		public ICompareExploreLevelConditionT UnPack()
		{
			ICompareExploreLevelConditionT compareExploreLevelConditionT = new ICompareExploreLevelConditionT();
			this.UnPackTo(compareExploreLevelConditionT);
			return compareExploreLevelConditionT;
		}

		// Token: 0x0601E85E RID: 125022 RVA: 0x0044572B File Offset: 0x0044392B
		public void UnPackTo(ICompareExploreLevelConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601E85F RID: 125023 RVA: 0x00445754 File Offset: 0x00443954
		public static Offset<ICompareExploreLevelCondition> Pack(FlatBufferBuilder builder, ICompareExploreLevelConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareExploreLevelCondition>);
			}
			return ICompareExploreLevelCondition.CreateICompareExploreLevelCondition(builder, _o.Type, _o.Compare, _o.Level);
		}

		// Token: 0x0400D479 RID: 54393
		private Table __p;
	}
}
