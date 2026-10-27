using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x020025A4 RID: 9636
public static class PhotoModeCollisionHelper
{
	// Token: 0x06013844 RID: 79940 RVA: 0x004E03F4 File Offset: 0x004DE5F4
	[NullableContext(2)]
	public unsafe static bool IsModeCollisionBlocked(PhotoCameraType mode, out string tips)
	{
		tips = null;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		TsBaseCharacter tsBaseCharacter = (characterActorComponent != null) ? characterActorComponent.Actor : null;
		if (characterActorComponent == null || tsBaseCharacter == null)
		{
			return false;
		}
		float defaultRadius = characterActorComponent.DefaultRadius;
		float modeCollisionRadius = PhotographConfig.Instance.GetModeCollisionRadius(mode, defaultRadius);
		if (modeCollisionRadius == defaultRadius)
		{
			return false;
		}
		UTraceCapsuleElement utraceCapsuleElement = new UTraceCapsuleElement();
		utraceCapsuleElement.bIsSingle = true;
		utraceCapsuleElement.bIgnoreSelf = true;
		utraceCapsuleElement.bTraceComplex = false;
		utraceCapsuleElement.WorldContextObject = GlobalData.World;
		utraceCapsuleElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		float num = (float)((double)modeCollisionRadius * characterActorComponent.ActorScaleProxy.X);
		float num2 = Math.Max(characterActorComponent.ScaledHalfHeight, num);
		utraceCapsuleElement.Radius = num;
		utraceCapsuleElement.HalfHeight = num2;
		utraceCapsuleElement.ActorsToIgnore.Add(tsBaseCharacter);
		global::Vector vector = global::Vector.Create(characterActorComponent.ActorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(characterActorComponent, vector, (double)(num2 - characterActorComponent.ScaledHalfHeight));
		TraceElementCommon.Instance.SetStartLocation(utraceCapsuleElement, vector);
		TraceElementCommon.Instance.SetEndLocation(utraceCapsuleElement, vector);
		if (SundryModel.Instance.GetModuleDebugLevel("PhotoModeCollision") > 0)
		{
			utraceCapsuleElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			utraceCapsuleElement.DrawTime = 5f;
			utraceCapsuleElement.SetTraceColor(0f, 1f, 0f, 1f);
			utraceCapsuleElement.SetTraceHitColor(1f, 0f, 0f, 1f);
		}
		else
		{
			utraceCapsuleElement.SetDrawDebugTrace(EDrawDebugTrace.None);
		}
		if (TraceElementCommon.Instance.CapsuleTrace(utraceCapsuleElement, "PhotoModeCollisionHelper.IsModeCollisionBlocked"))
		{
			UKuroHitResult hitResult = utraceCapsuleElement.HitResult;
			if (hitResult != null && hitResult.bBlockingHit)
			{
				PhotoMode? photoModeConfigByType = PhotographConfig.Instance.GetPhotoModeConfigByType((int)mode);
				tips = ((photoModeConfigByType != null) ? photoModeConfigByType.GetValueOrDefault().CollisionBlockedTip : null);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照模式预检:放大碰撞体会与场景碰撞,禁止进入";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Mode", mode.ToString());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CheckRadius", utraceCapsuleElement.Radius);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HalfHeight", utraceCapsuleElement.HalfHeight);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return true;
			}
		}
		return false;
	}

	// Token: 0x04009353 RID: 37715
	[Nullable(1)]
	private const string COLLISION_DEBUG_KEY = "PhotoModeCollision";
}
