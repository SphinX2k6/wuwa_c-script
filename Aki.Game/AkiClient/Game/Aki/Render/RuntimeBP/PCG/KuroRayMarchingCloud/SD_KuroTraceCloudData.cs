using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud
{
	// Token: 0x02003C7A RID: 15482
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/SD_KuroTraceCloudData.SD_KuroTraceCloudData")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class SD_KuroTraceCloudData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024036 RID: 147510 RVA: 0x00932E99 File Offset: 0x00931099
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SD_KuroTraceCloudData._ScriptStructPtr != 0) ? SD_KuroTraceCloudData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/SD_KuroTraceCloudData.SD_KuroTraceCloudData", ref SD_KuroTraceCloudData._ScriptStructPtr);
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x06024037 RID: 147511 RVA: 0x00932EBD File Offset: 0x009310BD
		// (set) Token: 0x06024038 RID: 147512 RVA: 0x00932ECD File Offset: 0x009310CD
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SD_KuroTraceCloudData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SD_KuroTraceCloudData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x06024039 RID: 147513 RVA: 0x00932EDE File Offset: 0x009310DE
		// (set) Token: 0x0602403A RID: 147514 RVA: 0x00932EF2 File Offset: 0x009310F2
		public unsafe FLinearColor LightWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SD_KuroTraceCloudData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SD_KuroTraceCloudData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602403B RID: 147515 RVA: 0x00932F07 File Offset: 0x00931107
		public SD_KuroTraceCloudData()
		{
		}

		// Token: 0x0602403C RID: 147516 RVA: 0x00932F0F File Offset: 0x0093110F
		public SD_KuroTraceCloudData(float Time, FLinearColor LightWeight)
		{
			this.Time = Time;
			this.LightWeight = LightWeight;
		}

		// Token: 0x0602403D RID: 147517 RVA: 0x00932F25 File Offset: 0x00931125
		protected override IntPtr GetUStructPtr()
		{
			return SD_KuroTraceCloudData.StaticStruct();
		}

		// Token: 0x0602403E RID: 147518 RVA: 0x00932F31 File Offset: 0x00931131
		[NullableContext(2)]
		public SD_KuroTraceCloudData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602403F RID: 147519 RVA: 0x00932F3B File Offset: 0x0093113B
		public SD_KuroTraceCloudData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024040 RID: 147520 RVA: 0x00932F46 File Offset: 0x00931146
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SD_KuroTraceCloudData(Pointer, false, true);
		}

		// Token: 0x06024041 RID: 147521 RVA: 0x00932F50 File Offset: 0x00931150
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SD_KuroTraceCloudData(Pointer, MemoryOwner);
		}

		// Token: 0x04011D2C RID: 73004
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/SD_KuroTraceCloudData.SD_KuroTraceCloudData";

		// Token: 0x04011D2D RID: 73005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011D2E RID: 73006
		internal static int __PropertyOffset_0;

		// Token: 0x04011D2F RID: 73007
		internal static int __PropertyOffset_1;
	}
}
