using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.ControlMonster
{
	// Token: 0x020032D5 RID: 13013
	[UnrealObjectPath("/Game/Aki/Character/Input/ControlMonster/ICM_AutomaticFlight_DataBase.ICM_AutomaticFlight_DataBase_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class ICM_AutomaticFlight_DataBase_C : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F5A RID: 135002 RVA: 0x00953898 File Offset: 0x00951A98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ICM_AutomaticFlight_DataBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/ControlMonster/ICM_AutomaticFlight_DataBase.ICM_AutomaticFlight_DataBase_C");
			}
			return ICM_AutomaticFlight_DataBase_C._ClassPtr;
		}

		// Token: 0x06020F5B RID: 135003 RVA: 0x009538BC File Offset: 0x00951ABC
		public ICM_AutomaticFlight_DataBase_C() : this(BuiltinUtils.AllocNativeUObject(ICM_AutomaticFlight_DataBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F5C RID: 135004 RVA: 0x009538E4 File Offset: 0x00951AE4
		[NullableContext(1)]
		public ICM_AutomaticFlight_DataBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ICM_AutomaticFlight_DataBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x06020F5D RID: 135005 RVA: 0x00953917 File Offset: 0x00951B17
		// (set) Token: 0x06020F5E RID: 135006 RVA: 0x00953927 File Offset: 0x00951B27
		public unsafe float 低飞行速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_低飞行速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_低飞行速度) = value;
			}
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x06020F5F RID: 135007 RVA: 0x00953938 File Offset: 0x00951B38
		// (set) Token: 0x06020F60 RID: 135008 RVA: 0x00953948 File Offset: 0x00951B48
		public unsafe float 标准飞行速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_标准飞行速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_标准飞行速度) = value;
			}
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x06020F61 RID: 135009 RVA: 0x00953959 File Offset: 0x00951B59
		// (set) Token: 0x06020F62 RID: 135010 RVA: 0x00953969 File Offset: 0x00951B69
		public unsafe float 高飞行速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_高飞行速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_高飞行速度) = value;
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x06020F63 RID: 135011 RVA: 0x0095397A File Offset: 0x00951B7A
		// (set) Token: 0x06020F64 RID: 135012 RVA: 0x0095398E File Offset: 0x00951B8E
		[Nullable(2)]
		public unsafe UCurveVector 速度过渡曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + ICM_AutomaticFlight_DataBase_C.__PropertyOffset_速度过渡曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ICM_AutomaticFlight_DataBase_C.__PropertyOffset_速度过渡曲线, value);
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x06020F65 RID: 135013 RVA: 0x009539A3 File Offset: 0x00951BA3
		// (set) Token: 0x06020F66 RID: 135014 RVA: 0x009539B3 File Offset: 0x00951BB3
		public unsafe float 前向轴输入响应比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_前向轴输入响应比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_前向轴输入响应比例) = value;
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x06020F67 RID: 135015 RVA: 0x009539C4 File Offset: 0x00951BC4
		// (set) Token: 0x06020F68 RID: 135016 RVA: 0x009539D4 File Offset: 0x00951BD4
		public unsafe int 前向轴输入响应技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_前向轴输入响应技能);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_前向轴输入响应技能) = value;
			}
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x06020F69 RID: 135017 RVA: 0x009539E5 File Offset: 0x00951BE5
		// (set) Token: 0x06020F6A RID: 135018 RVA: 0x009539F5 File Offset: 0x00951BF5
		public unsafe float 后向轴输入响应比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_后向轴输入响应比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_后向轴输入响应比例) = value;
			}
		}

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x06020F6B RID: 135019 RVA: 0x00953A06 File Offset: 0x00951C06
		// (set) Token: 0x06020F6C RID: 135020 RVA: 0x00953A16 File Offset: 0x00951C16
		public unsafe int 后向轴输入响应技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_后向轴输入响应技能);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ICM_AutomaticFlight_DataBase_C.__PropertyOffset_后向轴输入响应技能) = value;
			}
		}

		// Token: 0x06020F6D RID: 135021 RVA: 0x00953A27 File Offset: 0x00951C27
		protected ICM_AutomaticFlight_DataBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DDA RID: 73178
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/ControlMonster/ICM_AutomaticFlight_DataBase.ICM_AutomaticFlight_DataBase_C";

		// Token: 0x04011DDB RID: 73179
		private static IntPtr _ClassPtr;

		// Token: 0x04011DDC RID: 73180
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DDD RID: 73181
		internal static int __PropertyOffset_低飞行速度;

		// Token: 0x04011DDE RID: 73182
		internal static int __PropertyOffset_标准飞行速度;

		// Token: 0x04011DDF RID: 73183
		internal static int __PropertyOffset_高飞行速度;

		// Token: 0x04011DE0 RID: 73184
		internal static int __PropertyOffset_速度过渡曲线;

		// Token: 0x04011DE1 RID: 73185
		internal static int __PropertyOffset_前向轴输入响应比例;

		// Token: 0x04011DE2 RID: 73186
		internal static int __PropertyOffset_前向轴输入响应技能;

		// Token: 0x04011DE3 RID: 73187
		internal static int __PropertyOffset_后向轴输入响应比例;

		// Token: 0x04011DE4 RID: 73188
		internal static int __PropertyOffset_后向轴输入响应技能;
	}
}
