using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Editor.Tools.Sequence.SeqGraph
{
	// Token: 0x02003E83 RID: 16003
	[UnrealObjectPath("/Game/Aki/Editor/Tools/Sequence/SeqGraph/BP_SeqGraph.BP_SeqGraph_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SeqGraph_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028671 RID: 165489 RVA: 0x009AB966 File Offset: 0x009A9B66
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqGraph_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Editor/Tools/Sequence/SeqGraph/BP_SeqGraph.BP_SeqGraph_C");
			}
			return BP_SeqGraph_C._ClassPtr;
		}

		// Token: 0x06028672 RID: 165490 RVA: 0x009AB98C File Offset: 0x009A9B8C
		public BP_SeqGraph_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqGraph_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028673 RID: 165491 RVA: 0x009AB9B4 File Offset: 0x009A9BB4
		[NullableContext(1)]
		public BP_SeqGraph_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqGraph_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06028674 RID: 165492 RVA: 0x009AB9E7 File Offset: 0x009A9BE7
		protected BP_SeqGraph_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014981 RID: 84353
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Editor/Tools/Sequence/SeqGraph/BP_SeqGraph.BP_SeqGraph_C";

		// Token: 0x04014982 RID: 84354
		private static IntPtr _ClassPtr;

		// Token: 0x04014983 RID: 84355
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
