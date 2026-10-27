using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.ClothPath
{
	// Token: 0x02003C94 RID: 15508
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/S_KuroCSClothPath.S_KuroCSClothPath")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class S_KuroCSClothPath : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024456 RID: 148566 RVA: 0x00939EE3 File Offset: 0x009380E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_KuroCSClothPath._ScriptStructPtr != 0) ? S_KuroCSClothPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/S_KuroCSClothPath.S_KuroCSClothPath", ref S_KuroCSClothPath._ScriptStructPtr);
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x06024457 RID: 148567 RVA: 0x00939F07 File Offset: 0x00938107
		// (set) Token: 0x06024458 RID: 148568 RVA: 0x00939F1B File Offset: 0x0093811B
		[Nullable(2)]
		public unsafe UDataTable Table
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + S_KuroCSClothPath.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + S_KuroCSClothPath.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x06024459 RID: 148569 RVA: 0x00939F30 File Offset: 0x00938130
		// (set) Token: 0x0602445A RID: 148570 RVA: 0x00939F40 File Offset: 0x00938140
		public unsafe float CollisionWorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17004623 RID: 17955
		// (get) Token: 0x0602445B RID: 148571 RVA: 0x00939F51 File Offset: 0x00938151
		// (set) Token: 0x0602445C RID: 148572 RVA: 0x00939F61 File Offset: 0x00938161
		public unsafe float UpOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004624 RID: 17956
		// (get) Token: 0x0602445D RID: 148573 RVA: 0x00939F72 File Offset: 0x00938172
		// (set) Token: 0x0602445E RID: 148574 RVA: 0x00939F82 File Offset: 0x00938182
		public unsafe int XCOUNT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x0602445F RID: 148575 RVA: 0x00939F93 File Offset: 0x00938193
		// (set) Token: 0x06024460 RID: 148576 RVA: 0x00939FA3 File Offset: 0x009381A3
		public unsafe int YCOUNT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x06024461 RID: 148577 RVA: 0x00939FB4 File Offset: 0x009381B4
		// (set) Token: 0x06024462 RID: 148578 RVA: 0x00939FC4 File Offset: 0x009381C4
		public unsafe float AttenuationPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x06024463 RID: 148579 RVA: 0x00939FD8 File Offset: 0x009381D8
		// (set) Token: 0x06024464 RID: 148580 RVA: 0x0093A01B File Offset: 0x0093821B
		public TArray<UMaterialInstance> mobileMat
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._mobileMat) == null)
				{
					result = (this._mobileMat = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)S_KuroCSClothPath.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.mobileMat.CopyAssign(value);
			}
		}

		// Token: 0x06024465 RID: 148581 RVA: 0x0093A029 File Offset: 0x00938229
		public S_KuroCSClothPath()
		{
		}

		// Token: 0x06024466 RID: 148582 RVA: 0x0093A031 File Offset: 0x00938231
		public S_KuroCSClothPath(UDataTable Table, float CollisionWorldRadius, float UpOffset, int XCOUNT, int YCOUNT, float AttenuationPower, TArray<UMaterialInstance> mobileMat)
		{
			this.Table = Table;
			this.CollisionWorldRadius = CollisionWorldRadius;
			this.UpOffset = UpOffset;
			this.XCOUNT = XCOUNT;
			this.YCOUNT = YCOUNT;
			this.AttenuationPower = AttenuationPower;
			this.mobileMat = mobileMat;
		}

		// Token: 0x06024467 RID: 148583 RVA: 0x0093A06E File Offset: 0x0093826E
		protected override IntPtr GetUStructPtr()
		{
			return S_KuroCSClothPath.StaticStruct();
		}

		// Token: 0x06024468 RID: 148584 RVA: 0x0093A07A File Offset: 0x0093827A
		[NullableContext(2)]
		public S_KuroCSClothPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024469 RID: 148585 RVA: 0x0093A084 File Offset: 0x00938284
		public S_KuroCSClothPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602446A RID: 148586 RVA: 0x0093A08F File Offset: 0x0093828F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_KuroCSClothPath(Pointer, false, true);
		}

		// Token: 0x0602446B RID: 148587 RVA: 0x0093A099 File Offset: 0x00938299
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_KuroCSClothPath(Pointer, MemoryOwner);
		}

		// Token: 0x04011FB5 RID: 73653
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/S_KuroCSClothPath.S_KuroCSClothPath";

		// Token: 0x04011FB6 RID: 73654
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011FB7 RID: 73655
		internal static int __PropertyOffset_0;

		// Token: 0x04011FB8 RID: 73656
		internal static int __PropertyOffset_1;

		// Token: 0x04011FB9 RID: 73657
		internal static int __PropertyOffset_2;

		// Token: 0x04011FBA RID: 73658
		internal static int __PropertyOffset_3;

		// Token: 0x04011FBB RID: 73659
		internal static int __PropertyOffset_4;

		// Token: 0x04011FBC RID: 73660
		internal static int __PropertyOffset_5;

		// Token: 0x04011FBD RID: 73661
		internal static int __PropertyOffset_6;

		// Token: 0x04011FBE RID: 73662
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _mobileMat;
	}
}
