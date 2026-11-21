using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D2 RID: 16850
	public struct IConditionTrackPos : IFlatbufferObject
	{
		// Token: 0x170072CF RID: 29391
		// (get) Token: 0x060175F6 RID: 95734 RVA: 0x00357721 File Offset: 0x00355921
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060175F7 RID: 95735 RVA: 0x0035772E File Offset: 0x0035592E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060175F8 RID: 95736 RVA: 0x00357738 File Offset: 0x00355938
		public static IConditionTrackPos GetRootAsIConditionTrackPos(ByteBuffer _bb)
		{
			return IConditionTrackPos.GetRootAsIConditionTrackPos(_bb, default(IConditionTrackPos));
		}

		// Token: 0x060175F9 RID: 95737 RVA: 0x00357754 File Offset: 0x00355954
		public static IConditionTrackPos GetRootAsIConditionTrackPos(ByteBuffer _bb, IConditionTrackPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060175FA RID: 95738 RVA: 0x00357771 File Offset: 0x00355971
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060175FB RID: 95739 RVA: 0x00357780 File Offset: 0x00355980
		public IConditionTrackPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072D0 RID: 29392
		// (get) Token: 0x060175FC RID: 95740 RVA: 0x00357790 File Offset: 0x00355990
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

		// Token: 0x170072D1 RID: 29393
		// (get) Token: 0x060175FD RID: 95741 RVA: 0x003577F0 File Offset: 0x003559F0
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

		// Token: 0x060175FE RID: 95742 RVA: 0x0035784D File Offset: 0x00355A4D
		public static Offset<IConditionTrackPos> CreateIConditionTrackPos(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IVectorInfo> TrackPosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IConditionTrackPos.AddTrackPos(builder, TrackPosOffset);
			IConditionTrackPos.AddCondition(builder, ConditionOffset);
			return IConditionTrackPos.EndIConditionTrackPos(builder);
		}

		// Token: 0x060175FF RID: 95743 RVA: 0x0035786A File Offset: 0x00355A6A
		public static void StartIConditionTrackPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017600 RID: 95744 RVA: 0x00357873 File Offset: 0x00355A73
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06017601 RID: 95745 RVA: 0x00357883 File Offset: 0x00355A83
		public static void AddTrackPos(FlatBufferBuilder builder, Offset<IVectorInfo> trackPosOffset)
		{
			builder.AddOffset(1, trackPosOffset.Value, 0);
		}

		// Token: 0x06017602 RID: 95746 RVA: 0x00357893 File Offset: 0x00355A93
		public static Offset<IConditionTrackPos> EndIConditionTrackPos(FlatBufferBuilder builder)
		{
			return new Offset<IConditionTrackPos>(builder.EndTable());
		}

		// Token: 0x06017603 RID: 95747 RVA: 0x003578A0 File Offset: 0x00355AA0
		public IConditionTrackPosT UnPack()
		{
			IConditionTrackPosT conditionTrackPosT = new IConditionTrackPosT();
			this.UnPackTo(conditionTrackPosT);
			return conditionTrackPosT;
		}

		// Token: 0x06017604 RID: 95748 RVA: 0x003578BC File Offset: 0x00355ABC
		public void UnPackTo(IConditionTrackPosT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.TrackPos = ((this.TrackPos != null) ? this.TrackPos.Value.UnPack() : null);
		}

		// Token: 0x06017605 RID: 95749 RVA: 0x00357928 File Offset: 0x00355B28
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

		// Token: 0x0400C0A8 RID: 49320
		private Table __p;
	}
}
