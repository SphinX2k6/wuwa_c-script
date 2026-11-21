using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045EB RID: 17899
	public class MapRogueGridFog : UiPanelBase
	{
		// Token: 0x0602D02C RID: 184364 RVA: 0x00C95FC1 File Offset: 0x00C941C1
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x0602D02D RID: 184365 RVA: 0x00C95FC3 File Offset: 0x00C941C3
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602D02E RID: 184366 RVA: 0x00C95FD8 File Offset: 0x00C941D8
		public void SetVision(bool bHasVision, bool bAnim)
		{
			if (this.HasVision == bHasVision)
			{
				return;
			}
			this.HasVision = bHasVision;
			if (bHasVision)
			{
				string[] array = new string[]
				{
					"Disappear",
					"Disappear1",
					"Disappear2"
				};
				int num = (int)Math.Floor(new Random().NextDouble() * (double)array.Length);
				CustomPromise<bool> stopPromise = new CustomPromise<bool>();
				this.LevelSequencePlayer.PlaySequenceAsync(array[num], stopPromise, false, false, null, false).ContinueWith(delegate()
				{
					this.SetActive(false);
				});
				return;
			}
			this.SetActive(true);
		}

		// Token: 0x0401823F RID: 98879
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018240 RID: 98880
		private bool HasVision;
	}
}
