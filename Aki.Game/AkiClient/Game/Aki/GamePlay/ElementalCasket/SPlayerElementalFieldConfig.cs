using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.ElementalCasket
{
	// Token: 0x02003E69 RID: 15977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalFieldConfig.SPlayerElementalFieldConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SPlayerElementalFieldConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028319 RID: 164633 RVA: 0x009A64D4 File Offset: 0x009A46D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPlayerElementalFieldConfig._ScriptStructPtr != 0) ? SPlayerElementalFieldConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalFieldConfig.SPlayerElementalFieldConfig", ref SPlayerElementalFieldConfig._ScriptStructPtr);
		}

		// Token: 0x17005C3F RID: 23615
		// (get) Token: 0x0602831A RID: 164634 RVA: 0x009A64F8 File Offset: 0x009A46F8
		// (set) Token: 0x0602831B RID: 164635 RVA: 0x009A653B File Offset: 0x009A473B
		public TArray<long> UnopenedGameplayCueList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._UnopenedGameplayCueList) == null)
				{
					result = (this._UnopenedGameplayCueList = new TArray<long>(base.NativePtr + (IntPtr)SPlayerElementalFieldConfig.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UnopenedGameplayCueList.CopyAssign(value);
			}
		}

		// Token: 0x17005C40 RID: 23616
		// (get) Token: 0x0602831C RID: 164636 RVA: 0x009A654C File Offset: 0x009A474C
		// (set) Token: 0x0602831D RID: 164637 RVA: 0x009A658F File Offset: 0x009A478F
		public TArray<long> OpenedFieldGameplayCueList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._OpenedFieldGameplayCueList) == null)
				{
					result = (this._OpenedFieldGameplayCueList = new TArray<long>(base.NativePtr + (IntPtr)SPlayerElementalFieldConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OpenedFieldGameplayCueList.CopyAssign(value);
			}
		}

		// Token: 0x0602831E RID: 164638 RVA: 0x009A659D File Offset: 0x009A479D
		public SPlayerElementalFieldConfig()
		{
		}

		// Token: 0x0602831F RID: 164639 RVA: 0x009A65A5 File Offset: 0x009A47A5
		public SPlayerElementalFieldConfig(TArray<long> UnopenedGameplayCueList, TArray<long> OpenedFieldGameplayCueList)
		{
			this.UnopenedGameplayCueList = UnopenedGameplayCueList;
			this.OpenedFieldGameplayCueList = OpenedFieldGameplayCueList;
		}

		// Token: 0x06028320 RID: 164640 RVA: 0x009A65BB File Offset: 0x009A47BB
		protected override IntPtr GetUStructPtr()
		{
			return SPlayerElementalFieldConfig.StaticStruct();
		}

		// Token: 0x06028321 RID: 164641 RVA: 0x009A65C7 File Offset: 0x009A47C7
		[NullableContext(2)]
		public SPlayerElementalFieldConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028322 RID: 164642 RVA: 0x009A65D1 File Offset: 0x009A47D1
		public SPlayerElementalFieldConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028323 RID: 164643 RVA: 0x009A65DC File Offset: 0x009A47DC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPlayerElementalFieldConfig(Pointer, false, true);
		}

		// Token: 0x06028324 RID: 164644 RVA: 0x009A65E6 File Offset: 0x009A47E6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPlayerElementalFieldConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014762 RID: 83810
		public const string __ObjectPath = "/Game/Aki/GamePlay/ElementalCasket/SPlayerElementalFieldConfig.SPlayerElementalFieldConfig";

		// Token: 0x04014763 RID: 83811
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014764 RID: 83812
		internal static int __PropertyOffset_0;

		// Token: 0x04014765 RID: 83813
		[Nullable(2)]
		private TArray<long> _UnopenedGameplayCueList;

		// Token: 0x04014766 RID: 83814
		internal static int __PropertyOffset_1;

		// Token: 0x04014767 RID: 83815
		[Nullable(2)]
		private TArray<long> _OpenedFieldGameplayCueList;
	}
}
