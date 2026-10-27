using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D72 RID: 15730
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WeatherPreset.WeatherPreset_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WeatherPreset_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060269FD RID: 158205 RVA: 0x00979C48 File Offset: 0x00977E48
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WeatherPreset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WeatherPreset.WeatherPreset_C");
			}
			return WeatherPreset_C._ClassPtr;
		}

		// Token: 0x060269FE RID: 158206 RVA: 0x00979C6C File Offset: 0x00977E6C
		public WeatherPreset_C() : this(BuiltinUtils.AllocNativeUObject(WeatherPreset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060269FF RID: 158207 RVA: 0x00979C94 File Offset: 0x00977E94
		public WeatherPreset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WeatherPreset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005353 RID: 21331
		// (get) Token: 0x06026A00 RID: 158208 RVA: 0x00979CC8 File Offset: 0x00977EC8
		// (set) Token: 0x06026A01 RID: 158209 RVA: 0x00979D01 File Offset: 0x00977F01
		public WeatherData Data
		{
			get
			{
				base.FastCheckIsValid();
				WeatherData result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new WeatherData(base.NativePtr + (IntPtr)WeatherPreset_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(WeatherData.StaticStruct(), base.NativePtr + (IntPtr)WeatherPreset_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026A02 RID: 158210 RVA: 0x00979D22 File Offset: 0x00977F22
		protected WeatherPreset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013690 RID: 79504
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WeatherPreset.WeatherPreset_C";

		// Token: 0x04013691 RID: 79505
		private static IntPtr _ClassPtr;

		// Token: 0x04013692 RID: 79506
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013693 RID: 79507
		internal static int __PropertyOffset_0;

		// Token: 0x04013694 RID: 79508
		[Nullable(2)]
		private WeatherData _Data;
	}
}
