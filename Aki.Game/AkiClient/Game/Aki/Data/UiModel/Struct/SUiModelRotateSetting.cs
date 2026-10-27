using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiModel.Struct
{
	// Token: 0x02003E8D RID: 16013
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiModel/Struct/SUiModelRotateSetting.SUiModelRotateSetting")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class SUiModelRotateSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060286F3 RID: 165619 RVA: 0x009AC750 File Offset: 0x009AA950
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiModelRotateSetting._ScriptStructPtr != 0) ? SUiModelRotateSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiModel/Struct/SUiModelRotateSetting.SUiModelRotateSetting", ref SUiModelRotateSetting._ScriptStructPtr);
		}

		// Token: 0x17005DBA RID: 23994
		// (get) Token: 0x060286F4 RID: 165620 RVA: 0x009AC774 File Offset: 0x009AA974
		// (set) Token: 0x060286F5 RID: 165621 RVA: 0x009AC788 File Offset: 0x009AA988
		public unsafe string 旋转中轴
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiModelRotateSetting.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiModelRotateSetting.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005DBB RID: 23995
		// (get) Token: 0x060286F6 RID: 165622 RVA: 0x009AC79D File Offset: 0x009AA99D
		// (set) Token: 0x060286F7 RID: 165623 RVA: 0x009AC7AD File Offset: 0x009AA9AD
		public unsafe float 旋转偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005DBC RID: 23996
		// (get) Token: 0x060286F8 RID: 165624 RVA: 0x009AC7BE File Offset: 0x009AA9BE
		// (set) Token: 0x060286F9 RID: 165625 RVA: 0x009AC7CE File Offset: 0x009AA9CE
		public unsafe float 模型Yaw灵敏度系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005DBD RID: 23997
		// (get) Token: 0x060286FA RID: 165626 RVA: 0x009AC7DF File Offset: 0x009AA9DF
		// (set) Token: 0x060286FB RID: 165627 RVA: 0x009AC7EF File Offset: 0x009AA9EF
		public unsafe float 模型Pitch灵敏度系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005DBE RID: 23998
		// (get) Token: 0x060286FC RID: 165628 RVA: 0x009AC800 File Offset: 0x009AAA00
		// (set) Token: 0x060286FD RID: 165629 RVA: 0x009AC810 File Offset: 0x009AAA10
		public unsafe float Yaw限制Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005DBF RID: 23999
		// (get) Token: 0x060286FE RID: 165630 RVA: 0x009AC821 File Offset: 0x009AAA21
		// (set) Token: 0x060286FF RID: 165631 RVA: 0x009AC831 File Offset: 0x009AAA31
		public unsafe float Yaw限制Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005DC0 RID: 24000
		// (get) Token: 0x06028700 RID: 165632 RVA: 0x009AC842 File Offset: 0x009AAA42
		// (set) Token: 0x06028701 RID: 165633 RVA: 0x009AC852 File Offset: 0x009AAA52
		public unsafe float Pitch限制Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005DC1 RID: 24001
		// (get) Token: 0x06028702 RID: 165634 RVA: 0x009AC863 File Offset: 0x009AAA63
		// (set) Token: 0x06028703 RID: 165635 RVA: 0x009AC873 File Offset: 0x009AAA73
		public unsafe float Pitch限制Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005DC2 RID: 24002
		// (get) Token: 0x06028704 RID: 165636 RVA: 0x009AC884 File Offset: 0x009AAA84
		// (set) Token: 0x06028705 RID: 165637 RVA: 0x009AC894 File Offset: 0x009AAA94
		public unsafe float 最小臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005DC3 RID: 24003
		// (get) Token: 0x06028706 RID: 165638 RVA: 0x009AC8A5 File Offset: 0x009AAAA5
		// (set) Token: 0x06028707 RID: 165639 RVA: 0x009AC8B5 File Offset: 0x009AAAB5
		public unsafe float 最大臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005DC4 RID: 24004
		// (get) Token: 0x06028708 RID: 165640 RVA: 0x009AC8C6 File Offset: 0x009AAAC6
		// (set) Token: 0x06028709 RID: 165641 RVA: 0x009AC8D6 File Offset: 0x009AAAD6
		public unsafe float 倍化手柄输入倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005DC5 RID: 24005
		// (get) Token: 0x0602870A RID: 165642 RVA: 0x009AC8E7 File Offset: 0x009AAAE7
		// (set) Token: 0x0602870B RID: 165643 RVA: 0x009AC8F7 File Offset: 0x009AAAF7
		public unsafe float 移动端旋转输入倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiModelRotateSetting.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x0602870C RID: 165644 RVA: 0x009AC908 File Offset: 0x009AAB08
		public SUiModelRotateSetting()
		{
		}

		// Token: 0x0602870D RID: 165645 RVA: 0x009AC910 File Offset: 0x009AAB10
		public SUiModelRotateSetting(string 旋转中轴, float 旋转偏移, float 模型Yaw灵敏度系数, float 模型Pitch灵敏度系数, float Yaw限制Min, float Yaw限制Max, float Pitch限制Min, float Pitch限制Max, float 最小臂长, float 最大臂长, float 倍化手柄输入倍率, float 移动端旋转输入倍率)
		{
			this.旋转中轴 = 旋转中轴;
			this.旋转偏移 = 旋转偏移;
			this.模型Yaw灵敏度系数 = 模型Yaw灵敏度系数;
			this.模型Pitch灵敏度系数 = 模型Pitch灵敏度系数;
			this.Yaw限制Min = Yaw限制Min;
			this.Yaw限制Max = Yaw限制Max;
			this.Pitch限制Min = Pitch限制Min;
			this.Pitch限制Max = Pitch限制Max;
			this.最小臂长 = 最小臂长;
			this.最大臂长 = 最大臂长;
			this.倍化手柄输入倍率 = 倍化手柄输入倍率;
			this.移动端旋转输入倍率 = 移动端旋转输入倍率;
		}

		// Token: 0x0602870E RID: 165646 RVA: 0x009AC980 File Offset: 0x009AAB80
		protected override IntPtr GetUStructPtr()
		{
			return SUiModelRotateSetting.StaticStruct();
		}

		// Token: 0x0602870F RID: 165647 RVA: 0x009AC98C File Offset: 0x009AAB8C
		[NullableContext(2)]
		public SUiModelRotateSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028710 RID: 165648 RVA: 0x009AC996 File Offset: 0x009AAB96
		public SUiModelRotateSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028711 RID: 165649 RVA: 0x009AC9A1 File Offset: 0x009AABA1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiModelRotateSetting(Pointer, false, true);
		}

		// Token: 0x06028712 RID: 165650 RVA: 0x009AC9AB File Offset: 0x009AABAB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiModelRotateSetting(Pointer, MemoryOwner);
		}

		// Token: 0x040149DF RID: 84447
		public const string __ObjectPath = "/Game/Aki/Data/UiModel/Struct/SUiModelRotateSetting.SUiModelRotateSetting";

		// Token: 0x040149E0 RID: 84448
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149E1 RID: 84449
		internal static int __PropertyOffset_0;

		// Token: 0x040149E2 RID: 84450
		internal static int __PropertyOffset_1;

		// Token: 0x040149E3 RID: 84451
		internal static int __PropertyOffset_2;

		// Token: 0x040149E4 RID: 84452
		internal static int __PropertyOffset_3;

		// Token: 0x040149E5 RID: 84453
		internal static int __PropertyOffset_4;

		// Token: 0x040149E6 RID: 84454
		internal static int __PropertyOffset_5;

		// Token: 0x040149E7 RID: 84455
		internal static int __PropertyOffset_6;

		// Token: 0x040149E8 RID: 84456
		internal static int __PropertyOffset_7;

		// Token: 0x040149E9 RID: 84457
		internal static int __PropertyOffset_8;

		// Token: 0x040149EA RID: 84458
		internal static int __PropertyOffset_9;

		// Token: 0x040149EB RID: 84459
		internal static int __PropertyOffset_10;

		// Token: 0x040149EC RID: 84460
		internal static int __PropertyOffset_11;
	}
}
