using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047C1 RID: 18369
	public class IEntityOwnerInfo_UnionUnion
	{
		// Token: 0x170083F0 RID: 33776
		// (get) Token: 0x0601C5C7 RID: 116167 RVA: 0x00403871 File Offset: 0x00401A71
		// (set) Token: 0x0601C5C8 RID: 116168 RVA: 0x00403879 File Offset: 0x00401A79
		public IEntityOwnerInfo_Union Type { get; set; }

		// Token: 0x170083F1 RID: 33777
		// (get) Token: 0x0601C5C9 RID: 116169 RVA: 0x00403882 File Offset: 0x00401A82
		// (set) Token: 0x0601C5CA RID: 116170 RVA: 0x0040388A File Offset: 0x00401A8A
		public object Value { get; set; }

		// Token: 0x0601C5CB RID: 116171 RVA: 0x00403893 File Offset: 0x00401A93
		public IEntityOwnerInfo_UnionUnion()
		{
			this.Type = IEntityOwnerInfo_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C5CC RID: 116172 RVA: 0x004038A9 File Offset: 0x00401AA9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C5CD RID: 116173 RVA: 0x004038BB File Offset: 0x00401ABB
		public IEntityOwnerInfoT AsIEntityOwnerInfo()
		{
			return this.As<IEntityOwnerInfoT>();
		}

		// Token: 0x0601C5CE RID: 116174 RVA: 0x004038C3 File Offset: 0x00401AC3
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerInfo(IEntityOwnerInfoT _ientityownerinfo)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerInfo,
				Value = _ientityownerinfo
			};
		}

		// Token: 0x0601C5CF RID: 116175 RVA: 0x004038D8 File Offset: 0x00401AD8
		public IEntityOwnerQuestT AsIEntityOwnerQuest()
		{
			return this.As<IEntityOwnerQuestT>();
		}

		// Token: 0x0601C5D0 RID: 116176 RVA: 0x004038E0 File Offset: 0x00401AE0
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerQuest(IEntityOwnerQuestT _ientityownerquest)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerQuest,
				Value = _ientityownerquest
			};
		}

		// Token: 0x0601C5D1 RID: 116177 RVA: 0x004038F5 File Offset: 0x00401AF5
		public IEntityOwnerLevelPlayT AsIEntityOwnerLevelPlay()
		{
			return this.As<IEntityOwnerLevelPlayT>();
		}

		// Token: 0x0601C5D2 RID: 116178 RVA: 0x004038FD File Offset: 0x00401AFD
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerLevelPlay(IEntityOwnerLevelPlayT _ientityownerlevelplay)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerLevelPlay,
				Value = _ientityownerlevelplay
			};
		}

		// Token: 0x0601C5D3 RID: 116179 RVA: 0x00403912 File Offset: 0x00401B12
		public IEntityOwnerEntityT AsIEntityOwnerEntity()
		{
			return this.As<IEntityOwnerEntityT>();
		}

		// Token: 0x0601C5D4 RID: 116180 RVA: 0x0040391A File Offset: 0x00401B1A
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerEntity(IEntityOwnerEntityT _ientityownerentity)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerEntity,
				Value = _ientityownerentity
			};
		}

		// Token: 0x0601C5D5 RID: 116181 RVA: 0x00403930 File Offset: 0x00401B30
		public static int Pack(FlatBufferBuilder builder, IEntityOwnerInfo_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEntityOwnerInfo_Union.IEntityOwnerInfo:
				return IEntityOwnerInfo.Pack(builder, _o.AsIEntityOwnerInfo()).Value;
			case IEntityOwnerInfo_Union.IEntityOwnerQuest:
				return IEntityOwnerQuest.Pack(builder, _o.AsIEntityOwnerQuest()).Value;
			case IEntityOwnerInfo_Union.IEntityOwnerLevelPlay:
				return IEntityOwnerLevelPlay.Pack(builder, _o.AsIEntityOwnerLevelPlay()).Value;
			case IEntityOwnerInfo_Union.IEntityOwnerEntity:
				return IEntityOwnerEntity.Pack(builder, _o.AsIEntityOwnerEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
