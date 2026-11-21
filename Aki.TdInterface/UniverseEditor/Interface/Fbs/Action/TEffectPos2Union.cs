using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EB9 RID: 32441
	public class TEffectPos2Union
	{
		// Token: 0x1700F249 RID: 62025
		// (get) Token: 0x0603A8F5 RID: 239861 RVA: 0x007E174A File Offset: 0x007DF94A
		// (set) Token: 0x0603A8F6 RID: 239862 RVA: 0x007E1752 File Offset: 0x007DF952
		public TEffectPos2 Type { get; set; }

		// Token: 0x1700F24A RID: 62026
		// (get) Token: 0x0603A8F7 RID: 239863 RVA: 0x007E175B File Offset: 0x007DF95B
		// (set) Token: 0x0603A8F8 RID: 239864 RVA: 0x007E1763 File Offset: 0x007DF963
		public object Value { get; set; }

		// Token: 0x0603A8F9 RID: 239865 RVA: 0x007E176C File Offset: 0x007DF96C
		public TEffectPos2Union()
		{
			this.Type = TEffectPos2.NONE;
			this.Value = null;
		}

		// Token: 0x0603A8FA RID: 239866 RVA: 0x007E1782 File Offset: 0x007DF982
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A8FB RID: 239867 RVA: 0x007E1794 File Offset: 0x007DF994
		public IAbsolutePos2T AsIAbsolutePos2()
		{
			return this.As<IAbsolutePos2T>();
		}

		// Token: 0x0603A8FC RID: 239868 RVA: 0x007E179C File Offset: 0x007DF99C
		public static TEffectPos2Union FromIAbsolutePos2(IAbsolutePos2T _iabsolutepos2)
		{
			return new TEffectPos2Union
			{
				Type = TEffectPos2.IAbsolutePos2,
				Value = _iabsolutepos2
			};
		}

		// Token: 0x0603A8FD RID: 239869 RVA: 0x007E17B1 File Offset: 0x007DF9B1
		public IEffectEntityPos2T AsIEffectEntityPos2()
		{
			return this.As<IEffectEntityPos2T>();
		}

		// Token: 0x0603A8FE RID: 239870 RVA: 0x007E17B9 File Offset: 0x007DF9B9
		public static TEffectPos2Union FromIEffectEntityPos2(IEffectEntityPos2T _ieffectentitypos2)
		{
			return new TEffectPos2Union
			{
				Type = TEffectPos2.IEffectEntityPos2,
				Value = _ieffectentitypos2
			};
		}

		// Token: 0x0603A8FF RID: 239871 RVA: 0x007E17CE File Offset: 0x007DF9CE
		public IEffectPlayerPos2T AsIEffectPlayerPos2()
		{
			return this.As<IEffectPlayerPos2T>();
		}

		// Token: 0x0603A900 RID: 239872 RVA: 0x007E17D6 File Offset: 0x007DF9D6
		public static TEffectPos2Union FromIEffectPlayerPos2(IEffectPlayerPos2T _ieffectplayerpos2)
		{
			return new TEffectPos2Union
			{
				Type = TEffectPos2.IEffectPlayerPos2,
				Value = _ieffectplayerpos2
			};
		}

		// Token: 0x0603A901 RID: 239873 RVA: 0x007E17EC File Offset: 0x007DF9EC
		public static int Pack(FlatBufferBuilder builder, TEffectPos2Union _o)
		{
			switch (_o.Type)
			{
			case TEffectPos2.IAbsolutePos2:
				return IAbsolutePos2.Pack(builder, _o.AsIAbsolutePos2()).Value;
			case TEffectPos2.IEffectEntityPos2:
				return IEffectEntityPos2.Pack(builder, _o.AsIEffectEntityPos2()).Value;
			case TEffectPos2.IEffectPlayerPos2:
				return IEffectPlayerPos2.Pack(builder, _o.AsIEffectPlayerPos2()).Value;
			default:
				return 0;
			}
		}
	}
}
