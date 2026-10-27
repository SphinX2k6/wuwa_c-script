using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DBB RID: 15803
	public struct IConditionTrackPos : IFlatbufferObject
	{
		// Token: 0x17006D15 RID: 27925
		// (get) Token: 0x060160BD RID: 90301 RVA: 0x00330399 File Offset: 0x0032E599
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060160BE RID: 90302 RVA: 0x003303A6 File Offset: 0x0032E5A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060160BF RID: 90303 RVA: 0x003303B0 File Offset: 0x0032E5B0
		public static IConditionTrackPos GetRootAsIConditionTrackPos(ByteBuffer _bb)
		{
			return IConditionTrackPos.GetRootAsIConditionTrackPos(_bb, default(IConditionTrackPos));
		}

		// Token: 0x060160C0 RID: 90304 RVA: 0x003303CC File Offset: 0x0032E5CC
		public static IConditionTrackPos GetRootAsIConditionTrackPos(ByteBuffer _bb, IConditionTrackPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060160C1 RID: 90305 RVA: 0x003303E9 File Offset: 0x0032E5E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060160C2 RID: 90306 RVA: 0x003303F8 File Offset: 0x0032E5F8
		public IConditionTrackPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D16 RID: 27926
		// (get) Token: 0x060160C3 RID: 90307 RVA: 0x00330408 File Offset: 0x0032E608
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006D17 RID: 27927
		// (get) Token: 0x060160C4 RID: 90308 RVA: 0x00330468 File Offset: 0x0032E668
		public IVectorInfo? TrackPos
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

		// Token: 0x060160C5 RID: 90309 RVA: 0x003304C5 File Offset: 0x0032E6C5
		public static Offset<IConditionTrackPos> CreateIConditionTrackPos(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IVectorInfo> TrackPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IConditionTrackPos.AddTrackPos(builder, TrackPosOffset);
			IConditionTrackPos.AddCondition(builder, ConditionOffset);
			return IConditionTrackPos.EndIConditionTrackPos(builder);
		}

		// Token: 0x060160C6 RID: 90310 RVA: 0x003304E2 File Offset: 0x0032E6E2
		public static void StartIConditionTrackPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060160C7 RID: 90311 RVA: 0x003304EB File Offset: 0x0032E6EB
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060160C8 RID: 90312 RVA: 0x003304FB File Offset: 0x0032E6FB
		public static void AddTrackPos(FlatBufferBuilder builder, Offset<IVectorInfo> trackPosOffset)
		{
			builder.AddOffset(1, trackPosOffset.Value, 0);
		}

		// Token: 0x060160C9 RID: 90313 RVA: 0x0033050B File Offset: 0x0032E70B
		public static Offset<IConditionTrackPos> EndIConditionTrackPos(FlatBufferBuilder builder)
		{
			return new Offset<IConditionTrackPos>(builder.EndTable());
		}

		// Token: 0x060160CA RID: 90314 RVA: 0x00330518 File Offset: 0x0032E718
		public IConditionTrackPosT UnPack()
		{
			IConditionTrackPosT conditionTrackPosT = new IConditionTrackPosT();
			this.UnPackTo(conditionTrackPosT);
			return conditionTrackPosT;
		}

		// Token: 0x060160CB RID: 90315 RVA: 0x00330534 File Offset: 0x0032E734
		public void UnPackTo(IConditionTrackPosT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.TrackPos = ((this.TrackPos != null) ? this.TrackPos.Value.UnPack() : null);
		}

		// Token: 0x060160CC RID: 90316 RVA: 0x003305A0 File Offset: 0x0032E7A0
		public static Offset<IConditionTrackPos> Pack(FlatBufferBuilder builder, IConditionTrackPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionTrackPos>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<IVectorInfo> trackPosOffset = (_o.TrackPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TrackPos);
			return IConditionTrackPos.CreateIConditionTrackPos(builder, conditionOffset, trackPosOffset);
		}

		// Token: 0x0400B6FB RID: 46843
		private Table __p;
	}
}
