using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A7 RID: 26535
	public struct IFinishDungeon : IFlatbufferObject
	{
		// Token: 0x1700C4F7 RID: 50423
		// (get) Token: 0x0602E2D2 RID: 189138 RVA: 0x0064E802 File Offset: 0x0064CA02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2D3 RID: 189139 RVA: 0x0064E80F File Offset: 0x0064CA0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2D4 RID: 189140 RVA: 0x0064E818 File Offset: 0x0064CA18
		public static IFinishDungeon GetRootAsIFinishDungeon(ByteBuffer _bb)
		{
			return IFinishDungeon.GetRootAsIFinishDungeon(_bb, default(IFinishDungeon));
		}

		// Token: 0x0602E2D5 RID: 189141 RVA: 0x0064E834 File Offset: 0x0064CA34
		public static IFinishDungeon GetRootAsIFinishDungeon(ByteBuffer _bb, IFinishDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2D6 RID: 189142 RVA: 0x0064E851 File Offset: 0x0064CA51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2D7 RID: 189143 RVA: 0x0064E860 File Offset: 0x0064CA60
		public IFinishDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4F8 RID: 50424
		// (get) Token: 0x0602E2D8 RID: 189144 RVA: 0x0064E870 File Offset: 0x0064CA70
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602E2D9 RID: 189145 RVA: 0x0064E8AF File Offset: 0x0064CAAF
		public static Offset<IFinishDungeon> CreateIFinishDungeon(FlatBufferBuilder builder, bool IsSuccess = false)
		{
			builder.StartTable(1);
			IFinishDungeon.AddIsSuccess(builder, IsSuccess);
			return IFinishDungeon.EndIFinishDungeon(builder);
		}

		// Token: 0x0602E2DA RID: 189146 RVA: 0x0064E8C5 File Offset: 0x0064CAC5
		public static void StartIFinishDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E2DB RID: 189147 RVA: 0x0064E8CE File Offset: 0x0064CACE
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x0602E2DC RID: 189148 RVA: 0x0064E8D9 File Offset: 0x0064CAD9
		public static Offset<IFinishDungeon> EndIFinishDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IFinishDungeon>(builder.EndTable());
		}

		// Token: 0x0602E2DD RID: 189149 RVA: 0x0064E8E8 File Offset: 0x0064CAE8
		public IFinishDungeonT UnPack()
		{
			IFinishDungeonT finishDungeonT = new IFinishDungeonT();
			this.UnPackTo(finishDungeonT);
			return finishDungeonT;
		}

		// Token: 0x0602E2DE RID: 189150 RVA: 0x0064E903 File Offset: 0x0064CB03
		public void UnPackTo(IFinishDungeonT _o)
		{
			_o.IsSuccess = this.IsSuccess;
		}

		// Token: 0x0602E2DF RID: 189151 RVA: 0x0064E914 File Offset: 0x0064CB14
		public static Offset<IFinishDungeon> Pack(FlatBufferBuilder builder, IFinishDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishDungeon>);
			}
			return IFinishDungeon.CreateIFinishDungeon(builder, _o.IsSuccess);
		}

		// Token: 0x04010EB6 RID: 69302
		private Table __p;
	}
}
