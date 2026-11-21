using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200414C RID: 16716
	public class IBindingProgressType_UnionUnion
	{
		// Token: 0x17007133 RID: 28979
		// (get) Token: 0x06016F73 RID: 94067 RVA: 0x00346C25 File Offset: 0x00344E25
		// (set) Token: 0x06016F74 RID: 94068 RVA: 0x00346C2D File Offset: 0x00344E2D
		public IBindingProgressType_Union Type { get; set; }

		// Token: 0x17007134 RID: 28980
		// (get) Token: 0x06016F75 RID: 94069 RVA: 0x00346C36 File Offset: 0x00344E36
		// (set) Token: 0x06016F76 RID: 94070 RVA: 0x00346C3E File Offset: 0x00344E3E
		public object Value { get; set; }

		// Token: 0x06016F77 RID: 94071 RVA: 0x00346C47 File Offset: 0x00344E47
		public IBindingProgressType_UnionUnion()
		{
			this.Type = IBindingProgressType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016F78 RID: 94072 RVA: 0x00346C5D File Offset: 0x00344E5D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016F79 RID: 94073 RVA: 0x00346C6F File Offset: 0x00344E6F
		public IBindingProgressTypeT AsIBindingProgressType()
		{
			return this.As<IBindingProgressTypeT>();
		}

		// Token: 0x06016F7A RID: 94074 RVA: 0x00346C77 File Offset: 0x00344E77
		public static IBindingProgressType_UnionUnion FromIBindingProgressType(IBindingProgressTypeT _ibindingprogresstype)
		{
			return new IBindingProgressType_UnionUnion
			{
				Type = IBindingProgressType_Union.IBindingProgressType,
				Value = _ibindingprogresstype
			};
		}

		// Token: 0x06016F7B RID: 94075 RVA: 0x00346C8C File Offset: 0x00344E8C
		public IPlayerHavingItemCountT AsIPlayerHavingItemCount()
		{
			return this.As<IPlayerHavingItemCountT>();
		}

		// Token: 0x06016F7C RID: 94076 RVA: 0x00346C94 File Offset: 0x00344E94
		public static IBindingProgressType_UnionUnion FromIPlayerHavingItemCount(IPlayerHavingItemCountT _iplayerhavingitemcount)
		{
			return new IBindingProgressType_UnionUnion
			{
				Type = IBindingProgressType_Union.IPlayerHavingItemCount,
				Value = _iplayerhavingitemcount
			};
		}

		// Token: 0x06016F7D RID: 94077 RVA: 0x00346CAC File Offset: 0x00344EAC
		public static int Pack(FlatBufferBuilder builder, IBindingProgressType_UnionUnion _o)
		{
			IBindingProgressType_Union type = _o.Type;
			if (type == IBindingProgressType_Union.IBindingProgressType)
			{
				return IBindingProgressType.Pack(builder, _o.AsIBindingProgressType()).Value;
			}
			if (type != IBindingProgressType_Union.IPlayerHavingItemCount)
			{
				return 0;
			}
			return IPlayerHavingItemCount.Pack(builder, _o.AsIPlayerHavingItemCount()).Value;
		}
	}
}
