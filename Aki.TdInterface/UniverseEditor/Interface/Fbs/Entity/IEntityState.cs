using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D2 RID: 18386
	public struct IEntityState : IFlatbufferObject
	{
		// Token: 0x17008417 RID: 33815
		// (get) Token: 0x0601C681 RID: 116353 RVA: 0x00404FBF File Offset: 0x004031BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C682 RID: 116354 RVA: 0x00404FCC File Offset: 0x004031CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C683 RID: 116355 RVA: 0x00404FD4 File Offset: 0x004031D4
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb)
		{
			return IEntityState.GetRootAsIEntityState(_bb, default(IEntityState));
		}

		// Token: 0x0601C684 RID: 116356 RVA: 0x00404FF0 File Offset: 0x004031F0
		public static IEntityState GetRootAsIEntityState(ByteBuffer _bb, IEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C685 RID: 116357 RVA: 0x0040500D File Offset: 0x0040320D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C686 RID: 116358 RVA: 0x0040501C File Offset: 0x0040321C
		public IEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008418 RID: 33816
		// (get) Token: 0x0601C687 RID: 116359 RVA: 0x0040502C File Offset: 0x0040322C
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

		// Token: 0x17008419 RID: 33817
		// (get) Token: 0x0601C688 RID: 116360 RVA: 0x00405068 File Offset: 0x00403268
		public IEntityData? Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityData?(default(IEntityData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C689 RID: 116361 RVA: 0x004050C5 File Offset: 0x004032C5
		public static Offset<IEntityState> CreateIEntityState(FlatBufferBuilder builder, int EntityId = 0, Offset<IEntityData> DataOffset = default(Offset<IEntityData>))
		{
			builder.StartTable(2);
			IEntityState.AddData(builder, DataOffset);
			IEntityState.AddEntityId(builder, EntityId);
			return IEntityState.EndIEntityState(builder);
		}

		// Token: 0x0601C68A RID: 116362 RVA: 0x004050E2 File Offset: 0x004032E2
		public static void StartIEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C68B RID: 116363 RVA: 0x004050EB File Offset: 0x004032EB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0601C68C RID: 116364 RVA: 0x004050F6 File Offset: 0x004032F6
		public static void AddData(FlatBufferBuilder builder, Offset<IEntityData> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0601C68D RID: 116365 RVA: 0x00405106 File Offset: 0x00403306
		public static Offset<IEntityState> EndIEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IEntityState>(builder.EndTable());
		}

		// Token: 0x0601C68E RID: 116366 RVA: 0x00405114 File Offset: 0x00403314
		public IEntityStateT UnPack()
		{
			IEntityStateT entityStateT = new IEntityStateT();
			this.UnPackTo(entityStateT);
			return entityStateT;
		}

		// Token: 0x0601C68F RID: 116367 RVA: 0x00405130 File Offset: 0x00403330
		public void UnPackTo(IEntityStateT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0601C690 RID: 116368 RVA: 0x00405178 File Offset: 0x00403378
		public static Offset<IEntityState> Pack(FlatBufferBuilder builder, IEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityState>);
			}
			Offset<IEntityData> dataOffset = (_o.Data == null) ? default(Offset<IEntityData>) : IEntityData.Pack(builder, _o.Data);
			return IEntityState.CreateIEntityState(builder, _o.EntityId, dataOffset);
		}

		// Token: 0x0400CC61 RID: 52321
		private Table __p;
	}
}
