using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D6 RID: 18134
	public struct IVisionSystemQuestSetActivated : IFlatbufferObject
	{
		// Token: 0x17007EF9 RID: 32505
		// (get) Token: 0x0601AA72 RID: 109170 RVA: 0x003C9F9D File Offset: 0x003C819D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA73 RID: 109171 RVA: 0x003C9FAA File Offset: 0x003C81AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA74 RID: 109172 RVA: 0x003C9FB4 File Offset: 0x003C81B4
		public static IVisionSystemQuestSetActivated GetRootAsIVisionSystemQuestSetActivated(ByteBuffer _bb)
		{
			return IVisionSystemQuestSetActivated.GetRootAsIVisionSystemQuestSetActivated(_bb, default(IVisionSystemQuestSetActivated));
		}

		// Token: 0x0601AA75 RID: 109173 RVA: 0x003C9FD0 File Offset: 0x003C81D0
		public static IVisionSystemQuestSetActivated GetRootAsIVisionSystemQuestSetActivated(ByteBuffer _bb, IVisionSystemQuestSetActivated obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA76 RID: 109174 RVA: 0x003C9FED File Offset: 0x003C81ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA77 RID: 109175 RVA: 0x003C9FFC File Offset: 0x003C81FC
		public IVisionSystemQuestSetActivated __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EFA RID: 32506
		// (get) Token: 0x0601AA78 RID: 109176 RVA: 0x003CA00C File Offset: 0x003C820C
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

		// Token: 0x17007EFB RID: 32507
		// (get) Token: 0x0601AA79 RID: 109177 RVA: 0x003CA048 File Offset: 0x003C8248
		public EVisionSetType SetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVisionSetType.None;
				}
				return (EVisionSetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA7A RID: 109178 RVA: 0x003CA084 File Offset: 0x003C8284
		public static Offset<IVisionSystemQuestSetActivated> CreateIVisionSystemQuestSetActivated(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel, EVisionSetType SetType = EVisionSetType.None)
		{
			builder.StartTable(2);
			IVisionSystemQuestSetActivated.AddSetType(builder, SetType);
			IVisionSystemQuestSetActivated.AddType(builder, Type);
			return IVisionSystemQuestSetActivated.EndIVisionSystemQuestSetActivated(builder);
		}

		// Token: 0x0601AA7B RID: 109179 RVA: 0x003CA0A1 File Offset: 0x003C82A1
		public static void StartIVisionSystemQuestSetActivated(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AA7C RID: 109180 RVA: 0x003CA0AA File Offset: 0x003C82AA
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA7D RID: 109181 RVA: 0x003CA0B5 File Offset: 0x003C82B5
		public static void AddSetType(FlatBufferBuilder builder, EVisionSetType setType)
		{
			builder.AddByte(1, (byte)setType, 0);
		}

		// Token: 0x0601AA7E RID: 109182 RVA: 0x003CA0C0 File Offset: 0x003C82C0
		public static Offset<IVisionSystemQuestSetActivated> EndIVisionSystemQuestSetActivated(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestSetActivated>(builder.EndTable());
		}

		// Token: 0x0601AA7F RID: 109183 RVA: 0x003CA0D0 File Offset: 0x003C82D0
		public IVisionSystemQuestSetActivatedT UnPack()
		{
			IVisionSystemQuestSetActivatedT visionSystemQuestSetActivatedT = new IVisionSystemQuestSetActivatedT();
			this.UnPackTo(visionSystemQuestSetActivatedT);
			return visionSystemQuestSetActivatedT;
		}

		// Token: 0x0601AA80 RID: 109184 RVA: 0x003CA0EB File Offset: 0x003C82EB
		public void UnPackTo(IVisionSystemQuestSetActivatedT _o)
		{
			_o.Type = this.Type;
			_o.SetType = this.SetType;
		}

		// Token: 0x0601AA81 RID: 109185 RVA: 0x003CA108 File Offset: 0x003C8308
		public static Offset<IVisionSystemQuestSetActivated> Pack(FlatBufferBuilder builder, IVisionSystemQuestSetActivatedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestSetActivated>);
			}
			return IVisionSystemQuestSetActivated.CreateIVisionSystemQuestSetActivated(builder, _o.Type, _o.SetType);
		}

		// Token: 0x0400C91D RID: 51485
		private Table __p;
	}
}
