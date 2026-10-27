using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040B3 RID: 16563
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SSpecialTagListenerInfo.SSpecialTagListenerInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SSpecialTagListenerInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602AC98 RID: 175256 RVA: 0x009EB54D File Offset: 0x009E974D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpecialTagListenerInfo._ScriptStructPtr != 0) ? SSpecialTagListenerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SSpecialTagListenerInfo.SSpecialTagListenerInfo", ref SSpecialTagListenerInfo._ScriptStructPtr);
		}

		// Token: 0x17006983 RID: 27011
		// (get) Token: 0x0602AC99 RID: 175257 RVA: 0x009EB571 File Offset: 0x009E9771
		// (set) Token: 0x0602AC9A RID: 175258 RVA: 0x009EB585 File Offset: 0x009E9785
		public unsafe FGameplayTag SpecialTagListener
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006984 RID: 27012
		// (get) Token: 0x0602AC9B RID: 175259 RVA: 0x009EB59C File Offset: 0x009E979C
		// (set) Token: 0x0602AC9C RID: 175260 RVA: 0x009EB5DF File Offset: 0x009E97DF
		public FGameplayTagContainer TargetTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TargetTagList) == null)
				{
					result = (this._TargetTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006985 RID: 27013
		// (get) Token: 0x0602AC9D RID: 175261 RVA: 0x009EB600 File Offset: 0x009E9800
		// (set) Token: 0x0602AC9E RID: 175262 RVA: 0x009EB643 File Offset: 0x009E9843
		public FGameplayTagContainer ForbidTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidTagList) == null)
				{
					result = (this._ForbidTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SSpecialTagListenerInfo.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602AC9F RID: 175263 RVA: 0x009EB664 File Offset: 0x009E9864
		public SSpecialTagListenerInfo()
		{
		}

		// Token: 0x0602ACA0 RID: 175264 RVA: 0x009EB66C File Offset: 0x009E986C
		public SSpecialTagListenerInfo(FGameplayTag SpecialTagListener, FGameplayTagContainer TargetTagList, FGameplayTagContainer ForbidTagList)
		{
			this.SpecialTagListener = SpecialTagListener;
			this.TargetTagList = TargetTagList;
			this.ForbidTagList = ForbidTagList;
		}

		// Token: 0x0602ACA1 RID: 175265 RVA: 0x009EB689 File Offset: 0x009E9889
		protected override IntPtr GetUStructPtr()
		{
			return SSpecialTagListenerInfo.StaticStruct();
		}

		// Token: 0x0602ACA2 RID: 175266 RVA: 0x009EB695 File Offset: 0x009E9895
		[NullableContext(2)]
		public SSpecialTagListenerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602ACA3 RID: 175267 RVA: 0x009EB69F File Offset: 0x009E989F
		public SSpecialTagListenerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602ACA4 RID: 175268 RVA: 0x009EB6AA File Offset: 0x009E98AA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSpecialTagListenerInfo(Pointer, false, true);
		}

		// Token: 0x0602ACA5 RID: 175269 RVA: 0x009EB6B4 File Offset: 0x009E98B4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSpecialTagListenerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04016259 RID: 90713
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SSpecialTagListenerInfo.SSpecialTagListenerInfo";

		// Token: 0x0401625A RID: 90714
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401625B RID: 90715
		internal static int __PropertyOffset_0;

		// Token: 0x0401625C RID: 90716
		internal static int __PropertyOffset_1;

		// Token: 0x0401625D RID: 90717
		[Nullable(2)]
		private FGameplayTagContainer _TargetTagList;

		// Token: 0x0401625E RID: 90718
		internal static int __PropertyOffset_2;

		// Token: 0x0401625F RID: 90719
		[Nullable(2)]
		private FGameplayTagContainer _ForbidTagList;
	}
}
