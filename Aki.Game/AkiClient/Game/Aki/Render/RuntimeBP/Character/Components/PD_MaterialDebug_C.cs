using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Components
{
	// Token: 0x02003E2D RID: 15917
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Components/PD_MaterialDebug.PD_MaterialDebug_C")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class PD_MaterialDebug_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027EBD RID: 163517 RVA: 0x0099F4E8 File Offset: 0x0099D6E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MaterialDebug_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Components/PD_MaterialDebug.PD_MaterialDebug_C");
			}
			return PD_MaterialDebug_C._ClassPtr;
		}

		// Token: 0x06027EBE RID: 163518 RVA: 0x0099F50C File Offset: 0x0099D70C
		public PD_MaterialDebug_C() : this(BuiltinUtils.AllocNativeUObject(PD_MaterialDebug_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027EBF RID: 163519 RVA: 0x0099F534 File Offset: 0x0099D734
		public PD_MaterialDebug_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MaterialDebug_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AC0 RID: 23232
		// (get) Token: 0x06027EC0 RID: 163520 RVA: 0x0099F568 File Offset: 0x0099D768
		// (set) Token: 0x06027EC1 RID: 163521 RVA: 0x0099F5A1 File Offset: 0x0099D7A1
		public TMap<int, string> MaterialControllerList
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, string> result;
				if ((result = this._MaterialControllerList) == null)
				{
					result = (this._MaterialControllerList = new TMap<int, string>(base.NativePtr + (IntPtr)PD_MaterialDebug_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.MaterialControllerList.CopyAssign(value);
			}
		}

		// Token: 0x17005AC1 RID: 23233
		// (get) Token: 0x06027EC2 RID: 163522 RVA: 0x0099F5B0 File Offset: 0x0099D7B0
		// (set) Token: 0x06027EC3 RID: 163523 RVA: 0x0099F5E9 File Offset: 0x0099D7E9
		public TMap<string, SMaterialDebugInfo> Body
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, SMaterialDebugInfo> result;
				if ((result = this._Body) == null)
				{
					result = (this._Body = new TMap<string, SMaterialDebugInfo>(base.NativePtr + (IntPtr)PD_MaterialDebug_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Body.CopyAssign(value);
			}
		}

		// Token: 0x17005AC2 RID: 23234
		// (get) Token: 0x06027EC4 RID: 163524 RVA: 0x0099F5F8 File Offset: 0x0099D7F8
		// (set) Token: 0x06027EC5 RID: 163525 RVA: 0x0099F631 File Offset: 0x0099D831
		public TMap<string, SMaterialDebugInfo> Weapon
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, SMaterialDebugInfo> result;
				if ((result = this._Weapon) == null)
				{
					result = (this._Weapon = new TMap<string, SMaterialDebugInfo>(base.NativePtr + (IntPtr)PD_MaterialDebug_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.Weapon.CopyAssign(value);
			}
		}

		// Token: 0x17005AC3 RID: 23235
		// (get) Token: 0x06027EC6 RID: 163526 RVA: 0x0099F640 File Offset: 0x0099D840
		// (set) Token: 0x06027EC7 RID: 163527 RVA: 0x0099F679 File Offset: 0x0099D879
		public TMap<string, SMaterialDebugInfo> Hulu
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, SMaterialDebugInfo> result;
				if ((result = this._Hulu) == null)
				{
					result = (this._Hulu = new TMap<string, SMaterialDebugInfo>(base.NativePtr + (IntPtr)PD_MaterialDebug_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Hulu.CopyAssign(value);
			}
		}

		// Token: 0x06027EC8 RID: 163528 RVA: 0x0099F687 File Offset: 0x0099D887
		protected PD_MaterialDebug_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014425 RID: 82981
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Components/PD_MaterialDebug.PD_MaterialDebug_C";

		// Token: 0x04014426 RID: 82982
		private static IntPtr _ClassPtr;

		// Token: 0x04014427 RID: 82983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014428 RID: 82984
		internal static int __PropertyOffset_0;

		// Token: 0x04014429 RID: 82985
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, string> _MaterialControllerList;

		// Token: 0x0401442A RID: 82986
		internal static int __PropertyOffset_1;

		// Token: 0x0401442B RID: 82987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, SMaterialDebugInfo> _Body;

		// Token: 0x0401442C RID: 82988
		internal static int __PropertyOffset_2;

		// Token: 0x0401442D RID: 82989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, SMaterialDebugInfo> _Weapon;

		// Token: 0x0401442E RID: 82990
		internal static int __PropertyOffset_3;

		// Token: 0x0401442F RID: 82991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, SMaterialDebugInfo> _Hulu;
	}
}
