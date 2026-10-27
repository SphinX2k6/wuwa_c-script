using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A6A RID: 23146
	public struct IThrowMotionFreeFall : IFlatbufferObject
	{
		// Token: 0x1700AE2C RID: 44588
		// (get) Token: 0x06027635 RID: 161333 RVA: 0x0056B8FD File Offset: 0x00569AFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027636 RID: 161334 RVA: 0x0056B90A File Offset: 0x00569B0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027637 RID: 161335 RVA: 0x0056B914 File Offset: 0x00569B14
		public static IThrowMotionFreeFall GetRootAsIThrowMotionFreeFall(ByteBuffer _bb)
		{
			return IThrowMotionFreeFall.GetRootAsIThrowMotionFreeFall(_bb, default(IThrowMotionFreeFall));
		}

		// Token: 0x06027638 RID: 161336 RVA: 0x0056B930 File Offset: 0x00569B30
		public static IThrowMotionFreeFall GetRootAsIThrowMotionFreeFall(ByteBuffer _bb, IThrowMotionFreeFall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027639 RID: 161337 RVA: 0x0056B94D File Offset: 0x00569B4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602763A RID: 161338 RVA: 0x0056B95C File Offset: 0x00569B5C
		public IThrowMotionFreeFall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE2D RID: 44589
		// (get) Token: 0x0602763B RID: 161339 RVA: 0x0056B96C File Offset: 0x00569B6C
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

		// Token: 0x1700AE2E RID: 44590
		// (get) Token: 0x0602763C RID: 161340 RVA: 0x0056B9A8 File Offset: 0x00569BA8
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

		// Token: 0x1700AE2F RID: 44591
		// (get) Token: 0x0602763D RID: 161341 RVA: 0x0056BA08 File Offset: 0x00569C08
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

		// Token: 0x0602763E RID: 161342 RVA: 0x0056BA65 File Offset: 0x00569C65
		public static Offset<IThrowMotionFreeFall> CreateIThrowMotionFreeFall(FlatBufferBuilder builder, EThrowMotion Type = EThrowMotion.Projectile, Offset<IVectorInfo> VelocityOffset = default(Offset<IVectorInfo>), Offset<IAngularVelocityConfig> AngularVelocityOffset = default(Offset<IAngularVelocityConfig>))
		{
			builder.StartTable(3);
			IThrowMotionFreeFall.AddAngularVelocity(builder, AngularVelocityOffset);
			IThrowMotionFreeFall.AddVelocity(builder, VelocityOffset);
			IThrowMotionFreeFall.AddType(builder, Type);
			return IThrowMotionFreeFall.EndIThrowMotionFreeFall(builder);
		}

		// Token: 0x0602763F RID: 161343 RVA: 0x0056BA89 File Offset: 0x00569C89
		public static void StartIThrowMotionFreeFall(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027640 RID: 161344 RVA: 0x0056BA92 File Offset: 0x00569C92
		public static void AddType(FlatBufferBuilder builder, EThrowMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027641 RID: 161345 RVA: 0x0056BA9D File Offset: 0x00569C9D
		public static void AddVelocity(FlatBufferBuilder builder, Offset<IVectorInfo> velocityOffset)
		{
			builder.AddOffset(1, velocityOffset.Value, 0);
		}

		// Token: 0x06027642 RID: 161346 RVA: 0x0056BAAD File Offset: 0x00569CAD
		public static void AddAngularVelocity(FlatBufferBuilder builder, Offset<IAngularVelocityConfig> angularVelocityOffset)
		{
			builder.AddOffset(2, angularVelocityOffset.Value, 0);
		}

		// Token: 0x06027643 RID: 161347 RVA: 0x0056BABD File Offset: 0x00569CBD
		public static Offset<IThrowMotionFreeFall> EndIThrowMotionFreeFall(FlatBufferBuilder builder)
		{
			return new Offset<IThrowMotionFreeFall>(builder.EndTable());
		}

		// Token: 0x06027644 RID: 161348 RVA: 0x0056BACC File Offset: 0x00569CCC
		public IThrowMotionFreeFallT UnPack()
		{
			IThrowMotionFreeFallT throwMotionFreeFallT = new IThrowMotionFreeFallT();
			this.UnPackTo(throwMotionFreeFallT);
			return throwMotionFreeFallT;
		}

		// Token: 0x06027645 RID: 161349 RVA: 0x0056BAE8 File Offset: 0x00569CE8
		public void UnPackTo(IThrowMotionFreeFallT _o)
		{
			_o.Type = this.Type;
			_o.Velocity = ((this.Velocity != null) ? this.Velocity.Value.UnPack() : null);
			_o.AngularVelocity = ((this.AngularVelocity != null) ? this.AngularVelocity.Value.UnPack() : null);
		}

		// Token: 0x06027646 RID: 161350 RVA: 0x0056BB60 File Offset: 0x00569D60
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

		// Token: 0x0400F0FB RID: 61691
		private Table __p;
	}
}
