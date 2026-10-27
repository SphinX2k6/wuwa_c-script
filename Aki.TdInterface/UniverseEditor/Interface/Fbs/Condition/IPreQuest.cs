using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C9A RID: 19610
	public struct IPreQuest : IFlatbufferObject
	{
		// Token: 0x17008E61 RID: 36449
		// (get) Token: 0x0601F1AB RID: 127403 RVA: 0x0045881E File Offset: 0x00456A1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1AC RID: 127404 RVA: 0x0045882B File Offset: 0x00456A2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1AD RID: 127405 RVA: 0x00458834 File Offset: 0x00456A34
		public static IPreQuest GetRootAsIPreQuest(ByteBuffer _bb)
		{
			return IPreQuest.GetRootAsIPreQuest(_bb, default(IPreQuest));
		}

		// Token: 0x0601F1AE RID: 127406 RVA: 0x00458850 File Offset: 0x00456A50
		public static IPreQuest GetRootAsIPreQuest(ByteBuffer _bb, IPreQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1AF RID: 127407 RVA: 0x0045886D File Offset: 0x00456A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1B0 RID: 127408 RVA: 0x0045887C File Offset: 0x00456A7C
		public IPreQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E62 RID: 36450
		// (get) Token: 0x0601F1B1 RID: 127409 RVA: 0x0045888C File Offset: 0x00456A8C
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E63 RID: 36451
		// (get) Token: 0x0601F1B2 RID: 127410 RVA: 0x004588C8 File Offset: 0x00456AC8
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E64 RID: 36452
		// (get) Token: 0x0601F1B3 RID: 127411 RVA: 0x00458904 File Offset: 0x00456B04
		public int PreQuestId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F1B4 RID: 127412 RVA: 0x00458940 File Offset: 0x00456B40
		public static Offset<IPreQuest> CreateIPreQuest(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, int PreQuestId = 0)
		{
			builder.StartTable(3);
			IPreQuest.AddPreQuestId(builder, PreQuestId);
			IPreQuest.AddCompare(builder, Compare);
			IPreQuest.AddType(builder, Type);
			return IPreQuest.EndIPreQuest(builder);
		}

		// Token: 0x0601F1B5 RID: 127413 RVA: 0x00458964 File Offset: 0x00456B64
		public static void StartIPreQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F1B6 RID: 127414 RVA: 0x0045896D File Offset: 0x00456B6D
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F1B7 RID: 127415 RVA: 0x00458978 File Offset: 0x00456B78
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F1B8 RID: 127416 RVA: 0x00458983 File Offset: 0x00456B83
		public static void AddPreQuestId(FlatBufferBuilder builder, int preQuestId)
		{
			builder.AddInt(2, preQuestId, 0);
		}

		// Token: 0x0601F1B9 RID: 127417 RVA: 0x0045898E File Offset: 0x00456B8E
		public static Offset<IPreQuest> EndIPreQuest(FlatBufferBuilder builder)
		{
			return new Offset<IPreQuest>(builder.EndTable());
		}

		// Token: 0x0601F1BA RID: 127418 RVA: 0x0045899C File Offset: 0x00456B9C
		public IPreQuestT UnPack()
		{
			IPreQuestT preQuestT = new IPreQuestT();
			this.UnPackTo(preQuestT);
			return preQuestT;
		}

		// Token: 0x0601F1BB RID: 127419 RVA: 0x004589B7 File Offset: 0x00456BB7
		public void UnPackTo(IPreQuestT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.PreQuestId = this.PreQuestId;
		}

		// Token: 0x0601F1BC RID: 127420 RVA: 0x004589E0 File Offset: 0x00456BE0
		public static Offset<IPreQuest> Pack(FlatBufferBuilder builder, IPreQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreQuest>);
			}
			return IPreQuest.CreateIPreQuest(builder, _o.Type, _o.Compare, _o.PreQuestId);
		}

		// Token: 0x0400D654 RID: 54868
		private Table __p;
	}
}
