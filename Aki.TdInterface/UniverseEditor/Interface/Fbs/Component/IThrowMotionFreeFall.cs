using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006077 RID: 24695
	public struct IThrowMotionFreeFall : IFlatbufferObject
	{
		// Token: 0x1700B764 RID: 46948
		// (get) Token: 0x06029BAD RID: 170925 RVA: 0x005B2909 File Offset: 0x005B0B09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029BAE RID: 170926 RVA: 0x005B2916 File Offset: 0x005B0B16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029BAF RID: 170927 RVA: 0x005B2920 File Offset: 0x005B0B20
		public static IThrowMotionFreeFall GetRootAsIThrowMotionFreeFall(ByteBuffer _bb)
		{
			return IThrowMotionFreeFall.GetRootAsIThrowMotionFreeFall(_bb, default(IThrowMotionFreeFall));
		}

		// Token: 0x06029BB0 RID: 170928 RVA: 0x005B293C File Offset: 0x005B0B3C
		public static IThrowMotionFreeFall GetRootAsIThrowMotionFreeFall(ByteBuffer _bb, IThrowMotionFreeFall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029BB1 RID: 170929 RVA: 0x005B2959 File Offset: 0x005B0B59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BB2 RID: 170930 RVA: 0x005B2968 File Offset: 0x005B0B68
		public IThrowMotionFreeFall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B765 RID: 46949
		// (get) Token: 0x06029BB3 RID: 170931 RVA: 0x005B2978 File Offset: 0x005B0B78
		public EThrowMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EThrowMotion.Projectile;
				}
				return (EThrowMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B766 RID: 46950
		// (get) Token: 0x06029BB4 RID: 170932 RVA: 0x005B29B4 File Offset: 0x005B0BB4
		public IVectorInfo? Velocity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B767 RID: 46951
		// (get) Token: 0x06029BB5 RID: 170933 RVA: 0x005B2A14 File Offset: 0x005B0C14
		public IAngularVelocityConfig? AngularVelocity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAngularVelocityConfig?(default(IAngularVelocityConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029BB6 RID: 170934 RVA: 0x005B2A71 File Offset: 0x005B0C71
		public static Offset<IThrowMotionFreeFall> CreateIThrowMotionFreeFall(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile, Offset<IVectorInfo> VelocityOffset = default(Offset<IVectorInfo>), Offset<IAngularVelocityConfig> AngularVelocityOffset = default(Offset<IAngularVelocityConfig>))
		{
			builder.StartTable(3);
			IThrowMotionFreeFall.AddAngularVelocity(builder, AngularVelocityOffset);
			IThrowMotionFreeFall.AddVelocity(builder, VelocityOffset);
			IThrowMotionFreeFall.AddType(builder, Type);
			return IThrowMotionFreeFall.EndIThrowMotionFreeFall(builder);
		}

		// Token: 0x06029BB7 RID: 170935 RVA: 0x005B2A95 File Offset: 0x005B0C95
		public static void StartIThrowMotionFreeFall(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029BB8 RID: 170936 RVA: 0x005B2A9E File Offset: 0x005B0C9E
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029BB9 RID: 170937 RVA: 0x005B2AA9 File Offset: 0x005B0CA9
		public static void AddVelocity(FlatBufferBuilder builder, Offset<IVectorInfo> velocityOffset)
		{
			builder.AddOffset(1, velocityOffset.Value, 0);
		}

		// Token: 0x06029BBA RID: 170938 RVA: 0x005B2AB9 File Offset: 0x005B0CB9
		public static void AddAngularVelocity(FlatBufferBuilder builder, Offset<IAngularVelocityConfig> angularVelocityOffset)
		{
			builder.AddOffset(2, angularVelocityOffset.Value, 0);
		}

		// Token: 0x06029BBB RID: 170939 RVA: 0x005B2AC9 File Offset: 0x005B0CC9
		public static Offset<IThrowMotionFreeFall> EndIThrowMotionFreeFall(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotionFreeFall>(builder.EndTable());
		}

		// Token: 0x06029BBC RID: 170940 RVA: 0x005B2AD8 File Offset: 0x005B0CD8
		public IThrowMotionFreeFallT UnPack()
		{
			IThrowMotionFreeFallT throwMotionFreeFallT = new IThrowMotionFreeFallT();
			this.UnPackTo(throwMotionFreeFallT);
			return throwMotionFreeFallT;
		}

		// Token: 0x06029BBD RID: 170941 RVA: 0x005B2AF4 File Offset: 0x005B0CF4
		public void UnPackTo(IThrowMotionFreeFallT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = ((this.Velocity != null) ? this.Velocity.Value.UnPack() : null);
			_o.AngularVelocity = ((this.AngularVelocity != null) ? this.AngularVelocity.Value.UnPack() : null);
		}

		// Token: 0x06029BBE RID: 170942 RVA: 0x005B2B6C File Offset: 0x005B0D6C
		public static Offset<IThrowMotionFreeFall> Pack(FlatBufferBuilder builder, IThrowMotionFreeFallT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowMotionFreeFall>);
			}
			Offset<IVectorInfo> velocityOffset = (_o.Velocity == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Velocity);
			Offset<IAngularVelocityConfig> angularVelocityOffset = (_o.AngularVelocity == null) ? default(Offset<IAngularVelocityConfig>) : IAngularVelocityConfig.Pack(builder, _o.AngularVelocity);
			return IThrowMotionFreeFall.CreateIThrowMotionFreeFall(builder, _o.Type, velocityOffset, angularVelocityOffset);
		}

		// Token: 0x0400FDF2 RID: 65010
		private Table __p;
	}
}
