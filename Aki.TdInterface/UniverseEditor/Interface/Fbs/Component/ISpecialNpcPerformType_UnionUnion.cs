using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F82 RID: 24450
	public class ISpecialNpcPerformType_UnionUnion
	{
		// Token: 0x1700B50B RID: 46347
		// (get) Token: 0x0602919D RID: 168349 RVA: 0x0059CDA5 File Offset: 0x0059AFA5
		// (set) Token: 0x0602919E RID: 168350 RVA: 0x0059CDAD File Offset: 0x0059AFAD
		public ISpecialNpcPerformType_Union Type { get; set; }

		// Token: 0x1700B50C RID: 46348
		// (get) Token: 0x0602919F RID: 168351 RVA: 0x0059CDB6 File Offset: 0x0059AFB6
		// (set) Token: 0x060291A0 RID: 168352 RVA: 0x0059CDBE File Offset: 0x0059AFBE
		public object Value { get; set; }

		// Token: 0x060291A1 RID: 168353 RVA: 0x0059CDC7 File Offset: 0x0059AFC7
		public ISpecialNpcPerformType_UnionUnion()
		{
			this.Type = ISpecialNpcPerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060291A2 RID: 168354 RVA: 0x0059CDDD File Offset: 0x0059AFDD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060291A3 RID: 168355 RVA: 0x0059CDEF File Offset: 0x0059AFEF
		public ISpecialNpcPerformTypeT AsISpecialNpcPerformType()
		{
			return this.As<ISpecialNpcPerformTypeT>();
		}

		// Token: 0x060291A4 RID: 168356 RVA: 0x0059CDF7 File Offset: 0x0059AFF7
		public static ISpecialNpcPerformType_UnionUnion FromISpecialNpcPerformType(ISpecialNpcPerformTypeT _ispecialnpcperformtype)
		{
			return new ISpecialNpcPerformType_UnionUnion
			{
				Type = ISpecialNpcPerformType_Union.ISpecialNpcPerformType,
				Value = _ispecialnpcperformtype
			};
		}

		// Token: 0x060291A5 RID: 168357 RVA: 0x0059CE0C File Offset: 0x0059B00C
		public IBaseRoleNpcPerformT AsIBaseRoleNpcPerform()
		{
			return this.As<IBaseRoleNpcPerformT>();
		}

		// Token: 0x060291A6 RID: 168358 RVA: 0x0059CE14 File Offset: 0x0059B014
		public static ISpecialNpcPerformType_UnionUnion FromIBaseRoleNpcPerform(IBaseRoleNpcPerformT _ibaserolenpcperform)
		{
			return new ISpecialNpcPerformType_UnionUnion
			{
				Type = ISpecialNpcPerformType_Union.IBaseRoleNpcPerform,
				Value = _ibaserolenpcperform
			};
		}

		// Token: 0x060291A7 RID: 168359 RVA: 0x0059CE2C File Offset: 0x0059B02C
		public static int Pack(FlatBufferBuilder builder, ISpecialNpcPerformType_UnionUnion _o)
		{
			ISpecialNpcPerformType_Union type = _o.Type;
			if (type == ISpecialNpcPerformType_Union.ISpecialNpcPerformType)
			{
				return ISpecialNpcPerformType.Pack(builder, _o.AsISpecialNpcPerformType()).Value;
			}
			if (type != ISpecialNpcPerformType_Union.IBaseRoleNpcPerform)
			{
				return 0;
			}
			return IBaseRoleNpcPerform.Pack(builder, _o.AsIBaseRoleNpcPerform()).Value;
		}
	}
}
