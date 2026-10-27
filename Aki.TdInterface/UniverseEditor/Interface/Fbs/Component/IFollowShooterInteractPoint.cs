using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A3 RID: 21155
	public struct IFollowShooterInteractPoint : IFlatbufferObject
	{
		// Token: 0x17009B1F RID: 39711
		// (get) Token: 0x060227BE RID: 141246 RVA: 0x004C7DC2 File Offset: 0x004C5FC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060227BF RID: 141247 RVA: 0x004C7DCF File Offset: 0x004C5FCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060227C0 RID: 141248 RVA: 0x004C7DD8 File Offset: 0x004C5FD8
		public static IFollowShooterInteractPoint GetRootAsIFollowShooterInteractPoint(ByteBuffer _bb)
		{
			return IFollowShooterInteractPoint.GetRootAsIFollowShooterInteractPoint(_bb, default(IFollowShooterInteractPoint));
		}

		// Token: 0x060227C1 RID: 141249 RVA: 0x004C7DF4 File Offset: 0x004C5FF4
		public static IFollowShooterInteractPoint GetRootAsIFollowShooterInteractPoint(ByteBuffer _bb, IFollowShooterInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060227C2 RID: 141250 RVA: 0x004C7E11 File Offset: 0x004C6011
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060227C3 RID: 141251 RVA: 0x004C7E20 File Offset: 0x004C6020
		public IFollowShooterInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B20 RID: 39712
		// (get) Token: 0x060227C4 RID: 141252 RVA: 0x004C7E30 File Offset: 0x004C6030
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

		// Token: 0x17009B21 RID: 39713
		// (get) Token: 0x060227C5 RID: 141253 RVA: 0x004C7E6C File Offset: 0x004C606C
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

		// Token: 0x060227C6 RID: 141254 RVA: 0x004C7EC9 File Offset: 0x004C60C9
		public static Offset<IFollowShooterInteractPoint> CreateIFollowShooterInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, Offset<IThrowFollowShooterInteractConfig> ThrowInteractConfigOffset = default(Offset<IThrowFollowShooterInteractConfig>))
		{
			builder.StartTable(2);
			IFollowShooterInteractPoint.AddThrowInteractConfig(builder, ThrowInteractConfigOffset);
			IFollowShooterInteractPoint.AddType(builder, Type);
			return IFollowShooterInteractPoint.EndIFollowShooterInteractPoint(builder);
		}

		// Token: 0x060227C7 RID: 141255 RVA: 0x004C7EE6 File Offset: 0x004C60E6
		public static void StartIFollowShooterInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060227C8 RID: 141256 RVA: 0x004C7EEF File Offset: 0x004C60EF
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060227C9 RID: 141257 RVA: 0x004C7EFA File Offset: 0x004C60FA
		public static void AddThrowInteractConfig(FlatBufferBuilder builder, Offset<IThrowFollowShooterInteractConfig> throwInteractConfigOffset)
		{
			builder.AddOffset(1, throwInteractConfigOffset.Value, 0);
		}

		// Token: 0x060227CA RID: 141258 RVA: 0x004C7F0A File Offset: 0x004C610A
		public static Offset<IFollowShooterInteractPoint> EndIFollowShooterInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterInteractPoint>(builder.EndTable());
		}

		// Token: 0x060227CB RID: 141259 RVA: 0x004C7F18 File Offset: 0x004C6118
		public IFollowShooterInteractPointT UnPack()
		{
			IFollowShooterInteractPointT followShooterInteractPointT = new IFollowShooterInteractPointT();
			this.UnPackTo(followShooterInteractPointT);
			return followShooterInteractPointT;
		}

		// Token: 0x060227CC RID: 141260 RVA: 0x004C7F34 File Offset: 0x004C6134
		public void UnPackTo(IFollowShooterInteractPointT _o)
		{
			_o.Type = this.Type;
			_o.ThrowInteractConfig = ((this.ThrowInteractConfig != null) ? this.ThrowInteractConfig.Value.UnPack() : null);
		}

		// Token: 0x060227CD RID: 141261 RVA: 0x004C7F7C File Offset: 0x004C617C
		public static Offset<IFollowShooterInteractPoint> Pack(FlatBufferBuilder builder, IFollowShooterInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterInteractPoint>);
			}
			Offset<IThrowFollowShooterInteractConfig> throwInteractConfigOffset = (_o.ThrowInteractConfig == null) ? default(Offset<IThrowFollowShooterInteractConfig>) : IThrowFollowShooterInteractConfig.Pack(builder, _o.ThrowInteractConfig);
			return IFollowShooterInteractPoint.CreateIFollowShooterInteractPoint(builder, _o.Type, throwInteractConfigOffset);
		}

		// Token: 0x0400E41B RID: 58395
		private Table __p;
	}
}
