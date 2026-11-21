using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A57 RID: 23127
	public class ILevelAiCycleModeType_UnionUnion
	{
		// Token: 0x1700A837 RID: 43063
		// (get) Token: 0x06025D3C RID: 154940 RVA: 0x0052F559 File Offset: 0x0052D759
		// (set) Token: 0x06025D3D RID: 154941 RVA: 0x0052F561 File Offset: 0x0052D761
		public ILevelAiCycleModeType_Union Type { get; set; }

		// Token: 0x1700A838 RID: 43064
		// (get) Token: 0x06025D3E RID: 154942 RVA: 0x0052F56A File Offset: 0x0052D76A
		// (set) Token: 0x06025D3F RID: 154943 RVA: 0x0052F572 File Offset: 0x0052D772
		public object Value { get; set; }

		// Token: 0x06025D40 RID: 154944 RVA: 0x0052F57B File Offset: 0x0052D77B
		public ILevelAiCycleModeType_UnionUnion()
		{
			this.Type = ILevelAiCycleModeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025D41 RID: 154945 RVA: 0x0052F591 File Offset: 0x0052D791
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025D42 RID: 154946 RVA: 0x0052F5A3 File Offset: 0x0052D7A3
		public ILevelAiCycleModeTypeT AsILevelAiCycleModeType()
		{
			return this.As<ILevelAiCycleModeTypeT>();
		}

		// Token: 0x06025D43 RID: 154947 RVA: 0x0052F5AB File Offset: 0x0052D7AB
		public static ILevelAiCycleModeType_UnionUnion FromILevelAiCycleModeType(ILevelAiCycleModeTypeT _ilevelaicyclemodetype)
		{
			return new ILevelAiCycleModeType_UnionUnion
			{
				Type = ILevelAiCycleModeType_Union.ILevelAiCycleModeType,
				Value = _ilevelaicyclemodetype
			};
		}

		// Token: 0x06025D44 RID: 154948 RVA: 0x0052F5C0 File Offset: 0x0052D7C0
		public ILevelAiCycleLooplyT AsILevelAiCycleLooply()
		{
			return this.As<ILevelAiCycleLooplyT>();
		}

		// Token: 0x06025D45 RID: 154949 RVA: 0x0052F5C8 File Offset: 0x0052D7C8
		public static ILevelAiCycleModeType_UnionUnion FromILevelAiCycleLooply(ILevelAiCycleLooplyT _ilevelaicyclelooply)
		{
			return new ILevelAiCycleModeType_UnionUnion
			{
				Type = ILevelAiCycleModeType_Union.ILevelAiCycleLooply,
				Value = _ilevelaicyclelooply
			};
		}

		// Token: 0x06025D46 RID: 154950 RVA: 0x0052F5E0 File Offset: 0x0052D7E0
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
