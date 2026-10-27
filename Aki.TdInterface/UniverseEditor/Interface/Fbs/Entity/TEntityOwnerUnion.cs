using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047FD RID: 18429
	public class TEntityOwnerUnion
	{
		// Token: 0x1700846A RID: 33898
		// (get) Token: 0x0601C80B RID: 116747 RVA: 0x004081CE File Offset: 0x004063CE
		// (set) Token: 0x0601C80C RID: 116748 RVA: 0x004081D6 File Offset: 0x004063D6
		public TEntityOwner Type { get; set; }

		// Token: 0x1700846B RID: 33899
		// (get) Token: 0x0601C80D RID: 116749 RVA: 0x004081DF File Offset: 0x004063DF
		// (set) Token: 0x0601C80E RID: 116750 RVA: 0x004081E7 File Offset: 0x004063E7
		public object Value { get; set; }

		// Token: 0x0601C80F RID: 116751 RVA: 0x004081F0 File Offset: 0x004063F0
		public TEntityOwnerUnion()
		{
			this.Type = TEntityOwner.NONE;
			this.Value = null;
		}

		// Token: 0x0601C810 RID: 116752 RVA: 0x00408206 File Offset: 0x00406406
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C811 RID: 116753 RVA: 0x00408218 File Offset: 0x00406418
		public IEntityOwnerEntityT AsIEntityOwnerEntity()
		{
			return this.As<IEntityOwnerEntityT>();
		}

		// Token: 0x0601C812 RID: 116754 RVA: 0x00408220 File Offset: 0x00406420
		public static TEntityOwnerUnion FromIEntityOwnerEntity(IEntityOwnerEntityT _ientityownerentity)
		{
			return new TEntityOwnerUnion
			{
				Type = TEntityOwner.IEntityOwnerEntity,
				Value = _ientityownerentity
			};
		}

		// Token: 0x0601C813 RID: 116755 RVA: 0x00408235 File Offset: 0x00406435
		public IEntityOwnerLevelPlayT AsIEntityOwnerLevelPlay()
		{
			return this.As<IEntityOwnerLevelPlayT>();
		}

		// Token: 0x0601C814 RID: 116756 RVA: 0x0040823D File Offset: 0x0040643D
		public static TEntityOwnerUnion FromIEntityOwnerLevelPlay(IEntityOwnerLevelPlayT _ientityownerlevelplay)
		{
			return new TEntityOwnerUnion
			{
				Type = TEntityOwner.IEntityOwnerLevelPlay,
				Value = _ientityownerlevelplay
			};
		}

		// Token: 0x0601C815 RID: 116757 RVA: 0x00408252 File Offset: 0x00406452
		public IEntityOwnerQuestT AsIEntityOwnerQuest()
		{
			return this.As<IEntityOwnerQuestT>();
		}

		// Token: 0x0601C816 RID: 116758 RVA: 0x0040825A File Offset: 0x0040645A
		public static TEntityOwnerUnion FromIEntityOwnerQuest(IEntityOwnerQuestT _ientityownerquest)
		{
			return new TEntityOwnerUnion
			{
				Type = TEntityOwner.IEntityOwnerQuest,
				Value = _ientityownerquest
			};
		}

		// Token: 0x0601C817 RID: 116759 RVA: 0x00408270 File Offset: 0x00406470
		public static int Pack(FlatBufferBuilder builder, TEntityOwnerUnion _o)
		{
			switch (_o.Type)
			{
			case TEntityOwner.IEntityOwnerEntity:
				return IEntityOwnerEntity.Pack(builder, _o.AsIEntityOwnerEntity()).Value;
			case TEntityOwner.IEntityOwnerLevelPlay:
				return IEntityOwnerLevelPlay.Pack(builder, _o.AsIEntityOwnerLevelPlay()).Value;
			case TEntityOwner.IEntityOwnerQuest:
				return IEntityOwnerQuest.Pack(builder, _o.AsIEntityOwnerQuest()).Value;
			default:
				return 0;
			}
		}
	}
}
