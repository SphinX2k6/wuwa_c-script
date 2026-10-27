using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.AudioVisualization
{
	// Token: 0x02003E3E RID: 15934
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/AudioVisualization/SGlobalRtpcEntry.SGlobalRtpcEntry")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SGlobalRtpcEntry : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602808B RID: 163979 RVA: 0x009A268D File Offset: 0x009A088D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGlobalRtpcEntry._ScriptStructPtr != 0) ? SGlobalRtpcEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/AudioVisualization/SGlobalRtpcEntry.SGlobalRtpcEntry", ref SGlobalRtpcEntry._ScriptStructPtr);
		}

		// Token: 0x17005B71 RID: 23409
		// (get) Token: 0x0602808C RID: 163980 RVA: 0x009A26B1 File Offset: 0x009A08B1
		// (set) Token: 0x0602808D RID: 163981 RVA: 0x009A26C5 File Offset: 0x009A08C5
		[Nullable(2)]
		public unsafe UAkRtpc RtpcFile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkRtpc>(base.NativePtr / (IntPtr)sizeof(void*) + SGlobalRtpcEntry.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SGlobalRtpcEntry.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005B72 RID: 23410
		// (get) Token: 0x0602808E RID: 163982 RVA: 0x009A26DA File Offset: 0x009A08DA
		// (set) Token: 0x0602808F RID: 163983 RVA: 0x009A26EE File Offset: 0x009A08EE
		public unsafe string Identifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SGlobalRtpcEntry.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SGlobalRtpcEntry.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17005B73 RID: 23411
		// (get) Token: 0x06028090 RID: 163984 RVA: 0x009A2703 File Offset: 0x009A0903
		// (set) Token: 0x06028091 RID: 163985 RVA: 0x009A2713 File Offset: 0x009A0913
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGlobalRtpcEntry.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGlobalRtpcEntry.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005B74 RID: 23412
		// (get) Token: 0x06028092 RID: 163986 RVA: 0x009A2724 File Offset: 0x009A0924
		// (set) Token: 0x06028093 RID: 163987 RVA: 0x009A2734 File Offset: 0x009A0934
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGlobalRtpcEntry.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGlobalRtpcEntry.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06028094 RID: 163988 RVA: 0x009A2745 File Offset: 0x009A0945
		public SGlobalRtpcEntry()
		{
		}

		// Token: 0x06028095 RID: 163989 RVA: 0x009A274D File Offset: 0x009A094D
		public SGlobalRtpcEntry(UAkRtpc RtpcFile, string Identifier, float Min, float Max)
		{
			this.RtpcFile = RtpcFile;
			this.Identifier = Identifier;
			this.Min = Min;
			this.Max = Max;
		}

		// Token: 0x06028096 RID: 163990 RVA: 0x009A2772 File Offset: 0x009A0972
		protected override IntPtr GetUStructPtr()
		{
			return SGlobalRtpcEntry.StaticStruct();
		}

		// Token: 0x06028097 RID: 163991 RVA: 0x009A277E File Offset: 0x009A097E
		[NullableContext(2)]
		public SGlobalRtpcEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028098 RID: 163992 RVA: 0x009A2788 File Offset: 0x009A0988
		public SGlobalRtpcEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028099 RID: 163993 RVA: 0x009A2793 File Offset: 0x009A0993
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGlobalRtpcEntry(Pointer, false, true);
		}

		// Token: 0x0602809A RID: 163994 RVA: 0x009A279D File Offset: 0x009A099D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGlobalRtpcEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0401454A RID: 83274
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/AudioVisualization/SGlobalRtpcEntry.SGlobalRtpcEntry";

		// Token: 0x0401454B RID: 83275
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401454C RID: 83276
		internal static int __PropertyOffset_0;

		// Token: 0x0401454D RID: 83277
		internal static int __PropertyOffset_1;

		// Token: 0x0401454E RID: 83278
		internal static int __PropertyOffset_2;

		// Token: 0x0401454F RID: 83279
		internal static int __PropertyOffset_3;
	}
}
