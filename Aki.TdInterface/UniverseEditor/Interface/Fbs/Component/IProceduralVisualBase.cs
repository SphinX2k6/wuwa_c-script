using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D97 RID: 23959
	public struct IProceduralVisualBase : IFlatbufferObject
	{
		// Token: 0x1700B052 RID: 45138
		// (get) Token: 0x06027E65 RID: 163429 RVA: 0x0057504A File Offset: 0x0057324A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E66 RID: 163430 RVA: 0x00575057 File Offset: 0x00573257
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E67 RID: 163431 RVA: 0x00575060 File Offset: 0x00573260
		public static IProceduralVisualBase GetRootAsIProceduralVisualBase(ByteBuffer _bb)
		{
			return IProceduralVisualBase.GetRootAsIProceduralVisualBase(_bb, default(IProceduralVisualBase));
		}

		// Token: 0x06027E68 RID: 163432 RVA: 0x0057507C File Offset: 0x0057327C
		public static IProceduralVisualBase GetRootAsIProceduralVisualBase(ByteBuffer _bb, IProceduralVisualBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E69 RID: 163433 RVA: 0x00575099 File Offset: 0x00573299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E6A RID: 163434 RVA: 0x005750A8 File Offset: 0x005732A8
		public IProceduralVisualBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B053 RID: 45139
		// (get) Token: 0x06027E6B RID: 163435 RVA: 0x005750B8 File Offset: 0x005732B8
		public EProceduralVisualType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProceduralVisualType.LookAt;
				}
				return (EProceduralVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B054 RID: 45140
		// (get) Token: 0x06027E6C RID: 163436 RVA: 0x005750F4 File Offset: 0x005732F4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027E6D RID: 163437 RVA: 0x00575151 File Offset: 0x00573351
		public static Offset<IProceduralVisualBase> CreateIProceduralVisualBase(FlatBufferBuilder builder, EProceduralVisualType Type = EProceduralVisualType.LookAt, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IProceduralVisualBase.AddCondition(builder, ConditionOffset);
			IProceduralVisualBase.AddType(builder, Type);
			return IProceduralVisualBase.EndIProceduralVisualBase(builder);
		}

		// Token: 0x06027E6E RID: 163438 RVA: 0x0057516E File Offset: 0x0057336E
		public static void StartIProceduralVisualBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027E6F RID: 163439 RVA: 0x00575177 File Offset: 0x00573377
		public static void AddType(FlatBufferBuilder builder, EProceduralVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027E70 RID: 163440 RVA: 0x00575182 File Offset: 0x00573382
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06027E71 RID: 163441 RVA: 0x00575192 File Offset: 0x00573392
		public static Offset<IProceduralVisualBase> EndIProceduralVisualBase(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralVisualBase>(builder.EndTable());
		}

		// Token: 0x06027E72 RID: 163442 RVA: 0x005751A0 File Offset: 0x005733A0
		public IProceduralVisualBaseT UnPack()
		{
			IProceduralVisualBaseT proceduralVisualBaseT = new IProceduralVisualBaseT();
			this.UnPackTo(proceduralVisualBaseT);
			return proceduralVisualBaseT;
		}

		// Token: 0x06027E73 RID: 163443 RVA: 0x005751BC File Offset: 0x005733BC
		public void UnPackTo(IProceduralVisualBaseT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06027E74 RID: 163444 RVA: 0x00575204 File Offset: 0x00573404
		public static Offset<IProceduralVisualBase> Pack(FlatBufferBuilder builder, IProceduralVisualBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralVisualBase>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IProceduralVisualBase.CreateIProceduralVisualBase(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400F92C RID: 63788
		private Table __p;
	}
}
