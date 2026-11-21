using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C92 RID: 23698
	public class LevelEventEnableTakePhotoClip : LevelEventBase
	{
		// Token: 0x0603A203 RID: 238083 RVA: 0x010636BA File Offset: 0x010618BA
		public LevelEventEnableTakePhotoClip(int id) : base(id)
		{
		}

		// Token: 0x0603A204 RID: 238084 RVA: 0x010636C4 File Offset: 0x010618C4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (context.Type.GetValueOrDefault() != EGeneralContextType.Entity)
			{
				return;
			}
			EntityContext entityContext = context as EntityContext;
			if (string.IsNullOrEmpty(entityContext.SequencePath))
			{
				return;
			}
			if ((inParams as EnableTakePhotoClip).Enable)
			{
				PhotographModel.Instance.SequenceInValidSectionSet.Add(entityContext.SequencePath);
				return;
			}
			PhotographModel.Instance.SequenceInValidSectionSet.Remove(entityContext.SequencePath);
		}
	}
}
