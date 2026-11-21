using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E99 RID: 20121
	public struct ICheckDungeonFinish : IFlatbufferObject
	{
		// Token: 0x17008F84 RID: 36740
		// (get) Token: 0x0601F2D9 RID: 127705 RVA: 0x0045904A File Offset: 0x0045724A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F2DA RID: 127706 RVA: 0x00459057 File Offset: 0x00457257
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F2DB RID: 127707 RVA: 0x00459060 File Offset: 0x00457260
		public static ICheckDungeonFinish GetRootAsICheckDungeonFinish(ByteBuffer _bb)
		{
			return ICheckDungeonFinish.GetRootAsICheckDungeonFinish(_bb, default(ICheckDungeonFinish));
		}

		// Token: 0x0601F2DC RID: 127708 RVA: 0x0045907C File Offset: 0x0045727C
		public static ICheckDungeonFinish GetRootAsICheckDungeonFinish(ByteBuffer _bb, ICheckDungeonFinish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F2DD RID: 127709 RVA: 0x00459099 File Offset: 0x00457299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F2DE RID: 127710 RVA: 0x004590A8 File Offset: 0x004572A8
		public ICheckDungeonFinish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F85 RID: 36741
		// (get) Token: 0x0601F2DF RID: 127711 RVA: 0x004590B8 File Offset: 0x004572B8
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

		// Token: 0x17008F86 RID: 36742
		// (get) Token: 0x0601F2E0 RID: 127712 RVA: 0x004590F4 File Offset: 0x004572F4
		public int DungeonId
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

		// Token: 0x17008F87 RID: 36743
		// (get) Token: 0x0601F2E1 RID: 127713 RVA: 0x00459130 File Offset: 0x00457330
		public bool IsFinished
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008F88 RID: 36744
		// (get) Token: 0x0601F2E2 RID: 127714 RVA: 0x00459170 File Offset: 0x00457370
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F2E3 RID: 127715 RVA: 0x004591AD File Offset: 0x004573AD
		public static Offset<ICheckDungeonFinish> CreateICheckDungeonFinish(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, bool IsFinished = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICheckDungeonFinish.AddDungeonId(builder, DungeonId);
			ICheckDungeonFinish.AddNullMask(builder, NullMask);
			ICheckDungeonFinish.AddIsFinished(builder, IsFinished);
			ICheckDungeonFinish.AddType(builder, Type);
			return ICheckDungeonFinish.EndICheckDungeonFinish(builder);
		}

		// Token: 0x0601F2E4 RID: 127716 RVA: 0x004591D9 File Offset: 0x004573D9
		public static void StartICheckDungeonFinish(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F2E5 RID: 127717 RVA: 0x004591E2 File Offset: 0x004573E2
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F2E6 RID: 127718 RVA: 0x004591ED File Offset: 0x004573ED
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601F2E7 RID: 127719 RVA: 0x004591F8 File Offset: 0x004573F8
		public static void AddIsFinished(FlatBufferBuilder builder, bool isFinished)
		{
			builder.AddBool(2, isFinished, false);
		}

		// Token: 0x0601F2E8 RID: 127720 RVA: 0x00459203 File Offset: 0x00457403
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601F2E9 RID: 127721 RVA: 0x0045920E File Offset: 0x0045740E
		public static Offset<ICheckDungeonFinish> EndICheckDungeonFinish(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDungeonFinish>(builder.EndTable());
		}

		// Token: 0x0601F2EA RID: 127722 RVA: 0x0045921C File Offset: 0x0045741C
		public ICheckDungeonFinishT UnPack()
		{
			ICheckDungeonFinishT checkDungeonFinishT = new ICheckDungeonFinishT();
			this.UnPackTo(checkDungeonFinishT);
			return checkDungeonFinishT;
		}

		// Token: 0x0601F2EB RID: 127723 RVA: 0x00459237 File Offset: 0x00457437
		public void UnPackTo(ICheckDungeonFinishT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.IsFinished = this.IsFinished;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F2EC RID: 127724 RVA: 0x0045926C File Offset: 0x0045746C
		public static Offset<ICheckDungeonFinish> Pack(FlatBufferBuilder builder, ICheckDungeonFinishT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDungeonFinish>);
			}
			return ICheckDungeonFinish.CreateICheckDungeonFinish(builder, _o.Type, _o.DungeonId, _o.IsFinished, _o.NullMask);
		}

		// Token: 0x0400DCDA RID: 56538
		private Table __p;
	}
}
