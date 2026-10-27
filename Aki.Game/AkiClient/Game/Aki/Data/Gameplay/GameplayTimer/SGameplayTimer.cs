using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.GameplayTimer
{
	// Token: 0x02003F4B RID: 16203
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/GameplayTimer/SGameplayTimer.SGameplayTimer")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SGameplayTimer : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060293F3 RID: 168947 RVA: 0x009BF590 File Offset: 0x009BD790
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayTimer._ScriptStructPtr != 0) ? SGameplayTimer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/GameplayTimer/SGameplayTimer.SGameplayTimer", ref SGameplayTimer._ScriptStructPtr);
		}

		// Token: 0x17006242 RID: 25154
		// (get) Token: 0x060293F4 RID: 168948 RVA: 0x009BF5B4 File Offset: 0x009BD7B4
		// (set) Token: 0x060293F5 RID: 168949 RVA: 0x009BF5C4 File Offset: 0x009BD7C4
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006243 RID: 25155
		// (get) Token: 0x060293F6 RID: 168950 RVA: 0x009BF5D5 File Offset: 0x009BD7D5
		// (set) Token: 0x060293F7 RID: 168951 RVA: 0x009BF5E5 File Offset: 0x009BD7E5
		public unsafe int TimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006244 RID: 25156
		// (get) Token: 0x060293F8 RID: 168952 RVA: 0x009BF5F6 File Offset: 0x009BD7F6
		// (set) Token: 0x060293F9 RID: 168953 RVA: 0x009BF606 File Offset: 0x009BD806
		public unsafe int TimerFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006245 RID: 25157
		// (get) Token: 0x060293FA RID: 168954 RVA: 0x009BF617 File Offset: 0x009BD817
		// (set) Token: 0x060293FB RID: 168955 RVA: 0x009BF62B File Offset: 0x009BD82B
		public unsafe string UIRes
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SGameplayTimer.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SGameplayTimer.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17006246 RID: 25158
		// (get) Token: 0x060293FC RID: 168956 RVA: 0x009BF640 File Offset: 0x009BD840
		// (set) Token: 0x060293FD RID: 168957 RVA: 0x009BF650 File Offset: 0x009BD850
		public unsafe int StarEventGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006247 RID: 25159
		// (get) Token: 0x060293FE RID: 168958 RVA: 0x009BF661 File Offset: 0x009BD861
		// (set) Token: 0x060293FF RID: 168959 RVA: 0x009BF671 File Offset: 0x009BD871
		public unsafe int EndEventGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006248 RID: 25160
		// (get) Token: 0x06029400 RID: 168960 RVA: 0x009BF682 File Offset: 0x009BD882
		// (set) Token: 0x06029401 RID: 168961 RVA: 0x009BF696 File Offset: 0x009BD896
		public unsafe string EndTips
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SGameplayTimer.__PropertyOffset_6)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SGameplayTimer.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x17006249 RID: 25161
		// (get) Token: 0x06029402 RID: 168962 RVA: 0x009BF6AB File Offset: 0x009BD8AB
		// (set) Token: 0x06029403 RID: 168963 RVA: 0x009BF6BB File Offset: 0x009BD8BB
		public unsafe int ValidRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700624A RID: 25162
		// (get) Token: 0x06029404 RID: 168964 RVA: 0x009BF6CC File Offset: 0x009BD8CC
		// (set) Token: 0x06029405 RID: 168965 RVA: 0x009BF6DC File Offset: 0x009BD8DC
		public unsafe int CentralPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGameplayTimer.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700624B RID: 25163
		// (get) Token: 0x06029406 RID: 168966 RVA: 0x009BF6ED File Offset: 0x009BD8ED
		// (set) Token: 0x06029407 RID: 168967 RVA: 0x009BF701 File Offset: 0x009BD901
		public unsafe string RangeTips
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SGameplayTimer.__PropertyOffset_9)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SGameplayTimer.__PropertyOffset_9)), value);
			}
		}

		// Token: 0x06029408 RID: 168968 RVA: 0x009BF716 File Offset: 0x009BD916
		public SGameplayTimer()
		{
		}

		// Token: 0x06029409 RID: 168969 RVA: 0x009BF720 File Offset: 0x009BD920
		public SGameplayTimer(int ID, int TimeLength, int TimerFormat, string UIRes, int StarEventGroup, int EndEventGroup, string EndTips, int ValidRange, int CentralPos, string RangeTips)
		{
			this.ID = ID;
			this.TimeLength = TimeLength;
			this.TimerFormat = TimerFormat;
			this.UIRes = UIRes;
			this.StarEventGroup = StarEventGroup;
			this.EndEventGroup = EndEventGroup;
			this.EndTips = EndTips;
			this.ValidRange = ValidRange;
			this.CentralPos = CentralPos;
			this.RangeTips = RangeTips;
		}

		// Token: 0x0602940A RID: 168970 RVA: 0x009BF780 File Offset: 0x009BD980
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayTimer.StaticStruct();
		}

		// Token: 0x0602940B RID: 168971 RVA: 0x009BF78C File Offset: 0x009BD98C
		[NullableContext(2)]
		public SGameplayTimer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602940C RID: 168972 RVA: 0x009BF796 File Offset: 0x009BD996
		public SGameplayTimer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602940D RID: 168973 RVA: 0x009BF7A1 File Offset: 0x009BD9A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayTimer(Pointer, false, true);
		}

		// Token: 0x0602940E RID: 168974 RVA: 0x009BF7AB File Offset: 0x009BD9AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayTimer(Pointer, MemoryOwner);
		}

		// Token: 0x040151FD RID: 86525
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/GameplayTimer/SGameplayTimer.SGameplayTimer";

		// Token: 0x040151FE RID: 86526
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151FF RID: 86527
		internal static int __PropertyOffset_0;

		// Token: 0x04015200 RID: 86528
		internal static int __PropertyOffset_1;

		// Token: 0x04015201 RID: 86529
		internal static int __PropertyOffset_2;

		// Token: 0x04015202 RID: 86530
		internal static int __PropertyOffset_3;

		// Token: 0x04015203 RID: 86531
		internal static int __PropertyOffset_4;

		// Token: 0x04015204 RID: 86532
		internal static int __PropertyOffset_5;

		// Token: 0x04015205 RID: 86533
		internal static int __PropertyOffset_6;

		// Token: 0x04015206 RID: 86534
		internal static int __PropertyOffset_7;

		// Token: 0x04015207 RID: 86535
		internal static int __PropertyOffset_8;

		// Token: 0x04015208 RID: 86536
		internal static int __PropertyOffset_9;
	}
}
