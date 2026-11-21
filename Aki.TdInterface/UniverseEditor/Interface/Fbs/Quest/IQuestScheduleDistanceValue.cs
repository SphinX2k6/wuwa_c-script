using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004460 RID: 17504
	public struct IQuestScheduleDistanceValue : IFlatbufferObject
	{
		// Token: 0x17007973 RID: 31091
		// (get) Token: 0x06019218 RID: 102936 RVA: 0x00395C3A File Offset: 0x00393E3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019219 RID: 102937 RVA: 0x00395C47 File Offset: 0x00393E47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601921A RID: 102938 RVA: 0x00395C50 File Offset: 0x00393E50
		public static IQuestScheduleDistanceValue GetRootAsIQuestScheduleDistanceValue(ByteBuffer _bb)
		{
			return IQuestScheduleDistanceValue.GetRootAsIQuestScheduleDistanceValue(_bb, default(IQuestScheduleDistanceValue));
		}

		// Token: 0x0601921B RID: 102939 RVA: 0x00395C6C File Offset: 0x00393E6C
		public static IQuestScheduleDistanceValue GetRootAsIQuestScheduleDistanceValue(ByteBuffer _bb, IQuestScheduleDistanceValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601921C RID: 102940 RVA: 0x00395C89 File Offset: 0x00393E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601921D RID: 102941 RVA: 0x00395C98 File Offset: 0x00393E98
		public IQuestScheduleDistanceValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007974 RID: 31092
		// (get) Token: 0x0601921E RID: 102942 RVA: 0x00395CA8 File Offset: 0x00393EA8
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

		// Token: 0x17007975 RID: 31093
		// (get) Token: 0x0601921F RID: 102943 RVA: 0x00395CE4 File Offset: 0x00393EE4
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

		// Token: 0x17007976 RID: 31094
		// (get) Token: 0x06019220 RID: 102944 RVA: 0x00395D44 File Offset: 0x00393F44
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

		// Token: 0x06019221 RID: 102945 RVA: 0x00395D80 File Offset: 0x00393F80
		public static Offset<IQuestScheduleDistanceValue> CreateIQuestScheduleDistanceValue(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> PosOffset = default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>), EDistanceMeasureMode DistanceMeasureMode = EDistanceMeasureMode.Horizontal)
		{
			builder.StartTable(3);
			IQuestScheduleDistanceValue.AddPos(builder, PosOffset);
			IQuestScheduleDistanceValue.AddDistanceMeasureMode(builder, DistanceMeasureMode);
			IQuestScheduleDistanceValue.AddType(builder, Type);
			return IQuestScheduleDistanceValue.EndIQuestScheduleDistanceValue(builder);
		}

		// Token: 0x06019222 RID: 102946 RVA: 0x00395DA4 File Offset: 0x00393FA4
		public static void StartIQuestScheduleDistanceValue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019223 RID: 102947 RVA: 0x00395DAD File Offset: 0x00393FAD
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019224 RID: 102948 RVA: 0x00395DB8 File Offset: 0x00393FB8
		public static void AddPos(FlatBufferBuilder builder, Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06019225 RID: 102949 RVA: 0x00395DC8 File Offset: 0x00393FC8
		public static void AddDistanceMeasureMode(FlatBufferBuilder builder, EDistanceMeasureMode distanceMeasureMode)
		{
			builder.AddByte(2, (byte)distanceMeasureMode, 0);
		}

		// Token: 0x06019226 RID: 102950 RVA: 0x00395DD3 File Offset: 0x00393FD3
		public static Offset<IQuestScheduleDistanceValue> EndIQuestScheduleDistanceValue(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleDistanceValue>(builder.EndTable());
		}

		// Token: 0x06019227 RID: 102951 RVA: 0x00395DE0 File Offset: 0x00393FE0
		public IQuestScheduleDistanceValueT UnPack()
		{
			IQuestScheduleDistanceValueT questScheduleDistanceValueT = new IQuestScheduleDistanceValueT();
			this.UnPackTo(questScheduleDistanceValueT);
			return questScheduleDistanceValueT;
		}

		// Token: 0x06019228 RID: 102952 RVA: 0x00395DFC File Offset: 0x00393FFC
		public void UnPackTo(IQuestScheduleDistanceValueT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.DistanceMeasureMode = this.DistanceMeasureMode;
		}

		// Token: 0x06019229 RID: 102953 RVA: 0x00395E50 File Offset: 0x00394050
		public static Offset<IQuestScheduleDistanceValue> Pack(FlatBufferBuilder builder, IQuestScheduleDistanceValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleDistanceValue>);
			}
			Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA> posOffset = (_o.Pos == null) ? default(Offset<Aki.UniverseEditor.Interface.Fbs.Action.IPosA>) : Aki.UniverseEditor.Interface.Fbs.Action.IPosA.Pack(builder, _o.Pos);
			return IQuestScheduleDistanceValue.CreateIQuestScheduleDistanceValue(builder, _o.Type, posOffset, _o.DistanceMeasureMode);
		}

		// Token: 0x0400C52E RID: 50478
		private Table __p;
	}
}
