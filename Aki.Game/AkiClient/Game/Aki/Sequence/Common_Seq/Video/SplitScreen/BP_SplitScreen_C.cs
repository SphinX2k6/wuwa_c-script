using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen
{
	// Token: 0x02003082 RID: 12418
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen.BP_SplitScreen_C")]
	[UnrealStructLayout(1416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1416)]
	public class BP_SplitScreen_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D966 RID: 121190 RVA: 0x008FC3CF File Offset: 0x008FA5CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitScreen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen.BP_SplitScreen_C");
			}
			return BP_SplitScreen_C._ClassPtr;
		}

		// Token: 0x0601D967 RID: 121191 RVA: 0x008FC3F4 File Offset: 0x008FA5F4
		public BP_SplitScreen_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D968 RID: 121192 RVA: 0x008FC41C File Offset: 0x008FA61C
		[NullableContext(1)]
		public BP_SplitScreen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0601D969 RID: 121193 RVA: 0x008FC44F File Offset: 0x008FA64F
		// (set) Token: 0x0601D96A RID: 121194 RVA: 0x008FC463 File Offset: 0x008FA663
		public unsafe UPointLightComponent PointLight3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_PointLight3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_PointLight3, value);
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0601D96B RID: 121195 RVA: 0x008FC478 File Offset: 0x008FA678
		// (set) Token: 0x0601D96C RID: 121196 RVA: 0x008FC48C File Offset: 0x008FA68C
		public unsafe UPointLightComponent PointLight2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_PointLight2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_PointLight2, value);
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0601D96D RID: 121197 RVA: 0x008FC4A1 File Offset: 0x008FA6A1
		// (set) Token: 0x0601D96E RID: 121198 RVA: 0x008FC4B5 File Offset: 0x008FA6B5
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_PointLight1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_PointLight1, value);
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0601D96F RID: 121199 RVA: 0x008FC4CA File Offset: 0x008FA6CA
		// (set) Token: 0x0601D970 RID: 121200 RVA: 0x008FC4DE File Offset: 0x008FA6DE
		public unsafe UChildActorComponent CharacterActor_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_CharacterActor_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_CharacterActor_3, value);
			}
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x0601D971 RID: 121201 RVA: 0x008FC4F3 File Offset: 0x008FA6F3
		// (set) Token: 0x0601D972 RID: 121202 RVA: 0x008FC507 File Offset: 0x008FA707
		public unsafe UChildActorComponent CharacterActor_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_CharacterActor_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_CharacterActor_2, value);
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0601D973 RID: 121203 RVA: 0x008FC51C File Offset: 0x008FA71C
		// (set) Token: 0x0601D974 RID: 121204 RVA: 0x008FC530 File Offset: 0x008FA730
		public unsafe UChildActorComponent CharacterActor_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_CharacterActor_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_CharacterActor_1, value);
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0601D975 RID: 121205 RVA: 0x008FC545 File Offset: 0x008FA745
		// (set) Token: 0x0601D976 RID: 121206 RVA: 0x008FC559 File Offset: 0x008FA759
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0601D977 RID: 121207 RVA: 0x008FC56E File Offset: 0x008FA76E
		// (set) Token: 0x0601D978 RID: 121208 RVA: 0x008FC582 File Offset: 0x008FA782
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_MPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_MPC, value);
			}
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0601D979 RID: 121209 RVA: 0x008FC597 File Offset: 0x008FA797
		// (set) Token: 0x0601D97A RID: 121210 RVA: 0x008FC5AB File Offset: 0x008FA7AB
		public unsafe FName Angle_LinePosition__LineDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Angle_LinePosition__LineDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Angle_LinePosition__LineDistance) = value;
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0601D97B RID: 121211 RVA: 0x008FC5C0 File Offset: 0x008FA7C0
		// (set) Token: 0x0601D97C RID: 121212 RVA: 0x008FC5D0 File Offset: 0x008FA7D0
		public unsafe float E_LinkPos_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_E_LinkPos_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_E_LinkPos_1) = value;
			}
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0601D97D RID: 121213 RVA: 0x008FC5E1 File Offset: 0x008FA7E1
		// (set) Token: 0x0601D97E RID: 121214 RVA: 0x008FC5F1 File Offset: 0x008FA7F1
		public unsafe float E_LinkPos_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_E_LinkPos_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_E_LinkPos_2) = value;
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0601D97F RID: 121215 RVA: 0x008FC602 File Offset: 0x008FA802
		// (set) Token: 0x0601D980 RID: 121216 RVA: 0x008FC612 File Offset: 0x008FA812
		public unsafe float E_LinkPos_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_E_LinkPos_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_E_LinkPos_3) = value;
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0601D981 RID: 121217 RVA: 0x008FC623 File Offset: 0x008FA823
		// (set) Token: 0x0601D982 RID: 121218 RVA: 0x008FC637 File Offset: 0x008FA837
		public unsafe FVector PointLight1_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight1_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight1_Location) = value;
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0601D983 RID: 121219 RVA: 0x008FC64C File Offset: 0x008FA84C
		// (set) Token: 0x0601D984 RID: 121220 RVA: 0x008FC660 File Offset: 0x008FA860
		public unsafe FVector PointLight2_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight2_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight2_Location) = value;
			}
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x0601D985 RID: 121221 RVA: 0x008FC675 File Offset: 0x008FA875
		// (set) Token: 0x0601D986 RID: 121222 RVA: 0x008FC689 File Offset: 0x008FA889
		public unsafe FVector PointLight3_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight3_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight3_Location) = value;
			}
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0601D987 RID: 121223 RVA: 0x008FC69E File Offset: 0x008FA89E
		// (set) Token: 0x0601D988 RID: 121224 RVA: 0x008FC6B2 File Offset: 0x008FA8B2
		public unsafe FLinearColor PointLight1_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight1_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight1_ToonLightColor) = value;
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x0601D989 RID: 121225 RVA: 0x008FC6C7 File Offset: 0x008FA8C7
		// (set) Token: 0x0601D98A RID: 121226 RVA: 0x008FC6DB File Offset: 0x008FA8DB
		public unsafe FLinearColor PointLight2_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight2_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight2_ToonLightColor) = value;
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x0601D98B RID: 121227 RVA: 0x008FC6F0 File Offset: 0x008FA8F0
		// (set) Token: 0x0601D98C RID: 121228 RVA: 0x008FC704 File Offset: 0x008FA904
		public unsafe FLinearColor PointLight3_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight3_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_PointLight3_ToonLightColor) = value;
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x0601D98D RID: 121229 RVA: 0x008FC719 File Offset: 0x008FA919
		// (set) Token: 0x0601D98E RID: 121230 RVA: 0x008FC72D File Offset: 0x008FA92D
		public unsafe FLinearColor EyeLightSimulation_TongKong1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_TongKong1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_TongKong1) = value;
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0601D98F RID: 121231 RVA: 0x008FC742 File Offset: 0x008FA942
		// (set) Token: 0x0601D990 RID: 121232 RVA: 0x008FC756 File Offset: 0x008FA956
		public unsafe FLinearColor EyeLightSimulation_TongKong2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_TongKong2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_TongKong2) = value;
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0601D991 RID: 121233 RVA: 0x008FC76B File Offset: 0x008FA96B
		// (set) Token: 0x0601D992 RID: 121234 RVA: 0x008FC77F File Offset: 0x008FA97F
		public unsafe FLinearColor EyeLightSimulation_TongKong3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_TongKong3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_TongKong3) = value;
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0601D993 RID: 121235 RVA: 0x008FC794 File Offset: 0x008FA994
		// (set) Token: 0x0601D994 RID: 121236 RVA: 0x008FC7A8 File Offset: 0x008FA9A8
		public unsafe FLinearColor EyeLightSimulation_YanBai1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_YanBai1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_YanBai1) = value;
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0601D995 RID: 121237 RVA: 0x008FC7BD File Offset: 0x008FA9BD
		// (set) Token: 0x0601D996 RID: 121238 RVA: 0x008FC7D1 File Offset: 0x008FA9D1
		public unsafe FLinearColor EyeLightSimulation_YanBai2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_YanBai2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_YanBai2) = value;
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0601D997 RID: 121239 RVA: 0x008FC7E6 File Offset: 0x008FA9E6
		// (set) Token: 0x0601D998 RID: 121240 RVA: 0x008FC7FA File Offset: 0x008FA9FA
		public unsafe FLinearColor EyeLightSimulation_YanBai3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_YanBai3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_YanBai3) = value;
			}
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0601D999 RID: 121241 RVA: 0x008FC80F File Offset: 0x008FAA0F
		// (set) Token: 0x0601D99A RID: 121242 RVA: 0x008FC823 File Offset: 0x008FAA23
		public unsafe FLinearColor EyeLightSimulation_Color1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_Color1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_Color1) = value;
			}
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0601D99B RID: 121243 RVA: 0x008FC838 File Offset: 0x008FAA38
		// (set) Token: 0x0601D99C RID: 121244 RVA: 0x008FC84C File Offset: 0x008FAA4C
		public unsafe FLinearColor EyeLightSimulation_Color2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_Color2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_Color2) = value;
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x0601D99D RID: 121245 RVA: 0x008FC861 File Offset: 0x008FAA61
		// (set) Token: 0x0601D99E RID: 121246 RVA: 0x008FC875 File Offset: 0x008FAA75
		public unsafe FLinearColor EyeLightSimulation_Color3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_Color3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_EyeLightSimulation_Color3) = value;
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x0601D99F RID: 121247 RVA: 0x008FC88A File Offset: 0x008FAA8A
		// (set) Token: 0x0601D9A0 RID: 121248 RVA: 0x008FC89A File Offset: 0x008FAA9A
		public unsafe byte MeshPart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_MeshPart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_MeshPart) = value;
			}
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0601D9A1 RID: 121249 RVA: 0x008FC8AB File Offset: 0x008FAAAB
		// (set) Token: 0x0601D9A2 RID: 121250 RVA: 0x008FC8BB File Offset: 0x008FAABB
		public unsafe int Handle1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Handle1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Handle1) = value;
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0601D9A3 RID: 121251 RVA: 0x008FC8CC File Offset: 0x008FAACC
		// (set) Token: 0x0601D9A4 RID: 121252 RVA: 0x008FC8DC File Offset: 0x008FAADC
		public unsafe int Handle2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Handle2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Handle2) = value;
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0601D9A5 RID: 121253 RVA: 0x008FC8ED File Offset: 0x008FAAED
		// (set) Token: 0x0601D9A6 RID: 121254 RVA: 0x008FC8FD File Offset: 0x008FAAFD
		public unsafe int Handle3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Handle3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_C.__PropertyOffset_Handle3) = value;
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0601D9A7 RID: 121255 RVA: 0x008FC90E File Offset: 0x008FAB0E
		// (set) Token: 0x0601D9A8 RID: 121256 RVA: 0x008FC922 File Offset: 0x008FAB22
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_KuroMaterialControllerComponent1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_KuroMaterialControllerComponent1, value);
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x0601D9A9 RID: 121257 RVA: 0x008FC937 File Offset: 0x008FAB37
		// (set) Token: 0x0601D9AA RID: 121258 RVA: 0x008FC94B File Offset: 0x008FAB4B
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_KuroMaterialControllerComponent2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_KuroMaterialControllerComponent2, value);
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x0601D9AB RID: 121259 RVA: 0x008FC960 File Offset: 0x008FAB60
		// (set) Token: 0x0601D9AC RID: 121260 RVA: 0x008FC974 File Offset: 0x008FAB74
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_KuroMaterialControllerComponent3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_C.__PropertyOffset_KuroMaterialControllerComponent3, value);
			}
		}

		// Token: 0x0601D9AD RID: 121261 RVA: 0x008FC989 File Offset: 0x008FAB89
		[SkipLocalsInit]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601D9AE RID: 121262 RVA: 0x008FC9A0 File Offset: 0x008FABA0
		[SkipLocalsInit]
		public unsafe virtual void InitKuroMaterialController(UKuroMaterialControllerComponent KuroMaterialControllerComponent, UChildActorComponent CharacterActorComponent, UPointLightComponent PointLightComponent, FVector PointLight_Location, FLinearColor PointLight_ToonLightColor, FLinearColor EyeLightSimulation_TongKong, FLinearColor EyeLightSimulation_YanBai, FLinearColor EyeLightSimulation_Color, float E_LinkPos, bool Channel0, bool Channel1, bool Channel2, ref int returnHandle)
		{
			BP_SplitScreen_C.__InitKuroMaterialController_FunctionParams* ptr = stackalloc BP_SplitScreen_C.__InitKuroMaterialController_FunctionParams[(UIntPtr)335] + 15L / (long)sizeof(BP_SplitScreen_C.__InitKuroMaterialController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->KuroMaterialControllerComponent = ((KuroMaterialControllerComponent != null) ? KuroMaterialControllerComponent.NativePtr : IntPtr.Zero);
			ptr->CharacterActorComponent = ((CharacterActorComponent != null) ? CharacterActorComponent.NativePtr : IntPtr.Zero);
			ptr->PointLightComponent = ((PointLightComponent != null) ? PointLightComponent.NativePtr : IntPtr.Zero);
			ptr->PointLight_Location = PointLight_Location;
			ptr->PointLight_ToonLightColor = PointLight_ToonLightColor;
			ptr->EyeLightSimulation_TongKong = EyeLightSimulation_TongKong;
			ptr->EyeLightSimulation_YanBai = EyeLightSimulation_YanBai;
			ptr->EyeLightSimulation_Color = EyeLightSimulation_Color;
			ptr->E_LinkPos = E_LinkPos;
			ptr->Channel0 = Channel0;
			ptr->Channel1 = Channel1;
			ptr->Channel2 = Channel2;
			ptr->returnHandle = returnHandle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr);
			returnHandle = ptr->returnHandle;
		}

		// Token: 0x0601D9AF RID: 121263 RVA: 0x008FCA7E File Offset: 0x008FAC7E
		[SkipLocalsInit]
		public virtual void End()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__End_NativeFunctionPtr, null);
		}

		// Token: 0x0601D9B0 RID: 121264 RVA: 0x008FCA92 File Offset: 0x008FAC92
		[SkipLocalsInit]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601D9B1 RID: 121265 RVA: 0x008FCAA6 File Offset: 0x008FACA6
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D9B2 RID: 121266 RVA: 0x008FCABA File Offset: 0x008FACBA
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601D9B3 RID: 121267 RVA: 0x008FCAD0 File Offset: 0x008FACD0
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplitScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D9B4 RID: 121268 RVA: 0x008FCB18 File Offset: 0x008FAD18
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplitScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D9B5 RID: 121269 RVA: 0x008FCB5E File Offset: 0x008FAD5E
		protected BP_SplitScreen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F981 RID: 63873
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen.BP_SplitScreen_C";

		// Token: 0x0400F982 RID: 63874
		private static IntPtr _ClassPtr;

		// Token: 0x0400F983 RID: 63875
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F984 RID: 63876
		internal static int __PropertyOffset_PointLight3;

		// Token: 0x0400F985 RID: 63877
		internal static int __PropertyOffset_PointLight2;

		// Token: 0x0400F986 RID: 63878
		internal static int __PropertyOffset_PointLight1;

		// Token: 0x0400F987 RID: 63879
		internal static int __PropertyOffset_CharacterActor_3;

		// Token: 0x0400F988 RID: 63880
		internal static int __PropertyOffset_CharacterActor_2;

		// Token: 0x0400F989 RID: 63881
		internal static int __PropertyOffset_CharacterActor_1;

		// Token: 0x0400F98A RID: 63882
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F98B RID: 63883
		internal static int __PropertyOffset_MPC;

		// Token: 0x0400F98C RID: 63884
		internal static int __PropertyOffset_Angle_LinePosition__LineDistance;

		// Token: 0x0400F98D RID: 63885
		internal static int __PropertyOffset_E_LinkPos_1;

		// Token: 0x0400F98E RID: 63886
		internal static int __PropertyOffset_E_LinkPos_2;

		// Token: 0x0400F98F RID: 63887
		internal static int __PropertyOffset_E_LinkPos_3;

		// Token: 0x0400F990 RID: 63888
		internal static int __PropertyOffset_PointLight1_Location;

		// Token: 0x0400F991 RID: 63889
		internal static int __PropertyOffset_PointLight2_Location;

		// Token: 0x0400F992 RID: 63890
		internal static int __PropertyOffset_PointLight3_Location;

		// Token: 0x0400F993 RID: 63891
		internal static int __PropertyOffset_PointLight1_ToonLightColor;

		// Token: 0x0400F994 RID: 63892
		internal static int __PropertyOffset_PointLight2_ToonLightColor;

		// Token: 0x0400F995 RID: 63893
		internal static int __PropertyOffset_PointLight3_ToonLightColor;

		// Token: 0x0400F996 RID: 63894
		internal static int __PropertyOffset_EyeLightSimulation_TongKong1;

		// Token: 0x0400F997 RID: 63895
		internal static int __PropertyOffset_EyeLightSimulation_TongKong2;

		// Token: 0x0400F998 RID: 63896
		internal static int __PropertyOffset_EyeLightSimulation_TongKong3;

		// Token: 0x0400F999 RID: 63897
		internal static int __PropertyOffset_EyeLightSimulation_YanBai1;

		// Token: 0x0400F99A RID: 63898
		internal static int __PropertyOffset_EyeLightSimulation_YanBai2;

		// Token: 0x0400F99B RID: 63899
		internal static int __PropertyOffset_EyeLightSimulation_YanBai3;

		// Token: 0x0400F99C RID: 63900
		internal static int __PropertyOffset_EyeLightSimulation_Color1;

		// Token: 0x0400F99D RID: 63901
		internal static int __PropertyOffset_EyeLightSimulation_Color2;

		// Token: 0x0400F99E RID: 63902
		internal static int __PropertyOffset_EyeLightSimulation_Color3;

		// Token: 0x0400F99F RID: 63903
		internal static int __PropertyOffset_MeshPart;

		// Token: 0x0400F9A0 RID: 63904
		internal static int __PropertyOffset_Handle1;

		// Token: 0x0400F9A1 RID: 63905
		internal static int __PropertyOffset_Handle2;

		// Token: 0x0400F9A2 RID: 63906
		internal static int __PropertyOffset_Handle3;

		// Token: 0x0400F9A3 RID: 63907
		internal static int __PropertyOffset_KuroMaterialControllerComponent1;

		// Token: 0x0400F9A4 RID: 63908
		internal static int __PropertyOffset_KuroMaterialControllerComponent2;

		// Token: 0x0400F9A5 RID: 63909
		internal static int __PropertyOffset_KuroMaterialControllerComponent3;

		// Token: 0x0400F9A6 RID: 63910
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0400F9A7 RID: 63911
		private static IntPtr __InitKuroMaterialController_NativeFunctionPtr;

		// Token: 0x0400F9A8 RID: 63912
		private static IntPtr __End_NativeFunctionPtr;

		// Token: 0x0400F9A9 RID: 63913
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400F9AA RID: 63914
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F9AB RID: 63915
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008D67 RID: 36199
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __InitKuroMaterialController_FunctionParams
		{
			// Token: 0x0402C8F4 RID: 182516
			[FieldOffset(0)]
			public IntPtr KuroMaterialControllerComponent;

			// Token: 0x0402C8F5 RID: 182517
			[FieldOffset(8)]
			public IntPtr CharacterActorComponent;

			// Token: 0x0402C8F6 RID: 182518
			[FieldOffset(16)]
			public IntPtr PointLightComponent;

			// Token: 0x0402C8F7 RID: 182519
			[FieldOffset(24)]
			public FVector PointLight_Location;

			// Token: 0x0402C8F8 RID: 182520
			[FieldOffset(36)]
			public FLinearColor PointLight_ToonLightColor;

			// Token: 0x0402C8F9 RID: 182521
			[FieldOffset(52)]
			public FLinearColor EyeLightSimulation_TongKong;

			// Token: 0x0402C8FA RID: 182522
			[FieldOffset(68)]
			public FLinearColor EyeLightSimulation_YanBai;

			// Token: 0x0402C8FB RID: 182523
			[FieldOffset(84)]
			public FLinearColor EyeLightSimulation_Color;

			// Token: 0x0402C8FC RID: 182524
			[FieldOffset(100)]
			public float E_LinkPos;

			// Token: 0x0402C8FD RID: 182525
			[FieldOffset(104)]
			public bool Channel0;

			// Token: 0x0402C8FE RID: 182526
			[FieldOffset(105)]
			public bool Channel1;

			// Token: 0x0402C8FF RID: 182527
			[FieldOffset(106)]
			public bool Channel2;

			// Token: 0x0402C900 RID: 182528
			[FieldOffset(108)]
			public int returnHandle;
		}

		// Token: 0x02008D68 RID: 36200
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C901 RID: 182529
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
