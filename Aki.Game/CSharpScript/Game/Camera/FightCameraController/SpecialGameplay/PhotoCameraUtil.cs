using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x0200648B RID: 25739
	public class PhotoCameraUtil
	{
		// Token: 0x0603E8B8 RID: 256184 RVA: 0x0123524E File Offset: 0x0123344E
		public static bool IsModeAllowCharacterMove(PhotoCameraType? mode)
		{
			return mode != null && PhotoCameraUtil.PhotoModeAllowCharacterMoveSet.Contains(mode.Value);
		}

		// Token: 0x0603E8B9 RID: 256185 RVA: 0x0123526C File Offset: 0x0123346C
		public static bool IsMoveBlocked()
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			return currentJoystickOwner != null && currentJoystickOwner.Current > EPhotoJoystickOwner.CameraMove;
		}

		// Token: 0x0603E8BA RID: 256186 RVA: 0x01235294 File Offset: 0x01233494
		public static bool IsInCursorMode()
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			return currentJoystickOwner != null && currentJoystickOwner.Current == EPhotoJoystickOwner.Cursor;
		}

		// Token: 0x0603E8BB RID: 256187 RVA: 0x012352BC File Offset: 0x012334BC
		public static bool IsCameraMoveBlockedByUi()
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			return currentJoystickOwner != null && currentJoystickOwner.Current != EPhotoJoystickOwner.CameraMove && currentJoystickOwner.Current != EPhotoJoystickOwner.Cursor;
		}

		// Token: 0x0603E8BC RID: 256188 RVA: 0x012352ED File Offset: 0x012334ED
		public static float ReverseFovByRange(float value, float minFov, float maxFov)
		{
			return MathUtils.Instance.RangeClamp(value, minFov, maxFov, maxFov, minFov);
		}

		// Token: 0x0603E8BD RID: 256189 RVA: 0x01235300 File Offset: 0x01233500
		[NullableContext(2)]
		public static EPhotoCameraBodyType ToPhotoCameraBodyType(string roleBody)
		{
			if (string.IsNullOrEmpty(roleBody))
			{
				return EPhotoCameraBodyType.None;
			}
			EPhotoCameraBodyType result;
			if (!Enum.TryParse<EPhotoCameraBodyType>(roleBody, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhotoCamera;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "拍照体型:配表体型字符串在EPhotoCameraBodyType中没有同名枚举,请先在蓝图枚举中补充";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleBody", roleBody);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return EPhotoCameraBodyType.None;
			}
			return result;
		}

		// Token: 0x0603E8BE RID: 256190 RVA: 0x01235350 File Offset: 0x01233550
		public unsafe static EPhotoCameraBodyType GetBodyType(int roleId, EMorphType morphType)
		{
			if (morphType == EMorphType.默认形态)
			{
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
				if (roleConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PhotoCamera;
					ELogAuthor author = ELogAuthor.CXJ;
					string message = "拍照体型:默认形态取不到角色配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", roleId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return EPhotoCameraBodyType.None;
				}
				return PhotoCameraUtil.ToPhotoCameraBodyType(roleConfig.Value.RoleBody);
			}
			else
			{
				PhotoRoleBody? config = ConfigPhotoRoleBodyByRoleIdAndMorph.GetConfig(roleId, (int)morphType, true);
				if (config == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.PhotoCamera;
					ELogAuthor author2 = ELogAuthor.CXJ;
					string message2 = "拍照体型:非默认形态在拍照体型表中没有配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleId", roleId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Morph", (int)morphType);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return EPhotoCameraBodyType.None;
				}
				return PhotoCameraUtil.ToPhotoCameraBodyType(config.Value.RoleBody);
			}
		}

		// Token: 0x040215F4 RID: 136692
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly HashSet<PhotoCameraType> PhotoModeAllowCharacterMoveSet = new HashSet<PhotoCameraType>
		{
			PhotoCameraType.Selfie,
			PhotoCameraType.FirstPerson
		};
	}
}
