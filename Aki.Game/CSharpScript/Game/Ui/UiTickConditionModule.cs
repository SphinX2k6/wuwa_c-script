using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003615 RID: 13845
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTickConditionModule
	{
		// Token: 0x0602340B RID: 144395 RVA: 0x00A03731 File Offset: 0x00A01931
		public UiTickConditionModule(string tag)
		{
			this.Tag = tag;
		}

		// Token: 0x0602340C RID: 144396 RVA: 0x00A03748 File Offset: 0x00A01948
		public void StartTick(Func<float, bool> checkCondition, Action<float> stopCallback, Action<float> finishCallback)
		{
			this.CheckCondition = checkCondition;
			this.StopCallback = stopCallback;
			this.FinishCallback = finishCallback;
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.Tick), "UiTickConditionModule", ETickingGroup.TG_PrePhysics, true, 0, false).Id;
		}

		// Token: 0x0602340D RID: 144397 RVA: 0x00A03794 File Offset: 0x00A01994
		public void ManualStopTick()
		{
			if (this.StopCallback == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiTickConditionModule;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "手动停止Tick,执行停止回调";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("标识", this.Tag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action<float> stopCallback = this.StopCallback;
			if (stopCallback != null)
			{
				stopCallback(this.CurrentTickTime);
			}
			this.StopTick();
		}

		// Token: 0x0602340E RID: 144398 RVA: 0x00A037F6 File Offset: 0x00A019F6
		private void StopTick()
		{
			this.RemoveTick();
			this.CurrentTickTime = 0f;
			this.CheckCondition = null;
			this.StopCallback = null;
			this.FinishCallback = null;
		}

		// Token: 0x0602340F RID: 144399 RVA: 0x00A0381E File Offset: 0x00A01A1E
		private void RemoveTick()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
			}
		}

		// Token: 0x06023410 RID: 144400 RVA: 0x00A0383C File Offset: 0x00A01A3C
		private void Tick(float deltaTime)
		{
			Func<float, bool> checkCondition = this.CheckCondition;
			if (checkCondition != null && checkCondition(deltaTime))
			{
				Action<float> finishCallback = this.FinishCallback;
				if (finishCallback != null)
				{
					finishCallback(this.CurrentTickTime);
				}
				Action<float> stopCallback = this.StopCallback;
				if (stopCallback != null)
				{
					stopCallback(this.CurrentTickTime);
				}
				this.StopTick();
				return;
			}
			this.CurrentTickTime += deltaTime;
		}

		// Token: 0x04013DFD RID: 81405
		private readonly string Tag;

		// Token: 0x04013DFE RID: 81406
		private Action<float> FinishCallback;

		// Token: 0x04013DFF RID: 81407
		private Action<float> StopCallback;

		// Token: 0x04013E00 RID: 81408
		private Func<float, bool> CheckCondition;

		// Token: 0x04013E01 RID: 81409
		private float CurrentTickTime;

		// Token: 0x04013E02 RID: 81410
		private int TickId = -1;
	}
}
