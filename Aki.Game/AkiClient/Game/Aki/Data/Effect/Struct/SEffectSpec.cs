using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Effect.Struct
{
	// Token: 0x02003F9A RID: 16282
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Effect/Struct/SEffectSpec.SEffectSpec")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SEffectSpec : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602995B RID: 170331 RVA: 0x009C7F33 File Offset: 0x009C6133
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectSpec._ScriptStructPtr != 0) ? SEffectSpec._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Effect/Struct/SEffectSpec.SEffectSpec", ref SEffectSpec._ScriptStructPtr);
		}

		// Token: 0x17006415 RID: 25621
		// (get) Token: 0x0602995C RID: 170332 RVA: 0x009C7F57 File Offset: 0x009C6157
		// (set) Token: 0x0602995D RID: 170333 RVA: 0x009C7F6B File Offset: 0x009C616B
		public unsafe string Class
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SEffectSpec.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SEffectSpec.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006416 RID: 25622
		// (get) Token: 0x0602995E RID: 170334 RVA: 0x009C7F80 File Offset: 0x009C6180
		// (set) Token: 0x0602995F RID: 170335 RVA: 0x009C7FC3 File Offset: 0x009C61C3
		public TArray<string> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<string>(base.NativePtr + (IntPtr)SEffectSpec.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x06029960 RID: 170336 RVA: 0x009C7FD1 File Offset: 0x009C61D1
		public SEffectSpec()
		{
		}

		// Token: 0x06029961 RID: 170337 RVA: 0x009C7FD9 File Offset: 0x009C61D9
		public SEffectSpec(string Class, TArray<string> Effects)
		{
			this.Class = Class;
			this.Effects = Effects;
		}

		// Token: 0x06029962 RID: 170338 RVA: 0x009C7FEF File Offset: 0x009C61EF
		protected override IntPtr GetUStructPtr()
		{
			return SEffectSpec.StaticStruct();
		}

		// Token: 0x06029963 RID: 170339 RVA: 0x009C7FFB File Offset: 0x009C61FB
		[NullableContext(2)]
		public SEffectSpec(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029964 RID: 170340 RVA: 0x009C8005 File Offset: 0x009C6205
		public SEffectSpec(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029965 RID: 170341 RVA: 0x009C8010 File Offset: 0x009C6210
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEffectSpec(Pointer, false, true);
		}

		// Token: 0x06029966 RID: 170342 RVA: 0x009C801A File Offset: 0x009C621A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEffectSpec(Pointer, MemoryOwner);
		}

		// Token: 0x04015569 RID: 87401
		public const string __ObjectPath = "/Game/Aki/Data/Effect/Struct/SEffectSpec.SEffectSpec";

		// Token: 0x0401556A RID: 87402
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401556B RID: 87403
		internal static int __PropertyOffset_0;

		// Token: 0x0401556C RID: 87404
		internal static int __PropertyOffset_1;

		// Token: 0x0401556D RID: 87405
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Effects;
	}
}
