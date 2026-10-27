using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C9D RID: 19613
	public struct IPreQuestCondtion : IFlatbufferObject
	{
		// Token: 0x17008E68 RID: 36456
		// (get) Token: 0x0601F1C5 RID: 127429 RVA: 0x00458AB0 File Offset: 0x00456CB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1C6 RID: 127430 RVA: 0x00458ABD File Offset: 0x00456CBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1C7 RID: 127431 RVA: 0x00458AC4 File Offset: 0x00456CC4
		public static IPreQuestCondtion GetRootAsIPreQuestCondtion(ByteBuffer _bb)
		{
			return IPreQuestCondtion.GetRootAsIPreQuestCondtion(_bb, default(IPreQuestCondtion));
		}

		// Token: 0x0601F1C8 RID: 127432 RVA: 0x00458AE0 File Offset: 0x00456CE0
		public static IPreQuestCondtion GetRootAsIPreQuestCondtion(ByteBuffer _bb, IPreQuestCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1C9 RID: 127433 RVA: 0x00458AFD File Offset: 0x00456CFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1CA RID: 127434 RVA: 0x00458B0C File Offset: 0x00456D0C
		public IPreQuestCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E69 RID: 36457
		// (get) Token: 0x0601F1CB RID: 127435 RVA: 0x00458B1C File Offset: 0x00456D1C
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

		// Token: 0x17008E6A RID: 36458
		// (get) Token: 0x0601F1CC RID: 127436 RVA: 0x00458B58 File Offset: 0x00456D58
		public int PreQuest
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

		// Token: 0x0601F1CD RID: 127437 RVA: 0x00458B94 File Offset: 0x00456D94
		public static Offset<IPreQuestCondtion> CreateIPreQuestCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int PreQuest = 0)
		{
			builder.StartTable(2);
			IPreQuestCondtion.AddPreQuest(builder, PreQuest);
			IPreQuestCondtion.AddType(builder, Type);
			return IPreQuestCondtion.EndIPreQuestCondtion(builder);
		}

		// Token: 0x0601F1CE RID: 127438 RVA: 0x00458BB1 File Offset: 0x00456DB1
		public static void StartIPreQuestCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F1CF RID: 127439 RVA: 0x00458BBA File Offset: 0x00456DBA
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F1D0 RID: 127440 RVA: 0x00458BC5 File Offset: 0x00456DC5
		public static void AddPreQuest(FlatBufferBuilder builder, int preQuest)
		{
			builder.AddInt(1, preQuest, 0);
		}

		// Token: 0x0601F1D1 RID: 127441 RVA: 0x00458BD0 File Offset: 0x00456DD0
		public static Offset<IPreQuestCondtion> EndIPreQuestCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreQuestCondtion>(builder.EndTable());
		}

		// Token: 0x0601F1D2 RID: 127442 RVA: 0x00458BE0 File Offset: 0x00456DE0
		public IPreQuestCondtionT UnPack()
		{
			IPreQuestCondtionT preQuestCondtionT = new IPreQuestCondtionT();
			this.UnPackTo(preQuestCondtionT);
			return preQuestCondtionT;
		}

		// Token: 0x0601F1D3 RID: 127443 RVA: 0x00458BFB File Offset: 0x00456DFB
		public void UnPackTo(IPreQuestCondtionT _o)
		{
			_o.Type = this.Type;
			_o.PreQuest = this.PreQuest;
		}

		// Token: 0x0601F1D4 RID: 127444 RVA: 0x00458C18 File Offset: 0x00456E18
		public static Offset<IPreQuestCondtion> Pack(FlatBufferBuilder builder, IPreQuestCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreQuestCondtion>);
			}
			return IPreQuestCondtion.CreateIPreQuestCondtion(builder, _o.Type, _o.PreQuest);
		}

		// Token: 0x0400D658 RID: 54872
		private Table __p;
	}
}
