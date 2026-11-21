using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E27 RID: 28199
	public struct IFinishDungeon : IFlatbufferObject
	{
		// Token: 0x1700CEAD RID: 52909
		// (get) Token: 0x06030B18 RID: 199448 RVA: 0x0069BF46 File Offset: 0x0069A146
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B19 RID: 199449 RVA: 0x0069BF53 File Offset: 0x0069A153
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B1A RID: 199450 RVA: 0x0069BF5C File Offset: 0x0069A15C
		public static IFinishDungeon GetRootAsIFinishDungeon(ByteBuffer _bb)
		{
			return IFinishDungeon.GetRootAsIFinishDungeon(_bb, default(IFinishDungeon));
		}

		// Token: 0x06030B1B RID: 199451 RVA: 0x0069BF78 File Offset: 0x0069A178
		public static IFinishDungeon GetRootAsIFinishDungeon(ByteBuffer _bb, IFinishDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B1C RID: 199452 RVA: 0x0069BF95 File Offset: 0x0069A195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B1D RID: 199453 RVA: 0x0069BFA4 File Offset: 0x0069A1A4
		public IFinishDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEAE RID: 52910
		// (get) Token: 0x06030B1E RID: 199454 RVA: 0x0069BFB4 File Offset: 0x0069A1B4
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06030B1F RID: 199455 RVA: 0x0069BFF3 File Offset: 0x0069A1F3
		public static Offset<IFinishDungeon> CreateIFinishDungeon(FlatBufferBuilder builder, bool IsSuccess = false)
		{
			builder.StartTable(1);
			IFinishDungeon.AddIsSuccess(builder, IsSuccess);
			return IFinishDungeon.EndIFinishDungeon(builder);
		}

		// Token: 0x06030B20 RID: 199456 RVA: 0x0069C009 File Offset: 0x0069A209
		public static void StartIFinishDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030B21 RID: 199457 RVA: 0x0069C012 File Offset: 0x0069A212
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x06030B22 RID: 199458 RVA: 0x0069C01D File Offset: 0x0069A21D
		public static Offset<IFinishDungeon> EndIFinishDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IFinishDungeon>(builder.EndTable());
		}

		// Token: 0x06030B23 RID: 199459 RVA: 0x0069C02C File Offset: 0x0069A22C
		public IFinishDungeonT UnPack()
		{
			IFinishDungeonT finishDungeonT = new IFinishDungeonT();
			this.UnPackTo(finishDungeonT);
			return finishDungeonT;
		}

		// Token: 0x06030B24 RID: 199460 RVA: 0x0069C047 File Offset: 0x0069A247
		public void UnPackTo(IFinishDungeonT _o)
		{
			_o.IsSuccess = this.IsSuccess;
		}

		// Token: 0x06030B25 RID: 199461 RVA: 0x0069C058 File Offset: 0x0069A258
		public static Offset<IFinishDungeon> Pack(FlatBufferBuilder builder, IFinishDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishDungeon>);
			}
			return IFinishDungeon.CreateIFinishDungeon(builder, _o.IsSuccess);
		}

		// Token: 0x04011CE8 RID: 72936
		private Table __p;
	}
}
