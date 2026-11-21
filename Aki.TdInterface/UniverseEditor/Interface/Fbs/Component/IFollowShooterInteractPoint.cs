using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580B RID: 22539
	public struct IFollowShooterInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700A31D RID: 41757
		// (get) Token: 0x06024758 RID: 149336 RVA: 0x00502932 File Offset: 0x00500B32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024759 RID: 149337 RVA: 0x0050293F File Offset: 0x00500B3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602475A RID: 149338 RVA: 0x00502948 File Offset: 0x00500B48
		public static IFollowShooterInteractPoint GetRootAsIFollowShooterInteractPoint(ByteBuffer _bb)
		{
			return IFollowShooterInteractPoint.GetRootAsIFollowShooterInteractPoint(_bb, default(IFollowShooterInteractPoint));
		}

		// Token: 0x0602475B RID: 149339 RVA: 0x00502964 File Offset: 0x00500B64
		public static IFollowShooterInteractPoint GetRootAsIFollowShooterInteractPoint(ByteBuffer _bb, IFollowShooterInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602475C RID: 149340 RVA: 0x00502981 File Offset: 0x00500B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602475D RID: 149341 RVA: 0x00502990 File Offset: 0x00500B90
		public IFollowShooterInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A31E RID: 41758
		// (get) Token: 0x0602475E RID: 149342 RVA: 0x005029A0 File Offset: 0x00500BA0
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A31F RID: 41759
		// (get) Token: 0x0602475F RID: 149343 RVA: 0x005029DC File Offset: 0x00500BDC
		public IThrowFollowShooterInteractConfig? ThrowInteractConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IThrowFollowShooterInteractConfig?(default(IThrowFollowShooterInteractConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024760 RID: 149344 RVA: 0x00502A39 File Offset: 0x00500C39
		public static Offset<IFollowShooterInteractPoint> CreateIFollowShooterInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, Offset<IThrowFollowShooterInteractConfig> ThrowInteractConfigOffset = default(Offset<IThrowFollowShooterInteractConfig>))
		{
			builder.StartTable(2);
			IFollowShooterInteractPoint.AddThrowInteractConfig(builder, ThrowInteractConfigOffset);
			IFollowShooterInteractPoint.AddType(builder, Type);
			return IFollowShooterInteractPoint.EndIFollowShooterInteractPoint(builder);
		}

		// Token: 0x06024761 RID: 149345 RVA: 0x00502A56 File Offset: 0x00500C56
		public static void StartIFollowShooterInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024762 RID: 149346 RVA: 0x00502A5F File Offset: 0x00500C5F
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024763 RID: 149347 RVA: 0x00502A6A File Offset: 0x00500C6A
		public static void AddThrowInteractConfig(FlatBufferBuilder builder, Offset<IThrowFollowShooterInteractConfig> throwInteractConfigOffset)
		{
			builder.AddOffset(1, throwInteractConfigOffset.Value, 0);
		}

		// Token: 0x06024764 RID: 149348 RVA: 0x00502A7A File Offset: 0x00500C7A
		public static Offset<IFollowShooterInteractPoint> EndIFollowShooterInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterInteractPoint>(builder.EndTable());
		}

		// Token: 0x06024765 RID: 149349 RVA: 0x00502A88 File Offset: 0x00500C88
		public IFollowShooterInteractPointT UnPack()
		{
			IFollowShooterInteractPointT followShooterInteractPointT = new IFollowShooterInteractPointT();
			this.UnPackTo(followShooterInteractPointT);
			return followShooterInteractPointT;
		}

		// Token: 0x06024766 RID: 149350 RVA: 0x00502AA4 File Offset: 0x00500CA4
		public void UnPackTo(IFollowShooterInteractPointT _o)
		{
			_o.Type = this.Type;
			_o.ThrowInteractConfig = ((this.ThrowInteractConfig != null) ? this.ThrowInteractConfig.Value.UnPack() : null);
		}

		// Token: 0x06024767 RID: 149351 RVA: 0x00502AEC File Offset: 0x00500CEC
		public static Offset<IFollowShooterInteractPoint> Pack(FlatBufferBuilder builder, IFollowShooterInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterInteractPoint>);
			}
			Offset<IThrowFollowShooterInteractConfig> throwInteractConfigOffset = (_o.ThrowInteractConfig == null) ? default(Offset<IThrowFollowShooterInteractConfig>) : IThrowFollowShooterInteractConfig.Pack(builder, _o.ThrowInteractConfig);
			return IFollowShooterInteractPoint.CreateIFollowShooterInteractPoint(builder, _o.Type, throwInteractConfigOffset);
		}

		// Token: 0x0400F022 RID: 61474
		private Table __p;
	}
}
