using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004375 RID: 17269
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateSkillCounter.BP_SM_BindStateSkillCounter_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 89)]
	public class BP_SM_BindStateSkillCounter_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC02 RID: 183298 RVA: 0x00A279E6 File Offset: 0x00A25BE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateSkillCounter_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateSkillCounter.BP_SM_BindStateSkillCounter_C");
			}
			return BP_SM_BindStateSkillCounter_C._ClassPtr;
		}

		// Token: 0x0602CC03 RID: 183299 RVA: 0x00A27A0C File Offset: 0x00A25C0C
		public BP_SM_BindStateSkillCounter_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateSkillCounter_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC04 RID: 183300 RVA: 0x00A27A34 File Offset: 0x00A25C34
		public BP_SM_BindStateSkillCounter_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateSkillCounter_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070AF RID: 28847
		// (get) Token: 0x0602CC05 RID: 183301 RVA: 0x00A27A68 File Offset: 0x00A25C68
		// (set) Token: 0x0602CC06 RID: 183302 RVA: 0x00A27AA1 File Offset: 0x00A25CA1
		public TArray<int> SkillIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SkillIds) == null)
				{
					result = (this._SkillIds = new TArray<int>(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SkillIds.CopyAssign(value);
			}
		}

		// Token: 0x170070B0 RID: 28848
		// (get) Token: 0x0602CC07 RID: 183303 RVA: 0x00A27AAF File Offset: 0x00A25CAF
		// (set) Token: 0x0602CC08 RID: 183304 RVA: 0x00A27AC3 File Offset: 0x00A25CC3
		public unsafe string 黑板Key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x170070B1 RID: 28849
		// (get) Token: 0x0602CC09 RID: 183305 RVA: 0x00A27AD8 File Offset: 0x00A25CD8
		// (set) Token: 0x0602CC0A RID: 183306 RVA: 0x00A27AE8 File Offset: 0x00A25CE8
		public unsafe int 增加值Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170070B2 RID: 28850
		// (get) Token: 0x0602CC0B RID: 183307 RVA: 0x00A27AF9 File Offset: 0x00A25CF9
		// (set) Token: 0x0602CC0C RID: 183308 RVA: 0x00A27B09 File Offset: 0x00A25D09
		public unsafe int 增加值Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170070B3 RID: 28851
		// (get) Token: 0x0602CC0D RID: 183309 RVA: 0x00A27B1A File Offset: 0x00A25D1A
		// (set) Token: 0x0602CC0E RID: 183310 RVA: 0x00A27B2A File Offset: 0x00A25D2A
		public unsafe bool 重置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CC0F RID: 183311 RVA: 0x00A27B3B File Offset: 0x00A25D3B
		protected BP_SM_BindStateSkillCounter_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179A0 RID: 96672
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateSkillCounter.BP_SM_BindStateSkillCounter_C";

		// Token: 0x040179A1 RID: 96673
		private static IntPtr _ClassPtr;

		// Token: 0x040179A2 RID: 96674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179A3 RID: 96675
		internal static int __PropertyOffset_0;

		// Token: 0x040179A4 RID: 96676
		[Nullable(2)]
		private TArray<int> _SkillIds;

		// Token: 0x040179A5 RID: 96677
		internal static int __PropertyOffset_1;

		// Token: 0x040179A6 RID: 96678
		internal static int __PropertyOffset_2;

		// Token: 0x040179A7 RID: 96679
		internal static int __PropertyOffset_3;

		// Token: 0x040179A8 RID: 96680
		internal static int __PropertyOffset_4;
	}
}
