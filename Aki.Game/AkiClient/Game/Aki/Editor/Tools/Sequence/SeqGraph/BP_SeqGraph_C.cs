using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Editor.Tools.Sequence.SeqGraph
{
	// Token: 0x0200315A RID: 12634
	[UnrealObjectPath("/Game/Aki/Editor/Tools/Sequence/SeqGraph/BP_SeqGraph.BP_SeqGraph_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SeqGraph_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F1D9 RID: 127449 RVA: 0x00926A37 File Offset: 0x00924C37
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqGraph_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Editor/Tools/Sequence/SeqGraph/BP_SeqGraph.BP_SeqGraph_C");
			}
			return BP_SeqGraph_C._ClassPtr;
		}

		// Token: 0x0601F1DA RID: 127450 RVA: 0x00926A5C File Offset: 0x00924C5C
		public BP_SeqGraph_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqGraph_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F1DB RID: 127451 RVA: 0x00926A84 File Offset: 0x00924C84
		[NullableContext(1)]
		public BP_SeqGraph_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqGraph_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F1DC RID: 127452 RVA: 0x00926AB7 File Offset: 0x00924CB7
		protected BP_SeqGraph_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A02 RID: 68098
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Editor/Tools/Sequence/SeqGraph/BP_SeqGraph.BP_SeqGraph_C";

		// Token: 0x04010A03 RID: 68099
		private static IntPtr _ClassPtr;

		// Token: 0x04010A04 RID: 68100
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
