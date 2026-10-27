using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FDD RID: 16349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_UiActorCallBack_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029E0A RID: 171530 RVA: 0x009CEAC4 File Offset: 0x009CCCC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UiActorCallBack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C");
			}
			return BP_UiActorCallBack_C._ClassPtr;
		}

		// Token: 0x06029E0B RID: 171531 RVA: 0x009CEAE8 File Offset: 0x009CCCE8
		public BP_UiActorCallBack_C() : this(BuiltinUtils.AllocNativeUObject(BP_UiActorCallBack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029E0C RID: 171532 RVA: 0x009CEB10 File Offset: 0x009CCD10
		public BP_UiActorCallBack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UiActorCallBack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170065AA RID: 26026
		// (get) Token: 0x06029E0D RID: 171533 RVA: 0x009CEB43 File Offset: 0x009CCD43
		// (set) Token: 0x06029E0E RID: 171534 RVA: 0x009CEB57 File Offset: 0x009CCD57
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiActorCallBack_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiActorCallBack_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170065AB RID: 26027
		// (get) Token: 0x06029E0F RID: 171535 RVA: 0x009CEB6C File Offset: 0x009CCD6C
		// (set) Token: 0x06029E10 RID: 171536 RVA: 0x009CEBA5 File Offset: 0x009CCDA5
		public UiAnimNotifyStateEffectPlay UiAnimNotifyStateEffectPlay
		{
			get
			{
				base.FastCheckIsValid();
				UiAnimNotifyStateEffectPlay result;
				if ((result = this._UiAnimNotifyStateEffectPlay) == null)
				{
					result = (this._UiAnimNotifyStateEffectPlay = new UiAnimNotifyStateEffectPlay(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_1, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170065AC RID: 26028
		// (get) Token: 0x06029E11 RID: 171537 RVA: 0x009CEBC8 File Offset: 0x009CCDC8
		// (set) Token: 0x06029E12 RID: 171538 RVA: 0x009CEC01 File Offset: 0x009CCE01
		public UiAnimNotifyStateEffectStop UiAnimNotifyStateEffectStop
		{
			get
			{
				base.FastCheckIsValid();
				UiAnimNotifyStateEffectStop result;
				if ((result = this._UiAnimNotifyStateEffectStop) == null)
				{
					result = (this._UiAnimNotifyStateEffectStop = new UiAnimNotifyStateEffectStop(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_2, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170065AD RID: 26029
		// (get) Token: 0x06029E13 RID: 171539 RVA: 0x009CEC24 File Offset: 0x009CCE24
		// (set) Token: 0x06029E14 RID: 171540 RVA: 0x009CEC5D File Offset: 0x009CCE5D
		public UiAnimNotifyEffect UiAnimNotifyEffect
		{
			get
			{
				base.FastCheckIsValid();
				UiAnimNotifyEffect result;
				if ((result = this._UiAnimNotifyEffect) == null)
				{
					result = (this._UiAnimNotifyEffect = new UiAnimNotifyEffect(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_3, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170065AE RID: 26030
		// (get) Token: 0x06029E15 RID: 171541 RVA: 0x009CEC80 File Offset: 0x009CCE80
		// (set) Token: 0x06029E16 RID: 171542 RVA: 0x009CECB9 File Offset: 0x009CCEB9
		public UiAnimNotifyModel UiAnimNotifyModel
		{
			get
			{
				base.FastCheckIsValid();
				UiAnimNotifyModel result;
				if ((result = this._UiAnimNotifyModel) == null)
				{
					result = (this._UiAnimNotifyModel = new UiAnimNotifyModel(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_4, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170065AF RID: 26031
		// (get) Token: 0x06029E17 RID: 171543 RVA: 0x009CECDC File Offset: 0x009CCEDC
		// (set) Token: 0x06029E18 RID: 171544 RVA: 0x009CED15 File Offset: 0x009CCF15
		public UiAnimNotifyEndPoint UiAnimNotifyEndPoint
		{
			get
			{
				base.FastCheckIsValid();
				UiAnimNotifyEndPoint result;
				if ((result = this._UiAnimNotifyEndPoint) == null)
				{
					result = (this._UiAnimNotifyEndPoint = new UiAnimNotifyEndPoint(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_UiActorCallBack_C.__PropertyOffset_5, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06029E19 RID: 171545 RVA: 0x009CED36 File Offset: 0x009CCF36
		protected BP_UiActorCallBack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015823 RID: 88099
		public new const string __ObjectPath = "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C";

		// Token: 0x04015824 RID: 88100
		private static IntPtr _ClassPtr;

		// Token: 0x04015825 RID: 88101
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015826 RID: 88102
		public static IntPtr __UiAnimNotifyEndPoint__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015827 RID: 88103
		public static IntPtr __UiAnimNotifyModel__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015828 RID: 88104
		public static IntPtr __UiAnimNotifyEffect__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015829 RID: 88105
		public static IntPtr __UiAnimNotifyStateEffectStop__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401582A RID: 88106
		public static IntPtr __UiAnimNotifyStateEffectPlay__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401582B RID: 88107
		internal static int __PropertyOffset_0;

		// Token: 0x0401582C RID: 88108
		internal static int __PropertyOffset_1;

		// Token: 0x0401582D RID: 88109
		[Nullable(2)]
		private UiAnimNotifyStateEffectPlay _UiAnimNotifyStateEffectPlay;

		// Token: 0x0401582E RID: 88110
		internal static int __PropertyOffset_2;

		// Token: 0x0401582F RID: 88111
		[Nullable(2)]
		private UiAnimNotifyStateEffectStop _UiAnimNotifyStateEffectStop;

		// Token: 0x04015830 RID: 88112
		internal static int __PropertyOffset_3;

		// Token: 0x04015831 RID: 88113
		[Nullable(2)]
		private UiAnimNotifyEffect _UiAnimNotifyEffect;

		// Token: 0x04015832 RID: 88114
		internal static int __PropertyOffset_4;

		// Token: 0x04015833 RID: 88115
		[Nullable(2)]
		private UiAnimNotifyModel _UiAnimNotifyModel;

		// Token: 0x04015834 RID: 88116
		internal static int __PropertyOffset_5;

		// Token: 0x04015835 RID: 88117
		[Nullable(2)]
		private UiAnimNotifyEndPoint _UiAnimNotifyEndPoint;
	}
}
