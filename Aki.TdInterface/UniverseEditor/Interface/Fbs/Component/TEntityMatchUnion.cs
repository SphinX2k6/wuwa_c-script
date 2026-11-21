using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006232 RID: 25138
	public class TEntityMatchUnion
	{
		// Token: 0x1700BB38 RID: 47928
		// (get) Token: 0x0602ACC5 RID: 175301 RVA: 0x005D86B2 File Offset: 0x005D68B2
		// (set) Token: 0x0602ACC6 RID: 175302 RVA: 0x005D86BA File Offset: 0x005D68BA
		public TEntityMatch Type { get; set; }

		// Token: 0x1700BB39 RID: 47929
		// (get) Token: 0x0602ACC7 RID: 175303 RVA: 0x005D86C3 File Offset: 0x005D68C3
		// (set) Token: 0x0602ACC8 RID: 175304 RVA: 0x005D86CB File Offset: 0x005D68CB
		public object Value { get; set; }

		// Token: 0x0602ACC9 RID: 175305 RVA: 0x005D86D4 File Offset: 0x005D68D4
		public TEntityMatchUnion()
		{
			this.Type = TEntityMatch.NONE;
			this.Value = null;
		}

		// Token: 0x0602ACCA RID: 175306 RVA: 0x005D86EA File Offset: 0x005D68EA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ACCB RID: 175307 RVA: 0x005D86FC File Offset: 0x005D68FC
		public IEntityMatchAllCharacterT AsIEntityMatchAllCharacter()
		{
			return this.As<IEntityMatchAllCharacterT>();
		}

		// Token: 0x0602ACCC RID: 175308 RVA: 0x005D8704 File Offset: 0x005D6904
		public static TEntityMatchUnion FromIEntityMatchAllCharacter(IEntityMatchAllCharacterT _ientitymatchallcharacter)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchAllCharacter,
				Value = _ientitymatchallcharacter
			};
		}

		// Token: 0x0602ACCD RID: 175309 RVA: 0x005D8719 File Offset: 0x005D6919
		public IEntityMatchDynamicT AsIEntityMatchDynamic()
		{
			return this.As<IEntityMatchDynamicT>();
		}

		// Token: 0x0602ACCE RID: 175310 RVA: 0x005D8721 File Offset: 0x005D6921
		public static TEntityMatchUnion FromIEntityMatchDynamic(IEntityMatchDynamicT _ientitymatchdynamic)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchDynamic,
				Value = _ientitymatchdynamic
			};
		}

		// Token: 0x0602ACCF RID: 175311 RVA: 0x005D8736 File Offset: 0x005D6936
		public IEntityMatchPlayerT AsIEntityMatchPlayer()
		{
			return this.As<IEntityMatchPlayerT>();
		}

		// Token: 0x0602ACD0 RID: 175312 RVA: 0x005D873E File Offset: 0x005D693E
		public static TEntityMatchUnion FromIEntityMatchPlayer(IEntityMatchPlayerT _ientitymatchplayer)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchPlayer,
				Value = _ientitymatchplayer
			};
		}

		// Token: 0x0602ACD1 RID: 175313 RVA: 0x005D8753 File Offset: 0x005D6953
		public IEntityMatchSpecificBpT AsIEntityMatchSpecificBp()
		{
			return this.As<IEntityMatchSpecificBpT>();
		}

		// Token: 0x0602ACD2 RID: 175314 RVA: 0x005D875B File Offset: 0x005D695B
		public static TEntityMatchUnion FromIEntityMatchSpecificBp(IEntityMatchSpecificBpT _ientitymatchspecificbp)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchSpecificBp,
				Value = _ientitymatchspecificbp
			};
		}

		// Token: 0x0602ACD3 RID: 175315 RVA: 0x005D8770 File Offset: 0x005D6970
		public static int Pack(FlatBufferBuilder builder, TEntityMatchUnion _o)
		{
			switch (_o.Type)
			{
			case TEntityMatch.IEntityMatchAllCharacter:
				return IEntityMatchAllCharacter.Pack(builder, _o.AsIEntityMatchAllCharacter()).Value;
			case TEntityMatch.IEntityMatchDynamic:
				return IEntityMatchDynamic.Pack(builder, _o.AsIEntityMatchDynamic()).Value;
			case TEntityMatch.IEntityMatchPlayer:
				return IEntityMatchPlayer.Pack(builder, _o.AsIEntityMatchPlayer()).Value;
			case TEntityMatch.IEntityMatchSpecificBp:
				return IEntityMatchSpecificBp.Pack(builder, _o.AsIEntityMatchSpecificBp()).Value;
			default:
				return 0;
			}
		}
	}
}
