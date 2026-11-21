using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FE RID: 22270
	public class IEntityMatchConfig_UnionUnion
	{
		// Token: 0x1700A08B RID: 41099
		// (get) Token: 0x06023BF9 RID: 146425 RVA: 0x004EA089 File Offset: 0x004E8289
		// (set) Token: 0x06023BFA RID: 146426 RVA: 0x004EA091 File Offset: 0x004E8291
		public IEntityMatchConfig_Union Type { get; set; }

		// Token: 0x1700A08C RID: 41100
		// (get) Token: 0x06023BFB RID: 146427 RVA: 0x004EA09A File Offset: 0x004E829A
		// (set) Token: 0x06023BFC RID: 146428 RVA: 0x004EA0A2 File Offset: 0x004E82A2
		public object Value { get; set; }

		// Token: 0x06023BFD RID: 146429 RVA: 0x004EA0AB File Offset: 0x004E82AB
		public IEntityMatchConfig_UnionUnion()
		{
			this.Type = IEntityMatchConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023BFE RID: 146430 RVA: 0x004EA0C1 File Offset: 0x004E82C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023BFF RID: 146431 RVA: 0x004EA0D3 File Offset: 0x004E82D3
		public IEntityMatchConfigT AsIEntityMatchConfig()
		{
			return this.As<IEntityMatchConfigT>();
		}

		// Token: 0x06023C00 RID: 146432 RVA: 0x004EA0DB File Offset: 0x004E82DB
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchConfig(IEntityMatchConfigT _ientitymatchconfig)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchConfig,
				Value = _ientitymatchconfig
			};
		}

		// Token: 0x06023C01 RID: 146433 RVA: 0x004EA0F0 File Offset: 0x004E82F0
		public IEntityMatchAllCharacterT AsIEntityMatchAllCharacter()
		{
			return this.As<IEntityMatchAllCharacterT>();
		}

		// Token: 0x06023C02 RID: 146434 RVA: 0x004EA0F8 File Offset: 0x004E82F8
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchAllCharacter(IEntityMatchAllCharacterT _ientitymatchallcharacter)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchAllCharacter,
				Value = _ientitymatchallcharacter
			};
		}

		// Token: 0x06023C03 RID: 146435 RVA: 0x004EA10D File Offset: 0x004E830D
		public IEntityMatchPlayerT AsIEntityMatchPlayer()
		{
			return this.As<IEntityMatchPlayerT>();
		}

		// Token: 0x06023C04 RID: 146436 RVA: 0x004EA115 File Offset: 0x004E8315
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchPlayer(IEntityMatchPlayerT _ientitymatchplayer)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchPlayer,
				Value = _ientitymatchplayer
			};
		}

		// Token: 0x06023C05 RID: 146437 RVA: 0x004EA12A File Offset: 0x004E832A
		public IEntityMatchDynamicT AsIEntityMatchDynamic()
		{
			return this.As<IEntityMatchDynamicT>();
		}

		// Token: 0x06023C06 RID: 146438 RVA: 0x004EA132 File Offset: 0x004E8332
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchDynamic(IEntityMatchDynamicT _ientitymatchdynamic)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchDynamic,
				Value = _ientitymatchdynamic
			};
		}

		// Token: 0x06023C07 RID: 146439 RVA: 0x004EA147 File Offset: 0x004E8347
		public IEntityMatchSpecificBpT AsIEntityMatchSpecificBp()
		{
			return this.As<IEntityMatchSpecificBpT>();
		}

		// Token: 0x06023C08 RID: 146440 RVA: 0x004EA14F File Offset: 0x004E834F
		public static IEntityMatchConfig_UnionUnion FromIEntityMatchSpecificBp(IEntityMatchSpecificBpT _ientitymatchspecificbp)
		{
			return new IEntityMatchConfig_UnionUnion
			{
				Type = IEntityMatchConfig_Union.IEntityMatchSpecificBp,
				Value = _ientitymatchspecificbp
			};
		}

		// Token: 0x06023C09 RID: 146441 RVA: 0x004EA164 File Offset: 0x004E8364
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
