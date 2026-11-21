using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062BC RID: 25276
	public class TPortalViewDistanceConfigUnion
	{
		// Token: 0x1700BB94 RID: 48020
		// (get) Token: 0x0602AF8D RID: 176013 RVA: 0x005DC9A2 File Offset: 0x005DABA2
		// (set) Token: 0x0602AF8E RID: 176014 RVA: 0x005DC9AA File Offset: 0x005DABAA
		public TPortalViewDistanceConfig Type { get; set; }

		// Token: 0x1700BB95 RID: 48021
		// (get) Token: 0x0602AF8F RID: 176015 RVA: 0x005DC9B3 File Offset: 0x005DABB3
		// (set) Token: 0x0602AF90 RID: 176016 RVA: 0x005DC9BB File Offset: 0x005DABBB
		public object Value { get; set; }

		// Token: 0x0602AF91 RID: 176017 RVA: 0x005DC9C4 File Offset: 0x005DABC4
		public TPortalViewDistanceConfigUnion()
		{
			this.Type = TPortalViewDistanceConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF92 RID: 176018 RVA: 0x005DC9DA File Offset: 0x005DABDA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF93 RID: 176019 RVA: 0x005DC9EC File Offset: 0x005DABEC
		public ICustomViewDistanceT AsICustomViewDistance()
		{
			return this.As<ICustomViewDistanceT>();
		}

		// Token: 0x0602AF94 RID: 176020 RVA: 0x005DC9F4 File Offset: 0x005DABF4
		public static TPortalViewDistanceConfigUnion FromICustomViewDistance(ICustomViewDistanceT _icustomviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.ICustomViewDistance,
				Value = _icustomviewdistance
			};
		}

		// Token: 0x0602AF95 RID: 176021 RVA: 0x005DCA09 File Offset: 0x005DAC09
		public IHighViewDistanceT AsIHighViewDistance()
		{
			return this.As<IHighViewDistanceT>();
		}

		// Token: 0x0602AF96 RID: 176022 RVA: 0x005DCA11 File Offset: 0x005DAC11
		public static TPortalViewDistanceConfigUnion FromIHighViewDistance(IHighViewDistanceT _ihighviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.IHighViewDistance,
				Value = _ihighviewdistance
			};
		}

		// Token: 0x0602AF97 RID: 176023 RVA: 0x005DCA26 File Offset: 0x005DAC26
		public ILowViewDistanceT AsILowViewDistance()
		{
			return this.As<ILowViewDistanceT>();
		}

		// Token: 0x0602AF98 RID: 176024 RVA: 0x005DCA2E File Offset: 0x005DAC2E
		public static TPortalViewDistanceConfigUnion FromILowViewDistance(ILowViewDistanceT _ilowviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.ILowViewDistance,
				Value = _ilowviewdistance
			};
		}

		// Token: 0x0602AF99 RID: 176025 RVA: 0x005DCA43 File Offset: 0x005DAC43
		public IMidViewDistanceT AsIMidViewDistance()
		{
			return this.As<IMidViewDistanceT>();
		}

		// Token: 0x0602AF9A RID: 176026 RVA: 0x005DCA4B File Offset: 0x005DAC4B
		public static TPortalViewDistanceConfigUnion FromIMidViewDistance(IMidViewDistanceT _imidviewdistance)
		{
			return new TPortalViewDistanceConfigUnion
			{
				Type = TPortalViewDistanceConfig.IMidViewDistance,
				Value = _imidviewdistance
			};
		}

		// Token: 0x0602AF9B RID: 176027 RVA: 0x005DCA60 File Offset: 0x005DAC60
		public static int Pack(FlatBufferBuilder builder, TPortalViewDistanceConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TPortalViewDistanceConfig.ICustomViewDistance:
				return ICustomViewDistance.Pack(builder, _o.AsICustomViewDistance()).Value;
			case TPortalViewDistanceConfig.IHighViewDistance:
				return IHighViewDistance.Pack(builder, _o.AsIHighViewDistance()).Value;
			case TPortalViewDistanceConfig.ILowViewDistance:
				return ILowViewDistance.Pack(builder, _o.AsILowViewDistance()).Value;
			case TPortalViewDistanceConfig.IMidViewDistance:
				return IMidViewDistance.Pack(builder, _o.AsIMidViewDistance()).Value;
			default:
				return 0;
			}
		}
	}
}
