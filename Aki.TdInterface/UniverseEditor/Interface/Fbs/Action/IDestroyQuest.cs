using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFF RID: 27647
	public struct IDestroyQuest : IFlatbufferObject
	{
		// Token: 0x1700CAB0 RID: 51888
		// (get) Token: 0x0602F94D RID: 194893 RVA: 0x0067C345 File Offset: 0x0067A545
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F94E RID: 194894 RVA: 0x0067C352 File Offset: 0x0067A552
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F94F RID: 194895 RVA: 0x0067C35C File Offset: 0x0067A55C
		public static IDestroyQuest GetRootAsIDestroyQuest(ByteBuffer _bb)
		{
			return IDestroyQuest.GetRootAsIDestroyQuest(_bb, default(IDestroyQuest));
		}

		// Token: 0x0602F950 RID: 194896 RVA: 0x0067C378 File Offset: 0x0067A578
		public static IDestroyQuest GetRootAsIDestroyQuest(ByteBuffer _bb, IDestroyQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F951 RID: 194897 RVA: 0x0067C395 File Offset: 0x0067A595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F952 RID: 194898 RVA: 0x0067C3A4 File Offset: 0x0067A5A4
		public IDestroyQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAB1 RID: 51889
		// (get) Token: 0x0602F953 RID: 194899 RVA: 0x0067C3B4 File Offset: 0x0067A5B4
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CAB2 RID: 51890
		// (get) Token: 0x0602F954 RID: 194900 RVA: 0x0067C3F0 File Offset: 0x0067A5F0
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CAB3 RID: 51891
		// (get) Token: 0x0602F955 RID: 194901 RVA: 0x0067C430 File Offset: 0x0067A630
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F956 RID: 194902 RVA: 0x0067C46C File Offset: 0x0067A66C
		public static Offset<IDestroyQuest> CreateIDestroyQuest(FlatBufferBuilder builder, int QuestId = 0, bool IsDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDestroyQuest.AddQuestId(builder, QuestId);
			IDestroyQuest.AddNullMask(builder, NullMask);
			IDestroyQuest.AddIsDestroy(builder, IsDestroy);
			return IDestroyQuest.EndIDestroyQuest(builder);
		}

		// Token: 0x0602F957 RID: 194903 RVA: 0x0067C490 File Offset: 0x0067A690
		public static void StartIDestroyQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F958 RID: 194904 RVA: 0x0067C499 File Offset: 0x0067A699
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x0602F959 RID: 194905 RVA: 0x0067C4A4 File Offset: 0x0067A6A4
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(1, isDestroy, false);
		}

		// Token: 0x0602F95A RID: 194906 RVA: 0x0067C4AF File Offset: 0x0067A6AF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F95B RID: 194907 RVA: 0x0067C4BA File Offset: 0x0067A6BA
		public static Offset<IDestroyQuest> EndIDestroyQuest(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyQuest>(builder.EndTable());
		}

		// Token: 0x0602F95C RID: 194908 RVA: 0x0067C4C8 File Offset: 0x0067A6C8
		public IDestroyQuestT UnPack()
		{
			IDestroyQuestT destroyQuestT = new IDestroyQuestT();
			this.UnPackTo(destroyQuestT);
			return destroyQuestT;
		}

		// Token: 0x0602F95D RID: 194909 RVA: 0x0067C4E3 File Offset: 0x0067A6E3
		public void UnPackTo(IDestroyQuestT _o)
		{
			_o.QuestId = this.QuestId;
			_o.IsDestroy = this.IsDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F95E RID: 194910 RVA: 0x0067C50C File Offset: 0x0067A70C
		public static Offset<IDestroyQuest> Pack(FlatBufferBuilder builder, IDestroyQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyQuest>);
			}
			return IDestroyQuest.CreateIDestroyQuest(builder, _o.QuestId, _o.IsDestroy, _o.NullMask);
		}

		// Token: 0x04011A01 RID: 72193
		private Table __p;
	}
}
