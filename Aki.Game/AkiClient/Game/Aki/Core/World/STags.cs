using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.World
{
	// Token: 0x02003FE7 RID: 16359
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/World/STags.STags")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class STags : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029E5C RID: 171612 RVA: 0x009CFA64 File Offset: 0x009CDC64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (STags._ScriptStructPtr != 0) ? STags._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/World/STags.STags", ref STags._ScriptStructPtr);
		}

		// Token: 0x170065B0 RID: 26032
		// (get) Token: 0x06029E5D RID: 171613 RVA: 0x009CFA88 File Offset: 0x009CDC88
		// (set) Token: 0x06029E5E RID: 171614 RVA: 0x009CFACB File Offset: 0x009CDCCB
		public TArray<string> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<string>(base.NativePtr + (IntPtr)STags.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x170065B1 RID: 26033
		// (get) Token: 0x06029E5F RID: 171615 RVA: 0x009CFADC File Offset: 0x009CDCDC
		// (set) Token: 0x06029E60 RID: 171616 RVA: 0x009CFB1F File Offset: 0x009CDD1F
		public TArray<string> PrivateTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PrivateTags) == null)
				{
					result = (this._PrivateTags = new TArray<string>(base.NativePtr + (IntPtr)STags.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PrivateTags.CopyAssign(value);
			}
		}

		// Token: 0x06029E61 RID: 171617 RVA: 0x009CFB2D File Offset: 0x009CDD2D
		public STags()
		{
		}

		// Token: 0x06029E62 RID: 171618 RVA: 0x009CFB35 File Offset: 0x009CDD35
		public STags(TArray<string> Tags, TArray<string> PrivateTags)
		{
			this.Tags = Tags;
			this.PrivateTags = PrivateTags;
		}

		// Token: 0x06029E63 RID: 171619 RVA: 0x009CFB4B File Offset: 0x009CDD4B
		protected override IntPtr GetUStructPtr()
		{
			return STags.StaticStruct();
		}

		// Token: 0x06029E64 RID: 171620 RVA: 0x009CFB57 File Offset: 0x009CDD57
		[NullableContext(2)]
		public STags(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029E65 RID: 171621 RVA: 0x009CFB61 File Offset: 0x009CDD61
		public STags(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029E66 RID: 171622 RVA: 0x009CFB6C File Offset: 0x009CDD6C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new STags(Pointer, false, true);
		}

		// Token: 0x06029E67 RID: 171623 RVA: 0x009CFB76 File Offset: 0x009CDD76
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new STags(Pointer, MemoryOwner);
		}

		// Token: 0x0401585F RID: 88159
		public const string __ObjectPath = "/Game/Aki/Core/World/STags.STags";

		// Token: 0x04015860 RID: 88160
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015861 RID: 88161
		internal static int __PropertyOffset_0;

		// Token: 0x04015862 RID: 88162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Tags;

		// Token: 0x04015863 RID: 88163
		internal static int __PropertyOffset_1;

		// Token: 0x04015864 RID: 88164
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PrivateTags;
	}
}
