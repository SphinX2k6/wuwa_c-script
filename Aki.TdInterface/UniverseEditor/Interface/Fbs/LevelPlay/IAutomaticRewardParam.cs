using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004434 RID: 17460
	public struct IAutomaticRewardParam : IFlatbufferObject
	{
		// Token: 0x17007B02 RID: 31490
		// (get) Token: 0x06019F82 RID: 106370 RVA: 0x003B6AA8 File Offset: 0x003B4CA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019F83 RID: 106371 RVA: 0x003B6AB5 File Offset: 0x003B4CB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019F84 RID: 106372 RVA: 0x003B6ABC File Offset: 0x003B4CBC
		public static IAutomaticRewardParam GetRootAsIAutomaticRewardParam(ByteBuffer _bb)
		{
			return IAutomaticRewardParam.GetRootAsIAutomaticRewardParam(_bb, default(IAutomaticRewardParam));
		}

		// Token: 0x06019F85 RID: 106373 RVA: 0x003B6AD8 File Offset: 0x003B4CD8
		public static IAutomaticRewardParam GetRootAsIAutomaticRewardParam(ByteBuffer _bb, IAutomaticRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019F86 RID: 106374 RVA: 0x003B6AF5 File Offset: 0x003B4CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019F87 RID: 106375 RVA: 0x003B6B04 File Offset: 0x003B4D04
		public IAutomaticRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B03 RID: 31491
		// (get) Token: 0x06019F88 RID: 106376 RVA: 0x003B6B14 File Offset: 0x003B4D14
		public ELevelPlayRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRewardType.None;
				}
				return (ELevelPlayRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B04 RID: 31492
		// (get) Token: 0x06019F89 RID: 106377 RVA: 0x003B6B50 File Offset: 0x003B4D50
		public int RewardId
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

		// Token: 0x17007B05 RID: 31493
		// (get) Token: 0x06019F8A RID: 106378 RVA: 0x003B6B8C File Offset: 0x003B4D8C
		public int FirstRewardId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B06 RID: 31494
		// (get) Token: 0x06019F8B RID: 106379 RVA: 0x003B6BC8 File Offset: 0x003B4DC8
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

		// Token: 0x06019F8C RID: 106380 RVA: 0x003B6C05 File Offset: 0x003B4E05
		public static Offset<IAutomaticRewardParam> CreateIAutomaticRewardParam(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None, int RewardId = 0, int FirstRewardId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IAutomaticRewardParam.AddFirstRewardId(builder, FirstRewardId);
			IAutomaticRewardParam.AddRewardId(builder, RewardId);
			IAutomaticRewardParam.AddNullMask(builder, NullMask);
			IAutomaticRewardParam.AddType(builder, Type);
			return IAutomaticRewardParam.EndIAutomaticRewardParam(builder);
		}

		// Token: 0x06019F8D RID: 106381 RVA: 0x003B6C31 File Offset: 0x003B4E31
		public static void StartIAutomaticRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019F8E RID: 106382 RVA: 0x003B6C3A File Offset: 0x003B4E3A
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019F8F RID: 106383 RVA: 0x003B6C45 File Offset: 0x003B4E45
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x06019F90 RID: 106384 RVA: 0x003B6C50 File Offset: 0x003B4E50
		public static void AddFirstRewardId(FlatBufferBuilder builder, int firstRewardId)
		{
			builder.AddInt(2, firstRewardId, 0);
		}

		// Token: 0x06019F91 RID: 106385 RVA: 0x003B6C5B File Offset: 0x003B4E5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019F92 RID: 106386 RVA: 0x003B6C66 File Offset: 0x003B4E66
		public static Offset<IAutomaticRewardParam> EndIAutomaticRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<IAutomaticRewardParam>(builder.EndTable());
		}

		// Token: 0x06019F93 RID: 106387 RVA: 0x003B6C74 File Offset: 0x003B4E74
		public IAutomaticRewardParamT UnPack()
		{
			IAutomaticRewardParamT automaticRewardParamT = new IAutomaticRewardParamT();
			this.UnPackTo(automaticRewardParamT);
			return automaticRewardParamT;
		}

		// Token: 0x06019F94 RID: 106388 RVA: 0x003B6C8F File Offset: 0x003B4E8F
		public void UnPackTo(IAutomaticRewardParamT _o)
		{
			_o.Type = this.Type;
			_o.RewardId = this.RewardId;
			_o.FirstRewardId = this.FirstRewardId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019F95 RID: 106389 RVA: 0x003B6CC4 File Offset: 0x003B4EC4
		public static Offset<IAutomaticRewardParam> Pack(FlatBufferBuilder builder, IAutomaticRewardParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutomaticRewardParam>);
			}
			return IAutomaticRewardParam.CreateIAutomaticRewardParam(builder, _o.Type, _o.RewardId, _o.FirstRewardId, _o.NullMask);
		}

		// Token: 0x0400C400 RID: 50176
		private Table __p;
	}
}
