using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.Cipher
{
	// Token: 0x02003E6C RID: 15980
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/GamePlay/Cipher/SCipherGameplay.SCipherGameplay")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SCipherGameplay : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028395 RID: 164757 RVA: 0x009A6EE3 File Offset: 0x009A50E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCipherGameplay._ScriptStructPtr != 0) ? SCipherGameplay._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/Cipher/SCipherGameplay.SCipherGameplay", ref SCipherGameplay._ScriptStructPtr);
		}

		// Token: 0x17005C77 RID: 23671
		// (get) Token: 0x06028396 RID: 164758 RVA: 0x009A6F07 File Offset: 0x009A5107
		// (set) Token: 0x06028397 RID: 164759 RVA: 0x009A6F1B File Offset: 0x009A511B
		public unsafe FName ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005C78 RID: 23672
		// (get) Token: 0x06028398 RID: 164760 RVA: 0x009A6F30 File Offset: 0x009A5130
		// (set) Token: 0x06028399 RID: 164761 RVA: 0x009A6F44 File Offset: 0x009A5144
		[Nullable(0)]
		public unsafe TEnumAsByte<ECipherGameplayType> 解密类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005C79 RID: 23673
		// (get) Token: 0x0602839A RID: 164762 RVA: 0x009A6F59 File Offset: 0x009A5159
		// (set) Token: 0x0602839B RID: 164763 RVA: 0x009A6F6D File Offset: 0x009A516D
		public unsafe string 正确密码
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCipherGameplay.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCipherGameplay.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17005C7A RID: 23674
		// (get) Token: 0x0602839C RID: 164764 RVA: 0x009A6F82 File Offset: 0x009A5182
		// (set) Token: 0x0602839D RID: 164765 RVA: 0x009A6F96 File Offset: 0x009A5196
		public unsafe string 扰乱密码
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCipherGameplay.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCipherGameplay.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17005C7B RID: 23675
		// (get) Token: 0x0602839E RID: 164766 RVA: 0x009A6FAB File Offset: 0x009A51AB
		// (set) Token: 0x0602839F RID: 164767 RVA: 0x009A6FBF File Offset: 0x009A51BF
		public unsafe FName 解密成功交互ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005C7C RID: 23676
		// (get) Token: 0x060283A0 RID: 164768 RVA: 0x009A6FD4 File Offset: 0x009A51D4
		// (set) Token: 0x060283A1 RID: 164769 RVA: 0x009A6FE8 File Offset: 0x009A51E8
		public unsafe FName 解密失败交互ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCipherGameplay.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005C7D RID: 23677
		// (get) Token: 0x060283A2 RID: 164770 RVA: 0x009A6FFD File Offset: 0x009A51FD
		// (set) Token: 0x060283A3 RID: 164771 RVA: 0x009A7011 File Offset: 0x009A5211
		public unsafe string Tips
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCipherGameplay.__PropertyOffset_6)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCipherGameplay.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x060283A4 RID: 164772 RVA: 0x009A7026 File Offset: 0x009A5226
		public SCipherGameplay()
		{
		}

		// Token: 0x060283A5 RID: 164773 RVA: 0x009A702E File Offset: 0x009A522E
		public SCipherGameplay(FName ID, [Nullable(0)] TEnumAsByte<ECipherGameplayType> 解密类型, string 正确密码, string 扰乱密码, FName 解密成功交互ID, FName 解密失败交互ID, string Tips)
		{
			this.ID = ID;
			this.解密类型 = 解密类型;
			this.正确密码 = 正确密码;
			this.扰乱密码 = 扰乱密码;
			this.解密成功交互ID = 解密成功交互ID;
			this.解密失败交互ID = 解密失败交互ID;
			this.Tips = Tips;
		}

		// Token: 0x060283A6 RID: 164774 RVA: 0x009A706B File Offset: 0x009A526B
		protected override IntPtr GetUStructPtr()
		{
			return SCipherGameplay.StaticStruct();
		}

		// Token: 0x060283A7 RID: 164775 RVA: 0x009A7077 File Offset: 0x009A5277
		[NullableContext(2)]
		public SCipherGameplay(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060283A8 RID: 164776 RVA: 0x009A7081 File Offset: 0x009A5281
		public SCipherGameplay(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060283A9 RID: 164777 RVA: 0x009A708C File Offset: 0x009A528C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCipherGameplay(Pointer, false, true);
		}

		// Token: 0x060283AA RID: 164778 RVA: 0x009A7096 File Offset: 0x009A5296
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCipherGameplay(Pointer, MemoryOwner);
		}

		// Token: 0x040147A6 RID: 83878
		public const string __ObjectPath = "/Game/Aki/GamePlay/Cipher/SCipherGameplay.SCipherGameplay";

		// Token: 0x040147A7 RID: 83879
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040147A8 RID: 83880
		internal static int __PropertyOffset_0;

		// Token: 0x040147A9 RID: 83881
		internal static int __PropertyOffset_1;

		// Token: 0x040147AA RID: 83882
		internal static int __PropertyOffset_2;

		// Token: 0x040147AB RID: 83883
		internal static int __PropertyOffset_3;

		// Token: 0x040147AC RID: 83884
		internal static int __PropertyOffset_4;

		// Token: 0x040147AD RID: 83885
		internal static int __PropertyOffset_5;

		// Token: 0x040147AE RID: 83886
		internal static int __PropertyOffset_6;
	}
}
