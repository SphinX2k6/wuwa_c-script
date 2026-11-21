using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006163 RID: 24931
	public struct IWaterBoxBigWeaponHook : IFlatbufferObject
	{
		// Token: 0x1700B9C3 RID: 47555
		// (get) Token: 0x0602A537 RID: 173367 RVA: 0x005C6504 File Offset: 0x005C4704
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A538 RID: 173368 RVA: 0x005C6511 File Offset: 0x005C4711
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A539 RID: 173369 RVA: 0x005C6518 File Offset: 0x005C4718
		public static IWaterBoxBigWeaponHook GetRootAsIWaterBoxBigWeaponHook(ByteBuffer _bb)
		{
			return IWaterBoxBigWeaponHook.GetRootAsIWaterBoxBigWeaponHook(_bb, default(IWaterBoxBigWeaponHook));
		}

		// Token: 0x0602A53A RID: 173370 RVA: 0x005C6534 File Offset: 0x005C4734
		public static IWaterBoxBigWeaponHook GetRootAsIWaterBoxBigWeaponHook(ByteBuffer _bb, IWaterBoxBigWeaponHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A53B RID: 173371 RVA: 0x005C6551 File Offset: 0x005C4751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A53C RID: 173372 RVA: 0x005C6560 File Offset: 0x005C4760
		public IWaterBoxBigWeaponHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9C4 RID: 47556
		// (get) Token: 0x0602A53D RID: 173373 RVA: 0x005C6570 File Offset: 0x005C4770
		public EHookInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookInteractType.FixedPointHook;
				}
				return (EHookInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A53E RID: 173374 RVA: 0x005C65AC File Offset: 0x005C47AC
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B9C5 RID: 47557
		// (get) Token: 0x0602A53F RID: 173375 RVA: 0x005C660C File Offset: 0x005C480C
		public int HookActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A540 RID: 173376 RVA: 0x005C6638 File Offset: 0x005C4838
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B9C6 RID: 47558
		// (get) Token: 0x0602A541 RID: 173377 RVA: 0x005C6698 File Offset: 0x005C4898
		public int ExitHookActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A542 RID: 173378 RVA: 0x005C66C4 File Offset: 0x005C48C4
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B9C7 RID: 47559
		// (get) Token: 0x0602A543 RID: 173379 RVA: 0x005C6728 File Offset: 0x005C4928
		public int FinishActionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B9C8 RID: 47560
		// (get) Token: 0x0602A544 RID: 173380 RVA: 0x005C6754 File Offset: 0x005C4954
		public IClientHookActionConfig? ClientHookActionConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IClientHookActionConfig?(default(IClientHookActionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B9C9 RID: 47561
		// (get) Token: 0x0602A545 RID: 173381 RVA: 0x005C67B4 File Offset: 0x005C49B4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A546 RID: 173382 RVA: 0x005C67F1 File Offset: 0x005C49F1
		public static Offset<IWaterBoxBigWeaponHook> CreateIWaterBoxBigWeaponHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IWaterBoxBigWeaponHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IWaterBoxBigWeaponHook.AddFinishActions(builder, FinishActionsOffset);
			IWaterBoxBigWeaponHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IWaterBoxBigWeaponHook.AddHookActions(builder, HookActionsOffset);
			IWaterBoxBigWeaponHook.AddNullMask(builder, NullMask);
			IWaterBoxBigWeaponHook.AddType(builder, Type);
			return IWaterBoxBigWeaponHook.EndIWaterBoxBigWeaponHook(builder);
		}

		// Token: 0x0602A547 RID: 173383 RVA: 0x005C682D File Offset: 0x005C4A2D
		public static void StartIWaterBoxBigWeaponHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A548 RID: 173384 RVA: 0x005C6836 File Offset: 0x005C4A36
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A549 RID: 173385 RVA: 0x005C6841 File Offset: 0x005C4A41
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602A54A RID: 173386 RVA: 0x005C6854 File Offset: 0x005C4A54
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A54B RID: 173387 RVA: 0x005C6894 File Offset: 0x005C4A94
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A54C RID: 173388 RVA: 0x005C68AE File Offset: 0x005C4AAE
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A54D RID: 173389 RVA: 0x005C68CC File Offset: 0x005C4ACC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A54E RID: 173390 RVA: 0x005C68E5 File Offset: 0x005C4AE5
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A54F RID: 173391 RVA: 0x005C68F0 File Offset: 0x005C4AF0
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602A550 RID: 173392 RVA: 0x005C6900 File Offset: 0x005C4B00
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A551 RID: 173393 RVA: 0x005C6940 File Offset: 0x005C4B40
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A552 RID: 173394 RVA: 0x005C695A File Offset: 0x005C4B5A
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A553 RID: 173395 RVA: 0x005C6978 File Offset: 0x005C4B78
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A554 RID: 173396 RVA: 0x005C6991 File Offset: 0x005C4B91
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A555 RID: 173397 RVA: 0x005C699C File Offset: 0x005C4B9C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602A556 RID: 173398 RVA: 0x005C69AC File Offset: 0x005C4BAC
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A557 RID: 173399 RVA: 0x005C69EC File Offset: 0x005C4BEC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A558 RID: 173400 RVA: 0x005C6A06 File Offset: 0x005C4C06
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A559 RID: 173401 RVA: 0x005C6A24 File Offset: 0x005C4C24
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A55A RID: 173402 RVA: 0x005C6A3D File Offset: 0x005C4C3D
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A55B RID: 173403 RVA: 0x005C6A48 File Offset: 0x005C4C48
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602A55C RID: 173404 RVA: 0x005C6A58 File Offset: 0x005C4C58
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602A55D RID: 173405 RVA: 0x005C6A63 File Offset: 0x005C4C63
		public static Offset<IWaterBoxBigWeaponHook> EndIWaterBoxBigWeaponHook(FlatBufferBuilder builder)
		{
			return new Offset<IWaterBoxBigWeaponHook>(builder.EndTable());
		}

		// Token: 0x0602A55E RID: 173406 RVA: 0x005C6A70 File Offset: 0x005C4C70
		public IWaterBoxBigWeaponHookT UnPack()
		{
			IWaterBoxBigWeaponHookT waterBoxBigWeaponHookT = new IWaterBoxBigWeaponHookT();
			this.UnPackTo(waterBoxBigWeaponHookT);
			return waterBoxBigWeaponHookT;
		}

		// Token: 0x0602A55F RID: 173407 RVA: 0x005C6A8C File Offset: 0x005C4C8C
		public void UnPackTo(IWaterBoxBigWeaponHookT _o)
		{
			_o.Type = this.Type;
			_o.HookActions = new List<IActionInfoT>();
			for (int i = 0; i < this.HookActionsLength; i++)
			{
				_o.HookActions.Add((this.HookActions(i) != null) ? this.HookActions(i).Value.UnPack() : null);
			}
			_o.ExitHookActions = new List<IActionInfoT>();
			for (int j = 0; j < this.ExitHookActionsLength; j++)
			{
				_o.ExitHookActions.Add((this.ExitHookActions(j) != null) ? this.ExitHookActions(j).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int k = 0; k < this.FinishActionsLength; k++)
			{
				_o.FinishActions.Add((this.FinishActions(k) != null) ? this.FinishActions(k).Value.UnPack() : null);
			}
			_o.ClientHookActionConfig = ((this.ClientHookActionConfig != null) ? this.ClientHookActionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A560 RID: 173408 RVA: 0x005C6BE0 File Offset: 0x005C4DE0
		public static Offset<IWaterBoxBigWeaponHook> Pack(FlatBufferBuilder builder, IWaterBoxBigWeaponHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaterBoxBigWeaponHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IWaterBoxBigWeaponHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IWaterBoxBigWeaponHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IWaterBoxBigWeaponHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IWaterBoxBigWeaponHook.CreateIWaterBoxBigWeaponHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FF8C RID: 65420
		private Table __p;
	}
}
