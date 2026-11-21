using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C65 RID: 19557
	public class TEntityOwnerUnion
	{
		// Token: 0x17008AB5 RID: 35509
		// (get) Token: 0x0601E008 RID: 122888 RVA: 0x00434B1E File Offset: 0x00432D1E
		// (set) Token: 0x0601E009 RID: 122889 RVA: 0x00434B26 File Offset: 0x00432D26
		public TEntityOwner Type { get; set; }

		// Token: 0x17008AB6 RID: 35510
		// (get) Token: 0x0601E00A RID: 122890 RVA: 0x00434B2F File Offset: 0x00432D2F
		// (set) Token: 0x0601E00B RID: 122891 RVA: 0x00434B37 File Offset: 0x00432D37
		public object Value { get; set; }

		// Token: 0x0601E00C RID: 122892 RVA: 0x00434B40 File Offset: 0x00432D40
		public TEntityOwnerUnion()
		{
			this.Type = TEntityOwner.NONE;
			this.Value = null;
		}

		// Token: 0x0601E00D RID: 122893 RVA: 0x00434B56 File Offset: 0x00432D56
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E00E RID: 122894 RVA: 0x00434B68 File Offset: 0x00432D68
		public IEntityOwnerEntityT AsIEntityOwnerEntity()
		{
			return this.As<IEntityOwnerEntityT>();
		}

		// Token: 0x0601E00F RID: 122895 RVA: 0x00434B70 File Offset: 0x00432D70
		public static TEntityOwnerUnion FromIEntityOwnerEntity(IEntityOwnerEntityT _ientityownerentity)
		{
			return new TEntityOwnerUnion
			{
				Type = TEntityOwner.IEntityOwnerEntity,
				Value = _ientityownerentity
			};
		}

		// Token: 0x0601E010 RID: 122896 RVA: 0x00434B85 File Offset: 0x00432D85
		public IEntityOwnerLevelPlayT AsIEntityOwnerLevelPlay()
		{
			return this.As<IEntityOwnerLevelPlayT>();
		}

		// Token: 0x0601E011 RID: 122897 RVA: 0x00434B8D File Offset: 0x00432D8D
		public static TEntityOwnerUnion FromIEntityOwnerLevelPlay(IEntityOwnerLevelPlayT _ientityownerlevelplay)
		{
			return new TEntityOwnerUnion
			{
				Type = TEntityOwner.IEntityOwnerLevelPlay,
				Value = _ientityownerlevelplay
			};
		}

		// Token: 0x0601E012 RID: 122898 RVA: 0x00434BA2 File Offset: 0x00432DA2
		public IEntityOwnerQuestT AsIEntityOwnerQuest()
		{
			return this.As<IEntityOwnerQuestT>();
		}

		// Token: 0x0601E013 RID: 122899 RVA: 0x00434BAA File Offset: 0x00432DAA
		public static TEntityOwnerUnion FromIEntityOwnerQuest(IEntityOwnerQuestT _ientityownerquest)
		{
			return new TEntityOwnerUnion
			{
				Type = TEntityOwner.IEntityOwnerQuest,
				Value = _ientityownerquest
			};
		}

		// Token: 0x0601E014 RID: 122900 RVA: 0x00434BC0 File Offset: 0x00432DC0
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
