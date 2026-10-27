using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B1A RID: 27418
	public class LevelEventEnableTakePhotoClip : LevelEventBase
	{
		// Token: 0x060440B1 RID: 278705 RVA: 0x010B9E2E File Offset: 0x010B802E
		public LevelEventEnableTakePhotoClip(int id) : base(id)
		{
		}

		// Token: 0x060440B2 RID: 278706 RVA: 0x010B9E38 File Offset: 0x010B8038
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
