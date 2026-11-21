using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C29 RID: 19497
	public class IEntityOwnerInfo_UnionUnion
	{
		// Token: 0x17008A31 RID: 35377
		// (get) Token: 0x0601DD9C RID: 122268 RVA: 0x0042FB0D File Offset: 0x0042DD0D
		// (set) Token: 0x0601DD9D RID: 122269 RVA: 0x0042FB15 File Offset: 0x0042DD15
		public IEntityOwnerInfo_Union Type { get; set; }

		// Token: 0x17008A32 RID: 35378
		// (get) Token: 0x0601DD9E RID: 122270 RVA: 0x0042FB1E File Offset: 0x0042DD1E
		// (set) Token: 0x0601DD9F RID: 122271 RVA: 0x0042FB26 File Offset: 0x0042DD26
		public object Value { get; set; }

		// Token: 0x0601DDA0 RID: 122272 RVA: 0x0042FB2F File Offset: 0x0042DD2F
		public IEntityOwnerInfo_UnionUnion()
		{
			this.Type = IEntityOwnerInfo_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601DDA1 RID: 122273 RVA: 0x0042FB45 File Offset: 0x0042DD45
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601DDA2 RID: 122274 RVA: 0x0042FB57 File Offset: 0x0042DD57
		public IEntityOwnerInfoT AsIEntityOwnerInfo()
		{
			return this.As<IEntityOwnerInfoT>();
		}

		// Token: 0x0601DDA3 RID: 122275 RVA: 0x0042FB5F File Offset: 0x0042DD5F
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerInfo(IEntityOwnerInfoT _ientityownerinfo)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerInfo,
				Value = _ientityownerinfo
			};
		}

		// Token: 0x0601DDA4 RID: 122276 RVA: 0x0042FB74 File Offset: 0x0042DD74
		public IEntityOwnerQuestT AsIEntityOwnerQuest()
		{
			return this.As<IEntityOwnerQuestT>();
		}

		// Token: 0x0601DDA5 RID: 122277 RVA: 0x0042FB7C File Offset: 0x0042DD7C
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerQuest(IEntityOwnerQuestT _ientityownerquest)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerQuest,
				Value = _ientityownerquest
			};
		}

		// Token: 0x0601DDA6 RID: 122278 RVA: 0x0042FB91 File Offset: 0x0042DD91
		public IEntityOwnerLevelPlayT AsIEntityOwnerLevelPlay()
		{
			return this.As<IEntityOwnerLevelPlayT>();
		}

		// Token: 0x0601DDA7 RID: 122279 RVA: 0x0042FB99 File Offset: 0x0042DD99
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerLevelPlay(IEntityOwnerLevelPlayT _ientityownerlevelplay)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerLevelPlay,
				Value = _ientityownerlevelplay
			};
		}

		// Token: 0x0601DDA8 RID: 122280 RVA: 0x0042FBAE File Offset: 0x0042DDAE
		public IEntityOwnerEntityT AsIEntityOwnerEntity()
		{
			return this.As<IEntityOwnerEntityT>();
		}

		// Token: 0x0601DDA9 RID: 122281 RVA: 0x0042FBB6 File Offset: 0x0042DDB6
		public static IEntityOwnerInfo_UnionUnion FromIEntityOwnerEntity(IEntityOwnerEntityT _ientityownerentity)
		{
			return new IEntityOwnerInfo_UnionUnion
			{
				Type = IEntityOwnerInfo_Union.IEntityOwnerEntity,
				Value = _ientityownerentity
			};
		}

		// Token: 0x0601DDAA RID: 122282 RVA: 0x0042FBCC File Offset: 0x0042DDCC
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
