using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007291 RID: 29329
	public struct IMoveOnWallConfig : IFlatbufferObject
	{
		// Token: 0x1700D6FE RID: 55038
		// (get) Token: 0x060331BE RID: 209342 RVA: 0x006E593B File Offset: 0x006E3B3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331BF RID: 209343 RVA: 0x006E5948 File Offset: 0x006E3B48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060331C0 RID: 209344 RVA: 0x006E5950 File Offset: 0x006E3B50
		public static IMoveOnWallConfig GetRootAsIMoveOnWallConfig(ByteBuffer _bb)
		{
			return IMoveOnWallConfig.GetRootAsIMoveOnWallConfig(_bb, default(IMoveOnWallConfig));
		}

		// Token: 0x060331C1 RID: 209345 RVA: 0x006E596C File Offset: 0x006E3B6C
		public static IMoveOnWallConfig GetRootAsIMoveOnWallConfig(ByteBuffer _bb, IMoveOnWallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060331C2 RID: 209346 RVA: 0x006E5989 File Offset: 0x006E3B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060331C3 RID: 209347 RVA: 0x006E5998 File Offset: 0x006E3B98
		public IMoveOnWallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6FF RID: 55039
		// (get) Token: 0x060331C4 RID: 209348 RVA: 0x006E59A8 File Offset: 0x006E3BA8
		public IVectorInfo? WallDetectDir
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060331C5 RID: 209349 RVA: 0x006E5A05 File Offset: 0x006E3C05
		public static Offset<IMoveOnWallConfig> CreateIMoveOnWallConfig(FlatBufferBuilder builder, Offset<IVectorInfo> WallDetectDirOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IMoveOnWallConfig.AddWallDetectDir(builder, WallDetectDirOffset);
			return IMoveOnWallConfig.EndIMoveOnWallConfig(builder);
		}

		// Token: 0x060331C6 RID: 209350 RVA: 0x006E5A1B File Offset: 0x006E3C1B
		public static void StartIMoveOnWallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060331C7 RID: 209351 RVA: 0x006E5A24 File Offset: 0x006E3C24
		public static void AddWallDetectDir(FlatBufferBuilder builder, Offset<IVectorInfo> wallDetectDirOffset)
		{
			builder.AddOffset(0, wallDetectDirOffset.Value, 0);
		}

		// Token: 0x060331C8 RID: 209352 RVA: 0x006E5A34 File Offset: 0x006E3C34
		public static Offset<IMoveOnWallConfig> EndIMoveOnWallConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMoveOnWallConfig>(builder.EndTable());
		}

		// Token: 0x060331C9 RID: 209353 RVA: 0x006E5A44 File Offset: 0x006E3C44
		public IMoveOnWallConfigT UnPack()
		{
			IMoveOnWallConfigT moveOnWallConfigT = new IMoveOnWallConfigT();
			this.UnPackTo(moveOnWallConfigT);
			return moveOnWallConfigT;
		}

		// Token: 0x060331CA RID: 209354 RVA: 0x006E5A60 File Offset: 0x006E3C60
		public void UnPackTo(IMoveOnWallConfigT _o)
		{
			_o.WallDetectDir = ((this.WallDetectDir != null) ? this.WallDetectDir.Value.UnPack() : null);
		}

		// Token: 0x060331CB RID: 209355 RVA: 0x006E5A9C File Offset: 0x006E3C9C
		public static Offset<IMoveOnWallConfig> Pack(FlatBufferBuilder builder, IMoveOnWallConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveOnWallConfig>);
			}
			Offset<IVectorInfo> wallDetectDirOffset = (_o.WallDetectDir == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.WallDetectDir);
			return IMoveOnWallConfig.CreateIMoveOnWallConfig(builder, wallDetectDirOffset);
		}

		// Token: 0x04012314 RID: 74516
		private Table __p;
	}
}
