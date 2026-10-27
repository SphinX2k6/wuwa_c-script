using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE3 RID: 19683
	public class ITargetAttribute_UnionUnion
	{
		// Token: 0x17008EDD RID: 36573
		// (get) Token: 0x0601F3D6 RID: 127958 RVA: 0x0045C3A1 File Offset: 0x0045A5A1
		// (set) Token: 0x0601F3D7 RID: 127959 RVA: 0x0045C3A9 File Offset: 0x0045A5A9
		public ITargetAttribute_Union Type { get; set; }

		// Token: 0x17008EDE RID: 36574
		// (get) Token: 0x0601F3D8 RID: 127960 RVA: 0x0045C3B2 File Offset: 0x0045A5B2
		// (set) Token: 0x0601F3D9 RID: 127961 RVA: 0x0045C3BA File Offset: 0x0045A5BA
		public object Value { get; set; }

		// Token: 0x0601F3DA RID: 127962 RVA: 0x0045C3C3 File Offset: 0x0045A5C3
		public ITargetAttribute_UnionUnion()
		{
			this.Type = ITargetAttribute_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F3DB RID: 127963 RVA: 0x0045C3D9 File Offset: 0x0045A5D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F3DC RID: 127964 RVA: 0x0045C3EB File Offset: 0x0045A5EB
		public ITargetAttributeT AsITargetAttribute()
		{
			return this.As<ITargetAttributeT>();
		}

		// Token: 0x0601F3DD RID: 127965 RVA: 0x0045C3F3 File Offset: 0x0045A5F3
		public static ITargetAttribute_UnionUnion FromITargetAttribute(ITargetAttributeT _itargetattribute)
		{
			return new ITargetAttribute_UnionUnion
			{
				Type = ITargetAttribute_Union.ITargetAttribute,
				Value = _itargetattribute
			};
		}

		// Token: 0x0601F3DE RID: 127966 RVA: 0x0045C408 File Offset: 0x0045A608
		public IPlayerAttributeT AsIPlayerAttribute()
		{
			return this.As<IPlayerAttributeT>();
		}

		// Token: 0x0601F3DF RID: 127967 RVA: 0x0045C410 File Offset: 0x0045A610
		public static ITargetAttribute_UnionUnion FromIPlayerAttribute(IPlayerAttributeT _iplayerattribute)
		{
			return new ITargetAttribute_UnionUnion
			{
				Type = ITargetAttribute_Union.IPlayerAttribute,
				Value = _iplayerattribute
			};
		}

		// Token: 0x0601F3E0 RID: 127968 RVA: 0x0045C428 File Offset: 0x0045A628
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
