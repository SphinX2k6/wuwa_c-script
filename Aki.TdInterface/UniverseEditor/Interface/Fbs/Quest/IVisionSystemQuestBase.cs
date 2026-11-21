using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046CA RID: 18122
	public struct IVisionSystemQuestBase : IFlatbufferObject
	{
		// Token: 0x17007EEA RID: 32490
		// (get) Token: 0x0601AA1F RID: 109087 RVA: 0x003C9632 File Offset: 0x003C7832
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA20 RID: 109088 RVA: 0x003C963F File Offset: 0x003C783F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA21 RID: 109089 RVA: 0x003C9648 File Offset: 0x003C7848
		public static IVisionSystemQuestBase GetRootAsIVisionSystemQuestBase(ByteBuffer _bb)
		{
			return IVisionSystemQuestBase.GetRootAsIVisionSystemQuestBase(_bb, default(IVisionSystemQuestBase));
		}

		// Token: 0x0601AA22 RID: 109090 RVA: 0x003C9664 File Offset: 0x003C7864
		public static IVisionSystemQuestBase GetRootAsIVisionSystemQuestBase(ByteBuffer _bb, IVisionSystemQuestBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA23 RID: 109091 RVA: 0x003C9681 File Offset: 0x003C7881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA24 RID: 109092 RVA: 0x003C9690 File Offset: 0x003C7890
		public IVisionSystemQuestBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EEB RID: 32491
		// (get) Token: 0x0601AA25 RID: 109093 RVA: 0x003C96A0 File Offset: 0x003C78A0
		public EVisionSystemQuestType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisionSystemQuestType.HasVisionGetTargetLevel;
				}
				return (EVisionSystemQuestType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA26 RID: 109094 RVA: 0x003C96DC File Offset: 0x003C78DC
		public static Offset<IVisionSystemQuestBase> CreateIVisionSystemQuestBase(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel)
		{
			builder.StartTable(1);
			IVisionSystemQuestBase.AddType(builder, Type);
			return IVisionSystemQuestBase.EndIVisionSystemQuestBase(builder);
		}

		// Token: 0x0601AA27 RID: 109095 RVA: 0x003C96F2 File Offset: 0x003C78F2
		public static void StartIVisionSystemQuestBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AA28 RID: 109096 RVA: 0x003C96FB File Offset: 0x003C78FB
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA29 RID: 109097 RVA: 0x003C9706 File Offset: 0x003C7906
		public static Offset<IVisionSystemQuestBase> EndIVisionSystemQuestBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestBase>(builder.EndTable());
		}

		// Token: 0x0601AA2A RID: 109098 RVA: 0x003C9714 File Offset: 0x003C7914
		public IVisionSystemQuestBaseT UnPack()
		{
			IVisionSystemQuestBaseT visionSystemQuestBaseT = new IVisionSystemQuestBaseT();
			this.UnPackTo(visionSystemQuestBaseT);
			return visionSystemQuestBaseT;
		}

		// Token: 0x0601AA2B RID: 109099 RVA: 0x003C972F File Offset: 0x003C792F
		public void UnPackTo(IVisionSystemQuestBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AA2C RID: 109100 RVA: 0x003C9740 File Offset: 0x003C7940
		public static Offset<IVisionSystemQuestBase> Pack(FlatBufferBuilder builder, IVisionSystemQuestBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestBase>);
			}
			return IVisionSystemQuestBase.CreateIVisionSystemQuestBase(builder, _o.Type);
		}

		// Token: 0x0400C90D RID: 51469
		private Table __p;
	}
}
