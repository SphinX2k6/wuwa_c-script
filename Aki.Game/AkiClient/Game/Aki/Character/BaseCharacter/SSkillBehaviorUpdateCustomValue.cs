using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003369 RID: 13161
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorUpdateCustomValue.SSkillBehaviorUpdateCustomValue")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SSkillBehaviorUpdateCustomValue : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021643 RID: 136771 RVA: 0x0095F880 File Offset: 0x0095DA80
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorUpdateCustomValue._ScriptStructPtr != 0) ? SSkillBehaviorUpdateCustomValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorUpdateCustomValue.SSkillBehaviorUpdateCustomValue", ref SSkillBehaviorUpdateCustomValue._ScriptStructPtr);
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x06021644 RID: 136772 RVA: 0x0095F8A4 File Offset: 0x0095DAA4
		// (set) Token: 0x06021645 RID: 136773 RVA: 0x0095F8E7 File Offset: 0x0095DAE7
		public TArray<string> ValueName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ValueName) == null)
				{
					result = (this._ValueName = new TArray<string>(base.NativePtr + (IntPtr)SSkillBehaviorUpdateCustomValue.__PropertyOffset_ValueName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ValueName.CopyAssign(value);
			}
		}

		// Token: 0x06021646 RID: 136774 RVA: 0x0095F8F5 File Offset: 0x0095DAF5
		public SSkillBehaviorUpdateCustomValue()
		{
		}

		// Token: 0x06021647 RID: 136775 RVA: 0x0095F8FD File Offset: 0x0095DAFD
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorUpdateCustomValue.StaticStruct();
		}

		// Token: 0x06021648 RID: 136776 RVA: 0x0095F909 File Offset: 0x0095DB09
		[NullableContext(2)]
		public SSkillBehaviorUpdateCustomValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021649 RID: 136777 RVA: 0x0095F913 File Offset: 0x0095DB13
		public SSkillBehaviorUpdateCustomValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602164A RID: 136778 RVA: 0x0095F91E File Offset: 0x0095DB1E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorUpdateCustomValue(Pointer, false, true);
		}

		// Token: 0x0602164B RID: 136779 RVA: 0x0095F928 File Offset: 0x0095DB28
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorUpdateCustomValue(Pointer, MemoryOwner);
		}

		// Token: 0x040123FC RID: 74748
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorUpdateCustomValue.SSkillBehaviorUpdateCustomValue";

		// Token: 0x040123FD RID: 74749
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123FE RID: 74750
		internal static int __PropertyOffset_ValueName;

		// Token: 0x040123FF RID: 74751
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ValueName;
	}
}
