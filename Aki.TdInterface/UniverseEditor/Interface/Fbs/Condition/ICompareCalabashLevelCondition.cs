using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200506D RID: 20589
	public struct ICompareCalabashLevelCondition : IFlatbufferObject
	{
		// Token: 0x17009360 RID: 37728
		// (get) Token: 0x0602031E RID: 131870 RVA: 0x00476B15 File Offset: 0x00474D15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602031F RID: 131871 RVA: 0x00476B22 File Offset: 0x00474D22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020320 RID: 131872 RVA: 0x00476B2C File Offset: 0x00474D2C
		public static ICompareCalabashLevelCondition GetRootAsICompareCalabashLevelCondition(ByteBuffer _bb)
		{
			return ICompareCalabashLevelCondition.GetRootAsICompareCalabashLevelCondition(_bb, default(ICompareCalabashLevelCondition));
		}

		// Token: 0x06020321 RID: 131873 RVA: 0x00476B48 File Offset: 0x00474D48
		public static ICompareCalabashLevelCondition GetRootAsICompareCalabashLevelCondition(ByteBuffer _bb, ICompareCalabashLevelCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020322 RID: 131874 RVA: 0x00476B65 File Offset: 0x00474D65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020323 RID: 131875 RVA: 0x00476B74 File Offset: 0x00474D74
		public ICompareCalabashLevelCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009361 RID: 37729
		// (get) Token: 0x06020324 RID: 131876 RVA: 0x00476B84 File Offset: 0x00474D84
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

		// Token: 0x17009362 RID: 37730
		// (get) Token: 0x06020325 RID: 131877 RVA: 0x00476BC0 File Offset: 0x00474DC0
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

		// Token: 0x17009363 RID: 37731
		// (get) Token: 0x06020326 RID: 131878 RVA: 0x00476BFC File Offset: 0x00474DFC
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

		// Token: 0x06020327 RID: 131879 RVA: 0x00476C38 File Offset: 0x00474E38
		public static Offset<ICompareCalabashLevelCondition> CreateICompareCalabashLevelCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int CalabashLevel = 0)
		{
			builder.StartTable(3);
			ICompareCalabashLevelCondition.AddCalabashLevel(builder, CalabashLevel);
			ICompareCalabashLevelCondition.AddCompare(builder, Compare);
			ICompareCalabashLevelCondition.AddType(builder, Type);
			return ICompareCalabashLevelCondition.EndICompareCalabashLevelCondition(builder);
		}

		// Token: 0x06020328 RID: 131880 RVA: 0x00476C5C File Offset: 0x00474E5C
		public static void StartICompareCalabashLevelCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020329 RID: 131881 RVA: 0x00476C65 File Offset: 0x00474E65
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602032A RID: 131882 RVA: 0x00476C70 File Offset: 0x00474E70
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0602032B RID: 131883 RVA: 0x00476C7B File Offset: 0x00474E7B
		public static void AddCalabashLevel(FlatBufferBuilder builder, int calabashLevel)
		{
			builder.AddInt(2, calabashLevel, 0);
		}

		// Token: 0x0602032C RID: 131884 RVA: 0x00476C86 File Offset: 0x00474E86
		public static Offset<ICompareCalabashLevelCondition> EndICompareCalabashLevelCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareCalabashLevelCondition>(builder.EndTable());
		}

		// Token: 0x0602032D RID: 131885 RVA: 0x00476C94 File Offset: 0x00474E94
		public ICompareCalabashLevelConditionT UnPack()
		{
			ICompareCalabashLevelConditionT compareCalabashLevelConditionT = new ICompareCalabashLevelConditionT();
			this.UnPackTo(compareCalabashLevelConditionT);
			return compareCalabashLevelConditionT;
		}

		// Token: 0x0602032E RID: 131886 RVA: 0x00476CAF File Offset: 0x00474EAF
		public void UnPackTo(ICompareCalabashLevelConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.CalabashLevel = this.CalabashLevel;
		}

		// Token: 0x0602032F RID: 131887 RVA: 0x00476CD8 File Offset: 0x00474ED8
		public static Offset<ICompareCalabashLevelCondition> Pack(FlatBufferBuilder builder, ICompareCalabashLevelConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareCalabashLevelCondition>);
			}
			return ICompareCalabashLevelCondition.CreateICompareCalabashLevelCondition(builder, _o.Type, _o.Compare, _o.CalabashLevel);
		}

		// Token: 0x0400DF58 RID: 57176
		private Table __p;
	}
}
