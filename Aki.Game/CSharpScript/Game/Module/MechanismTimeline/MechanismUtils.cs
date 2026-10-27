using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200547F RID: 21631
	[NullableContext(1)]
	[Nullable(0)]
	public class MechanismUtils
	{
		// Token: 0x06037314 RID: 226068 RVA: 0x00D165CF File Offset: 0x00D147CF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<IEventData> GetAllAnimNotifyEvents(ULevelSequence sequence)
		{
			return MechanismUtils.GetAllEvents(sequence, false);
		}

		// Token: 0x06037315 RID: 226069 RVA: 0x00D165D8 File Offset: 0x00D147D8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static List<IEventData> GetAllAnimNotifyStateEvents(ULevelSequence sequence)
		{
			return MechanismUtils.GetAllEvents(sequence, true);
		}

		// Token: 0x06037316 RID: 226070 RVA: 0x00D165E4 File Offset: 0x00D147E4
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

		// Token: 0x06037317 RID: 226071 RVA: 0x00D16618 File Offset: 0x00D14818
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

		// Token: 0x06037318 RID: 226072 RVA: 0x00D1664C File Offset: 0x00D1484C
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

		// Token: 0x06037319 RID: 226073 RVA: 0x00D1668F File Offset: 0x00D1488F
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
