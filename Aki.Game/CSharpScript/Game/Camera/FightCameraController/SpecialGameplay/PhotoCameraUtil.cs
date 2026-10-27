using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02007308 RID: 29448
	public class PhotoCameraUtil
	{
		// Token: 0x0604846B RID: 296043 RVA: 0x012927CB File Offset: 0x012909CB
		public static bool IsModeAllowCharacterMove(PhotoCameraType? mode)
		{
			return mode != null && PhotoCameraUtil.PhotoModeAllowCharacterMoveSet.Contains(mode.Value);
		}

		// Token: 0x0604846C RID: 296044 RVA: 0x012927EC File Offset: 0x012909EC
		public static bool IsMoveBlocked()
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			return currentJoystickOwner != null && currentJoystickOwner.Current > EPhotoJoystickOwner.CameraMove;
		}

		// Token: 0x0604846D RID: 296045 RVA: 0x01292814 File Offset: 0x01290A14
		public static bool IsInCursorMode()
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			return currentJoystickOwner != null && currentJoystickOwner.Current == EPhotoJoystickOwner.Cursor;
		}

		// Token: 0x0604846E RID: 296046 RVA: 0x0129283C File Offset: 0x01290A3C
		public static bool IsCameraMoveBlockedByUi()
		{
			PhotoJoystickOwnerController currentJoystickOwner = PhotographController.Instance.CurrentJoystickOwner;
			return currentJoystickOwner != null && currentJoystickOwner.Current != EPhotoJoystickOwner.CameraMove && currentJoystickOwner.Current != EPhotoJoystickOwner.Cursor;
		}

		// Token: 0x0604846F RID: 296047 RVA: 0x0129286D File Offset: 0x01290A6D
		public static float ReverseFovByRange(float value, float minFov, float maxFov)
		{
			return MathUtils.Instance.RangeClamp(value, minFov, maxFov, maxFov, minFov);
		}

		// Token: 0x06048470 RID: 296048 RVA: 0x01292880 File Offset: 0x01290A80
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

		// Token: 0x06048471 RID: 296049 RVA: 0x012928D0 File Offset: 0x01290AD0
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

		// Token: 0x04026307 RID: 156423
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly HashSet<PhotoCameraType> PhotoModeAllowCharacterMoveSet = new HashSet<PhotoCameraType>
		{
			PhotoCameraType.Selfie,
			PhotoCameraType.FirstPerson
		};
	}
}
