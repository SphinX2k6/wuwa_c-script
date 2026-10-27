using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02004014 RID: 16404
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataLogic.SReBulletDataLogic")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SReBulletDataLogic : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A08B RID: 172171 RVA: 0x009D3DC2 File Offset: 0x009D1FC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataLogic._ScriptStructPtr != 0) ? SReBulletDataLogic._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataLogic.SReBulletDataLogic", ref SReBulletDataLogic._ScriptStructPtr);
		}

		// Token: 0x17006666 RID: 26214
		// (get) Token: 0x0602A08C RID: 172172 RVA: 0x009D3DE6 File Offset: 0x009D1FE6
		// (set) Token: 0x0602A08D RID: 172173 RVA: 0x009D3E05 File Offset: 0x009D2005
		public TSoftObjectPtr<BulletLogicType_C> 预设
		{
			get
			{
				return new TSoftObjectPtr<BulletLogicType_C>(base.NativePtr + (IntPtr)SReBulletDataLogic.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataLogic.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602A08E RID: 172174 RVA: 0x009D3E2A File Offset: 0x009D202A
		public SReBulletDataLogic()
		{
		}

		// Token: 0x0602A08F RID: 172175 RVA: 0x009D3E32 File Offset: 0x009D2032
		public SReBulletDataLogic(TSoftObjectPtr<BulletLogicType_C> 预设)
		{
			this.预设 = 预设;
		}

		// Token: 0x0602A090 RID: 172176 RVA: 0x009D3E41 File Offset: 0x009D2041
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataLogic.StaticStruct();
		}

		// Token: 0x0602A091 RID: 172177 RVA: 0x009D3E4D File Offset: 0x009D204D
		[NullableContext(2)]
		public SReBulletDataLogic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A092 RID: 172178 RVA: 0x009D3E57 File Offset: 0x009D2057
		public SReBulletDataLogic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A093 RID: 172179 RVA: 0x009D3E62 File Offset: 0x009D2062
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataLogic(Pointer, false, true);
		}

		// Token: 0x0602A094 RID: 172180 RVA: 0x009D3E6C File Offset: 0x009D206C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataLogic(Pointer, MemoryOwner);
		}

		// Token: 0x04015A57 RID: 88663
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataLogic.SReBulletDataLogic";

		// Token: 0x04015A58 RID: 88664
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A59 RID: 88665
		internal static int __PropertyOffset_0;
	}
}
