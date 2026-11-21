using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007053 RID: 28755
	public class IInteractPointConfig_UnionUnion
	{
		// Token: 0x1700D2A3 RID: 53923
		// (get) Token: 0x06031DCB RID: 204235 RVA: 0x006C011D File Offset: 0x006BE31D
		// (set) Token: 0x06031DCC RID: 204236 RVA: 0x006C0125 File Offset: 0x006BE325
		public IInteractPointConfig_Union Type { get; set; }

		// Token: 0x1700D2A4 RID: 53924
		// (get) Token: 0x06031DCD RID: 204237 RVA: 0x006C012E File Offset: 0x006BE32E
		// (set) Token: 0x06031DCE RID: 204238 RVA: 0x006C0136 File Offset: 0x006BE336
		public object Value { get; set; }

		// Token: 0x06031DCF RID: 204239 RVA: 0x006C013F File Offset: 0x006BE33F
		public IInteractPointConfig_UnionUnion()
		{
			this.Type = IInteractPointConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031DD0 RID: 204240 RVA: 0x006C0155 File Offset: 0x006BE355
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031DD1 RID: 204241 RVA: 0x006C0167 File Offset: 0x006BE367
		public IInteractPointConfigT AsIInteractPointConfig()
		{
			return this.As<IInteractPointConfigT>();
		}

		// Token: 0x06031DD2 RID: 204242 RVA: 0x006C016F File Offset: 0x006BE36F
		public static IInteractPointConfig_UnionUnion FromIInteractPointConfig(IInteractPointConfigT _iinteractpointconfig)
		{
			return new IInteractPointConfig_UnionUnion
			{
				Type = IInteractPointConfig_Union.IInteractPointConfig,
				Value = _iinteractpointconfig
			};
		}

		// Token: 0x06031DD3 RID: 204243 RVA: 0x006C0184 File Offset: 0x006BE384
		public ISequenceUnlockPointsT AsISequenceUnlockPoints()
		{
			return this.As<ISequenceUnlockPointsT>();
		}

		// Token: 0x06031DD4 RID: 204244 RVA: 0x006C018C File Offset: 0x006BE38C
		public static IInteractPointConfig_UnionUnion FromISequenceUnlockPoints(ISequenceUnlockPointsT _isequenceunlockpoints)
		{
			return new IInteractPointConfig_UnionUnion
			{
				Type = IInteractPointConfig_Union.ISequenceUnlockPoints,
				Value = _isequenceunlockpoints
			};
		}

		// Token: 0x06031DD5 RID: 204245 RVA: 0x006C01A4 File Offset: 0x006BE3A4
		public static int Pack(FlatBufferBuilder builder, IInteractPointConfig_UnionUnion _o)
		{
			IInteractPointConfig_Union type = _o.Type;
			if (type == IInteractPointConfig_Union.IInteractPointConfig)
			{
				return IInteractPointConfig.Pack(builder, _o.AsIInteractPointConfig()).Value;
			}
			if (type != IInteractPointConfig_Union.ISequenceUnlockPoints)
			{
				return 0;
			}
			return ISequenceUnlockPoints.Pack(builder, _o.AsISequenceUnlockPoints()).Value;
		}
	}
}
