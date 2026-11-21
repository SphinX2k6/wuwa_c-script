using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Core.Utils
{
	// Token: 0x02000117 RID: 279
	[NullableContext(1)]
	[Nullable(0)]
	public class OverlapTestUtils : Singleton
	{
		// Token: 0x06000A6D RID: 2669 RVA: 0x00034318 File Offset: 0x00032518
		public static bool BoxOverlapAnyTestByProfile(UObject worldContextObject, IVector boxPosition, FVector boxHalfExtent, FRotator boxOrientation, FName profileName, bool bTraceComplex, TArray<AActor> actorsToIgnore, string profileKey)
		{
			return UKuroOverlapTestLibrary.BoxOverlapAnyTestByProfile(worldContextObject, boxPosition.X, boxPosition.Y, boxPosition.Z, boxHalfExtent, boxOrientation, profileName, bTraceComplex, actorsToIgnore, profileKey);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00034349 File Offset: 0x00032549
		public static OverlapTestUtils Instance
		{
			get
			{
				if (OverlapTestUtils._instance == null)
				{
					OverlapTestUtils._instance = new OverlapTestUtils();
					OverlapTestUtils._instance.OnInit();
				}
				return OverlapTestUtils._instance;
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0003436C File Offset: 0x0003256C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0003436E File Offset: 0x0003256E
		public static void ResetStaticDefaultValue()
		{
			OverlapTestUtils instance = OverlapTestUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			OverlapTestUtils._instance = null;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00034387 File Offset: 0x00032587
		static OverlapTestUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(OverlapTestUtils.CreateStaticDefaultValue), new Action(OverlapTestUtils.ResetStaticDefaultValue));
		}

		// Token: 0x040006AA RID: 1706
		private const bool OPEN_PROFILE_TEST = true;

		// Token: 0x040006AB RID: 1707
		private const string NO_PROFILE_KEY = "";

		// Token: 0x040006AC RID: 1708
		[Nullable(2)]
		private static OverlapTestUtils _instance;
	}
}
