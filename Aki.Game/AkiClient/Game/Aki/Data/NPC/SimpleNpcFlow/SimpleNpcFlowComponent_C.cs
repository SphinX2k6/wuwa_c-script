using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x02003EF0 RID: 16112
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowComponent.SimpleNpcFlowComponent_C")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class SimpleNpcFlowComponent_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028CB6 RID: 167094 RVA: 0x009B4CE0 File Offset: 0x009B2EE0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SimpleNpcFlowComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowComponent.SimpleNpcFlowComponent_C");
			}
			return SimpleNpcFlowComponent_C._ClassPtr;
		}

		// Token: 0x06028CB7 RID: 167095 RVA: 0x009B4D04 File Offset: 0x009B2F04
		public SimpleNpcFlowComponent_C() : this(BuiltinUtils.AllocNativeUObject(SimpleNpcFlowComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028CB8 RID: 167096 RVA: 0x009B4D2C File Offset: 0x009B2F2C
		public SimpleNpcFlowComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SimpleNpcFlowComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FA3 RID: 24483
		// (get) Token: 0x06028CB9 RID: 167097 RVA: 0x009B4D60 File Offset: 0x009B2F60
		// (set) Token: 0x06028CBA RID: 167098 RVA: 0x009B4D99 File Offset: 0x009B2F99
		public TArray<TsSimpleNpc> NpcList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TsSimpleNpc> result;
				if ((result = this._NpcList) == null)
				{
					result = (this._NpcList = new TArray<TsSimpleNpc>(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.NpcList.CopyAssign(value);
			}
		}

		// Token: 0x17005FA4 RID: 24484
		// (get) Token: 0x06028CBB RID: 167099 RVA: 0x009B4DA8 File Offset: 0x009B2FA8
		// (set) Token: 0x06028CBC RID: 167100 RVA: 0x009B4DE1 File Offset: 0x009B2FE1
		public TArray<SimpleNpcFlowData> FlowList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SimpleNpcFlowData> result;
				if ((result = this._FlowList) == null)
				{
					result = (this._FlowList = new TArray<SimpleNpcFlowData>(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.FlowList.CopyAssign(value);
			}
		}

		// Token: 0x17005FA5 RID: 24485
		// (get) Token: 0x06028CBD RID: 167101 RVA: 0x009B4DEF File Offset: 0x009B2FEF
		// (set) Token: 0x06028CBE RID: 167102 RVA: 0x009B4E03 File Offset: 0x009B3003
		public unsafe FFloatRange CheckRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06028CBF RID: 167103 RVA: 0x009B4E18 File Offset: 0x009B3018
		protected SimpleNpcFlowComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014DC3 RID: 85443
		public new const string __ObjectPath = "/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowComponent.SimpleNpcFlowComponent_C";

		// Token: 0x04014DC4 RID: 85444
		private static IntPtr _ClassPtr;

		// Token: 0x04014DC5 RID: 85445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014DC6 RID: 85446
		internal static int __PropertyOffset_0;

		// Token: 0x04014DC7 RID: 85447
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<TsSimpleNpc> _NpcList;

		// Token: 0x04014DC8 RID: 85448
		internal static int __PropertyOffset_1;

		// Token: 0x04014DC9 RID: 85449
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SimpleNpcFlowData> _FlowList;

		// Token: 0x04014DCA RID: 85450
		internal static int __PropertyOffset_2;
	}
}
