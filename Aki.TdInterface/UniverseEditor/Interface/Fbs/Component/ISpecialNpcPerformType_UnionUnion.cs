using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005975 RID: 22901
	public class ISpecialNpcPerformType_UnionUnion
	{
		// Token: 0x1700ABD7 RID: 43991
		// (get) Token: 0x06026C33 RID: 158771 RVA: 0x00556139 File Offset: 0x00554339
		// (set) Token: 0x06026C34 RID: 158772 RVA: 0x00556141 File Offset: 0x00554341
		public ISpecialNpcPerformType_Union Type { get; set; }

		// Token: 0x1700ABD8 RID: 43992
		// (get) Token: 0x06026C35 RID: 158773 RVA: 0x0055614A File Offset: 0x0055434A
		// (set) Token: 0x06026C36 RID: 158774 RVA: 0x00556152 File Offset: 0x00554352
		public object Value { get; set; }

		// Token: 0x06026C37 RID: 158775 RVA: 0x0055615B File Offset: 0x0055435B
		public ISpecialNpcPerformType_UnionUnion()
		{
			this.Type = ISpecialNpcPerformType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026C38 RID: 158776 RVA: 0x00556171 File Offset: 0x00554371
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026C39 RID: 158777 RVA: 0x00556183 File Offset: 0x00554383
		public ISpecialNpcPerformTypeT AsISpecialNpcPerformType()
		{
			return this.As<ISpecialNpcPerformTypeT>();
		}

		// Token: 0x06026C3A RID: 158778 RVA: 0x0055618B File Offset: 0x0055438B
		public static ISpecialNpcPerformType_UnionUnion FromISpecialNpcPerformType(ISpecialNpcPerformTypeT _ispecialnpcperformtype)
		{
			return new ISpecialNpcPerformType_UnionUnion
			{
				Type = ISpecialNpcPerformType_Union.ISpecialNpcPerformType,
				Value = _ispecialnpcperformtype
			};
		}

		// Token: 0x06026C3B RID: 158779 RVA: 0x005561A0 File Offset: 0x005543A0
		public IBaseRoleNpcPerformT AsIBaseRoleNpcPerform()
		{
			return this.As<IBaseRoleNpcPerformT>();
		}

		// Token: 0x06026C3C RID: 158780 RVA: 0x005561A8 File Offset: 0x005543A8
		public static ISpecialNpcPerformType_UnionUnion FromIBaseRoleNpcPerform(IBaseRoleNpcPerformT _ibaserolenpcperform)
		{
			return new ISpecialNpcPerformType_UnionUnion
			{
				Type = ISpecialNpcPerformType_Union.IBaseRoleNpcPerform,
				Value = _ibaserolenpcperform
			};
		}

		// Token: 0x06026C3D RID: 158781 RVA: 0x005561C0 File Offset: 0x005543C0
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
