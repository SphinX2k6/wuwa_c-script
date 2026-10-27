using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.NPC.LevelAiBtTree
{
	// Token: 0x02003EF4 RID: 16116
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/NPC/LevelAiBtTree/SVarRefContext.SVarRefContext")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 101)]
	public class SVarRefContext : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028CF4 RID: 167156 RVA: 0x009B522D File Offset: 0x009B342D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVarRefContext._ScriptStructPtr != 0) ? SVarRefContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/NPC/LevelAiBtTree/SVarRefContext.SVarRefContext", ref SVarRefContext._ScriptStructPtr);
		}

		// Token: 0x17005FB4 RID: 24500
		// (get) Token: 0x06028CF5 RID: 167157 RVA: 0x009B5251 File Offset: 0x009B3451
		// (set) Token: 0x06028CF6 RID: 167158 RVA: 0x009B5265 File Offset: 0x009B3465
		public unsafe string Type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005FB5 RID: 24501
		// (get) Token: 0x06028CF7 RID: 167159 RVA: 0x009B527A File Offset: 0x009B347A
		// (set) Token: 0x06028CF8 RID: 167160 RVA: 0x009B528E File Offset: 0x009B348E
		public unsafe string VarRefSource
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17005FB6 RID: 24502
		// (get) Token: 0x06028CF9 RID: 167161 RVA: 0x009B52A3 File Offset: 0x009B34A3
		// (set) Token: 0x06028CFA RID: 167162 RVA: 0x009B52B7 File Offset: 0x009B34B7
		public unsafe string VarRefType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17005FB7 RID: 24503
		// (get) Token: 0x06028CFB RID: 167163 RVA: 0x009B52CC File Offset: 0x009B34CC
		// (set) Token: 0x06028CFC RID: 167164 RVA: 0x009B52DC File Offset: 0x009B34DC
		public unsafe int RefId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005FB8 RID: 24504
		// (get) Token: 0x06028CFD RID: 167165 RVA: 0x009B52ED File Offset: 0x009B34ED
		// (set) Token: 0x06028CFE RID: 167166 RVA: 0x009B5301 File Offset: 0x009B3501
		public unsafe string Key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17005FB9 RID: 24505
		// (get) Token: 0x06028CFF RID: 167167 RVA: 0x009B5316 File Offset: 0x009B3516
		// (set) Token: 0x06028D00 RID: 167168 RVA: 0x009B532A File Offset: 0x009B352A
		public unsafe string StringValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SVarRefContext.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17005FBA RID: 24506
		// (get) Token: 0x06028D01 RID: 167169 RVA: 0x009B533F File Offset: 0x009B353F
		// (set) Token: 0x06028D02 RID: 167170 RVA: 0x009B534F File Offset: 0x009B354F
		public unsafe bool BoolValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005FBB RID: 24507
		// (get) Token: 0x06028D03 RID: 167171 RVA: 0x009B5360 File Offset: 0x009B3560
		// (set) Token: 0x06028D04 RID: 167172 RVA: 0x009B5370 File Offset: 0x009B3570
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005FBC RID: 24508
		// (get) Token: 0x06028D05 RID: 167173 RVA: 0x009B5381 File Offset: 0x009B3581
		// (set) Token: 0x06028D06 RID: 167174 RVA: 0x009B5391 File Offset: 0x009B3591
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005FBD RID: 24509
		// (get) Token: 0x06028D07 RID: 167175 RVA: 0x009B53A2 File Offset: 0x009B35A2
		// (set) Token: 0x06028D08 RID: 167176 RVA: 0x009B53B2 File Offset: 0x009B35B2
		public unsafe bool IsClientVariable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SVarRefContext.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028D09 RID: 167177 RVA: 0x009B53C3 File Offset: 0x009B35C3
		public SVarRefContext()
		{
		}

		// Token: 0x06028D0A RID: 167178 RVA: 0x009B53CC File Offset: 0x009B35CC
		public SVarRefContext(string Type, string VarRefSource, string VarRefType, int RefId, string Key, string StringValue, bool BoolValue, float FloatValue, int IntValue, bool IsClientVariable)
		{
			this.Type = Type;
			this.VarRefSource = VarRefSource;
			this.VarRefType = VarRefType;
			this.RefId = RefId;
			this.Key = Key;
			this.StringValue = StringValue;
			this.BoolValue = BoolValue;
			this.FloatValue = FloatValue;
			this.IntValue = IntValue;
			this.IsClientVariable = IsClientVariable;
		}

		// Token: 0x06028D0B RID: 167179 RVA: 0x009B542C File Offset: 0x009B362C
		protected override IntPtr GetUStructPtr()
		{
			return SVarRefContext.StaticStruct();
		}

		// Token: 0x06028D0C RID: 167180 RVA: 0x009B5438 File Offset: 0x009B3638
		[NullableContext(2)]
		public SVarRefContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028D0D RID: 167181 RVA: 0x009B5442 File Offset: 0x009B3642
		public SVarRefContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028D0E RID: 167182 RVA: 0x009B544D File Offset: 0x009B364D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVarRefContext(Pointer, false, true);
		}

		// Token: 0x06028D0F RID: 167183 RVA: 0x009B5457 File Offset: 0x009B3657
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVarRefContext(Pointer, MemoryOwner);
		}

		// Token: 0x04014DE1 RID: 85473
		public const string __ObjectPath = "/Game/Aki/Data/NPC/LevelAiBtTree/SVarRefContext.SVarRefContext";

		// Token: 0x04014DE2 RID: 85474
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014DE3 RID: 85475
		internal static int __PropertyOffset_0;

		// Token: 0x04014DE4 RID: 85476
		internal static int __PropertyOffset_1;

		// Token: 0x04014DE5 RID: 85477
		internal static int __PropertyOffset_2;

		// Token: 0x04014DE6 RID: 85478
		internal static int __PropertyOffset_3;

		// Token: 0x04014DE7 RID: 85479
		internal static int __PropertyOffset_4;

		// Token: 0x04014DE8 RID: 85480
		internal static int __PropertyOffset_5;

		// Token: 0x04014DE9 RID: 85481
		internal static int __PropertyOffset_6;

		// Token: 0x04014DEA RID: 85482
		internal static int __PropertyOffset_7;

		// Token: 0x04014DEB RID: 85483
		internal static int __PropertyOffset_8;

		// Token: 0x04014DEC RID: 85484
		internal static int __PropertyOffset_9;
	}
}
