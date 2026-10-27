using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427D RID: 17021
	public struct IVisionSystemQuestTargetLevel : IFlatbufferObject
	{
		// Token: 0x170078CD RID: 30925
		// (get) Token: 0x0601931C RID: 103196 RVA: 0x0039EAC6 File Offset: 0x0039CCC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601931D RID: 103197 RVA: 0x0039EAD3 File Offset: 0x0039CCD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601931E RID: 103198 RVA: 0x0039EADC File Offset: 0x0039CCDC
		public static IVisionSystemQuestTargetLevel GetRootAsIVisionSystemQuestTargetLevel(ByteBuffer _bb)
		{
			return IVisionSystemQuestTargetLevel.GetRootAsIVisionSystemQuestTargetLevel(_bb, default(IVisionSystemQuestTargetLevel));
		}

		// Token: 0x0601931F RID: 103199 RVA: 0x0039EAF8 File Offset: 0x0039CCF8
		public static IVisionSystemQuestTargetLevel GetRootAsIVisionSystemQuestTargetLevel(ByteBuffer _bb, IVisionSystemQuestTargetLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019320 RID: 103200 RVA: 0x0039EB15 File Offset: 0x0039CD15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019321 RID: 103201 RVA: 0x0039EB24 File Offset: 0x0039CD24
		public IVisionSystemQuestTargetLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078CE RID: 30926
		// (get) Token: 0x06019322 RID: 103202 RVA: 0x0039EB34 File Offset: 0x0039CD34
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

		// Token: 0x170078CF RID: 30927
		// (get) Token: 0x06019323 RID: 103203 RVA: 0x0039EB70 File Offset: 0x0039CD70
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

		// Token: 0x06019324 RID: 103204 RVA: 0x0039EBAC File Offset: 0x0039CDAC
		public static Offset<IVisionSystemQuestTargetLevel> CreateIVisionSystemQuestTargetLevel(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel, int TargetLevel = 0)
		{
			builder.StartTable(2);
			IVisionSystemQuestTargetLevel.AddTargetLevel(builder, TargetLevel);
			IVisionSystemQuestTargetLevel.AddType(builder, Type);
			return IVisionSystemQuestTargetLevel.EndIVisionSystemQuestTargetLevel(builder);
		}

		// Token: 0x06019325 RID: 103205 RVA: 0x0039EBC9 File Offset: 0x0039CDC9
		public static void StartIVisionSystemQuestTargetLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019326 RID: 103206 RVA: 0x0039EBD2 File Offset: 0x0039CDD2
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019327 RID: 103207 RVA: 0x0039EBDD File Offset: 0x0039CDDD
		public static void AddTargetLevel(FlatBufferBuilder builder, int targetLevel)
		{
			builder.AddInt(1, targetLevel, 0);
		}

		// Token: 0x06019328 RID: 103208 RVA: 0x0039EBE8 File Offset: 0x0039CDE8
		public static Offset<IVisionSystemQuestTargetLevel> EndIVisionSystemQuestTargetLevel(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestTargetLevel>(builder.EndTable());
		}

		// Token: 0x06019329 RID: 103209 RVA: 0x0039EBF8 File Offset: 0x0039CDF8
		public IVisionSystemQuestTargetLevelT UnPack()
		{
			IVisionSystemQuestTargetLevelT visionSystemQuestTargetLevelT = new IVisionSystemQuestTargetLevelT();
			this.UnPackTo(visionSystemQuestTargetLevelT);
			return visionSystemQuestTargetLevelT;
		}

		// Token: 0x0601932A RID: 103210 RVA: 0x0039EC13 File Offset: 0x0039CE13
		public void UnPackTo(IVisionSystemQuestTargetLevelT _o)
		{
			_o.Type = this.Type;
			_o.TargetLevel = this.TargetLevel;
		}

		// Token: 0x0601932B RID: 103211 RVA: 0x0039EC30 File Offset: 0x0039CE30
		public static Offset<IVisionSystemQuestTargetLevel> Pack(FlatBufferBuilder builder, IVisionSystemQuestTargetLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestTargetLevel>);
			}
			return IVisionSystemQuestTargetLevel.CreateIVisionSystemQuestTargetLevel(builder, _o.Type, _o.TargetLevel);
		}

		// Token: 0x0400BF13 RID: 48915
		private Table __p;
	}
}
