using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AFD RID: 31485
	public struct ITalkOptionConditionSolarSchool : IFlatbufferObject
	{
		// Token: 0x1700EBED RID: 60397
		// (get) Token: 0x06038B2B RID: 232235 RVA: 0x007ABB4C File Offset: 0x007A9D4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038B2C RID: 232236 RVA: 0x007ABB59 File Offset: 0x007A9D59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038B2D RID: 232237 RVA: 0x007ABB60 File Offset: 0x007A9D60
		public static ITalkOptionConditionSolarSchool GetRootAsITalkOptionConditionSolarSchool(ByteBuffer _bb)
		{
			return ITalkOptionConditionSolarSchool.GetRootAsITalkOptionConditionSolarSchool(_bb, default(ITalkOptionConditionSolarSchool));
		}

		// Token: 0x06038B2E RID: 232238 RVA: 0x007ABB7C File Offset: 0x007A9D7C
		public static ITalkOptionConditionSolarSchool GetRootAsITalkOptionConditionSolarSchool(ByteBuffer _bb, ITalkOptionConditionSolarSchool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038B2F RID: 232239 RVA: 0x007ABB99 File Offset: 0x007A9D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038B30 RID: 232240 RVA: 0x007ABBA8 File Offset: 0x007A9DA8
		public ITalkOptionConditionSolarSchool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EBEE RID: 60398
		// (get) Token: 0x06038B31 RID: 232241 RVA: 0x007ABBB8 File Offset: 0x007A9DB8
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

		// Token: 0x1700EBEF RID: 60399
		// (get) Token: 0x06038B32 RID: 232242 RVA: 0x007ABBF4 File Offset: 0x007A9DF4
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

		// Token: 0x06038B33 RID: 232243 RVA: 0x007ABC30 File Offset: 0x007A9E30
		public static Offset<ITalkOptionConditionSolarSchool> CreateITalkOptionConditionSolarSchool(FlatBufferBuilder builder, ETalkOptionConditionSystem Type = ETalkOptionConditionSystem.SolarSchool, int ConditionGroupId = 0)
		{
			builder.StartTable(2);
			ITalkOptionConditionSolarSchool.AddConditionGroupId(builder, ConditionGroupId);
			ITalkOptionConditionSolarSchool.AddType(builder, Type);
			return ITalkOptionConditionSolarSchool.EndITalkOptionConditionSolarSchool(builder);
		}

		// Token: 0x06038B34 RID: 232244 RVA: 0x007ABC4D File Offset: 0x007A9E4D
		public static void StartITalkOptionConditionSolarSchool(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038B35 RID: 232245 RVA: 0x007ABC56 File Offset: 0x007A9E56
		public static void AddType(FlatBufferBuilder builder, ETalkOptionConditionSystem type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038B36 RID: 232246 RVA: 0x007ABC61 File Offset: 0x007A9E61
		public static void AddConditionGroupId(FlatBufferBuilder builder, int conditionGroupId)
		{
			builder.AddInt(1, conditionGroupId, 0);
		}

		// Token: 0x06038B37 RID: 232247 RVA: 0x007ABC6C File Offset: 0x007A9E6C
		public static Offset<ITalkOptionConditionSolarSchool> EndITalkOptionConditionSolarSchool(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionConditionSolarSchool>(builder.EndTable());
		}

		// Token: 0x06038B38 RID: 232248 RVA: 0x007ABC7C File Offset: 0x007A9E7C
		public ITalkOptionConditionSolarSchoolT UnPack()
		{
			ITalkOptionConditionSolarSchoolT talkOptionConditionSolarSchoolT = new ITalkOptionConditionSolarSchoolT();
			this.UnPackTo(talkOptionConditionSolarSchoolT);
			return talkOptionConditionSolarSchoolT;
		}

		// Token: 0x06038B39 RID: 232249 RVA: 0x007ABC97 File Offset: 0x007A9E97
		public void UnPackTo(ITalkOptionConditionSolarSchoolT _o)
		{
			_o.Type = this.Type;
			_o.ConditionGroupId = this.ConditionGroupId;
		}

		// Token: 0x06038B3A RID: 232250 RVA: 0x007ABCB4 File Offset: 0x007A9EB4
		public static Offset<ITalkOptionConditionSolarSchool> Pack(FlatBufferBuilder builder, ITalkOptionConditionSolarSchoolT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionConditionSolarSchool>);
			}
			return ITalkOptionConditionSolarSchool.CreateITalkOptionConditionSolarSchool(builder, _o.Type, _o.ConditionGroupId);
		}

		// Token: 0x04013117 RID: 78103
		private Table __p;
	}
}
