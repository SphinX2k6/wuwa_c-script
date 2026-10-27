using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005295 RID: 21141
	public class IFollowDecorationConfig_UnionUnion
	{
		// Token: 0x17009B00 RID: 39680
		// (get) Token: 0x06022732 RID: 141106 RVA: 0x004C6A89 File Offset: 0x004C4C89
		// (set) Token: 0x06022733 RID: 141107 RVA: 0x004C6A91 File Offset: 0x004C4C91
		public IFollowDecorationConfig_Union Type { get; set; }

		// Token: 0x17009B01 RID: 39681
		// (get) Token: 0x06022734 RID: 141108 RVA: 0x004C6A9A File Offset: 0x004C4C9A
		// (set) Token: 0x06022735 RID: 141109 RVA: 0x004C6AA2 File Offset: 0x004C4CA2
		public object Value { get; set; }

		// Token: 0x06022736 RID: 141110 RVA: 0x004C6AAB File Offset: 0x004C4CAB
		public IFollowDecorationConfig_UnionUnion()
		{
			this.Type = IFollowDecorationConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022737 RID: 141111 RVA: 0x004C6AC1 File Offset: 0x004C4CC1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022738 RID: 141112 RVA: 0x004C6AD3 File Offset: 0x004C4CD3
		public IFollowDecorationConfigT AsIFollowDecorationConfig()
		{
			return this.As<IFollowDecorationConfigT>();
		}

		// Token: 0x06022739 RID: 141113 RVA: 0x004C6ADB File Offset: 0x004C4CDB
		public static IFollowDecorationConfig_UnionUnion FromIFollowDecorationConfig(IFollowDecorationConfigT _ifollowdecorationconfig)
		{
			return new IFollowDecorationConfig_UnionUnion
			{
				Type = IFollowDecorationConfig_Union.IFollowDecorationConfig,
				Value = _ifollowdecorationconfig
			};
		}

		// Token: 0x0602273A RID: 141114 RVA: 0x004C6AF0 File Offset: 0x004C4CF0
		public IFollowDecorationChairConfigT AsIFollowDecorationChairConfig()
		{
			return this.As<IFollowDecorationChairConfigT>();
		}

		// Token: 0x0602273B RID: 141115 RVA: 0x004C6AF8 File Offset: 0x004C4CF8
		public static IFollowDecorationConfig_UnionUnion FromIFollowDecorationChairConfig(IFollowDecorationChairConfigT _ifollowdecorationchairconfig)
		{
			return new IFollowDecorationConfig_UnionUnion
			{
				Type = IFollowDecorationConfig_Union.IFollowDecorationChairConfig,
				Value = _ifollowdecorationchairconfig
			};
		}

		// Token: 0x0602273C RID: 141116 RVA: 0x004C6B10 File Offset: 0x004C4D10
		public static int Pack(FlatBufferBuilder builder, IFollowDecorationConfig_UnionUnion _o)
		{
			IFollowDecorationConfig_Union type = _o.Type;
			if (type == IFollowDecorationConfig_Union.IFollowDecorationConfig)
			{
				return IFollowDecorationConfig.Pack(builder, _o.AsIFollowDecorationConfig()).Value;
			}
			if (type != IFollowDecorationConfig_Union.IFollowDecorationChairConfig)
			{
				return 0;
			}
			return IFollowDecorationChairConfig.Pack(builder, _o.AsIFollowDecorationChairConfig()).Value;
		}
	}
}
