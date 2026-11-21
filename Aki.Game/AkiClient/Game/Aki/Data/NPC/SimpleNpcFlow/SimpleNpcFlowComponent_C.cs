using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x020031B1 RID: 12721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowComponent.SimpleNpcFlowComponent_C")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class SimpleNpcFlowComponent_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F688 RID: 128648 RVA: 0x0092D215 File Offset: 0x0092B415
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SimpleNpcFlowComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowComponent.SimpleNpcFlowComponent_C");
			}
			return SimpleNpcFlowComponent_C._ClassPtr;
		}

		// Token: 0x0601F689 RID: 128649 RVA: 0x0092D23C File Offset: 0x0092B43C
		public SimpleNpcFlowComponent_C() : this(BuiltinUtils.AllocNativeUObject(SimpleNpcFlowComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F68A RID: 128650 RVA: 0x0092D264 File Offset: 0x0092B464
		public SimpleNpcFlowComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SimpleNpcFlowComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0601F68B RID: 128651 RVA: 0x0092D298 File Offset: 0x0092B498
		// (set) Token: 0x0601F68C RID: 128652 RVA: 0x0092D2D1 File Offset: 0x0092B4D1
		public TArray<TsSimpleNpc> NpcList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TsSimpleNpc> result;
				if ((result = this._NpcList) == null)
				{
					result = (this._NpcList = new TArray<TsSimpleNpc>(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_NpcList, this));
				}
				return result;
			}
			set
			{
				this.NpcList.CopyAssign(value);
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0601F68D RID: 128653 RVA: 0x0092D2E0 File Offset: 0x0092B4E0
		// (set) Token: 0x0601F68E RID: 128654 RVA: 0x0092D319 File Offset: 0x0092B519
		public TArray<SimpleNpcFlowData> FlowList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SimpleNpcFlowData> result;
				if ((result = this._FlowList) == null)
				{
					result = (this._FlowList = new TArray<SimpleNpcFlowData>(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_FlowList, this));
				}
				return result;
			}
			set
			{
				this.FlowList.CopyAssign(value);
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0601F68F RID: 128655 RVA: 0x0092D327 File Offset: 0x0092B527
		// (set) Token: 0x0601F690 RID: 128656 RVA: 0x0092D33B File Offset: 0x0092B53B
		public unsafe FFloatRange CheckRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_CheckRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowComponent_C.__PropertyOffset_CheckRange) = value;
			}
		}

		// Token: 0x0601F691 RID: 128657 RVA: 0x0092D350 File Offset: 0x0092B550
		protected SimpleNpcFlowComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D7C RID: 68988
		public new const string __ObjectPath = "/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowComponent.SimpleNpcFlowComponent_C";

		// Token: 0x04010D7D RID: 68989
		private static IntPtr _ClassPtr;

		// Token: 0x04010D7E RID: 68990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D7F RID: 68991
		internal static int __PropertyOffset_NpcList;

		// Token: 0x04010D80 RID: 68992
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<TsSimpleNpc> _NpcList;

		// Token: 0x04010D81 RID: 68993
		internal static int __PropertyOffset_FlowList;

		// Token: 0x04010D82 RID: 68994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SimpleNpcFlowData> _FlowList;

		// Token: 0x04010D83 RID: 68995
		internal static int __PropertyOffset_CheckRange;
	}
}
