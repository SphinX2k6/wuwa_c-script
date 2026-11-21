using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DDF RID: 24031
	public struct IRagDollClimbingPoint : IFlatbufferObject
	{
		// Token: 0x1700B109 RID: 45321
		// (get) Token: 0x0602814C RID: 164172 RVA: 0x0057B273 File Offset: 0x00579473
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602814D RID: 164173 RVA: 0x0057B280 File Offset: 0x00579480
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602814E RID: 164174 RVA: 0x0057B288 File Offset: 0x00579488
		public static IRagDollClimbingPoint GetRootAsIRagDollClimbingPoint(ByteBuffer _bb)
		{
			return IRagDollClimbingPoint.GetRootAsIRagDollClimbingPoint(_bb, default(IRagDollClimbingPoint));
		}

		// Token: 0x0602814F RID: 164175 RVA: 0x0057B2A4 File Offset: 0x005794A4
		public static IRagDollClimbingPoint GetRootAsIRagDollClimbingPoint(ByteBuffer _bb, IRagDollClimbingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028150 RID: 164176 RVA: 0x0057B2C1 File Offset: 0x005794C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028151 RID: 164177 RVA: 0x0057B2D0 File Offset: 0x005794D0
		public IRagDollClimbingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B10A RID: 45322
		// (get) Token: 0x06028152 RID: 164178 RVA: 0x0057B2E0 File Offset: 0x005794E0
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

		// Token: 0x06028153 RID: 164179 RVA: 0x0057B31C File Offset: 0x0057951C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B10B RID: 45323
		// (get) Token: 0x06028154 RID: 164180 RVA: 0x0057B37C File Offset: 0x0057957C
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

		// Token: 0x06028155 RID: 164181 RVA: 0x0057B3A8 File Offset: 0x005795A8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B10C RID: 45324
		// (get) Token: 0x06028156 RID: 164182 RVA: 0x0057B408 File Offset: 0x00579608
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

		// Token: 0x06028157 RID: 164183 RVA: 0x0057B434 File Offset: 0x00579634
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B10D RID: 45325
		// (get) Token: 0x06028158 RID: 164184 RVA: 0x0057B498 File Offset: 0x00579698
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

		// Token: 0x1700B10E RID: 45326
		// (get) Token: 0x06028159 RID: 164185 RVA: 0x0057B4C4 File Offset: 0x005796C4
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

		// Token: 0x1700B10F RID: 45327
		// (get) Token: 0x0602815A RID: 164186 RVA: 0x0057B524 File Offset: 0x00579724
		public bool IsSummitPoint
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B110 RID: 45328
		// (get) Token: 0x0602815B RID: 164187 RVA: 0x0057B564 File Offset: 0x00579764
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

		// Token: 0x0602815C RID: 164188 RVA: 0x0057B5A4 File Offset: 0x005797A4
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

		// Token: 0x0602815D RID: 164189 RVA: 0x0057B5F3 File Offset: 0x005797F3
		public static void StartIRagDollClimbingPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602815E RID: 164190 RVA: 0x0057B5FC File Offset: 0x005797FC
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602815F RID: 164191 RVA: 0x0057B607 File Offset: 0x00579807
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06028160 RID: 164192 RVA: 0x0057B618 File Offset: 0x00579818
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028161 RID: 164193 RVA: 0x0057B658 File Offset: 0x00579858
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028162 RID: 164194 RVA: 0x0057B672 File Offset: 0x00579872
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028163 RID: 164195 RVA: 0x0057B690 File Offset: 0x00579890
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028164 RID: 164196 RVA: 0x0057B6A9 File Offset: 0x005798A9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028165 RID: 164197 RVA: 0x0057B6B4 File Offset: 0x005798B4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06028166 RID: 164198 RVA: 0x0057B6C4 File Offset: 0x005798C4
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028167 RID: 164199 RVA: 0x0057B704 File Offset: 0x00579904
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028168 RID: 164200 RVA: 0x0057B71E File Offset: 0x0057991E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028169 RID: 164201 RVA: 0x0057B73C File Offset: 0x0057993C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602816A RID: 164202 RVA: 0x0057B755 File Offset: 0x00579955
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602816B RID: 164203 RVA: 0x0057B760 File Offset: 0x00579960
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602816C RID: 164204 RVA: 0x0057B770 File Offset: 0x00579970
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602816D RID: 164205 RVA: 0x0057B7B0 File Offset: 0x005799B0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602816E RID: 164206 RVA: 0x0057B7CA File Offset: 0x005799CA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602816F RID: 164207 RVA: 0x0057B7E8 File Offset: 0x005799E8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028170 RID: 164208 RVA: 0x0057B801 File Offset: 0x00579A01
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028171 RID: 164209 RVA: 0x0057B80C File Offset: 0x00579A0C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06028172 RID: 164210 RVA: 0x0057B81C File Offset: 0x00579A1C
		public static void AddIsSummitPoint(FlatBufferBuilder builder, bool isSummitPoint)
		{
			builder.AddBool(5, isSummitPoint, false);
		}

		// Token: 0x06028173 RID: 164211 RVA: 0x0057B827 File Offset: 0x00579A27
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06028174 RID: 164212 RVA: 0x0057B832 File Offset: 0x00579A32
		public static Offset<IRagDollClimbingPoint> EndIRagDollClimbingPoint(FlatBufferBuilder builder)
		{
			return new Offset<IRagDollClimbingPoint>(builder.EndTable());
		}

		// Token: 0x06028175 RID: 164213 RVA: 0x0057B840 File Offset: 0x00579A40
		public IRagDollClimbingPointT UnPack()
		{
			IRagDollClimbingPointT ragDollClimbingPointT = new IRagDollClimbingPointT();
			this.UnPackTo(ragDollClimbingPointT);
			return ragDollClimbingPointT;
		}

		// Token: 0x06028176 RID: 164214 RVA: 0x0057B85C File Offset: 0x00579A5C
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

		// Token: 0x06028177 RID: 164215 RVA: 0x0057B9BC File Offset: 0x00579BBC
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

		// Token: 0x0400F9AA RID: 63914
		private Table __p;
	}
}
