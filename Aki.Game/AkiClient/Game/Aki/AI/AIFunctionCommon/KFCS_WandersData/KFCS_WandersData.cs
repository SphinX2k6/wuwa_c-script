using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x02004447 RID: 17479
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WandersData.KFCS_WandersData")]
	[UnrealStructLayout(112, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class KFCS_WandersData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D3FC RID: 185340 RVA: 0x00A37B6E File Offset: 0x00A35D6E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (KFCS_WandersData._ScriptStructPtr != 0) ? KFCS_WandersData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WandersData.KFCS_WandersData", ref KFCS_WandersData._ScriptStructPtr);
		}

		// Token: 0x170072BB RID: 29371
		// (get) Token: 0x0602D3FD RID: 185341 RVA: 0x00A37B92 File Offset: 0x00A35D92
		// (set) Token: 0x0602D3FE RID: 185342 RVA: 0x00A37BA6 File Offset: 0x00A35DA6
		public unsafe KFCS_WanderDistance 距离设置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WandersData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WandersData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170072BC RID: 29372
		// (get) Token: 0x0602D3FF RID: 185343 RVA: 0x00A37BBC File Offset: 0x00A35DBC
		// (set) Token: 0x0602D400 RID: 185344 RVA: 0x00A37BFF File Offset: 0x00A35DFF
		public KFCS_WanderDirectionProbability 概率设置
		{
			get
			{
				base.FastCheckIsValid();
				KFCS_WanderDirectionProbability result;
				if ((result = this._概率设置) == null)
				{
					result = (this._概率设置 = new KFCS_WanderDirectionProbability(base.NativePtr + (IntPtr)KFCS_WandersData.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(KFCS_WanderDirectionProbability.StaticStruct(), base.NativePtr + (IntPtr)KFCS_WandersData.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170072BD RID: 29373
		// (get) Token: 0x0602D401 RID: 185345 RVA: 0x00A37C20 File Offset: 0x00A35E20
		// (set) Token: 0x0602D402 RID: 185346 RVA: 0x00A37C34 File Offset: 0x00A35E34
		public unsafe KFCS_DirectionData 转向速度设置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)KFCS_WandersData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)KFCS_WandersData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602D403 RID: 185347 RVA: 0x00A37C49 File Offset: 0x00A35E49
		public KFCS_WandersData()
		{
		}

		// Token: 0x0602D404 RID: 185348 RVA: 0x00A37C51 File Offset: 0x00A35E51
		public KFCS_WandersData(KFCS_WanderDistance 距离设置, KFCS_WanderDirectionProbability 概率设置, KFCS_DirectionData 转向速度设置)
		{
			this.距离设置 = 距离设置;
			this.概率设置 = 概率设置;
			this.转向速度设置 = 转向速度设置;
		}

		// Token: 0x0602D405 RID: 185349 RVA: 0x00A37C6E File Offset: 0x00A35E6E
		protected override IntPtr GetUStructPtr()
		{
			return KFCS_WandersData.StaticStruct();
		}

		// Token: 0x0602D406 RID: 185350 RVA: 0x00A37C7A File Offset: 0x00A35E7A
		[NullableContext(2)]
		public KFCS_WandersData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D407 RID: 185351 RVA: 0x00A37C84 File Offset: 0x00A35E84
		public KFCS_WandersData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D408 RID: 185352 RVA: 0x00A37C8F File Offset: 0x00A35E8F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new KFCS_WandersData(Pointer, false, true);
		}

		// Token: 0x0602D409 RID: 185353 RVA: 0x00A37C99 File Offset: 0x00A35E99
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new KFCS_WandersData(Pointer, MemoryOwner);
		}

		// Token: 0x0401812A RID: 98602
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/KFCS_WandersData.KFCS_WandersData";

		// Token: 0x0401812B RID: 98603
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401812C RID: 98604
		internal static int __PropertyOffset_0;

		// Token: 0x0401812D RID: 98605
		internal static int __PropertyOffset_1;

		// Token: 0x0401812E RID: 98606
		[Nullable(2)]
		private KFCS_WanderDirectionProbability _概率设置;

		// Token: 0x0401812F RID: 98607
		internal static int __PropertyOffset_2;
	}
}
