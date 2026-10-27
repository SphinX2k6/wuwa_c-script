using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426E RID: 17006
	public struct IVisionSystemQuestBase : IFlatbufferObject
	{
		// Token: 0x170078B9 RID: 30905
		// (get) Token: 0x060192B3 RID: 103091 RVA: 0x0039DF5A File Offset: 0x0039C15A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060192B4 RID: 103092 RVA: 0x0039DF67 File Offset: 0x0039C167
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060192B5 RID: 103093 RVA: 0x0039DF70 File Offset: 0x0039C170
		public static IVisionSystemQuestBase GetRootAsIVisionSystemQuestBase(ByteBuffer _bb)
		{
			return IVisionSystemQuestBase.GetRootAsIVisionSystemQuestBase(_bb, default(IVisionSystemQuestBase));
		}

		// Token: 0x060192B6 RID: 103094 RVA: 0x0039DF8C File Offset: 0x0039C18C
		public static IVisionSystemQuestBase GetRootAsIVisionSystemQuestBase(ByteBuffer _bb, IVisionSystemQuestBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192B7 RID: 103095 RVA: 0x0039DFA9 File Offset: 0x0039C1A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060192B8 RID: 103096 RVA: 0x0039DFB8 File Offset: 0x0039C1B8
		public IVisionSystemQuestBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078BA RID: 30906
		// (get) Token: 0x060192B9 RID: 103097 RVA: 0x0039DFC8 File Offset: 0x0039C1C8
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

		// Token: 0x060192BA RID: 103098 RVA: 0x0039E004 File Offset: 0x0039C204
		public static Offset<IVisionSystemQuestBase> CreateIVisionSystemQuestBase(FlatBufferBuilder builder, EVisionSystemQuestType Type = EVisionSystemQuestType.HasVisionGetTargetLevel)
		{
			builder.StartTable(1);
			IVisionSystemQuestBase.AddType(builder, Type);
			return IVisionSystemQuestBase.EndIVisionSystemQuestBase(builder);
		}

		// Token: 0x060192BB RID: 103099 RVA: 0x0039E01A File Offset: 0x0039C21A
		public static void StartIVisionSystemQuestBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060192BC RID: 103100 RVA: 0x0039E023 File Offset: 0x0039C223
		public static void AddType(FlatBufferBuilder builder, EVisionSystemQuestType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060192BD RID: 103101 RVA: 0x0039E02E File Offset: 0x0039C22E
		public static Offset<IVisionSystemQuestBase> EndIVisionSystemQuestBase(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestBase>(builder.EndTable());
		}

		// Token: 0x060192BE RID: 103102 RVA: 0x0039E03C File Offset: 0x0039C23C
		public IVisionSystemQuestBaseT UnPack()
		{
			IVisionSystemQuestBaseT visionSystemQuestBaseT = new IVisionSystemQuestBaseT();
			this.UnPackTo(visionSystemQuestBaseT);
			return visionSystemQuestBaseT;
		}

		// Token: 0x060192BF RID: 103103 RVA: 0x0039E057 File Offset: 0x0039C257
		public void UnPackTo(IVisionSystemQuestBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060192C0 RID: 103104 RVA: 0x0039E068 File Offset: 0x0039C268
		public static Offset<IVisionSystemQuestBase> Pack(FlatBufferBuilder builder, IVisionSystemQuestBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestBase>);
			}
			return IVisionSystemQuestBase.CreateIVisionSystemQuestBase(builder, _o.Type);
		}

		// Token: 0x0400BF00 RID: 48896
		private Table __p;
	}
}
