using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF2 RID: 28658
	public struct ISetForceLock : IFlatbufferObject
	{
		// Token: 0x1700D4E5 RID: 54501
		// (get) Token: 0x06032B0E RID: 207630 RVA: 0x006D716A File Offset: 0x006D536A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B0F RID: 207631 RVA: 0x006D7177 File Offset: 0x006D5377
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B10 RID: 207632 RVA: 0x006D7180 File Offset: 0x006D5380
		public static ISetForceLock GetRootAsISetForceLock(ByteBuffer _bb)
		{
			return ISetForceLock.GetRootAsISetForceLock(_bb, default(ISetForceLock));
		}

		// Token: 0x06032B11 RID: 207633 RVA: 0x006D719C File Offset: 0x006D539C
		public static ISetForceLock GetRootAsISetForceLock(ByteBuffer _bb, ISetForceLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B12 RID: 207634 RVA: 0x006D71B9 File Offset: 0x006D53B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B13 RID: 207635 RVA: 0x006D71C8 File Offset: 0x006D53C8
		public ISetForceLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4E6 RID: 54502
		// (get) Token: 0x06032B14 RID: 207636 RVA: 0x006D71D8 File Offset: 0x006D53D8
		public int EntityId
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

		// Token: 0x1700D4E7 RID: 54503
		// (get) Token: 0x06032B15 RID: 207637 RVA: 0x006D7214 File Offset: 0x006D5414
		public bool IsLocked
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06032B16 RID: 207638 RVA: 0x006D7253 File Offset: 0x006D5453
		public static Offset<ISetForceLock> CreateISetForceLock(FlatBufferBuilder builder, int EntityId = 0, bool IsLocked = false)
		{
			builder.StartTable(2);
			ISetForceLock.AddEntityId(builder, EntityId);
			ISetForceLock.AddIsLocked(builder, IsLocked);
			return ISetForceLock.EndISetForceLock(builder);
		}

		// Token: 0x06032B17 RID: 207639 RVA: 0x006D7270 File Offset: 0x006D5470
		public static void StartISetForceLock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032B18 RID: 207640 RVA: 0x006D7279 File Offset: 0x006D5479
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06032B19 RID: 207641 RVA: 0x006D7284 File Offset: 0x006D5484
		public static void AddIsLocked(FlatBufferBuilder builder, bool isLocked)
		{
			builder.AddBool(1, isLocked, false);
		}

		// Token: 0x06032B1A RID: 207642 RVA: 0x006D728F File Offset: 0x006D548F
		public static Offset<ISetForceLock> EndISetForceLock(FlatBufferBuilder builder)
		{
			return new Offset<ISetForceLock>(builder.EndTable());
		}

		// Token: 0x06032B1B RID: 207643 RVA: 0x006D729C File Offset: 0x006D549C
		public ISetForceLockT UnPack()
		{
			ISetForceLockT setForceLockT = new ISetForceLockT();
			this.UnPackTo(setForceLockT);
			return setForceLockT;
		}

		// Token: 0x06032B1C RID: 207644 RVA: 0x006D72B7 File Offset: 0x006D54B7
		public void UnPackTo(ISetForceLockT _o)
		{
			_o.EntityId = this.EntityId;
			_o.IsLocked = this.IsLocked;
		}

		// Token: 0x06032B1D RID: 207645 RVA: 0x006D72D4 File Offset: 0x006D54D4
		public static Offset<ISetForceLock> Pack(FlatBufferBuilder builder, ISetForceLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetForceLock>);
			}
			return ISetForceLock.CreateISetForceLock(builder, _o.EntityId, _o.IsLocked);
		}

		// Token: 0x04011A13 RID: 72211
		private Table __p;
	}
}
