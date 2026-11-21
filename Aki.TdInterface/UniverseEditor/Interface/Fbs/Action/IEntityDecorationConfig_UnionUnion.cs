using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D59 RID: 27993
	public class IEntityDecorationConfig_UnionUnion
	{
		// Token: 0x1700CD50 RID: 52560
		// (get) Token: 0x06030490 RID: 197776 RVA: 0x0068FECD File Offset: 0x0068E0CD
		// (set) Token: 0x06030491 RID: 197777 RVA: 0x0068FED5 File Offset: 0x0068E0D5
		public IEntityDecorationConfig_Union Type { get; set; }

		// Token: 0x1700CD51 RID: 52561
		// (get) Token: 0x06030492 RID: 197778 RVA: 0x0068FEDE File Offset: 0x0068E0DE
		// (set) Token: 0x06030493 RID: 197779 RVA: 0x0068FEE6 File Offset: 0x0068E0E6
		public object Value { get; set; }

		// Token: 0x06030494 RID: 197780 RVA: 0x0068FEEF File Offset: 0x0068E0EF
		public IEntityDecorationConfig_UnionUnion()
		{
			this.Type = IEntityDecorationConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030495 RID: 197781 RVA: 0x0068FF05 File Offset: 0x0068E105
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030496 RID: 197782 RVA: 0x0068FF17 File Offset: 0x0068E117
		public IEntityDecorationConfigT AsIEntityDecorationConfig()
		{
			return this.As<IEntityDecorationConfigT>();
		}

		// Token: 0x06030497 RID: 197783 RVA: 0x0068FF1F File Offset: 0x0068E11F
		public static IEntityDecorationConfig_UnionUnion FromIEntityDecorationConfig(IEntityDecorationConfigT _ientitydecorationconfig)
		{
			return new IEntityDecorationConfig_UnionUnion
			{
				Type = IEntityDecorationConfig_Union.IEntityDecorationConfig,
				Value = _ientitydecorationconfig
			};
		}

		// Token: 0x06030498 RID: 197784 RVA: 0x0068FF34 File Offset: 0x0068E134
		public IAddEntityDecorationT AsIAddEntityDecoration()
		{
			return this.As<IAddEntityDecorationT>();
		}

		// Token: 0x06030499 RID: 197785 RVA: 0x0068FF3C File Offset: 0x0068E13C
		public static IEntityDecorationConfig_UnionUnion FromIAddEntityDecoration(IAddEntityDecorationT _iaddentitydecoration)
		{
			return new IEntityDecorationConfig_UnionUnion
			{
				Type = IEntityDecorationConfig_Union.IAddEntityDecoration,
				Value = _iaddentitydecoration
			};
		}

		// Token: 0x0603049A RID: 197786 RVA: 0x0068FF51 File Offset: 0x0068E151
		public IRemoveEntityDecorationT AsIRemoveEntityDecoration()
		{
			return this.As<IRemoveEntityDecorationT>();
		}

		// Token: 0x0603049B RID: 197787 RVA: 0x0068FF59 File Offset: 0x0068E159
		public static IEntityDecorationConfig_UnionUnion FromIRemoveEntityDecoration(IRemoveEntityDecorationT _iremoveentitydecoration)
		{
			return new IEntityDecorationConfig_UnionUnion
			{
				Type = IEntityDecorationConfig_Union.IRemoveEntityDecoration,
				Value = _iremoveentitydecoration
			};
		}

		// Token: 0x0603049C RID: 197788 RVA: 0x0068FF70 File Offset: 0x0068E170
		public static int Pack(FlatBufferBuilder builder, IEntityDecorationConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEntityDecorationConfig_Union.IEntityDecorationConfig:
				return IEntityDecorationConfig.Pack(builder, _o.AsIEntityDecorationConfig()).Value;
			case IEntityDecorationConfig_Union.IAddEntityDecoration:
				return IAddEntityDecoration.Pack(builder, _o.AsIAddEntityDecoration()).Value;
			case IEntityDecorationConfig_Union.IRemoveEntityDecoration:
				return IRemoveEntityDecoration.Pack(builder, _o.AsIRemoveEntityDecoration()).Value;
			default:
				return 0;
			}
		}
	}
}
