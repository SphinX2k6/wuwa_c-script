using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049D9 RID: 18905
	public struct ICheckDungeonFinish : IFlatbufferObject
	{
		// Token: 0x170088B4 RID: 34996
		// (get) Token: 0x0601D866 RID: 120934 RVA: 0x004283DE File Offset: 0x004265DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D867 RID: 120935 RVA: 0x004283EB File Offset: 0x004265EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D868 RID: 120936 RVA: 0x004283F4 File Offset: 0x004265F4
		public static ICheckDungeonFinish GetRootAsICheckDungeonFinish(ByteBuffer _bb)
		{
			return ICheckDungeonFinish.GetRootAsICheckDungeonFinish(_bb, default(ICheckDungeonFinish));
		}

		// Token: 0x0601D869 RID: 120937 RVA: 0x00428410 File Offset: 0x00426610
		public static ICheckDungeonFinish GetRootAsICheckDungeonFinish(ByteBuffer _bb, ICheckDungeonFinish obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D86A RID: 120938 RVA: 0x0042842D File Offset: 0x0042662D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D86B RID: 120939 RVA: 0x0042843C File Offset: 0x0042663C
		public ICheckDungeonFinish __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088B5 RID: 34997
		// (get) Token: 0x0601D86C RID: 120940 RVA: 0x0042844C File Offset: 0x0042664C
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

		// Token: 0x170088B6 RID: 34998
		// (get) Token: 0x0601D86D RID: 120941 RVA: 0x00428488 File Offset: 0x00426688
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

		// Token: 0x170088B7 RID: 34999
		// (get) Token: 0x0601D86E RID: 120942 RVA: 0x004284C4 File Offset: 0x004266C4
		public bool IsFinished
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170088B8 RID: 35000
		// (get) Token: 0x0601D86F RID: 120943 RVA: 0x00428504 File Offset: 0x00426704
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

		// Token: 0x0601D870 RID: 120944 RVA: 0x00428541 File Offset: 0x00426741
		public static Offset<ICheckDungeonFinish> CreateICheckDungeonFinish(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, bool IsFinished = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ICheckDungeonFinish.AddDungeonId(builder, DungeonId);
			ICheckDungeonFinish.AddNullMask(builder, NullMask);
			ICheckDungeonFinish.AddIsFinished(builder, IsFinished);
			ICheckDungeonFinish.AddType(builder, Type);
			return ICheckDungeonFinish.EndICheckDungeonFinish(builder);
		}

		// Token: 0x0601D871 RID: 120945 RVA: 0x0042856D File Offset: 0x0042676D
		public static void StartICheckDungeonFinish(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D872 RID: 120946 RVA: 0x00428576 File Offset: 0x00426776
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D873 RID: 120947 RVA: 0x00428581 File Offset: 0x00426781
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601D874 RID: 120948 RVA: 0x0042858C File Offset: 0x0042678C
		public static void AddIsFinished(FlatBufferBuilder builder, bool isFinished)
		{
			builder.AddBool(2, isFinished, false);
		}

		// Token: 0x0601D875 RID: 120949 RVA: 0x00428597 File Offset: 0x00426797
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601D876 RID: 120950 RVA: 0x004285A2 File Offset: 0x004267A2
		public static Offset<ICheckDungeonFinish> EndICheckDungeonFinish(FlatBufferBuilder builder)
		{
			return new Offset<ICheckDungeonFinish>(builder.EndTable());
		}

		// Token: 0x0601D877 RID: 120951 RVA: 0x004285B0 File Offset: 0x004267B0
		public ICheckDungeonFinishT UnPack()
		{
			ICheckDungeonFinishT checkDungeonFinishT = new ICheckDungeonFinishT();
			this.UnPackTo(checkDungeonFinishT);
			return checkDungeonFinishT;
		}

		// Token: 0x0601D878 RID: 120952 RVA: 0x004285CB File Offset: 0x004267CB
		public void UnPackTo(ICheckDungeonFinishT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.IsFinished = this.IsFinished;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D879 RID: 120953 RVA: 0x00428600 File Offset: 0x00426800
		public static Offset<ICheckDungeonFinish> Pack(FlatBufferBuilder builder, ICheckDungeonFinishT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckDungeonFinish>);
			}
			return ICheckDungeonFinish.CreateICheckDungeonFinish(builder, _o.Type, _o.DungeonId, _o.IsFinished, _o.NullMask);
		}

		// Token: 0x0400D206 RID: 53766
		private Table __p;
	}
}
