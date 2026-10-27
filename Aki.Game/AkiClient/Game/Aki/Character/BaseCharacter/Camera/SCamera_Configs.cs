using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043CB RID: 17355
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCamera_Configs.SCamera_Configs")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class SCamera_Configs : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CEE0 RID: 184032 RVA: 0x00A2C778 File Offset: 0x00A2A978
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamera_Configs._ScriptStructPtr != 0) ? SCamera_Configs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCamera_Configs.SCamera_Configs", ref SCamera_Configs._ScriptStructPtr);
		}

		// Token: 0x1700719E RID: 29086
		// (get) Token: 0x0602CEE1 RID: 184033 RVA: 0x00A2C79C File Offset: 0x00A2A99C
		// (set) Token: 0x0602CEE2 RID: 184034 RVA: 0x00A2C7B0 File Offset: 0x00A2A9B0
		public unsafe TEnumAsByte<EFightCameraType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Configs.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Configs.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700719F RID: 29087
		// (get) Token: 0x0602CEE3 RID: 184035 RVA: 0x00A2C7C5 File Offset: 0x00A2A9C5
		// (set) Token: 0x0602CEE4 RID: 184036 RVA: 0x00A2C7D9 File Offset: 0x00A2A9D9
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Configs.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Configs.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071A0 RID: 29088
		// (get) Token: 0x0602CEE5 RID: 184037 RVA: 0x00A2C7F0 File Offset: 0x00A2A9F0
		// (set) Token: 0x0602CEE6 RID: 184038 RVA: 0x00A2C833 File Offset: 0x00A2AA33
		[Nullable(1)]
		public SCamera_Setting Config
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._Config) == null)
				{
					result = (this._Config = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_Configs.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_Configs.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CEE7 RID: 184039 RVA: 0x00A2C854 File Offset: 0x00A2AA54
		public SCamera_Configs()
		{
		}

		// Token: 0x0602CEE8 RID: 184040 RVA: 0x00A2C85C File Offset: 0x00A2AA5C
		public SCamera_Configs(TEnumAsByte<EFightCameraType> Type, FGameplayTag Tag, [Nullable(1)] SCamera_Setting Config)
		{
			this.Type = Type;
			this.Tag = Tag;
			this.Config = Config;
		}

		// Token: 0x0602CEE9 RID: 184041 RVA: 0x00A2C879 File Offset: 0x00A2AA79
		protected override IntPtr GetUStructPtr()
		{
			return SCamera_Configs.StaticStruct();
		}

		// Token: 0x0602CEEA RID: 184042 RVA: 0x00A2C885 File Offset: 0x00A2AA85
		[NullableContext(2)]
		public SCamera_Configs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CEEB RID: 184043 RVA: 0x00A2C88F File Offset: 0x00A2AA8F
		public SCamera_Configs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CEEC RID: 184044 RVA: 0x00A2C89A File Offset: 0x00A2AA9A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamera_Configs(Pointer, false, true);
		}

		// Token: 0x0602CEED RID: 184045 RVA: 0x00A2C8A4 File Offset: 0x00A2AAA4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamera_Configs(Pointer, MemoryOwner);
		}

		// Token: 0x04017D76 RID: 97654
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCamera_Configs.SCamera_Configs";

		// Token: 0x04017D77 RID: 97655
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D78 RID: 97656
		internal static int __PropertyOffset_0;

		// Token: 0x04017D79 RID: 97657
		internal static int __PropertyOffset_1;

		// Token: 0x04017D7A RID: 97658
		internal static int __PropertyOffset_2;

		// Token: 0x04017D7B RID: 97659
		[Nullable(2)]
		private SCamera_Setting _Config;
	}
}
