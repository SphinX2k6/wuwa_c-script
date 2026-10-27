using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrackParticles.DT
{
	// Token: 0x02003ABA RID: 15034
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrackParticles/DT/Struct_TrackParticles.Struct_TrackParticles")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class Struct_TrackParticles : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060203FB RID: 132091 RVA: 0x008CDC01 File Offset: 0x008CBE01
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (Struct_TrackParticles._ScriptStructPtr != 0) ? Struct_TrackParticles._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/TrackParticles/DT/Struct_TrackParticles.Struct_TrackParticles", ref Struct_TrackParticles._ScriptStructPtr);
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x060203FC RID: 132092 RVA: 0x008CDC25 File Offset: 0x008CBE25
		// (set) Token: 0x060203FD RID: 132093 RVA: 0x008CDC35 File Offset: 0x008CBE35
		public unsafe bool Visible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x060203FE RID: 132094 RVA: 0x008CDC46 File Offset: 0x008CBE46
		// (set) Token: 0x060203FF RID: 132095 RVA: 0x008CDC5A File Offset: 0x008CBE5A
		[Nullable(2)]
		public unsafe UTexture2D TrackTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Struct_TrackParticles.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Struct_TrackParticles.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x06020400 RID: 132096 RVA: 0x008CDC6F File Offset: 0x008CBE6F
		// (set) Token: 0x06020401 RID: 132097 RVA: 0x008CDC83 File Offset: 0x008CBE83
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x06020402 RID: 132098 RVA: 0x008CDC98 File Offset: 0x008CBE98
		// (set) Token: 0x06020403 RID: 132099 RVA: 0x008CDCA8 File Offset: 0x008CBEA8
		public unsafe float Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x06020404 RID: 132100 RVA: 0x008CDCB9 File Offset: 0x008CBEB9
		// (set) Token: 0x06020405 RID: 132101 RVA: 0x008CDCC9 File Offset: 0x008CBEC9
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x06020406 RID: 132102 RVA: 0x008CDCDA File Offset: 0x008CBEDA
		// (set) Token: 0x06020407 RID: 132103 RVA: 0x008CDCEA File Offset: 0x008CBEEA
		public unsafe float TrackSpawnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x06020408 RID: 132104 RVA: 0x008CDCFB File Offset: 0x008CBEFB
		// (set) Token: 0x06020409 RID: 132105 RVA: 0x008CDD0B File Offset: 0x008CBF0B
		public unsafe float SparkSpawnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0602040A RID: 132106 RVA: 0x008CDD1C File Offset: 0x008CBF1C
		// (set) Token: 0x0602040B RID: 132107 RVA: 0x008CDD2C File Offset: 0x008CBF2C
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0602040C RID: 132108 RVA: 0x008CDD3D File Offset: 0x008CBF3D
		// (set) Token: 0x0602040D RID: 132109 RVA: 0x008CDD4D File Offset: 0x008CBF4D
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0602040E RID: 132110 RVA: 0x008CDD5E File Offset: 0x008CBF5E
		// (set) Token: 0x0602040F RID: 132111 RVA: 0x008CDD6E File Offset: 0x008CBF6E
		public unsafe int PointsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Struct_TrackParticles.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x06020410 RID: 132112 RVA: 0x008CDD7F File Offset: 0x008CBF7F
		public Struct_TrackParticles()
		{
		}

		// Token: 0x06020411 RID: 132113 RVA: 0x008CDD88 File Offset: 0x008CBF88
		[NullableContext(1)]
		public Struct_TrackParticles(bool Visible, UTexture2D TrackTexture, FLinearColor Color, float Brightness, float Speed, float TrackSpawnRate, float SparkSpawnRate, float LifeTime, float Width, int PointsNum)
		{
			this.Visible = Visible;
			this.TrackTexture = TrackTexture;
			this.Color = Color;
			this.Brightness = Brightness;
			this.Speed = Speed;
			this.TrackSpawnRate = TrackSpawnRate;
			this.SparkSpawnRate = SparkSpawnRate;
			this.LifeTime = LifeTime;
			this.Width = Width;
			this.PointsNum = PointsNum;
		}

		// Token: 0x06020412 RID: 132114 RVA: 0x008CDDE8 File Offset: 0x008CBFE8
		protected override IntPtr GetUStructPtr()
		{
			return Struct_TrackParticles.StaticStruct();
		}

		// Token: 0x06020413 RID: 132115 RVA: 0x008CDDF4 File Offset: 0x008CBFF4
		[NullableContext(2)]
		public Struct_TrackParticles(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020414 RID: 132116 RVA: 0x008CDDFE File Offset: 0x008CBFFE
		public Struct_TrackParticles(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020415 RID: 132117 RVA: 0x008CDE09 File Offset: 0x008CC009
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new Struct_TrackParticles(Pointer, false, true);
		}

		// Token: 0x06020416 RID: 132118 RVA: 0x008CDE13 File Offset: 0x008CC013
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new Struct_TrackParticles(Pointer, MemoryOwner);
		}

		// Token: 0x0400F981 RID: 63873
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrackParticles/DT/Struct_TrackParticles.Struct_TrackParticles";

		// Token: 0x0400F982 RID: 63874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F983 RID: 63875
		internal static int __PropertyOffset_0;

		// Token: 0x0400F984 RID: 63876
		internal static int __PropertyOffset_1;

		// Token: 0x0400F985 RID: 63877
		internal static int __PropertyOffset_2;

		// Token: 0x0400F986 RID: 63878
		internal static int __PropertyOffset_3;

		// Token: 0x0400F987 RID: 63879
		internal static int __PropertyOffset_4;

		// Token: 0x0400F988 RID: 63880
		internal static int __PropertyOffset_5;

		// Token: 0x0400F989 RID: 63881
		internal static int __PropertyOffset_6;

		// Token: 0x0400F98A RID: 63882
		internal static int __PropertyOffset_7;

		// Token: 0x0400F98B RID: 63883
		internal static int __PropertyOffset_8;

		// Token: 0x0400F98C RID: 63884
		internal static int __PropertyOffset_9;
	}
}
