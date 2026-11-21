using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B00 RID: 31488
	public struct ITalkOptionConditionSystemConfigBase : IFlatbufferObject
	{
		// Token: 0x1700EBF2 RID: 60402
		// (get) Token: 0x06038B41 RID: 232257 RVA: 0x007ABD4A File Offset: 0x007A9F4A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038B42 RID: 232258 RVA: 0x007ABD57 File Offset: 0x007A9F57
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038B43 RID: 232259 RVA: 0x007ABD60 File Offset: 0x007A9F60
		public static ITalkOptionConditionSystemConfigBase GetRootAsITalkOptionConditionSystemConfigBase(ByteBuffer _bb)
		{
			return ITalkOptionConditionSystemConfigBase.GetRootAsITalkOptionConditionSystemConfigBase(_bb, default(ITalkOptionConditionSystemConfigBase));
		}

		// Token: 0x06038B44 RID: 232260 RVA: 0x007ABD7C File Offset: 0x007A9F7C
		public static ITalkOptionConditionSystemConfigBase GetRootAsITalkOptionConditionSystemConfigBase(ByteBuffer _bb, ITalkOptionConditionSystemConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038B45 RID: 232261 RVA: 0x007ABD99 File Offset: 0x007A9F99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038B46 RID: 232262 RVA: 0x007ABDA8 File Offset: 0x007A9FA8
		public ITalkOptionConditionSystemConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EBF3 RID: 60403
		// (get) Token: 0x06038B47 RID: 232263 RVA: 0x007ABDB8 File Offset: 0x007A9FB8
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

		// Token: 0x06038B48 RID: 232264 RVA: 0x007ABDF4 File Offset: 0x007A9FF4
		public static Offset<ITalkOptionConditionSystemConfigBase> CreateITalkOptionConditionSystemConfigBase(FlatBufferBuilder builder, ETalkOptionConditionSystem Type = ETalkOptionConditionSystem.SolarSchool)
		{
			builder.StartTable(1);
			ITalkOptionConditionSystemConfigBase.AddType(builder, Type);
			return ITalkOptionConditionSystemConfigBase.EndITalkOptionConditionSystemConfigBase(builder);
		}

		// Token: 0x06038B49 RID: 232265 RVA: 0x007ABE0A File Offset: 0x007AA00A
		public static void StartITalkOptionConditionSystemConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038B4A RID: 232266 RVA: 0x007ABE13 File Offset: 0x007AA013
		public static void AddType(FlatBufferBuilder builder, ETalkOptionConditionSystem type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038B4B RID: 232267 RVA: 0x007ABE1E File Offset: 0x007AA01E
		public static Offset<ITalkOptionConditionSystemConfigBase> EndITalkOptionConditionSystemConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionConditionSystemConfigBase>(builder.EndTable());
		}

		// Token: 0x06038B4C RID: 232268 RVA: 0x007ABE2C File Offset: 0x007AA02C
		public ITalkOptionConditionSystemConfigBaseT UnPack()
		{
			ITalkOptionConditionSystemConfigBaseT talkOptionConditionSystemConfigBaseT = new ITalkOptionConditionSystemConfigBaseT();
			this.UnPackTo(talkOptionConditionSystemConfigBaseT);
			return talkOptionConditionSystemConfigBaseT;
		}

		// Token: 0x06038B4D RID: 232269 RVA: 0x007ABE47 File Offset: 0x007AA047
		public void UnPackTo(ITalkOptionConditionSystemConfigBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038B4E RID: 232270 RVA: 0x007ABE58 File Offset: 0x007AA058
		public static Offset<ITalkOptionConditionSystemConfigBase> Pack(FlatBufferBuilder builder, ITalkOptionConditionSystemConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionConditionSystemConfigBase>);
			}
			return ITalkOptionConditionSystemConfigBase.CreateITalkOptionConditionSystemConfigBase(builder, _o.Type);
		}

		// Token: 0x0401311A RID: 78106
		private Table __p;
	}
}
