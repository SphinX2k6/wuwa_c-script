using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200346D RID: 13421
	[NullableContext(1)]
	[Nullable(0)]
	public class AnimationUtils
	{
		// Token: 0x06022443 RID: 140355 RVA: 0x009B4E64 File Offset: 0x009B3064
		public static void GetRootLocationCurveValue(Entity entity, Vector outV)
		{
			outV.Reset();
			if (!entity.Valid)
			{
				return;
			}
			CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
			UAnimInstance uanimInstance = (component != null) ? component.MainAnimInstance : null;
			if (uanimInstance == null)
			{
				return;
			}
			float curveValue = uanimInstance.GetCurveValue(CharacterNameDefines.Instance.ROOT_X);
			float curveValue2 = uanimInstance.GetCurveValue(CharacterNameDefines.Instance.ROOT_Y);
			float curveValue3 = uanimInstance.GetCurveValue(CharacterNameDefines.Instance.ROOT_Z);
			outV.Set((double)curveValue, (double)curveValue2, (double)curveValue3);
		}

		// Token: 0x06022444 RID: 140356 RVA: 0x009B4ED8 File Offset: 0x009B30D8
		public static void GetRootLocationCurveValueWithDelta(Entity entity, float deltaTime, Vector outV)
		{
			outV.Reset();
			if (!entity.Valid)
			{
				return;
			}
			CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
			UAnimInstance uanimInstance = (component != null) ? component.MainAnimInstance : null;
			if (uanimInstance == null)
			{
				return;
			}
			float mainAnimsCurveValueWithDelta = uanimInstance.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_X, deltaTime, false, false);
			float mainAnimsCurveValueWithDelta2 = uanimInstance.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_Y, deltaTime, false, false);
			float mainAnimsCurveValueWithDelta3 = uanimInstance.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_Z, deltaTime, false, false);
			outV.Set((double)mainAnimsCurveValueWithDelta, (double)mainAnimsCurveValueWithDelta2, (double)mainAnimsCurveValueWithDelta3);
		}
	}
}
