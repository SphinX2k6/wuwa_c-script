using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9A RID: 28058
	public struct IExitDungeon : IFlatbufferObject
	{
		// Token: 0x1700CDC5 RID: 52677
		// (get) Token: 0x060306D3 RID: 198355 RVA: 0x00694652 File Offset: 0x00692852
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060306D4 RID: 198356 RVA: 0x0069465F File Offset: 0x0069285F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060306D5 RID: 198357 RVA: 0x00694668 File Offset: 0x00692868
		public static IExitDungeon GetRootAsIExitDungeon(ByteBuffer _bb)
		{
			return IExitDungeon.GetRootAsIExitDungeon(_bb, default(IExitDungeon));
		}

		// Token: 0x060306D6 RID: 198358 RVA: 0x00694684 File Offset: 0x00692884
		public static IExitDungeon GetRootAsIExitDungeon(ByteBuffer _bb, IExitDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060306D7 RID: 198359 RVA: 0x006946A1 File Offset: 0x006928A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060306D8 RID: 198360 RVA: 0x006946B0 File Offset: 0x006928B0
		public IExitDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDC6 RID: 52678
		// (get) Token: 0x060306D9 RID: 198361 RVA: 0x006946C0 File Offset: 0x006928C0
		public bool IsNeedSecondaryConfirmation
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CDC7 RID: 52679
		// (get) Token: 0x060306DA RID: 198362 RVA: 0x00694700 File Offset: 0x00692900
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060306DB RID: 198363 RVA: 0x0069473C File Offset: 0x0069293C
		public static Offset<IExitDungeon> CreateIExitDungeon(FlatBufferBuilder builder, bool IsNeedSecondaryConfirmation = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IExitDungeon.AddNullMask(builder, NullMask);
			IExitDungeon.AddIsNeedSecondaryConfirmation(builder, IsNeedSecondaryConfirmation);
			return IExitDungeon.EndIExitDungeon(builder);
		}

		// Token: 0x060306DC RID: 198364 RVA: 0x00694759 File Offset: 0x00692959
		public static void StartIExitDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060306DD RID: 198365 RVA: 0x00694762 File Offset: 0x00692962
		public static void AddIsNeedSecondaryConfirmation(FlatBufferBuilder builder, bool isNeedSecondaryConfirmation)
		{
			builder.AddBool(0, isNeedSecondaryConfirmation, false);
		}

		// Token: 0x060306DE RID: 198366 RVA: 0x0069476D File Offset: 0x0069296D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060306DF RID: 198367 RVA: 0x00694778 File Offset: 0x00692978
		public static Offset<IExitDungeon> EndIExitDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IExitDungeon>(builder.EndTable());
		}

		// Token: 0x060306E0 RID: 198368 RVA: 0x00694788 File Offset: 0x00692988
		public IExitDungeonT UnPack()
		{
			IExitDungeonT exitDungeonT = new IExitDungeonT();
			this.UnPackTo(exitDungeonT);
			return exitDungeonT;
		}

		// Token: 0x060306E1 RID: 198369 RVA: 0x006947A3 File Offset: 0x006929A3
		public void UnPackTo(IExitDungeonT _o)
		{
			_o.IsNeedSecondaryConfirmation = this.IsNeedSecondaryConfirmation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060306E2 RID: 198370 RVA: 0x006947C0 File Offset: 0x006929C0
		public static Offset<IExitDungeon> Pack(FlatBufferBuilder builder, IExitDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitDungeon>);
			}
			return IExitDungeon.CreateIExitDungeon(builder, _o.IsNeedSecondaryConfirmation, _o.NullMask);
		}

		// Token: 0x04011C33 RID: 72755
		private Table __p;
	}
}
