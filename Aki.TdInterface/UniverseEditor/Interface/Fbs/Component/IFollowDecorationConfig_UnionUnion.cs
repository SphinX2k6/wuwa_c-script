using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FD RID: 22525
	public class IFollowDecorationConfig_UnionUnion
	{
		// Token: 0x1700A2FE RID: 41726
		// (get) Token: 0x060246CC RID: 149196 RVA: 0x005015F9 File Offset: 0x004FF7F9
		// (set) Token: 0x060246CD RID: 149197 RVA: 0x00501601 File Offset: 0x004FF801
		public IFollowDecorationConfig_Union Type { get; set; }

		// Token: 0x1700A2FF RID: 41727
		// (get) Token: 0x060246CE RID: 149198 RVA: 0x0050160A File Offset: 0x004FF80A
		// (set) Token: 0x060246CF RID: 149199 RVA: 0x00501612 File Offset: 0x004FF812
		public object Value { get; set; }

		// Token: 0x060246D0 RID: 149200 RVA: 0x0050161B File Offset: 0x004FF81B
		public IFollowDecorationConfig_UnionUnion()
		{
			this.Type = IFollowDecorationConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060246D1 RID: 149201 RVA: 0x00501631 File Offset: 0x004FF831
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060246D2 RID: 149202 RVA: 0x00501643 File Offset: 0x004FF843
		public IFollowDecorationConfigT AsIFollowDecorationConfig()
		{
			return this.As<IFollowDecorationConfigT>();
		}

		// Token: 0x060246D3 RID: 149203 RVA: 0x0050164B File Offset: 0x004FF84B
		public static IFollowDecorationConfig_UnionUnion FromIFollowDecorationConfig(IFollowDecorationConfigT _ifollowdecorationconfig)
		{
			return new IFollowDecorationConfig_UnionUnion
			{
				Type = IFollowDecorationConfig_Union.IFollowDecorationConfig,
				Value = _ifollowdecorationconfig
			};
		}

		// Token: 0x060246D4 RID: 149204 RVA: 0x00501660 File Offset: 0x004FF860
		public IFollowDecorationChairConfigT AsIFollowDecorationChairConfig()
		{
			return this.As<IFollowDecorationChairConfigT>();
		}

		// Token: 0x060246D5 RID: 149205 RVA: 0x00501668 File Offset: 0x004FF868
		public static IFollowDecorationConfig_UnionUnion FromIFollowDecorationChairConfig(IFollowDecorationChairConfigT _ifollowdecorationchairconfig)
		{
			return new IFollowDecorationConfig_UnionUnion
			{
				Type = IFollowDecorationConfig_Union.IFollowDecorationChairConfig,
				Value = _ifollowdecorationchairconfig
			};
		}

		// Token: 0x060246D6 RID: 149206 RVA: 0x00501680 File Offset: 0x004FF880
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
