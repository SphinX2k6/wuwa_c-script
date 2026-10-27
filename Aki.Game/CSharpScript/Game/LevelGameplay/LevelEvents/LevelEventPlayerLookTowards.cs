using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B4F RID: 27471
	public class LevelEventPlayerLookTowards : LevelEventBase
	{
		// Token: 0x060441B5 RID: 278965 RVA: 0x010C260F File Offset: 0x010C080F
		public LevelEventPlayerLookTowards(int id) : base(id)
		{
		}

		// Token: 0x060441B6 RID: 278966 RVA: 0x010C2618 File Offset: 0x010C0818
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PlayerLookTowards playerLookTowards = inParams as PlayerLookTowards;
			if (playerLookTowards.Target.Type == ECharacterLookAt.Position)
			{
				Vector vector = Vector.Create();
				vector.FromConfigVector((playerLookTowards.Target as ICharacterLookAtPositionData).Pos);
				PerformModel.Instance.PlayerSightTarget = vector;
			}
			else if (playerLookTowards.Target.Type == ECharacterLookAt.Unlock)
			{
				PerformModel.Instance.PlayerSightTarget = null;
			}
			else
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.FZX, "PlayerLookTowards配置类型不支持", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			base.FinishExecute(true, false, true);
		}
	}
}
