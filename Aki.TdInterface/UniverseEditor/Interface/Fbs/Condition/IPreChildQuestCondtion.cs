using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C91 RID: 19601
	public struct IPreChildQuestCondtion : IFlatbufferObject
	{
		// Token: 0x17008E52 RID: 36434
		// (get) Token: 0x0601F169 RID: 127337 RVA: 0x00458193 File Offset: 0x00456393
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F16A RID: 127338 RVA: 0x004581A0 File Offset: 0x004563A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F16B RID: 127339 RVA: 0x004581A8 File Offset: 0x004563A8
		public static IPreChildQuestCondtion GetRootAsIPreChildQuestCondtion(ByteBuffer _bb)
		{
			return IPreChildQuestCondtion.GetRootAsIPreChildQuestCondtion(_bb, default(IPreChildQuestCondtion));
		}

		// Token: 0x0601F16C RID: 127340 RVA: 0x004581C4 File Offset: 0x004563C4
		public static IPreChildQuestCondtion GetRootAsIPreChildQuestCondtion(ByteBuffer _bb, IPreChildQuestCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F16D RID: 127341 RVA: 0x004581E1 File Offset: 0x004563E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F16E RID: 127342 RVA: 0x004581F0 File Offset: 0x004563F0
		public IPreChildQuestCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E53 RID: 36435
		// (get) Token: 0x0601F16F RID: 127343 RVA: 0x00458200 File Offset: 0x00456400
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E54 RID: 36436
		// (get) Token: 0x0601F170 RID: 127344 RVA: 0x0045823C File Offset: 0x0045643C
		public IChildQuestCondition? PreChildQuest
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IChildQuestCondition?(default(IChildQuestCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F171 RID: 127345 RVA: 0x00458299 File Offset: 0x00456499
		public static Offset<IPreChildQuestCondtion> CreateIPreChildQuestCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, Offset<IChildQuestCondition> PreChildQuestOffset = default(Offset<IChildQuestCondition>))
		{
			builder.StartTable(2);
			IPreChildQuestCondtion.AddPreChildQuest(builder, PreChildQuestOffset);
			IPreChildQuestCondtion.AddType(builder, Type);
			return IPreChildQuestCondtion.EndIPreChildQuestCondtion(builder);
		}

		// Token: 0x0601F172 RID: 127346 RVA: 0x004582B6 File Offset: 0x004564B6
		public static void StartIPreChildQuestCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F173 RID: 127347 RVA: 0x004582BF File Offset: 0x004564BF
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F174 RID: 127348 RVA: 0x004582CA File Offset: 0x004564CA
		public static void AddPreChildQuest(FlatBufferBuilder builder, Offset<IChildQuestCondition> preChildQuestOffset)
		{
			builder.AddOffset(1, preChildQuestOffset.Value, 0);
		}

		// Token: 0x0601F175 RID: 127349 RVA: 0x004582DA File Offset: 0x004564DA
		public static Offset<IPreChildQuestCondtion> EndIPreChildQuestCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreChildQuestCondtion>(builder.EndTable());
		}

		// Token: 0x0601F176 RID: 127350 RVA: 0x004582E8 File Offset: 0x004564E8
		public IPreChildQuestCondtionT UnPack()
		{
			IPreChildQuestCondtionT preChildQuestCondtionT = new IPreChildQuestCondtionT();
			this.UnPackTo(preChildQuestCondtionT);
			return preChildQuestCondtionT;
		}

		// Token: 0x0601F177 RID: 127351 RVA: 0x00458304 File Offset: 0x00456504
		public void UnPackTo(IPreChildQuestCondtionT _o)
		{
			_o.Type = this.Type;
			_o.PreChildQuest = ((this.PreChildQuest != null) ? this.PreChildQuest.Value.UnPack() : null);
		}

		// Token: 0x0601F178 RID: 127352 RVA: 0x0045834C File Offset: 0x0045654C
		public static Offset<IPreChildQuestCondtion> Pack(FlatBufferBuilder builder, IPreChildQuestCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreChildQuestCondtion>);
			}
			Offset<IChildQuestCondition> preChildQuestOffset = (_o.PreChildQuest == null) ? default(Offset<IChildQuestCondition>) : IChildQuestCondition.Pack(builder, _o.PreChildQuest);
			return IPreChildQuestCondtion.CreateIPreChildQuestCondtion(builder, _o.Type, preChildQuestOffset);
		}

		// Token: 0x0400D64B RID: 54859
		private Table __p;
	}
}
