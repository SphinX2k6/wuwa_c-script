using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4B RID: 27467
	public struct IMoveOnWallConfig : IFlatbufferObject
	{
		// Token: 0x1700CC19 RID: 52249
		// (get) Token: 0x06030367 RID: 197479 RVA: 0x0068D37F File Offset: 0x0068B57F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030368 RID: 197480 RVA: 0x0068D38C File Offset: 0x0068B58C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030369 RID: 197481 RVA: 0x0068D394 File Offset: 0x0068B594
		public static IMoveOnWallConfig GetRootAsIMoveOnWallConfig(ByteBuffer _bb)
		{
			return IMoveOnWallConfig.GetRootAsIMoveOnWallConfig(_bb, default(IMoveOnWallConfig));
		}

		// Token: 0x0603036A RID: 197482 RVA: 0x0068D3B0 File Offset: 0x0068B5B0
		public static IMoveOnWallConfig GetRootAsIMoveOnWallConfig(ByteBuffer _bb, IMoveOnWallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603036B RID: 197483 RVA: 0x0068D3CD File Offset: 0x0068B5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603036C RID: 197484 RVA: 0x0068D3DC File Offset: 0x0068B5DC
		public IMoveOnWallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC1A RID: 52250
		// (get) Token: 0x0603036D RID: 197485 RVA: 0x0068D3EC File Offset: 0x0068B5EC
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

		// Token: 0x0603036E RID: 197486 RVA: 0x0068D449 File Offset: 0x0068B649
		public static Offset<IMoveOnWallConfig> CreateIMoveOnWallConfig(FlatBufferBuilder builder, Offset<IVectorInfo> WallDetectDirOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IMoveOnWallConfig.AddWallDetectDir(builder, WallDetectDirOffset);
			return IMoveOnWallConfig.EndIMoveOnWallConfig(builder);
		}

		// Token: 0x0603036F RID: 197487 RVA: 0x0068D45F File Offset: 0x0068B65F
		public static void StartIMoveOnWallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030370 RID: 197488 RVA: 0x0068D468 File Offset: 0x0068B668
		public static void AddWallDetectDir(FlatBufferBuilder builder, Offset<IVectorInfo> wallDetectDirOffset)
		{
			builder.AddOffset(0, wallDetectDirOffset.Value, 0);
		}

		// Token: 0x06030371 RID: 197489 RVA: 0x0068D478 File Offset: 0x0068B678
		public static Offset<IMoveOnWallConfig> EndIMoveOnWallConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMoveOnWallConfig>(builder.EndTable());
		}

		// Token: 0x06030372 RID: 197490 RVA: 0x0068D488 File Offset: 0x0068B688
		public IMoveOnWallConfigT UnPack()
		{
			IMoveOnWallConfigT moveOnWallConfigT = new IMoveOnWallConfigT();
			this.UnPackTo(moveOnWallConfigT);
			return moveOnWallConfigT;
		}

		// Token: 0x06030373 RID: 197491 RVA: 0x0068D4A4 File Offset: 0x0068B6A4
		public void UnPackTo(IMoveOnWallConfigT _o)
		{
			_o.WallDetectDir = ((this.WallDetectDir != null) ? this.WallDetectDir.Value.UnPack() : null);
		}

		// Token: 0x06030374 RID: 197492 RVA: 0x0068D4E0 File Offset: 0x0068B6E0
		public static Offset<IMoveOnWallConfig> Pack(FlatBufferBuilder builder, IMoveOnWallConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveOnWallConfig>);
			}
			Offset<IVectorInfo> wallDetectDirOffset = (_o.WallDetectDir == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.WallDetectDir);
			return IMoveOnWallConfig.CreateIMoveOnWallConfig(builder, wallDetectDirOffset);
		}

		// Token: 0x040113EB RID: 70635
		private Table __p;
	}
}
