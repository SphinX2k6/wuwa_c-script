using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha
{
	// Token: 0x02003A46 RID: 14918
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/SFightSequenceItemConfig.SFightSequenceItemConfig")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class SFightSequenceItemConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F737 RID: 128823 RVA: 0x008B8AFE File Offset: 0x008B6CFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFightSequenceItemConfig._ScriptStructPtr != 0) ? SFightSequenceItemConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/NewGacha/SFightSequenceItemConfig.SFightSequenceItemConfig", ref SFightSequenceItemConfig._ScriptStructPtr);
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x0601F738 RID: 128824 RVA: 0x008B8B22 File Offset: 0x008B6D22
		// (set) Token: 0x0601F739 RID: 128825 RVA: 0x008B8B36 File Offset: 0x008B6D36
		[Nullable(2)]
		public unsafe UObject Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + SFightSequenceItemConfig.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFightSequenceItemConfig.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x0601F73A RID: 128826 RVA: 0x008B8B4B File Offset: 0x008B6D4B
		// (set) Token: 0x0601F73B RID: 128827 RVA: 0x008B8B5F File Offset: 0x008B6D5F
		public unsafe string SelectName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SFightSequenceItemConfig.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SFightSequenceItemConfig.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x0601F73C RID: 128828 RVA: 0x008B8B74 File Offset: 0x008B6D74
		// (set) Token: 0x0601F73D RID: 128829 RVA: 0x008B8BB7 File Offset: 0x008B6DB7
		public TMap<string, FName> UseComponents_Name__SocketName
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FName> result;
				if ((result = this._UseComponents_Name__SocketName) == null)
				{
					result = (this._UseComponents_Name__SocketName = new TMap<string, FName>(base.NativePtr + (IntPtr)SFightSequenceItemConfig.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UseComponents_Name__SocketName.CopyAssign(value);
			}
		}

		// Token: 0x0601F73E RID: 128830 RVA: 0x008B8BC5 File Offset: 0x008B6DC5
		public SFightSequenceItemConfig()
		{
		}

		// Token: 0x0601F73F RID: 128831 RVA: 0x008B8BCD File Offset: 0x008B6DCD
		public SFightSequenceItemConfig(UObject Sequence, string SelectName, TMap<string, FName> UseComponents_Name__SocketName)
		{
			this.Sequence = Sequence;
			this.SelectName = SelectName;
			this.UseComponents_Name__SocketName = UseComponents_Name__SocketName;
		}

		// Token: 0x0601F740 RID: 128832 RVA: 0x008B8BEA File Offset: 0x008B6DEA
		protected override IntPtr GetUStructPtr()
		{
			return SFightSequenceItemConfig.StaticStruct();
		}

		// Token: 0x0601F741 RID: 128833 RVA: 0x008B8BF6 File Offset: 0x008B6DF6
		[NullableContext(2)]
		public SFightSequenceItemConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F742 RID: 128834 RVA: 0x008B8C00 File Offset: 0x008B6E00
		public SFightSequenceItemConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F743 RID: 128835 RVA: 0x008B8C0B File Offset: 0x008B6E0B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFightSequenceItemConfig(Pointer, false, true);
		}

		// Token: 0x0601F744 RID: 128836 RVA: 0x008B8C15 File Offset: 0x008B6E15
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFightSequenceItemConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400F1B9 RID: 61881
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/SFightSequenceItemConfig.SFightSequenceItemConfig";

		// Token: 0x0400F1BA RID: 61882
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F1BB RID: 61883
		internal static int __PropertyOffset_0;

		// Token: 0x0400F1BC RID: 61884
		internal static int __PropertyOffset_1;

		// Token: 0x0400F1BD RID: 61885
		internal static int __PropertyOffset_2;

		// Token: 0x0400F1BE RID: 61886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FName> _UseComponents_Name__SocketName;
	}
}
