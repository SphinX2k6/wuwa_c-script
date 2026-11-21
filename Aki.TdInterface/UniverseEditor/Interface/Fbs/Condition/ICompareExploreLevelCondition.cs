using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005088 RID: 20616
	public struct ICompareExploreLevelCondition : IFlatbufferObject
	{
		// Token: 0x17009396 RID: 37782
		// (get) Token: 0x060203FA RID: 132090 RVA: 0x004780F8 File Offset: 0x004762F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060203FB RID: 132091 RVA: 0x00478105 File Offset: 0x00476305
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060203FC RID: 132092 RVA: 0x0047810C File Offset: 0x0047630C
		public static ICompareExploreLevelCondition GetRootAsICompareExploreLevelCondition(ByteBuffer _bb)
		{
			return ICompareExploreLevelCondition.GetRootAsICompareExploreLevelCondition(_bb, default(ICompareExploreLevelCondition));
		}

		// Token: 0x060203FD RID: 132093 RVA: 0x00478128 File Offset: 0x00476328
		public static ICompareExploreLevelCondition GetRootAsICompareExploreLevelCondition(ByteBuffer _bb, ICompareExploreLevelCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060203FE RID: 132094 RVA: 0x00478145 File Offset: 0x00476345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060203FF RID: 132095 RVA: 0x00478154 File Offset: 0x00476354
		public ICompareExploreLevelCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009397 RID: 37783
		// (get) Token: 0x06020400 RID: 132096 RVA: 0x00478164 File Offset: 0x00476364
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

		// Token: 0x17009398 RID: 37784
		// (get) Token: 0x06020401 RID: 132097 RVA: 0x004781A0 File Offset: 0x004763A0
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

		// Token: 0x17009399 RID: 37785
		// (get) Token: 0x06020402 RID: 132098 RVA: 0x004781DC File Offset: 0x004763DC
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

		// Token: 0x06020403 RID: 132099 RVA: 0x00478218 File Offset: 0x00476418
		public static Offset<ICompareExploreLevelCondition> CreateICompareExploreLevelCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(3);
			ICompareExploreLevelCondition.AddLevel(builder, Level);
			ICompareExploreLevelCondition.AddCompare(builder, Compare);
			ICompareExploreLevelCondition.AddType(builder, Type);
			return ICompareExploreLevelCondition.EndICompareExploreLevelCondition(builder);
		}

		// Token: 0x06020404 RID: 132100 RVA: 0x0047823C File Offset: 0x0047643C
		public static void StartICompareExploreLevelCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020405 RID: 132101 RVA: 0x00478245 File Offset: 0x00476445
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020406 RID: 132102 RVA: 0x00478250 File Offset: 0x00476450
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020407 RID: 132103 RVA: 0x0047825B File Offset: 0x0047645B
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		// Token: 0x06020408 RID: 132104 RVA: 0x00478266 File Offset: 0x00476466
		public static Offset<ICompareExploreLevelCondition> EndICompareExploreLevelCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareExploreLevelCondition>(builder.EndTable());
		}

		// Token: 0x06020409 RID: 132105 RVA: 0x00478274 File Offset: 0x00476474
		public ICompareExploreLevelConditionT UnPack()
		{
			ICompareExploreLevelConditionT compareExploreLevelConditionT = new ICompareExploreLevelConditionT();
			this.UnPackTo(compareExploreLevelConditionT);
			return compareExploreLevelConditionT;
		}

		// Token: 0x0602040A RID: 132106 RVA: 0x0047828F File Offset: 0x0047648F
		public void UnPackTo(ICompareExploreLevelConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0602040B RID: 132107 RVA: 0x004782B8 File Offset: 0x004764B8
		public static Offset<ICompareExploreLevelCondition> Pack(FlatBufferBuilder builder, ICompareExploreLevelConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareExploreLevelCondition>);
			}
			return ICompareExploreLevelCondition.CreateICompareExploreLevelCondition(builder, _o.Type, _o.Compare, _o.Level);
		}

		// Token: 0x0400DF7E RID: 57214
		private Table __p;
	}
}
