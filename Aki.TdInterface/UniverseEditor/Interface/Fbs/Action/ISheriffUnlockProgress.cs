using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200789C RID: 30876
	public struct ISheriffUnlockProgress : IFlatbufferObject
	{
		// Token: 0x1700E266 RID: 57958
		// (get) Token: 0x06036506 RID: 222470 RVA: 0x00745DE9 File Offset: 0x00743FE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036507 RID: 222471 RVA: 0x00745DF6 File Offset: 0x00743FF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036508 RID: 222472 RVA: 0x00745E00 File Offset: 0x00744000
		public static ISheriffUnlockProgress GetRootAsISheriffUnlockProgress(ByteBuffer _bb)
		{
			return ISheriffUnlockProgress.GetRootAsISheriffUnlockProgress(_bb, default(ISheriffUnlockProgress));
		}

		// Token: 0x06036509 RID: 222473 RVA: 0x00745E1C File Offset: 0x0074401C
		public static ISheriffUnlockProgress GetRootAsISheriffUnlockProgress(ByteBuffer _bb, ISheriffUnlockProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603650A RID: 222474 RVA: 0x00745E39 File Offset: 0x00744039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603650B RID: 222475 RVA: 0x00745E48 File Offset: 0x00744048
		public ISheriffUnlockProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E267 RID: 57959
		// (get) Token: 0x0603650C RID: 222476 RVA: 0x00745E58 File Offset: 0x00744058
		public int ProgressId
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

		// Token: 0x0603650D RID: 222477 RVA: 0x00745E94 File Offset: 0x00744094
		public static Offset<ISheriffUnlockProgress> CreateISheriffUnlockProgress(FlatBufferBuilder builder, int ProgressId = 0)
		{
			builder.StartTable(1);
			ISheriffUnlockProgress.AddProgressId(builder, ProgressId);
			return ISheriffUnlockProgress.EndISheriffUnlockProgress(builder);
		}

		// Token: 0x0603650E RID: 222478 RVA: 0x00745EAA File Offset: 0x007440AA
		public static void StartISheriffUnlockProgress(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603650F RID: 222479 RVA: 0x00745EB3 File Offset: 0x007440B3
		public static void AddProgressId(FlatBufferBuilder builder, int progressId)
		{
			builder.AddInt(0, progressId, 0);
		}

		// Token: 0x06036510 RID: 222480 RVA: 0x00745EBE File Offset: 0x007440BE
		public static Offset<ISheriffUnlockProgress> EndISheriffUnlockProgress(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffUnlockProgress>(builder.EndTable());
		}

		// Token: 0x06036511 RID: 222481 RVA: 0x00745ECC File Offset: 0x007440CC
		public ISheriffUnlockProgressT UnPack()
		{
			ISheriffUnlockProgressT sheriffUnlockProgressT = new ISheriffUnlockProgressT();
			this.UnPackTo(sheriffUnlockProgressT);
			return sheriffUnlockProgressT;
		}

		// Token: 0x06036512 RID: 222482 RVA: 0x00745EE7 File Offset: 0x007440E7
		public void UnPackTo(ISheriffUnlockProgressT _o)
		{
			_o.ProgressId = this.ProgressId;
		}

		// Token: 0x06036513 RID: 222483 RVA: 0x00745EF8 File Offset: 0x007440F8
		public static Offset<ISheriffUnlockProgress> Pack(FlatBufferBuilder builder, ISheriffUnlockProgressT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffUnlockProgress>);
			}
			return ISheriffUnlockProgress.CreateISheriffUnlockProgress(builder, _o.ProgressId);
		}

		// Token: 0x04012B2B RID: 76587
		private Table __p;
	}
}
