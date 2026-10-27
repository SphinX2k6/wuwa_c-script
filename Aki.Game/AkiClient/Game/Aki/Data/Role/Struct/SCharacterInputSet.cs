using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003E9B RID: 16027
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SCharacterInputSet.SCharacterInputSet")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 93)]
	public class SCharacterInputSet : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028857 RID: 165975 RVA: 0x009AE467 File Offset: 0x009AC667
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterInputSet._ScriptStructPtr != 0) ? SCharacterInputSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SCharacterInputSet.SCharacterInputSet", ref SCharacterInputSet._ScriptStructPtr);
		}

		// Token: 0x17005E48 RID: 24136
		// (get) Token: 0x06028858 RID: 165976 RVA: 0x009AE48B File Offset: 0x009AC68B
		// (set) Token: 0x06028859 RID: 165977 RVA: 0x009AE49F File Offset: 0x009AC69F
		public unsafe FName 名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005E49 RID: 24137
		// (get) Token: 0x0602885A RID: 165978 RVA: 0x009AE4B4 File Offset: 0x009AC6B4
		// (set) Token: 0x0602885B RID: 165979 RVA: 0x009AE4C4 File Offset: 0x009AC6C4
		public unsafe bool 是否是大招
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E4A RID: 24138
		// (get) Token: 0x0602885C RID: 165980 RVA: 0x009AE4D5 File Offset: 0x009AC6D5
		// (set) Token: 0x0602885D RID: 165981 RVA: 0x009AE4E5 File Offset: 0x009AC6E5
		public unsafe bool 是否是幻象
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E4B RID: 24139
		// (get) Token: 0x0602885E RID: 165982 RVA: 0x009AE4F6 File Offset: 0x009AC6F6
		// (set) Token: 0x0602885F RID: 165983 RVA: 0x009AE506 File Offset: 0x009AC706
		public unsafe int ListenAttributeDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005E4C RID: 24140
		// (get) Token: 0x06028860 RID: 165984 RVA: 0x009AE517 File Offset: 0x009AC717
		// (set) Token: 0x06028861 RID: 165985 RVA: 0x009AE527 File Offset: 0x009AC727
		public unsafe int ListenMaxAttributeDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005E4D RID: 24141
		// (get) Token: 0x06028862 RID: 165986 RVA: 0x009AE538 File Offset: 0x009AC738
		// (set) Token: 0x06028863 RID: 165987 RVA: 0x009AE54C File Offset: 0x009AC74C
		public unsafe string MaxAttributeEffect
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterInputSet.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterInputSet.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17005E4E RID: 24142
		// (get) Token: 0x06028864 RID: 165988 RVA: 0x009AE561 File Offset: 0x009AC761
		// (set) Token: 0x06028865 RID: 165989 RVA: 0x009AE575 File Offset: 0x009AC775
		public unsafe FLinearColor AttributeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005E4F RID: 24143
		// (get) Token: 0x06028866 RID: 165990 RVA: 0x009AE58A File Offset: 0x009AC78A
		// (set) Token: 0x06028867 RID: 165991 RVA: 0x009AE59A File Offset: 0x009AC79A
		public unsafe bool bUseElementColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E50 RID: 24144
		// (get) Token: 0x06028868 RID: 165992 RVA: 0x009AE5AB File Offset: 0x009AC7AB
		// (set) Token: 0x06028869 RID: 165993 RVA: 0x009AE5BB File Offset: 0x009AC7BB
		public unsafe float 长按时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005E51 RID: 24145
		// (get) Token: 0x0602886A RID: 165994 RVA: 0x009AE5CC File Offset: 0x009AC7CC
		// (set) Token: 0x0602886B RID: 165995 RVA: 0x009AE5DC File Offset: 0x009AC7DC
		public unsafe float 按键缓存记录延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005E52 RID: 24146
		// (get) Token: 0x0602886C RID: 165996 RVA: 0x009AE5F0 File Offset: 0x009AC7F0
		// (set) Token: 0x0602886D RID: 165997 RVA: 0x009AE633 File Offset: 0x009AC833
		public TArray<int> 技能Id列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._技能Id列表) == null)
				{
					result = (this._技能Id列表 = new TArray<int>(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.技能Id列表.CopyAssign(value);
			}
		}

		// Token: 0x17005E53 RID: 24147
		// (get) Token: 0x0602886E RID: 165998 RVA: 0x009AE641 File Offset: 0x009AC841
		// (set) Token: 0x0602886F RID: 165999 RVA: 0x009AE651 File Offset: 0x009AC851
		public unsafe int 幻象id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005E54 RID: 24148
		// (get) Token: 0x06028870 RID: 166000 RVA: 0x009AE662 File Offset: 0x009AC862
		// (set) Token: 0x06028871 RID: 166001 RVA: 0x009AE676 File Offset: 0x009AC876
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputAction> Action
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_12);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterInputSet.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06028872 RID: 166002 RVA: 0x009AE68B File Offset: 0x009AC88B
		public SCharacterInputSet()
		{
		}

		// Token: 0x06028873 RID: 166003 RVA: 0x009AE694 File Offset: 0x009AC894
		public SCharacterInputSet(FName 名称, bool 是否是大招, bool 是否是幻象, int ListenAttributeDataId, int ListenMaxAttributeDataId, string MaxAttributeEffect, FLinearColor AttributeColor, bool bUseElementColor, float 长按时间, float 按键缓存记录延迟时间, TArray<int> 技能Id列表, int 幻象id, [Nullable(0)] TEnumAsByte<EInputAction> Action)
		{
			this.名称 = 名称;
			this.是否是大招 = 是否是大招;
			this.是否是幻象 = 是否是幻象;
			this.ListenAttributeDataId = ListenAttributeDataId;
			this.ListenMaxAttributeDataId = ListenMaxAttributeDataId;
			this.MaxAttributeEffect = MaxAttributeEffect;
			this.AttributeColor = AttributeColor;
			this.bUseElementColor = bUseElementColor;
			this.长按时间 = 长按时间;
			this.按键缓存记录延迟时间 = 按键缓存记录延迟时间;
			this.技能Id列表 = 技能Id列表;
			this.幻象id = 幻象id;
			this.Action = Action;
		}

		// Token: 0x06028874 RID: 166004 RVA: 0x009AE70C File Offset: 0x009AC90C
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterInputSet.StaticStruct();
		}

		// Token: 0x06028875 RID: 166005 RVA: 0x009AE718 File Offset: 0x009AC918
		[NullableContext(2)]
		public SCharacterInputSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028876 RID: 166006 RVA: 0x009AE722 File Offset: 0x009AC922
		public SCharacterInputSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028877 RID: 166007 RVA: 0x009AE72D File Offset: 0x009AC92D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterInputSet(Pointer, false, true);
		}

		// Token: 0x06028878 RID: 166008 RVA: 0x009AE737 File Offset: 0x009AC937
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterInputSet(Pointer, MemoryOwner);
		}

		// Token: 0x04014AAF RID: 84655
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SCharacterInputSet.SCharacterInputSet";

		// Token: 0x04014AB0 RID: 84656
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AB1 RID: 84657
		internal static int __PropertyOffset_0;

		// Token: 0x04014AB2 RID: 84658
		internal static int __PropertyOffset_1;

		// Token: 0x04014AB3 RID: 84659
		internal static int __PropertyOffset_2;

		// Token: 0x04014AB4 RID: 84660
		internal static int __PropertyOffset_3;

		// Token: 0x04014AB5 RID: 84661
		internal static int __PropertyOffset_4;

		// Token: 0x04014AB6 RID: 84662
		internal static int __PropertyOffset_5;

		// Token: 0x04014AB7 RID: 84663
		internal static int __PropertyOffset_6;

		// Token: 0x04014AB8 RID: 84664
		internal static int __PropertyOffset_7;

		// Token: 0x04014AB9 RID: 84665
		internal static int __PropertyOffset_8;

		// Token: 0x04014ABA RID: 84666
		internal static int __PropertyOffset_9;

		// Token: 0x04014ABB RID: 84667
		internal static int __PropertyOffset_10;

		// Token: 0x04014ABC RID: 84668
		[Nullable(2)]
		private TArray<int> _技能Id列表;

		// Token: 0x04014ABD RID: 84669
		internal static int __PropertyOffset_11;

		// Token: 0x04014ABE RID: 84670
		internal static int __PropertyOffset_12;
	}
}
