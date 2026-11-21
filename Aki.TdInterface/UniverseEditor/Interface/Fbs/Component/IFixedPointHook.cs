using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DB RID: 22491
	public struct IFixedPointHook : IFlatbufferObject
	{
		// Token: 0x1700A2A3 RID: 41635
		// (get) Token: 0x0602452B RID: 148779 RVA: 0x004FD921 File Offset: 0x004FBB21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602452C RID: 148780 RVA: 0x004FD92E File Offset: 0x004FBB2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602452D RID: 148781 RVA: 0x004FD938 File Offset: 0x004FBB38
		public static IFixedPointHook GetRootAsIFixedPointHook(ByteBuffer _bb)
		{
			return IFixedPointHook.GetRootAsIFixedPointHook(_bb, default(IFixedPointHook));
		}

		// Token: 0x0602452E RID: 148782 RVA: 0x004FD954 File Offset: 0x004FBB54
		public static IFixedPointHook GetRootAsIFixedPointHook(ByteBuffer _bb, IFixedPointHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602452F RID: 148783 RVA: 0x004FD971 File Offset: 0x004FBB71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024530 RID: 148784 RVA: 0x004FD980 File Offset: 0x004FBB80
		public IFixedPointHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2A4 RID: 41636
		// (get) Token: 0x06024531 RID: 148785 RVA: 0x004FD990 File Offset: 0x004FBB90
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

		// Token: 0x06024532 RID: 148786 RVA: 0x004FD9CC File Offset: 0x004FBBCC
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2A5 RID: 41637
		// (get) Token: 0x06024533 RID: 148787 RVA: 0x004FDA2C File Offset: 0x004FBC2C
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

		// Token: 0x06024534 RID: 148788 RVA: 0x004FDA58 File Offset: 0x004FBC58
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2A6 RID: 41638
		// (get) Token: 0x06024535 RID: 148789 RVA: 0x004FDAB8 File Offset: 0x004FBCB8
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

		// Token: 0x06024536 RID: 148790 RVA: 0x004FDAE4 File Offset: 0x004FBCE4
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2A7 RID: 41639
		// (get) Token: 0x06024537 RID: 148791 RVA: 0x004FDB48 File Offset: 0x004FBD48
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

		// Token: 0x1700A2A8 RID: 41640
		// (get) Token: 0x06024538 RID: 148792 RVA: 0x004FDB74 File Offset: 0x004FBD74
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

		// Token: 0x1700A2A9 RID: 41641
		// (get) Token: 0x06024539 RID: 148793 RVA: 0x004FDBD4 File Offset: 0x004FBDD4
		public float ExitDistance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A2AA RID: 41642
		// (get) Token: 0x0602453A RID: 148794 RVA: 0x004FDC18 File Offset: 0x004FBE18
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602453B RID: 148795 RVA: 0x004FDC58 File Offset: 0x004FBE58
		public static Offset<IFixedPointHook> CreateIFixedPointHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), float ExitDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IFixedPointHook.AddExitDistance(builder, ExitDistance);
			IFixedPointHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IFixedPointHook.AddFinishActions(builder, FinishActionsOffset);
			IFixedPointHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IFixedPointHook.AddHookActions(builder, HookActionsOffset);
			IFixedPointHook.AddNullMask(builder, NullMask);
			IFixedPointHook.AddType(builder, Type);
			return IFixedPointHook.EndIFixedPointHook(builder);
		}

		// Token: 0x0602453C RID: 148796 RVA: 0x004FDCA7 File Offset: 0x004FBEA7
		public static void StartIFixedPointHook(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602453D RID: 148797 RVA: 0x004FDCB0 File Offset: 0x004FBEB0
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602453E RID: 148798 RVA: 0x004FDCBB File Offset: 0x004FBEBB
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602453F RID: 148799 RVA: 0x004FDCCC File Offset: 0x004FBECC
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024540 RID: 148800 RVA: 0x004FDD0C File Offset: 0x004FBF0C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024541 RID: 148801 RVA: 0x004FDD26 File Offset: 0x004FBF26
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024542 RID: 148802 RVA: 0x004FDD44 File Offset: 0x004FBF44
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024543 RID: 148803 RVA: 0x004FDD5D File Offset: 0x004FBF5D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024544 RID: 148804 RVA: 0x004FDD68 File Offset: 0x004FBF68
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06024545 RID: 148805 RVA: 0x004FDD78 File Offset: 0x004FBF78
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024546 RID: 148806 RVA: 0x004FDDB8 File Offset: 0x004FBFB8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024547 RID: 148807 RVA: 0x004FDDD2 File Offset: 0x004FBFD2
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024548 RID: 148808 RVA: 0x004FDDF0 File Offset: 0x004FBFF0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024549 RID: 148809 RVA: 0x004FDE09 File Offset: 0x004FC009
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602454A RID: 148810 RVA: 0x004FDE14 File Offset: 0x004FC014
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602454B RID: 148811 RVA: 0x004FDE24 File Offset: 0x004FC024
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602454C RID: 148812 RVA: 0x004FDE64 File Offset: 0x004FC064
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602454D RID: 148813 RVA: 0x004FDE7E File Offset: 0x004FC07E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602454E RID: 148814 RVA: 0x004FDE9C File Offset: 0x004FC09C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602454F RID: 148815 RVA: 0x004FDEB5 File Offset: 0x004FC0B5
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024550 RID: 148816 RVA: 0x004FDEC0 File Offset: 0x004FC0C0
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06024551 RID: 148817 RVA: 0x004FDED0 File Offset: 0x004FC0D0
		public static void AddExitDistance(FlatBufferBuilder builder, float exitDistance)
		{
			builder.AddFloat(5, exitDistance, 0.0);
		}

		// Token: 0x06024552 RID: 148818 RVA: 0x004FDEE3 File Offset: 0x004FC0E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06024553 RID: 148819 RVA: 0x004FDEEE File Offset: 0x004FC0EE
		public static Offset<IFixedPointHook> EndIFixedPointHook(FlatBufferBuilder builder)
		{
			return new Offset<IFixedPointHook>(builder.EndTable());
		}

		// Token: 0x06024554 RID: 148820 RVA: 0x004FDEFC File Offset: 0x004FC0FC
		public IFixedPointHookT UnPack()
		{
			IFixedPointHookT fixedPointHookT = new IFixedPointHookT();
			this.UnPackTo(fixedPointHookT);
			return fixedPointHookT;
		}

		// Token: 0x06024555 RID: 148821 RVA: 0x004FDF18 File Offset: 0x004FC118
		public void UnPackTo(IFixedPointHookT _o)
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
			_o.ExitDistance = this.ExitDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024556 RID: 148822 RVA: 0x004FE078 File Offset: 0x004FC278
		public static Offset<IFixedPointHook> Pack(FlatBufferBuilder builder, IFixedPointHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedPointHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IFixedPointHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IFixedPointHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IFixedPointHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IFixedPointHook.CreateIFixedPointHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.ExitDistance, _o.NullMask);
		}

		// Token: 0x0400EFD4 RID: 61396
		private Table __p;
	}
}
