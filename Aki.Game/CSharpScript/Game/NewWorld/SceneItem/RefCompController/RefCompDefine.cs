using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x020071B5 RID: 29109
	public class RefCompDefine
	{
		// Token: 0x0200CF0C RID: 53004
		public enum ERefCompControllerType
		{
			// Token: 0x0403E445 RID: 255045
			LevelSequence,
			// Token: 0x0403E446 RID: 255046
			AirWall,
			// Token: 0x0403E447 RID: 255047
			ModifyActorMaterial,
			// Token: 0x0403E448 RID: 255048
			ModifyActorMedia
		}

		// Token: 0x0200CF0D RID: 53005
		public class TransitStruct
		{
			// Token: 0x06052021 RID: 335905 RVA: 0x01648C2B File Offset: 0x01646E2B
			public TransitStruct(ELevelSequenceTransition transitType = ELevelSequenceTransition.Camera, float? duration = null, float? transitFadeIn = null, float? transitFadeOut = null, bool? bIsValid = false, ETransitionMask? mask = null)
			{
			}

			// Token: 0x0403E449 RID: 255049
			public ELevelSequenceTransition TransitType = transitType;

			// Token: 0x0403E44A RID: 255050
			public float? Duration = duration;

			// Token: 0x0403E44B RID: 255051
			public float? TransitFadeIn = transitFadeIn;

			// Token: 0x0403E44C RID: 255052
			public float? TransitFadeOut = transitFadeOut;

			// Token: 0x0403E44D RID: 255053
			public bool? IsValid = bIsValid;

			// Token: 0x0403E44E RID: 255054
			public ETransitionMask? Mask = mask;
		}

		// Token: 0x0200CF0E RID: 53006
		public class PlayRateStruct
		{
			// Token: 0x06052022 RID: 335906 RVA: 0x01648C60 File Offset: 0x01646E60
			public PlayRateStruct(float? playRateAbs = 1f, EKuroEasingFuncType easeType = EKuroEasingFuncType.KEF_Linear, float? easeDuration = 0f, float? easeExponent = 0f)
			{
			}

			// Token: 0x0403E44F RID: 255055
			public float? PlayRateAbs = playRateAbs;

			// Token: 0x0403E450 RID: 255056
			public EKuroEasingFuncType EaseType = easeType;

			// Token: 0x0403E451 RID: 255057
			public float? EaseDuration = easeDuration;

			// Token: 0x0403E452 RID: 255058
			public float? EaseExponent = easeExponent;
		}

		// Token: 0x0200CF0F RID: 53007
		public class PrePhysicsSequenceConfig : IStaticVariableResetter
		{
			// Token: 0x06052023 RID: 335907 RVA: 0x01648C85 File Offset: 0x01646E85
			static PrePhysicsSequenceConfig()
			{
				StaticVariableRegister.RegisterAndExecute(new Action(RefCompDefine.PrePhysicsSequenceConfig.CreateStaticDefaultValue), new Action(RefCompDefine.PrePhysicsSequenceConfig.ResetStaticDefaultValue));
			}

			// Token: 0x06052024 RID: 335908 RVA: 0x01648CA4 File Offset: 0x01646EA4
			public static void CreateStaticDefaultValue()
			{
				RefCompDefine.PrePhysicsSequenceConfig.Paths = new HashSet<string>();
				RefCompDefine.PrePhysicsSequenceConfig.IsInit = false;
			}

			// Token: 0x06052025 RID: 335909 RVA: 0x01648CB6 File Offset: 0x01646EB6
			public static void ResetStaticDefaultValue()
			{
				RefCompDefine.PrePhysicsSequenceConfig.Paths = null;
				RefCompDefine.PrePhysicsSequenceConfig.IsInit = false;
			}

			// Token: 0x06052026 RID: 335910 RVA: 0x01648CC4 File Offset: 0x01646EC4
			[NullableContext(2)]
			public static bool Check(string path = null)
			{
				if (string.IsNullOrEmpty(path))
				{
					return false;
				}
				if (!RefCompDefine.PrePhysicsSequenceConfig.IsInit)
				{
					IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig("UpdateAnimRefLevelSequencePaths");
					if (stringArrayConfig != null)
					{
						foreach (string item in stringArrayConfig)
						{
							RefCompDefine.PrePhysicsSequenceConfig.Paths.Add(item);
						}
					}
					RefCompDefine.PrePhysicsSequenceConfig.IsInit = true;
				}
				return RefCompDefine.PrePhysicsSequenceConfig.Paths.Contains(path);
			}

			// Token: 0x0403E453 RID: 255059
			[Nullable(1)]
			private static HashSet<string> Paths;

			// Token: 0x0403E454 RID: 255060
			private static bool IsInit;
		}
	}
}
