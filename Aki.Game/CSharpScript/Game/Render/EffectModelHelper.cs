using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034ED RID: 13549
	public class EffectModelHelper
	{
		// Token: 0x060227D1 RID: 141265 RVA: 0x009CA256 File Offset: 0x009C8456
		public static void VectorToRotator(FVector vector, FRotator rotator)
		{
			rotator.Pitch = vector.Y;
			rotator.Yaw = vector.Z;
			rotator.Roll = vector.X;
		}

		// Token: 0x060227D2 RID: 141266 RVA: 0x009CA280 File Offset: 0x009C8480
		[NullableContext(2)]
		public unsafe static USceneComponent AddSceneComponent(AActor actor, [Nullable(1)] UClass componentClass, USceneComponent parent, FTransform? transform = null, bool bDeferredFinish = false, UEffectModelBase effectModel = null)
		{
			if (actor != null && componentClass != null)
			{
				USceneComponent usceneComponent;
				if (transform == null)
				{
					usceneComponent = UKuroEffectLibrary.AddSceneComponent(actor, componentClass.ClassStackOnlyPtr, parent, bDeferredFinish);
				}
				else
				{
					usceneComponent = UKuroEffectLibrary.AddSceneComponentWithTransform(actor, componentClass.ClassStackOnlyPtr, parent, bDeferredFinish, transform.Value);
				}
				if (usceneComponent == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.LSY;
					string message = "特效试图生成在不属于任何世界的actor上";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", actor);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentClass", componentClass);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EffectDataPath", effectModel);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				return usceneComponent;
			}
			return null;
		}
	}
}
