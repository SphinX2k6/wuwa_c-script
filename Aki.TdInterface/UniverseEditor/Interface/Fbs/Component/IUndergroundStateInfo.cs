using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006115 RID: 24853
	public struct IUndergroundStateInfo : IFlatbufferObject
	{
		// Token: 0x1700B908 RID: 47368
		// (get) Token: 0x0602A224 RID: 172580 RVA: 0x005C025B File Offset: 0x005BE45B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A225 RID: 172581 RVA: 0x005C0268 File Offset: 0x005BE468
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A226 RID: 172582 RVA: 0x005C0270 File Offset: 0x005BE470
		public static IUndergroundStateInfo GetRootAsIUndergroundStateInfo(ByteBuffer _bb)
		{
			return IUndergroundStateInfo.GetRootAsIUndergroundStateInfo(_bb, default(IUndergroundStateInfo));
		}

		// Token: 0x0602A227 RID: 172583 RVA: 0x005C028C File Offset: 0x005BE48C
		public static IUndergroundStateInfo GetRootAsIUndergroundStateInfo(ByteBuffer _bb, IUndergroundStateInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A228 RID: 172584 RVA: 0x005C02A9 File Offset: 0x005BE4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A229 RID: 172585 RVA: 0x005C02B8 File Offset: 0x005BE4B8
		public IUndergroundStateInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B909 RID: 47369
		// (get) Token: 0x0602A22A RID: 172586 RVA: 0x005C02C8 File Offset: 0x005BE4C8
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B90A RID: 47370
		// (get) Token: 0x0602A22B RID: 172587 RVA: 0x005C0304 File Offset: 0x005BE504
		public IVectorInfo? RestartPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602A22C RID: 172588 RVA: 0x005C0361 File Offset: 0x005BE561
		public static Offset<IUndergroundStateInfo> CreateIUndergroundStateInfo(FlatBufferBuilder builder, int StateId = 0, Offset<IVectorInfo> RestartPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IUndergroundStateInfo.AddRestartPos(builder, RestartPosOffset);
			IUndergroundStateInfo.AddStateId(builder, StateId);
			return IUndergroundStateInfo.EndIUndergroundStateInfo(builder);
		}

		// Token: 0x0602A22D RID: 172589 RVA: 0x005C037E File Offset: 0x005BE57E
		public static void StartIUndergroundStateInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A22E RID: 172590 RVA: 0x005C0387 File Offset: 0x005BE587
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(0, stateId, 0);
		}

		// Token: 0x0602A22F RID: 172591 RVA: 0x005C0392 File Offset: 0x005BE592
		public static void AddRestartPos(FlatBufferBuilder builder, Offset<IVectorInfo> restartPosOffset)
		{
			builder.AddOffset(1, restartPosOffset.Value, 0);
		}

		// Token: 0x0602A230 RID: 172592 RVA: 0x005C03A2 File Offset: 0x005BE5A2
		public static Offset<IUndergroundStateInfo> EndIUndergroundStateInfo(FlatBufferBuilder builder)
		{
			return new Offset<IUndergroundStateInfo>(builder.EndTable());
		}

		// Token: 0x0602A231 RID: 172593 RVA: 0x005C03B0 File Offset: 0x005BE5B0
		public IUndergroundStateInfoT UnPack()
		{
			IUndergroundStateInfoT undergroundStateInfoT = new IUndergroundStateInfoT();
			this.UnPackTo(undergroundStateInfoT);
			return undergroundStateInfoT;
		}

		// Token: 0x0602A232 RID: 172594 RVA: 0x005C03CC File Offset: 0x005BE5CC
		public void UnPackTo(IUndergroundStateInfoT _o)
		{
			_o.StateId = this.StateId;
			_o.RestartPos = ((this.RestartPos != null) ? this.RestartPos.Value.UnPack() : null);
		}

		// Token: 0x0602A233 RID: 172595 RVA: 0x005C0414 File Offset: 0x005BE614
		public static Offset<IUndergroundStateInfo> Pack(FlatBufferBuilder builder, IUndergroundStateInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUndergroundStateInfo>);
			}
			Offset<IVectorInfo> restartPosOffset = (_o.RestartPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RestartPos);
			return IUndergroundStateInfo.CreateIUndergroundStateInfo(builder, _o.StateId, restartPosOffset);
		}

		// Token: 0x0400FF08 RID: 65288
		private Table __p;
	}
}
