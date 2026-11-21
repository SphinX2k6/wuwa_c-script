using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE2 RID: 24034
	public struct IRagDollJumpingPoint : IFlatbufferObject
	{
		// Token: 0x1700B118 RID: 45336
		// (get) Token: 0x06028188 RID: 164232 RVA: 0x0057BCC5 File Offset: 0x00579EC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028189 RID: 164233 RVA: 0x0057BCD2 File Offset: 0x00579ED2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602818A RID: 164234 RVA: 0x0057BCDC File Offset: 0x00579EDC
		public static IRagDollJumpingPoint GetRootAsIRagDollJumpingPoint(ByteBuffer _bb)
		{
			return IRagDollJumpingPoint.GetRootAsIRagDollJumpingPoint(_bb, default(IRagDollJumpingPoint));
		}

		// Token: 0x0602818B RID: 164235 RVA: 0x0057BCF8 File Offset: 0x00579EF8
		public static IRagDollJumpingPoint GetRootAsIRagDollJumpingPoint(ByteBuffer _bb, IRagDollJumpingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602818C RID: 164236 RVA: 0x0057BD15 File Offset: 0x00579F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602818D RID: 164237 RVA: 0x0057BD24 File Offset: 0x00579F24
		public IRagDollJumpingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B119 RID: 45337
		// (get) Token: 0x0602818E RID: 164238 RVA: 0x0057BD34 File Offset: 0x00579F34
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

		// Token: 0x0602818F RID: 164239 RVA: 0x0057BD70 File Offset: 0x00579F70
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B11A RID: 45338
		// (get) Token: 0x06028190 RID: 164240 RVA: 0x0057BDD0 File Offset: 0x00579FD0
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

		// Token: 0x06028191 RID: 164241 RVA: 0x0057BDFC File Offset: 0x00579FFC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B11B RID: 45339
		// (get) Token: 0x06028192 RID: 164242 RVA: 0x0057BE5C File Offset: 0x0057A05C
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

		// Token: 0x06028193 RID: 164243 RVA: 0x0057BE88 File Offset: 0x0057A088
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B11C RID: 45340
		// (get) Token: 0x06028194 RID: 164244 RVA: 0x0057BEEC File Offset: 0x0057A0EC
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

		// Token: 0x1700B11D RID: 45341
		// (get) Token: 0x06028195 RID: 164245 RVA: 0x0057BF18 File Offset: 0x0057A118
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

		// Token: 0x1700B11E RID: 45342
		// (get) Token: 0x06028196 RID: 164246 RVA: 0x0057BF78 File Offset: 0x0057A178
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

		// Token: 0x06028197 RID: 164247 RVA: 0x0057BFB5 File Offset: 0x0057A1B5
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

		// Token: 0x06028198 RID: 164248 RVA: 0x0057BFF1 File Offset: 0x0057A1F1
		public static void StartIRagDollJumpingPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06028199 RID: 164249 RVA: 0x0057BFFA File Offset: 0x0057A1FA
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602819A RID: 164250 RVA: 0x0057C005 File Offset: 0x0057A205
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602819B RID: 164251 RVA: 0x0057C018 File Offset: 0x0057A218
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602819C RID: 164252 RVA: 0x0057C058 File Offset: 0x0057A258
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602819D RID: 164253 RVA: 0x0057C072 File Offset: 0x0057A272
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602819E RID: 164254 RVA: 0x0057C090 File Offset: 0x0057A290
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602819F RID: 164255 RVA: 0x0057C0A9 File Offset: 0x0057A2A9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060281A0 RID: 164256 RVA: 0x0057C0B4 File Offset: 0x0057A2B4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060281A1 RID: 164257 RVA: 0x0057C0C4 File Offset: 0x0057A2C4
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060281A2 RID: 164258 RVA: 0x0057C104 File Offset: 0x0057A304
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281A3 RID: 164259 RVA: 0x0057C11E File Offset: 0x0057A31E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281A4 RID: 164260 RVA: 0x0057C13C File Offset: 0x0057A33C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060281A5 RID: 164261 RVA: 0x0057C155 File Offset: 0x0057A355
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060281A6 RID: 164262 RVA: 0x0057C160 File Offset: 0x0057A360
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060281A7 RID: 164263 RVA: 0x0057C170 File Offset: 0x0057A370
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060281A8 RID: 164264 RVA: 0x0057C1B0 File Offset: 0x0057A3B0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281A9 RID: 164265 RVA: 0x0057C1CA File Offset: 0x0057A3CA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060281AA RID: 164266 RVA: 0x0057C1E8 File Offset: 0x0057A3E8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060281AB RID: 164267 RVA: 0x0057C201 File Offset: 0x0057A401
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060281AC RID: 164268 RVA: 0x0057C20C File Offset: 0x0057A40C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060281AD RID: 164269 RVA: 0x0057C21C File Offset: 0x0057A41C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060281AE RID: 164270 RVA: 0x0057C227 File Offset: 0x0057A427
		public static Offset<IRagDollJumpingPoint> EndIRagDollJumpingPoint(FlatBufferBuilder builder)
		{
			return new Offset<IRagDollJumpingPoint>(builder.EndTable());
		}

		// Token: 0x060281AF RID: 164271 RVA: 0x0057C234 File Offset: 0x0057A434
		public IRagDollJumpingPointT UnPack()
		{
			IRagDollJumpingPointT ragDollJumpingPointT = new IRagDollJumpingPointT();
			this.UnPackTo(ragDollJumpingPointT);
			return ragDollJumpingPointT;
		}

		// Token: 0x060281B0 RID: 164272 RVA: 0x0057C250 File Offset: 0x0057A450
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

		// Token: 0x060281B1 RID: 164273 RVA: 0x0057C3A4 File Offset: 0x0057A5A4
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

		// Token: 0x0400F9B2 RID: 63922
		private Table __p;
	}
}
