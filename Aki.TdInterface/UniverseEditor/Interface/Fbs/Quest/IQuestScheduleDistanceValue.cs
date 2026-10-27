using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200401F RID: 16415
	public struct IQuestScheduleDistanceValue : IFlatbufferObject
	{
		// Token: 0x17007371 RID: 29553
		// (get) Token: 0x06017B7F RID: 97151 RVA: 0x0036BE46 File Offset: 0x0036A046
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B80 RID: 97152 RVA: 0x0036BE53 File Offset: 0x0036A053
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B81 RID: 97153 RVA: 0x0036BE5C File Offset: 0x0036A05C
		public static IQuestScheduleDistanceValue GetRootAsIQuestScheduleDistanceValue(ByteBuffer _bb)
		{
			return IQuestScheduleDistanceValue.GetRootAsIQuestScheduleDistanceValue(_bb, default(IQuestScheduleDistanceValue));
		}

		// Token: 0x06017B82 RID: 97154 RVA: 0x0036BE78 File Offset: 0x0036A078
		public static IQuestScheduleDistanceValue GetRootAsIQuestScheduleDistanceValue(ByteBuffer _bb, IQuestScheduleDistanceValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B83 RID: 97155 RVA: 0x0036BE95 File Offset: 0x0036A095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B84 RID: 97156 RVA: 0x0036BEA4 File Offset: 0x0036A0A4
		public IQuestScheduleDistanceValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007372 RID: 29554
		// (get) Token: 0x06017B85 RID: 97157 RVA: 0x0036BEB4 File Offset: 0x0036A0B4
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007373 RID: 29555
		// (get) Token: 0x06017B86 RID: 97158 RVA: 0x0036BEF0 File Offset: 0x0036A0F0
		public Aki.UniverseEditor.Interface.Fbs.Action.IPosA? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new Aki.UniverseEditor.Interface.Fbs.Action.IPosA?(default(Aki.UniverseEditor.Interface.Fbs.Action.IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007374 RID: 29556
		// (get) Token: 0x06017B87 RID: 97159 RVA: 0x0036BF50 File Offset: 0x0036A150
		public EDistanceMeasureMode DistanceMeasureMode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EDistanceMeasureMode.Horizontal;
				}
				return (EDistanceMeasureMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017B88 RID: 97160 RVA: 0x0036BF8C File Offset: 0x0036A18C
		public static Offset<IQuestScheduleDistanceValue> CreateIQuestScheduleDistanceValue(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> PosOffset = default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>), EDistanceMeasureMode DistanceMeasureMode = EDistanceMeasureMode.Horizontal)
		{
			builder.StartTable(3);
			IQuestScheduleDistanceValue.AddPos(builder, PosOffset);
			IQuestScheduleDistanceValue.AddDistanceMeasureMode(builder, DistanceMeasureMode);
			IQuestScheduleDistanceValue.AddType(builder, Type);
			return IQuestScheduleDistanceValue.EndIQuestScheduleDistanceValue(builder);
		}

		// Token: 0x06017B89 RID: 97161 RVA: 0x0036BFB0 File Offset: 0x0036A1B0
		public static void StartIQuestScheduleDistanceValue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017B8A RID: 97162 RVA: 0x0036BFB9 File Offset: 0x0036A1B9
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B8B RID: 97163 RVA: 0x0036BFC4 File Offset: 0x0036A1C4
		public static void AddPos(FlatBufferBuilder builder, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06017B8C RID: 97164 RVA: 0x0036BFD4 File Offset: 0x0036A1D4
		public static void AddDistanceMeasureMode(FlatBufferBuilder builder, EDistanceMeasureMode distanceMeasureMode)
		{
			builder.AddByte(2, (byte)distanceMeasureMode, 0);
		}

		// Token: 0x06017B8D RID: 97165 RVA: 0x0036BFDF File Offset: 0x0036A1DF
		public static Offset<IQuestScheduleDistanceValue> EndIQuestScheduleDistanceValue(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleDistanceValue>(builder.EndTable());
		}

		// Token: 0x06017B8E RID: 97166 RVA: 0x0036BFEC File Offset: 0x0036A1EC
		public IQuestScheduleDistanceValueT UnPack()
		{
			IQuestScheduleDistanceValueT questScheduleDistanceValueT = new IQuestScheduleDistanceValueT();
			this.UnPackTo(questScheduleDistanceValueT);
			return questScheduleDistanceValueT;
		}

		// Token: 0x06017B8F RID: 97167 RVA: 0x0036C008 File Offset: 0x0036A208
		public void UnPackTo(IQuestScheduleDistanceValueT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.DistanceMeasureMode = this.DistanceMeasureMode;
		}

		// Token: 0x06017B90 RID: 97168 RVA: 0x0036C05C File Offset: 0x0036A25C
		public static Offset<IQuestScheduleDistanceValue> Pack(FlatBufferBuilder builder, IQuestScheduleDistanceValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleDistanceValue>);
			}
			Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> posOffset = (_o.Pos == null) ? default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>) : Aki.UniverseEditor.Interface.Fbs.Action.IPosA.Pack(builder, _o.Pos);
			return IQuestScheduleDistanceValue.CreateIQuestScheduleDistanceValue(builder, _o.Type, posOffset, _o.DistanceMeasureMode);
		}

		// Token: 0x0400BB47 RID: 47943
		private Table __p;
	}
}
