using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D70 RID: 15728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayPreset.TimeOfDayPreset_C")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 212)]
	public class TimeOfDayPreset_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060269B9 RID: 158137 RVA: 0x009796A0 File Offset: 0x009778A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (TimeOfDayPreset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayPreset.TimeOfDayPreset_C");
			}
			return TimeOfDayPreset_C._ClassPtr;
		}

		// Token: 0x060269BA RID: 158138 RVA: 0x009796C4 File Offset: 0x009778C4
		public TimeOfDayPreset_C() : this(BuiltinUtils.AllocNativeUObject(TimeOfDayPreset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060269BB RID: 158139 RVA: 0x009796EC File Offset: 0x009778EC
		public TimeOfDayPreset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TimeOfDayPreset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005337 RID: 21303
		// (get) Token: 0x060269BC RID: 158140 RVA: 0x00979720 File Offset: 0x00977920
		// (set) Token: 0x060269BD RID: 158141 RVA: 0x00979759 File Offset: 0x00977959
		public TimeOfDayData Data
		{
			get
			{
				base.FastCheckIsValid();
				TimeOfDayData result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TimeOfDayData(base.NativePtr + (IntPtr)TimeOfDayPreset_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(TimeOfDayData.StaticStruct(), base.NativePtr + (IntPtr)TimeOfDayPreset_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060269BE RID: 158142 RVA: 0x0097977A File Offset: 0x0097797A
		protected TimeOfDayPreset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401366E RID: 79470
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/TimeOfDayPreset.TimeOfDayPreset_C";

		// Token: 0x0401366F RID: 79471
		private static IntPtr _ClassPtr;

		// Token: 0x04013670 RID: 79472
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013671 RID: 79473
		internal static int __PropertyOffset_0;

		// Token: 0x04013672 RID: 79474
		[Nullable(2)]
		private TimeOfDayData _Data;
	}
}
