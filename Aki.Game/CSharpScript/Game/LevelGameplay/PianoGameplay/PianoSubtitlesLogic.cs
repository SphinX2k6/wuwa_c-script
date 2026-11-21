using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C29 RID: 23593
	public class PianoSubtitlesLogic
	{
		// Token: 0x06039F43 RID: 237379 RVA: 0x0104D1DC File Offset: 0x0104B3DC
		public void StartGameplay()
		{
			EventSystem.Instance.Add<int>(EEventName.OnSceneTextOpen, new Action<int>(this.OnSceneTextOpen));
			EventSystem.Instance.Add<int>(EEventName.OnSceneTextClose, new Action<int>(this.OnSceneTextClose));
		}

		// Token: 0x06039F44 RID: 237380 RVA: 0x0104D218 File Offset: 0x0104B418
		public void ExitGameplay()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnSceneTextOpen, new Action<int>(this.OnSceneTextOpen));
			EventSystem.Instance.Remove<int>(EEventName.OnSceneTextClose, new Action<int>(this.OnSceneTextClose));
			this.CurrentPlayTextComp = null;
		}

		// Token: 0x06039F45 RID: 237381 RVA: 0x0104D264 File Offset: 0x0104B464
		private void OnSceneTextOpen(int pbDataId)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) != null)
			{
				SceneItemTextComponent component = entityByPbDataId.Entity.GetComponent<SceneItemTextComponent>();
				if (component != null)
				{
					if (this.CurrentPlayTextComp != null)
					{
						this.CurrentPlayTextComp.StopTextVoice();
					}
					this.CurrentPlayTextComp = component;
				}
			}
		}

		// Token: 0x06039F46 RID: 237382 RVA: 0x0104D2B4 File Offset: 0x0104B4B4
		private void OnSceneTextClose(int pbDataId)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) != null)
			{
				SceneItemTextComponent component = entityByPbDataId.Entity.GetComponent<SceneItemTextComponent>();
				if (component != null && this.CurrentPlayTextComp == component)
				{
					this.CurrentPlayTextComp = null;
				}
			}
		}

		// Token: 0x0401EA53 RID: 125523
		[Nullable(2)]
		private SceneItemTextComponent CurrentPlayTextComp;
	}
}
