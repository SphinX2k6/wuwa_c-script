using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CC7 RID: 23751
	public class LevelEventPlayerLookTowards : LevelEventBase
	{
		// Token: 0x0603A307 RID: 238343 RVA: 0x0106C1C3 File Offset: 0x0106A3C3
		public LevelEventPlayerLookTowards(int id) : base(id)
		{
		}

		// Token: 0x0603A308 RID: 238344 RVA: 0x0106C1CC File Offset: 0x0106A3CC
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
