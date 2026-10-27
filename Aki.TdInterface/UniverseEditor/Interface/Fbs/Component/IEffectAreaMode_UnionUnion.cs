using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005112 RID: 20754
	public class IEffectAreaMode_UnionUnion
	{
		// Token: 0x17009736 RID: 38710
		// (get) Token: 0x06021708 RID: 136968 RVA: 0x004A4819 File Offset: 0x004A2A19
		// (set) Token: 0x06021709 RID: 136969 RVA: 0x004A4821 File Offset: 0x004A2A21
		public IEffectAreaMode_Union Type { get; set; }

		// Token: 0x17009737 RID: 38711
		// (get) Token: 0x0602170A RID: 136970 RVA: 0x004A482A File Offset: 0x004A2A2A
		// (set) Token: 0x0602170B RID: 136971 RVA: 0x004A4832 File Offset: 0x004A2A32
		public object Value { get; set; }

		// Token: 0x0602170C RID: 136972 RVA: 0x004A483B File Offset: 0x004A2A3B
		public IEffectAreaMode_UnionUnion()
		{
			this.Type = IEffectAreaMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602170D RID: 136973 RVA: 0x004A4851 File Offset: 0x004A2A51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602170E RID: 136974 RVA: 0x004A4863 File Offset: 0x004A2A63
		public IEffectAreaModeT AsIEffectAreaMode()
		{
			return this.As<IEffectAreaModeT>();
		}

		// Token: 0x0602170F RID: 136975 RVA: 0x004A486B File Offset: 0x004A2A6B
		public static IEffectAreaMode_UnionUnion FromIEffectAreaMode(IEffectAreaModeT _ieffectareamode)
		{
			return new IEffectAreaMode_UnionUnion
			{
				Type = IEffectAreaMode_Union.IEffectAreaMode,
				Value = _ieffectareamode
			};
		}

		// Token: 0x06021710 RID: 136976 RVA: 0x004A4880 File Offset: 0x004A2A80
		public IBuffAreaT AsIBuffArea()
		{
			return this.As<IBuffAreaT>();
		}

		// Token: 0x06021711 RID: 136977 RVA: 0x004A4888 File Offset: 0x004A2A88
		public static IEffectAreaMode_UnionUnion FromIBuffArea(IBuffAreaT _ibuffarea)
		{
			return new IEffectAreaMode_UnionUnion
			{
				Type = IEffectAreaMode_Union.IBuffArea,
				Value = _ibuffarea
			};
		}

		// Token: 0x06021712 RID: 136978 RVA: 0x004A48A0 File Offset: 0x004A2AA0
		public static int Pack(FlatBufferBuilder builder, IEffectAreaMode_UnionUnion _o)
		{
			IEffectAreaMode_Union type = _o.Type;
			if (type == IEffectAreaMode_Union.IEffectAreaMode)
			{
				return IEffectAreaMode.Pack(builder, _o.AsIEffectAreaMode()).Value;
			}
			if (type != IEffectAreaMode_Union.IBuffArea)
			{
				return 0;
			}
			return IBuffArea.Pack(builder, _o.AsIBuffArea()).Value;
		}
	}
}
