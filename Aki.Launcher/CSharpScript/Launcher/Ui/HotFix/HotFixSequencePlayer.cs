using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E7 RID: 231
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixSequencePlayer
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x0003D806 File Offset: 0x0003BA06
		public HotFixSequencePlayer(UUIItem uiItem)
		{
			this.UiItem = uiItem;
			this.UiBaseActor = (uiItem.GetOwner() as AUIBaseActor);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0003D834 File Offset: 0x0003BA34
		[return: Nullable(2)]
		private USequencePlayContext GetSequencePlayContext(string sequenceName)
		{
			USequencePlayContext sequencePlayContextOfKey;
			if (!this.PlayContextMap.TryGetValue(sequenceName, out sequencePlayContextOfKey))
			{
				sequencePlayContextOfKey = this.UiBaseActor.GetSequencePlayContextOfKey(sequenceName);
				if (sequencePlayContextOfKey == null)
				{
					return null;
				}
				sequencePlayContextOfKey.bIsAsync = false;
				this.PlayContextMap[sequenceName] = sequencePlayContextOfKey;
			}
			return sequencePlayContextOfKey;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0003D878 File Offset: 0x0003BA78
		public bool PlaySequence(string sequenceName, [Nullable(2)] Action finishCallback = null)
		{
			USequencePlayContext playContext = this.GetSequencePlayContext(sequenceName);
			if (playContext == null)
			{
				LauncherLog.Instance.Warn("关卡序列不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				Action finishCallback2 = finishCallback;
				if (finishCallback2 != null)
				{
					finishCallback2();
				}
				return false;
			}
			playContext.OnFinish.Bind(delegate()
			{
				playContext.OnFinish.Unbind();
				Action finishCallback3 = finishCallback;
				if (finishCallback3 == null)
				{
					return;
				}
				finishCallback3();
			});
			playContext.ExecutePlay();
			LauncherLog instance = LauncherLog.Instance;
			string message = "播放关卡序列";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SequenceName", sequenceName);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0003D920 File Offset: 0x0003BB20
		public bool StopSequence(string sequenceName, bool toLastFrame = false, [Nullable(2)] Action stopCallback = null)
		{
			if (this.UiItem.LevelSequences.GetValueOrDefault(sequenceName) == null)
			{
				return false;
			}
			ALevelSequenceActor sequencePlayerByKey = this.UiBaseActor.GetSequencePlayerByKey(sequenceName);
			if (sequencePlayerByKey == null)
			{
				return false;
			}
			USequencePlayContext usequencePlayContext;
			if (!this.PlayContextMap.TryGetValue(sequenceName, out usequencePlayContext))
			{
				return false;
			}
			if (toLastFrame)
			{
				AUIBaseActor uiBaseActor = this.UiBaseActor;
				FFrameTime time = sequencePlayerByKey.SequencePlayer.GetDuration().Time;
				uiBaseActor.SequenceJumpToSecondByKey(sequenceName, time);
			}
			usequencePlayContext.TryStop();
			if (stopCallback != null)
			{
				stopCallback();
			}
			return true;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0003D99E File Offset: 0x0003BB9E
		public void ClearSequence()
		{
			this.PlayContextMap.Clear();
			this.UiBaseActor.ClearAllSequence();
			this.UiBaseActor = null;
			this.UiItem = null;
		}

		// Token: 0x040004A5 RID: 1189
		[Nullable(2)]
		private AUIBaseActor UiBaseActor;

		// Token: 0x040004A6 RID: 1190
		[Nullable(2)]
		private UUIItem UiItem;

		// Token: 0x040004A7 RID: 1191
		private readonly Dictionary<string, USequencePlayContext> PlayContextMap = new Dictionary<string, USequencePlayContext>();
	}
}
