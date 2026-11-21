using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F71 RID: 20337
	public struct ICheckIsTrackingCurrentQuest : IFlatbufferObject
	{
		// Token: 0x17009163 RID: 37219
		// (get) Token: 0x0601FA8F RID: 129679 RVA: 0x00466FB7 File Offset: 0x004651B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA90 RID: 129680 RVA: 0x00466FC4 File Offset: 0x004651C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA91 RID: 129681 RVA: 0x00466FCC File Offset: 0x004651CC
		public static ICheckIsTrackingCurrentQuest GetRootAsICheckIsTrackingCurrentQuest(ByteBuffer _bb)
		{
			return ICheckIsTrackingCurrentQuest.GetRootAsICheckIsTrackingCurrentQuest(_bb, default(ICheckIsTrackingCurrentQuest));
		}

		// Token: 0x0601FA92 RID: 129682 RVA: 0x00466FE8 File Offset: 0x004651E8
		public static ICheckIsTrackingCurrentQuest GetRootAsICheckIsTrackingCurrentQuest(ByteBuffer _bb, ICheckIsTrackingCurrentQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA93 RID: 129683 RVA: 0x00467005 File Offset: 0x00465205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA94 RID: 129684 RVA: 0x00467014 File Offset: 0x00465214
		public ICheckIsTrackingCurrentQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009164 RID: 37220
		// (get) Token: 0x0601FA95 RID: 129685 RVA: 0x00467024 File Offset: 0x00465224
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA96 RID: 129686 RVA: 0x00467060 File Offset: 0x00465260
		public static Offset<ICheckIsTrackingCurrentQuest> CreateICheckIsTrackingCurrentQuest(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar)
		{
			builder.StartTable(1);
			ICheckIsTrackingCurrentQuest.AddType(builder, Type);
			return ICheckIsTrackingCurrentQuest.EndICheckIsTrackingCurrentQuest(builder);
		}

		// Token: 0x0601FA97 RID: 129687 RVA: 0x00467076 File Offset: 0x00465276
		public static void StartICheckIsTrackingCurrentQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FA98 RID: 129688 RVA: 0x0046707F File Offset: 0x0046527F
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA99 RID: 129689 RVA: 0x0046708A File Offset: 0x0046528A
		public static Offset<ICheckIsTrackingCurrentQuest> EndICheckIsTrackingCurrentQuest(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsTrackingCurrentQuest>(builder.EndTable());
		}

		// Token: 0x0601FA9A RID: 129690 RVA: 0x00467098 File Offset: 0x00465298
		public ICheckIsTrackingCurrentQuestT UnPack()
		{
			ICheckIsTrackingCurrentQuestT checkIsTrackingCurrentQuestT = new ICheckIsTrackingCurrentQuestT();
			this.UnPackTo(checkIsTrackingCurrentQuestT);
			return checkIsTrackingCurrentQuestT;
		}

		// Token: 0x0601FA9B RID: 129691 RVA: 0x004670B3 File Offset: 0x004652B3
		public void UnPackTo(ICheckIsTrackingCurrentQuestT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FA9C RID: 129692 RVA: 0x004670C4 File Offset: 0x004652C4
		public static Offset<ICheckIsTrackingCurrentQuest> Pack(FlatBufferBuilder builder, ICheckIsTrackingCurrentQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsTrackingCurrentQuest>);
			}
			return ICheckIsTrackingCurrentQuest.CreateICheckIsTrackingCurrentQuest(builder, _o.Type);
		}

		// Token: 0x0400DDFE RID: 56830
		private Table __p;
	}
}
