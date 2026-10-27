using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FCF RID: 16335
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/NPCGeneralAction.NPCGeneralAction")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 106)]
	public class NPCGeneralAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029D3B RID: 171323 RVA: 0x009CD58C File Offset: 0x009CB78C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (NPCGeneralAction._ScriptStructPtr != 0) ? NPCGeneralAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/NPCGeneralAction.NPCGeneralAction", ref NPCGeneralAction._ScriptStructPtr);
		}

		// Token: 0x17006570 RID: 25968
		// (get) Token: 0x06029D3C RID: 171324 RVA: 0x009CD5B0 File Offset: 0x009CB7B0
		// (set) Token: 0x06029D3D RID: 171325 RVA: 0x009CD5C0 File Offset: 0x009CB7C0
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCGeneralAction.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCGeneralAction.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006571 RID: 25969
		// (get) Token: 0x06029D3E RID: 171326 RVA: 0x009CD5D1 File Offset: 0x009CB7D1
		// (set) Token: 0x06029D3F RID: 171327 RVA: 0x009CD5E5 File Offset: 0x009CB7E5
		public unsafe string ActionType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCGeneralAction.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCGeneralAction.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006572 RID: 25970
		// (get) Token: 0x06029D40 RID: 171328 RVA: 0x009CD5FC File Offset: 0x009CB7FC
		// (set) Token: 0x06029D41 RID: 171329 RVA: 0x009CD63F File Offset: 0x009CB83F
		public TMap<string, string> LimitParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._LimitParams) == null)
				{
					result = (this._LimitParams = new TMap<string, string>(base.NativePtr + (IntPtr)NPCGeneralAction.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LimitParams.CopyAssign(value);
			}
		}

		// Token: 0x17006573 RID: 25971
		// (get) Token: 0x06029D42 RID: 171330 RVA: 0x009CD64D File Offset: 0x009CB84D
		// (set) Token: 0x06029D43 RID: 171331 RVA: 0x009CD65D File Offset: 0x009CB85D
		public unsafe bool IsClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCGeneralAction.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCGeneralAction.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006574 RID: 25972
		// (get) Token: 0x06029D44 RID: 171332 RVA: 0x009CD66E File Offset: 0x009CB86E
		// (set) Token: 0x06029D45 RID: 171333 RVA: 0x009CD67E File Offset: 0x009CB87E
		public unsafe bool NeedTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCGeneralAction.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCGeneralAction.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06029D46 RID: 171334 RVA: 0x009CD68F File Offset: 0x009CB88F
		public NPCGeneralAction()
		{
		}

		// Token: 0x06029D47 RID: 171335 RVA: 0x009CD697 File Offset: 0x009CB897
		public NPCGeneralAction(int Id, string ActionType, TMap<string, string> LimitParams, bool IsClient, bool NeedTick)
		{
			this.Id = Id;
			this.ActionType = ActionType;
			this.LimitParams = LimitParams;
			this.IsClient = IsClient;
			this.NeedTick = NeedTick;
		}

		// Token: 0x06029D48 RID: 171336 RVA: 0x009CD6C4 File Offset: 0x009CB8C4
		protected override IntPtr GetUStructPtr()
		{
			return NPCGeneralAction.StaticStruct();
		}

		// Token: 0x06029D49 RID: 171337 RVA: 0x009CD6D0 File Offset: 0x009CB8D0
		[NullableContext(2)]
		public NPCGeneralAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029D4A RID: 171338 RVA: 0x009CD6DA File Offset: 0x009CB8DA
		public NPCGeneralAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029D4B RID: 171339 RVA: 0x009CD6E5 File Offset: 0x009CB8E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new NPCGeneralAction(Pointer, false, true);
		}

		// Token: 0x06029D4C RID: 171340 RVA: 0x009CD6EF File Offset: 0x009CB8EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new NPCGeneralAction(Pointer, MemoryOwner);
		}

		// Token: 0x040157AE RID: 87982
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/NPCGeneralAction.NPCGeneralAction";

		// Token: 0x040157AF RID: 87983
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157B0 RID: 87984
		internal static int __PropertyOffset_0;

		// Token: 0x040157B1 RID: 87985
		internal static int __PropertyOffset_1;

		// Token: 0x040157B2 RID: 87986
		internal static int __PropertyOffset_2;

		// Token: 0x040157B3 RID: 87987
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _LimitParams;

		// Token: 0x040157B4 RID: 87988
		internal static int __PropertyOffset_3;

		// Token: 0x040157B5 RID: 87989
		internal static int __PropertyOffset_4;
	}
}
