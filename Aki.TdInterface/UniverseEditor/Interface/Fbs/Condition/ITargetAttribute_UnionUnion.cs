using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051DF RID: 20959
	public class ITargetAttribute_UnionUnion
	{
		// Token: 0x17009616 RID: 38422
		// (get) Token: 0x0602101B RID: 135195 RVA: 0x004902F1 File Offset: 0x0048E4F1
		// (set) Token: 0x0602101C RID: 135196 RVA: 0x004902F9 File Offset: 0x0048E4F9
		public ITargetAttribute_Union Type { get; set; }

		// Token: 0x17009617 RID: 38423
		// (get) Token: 0x0602101D RID: 135197 RVA: 0x00490302 File Offset: 0x0048E502
		// (set) Token: 0x0602101E RID: 135198 RVA: 0x0049030A File Offset: 0x0048E50A
		public object Value { get; set; }

		// Token: 0x0602101F RID: 135199 RVA: 0x00490313 File Offset: 0x0048E513
		public ITargetAttribute_UnionUnion()
		{
			this.Type = ITargetAttribute_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021020 RID: 135200 RVA: 0x00490329 File Offset: 0x0048E529
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021021 RID: 135201 RVA: 0x0049033B File Offset: 0x0048E53B
		public ITargetAttributeT AsITargetAttribute()
		{
			return this.As<ITargetAttributeT>();
		}

		// Token: 0x06021022 RID: 135202 RVA: 0x00490343 File Offset: 0x0048E543
		public static ITargetAttribute_UnionUnion FromITargetAttribute(ITargetAttributeT _itargetattribute)
		{
			return new ITargetAttribute_UnionUnion
			{
				Type = ITargetAttribute_Union.ITargetAttribute,
				Value = _itargetattribute
			};
		}

		// Token: 0x06021023 RID: 135203 RVA: 0x00490358 File Offset: 0x0048E558
		public IPlayerAttributeT AsIPlayerAttribute()
		{
			return this.As<IPlayerAttributeT>();
		}

		// Token: 0x06021024 RID: 135204 RVA: 0x00490360 File Offset: 0x0048E560
		public static ITargetAttribute_UnionUnion FromIPlayerAttribute(IPlayerAttributeT _iplayerattribute)
		{
			return new ITargetAttribute_UnionUnion
			{
				Type = ITargetAttribute_Union.IPlayerAttribute,
				Value = _iplayerattribute
			};
		}

		// Token: 0x06021025 RID: 135205 RVA: 0x00490378 File Offset: 0x0048E578
		public static int Pack(FlatBufferBuilder builder, ITargetAttribute_UnionUnion _o)
		{
			ITargetAttribute_Union type = _o.Type;
			if (type == ITargetAttribute_Union.ITargetAttribute)
			{
				return ITargetAttribute.Pack(builder, _o.AsITargetAttribute()).Value;
			}
			if (type != ITargetAttribute_Union.IPlayerAttribute)
			{
				return 0;
			}
			return IPlayerAttribute.Pack(builder, _o.AsIPlayerAttribute()).Value;
		}
	}
}
