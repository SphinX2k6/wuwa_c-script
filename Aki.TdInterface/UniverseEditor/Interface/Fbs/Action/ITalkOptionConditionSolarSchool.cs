using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007325 RID: 29477
	public struct ITalkOptionConditionSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700DFF1 RID: 57329
		// (get) Token: 0x060357F8 RID: 219128 RVA: 0x00749FC4 File Offset: 0x007481C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060357F9 RID: 219129 RVA: 0x00749FD1 File Offset: 0x007481D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060357FA RID: 219130 RVA: 0x00749FD8 File Offset: 0x007481D8
		public static ITalkOptionConditionSolarSchool GetRootAsITalkOptionConditionSolarSchool(ByteBuffer _bb)
		{
			return ITalkOptionConditionSolarSchool.GetRootAsITalkOptionConditionSolarSchool(_bb, default(ITalkOptionConditionSolarSchool));
		}

		// Token: 0x060357FB RID: 219131 RVA: 0x00749FF4 File Offset: 0x007481F4
		public static ITalkOptionConditionSolarSchool GetRootAsITalkOptionConditionSolarSchool(ByteBuffer _bb, ITalkOptionConditionSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060357FC RID: 219132 RVA: 0x0074A011 File Offset: 0x00748211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060357FD RID: 219133 RVA: 0x0074A020 File Offset: 0x00748220
		public ITalkOptionConditionSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFF2 RID: 57330
		// (get) Token: 0x060357FE RID: 219134 RVA: 0x0074A030 File Offset: 0x00748230
		public ETalkOptionConditionSystem Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionConditionSystem.SolarSchool;
				}
				return (ETalkOptionConditionSystem)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFF3 RID: 57331
		// (get) Token: 0x060357FF RID: 219135 RVA: 0x0074A06C File Offset: 0x0074826C
		public int ConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035800 RID: 219136 RVA: 0x0074A0A8 File Offset: 0x007482A8
		public static Offset<ITalkOptionConditionSolarSchool> CreateITalkOptionConditionSolarSchool(FlatBufferBuilder builder, ETalkOptionConditionSystem Type = ETalkOptionConditionSystem.SolarSchool, int ConditionGroupId = 0)
		{
			builder.StartTable(2);
			ITalkOptionConditionSolarSchool.AddConditionGroupId(builder, ConditionGroupId);
			ITalkOptionConditionSolarSchool.AddType(builder, Type);
			return ITalkOptionConditionSolarSchool.EndITalkOptionConditionSolarSchool(builder);
		}

		// Token: 0x06035801 RID: 219137 RVA: 0x0074A0C5 File Offset: 0x007482C5
		public static void StartITalkOptionConditionSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035802 RID: 219138 RVA: 0x0074A0CE File Offset: 0x007482CE
		public static void AddType(FlatBufferBuilder builder, ETalkOptionConditionSystem type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035803 RID: 219139 RVA: 0x0074A0D9 File Offset: 0x007482D9
		public static void AddConditionGroupId(FlatBufferBuilder builder, int conditionGroupId)
		{
			builder.AddInt(1, conditionGroupId, 0);
		}

		// Token: 0x06035804 RID: 219140 RVA: 0x0074A0E4 File Offset: 0x007482E4
		public static Offset<ITalkOptionConditionSolarSchool> EndITalkOptionConditionSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionConditionSolarSchool>(builder.EndTable());
		}

		// Token: 0x06035805 RID: 219141 RVA: 0x0074A0F4 File Offset: 0x007482F4
		public ITalkOptionConditionSolarSchoolT UnPack()
		{
			ITalkOptionConditionSolarSchoolT talkOptionConditionSolarSchoolT = new ITalkOptionConditionSolarSchoolT();
			this.UnPackTo(talkOptionConditionSolarSchoolT);
			return talkOptionConditionSolarSchoolT;
		}

		// Token: 0x06035806 RID: 219142 RVA: 0x0074A10F File Offset: 0x0074830F
		public void UnPackTo(ITalkOptionConditionSolarSchoolT _o)
		{
			_o.Type = this.Type;
			_o.ConditionGroupId = this.ConditionGroupId;
		}

		// Token: 0x06035807 RID: 219143 RVA: 0x0074A12C File Offset: 0x0074832C
		public static Offset<ITalkOptionConditionSolarSchool> Pack(FlatBufferBuilder builder, ITalkOptionConditionSolarSchoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionConditionSolarSchool>);
			}
			return ITalkOptionConditionSolarSchool.CreateITalkOptionConditionSolarSchool(builder, _o.Type, _o.ConditionGroupId);
		}

		// Token: 0x04012111 RID: 74001
		private Table __p;
	}
}
