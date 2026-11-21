using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D9 RID: 18137
	public struct IVisionSystemQuestTargetLevel : IFlatbufferObject
	{
		// Token: 0x17007EFE RID: 32510
		// (get) Token: 0x0601AA88 RID: 109192 RVA: 0x003CA19E File Offset: 0x003C839E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA89 RID: 109193 RVA: 0x003CA1AB File Offset: 0x003C83AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA8A RID: 109194 RVA: 0x003CA1B4 File Offset: 0x003C83B4
		public static IVisionSystemQuestTargetLevel GetRootAsIVisionSystemQuestTargetLevel(ByteBuffer _bb)
		{
			return IVisionSystemQuestTargetLevel.GetRootAsIVisionSystemQuestTargetLevel(_bb, default(IVisionSystemQuestTargetLevel));
		}

		// Token: 0x0601AA8B RID: 109195 RVA: 0x003CA1D0 File Offset: 0x003C83D0
		public static IVisionSystemQuestTargetLevel GetRootAsIVisionSystemQuestTargetLevel(ByteBuffer _bb, IVisionSystemQuestTargetLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA8C RID: 109196 RVA: 0x003CA1ED File Offset: 0x003C83ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA8D RID: 109197 RVA: 0x003CA1FC File Offset: 0x003C83FC
		public IVisionSystemQuestTargetLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EFF RID: 32511
		// (get) Token: 0x0601AA8E RID: 109198 RVA: 0x003CA20C File Offset: 0x003C840C
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

		// Token: 0x17007F00 RID: 32512
		// (get) Token: 0x0601AA8F RID: 109199 RVA: 0x003CA248 File Offset: 0x003C8448
		public int TargetLevel
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

		// Token: 0x0601AA90 RID: 109200 RVA: 0x003CA284 File Offset: 0x003C8484
		public static Offset<IVisionSystemQuestTargetLevel> CreateIVisionSystemQuestTargetLevel(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel, int TargetLevel = 0)
		{
			builder.StartTable(2);
			IVisionSystemQuestTargetLevel.AddTargetLevel(builder, TargetLevel);
			IVisionSystemQuestTargetLevel.AddType(builder, Type);
			return IVisionSystemQuestTargetLevel.EndIVisionSystemQuestTargetLevel(builder);
		}

		// Token: 0x0601AA91 RID: 109201 RVA: 0x003CA2A1 File Offset: 0x003C84A1
		public static void StartIVisionSystemQuestTargetLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AA92 RID: 109202 RVA: 0x003CA2AA File Offset: 0x003C84AA
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA93 RID: 109203 RVA: 0x003CA2B5 File Offset: 0x003C84B5
		public static void AddTargetLevel(FlatBufferBuilder builder, int targetLevel)
		{
			builder.AddInt(1, targetLevel, 0);
		}

		// Token: 0x0601AA94 RID: 109204 RVA: 0x003CA2C0 File Offset: 0x003C84C0
		public static Offset<IVisionSystemQuestTargetLevel> EndIVisionSystemQuestTargetLevel(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestTargetLevel>(builder.EndTable());
		}

		// Token: 0x0601AA95 RID: 109205 RVA: 0x003CA2D0 File Offset: 0x003C84D0
		public IVisionSystemQuestTargetLevelT UnPack()
		{
			IVisionSystemQuestTargetLevelT visionSystemQuestTargetLevelT = new IVisionSystemQuestTargetLevelT();
			this.UnPackTo(visionSystemQuestTargetLevelT);
			return visionSystemQuestTargetLevelT;
		}

		// Token: 0x0601AA96 RID: 109206 RVA: 0x003CA2EB File Offset: 0x003C84EB
		public void UnPackTo(IVisionSystemQuestTargetLevelT _o)
		{
			_o.Type = this.Type;
			_o.TargetLevel = this.TargetLevel;
		}

		// Token: 0x0601AA97 RID: 109207 RVA: 0x003CA308 File Offset: 0x003C8508
		public static Offset<IVisionSystemQuestTargetLevel> Pack(FlatBufferBuilder builder, IVisionSystemQuestTargetLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestTargetLevel>);
			}
			return IVisionSystemQuestTargetLevel.CreateIVisionSystemQuestTargetLevel(builder, _o.Type, _o.TargetLevel);
		}

		// Token: 0x0400C920 RID: 51488
		private Table __p;
	}
}
