using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200518A RID: 20874
	public struct IPreChildQuestCondtion : IFlatbufferObject
	{
		// Token: 0x17009580 RID: 38272
		// (get) Token: 0x06020D8B RID: 134539 RVA: 0x0048BCE3 File Offset: 0x00489EE3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020D8C RID: 134540 RVA: 0x0048BCF0 File Offset: 0x00489EF0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020D8D RID: 134541 RVA: 0x0048BCF8 File Offset: 0x00489EF8
		public static IPreChildQuestCondtion GetRootAsIPreChildQuestCondtion(ByteBuffer _bb)
		{
			return IPreChildQuestCondtion.GetRootAsIPreChildQuestCondtion(_bb, default(IPreChildQuestCondtion));
		}

		// Token: 0x06020D8E RID: 134542 RVA: 0x0048BD14 File Offset: 0x00489F14
		public static IPreChildQuestCondtion GetRootAsIPreChildQuestCondtion(ByteBuffer _bb, IPreChildQuestCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020D8F RID: 134543 RVA: 0x0048BD31 File Offset: 0x00489F31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020D90 RID: 134544 RVA: 0x0048BD40 File Offset: 0x00489F40
		public IPreChildQuestCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009581 RID: 38273
		// (get) Token: 0x06020D91 RID: 134545 RVA: 0x0048BD50 File Offset: 0x00489F50
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

		// Token: 0x17009582 RID: 38274
		// (get) Token: 0x06020D92 RID: 134546 RVA: 0x0048BD8C File Offset: 0x00489F8C
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

		// Token: 0x06020D93 RID: 134547 RVA: 0x0048BDE9 File Offset: 0x00489FE9
		public static Offset<IPreChildQuestCondtion> CreateIPreChildQuestCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, Offset<IChildQuestCondition> PreChildQuestOffset = default(Offset<IChildQuestCondition>))
		{
			builder.StartTable(2);
			IPreChildQuestCondtion.AddPreChildQuest(builder, PreChildQuestOffset);
			IPreChildQuestCondtion.AddType(builder, Type);
			return IPreChildQuestCondtion.EndIPreChildQuestCondtion(builder);
		}

		// Token: 0x06020D94 RID: 134548 RVA: 0x0048BE06 File Offset: 0x0048A006
		public static void StartIPreChildQuestCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020D95 RID: 134549 RVA: 0x0048BE0F File Offset: 0x0048A00F
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020D96 RID: 134550 RVA: 0x0048BE1A File Offset: 0x0048A01A
		public static void AddPreChildQuest(FlatBufferBuilder builder, Offset<IChildQuestCondition> preChildQuestOffset)
		{
			builder.AddOffset(1, preChildQuestOffset.Value, 0);
		}

		// Token: 0x06020D97 RID: 134551 RVA: 0x0048BE2A File Offset: 0x0048A02A
		public static Offset<IPreChildQuestCondtion> EndIPreChildQuestCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreChildQuestCondtion>(builder.EndTable());
		}

		// Token: 0x06020D98 RID: 134552 RVA: 0x0048BE38 File Offset: 0x0048A038
		public IPreChildQuestCondtionT UnPack()
		{
			IPreChildQuestCondtionT preChildQuestCondtionT = new IPreChildQuestCondtionT();
			this.UnPackTo(preChildQuestCondtionT);
			return preChildQuestCondtionT;
		}

		// Token: 0x06020D99 RID: 134553 RVA: 0x0048BE54 File Offset: 0x0048A054
		public void UnPackTo(IPreChildQuestCondtionT _o)
		{
			_o.Type = this.Type;
			_o.PreChildQuest = ((this.PreChildQuest != null) ? this.PreChildQuest.Value.UnPack() : null);
		}

		// Token: 0x06020D9A RID: 134554 RVA: 0x0048BE9C File Offset: 0x0048A09C
		public static Offset<IPreChildQuestCondtion> Pack(FlatBufferBuilder builder, IPreChildQuestCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreChildQuestCondtion>);
			}
			Offset<IChildQuestCondition> preChildQuestOffset = (_o.PreChildQuest == null) ? default(Offset<IChildQuestCondition>) : IChildQuestCondition.Pack(builder, _o.PreChildQuest);
			return IPreChildQuestCondtion.CreateIPreChildQuestCondtion(builder, _o.Type, preChildQuestOffset);
		}

		// Token: 0x0400E172 RID: 57714
		private Table __p;
	}
}
