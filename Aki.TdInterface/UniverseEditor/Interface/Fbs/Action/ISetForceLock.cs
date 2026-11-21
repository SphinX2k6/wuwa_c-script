using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077BB RID: 30651
	public struct ISetForceLock : IFlatbufferObject
	{
		// Token: 0x1700E0B9 RID: 57529
		// (get) Token: 0x06035D74 RID: 220532 RVA: 0x00736DAE File Offset: 0x00734FAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D75 RID: 220533 RVA: 0x00736DBB File Offset: 0x00734FBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D76 RID: 220534 RVA: 0x00736DC4 File Offset: 0x00734FC4
		public static ISetForceLock GetRootAsISetForceLock(ByteBuffer _bb)
		{
			return ISetForceLock.GetRootAsISetForceLock(_bb, default(ISetForceLock));
		}

		// Token: 0x06035D77 RID: 220535 RVA: 0x00736DE0 File Offset: 0x00734FE0
		public static ISetForceLock GetRootAsISetForceLock(ByteBuffer _bb, ISetForceLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D78 RID: 220536 RVA: 0x00736DFD File Offset: 0x00734FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D79 RID: 220537 RVA: 0x00736E0C File Offset: 0x0073500C
		public ISetForceLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E0BA RID: 57530
		// (get) Token: 0x06035D7A RID: 220538 RVA: 0x00736E1C File Offset: 0x0073501C
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

		// Token: 0x1700E0BB RID: 57531
		// (get) Token: 0x06035D7B RID: 220539 RVA: 0x00736E58 File Offset: 0x00735058
		public bool IsLocked
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035D7C RID: 220540 RVA: 0x00736E97 File Offset: 0x00735097
		public static Offset<ISetForceLock> CreateISetForceLock(FlatBufferBuilder builder, int EntityId = 0, bool IsLocked = false)
		{
			builder.StartTable(2);
			ISetForceLock.AddEntityId(builder, EntityId);
			ISetForceLock.AddIsLocked(builder, IsLocked);
			return ISetForceLock.EndISetForceLock(builder);
		}

		// Token: 0x06035D7D RID: 220541 RVA: 0x00736EB4 File Offset: 0x007350B4
		public static void StartISetForceLock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035D7E RID: 220542 RVA: 0x00736EBD File Offset: 0x007350BD
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06035D7F RID: 220543 RVA: 0x00736EC8 File Offset: 0x007350C8
		public static void AddIsLocked(FlatBufferBuilder builder, bool isLocked)
		{
			builder.AddBool(1, isLocked, false);
		}

		// Token: 0x06035D80 RID: 220544 RVA: 0x00736ED3 File Offset: 0x007350D3
		public static Offset<ISetForceLock> EndISetForceLock(FlatBufferBuilder builder)
		{
			return new Offset<ISetForceLock>(builder.EndTable());
		}

		// Token: 0x06035D81 RID: 220545 RVA: 0x00736EE0 File Offset: 0x007350E0
		public ISetForceLockT UnPack()
		{
			ISetForceLockT setForceLockT = new ISetForceLockT();
			this.UnPackTo(setForceLockT);
			return setForceLockT;
		}

		// Token: 0x06035D82 RID: 220546 RVA: 0x00736EFB File Offset: 0x007350FB
		public void UnPackTo(ISetForceLockT _o)
		{
			_o.EntityId = this.EntityId;
			_o.IsLocked = this.IsLocked;
		}

		// Token: 0x06035D83 RID: 220547 RVA: 0x00736F18 File Offset: 0x00735118
		public static Offset<ISetForceLock> Pack(FlatBufferBuilder builder, ISetForceLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetForceLock>);
			}
			return ISetForceLock.CreateISetForceLock(builder, _o.EntityId, _o.IsLocked);
		}

		// Token: 0x040129F8 RID: 76280
		private Table __p;
	}
}
