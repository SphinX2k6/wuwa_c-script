using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x0200626A RID: 25194
	public class RefCompDefine
	{
		// Token: 0x0200BAA1 RID: 47777
		public enum ERefCompControllerType
		{
			// Token: 0x0403976A RID: 235370
			LevelSequence,
			// Token: 0x0403976B RID: 235371
			AirWall,
			// Token: 0x0403976C RID: 235372
			ModifyActorMaterial,
			// Token: 0x0403976D RID: 235373
			ModifyActorMedia
		}

		// Token: 0x0200BAA2 RID: 47778
		public class TransitStruct
		{
			// Token: 0x060487CB RID: 296907 RVA: 0x0161AD53 File Offset: 0x01618F53
			public TransitStruct(ELevelSequenceTransition transitType = ELevelSequenceTransition.Camera, float? duration = null, float? transitFadeIn = null, float? transitFadeOut = null, bool? bIsValid = false, ETransitionMask? mask = null)
			{
			}

			// Token: 0x0403976E RID: 235374
			public ELevelSequenceTransition TransitType = transitType;

			// Token: 0x0403976F RID: 235375
			public float? Duration = duration;

			// Token: 0x04039770 RID: 235376
			public float? TransitFadeIn = transitFadeIn;

			// Token: 0x04039771 RID: 235377
			public float? TransitFadeOut = transitFadeOut;

			// Token: 0x04039772 RID: 235378
			public bool? IsValid = bIsValid;

			// Token: 0x04039773 RID: 235379
			public ETransitionMask? Mask = mask;
		}

		// Token: 0x0200BAA3 RID: 47779
		public class PlayRateStruct
		{
			// Token: 0x060487CC RID: 296908 RVA: 0x0161AD88 File Offset: 0x01618F88
			public PlayRateStruct(float? playRateAbs = 1f, EKuroEasingFuncType easeType = EKuroEasingFuncType.KEF_Linear, float? easeDuration = 0f, float? easeExponent = 0f)
			{
			}

			// Token: 0x04039774 RID: 235380
			public float? PlayRateAbs = playRateAbs;

			// Token: 0x04039775 RID: 235381
			public EKuroEasingFuncType EaseType = easeType;

			// Token: 0x04039776 RID: 235382
			public float? EaseDuration = easeDuration;

			// Token: 0x04039777 RID: 235383
			public float? EaseExponent = easeExponent;
		}

		// Token: 0x0200BAA4 RID: 47780
		public class PrePhysicsSequenceConfig : IStaticVariableResetter
		{
			// Token: 0x060487CD RID: 296909 RVA: 0x0161ADAD File Offset: 0x01618FAD
			static PrePhysicsSequenceConfig()
			{
				StaticVariableRegister.RegisterAndExecute(new Action(RefCompDefine.PrePhysicsSequenceConfig.CreateStaticDefaultValue), new Action(RefCompDefine.PrePhysicsSequenceConfig.ResetStaticDefaultValue));
			}

			// Token: 0x060487CE RID: 296910 RVA: 0x0161ADCC File Offset: 0x01618FCC
			public static void CreateStaticDefaultValue()
			{
				RefCompDefine.PrePhysicsSequenceConfig.Paths = new HashSet<string>();
				RefCompDefine.PrePhysicsSequenceConfig.IsInit = false;
			}

			// Token: 0x060487CF RID: 296911 RVA: 0x0161ADDE File Offset: 0x01618FDE
			public static void ResetStaticDefaultValue()
			{
				RefCompDefine.PrePhysicsSequenceConfig.Paths = null;
				RefCompDefine.PrePhysicsSequenceConfig.IsInit = false;
			}

			// Token: 0x060487D0 RID: 296912 RVA: 0x0161ADEC File Offset: 0x01618FEC
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

			// Token: 0x04039778 RID: 235384
			[Nullable(1)]
			private static HashSet<string> Paths;

			// Token: 0x04039779 RID: 235385
			private static bool IsInit;
		}
	}
}
