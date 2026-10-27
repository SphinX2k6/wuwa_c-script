using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Parkour
{
	// Token: 0x02003EEB RID: 16107
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Parkour/SParkourConfig.SParkourConfig")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class SParkourConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028C91 RID: 167057 RVA: 0x009B48F8 File Offset: 0x009B2AF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SParkourConfig._ScriptStructPtr != 0) ? SParkourConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Parkour/SParkourConfig.SParkourConfig", ref SParkourConfig._ScriptStructPtr);
		}

		// Token: 0x17005F98 RID: 24472
		// (get) Token: 0x06028C92 RID: 167058 RVA: 0x009B491C File Offset: 0x009B2B1C
		// (set) Token: 0x06028C93 RID: 167059 RVA: 0x009B4930 File Offset: 0x009B2B30
		public unsafe FName ConfigName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005F99 RID: 24473
		// (get) Token: 0x06028C94 RID: 167060 RVA: 0x009B4945 File Offset: 0x009B2B45
		// (set) Token: 0x06028C95 RID: 167061 RVA: 0x009B4955 File Offset: 0x009B2B55
		public unsafe bool IstoStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F9A RID: 24474
		// (get) Token: 0x06028C96 RID: 167062 RVA: 0x009B4966 File Offset: 0x009B2B66
		// (set) Token: 0x06028C97 RID: 167063 RVA: 0x009B4976 File Offset: 0x009B2B76
		public unsafe bool IsRequireToEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F9B RID: 24475
		// (get) Token: 0x06028C98 RID: 167064 RVA: 0x009B4988 File Offset: 0x009B2B88
		// (set) Token: 0x06028C99 RID: 167065 RVA: 0x009B49CB File Offset: 0x009B2BCB
		public TArray<SParkourPointInfo> ParkourPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SParkourPointInfo> result;
				if ((result = this._ParkourPoints) == null)
				{
					result = (this._ParkourPoints = new TArray<SParkourPointInfo>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParkourPoints.CopyAssign(value);
			}
		}

		// Token: 0x17005F9C RID: 24476
		// (get) Token: 0x06028C9A RID: 167066 RVA: 0x009B49D9 File Offset: 0x009B2BD9
		// (set) Token: 0x06028C9B RID: 167067 RVA: 0x009B49E9 File Offset: 0x009B2BE9
		public unsafe int CheckPointsRequire
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005F9D RID: 24477
		// (get) Token: 0x06028C9C RID: 167068 RVA: 0x009B49FA File Offset: 0x009B2BFA
		// (set) Token: 0x06028C9D RID: 167069 RVA: 0x009B4A19 File Offset: 0x009B2C19
		public TSoftObjectPtr<UEffectModelBase> CheckPointResource
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F9E RID: 24478
		// (get) Token: 0x06028C9E RID: 167070 RVA: 0x009B4A3E File Offset: 0x009B2C3E
		// (set) Token: 0x06028C9F RID: 167071 RVA: 0x009B4A5D File Offset: 0x009B2C5D
		public TSoftObjectPtr<UEffectModelBase> CheckPointsDestroyRes
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005F9F RID: 24479
		// (get) Token: 0x06028CA0 RID: 167072 RVA: 0x009B4A82 File Offset: 0x009B2C82
		// (set) Token: 0x06028CA1 RID: 167073 RVA: 0x009B4AA1 File Offset: 0x009B2CA1
		public TSoftObjectPtr<UEffectModelBase> StartResource
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_7, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005FA0 RID: 24480
		// (get) Token: 0x06028CA2 RID: 167074 RVA: 0x009B4AC6 File Offset: 0x009B2CC6
		// (set) Token: 0x06028CA3 RID: 167075 RVA: 0x009B4AE5 File Offset: 0x009B2CE5
		public TSoftObjectPtr<UEffectModelBase> EndResource
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_8, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005FA1 RID: 24481
		// (get) Token: 0x06028CA4 RID: 167076 RVA: 0x009B4B0A File Offset: 0x009B2D0A
		// (set) Token: 0x06028CA5 RID: 167077 RVA: 0x009B4B1A File Offset: 0x009B2D1A
		public unsafe float DefaultBuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005FA2 RID: 24482
		// (get) Token: 0x06028CA6 RID: 167078 RVA: 0x009B4B2B File Offset: 0x009B2D2B
		// (set) Token: 0x06028CA7 RID: 167079 RVA: 0x009B4B3B File Offset: 0x009B2D3B
		public unsafe float DefaultModifiedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SParkourConfig.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06028CA8 RID: 167080 RVA: 0x009B4B4C File Offset: 0x009B2D4C
		public SParkourConfig()
		{
		}

		// Token: 0x06028CA9 RID: 167081 RVA: 0x009B4B54 File Offset: 0x009B2D54
		public SParkourConfig(FName ConfigName, bool IstoStart, bool IsRequireToEnd, TArray<SParkourPointInfo> ParkourPoints, int CheckPointsRequire, TSoftObjectPtr<UEffectModelBase> CheckPointResource, TSoftObjectPtr<UEffectModelBase> CheckPointsDestroyRes, TSoftObjectPtr<UEffectModelBase> StartResource, TSoftObjectPtr<UEffectModelBase> EndResource, float DefaultBuffId, float DefaultModifiedTime)
		{
			this.ConfigName = ConfigName;
			this.IstoStart = IstoStart;
			this.IsRequireToEnd = IsRequireToEnd;
			this.ParkourPoints = ParkourPoints;
			this.CheckPointsRequire = CheckPointsRequire;
			this.CheckPointResource = CheckPointResource;
			this.CheckPointsDestroyRes = CheckPointsDestroyRes;
			this.StartResource = StartResource;
			this.EndResource = EndResource;
			this.DefaultBuffId = DefaultBuffId;
			this.DefaultModifiedTime = DefaultModifiedTime;
		}

		// Token: 0x06028CAA RID: 167082 RVA: 0x009B4BBC File Offset: 0x009B2DBC
		protected override IntPtr GetUStructPtr()
		{
			return SParkourConfig.StaticStruct();
		}

		// Token: 0x06028CAB RID: 167083 RVA: 0x009B4BC8 File Offset: 0x009B2DC8
		[NullableContext(2)]
		public SParkourConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028CAC RID: 167084 RVA: 0x009B4BD2 File Offset: 0x009B2DD2
		public SParkourConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028CAD RID: 167085 RVA: 0x009B4BDD File Offset: 0x009B2DDD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SParkourConfig(Pointer, false, true);
		}

		// Token: 0x06028CAE RID: 167086 RVA: 0x009B4BE7 File Offset: 0x009B2DE7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SParkourConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014D91 RID: 85393
		public const string __ObjectPath = "/Game/Aki/Data/Parkour/SParkourConfig.SParkourConfig";

		// Token: 0x04014D92 RID: 85394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014D93 RID: 85395
		internal static int __PropertyOffset_0;

		// Token: 0x04014D94 RID: 85396
		internal static int __PropertyOffset_1;

		// Token: 0x04014D95 RID: 85397
		internal static int __PropertyOffset_2;

		// Token: 0x04014D96 RID: 85398
		internal static int __PropertyOffset_3;

		// Token: 0x04014D97 RID: 85399
		[Nullable(2)]
		private TArray<SParkourPointInfo> _ParkourPoints;

		// Token: 0x04014D98 RID: 85400
		internal static int __PropertyOffset_4;

		// Token: 0x04014D99 RID: 85401
		internal static int __PropertyOffset_5;

		// Token: 0x04014D9A RID: 85402
		internal static int __PropertyOffset_6;

		// Token: 0x04014D9B RID: 85403
		internal static int __PropertyOffset_7;

		// Token: 0x04014D9C RID: 85404
		internal static int __PropertyOffset_8;

		// Token: 0x04014D9D RID: 85405
		internal static int __PropertyOffset_9;

		// Token: 0x04014D9E RID: 85406
		internal static int __PropertyOffset_10;
	}
}
