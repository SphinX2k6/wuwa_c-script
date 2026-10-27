using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools.Data.Struct
{
	// Token: 0x0200434A RID: 17226
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBaseAnimPathConfig.SBaseAnimPathConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SBaseAnimPathConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CABA RID: 182970 RVA: 0x00A25610 File Offset: 0x00A23810
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBaseAnimPathConfig._ScriptStructPtr != 0) ? SBaseAnimPathConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBaseAnimPathConfig.SBaseAnimPathConfig", ref SBaseAnimPathConfig._ScriptStructPtr);
		}

		// Token: 0x17007067 RID: 28775
		// (get) Token: 0x0602CABB RID: 182971 RVA: 0x00A25634 File Offset: 0x00A23834
		// (set) Token: 0x0602CABC RID: 182972 RVA: 0x00A25648 File Offset: 0x00A23848
		public unsafe string RoleABPPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBaseAnimPathConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBaseAnimPathConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17007068 RID: 28776
		// (get) Token: 0x0602CABD RID: 182973 RVA: 0x00A25660 File Offset: 0x00A23860
		// (set) Token: 0x0602CABE RID: 182974 RVA: 0x00A256A3 File Offset: 0x00A238A3
		public TArray<string> BaseAnimPath
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BaseAnimPath) == null)
				{
					result = (this._BaseAnimPath = new TArray<string>(base.NativePtr + (IntPtr)SBaseAnimPathConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BaseAnimPath.CopyAssign(value);
			}
		}

		// Token: 0x0602CABF RID: 182975 RVA: 0x00A256B1 File Offset: 0x00A238B1
		public SBaseAnimPathConfig()
		{
		}

		// Token: 0x0602CAC0 RID: 182976 RVA: 0x00A256B9 File Offset: 0x00A238B9
		public SBaseAnimPathConfig(string RoleABPPath, TArray<string> BaseAnimPath)
		{
			this.RoleABPPath = RoleABPPath;
			this.BaseAnimPath = BaseAnimPath;
		}

		// Token: 0x0602CAC1 RID: 182977 RVA: 0x00A256CF File Offset: 0x00A238CF
		protected override IntPtr GetUStructPtr()
		{
			return SBaseAnimPathConfig.StaticStruct();
		}

		// Token: 0x0602CAC2 RID: 182978 RVA: 0x00A256DB File Offset: 0x00A238DB
		[NullableContext(2)]
		public SBaseAnimPathConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CAC3 RID: 182979 RVA: 0x00A256E5 File Offset: 0x00A238E5
		public SBaseAnimPathConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CAC4 RID: 182980 RVA: 0x00A256F0 File Offset: 0x00A238F0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBaseAnimPathConfig(Pointer, false, true);
		}

		// Token: 0x0602CAC5 RID: 182981 RVA: 0x00A256FA File Offset: 0x00A238FA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBaseAnimPathConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040178C9 RID: 96457
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBaseAnimPathConfig.SBaseAnimPathConfig";

		// Token: 0x040178CA RID: 96458
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040178CB RID: 96459
		internal static int __PropertyOffset_0;

		// Token: 0x040178CC RID: 96460
		internal static int __PropertyOffset_1;

		// Token: 0x040178CD RID: 96461
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BaseAnimPath;
	}
}
