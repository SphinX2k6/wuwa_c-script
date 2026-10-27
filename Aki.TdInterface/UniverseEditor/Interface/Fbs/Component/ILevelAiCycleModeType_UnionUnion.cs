using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D1 RID: 21713
	public class ILevelAiCycleModeType_UnionUnion
	{
		// Token: 0x17009FFD RID: 40957
		// (get) Token: 0x06023C84 RID: 146564 RVA: 0x004F24E5 File Offset: 0x004F06E5
		// (set) Token: 0x06023C85 RID: 146565 RVA: 0x004F24ED File Offset: 0x004F06ED
		public ILevelAiCycleModeType_Union Type { get; set; }

		// Token: 0x17009FFE RID: 40958
		// (get) Token: 0x06023C86 RID: 146566 RVA: 0x004F24F6 File Offset: 0x004F06F6
		// (set) Token: 0x06023C87 RID: 146567 RVA: 0x004F24FE File Offset: 0x004F06FE
		public object Value { get; set; }

		// Token: 0x06023C88 RID: 146568 RVA: 0x004F2507 File Offset: 0x004F0707
		public ILevelAiCycleModeType_UnionUnion()
		{
			this.Type = ILevelAiCycleModeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023C89 RID: 146569 RVA: 0x004F251D File Offset: 0x004F071D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023C8A RID: 146570 RVA: 0x004F252F File Offset: 0x004F072F
		public ILevelAiCycleModeTypeT AsILevelAiCycleModeType()
		{
			return this.As<ILevelAiCycleModeTypeT>();
		}

		// Token: 0x06023C8B RID: 146571 RVA: 0x004F2537 File Offset: 0x004F0737
		public static ILevelAiCycleModeType_UnionUnion FromILevelAiCycleModeType(ILevelAiCycleModeTypeT _ilevelaicyclemodetype)
		{
			return new ILevelAiCycleModeType_UnionUnion
			{
				Type = ILevelAiCycleModeType_Union.ILevelAiCycleModeType,
				Value = _ilevelaicyclemodetype
			};
		}

		// Token: 0x06023C8C RID: 146572 RVA: 0x004F254C File Offset: 0x004F074C
		public ILevelAiCycleLooplyT AsILevelAiCycleLooply()
		{
			return this.As<ILevelAiCycleLooplyT>();
		}

		// Token: 0x06023C8D RID: 146573 RVA: 0x004F2554 File Offset: 0x004F0754
		public static ILevelAiCycleModeType_UnionUnion FromILevelAiCycleLooply(ILevelAiCycleLooplyT _ilevelaicyclelooply)
		{
			return new ILevelAiCycleModeType_UnionUnion
			{
				Type = ILevelAiCycleModeType_Union.ILevelAiCycleLooply,
				Value = _ilevelaicyclelooply
			};
		}

		// Token: 0x06023C8E RID: 146574 RVA: 0x004F256C File Offset: 0x004F076C
		public static int Pack(FlatBufferBuilder builder, ILevelAiCycleModeType_UnionUnion _o)
		{
			ILevelAiCycleModeType_Union type = _o.Type;
			if (type == ILevelAiCycleModeType_Union.ILevelAiCycleModeType)
			{
				return ILevelAiCycleModeType.Pack(builder, _o.AsILevelAiCycleModeType()).Value;
			}
			if (type != ILevelAiCycleModeType_Union.ILevelAiCycleLooply)
			{
				return 0;
			}
			return ILevelAiCycleLooply.Pack(builder, _o.AsILevelAiCycleLooply()).Value;
		}
	}
}
