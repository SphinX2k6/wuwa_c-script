using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C13 RID: 23571
	public class TEntityMatchUnion
	{
		// Token: 0x1700B1EA RID: 45546
		// (get) Token: 0x060286D5 RID: 165589 RVA: 0x0059076A File Offset: 0x0058E96A
		// (set) Token: 0x060286D6 RID: 165590 RVA: 0x00590772 File Offset: 0x0058E972
		public TEntityMatch Type { get; set; }

		// Token: 0x1700B1EB RID: 45547
		// (get) Token: 0x060286D7 RID: 165591 RVA: 0x0059077B File Offset: 0x0058E97B
		// (set) Token: 0x060286D8 RID: 165592 RVA: 0x00590783 File Offset: 0x0058E983
		public object Value { get; set; }

		// Token: 0x060286D9 RID: 165593 RVA: 0x0059078C File Offset: 0x0058E98C
		public TEntityMatchUnion()
		{
			this.Type = TEntityMatch.NONE;
			this.Value = null;
		}

		// Token: 0x060286DA RID: 165594 RVA: 0x005907A2 File Offset: 0x0058E9A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060286DB RID: 165595 RVA: 0x005907B4 File Offset: 0x0058E9B4
		public IEntityMatchAllCharacterT AsIEntityMatchAllCharacter()
		{
			return this.As<IEntityMatchAllCharacterT>();
		}

		// Token: 0x060286DC RID: 165596 RVA: 0x005907BC File Offset: 0x0058E9BC
		public static TEntityMatchUnion FromIEntityMatchAllCharacter(IEntityMatchAllCharacterT _ientitymatchallcharacter)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchAllCharacter,
				Value = _ientitymatchallcharacter
			};
		}

		// Token: 0x060286DD RID: 165597 RVA: 0x005907D1 File Offset: 0x0058E9D1
		public IEntityMatchDynamicT AsIEntityMatchDynamic()
		{
			return this.As<IEntityMatchDynamicT>();
		}

		// Token: 0x060286DE RID: 165598 RVA: 0x005907D9 File Offset: 0x0058E9D9
		public static TEntityMatchUnion FromIEntityMatchDynamic(IEntityMatchDynamicT _ientitymatchdynamic)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchDynamic,
				Value = _ientitymatchdynamic
			};
		}

		// Token: 0x060286DF RID: 165599 RVA: 0x005907EE File Offset: 0x0058E9EE
		public IEntityMatchPlayerT AsIEntityMatchPlayer()
		{
			return this.As<IEntityMatchPlayerT>();
		}

		// Token: 0x060286E0 RID: 165600 RVA: 0x005907F6 File Offset: 0x0058E9F6
		public static TEntityMatchUnion FromIEntityMatchPlayer(IEntityMatchPlayerT _ientitymatchplayer)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchPlayer,
				Value = _ientitymatchplayer
			};
		}

		// Token: 0x060286E1 RID: 165601 RVA: 0x0059080B File Offset: 0x0058EA0B
		public IEntityMatchSpecificBpT AsIEntityMatchSpecificBp()
		{
			return this.As<IEntityMatchSpecificBpT>();
		}

		// Token: 0x060286E2 RID: 165602 RVA: 0x00590813 File Offset: 0x0058EA13
		public static TEntityMatchUnion FromIEntityMatchSpecificBp(IEntityMatchSpecificBpT _ientitymatchspecificbp)
		{
			return new TEntityMatchUnion
			{
				Type = TEntityMatch.IEntityMatchSpecificBp,
				Value = _ientitymatchspecificbp
			};
		}

		// Token: 0x060286E3 RID: 165603 RVA: 0x00590828 File Offset: 0x0058EA28
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
