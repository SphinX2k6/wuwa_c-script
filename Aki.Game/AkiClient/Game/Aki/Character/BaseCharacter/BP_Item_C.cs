using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200427F RID: 17023
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_Item.BP_Item_C")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class BP_Item_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C317 RID: 181015 RVA: 0x00A19941 File Offset: 0x00A17B41
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Item_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_Item.BP_Item_C");
			}
			return BP_Item_C._ClassPtr;
		}

		// Token: 0x0602C318 RID: 181016 RVA: 0x00A19968 File Offset: 0x00A17B68
		public BP_Item_C() : this(BuiltinUtils.AllocNativeUObject(BP_Item_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C319 RID: 181017 RVA: 0x00A19990 File Offset: 0x00A17B90
		[NullableContext(1)]
		public BP_Item_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Item_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E15 RID: 28181
		// (get) Token: 0x0602C31A RID: 181018 RVA: 0x00A199C3 File Offset: 0x00A17BC3
		// (set) Token: 0x0602C31B RID: 181019 RVA: 0x00A199D3 File Offset: 0x00A17BD3
		public unsafe int 注视优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Item_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Item_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E16 RID: 28182
		// (get) Token: 0x0602C31C RID: 181020 RVA: 0x00A199E4 File Offset: 0x00A17BE4
		// (set) Token: 0x0602C31D RID: 181021 RVA: 0x00A199F8 File Offset: 0x00A17BF8
		public unsafe TEnumAsByte<EEntityType> 实体类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Item_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Item_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E17 RID: 28183
		// (get) Token: 0x0602C31E RID: 181022 RVA: 0x00A19A10 File Offset: 0x00A17C10
		// (set) Token: 0x0602C31F RID: 181023 RVA: 0x00A19A49 File Offset: 0x00A17C49
		[Nullable(1)]
		public TArray<FName> 可被注视的骨骼
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._可被注视的骨骼) == null)
				{
					result = (this._可被注视的骨骼 = new TArray<FName>(base.NativePtr + (IntPtr)BP_Item_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.可被注视的骨骼.CopyAssign(value);
			}
		}

		// Token: 0x0602C320 RID: 181024 RVA: 0x00A19A57 File Offset: 0x00A17C57
		protected BP_Item_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017211 RID: 94737
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_Item.BP_Item_C";

		// Token: 0x04017212 RID: 94738
		private static IntPtr _ClassPtr;

		// Token: 0x04017213 RID: 94739
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017214 RID: 94740
		internal static int __PropertyOffset_0;

		// Token: 0x04017215 RID: 94741
		internal static int __PropertyOffset_1;

		// Token: 0x04017216 RID: 94742
		internal static int __PropertyOffset_2;

		// Token: 0x04017217 RID: 94743
		[Nullable(2)]
		private TArray<FName> _可被注视的骨骼;
	}
}
