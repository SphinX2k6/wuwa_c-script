using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005199 RID: 20889
	public class IEntityMatchConfig_UnionUnion
	{
		// Token: 0x1700989C RID: 39068
		// (get) Token: 0x06021CA1 RID: 138401 RVA: 0x004B0069 File Offset: 0x004AE269
		// (set) Token: 0x06021CA2 RID: 138402 RVA: 0x004B0071 File Offset: 0x004AE271
		public IEntityMatchConfig_Union Type { get; set; }

		// Token: 0x1700989D RID: 39069
		// (get) Token: 0x06021CA3 RID: 138403 RVA: 0x004B007A File Offset: 0x004AE27A
		// (set) Token: 0x06021CA4 RID: 138404 RVA: 0x004B0082 File Offset: 0x004AE282
		public object Value { get; set; }

		// Token: 0x06021CA5 RID: 138405 RVA: 0x004B008B File Offset: 0x004AE28B
		public IEntityMatchConfig_UnionUnion()
		{
			this.Type = IEntityMatchConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021CA6 RID: 138406 RVA: 0x004B00A1 File Offset: 0x004AE2A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021CA7 RID: 138407 RVA: 0x004B00B3 File Offset: 0x004AE2B3
		public IEntityMatchConfigT AsIEntityMatchConfig()
		{
			return this.As<IEntityMatchConfigT>();
		}

		// Token: 0x06021CA8 RID: 138408 RVA: 0x004B00BB File Offset: 0x004AE2BB
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchConfig(IEntityMatchConfigT _ientitymatchconfig)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchConfig,
				Value = _ientitymatchconfig
			};
		}

		// Token: 0x06021CA9 RID: 138409 RVA: 0x004B00D0 File Offset: 0x004AE2D0
		public IEntityMatchAllCharacterT AsIEntityMatchAllCharacter()
		{
			return this.As<IEntityMatchAllCharacterT>();
		}

		// Token: 0x06021CAA RID: 138410 RVA: 0x004B00D8 File Offset: 0x004AE2D8
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchAllCharacter(IEntityMatchAllCharacterT _ientitymatchallcharacter)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchAllCharacter,
				Value = _ientitymatchallcharacter
			};
		}

		// Token: 0x06021CAB RID: 138411 RVA: 0x004B00ED File Offset: 0x004AE2ED
		public IEntityMatchPlayerT AsIEntityMatchPlayer()
		{
			return this.As<IEntityMatchPlayerT>();
		}

		// Token: 0x06021CAC RID: 138412 RVA: 0x004B00F5 File Offset: 0x004AE2F5
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchPlayer(IEntityMatchPlayerT _ientitymatchplayer)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchPlayer,
				Value = _ientitymatchplayer
			};
		}

		// Token: 0x06021CAD RID: 138413 RVA: 0x004B010A File Offset: 0x004AE30A
		public IEntityMatchDynamicT AsIEntityMatchDynamic()
		{
			return this.As<IEntityMatchDynamicT>();
		}

		// Token: 0x06021CAE RID: 138414 RVA: 0x004B0112 File Offset: 0x004AE312
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchDynamic(IEntityMatchDynamicT _ientitymatchdynamic)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchDynamic,
				Value = _ientitymatchdynamic
			};
		}

		// Token: 0x06021CAF RID: 138415 RVA: 0x004B0127 File Offset: 0x004AE327
		public IEntityMatchSpecificBpT AsIEntityMatchSpecificBp()
		{
			return this.As<IEntityMatchSpecificBpT>();
		}

		// Token: 0x06021CB0 RID: 138416 RVA: 0x004B012F File Offset: 0x004AE32F
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchSpecificBp(IEntityMatchSpecificBpT _ientitymatchspecificbp)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchSpecificBp,
				Value = _ientitymatchspecificbp
			};
		}

		// Token: 0x06021CB1 RID: 138417 RVA: 0x004B0144 File Offset: 0x004AE344
		public static int Pack(FlatBufferBuilder builder, IEntityMatchConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEntityMatchConfig_Union.IEntityMatchConfig:
				return IEntityMatchConfig.Pack(builder, _o.AsIEntityMatchConfig()).Value;
			case IEntityMatchConfig_Union.IEntityMatchAllCharacter:
				return IEntityMatchAllCharacter.Pack(builder, _o.AsIEntityMatchAllCharacter()).Value;
			case IEntityMatchConfig_Union.IEntityMatchPlayer:
				return IEntityMatchPlayer.Pack(builder, _o.AsIEntityMatchPlayer()).Value;
			case IEntityMatchConfig_Union.IEntityMatchDynamic:
				return IEntityMatchDynamic.Pack(builder, _o.AsIEntityMatchDynamic()).Value;
			case IEntityMatchConfig_Union.IEntityMatchSpecificBp:
				return IEntityMatchSpecificBp.Pack(builder, _o.AsIEntityMatchSpecificBp()).Value;
			default:
				return 0;
			}
		}
	}
}
