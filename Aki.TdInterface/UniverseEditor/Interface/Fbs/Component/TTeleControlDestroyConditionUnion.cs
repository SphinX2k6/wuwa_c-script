using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBE RID: 23742
	public class TTeleControlDestroyConditionUnion
	{
		// Token: 0x1700B25C RID: 45660
		// (get) Token: 0x06028A43 RID: 166467 RVA: 0x005959BE File Offset: 0x00593BBE
		// (set) Token: 0x06028A44 RID: 166468 RVA: 0x005959C6 File Offset: 0x00593BC6
		public TTeleControlDestroyCondition Type { get; set; }

		// Token: 0x1700B25D RID: 45661
		// (get) Token: 0x06028A45 RID: 166469 RVA: 0x005959CF File Offset: 0x00593BCF
		// (set) Token: 0x06028A46 RID: 166470 RVA: 0x005959D7 File Offset: 0x00593BD7
		public object Value { get; set; }

		// Token: 0x06028A47 RID: 166471 RVA: 0x005959E0 File Offset: 0x00593BE0
		public TTeleControlDestroyConditionUnion()
		{
			this.Type = TTeleControlDestroyCondition.NONE;
			this.Value = null;
		}

		// Token: 0x06028A48 RID: 166472 RVA: 0x005959F6 File Offset: 0x00593BF6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A49 RID: 166473 RVA: 0x00595A08 File Offset: 0x00593C08
		public ICreateBulletDestroyConditionT AsICreateBulletDestroyCondition()
		{
			return this.As<ICreateBulletDestroyConditionT>();
		}

		// Token: 0x06028A4A RID: 166474 RVA: 0x00595A10 File Offset: 0x00593C10
		public static TTeleControlDestroyConditionUnion FromICreateBulletDestroyCondition(ICreateBulletDestroyConditionT _icreatebulletdestroycondition)
		{
			return new TTeleControlDestroyConditionUnion
			{
				Type = TTeleControlDestroyCondition.ICreateBulletDestroyCondition,
				Value = _icreatebulletdestroycondition
			};
		}

		// Token: 0x06028A4B RID: 166475 RVA: 0x00595A25 File Offset: 0x00593C25
		public ILetGoDestroyConditionT AsILetGoDestroyCondition()
		{
			return this.As<ILetGoDestroyConditionT>();
		}

		// Token: 0x06028A4C RID: 166476 RVA: 0x00595A2D File Offset: 0x00593C2D
		public static TTeleControlDestroyConditionUnion FromILetGoDestroyCondition(ILetGoDestroyConditionT _iletgodestroycondition)
		{
			return new TTeleControlDestroyConditionUnion
			{
				Type = TTeleControlDestroyCondition.ILetGoDestroyCondition,
				Value = _iletgodestroycondition
			};
		}

		// Token: 0x06028A4D RID: 166477 RVA: 0x00595A42 File Offset: 0x00593C42
		public IThrowDestroyConditionT AsIThrowDestroyCondition()
		{
			return this.As<IThrowDestroyConditionT>();
		}

		// Token: 0x06028A4E RID: 166478 RVA: 0x00595A4A File Offset: 0x00593C4A
		public static TTeleControlDestroyConditionUnion FromIThrowDestroyCondition(IThrowDestroyConditionT _ithrowdestroycondition)
		{
			return new TTeleControlDestroyConditionUnion
			{
				Type = TTeleControlDestroyCondition.IThrowDestroyCondition,
				Value = _ithrowdestroycondition
			};
		}

		// Token: 0x06028A4F RID: 166479 RVA: 0x00595A60 File Offset: 0x00593C60
		public static int Pack(FlatBufferBuilder builder, TTeleControlDestroyConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTeleControlDestroyCondition.ICreateBulletDestroyCondition:
				return ICreateBulletDestroyCondition.Pack(builder, _o.AsICreateBulletDestroyCondition()).Value;
			case TTeleControlDestroyCondition.ILetGoDestroyCondition:
				return ILetGoDestroyCondition.Pack(builder, _o.AsILetGoDestroyCondition()).Value;
			case TTeleControlDestroyCondition.IThrowDestroyCondition:
				return IThrowDestroyCondition.Pack(builder, _o.AsIThrowDestroyCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
