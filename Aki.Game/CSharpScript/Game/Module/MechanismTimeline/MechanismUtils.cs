using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x02004462 RID: 17506
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismUtils
	{
		// Token: 0x0602C25D RID: 180829 RVA: 0x00C65A27 File Offset: 0x00C63C27
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<IEventData> GetAllAnimNotifyEvents(ULevelSequence sequence)
		{
			return MechanismUtils.GetAllEvents(sequence, false);
		}

		// Token: 0x0602C25E RID: 180830 RVA: 0x00C65A30 File Offset: 0x00C63C30
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<IEventData> GetAllAnimNotifyStateEvents(ULevelSequence sequence)
		{
			return MechanismUtils.GetAllEvents(sequence, true);
		}

		// Token: 0x0602C25F RID: 180831 RVA: 0x00C65A3C File Offset: 0x00C63C3C
		public static void GetAllAnimNotifyEventsByPath(string sequencePath, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<List<IEventData>> callback)
		{
			MechanismUtils.LoadSequenceAsset(sequencePath).ContinueWith(delegate(ULevelSequence sequence)
			{
				if (sequence != null)
				{
					List<IEventData> allAnimNotifyEvents = MechanismUtils.GetAllAnimNotifyEvents(sequence);
					callback(allAnimNotifyEvents);
				}
			});
		}

		// Token: 0x0602C260 RID: 180832 RVA: 0x00C65A70 File Offset: 0x00C63C70
		public static void GetAllAnimNotifyStateEventsByPath(string sequencePath, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<List<IEventData>> callback)
		{
			MechanismUtils.LoadSequenceAsset(sequencePath).ContinueWith(delegate(ULevelSequence sequence)
			{
				if (sequence != null)
				{
					List<IEventData> allAnimNotifyStateEvents = MechanismUtils.GetAllAnimNotifyStateEvents(sequence);
					callback(allAnimNotifyStateEvents);
				}
			});
		}

		// Token: 0x0602C261 RID: 180833 RVA: 0x00C65AA4 File Offset: 0x00C63CA4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<ULevelSequence> LoadSequenceAsset(string sequencePath)
		{
			MechanismUtils.<LoadSequenceAsset>d__4 <LoadSequenceAsset>d__;
			<LoadSequenceAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<ULevelSequence>.Create();
			<LoadSequenceAsset>d__.sequencePath = sequencePath;
			<LoadSequenceAsset>d__.<>1__state = -1;
			<LoadSequenceAsset>d__.<>t__builder.Start<MechanismUtils.<LoadSequenceAsset>d__4>(ref <LoadSequenceAsset>d__);
			return <LoadSequenceAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0602C262 RID: 180834 RVA: 0x00C65AE7 File Offset: 0x00C63CE7
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<IEventData> GetAllEvents(ULevelSequence sequence, bool bAns)
		{
			return null;
		}
	}
}
