using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction
{
	// Token: 0x02003C70 RID: 15472
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Property.PCG_LightPrefab_Property_C")]
	[UnrealStructLayout(3504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3504)]
	public class PCG_LightPrefab_Property_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023E23 RID: 146979 RVA: 0x0092FAEF File Offset: 0x0092DCEF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PCG_LightPrefab_Property_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Property.PCG_LightPrefab_Property_C");
			}
			return PCG_LightPrefab_Property_C._ClassPtr;
		}

		// Token: 0x06023E24 RID: 146980 RVA: 0x0092FB14 File Offset: 0x0092DD14
		public PCG_LightPrefab_Property_C() : this(BuiltinUtils.AllocNativeUObject(PCG_LightPrefab_Property_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023E25 RID: 146981 RVA: 0x0092FB3C File Offset: 0x0092DD3C
		public PCG_LightPrefab_Property_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PCG_LightPrefab_Property_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x06023E26 RID: 146982 RVA: 0x0092FB6F File Offset: 0x0092DD6F
		// (set) Token: 0x06023E27 RID: 146983 RVA: 0x0092FB7F File Offset: 0x0092DD7F
		public unsafe bool 工具同步
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043F2 RID: 17394
		// (get) Token: 0x06023E28 RID: 146984 RVA: 0x0092FB90 File Offset: 0x0092DD90
		// (set) Token: 0x06023E29 RID: 146985 RVA: 0x0092FBA0 File Offset: 0x0092DDA0
		public unsafe bool TOD同步
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043F3 RID: 17395
		// (get) Token: 0x06023E2A RID: 146986 RVA: 0x0092FBB1 File Offset: 0x0092DDB1
		// (set) Token: 0x06023E2B RID: 146987 RVA: 0x0092FBC1 File Offset: 0x0092DDC1
		public unsafe float TOD同步频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170043F4 RID: 17396
		// (get) Token: 0x06023E2C RID: 146988 RVA: 0x0092FBD4 File Offset: 0x0092DDD4
		// (set) Token: 0x06023E2D RID: 146989 RVA: 0x0092FC0D File Offset: 0x0092DE0D
		public PCG_LightPrefab_Light 灯光
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Light result;
				if ((result = this._灯光) == null)
				{
					result = (this._灯光 = new PCG_LightPrefab_Light(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Light.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F5 RID: 17397
		// (get) Token: 0x06023E2E RID: 146990 RVA: 0x0092FC30 File Offset: 0x0092DE30
		// (set) Token: 0x06023E2F RID: 146991 RVA: 0x0092FC69 File Offset: 0x0092DE69
		public PCG_LightPrefab_Mesh 模型
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Mesh result;
				if ((result = this._模型) == null)
				{
					result = (this._模型 = new PCG_LightPrefab_Mesh(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Mesh.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x06023E30 RID: 146992 RVA: 0x0092FC8C File Offset: 0x0092DE8C
		// (set) Token: 0x06023E31 RID: 146993 RVA: 0x0092FCC5 File Offset: 0x0092DEC5
		public PCG_LightPrefab_Decal 贴花
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Decal result;
				if ((result = this._贴花) == null)
				{
					result = (this._贴花 = new PCG_LightPrefab_Decal(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Decal.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x06023E32 RID: 146994 RVA: 0x0092FCE8 File Offset: 0x0092DEE8
		// (set) Token: 0x06023E33 RID: 146995 RVA: 0x0092FD21 File Offset: 0x0092DF21
		public PCG_LightPrefab_Fog 雾效
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Fog result;
				if ((result = this._雾效) == null)
				{
					result = (this._雾效 = new PCG_LightPrefab_Fog(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Fog.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x06023E34 RID: 146996 RVA: 0x0092FD44 File Offset: 0x0092DF44
		// (set) Token: 0x06023E35 RID: 146997 RVA: 0x0092FD7D File Offset: 0x0092DF7D
		public PCG_LightPrefab_Effect 特效
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Effect result;
				if ((result = this._特效) == null)
				{
					result = (this._特效 = new PCG_LightPrefab_Effect(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Effect.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x06023E36 RID: 146998 RVA: 0x0092FDA0 File Offset: 0x0092DFA0
		// (set) Token: 0x06023E37 RID: 146999 RVA: 0x0092FDD9 File Offset: 0x0092DFD9
		public PCG_LightPrefab_Swing 摆动
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Swing result;
				if ((result = this._摆动) == null)
				{
					result = (this._摆动 = new PCG_LightPrefab_Swing(base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Swing.StaticStruct(), base.NativePtr + (IntPtr)PCG_LightPrefab_Property_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023E38 RID: 147000 RVA: 0x0092FDFA File Offset: 0x0092DFFA
		protected PCG_LightPrefab_Property_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BFC RID: 72700
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/Struction/PCG_LightPrefab_Property.PCG_LightPrefab_Property_C";

		// Token: 0x04011BFD RID: 72701
		private static IntPtr _ClassPtr;

		// Token: 0x04011BFE RID: 72702
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BFF RID: 72703
		internal static int __PropertyOffset_0;

		// Token: 0x04011C00 RID: 72704
		internal static int __PropertyOffset_1;

		// Token: 0x04011C01 RID: 72705
		internal static int __PropertyOffset_2;

		// Token: 0x04011C02 RID: 72706
		internal static int __PropertyOffset_3;

		// Token: 0x04011C03 RID: 72707
		[Nullable(2)]
		private PCG_LightPrefab_Light _灯光;

		// Token: 0x04011C04 RID: 72708
		internal static int __PropertyOffset_4;

		// Token: 0x04011C05 RID: 72709
		[Nullable(2)]
		private PCG_LightPrefab_Mesh _模型;

		// Token: 0x04011C06 RID: 72710
		internal static int __PropertyOffset_5;

		// Token: 0x04011C07 RID: 72711
		[Nullable(2)]
		private PCG_LightPrefab_Decal _贴花;

		// Token: 0x04011C08 RID: 72712
		internal static int __PropertyOffset_6;

		// Token: 0x04011C09 RID: 72713
		[Nullable(2)]
		private PCG_LightPrefab_Fog _雾效;

		// Token: 0x04011C0A RID: 72714
		internal static int __PropertyOffset_7;

		// Token: 0x04011C0B RID: 72715
		[Nullable(2)]
		private PCG_LightPrefab_Effect _特效;

		// Token: 0x04011C0C RID: 72716
		internal static int __PropertyOffset_8;

		// Token: 0x04011C0D RID: 72717
		[Nullable(2)]
		private PCG_LightPrefab_Swing _摆动;
	}
}
