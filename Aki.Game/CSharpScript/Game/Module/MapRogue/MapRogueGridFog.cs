using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005615 RID: 22037
	public class MapRogueGridFog : UiPanelBase
	{
		// Token: 0x0603812E RID: 229678 RVA: 0x00D48279 File Offset: 0x00D46479
		protected override void OnRegisterComponent()
		{
		}

		// Token: 0x0603812F RID: 229679 RVA: 0x00D4827B File Offset: 0x00D4647B
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038130 RID: 229680 RVA: 0x00D48290 File Offset: 0x00D46490
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

		// Token: 0x0401D7B4 RID: 120756
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D7B5 RID: 120757
		private bool HasVision;
	}
}
