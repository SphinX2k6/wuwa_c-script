using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A44 RID: 23108
	public class ITeleControlDestroyCondition_UnionUnion
	{
		// Token: 0x1700ADD7 RID: 44503
		// (get) Token: 0x060274B4 RID: 160948 RVA: 0x00568415 File Offset: 0x00566615
		// (set) Token: 0x060274B5 RID: 160949 RVA: 0x0056841D File Offset: 0x0056661D
		public ITeleControlDestroyCondition_Union Type { get; set; }

		// Token: 0x1700ADD8 RID: 44504
		// (get) Token: 0x060274B6 RID: 160950 RVA: 0x00568426 File Offset: 0x00566626
		// (set) Token: 0x060274B7 RID: 160951 RVA: 0x0056842E File Offset: 0x0056662E
		public object Value { get; set; }

		// Token: 0x060274B8 RID: 160952 RVA: 0x00568437 File Offset: 0x00566637
		public ITeleControlDestroyCondition_UnionUnion()
		{
			this.Type = ITeleControlDestroyCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060274B9 RID: 160953 RVA: 0x0056844D File Offset: 0x0056664D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060274BA RID: 160954 RVA: 0x0056845F File Offset: 0x0056665F
		public ITeleControlDestroyConditionT AsITeleControlDestroyCondition()
		{
			return this.As<ITeleControlDestroyConditionT>();
		}

		// Token: 0x060274BB RID: 160955 RVA: 0x00568467 File Offset: 0x00566667
		public static ITeleControlDestroyCondition_UnionUnion FromITeleControlDestroyCondition(ITeleControlDestroyConditionT _itelecontroldestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.ITeleControlDestroyCondition,
				Value = _itelecontroldestroycondition
			};
		}

		// Token: 0x060274BC RID: 160956 RVA: 0x0056847C File Offset: 0x0056667C
		public ILetGoDestroyConditionT AsILetGoDestroyCondition()
		{
			return this.As<ILetGoDestroyConditionT>();
		}

		// Token: 0x060274BD RID: 160957 RVA: 0x00568484 File Offset: 0x00566684
		public static ITeleControlDestroyCondition_UnionUnion FromILetGoDestroyCondition(ILetGoDestroyConditionT _iletgodestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.ILetGoDestroyCondition,
				Value = _iletgodestroycondition
			};
		}

		// Token: 0x060274BE RID: 160958 RVA: 0x00568499 File Offset: 0x00566699
		public ICreateBulletDestroyConditionT AsICreateBulletDestroyCondition()
		{
			return this.As<ICreateBulletDestroyConditionT>();
		}

		// Token: 0x060274BF RID: 160959 RVA: 0x005684A1 File Offset: 0x005666A1
		public static ITeleControlDestroyCondition_UnionUnion FromICreateBulletDestroyCondition(ICreateBulletDestroyConditionT _icreatebulletdestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.ICreateBulletDestroyCondition,
				Value = _icreatebulletdestroycondition
			};
		}

		// Token: 0x060274C0 RID: 160960 RVA: 0x005684B6 File Offset: 0x005666B6
		public IThrowDestroyConditionT AsIThrowDestroyCondition()
		{
			return this.As<IThrowDestroyConditionT>();
		}

		// Token: 0x060274C1 RID: 160961 RVA: 0x005684BE File Offset: 0x005666BE
		public static ITeleControlDestroyCondition_UnionUnion FromIThrowDestroyCondition(IThrowDestroyConditionT _ithrowdestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.IThrowDestroyCondition,
				Value = _ithrowdestroycondition
			};
		}

		// Token: 0x060274C2 RID: 160962 RVA: 0x005684D4 File Offset: 0x005666D4
		public static int Pack(FlatBufferBuilder builder, ITeleControlDestroyCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITeleControlDestroyCondition_Union.ITeleControlDestroyCondition:
				return ITeleControlDestroyCondition.Pack(builder, _o.AsITeleControlDestroyCondition()).Value;
			case ITeleControlDestroyCondition_Union.ILetGoDestroyCondition:
				return ILetGoDestroyCondition.Pack(builder, _o.AsILetGoDestroyCondition()).Value;
			case ITeleControlDestroyCondition_Union.ICreateBulletDestroyCondition:
				return ICreateBulletDestroyCondition.Pack(builder, _o.AsICreateBulletDestroyCondition()).Value;
			case ITeleControlDestroyCondition_Union.IThrowDestroyCondition:
				return IThrowDestroyCondition.Pack(builder, _o.AsIThrowDestroyCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
