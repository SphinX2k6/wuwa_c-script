using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E5 RID: 18149
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTickConditionModule
	{
		// Token: 0x0602ECD0 RID: 191696 RVA: 0x00AD5C59 File Offset: 0x00AD3E59
		public UiTickConditionModule(string tag)
		{
			this.Tag = tag;
		}

		// Token: 0x0602ECD1 RID: 191697 RVA: 0x00AD5C70 File Offset: 0x00AD3E70
		public void StartTick(Func<float, bool> checkCondition, Action<float> stopCallback, Action<float> finishCallback)
		{
			this.CheckCondition = checkCondition;
			this.StopCallback = stopCallback;
			this.FinishCallback = finishCallback;
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.Tick), "UiTickConditionModule", ETickingGroup.TG_PrePhysics, true, 0, false).Id;
		}

		// Token: 0x0602ECD2 RID: 191698 RVA: 0x00AD5CBC File Offset: 0x00AD3EBC
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

		// Token: 0x0602ECD3 RID: 191699 RVA: 0x00AD5D1E File Offset: 0x00AD3F1E
		private void StopTick()
		{
			this.RemoveTick();
			this.CurrentTickTime = 0f;
			this.CheckCondition = null;
			this.StopCallback = null;
			this.FinishCallback = null;
		}

		// Token: 0x0602ECD4 RID: 191700 RVA: 0x00AD5D46 File Offset: 0x00AD3F46
		private void RemoveTick()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
			}
		}

		// Token: 0x0602ECD5 RID: 191701 RVA: 0x00AD5D64 File Offset: 0x00AD3F64
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

		// Token: 0x0401975F RID: 104287
		private readonly string Tag;

		// Token: 0x04019760 RID: 104288
		private Action<float> FinishCallback;

		// Token: 0x04019761 RID: 104289
		private Action<float> StopCallback;

		// Token: 0x04019762 RID: 104290
		private Func<float, bool> CheckCondition;

		// Token: 0x04019763 RID: 104291
		private float CurrentTickTime;

		// Token: 0x04019764 RID: 104292
		private int TickId = -1;
	}
}
