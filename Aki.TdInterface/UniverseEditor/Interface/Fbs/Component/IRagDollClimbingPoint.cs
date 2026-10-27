using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D8 RID: 22488
	public struct IRagDollClimbingPoint : IFlatbufferObject
	{
		// Token: 0x1700A7E5 RID: 42981
		// (get) Token: 0x06025C2C RID: 154668 RVA: 0x005350E7 File Offset: 0x005332E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025C2D RID: 154669 RVA: 0x005350F4 File Offset: 0x005332F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025C2E RID: 154670 RVA: 0x005350FC File Offset: 0x005332FC
		public static IRagDollClimbingPoint GetRootAsIRagDollClimbingPoint(ByteBuffer _bb)
		{
			return IRagDollClimbingPoint.GetRootAsIRagDollClimbingPoint(_bb, default(IRagDollClimbingPoint));
		}

		// Token: 0x06025C2F RID: 154671 RVA: 0x00535118 File Offset: 0x00533318
		public static IRagDollClimbingPoint GetRootAsIRagDollClimbingPoint(ByteBuffer _bb, IRagDollClimbingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025C30 RID: 154672 RVA: 0x00535135 File Offset: 0x00533335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025C31 RID: 154673 RVA: 0x00535144 File Offset: 0x00533344
		public IRagDollClimbingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7E6 RID: 42982
		// (get) Token: 0x06025C32 RID: 154674 RVA: 0x00535154 File Offset: 0x00533354
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

		// Token: 0x06025C33 RID: 154675 RVA: 0x00535190 File Offset: 0x00533390
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7E7 RID: 42983
		// (get) Token: 0x06025C34 RID: 154676 RVA: 0x005351F0 File Offset: 0x005333F0
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

		// Token: 0x06025C35 RID: 154677 RVA: 0x0053521C File Offset: 0x0053341C
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7E8 RID: 42984
		// (get) Token: 0x06025C36 RID: 154678 RVA: 0x0053527C File Offset: 0x0053347C
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

		// Token: 0x06025C37 RID: 154679 RVA: 0x005352A8 File Offset: 0x005334A8
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7E9 RID: 42985
		// (get) Token: 0x06025C38 RID: 154680 RVA: 0x0053530C File Offset: 0x0053350C
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

		// Token: 0x1700A7EA RID: 42986
		// (get) Token: 0x06025C39 RID: 154681 RVA: 0x00535338 File Offset: 0x00533538
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

		// Token: 0x1700A7EB RID: 42987
		// (get) Token: 0x06025C3A RID: 154682 RVA: 0x00535398 File Offset: 0x00533598
		public bool IsSummitPoint
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7EC RID: 42988
		// (get) Token: 0x06025C3B RID: 154683 RVA: 0x005353D8 File Offset: 0x005335D8
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

		// Token: 0x06025C3C RID: 154684 RVA: 0x00535418 File Offset: 0x00533618
		public static Offset<IRagDollClimbingPoint> CreateIRagDollClimbingPoint(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), bool IsSummitPoint = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IRagDollClimbingPoint.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IRagDollClimbingPoint.AddFinishActions(builder, FinishActionsOffset);
			IRagDollClimbingPoint.AddExitHookActions(builder, ExitHookActionsOffset);
			IRagDollClimbingPoint.AddHookActions(builder, HookActionsOffset);
			IRagDollClimbingPoint.AddNullMask(builder, NullMask);
			IRagDollClimbingPoint.AddIsSummitPoint(builder, IsSummitPoint);
			IRagDollClimbingPoint.AddType(builder, Type);
			return IRagDollClimbingPoint.EndIRagDollClimbingPoint(builder);
		}

		// Token: 0x06025C3D RID: 154685 RVA: 0x00535467 File Offset: 0x00533667
		public static void StartIRagDollClimbingPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06025C3E RID: 154686 RVA: 0x00535470 File Offset: 0x00533670
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025C3F RID: 154687 RVA: 0x0053547B File Offset: 0x0053367B
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06025C40 RID: 154688 RVA: 0x0053548C File Offset: 0x0053368C
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C41 RID: 154689 RVA: 0x005354CC File Offset: 0x005336CC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C42 RID: 154690 RVA: 0x005354E6 File Offset: 0x005336E6
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C43 RID: 154691 RVA: 0x00535504 File Offset: 0x00533704
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C44 RID: 154692 RVA: 0x0053551D File Offset: 0x0053371D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C45 RID: 154693 RVA: 0x00535528 File Offset: 0x00533728
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06025C46 RID: 154694 RVA: 0x00535538 File Offset: 0x00533738
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C47 RID: 154695 RVA: 0x00535578 File Offset: 0x00533778
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C48 RID: 154696 RVA: 0x00535592 File Offset: 0x00533792
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C49 RID: 154697 RVA: 0x005355B0 File Offset: 0x005337B0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C4A RID: 154698 RVA: 0x005355C9 File Offset: 0x005337C9
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C4B RID: 154699 RVA: 0x005355D4 File Offset: 0x005337D4
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06025C4C RID: 154700 RVA: 0x005355E4 File Offset: 0x005337E4
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025C4D RID: 154701 RVA: 0x00535624 File Offset: 0x00533824
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C4E RID: 154702 RVA: 0x0053563E File Offset: 0x0053383E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025C4F RID: 154703 RVA: 0x0053565C File Offset: 0x0053385C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025C50 RID: 154704 RVA: 0x00535675 File Offset: 0x00533875
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025C51 RID: 154705 RVA: 0x00535680 File Offset: 0x00533880
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06025C52 RID: 154706 RVA: 0x00535690 File Offset: 0x00533890
		public static void AddIsSummitPoint(FlatBufferBuilder builder, bool isSummitPoint)
		{
			builder.AddBool(5, isSummitPoint, false);
		}

		// Token: 0x06025C53 RID: 154707 RVA: 0x0053569B File Offset: 0x0053389B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025C54 RID: 154708 RVA: 0x005356A6 File Offset: 0x005338A6
		public static Offset<IRagDollClimbingPoint> EndIRagDollClimbingPoint(FlatBufferBuilder builder)
		{
			return new Offset<IRagDollClimbingPoint>(builder.EndTable());
		}

		// Token: 0x06025C55 RID: 154709 RVA: 0x005356B4 File Offset: 0x005338B4
		public IRagDollClimbingPointT UnPack()
		{
			IRagDollClimbingPointT ragDollClimbingPointT = new IRagDollClimbingPointT();
			this.UnPackTo(ragDollClimbingPointT);
			return ragDollClimbingPointT;
		}

		// Token: 0x06025C56 RID: 154710 RVA: 0x005356D0 File Offset: 0x005338D0
		public void UnPackTo(IRagDollClimbingPointT _o)
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
			_o.IsSummitPoint = this.IsSummitPoint;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025C57 RID: 154711 RVA: 0x00535830 File Offset: 0x00533A30
		public static Offset<IRagDollClimbingPoint> Pack(FlatBufferBuilder builder, IRagDollClimbingPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRagDollClimbingPoint>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IRagDollClimbingPoint.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IRagDollClimbingPoint.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IRagDollClimbingPoint.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IRagDollClimbingPoint.CreateIRagDollClimbingPoint(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.IsSummitPoint, _o.NullMask);
		}

		// Token: 0x0400ECBF RID: 60607
		private Table __p;
	}
}
