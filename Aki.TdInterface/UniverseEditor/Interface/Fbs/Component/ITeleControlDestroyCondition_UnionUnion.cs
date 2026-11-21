using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006051 RID: 24657
	public class ITeleControlDestroyCondition_UnionUnion
	{
		// Token: 0x1700B70F RID: 46863
		// (get) Token: 0x06029A2C RID: 170540 RVA: 0x005AF421 File Offset: 0x005AD621
		// (set) Token: 0x06029A2D RID: 170541 RVA: 0x005AF429 File Offset: 0x005AD629
		public ITeleControlDestroyCondition_Union Type { get; set; }

		// Token: 0x1700B710 RID: 46864
		// (get) Token: 0x06029A2E RID: 170542 RVA: 0x005AF432 File Offset: 0x005AD632
		// (set) Token: 0x06029A2F RID: 170543 RVA: 0x005AF43A File Offset: 0x005AD63A
		public object Value { get; set; }

		// Token: 0x06029A30 RID: 170544 RVA: 0x005AF443 File Offset: 0x005AD643
		public ITeleControlDestroyCondition_UnionUnion()
		{
			this.Type = ITeleControlDestroyCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029A31 RID: 170545 RVA: 0x005AF459 File Offset: 0x005AD659
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029A32 RID: 170546 RVA: 0x005AF46B File Offset: 0x005AD66B
		public ITeleControlDestroyConditionT AsITeleControlDestroyCondition()
		{
			return this.As<ITeleControlDestroyConditionT>();
		}

		// Token: 0x06029A33 RID: 170547 RVA: 0x005AF473 File Offset: 0x005AD673
		public static ITeleControlDestroyCondition_UnionUnion FromITeleControlDestroyCondition(ITeleControlDestroyConditionT _itelecontroldestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.ITeleControlDestroyCondition,
				Value = _itelecontroldestroycondition
			};
		}

		// Token: 0x06029A34 RID: 170548 RVA: 0x005AF488 File Offset: 0x005AD688
		public ILetGoDestroyConditionT AsILetGoDestroyCondition()
		{
			return this.As<ILetGoDestroyConditionT>();
		}

		// Token: 0x06029A35 RID: 170549 RVA: 0x005AF490 File Offset: 0x005AD690
		public static ITeleControlDestroyCondition_UnionUnion FromILetGoDestroyCondition(ILetGoDestroyConditionT _iletgodestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.ILetGoDestroyCondition,
				Value = _iletgodestroycondition
			};
		}

		// Token: 0x06029A36 RID: 170550 RVA: 0x005AF4A5 File Offset: 0x005AD6A5
		public ICreateBulletDestroyConditionT AsICreateBulletDestroyCondition()
		{
			return this.As<ICreateBulletDestroyConditionT>();
		}

		// Token: 0x06029A37 RID: 170551 RVA: 0x005AF4AD File Offset: 0x005AD6AD
		public static ITeleControlDestroyCondition_UnionUnion FromICreateBulletDestroyCondition(ICreateBulletDestroyConditionT _icreatebulletdestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.ICreateBulletDestroyCondition,
				Value = _icreatebulletdestroycondition
			};
		}

		// Token: 0x06029A38 RID: 170552 RVA: 0x005AF4C2 File Offset: 0x005AD6C2
		public IThrowDestroyConditionT AsIThrowDestroyCondition()
		{
			return this.As<IThrowDestroyConditionT>();
		}

		// Token: 0x06029A39 RID: 170553 RVA: 0x005AF4CA File Offset: 0x005AD6CA
		public static ITeleControlDestroyCondition_UnionUnion FromIThrowDestroyCondition(IThrowDestroyConditionT _ithrowdestroycondition)
		{
			return new ITeleControlDestroyCondition_UnionUnion
			{
				Type = ITeleControlDestroyCondition_Union.IThrowDestroyCondition,
				Value = _ithrowdestroycondition
			};
		}

		// Token: 0x06029A3A RID: 170554 RVA: 0x005AF4E0 File Offset: 0x005AD6E0
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
