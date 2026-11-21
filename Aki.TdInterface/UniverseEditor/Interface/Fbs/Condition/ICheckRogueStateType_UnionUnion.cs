using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005002 RID: 20482
	public class ICheckRogueStateType_UnionUnion
	{
		// Token: 0x17009286 RID: 37510
		// (get) Token: 0x0601FF63 RID: 130915 RVA: 0x0046FBC5 File Offset: 0x0046DDC5
		// (set) Token: 0x0601FF64 RID: 130916 RVA: 0x0046FBCD File Offset: 0x0046DDCD
		public ICheckRogueStateType_Union Type { get; set; }

		// Token: 0x17009287 RID: 37511
		// (get) Token: 0x0601FF65 RID: 130917 RVA: 0x0046FBD6 File Offset: 0x0046DDD6
		// (set) Token: 0x0601FF66 RID: 130918 RVA: 0x0046FBDE File Offset: 0x0046DDDE
		public object Value { get; set; }

		// Token: 0x0601FF67 RID: 130919 RVA: 0x0046FBE7 File Offset: 0x0046DDE7
		public ICheckRogueStateType_UnionUnion()
		{
			this.Type = ICheckRogueStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FF68 RID: 130920 RVA: 0x0046FBFD File Offset: 0x0046DDFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FF69 RID: 130921 RVA: 0x0046FC0F File Offset: 0x0046DE0F
		public ICheckRogueStateTypeT AsICheckRogueStateType()
		{
			return this.As<ICheckRogueStateTypeT>();
		}

		// Token: 0x0601FF6A RID: 130922 RVA: 0x0046FC17 File Offset: 0x0046DE17
		public static ICheckRogueStateType_UnionUnion FromICheckRogueStateType(ICheckRogueStateTypeT _icheckroguestatetype)
		{
			return new ICheckRogueStateType_UnionUnion
			{
				Type = ICheckRogueStateType_Union.ICheckRogueStateType,
				Value = _icheckroguestatetype
			};
		}

		// Token: 0x0601FF6B RID: 130923 RVA: 0x0046FC2C File Offset: 0x0046DE2C
		public ICheckRogueTalentT AsICheckRogueTalent()
		{
			return this.As<ICheckRogueTalentT>();
		}

		// Token: 0x0601FF6C RID: 130924 RVA: 0x0046FC34 File Offset: 0x0046DE34
		public static ICheckRogueStateType_UnionUnion FromICheckRogueTalent(ICheckRogueTalentT _icheckroguetalent)
		{
			return new ICheckRogueStateType_UnionUnion
			{
				Type = ICheckRogueStateType_Union.ICheckRogueTalent,
				Value = _icheckroguetalent
			};
		}

		// Token: 0x0601FF6D RID: 130925 RVA: 0x0046FC49 File Offset: 0x0046DE49
		public ICheckRogueMiracleCreationT AsICheckRogueMiracleCreation()
		{
			return this.As<ICheckRogueMiracleCreationT>();
		}

		// Token: 0x0601FF6E RID: 130926 RVA: 0x0046FC51 File Offset: 0x0046DE51
		public static ICheckRogueStateType_UnionUnion FromICheckRogueMiracleCreation(ICheckRogueMiracleCreationT _icheckroguemiraclecreation)
		{
			return new ICheckRogueStateType_UnionUnion
			{
				Type = ICheckRogueStateType_Union.ICheckRogueMiracleCreation,
				Value = _icheckroguemiraclecreation
			};
		}

		// Token: 0x0601FF6F RID: 130927 RVA: 0x0046FC68 File Offset: 0x0046DE68
		public static int Pack(FlatBufferBuilder builder, ICheckRogueStateType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckRogueStateType_Union.ICheckRogueStateType:
				return ICheckRogueStateType.Pack(builder, _o.AsICheckRogueStateType()).Value;
			case ICheckRogueStateType_Union.ICheckRogueTalent:
				return ICheckRogueTalent.Pack(builder, _o.AsICheckRogueTalent()).Value;
			case ICheckRogueStateType_Union.ICheckRogueMiracleCreation:
				return ICheckRogueMiracleCreation.Pack(builder, _o.AsICheckRogueMiracleCreation()).Value;
			default:
				return 0;
			}
		}
	}
}
