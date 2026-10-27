using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DB RID: 22491
	public struct IRagDollJumpingPoint : IFlatbufferObject
	{
		// Token: 0x1700A7F4 RID: 42996
		// (get) Token: 0x06025C68 RID: 154728 RVA: 0x00535B39 File Offset: 0x00533D39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025C69 RID: 154729 RVA: 0x00535B46 File Offset: 0x00533D46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025C6A RID: 154730 RVA: 0x00535B50 File Offset: 0x00533D50
		public static IRagDollJumpingPoint GetRootAsIRagDollJumpingPoint(ByteBuffer _bb)
		{
			return IRagDollJumpingPoint.GetRootAsIRagDollJumpingPoint(_bb, default(IRagDollJumpingPoint));
		}

		// Token: 0x06025C6B RID: 154731 RVA: 0x00535B6C File Offset: 0x00533D6C
		public static IRagDollJumpingPoint GetRootAsIRagDollJumpingPoint(ByteBuffer _bb, IRagDollJumpingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025C6C RID: 154732 RVA: 0x00535B89 File Offset: 0x00533D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025C6D RID: 154733 RVA: 0x00535B98 File Offset: 0x00533D98
		public IRagDollJumpingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7F5 RID: 42997
		// (get) Token: 0x06025C6E RID: 154734 RVA: 0x00535BA8 File Offset: 0x00533DA8
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

		// Token: 0x06025C6F RID: 154735 RVA: 0x00535BE4 File Offset: 0x00533DE4
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7F6 RID: 42998
		// (get) Token: 0x06025C70 RID: 154736 RVA: 0x00535C44 File Offset: 0x00533E44
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

		// Token: 0x06025C71 RID: 154737 RVA: 0x00535C70 File Offset: 0x00533E70
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7F7 RID: 42999
		// (get) Token: 0x06025C72 RID: 154738 RVA: 0x00535CD0 File Offset: 0x00533ED0
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

		// Token: 0x06025C73 RID: 154739 RVA: 0x00535CFC File Offset: 0x00533EFC
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7F8 RID: 43000
		// (get) Token: 0x06025C74 RID: 154740 RVA: 0x00535D60 File Offset: 0x00533F60
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

		// Token: 0x1700A7F9 RID: 43001
		// (get) Token: 0x06025C75 RID: 154741 RVA: 0x00535D8C File Offset: 0x00533F8C
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

		// Token: 0x1700A7FA RID: 43002
		// (get) Token: 0x06025C76 RID: 154742 RVA: 0x00535DEC File Offset: 0x00533FEC
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

		// Token: 0x06025C77 RID: 154743 RVA: 0x00535E29 File Offset: 0x00534029
		public static Offset<IRagDollJumpingPoint> CreateIRagDollJumpingPoint(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRagDollJumpingPoint.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IRagDollJumpingPoint.AddFinishActions(builder, FinishActionsOffset);
			IRagDollJumpingPoint.AddExitHookActions(builder, ExitHookActionsOffset);
			IRagDollJumpingPoint.AddHookActions(builder, HookActionsOffset);
			IRagDollJumpingPoint.AddNullMask(builder, NullMask);
			IRagDollJumpingPoint.AddType(builder, Type);
			return IRagDollJumpingPoint.EndIRagDollJumpingPoint(builder);
		}

		// Token: 0x06025C78 RID: 154744 RVA: 0x00535E65 File Offset: 0x00534065
		public static void StartIRagDollJumpingPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025C79 RID: 154745 RVA: 0x00535E6E File Offset: 0x0053406E
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025C7A RID: 154746 RVA: 0x00535E79 File Offset: 0x00534079
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06025C7B RID: 154747 RVA: 0x00535E8C File Offset: 0x0053408C
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C7C RID: 154748 RVA: 0x00535ECC File Offset: 0x005340CC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C7D RID: 154749 RVA: 0x00535EE6 File Offset: 0x005340E6
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C7E RID: 154750 RVA: 0x00535F04 File Offset: 0x00534104
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C7F RID: 154751 RVA: 0x00535F1D File Offset: 0x0053411D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C80 RID: 154752 RVA: 0x00535F28 File Offset: 0x00534128
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06025C81 RID: 154753 RVA: 0x00535F38 File Offset: 0x00534138
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C82 RID: 154754 RVA: 0x00535F78 File Offset: 0x00534178
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C83 RID: 154755 RVA: 0x00535F92 File Offset: 0x00534192
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C84 RID: 154756 RVA: 0x00535FB0 File Offset: 0x005341B0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C85 RID: 154757 RVA: 0x00535FC9 File Offset: 0x005341C9
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C86 RID: 154758 RVA: 0x00535FD4 File Offset: 0x005341D4
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06025C87 RID: 154759 RVA: 0x00535FE4 File Offset: 0x005341E4
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C88 RID: 154760 RVA: 0x00536024 File Offset: 0x00534224
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C89 RID: 154761 RVA: 0x0053603E File Offset: 0x0053423E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C8A RID: 154762 RVA: 0x0053605C File Offset: 0x0053425C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C8B RID: 154763 RVA: 0x00536075 File Offset: 0x00534275
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C8C RID: 154764 RVA: 0x00536080 File Offset: 0x00534280
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06025C8D RID: 154765 RVA: 0x00536090 File Offset: 0x00534290
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025C8E RID: 154766 RVA: 0x0053609B File Offset: 0x0053429B
		public static Offset<IRagDollJumpingPoint> EndIRagDollJumpingPoint(FlatBufferBuilder builder)
		{
			return new Offset<IRagDollJumpingPoint>(builder.EndTable());
		}

		// Token: 0x06025C8F RID: 154767 RVA: 0x005360A8 File Offset: 0x005342A8
		public IRagDollJumpingPointT UnPack()
		{
			IRagDollJumpingPointT ragDollJumpingPointT = new IRagDollJumpingPointT();
			this.UnPackTo(ragDollJumpingPointT);
			return ragDollJumpingPointT;
		}

		// Token: 0x06025C90 RID: 154768 RVA: 0x005360C4 File Offset: 0x005342C4
		public void UnPackTo(IRagDollJumpingPointT _o)
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

		// Token: 0x06025C91 RID: 154769 RVA: 0x00536218 File Offset: 0x00534418
		public static Offset<IRagDollJumpingPoint> Pack(FlatBufferBuilder builder, IRagDollJumpingPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRagDollJumpingPoint>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IRagDollJumpingPoint.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IRagDollJumpingPoint.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IRagDollJumpingPoint.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IRagDollJumpingPoint.CreateIRagDollJumpingPoint(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400ECC7 RID: 60615
		private Table __p;
	}
}
