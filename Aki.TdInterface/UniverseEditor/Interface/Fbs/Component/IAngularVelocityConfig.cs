using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA1 RID: 20129
	public struct IAngularVelocityConfig : IFlatbufferObject
	{
		// Token: 0x17009059 RID: 36953
		// (get) Token: 0x0601FAE6 RID: 129766 RVA: 0x004694F0 File Offset: 0x004676F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FAE7 RID: 129767 RVA: 0x004694FD File Offset: 0x004676FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FAE8 RID: 129768 RVA: 0x00469504 File Offset: 0x00467704
		public static IAngularVelocityConfig GetRootAsIAngularVelocityConfig(ByteBuffer _bb)
		{
			return IAngularVelocityConfig.GetRootAsIAngularVelocityConfig(_bb, default(IAngularVelocityConfig));
		}

		// Token: 0x0601FAE9 RID: 129769 RVA: 0x00469520 File Offset: 0x00467720
		public static IAngularVelocityConfig GetRootAsIAngularVelocityConfig(ByteBuffer _bb, IAngularVelocityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FAEA RID: 129770 RVA: 0x0046953D File Offset: 0x0046773D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FAEB RID: 129771 RVA: 0x0046954C File Offset: 0x0046774C
		public IAngularVelocityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700905A RID: 36954
		// (get) Token: 0x0601FAEC RID: 129772 RVA: 0x0046955C File Offset: 0x0046775C
		public IRangedRandom? X
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IRangedRandom?(default(IRangedRandom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700905B RID: 36955
		// (get) Token: 0x0601FAED RID: 129773 RVA: 0x004695BC File Offset: 0x004677BC
		public IRangedRandom? Y
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRangedRandom?(default(IRangedRandom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700905C RID: 36956
		// (get) Token: 0x0601FAEE RID: 129774 RVA: 0x0046961C File Offset: 0x0046781C
		public IRangedRandom? Z
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IRangedRandom?(default(IRangedRandom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601FAEF RID: 129775 RVA: 0x00469679 File Offset: 0x00467879
		public static Offset<IAngularVelocityConfig> CreateIAngularVelocityConfig(FlatBufferBuilder builder, Offset<IRangedRandom> XOffset = default(Offset<IRangedRandom>), Offset<IRangedRandom> YOffset = default(Offset<IRangedRandom>), Offset<IRangedRandom> ZOffset = default(Offset<IRangedRandom>))
		{
			builder.StartTable(3);
			IAngularVelocityConfig.AddZ(builder, ZOffset);
			IAngularVelocityConfig.AddY(builder, YOffset);
			IAngularVelocityConfig.AddX(builder, XOffset);
			return IAngularVelocityConfig.EndIAngularVelocityConfig(builder);
		}

		// Token: 0x0601FAF0 RID: 129776 RVA: 0x0046969D File Offset: 0x0046789D
		public static void StartIAngularVelocityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FAF1 RID: 129777 RVA: 0x004696A6 File Offset: 0x004678A6
		public static void AddX(FlatBufferBuilder builder, Offset<IRangedRandom> xOffset)
		{
			builder.AddOffset(0, xOffset.Value, 0);
		}

		// Token: 0x0601FAF2 RID: 129778 RVA: 0x004696B6 File Offset: 0x004678B6
		public static void AddY(FlatBufferBuilder builder, Offset<IRangedRandom> yOffset)
		{
			builder.AddOffset(1, yOffset.Value, 0);
		}

		// Token: 0x0601FAF3 RID: 129779 RVA: 0x004696C6 File Offset: 0x004678C6
		public static void AddZ(FlatBufferBuilder builder, Offset<IRangedRandom> zOffset)
		{
			builder.AddOffset(2, zOffset.Value, 0);
		}

		// Token: 0x0601FAF4 RID: 129780 RVA: 0x004696D6 File Offset: 0x004678D6
		public static Offset<IAngularVelocityConfig> EndIAngularVelocityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAngularVelocityConfig>(builder.EndTable());
		}

		// Token: 0x0601FAF5 RID: 129781 RVA: 0x004696E4 File Offset: 0x004678E4
		public IAngularVelocityConfigT UnPack()
		{
			IAngularVelocityConfigT angularVelocityConfigT = new IAngularVelocityConfigT();
			this.UnPackTo(angularVelocityConfigT);
			return angularVelocityConfigT;
		}

		// Token: 0x0601FAF6 RID: 129782 RVA: 0x00469700 File Offset: 0x00467900
		public void UnPackTo(IAngularVelocityConfigT _o)
		{
			_o.X = ((this.X != null) ? this.X.Value.UnPack() : null);
			_o.Y = ((this.Y != null) ? this.Y.Value.UnPack() : null);
			_o.Z = ((this.Z != null) ? this.Z.Value.UnPack() : null);
		}

		// Token: 0x0601FAF7 RID: 129783 RVA: 0x0046979C File Offset: 0x0046799C
		public static Offset<IAngularVelocityConfig> Pack(FlatBufferBuilder builder, IAngularVelocityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAngularVelocityConfig>);
			}
			Offset<IRangedRandom> xoffset = (_o.X == null) ? default(Offset<IRangedRandom>) : IRangedRandom.Pack(builder, _o.X);
			Offset<IRangedRandom> yoffset = (_o.Y == null) ? default(Offset<IRangedRandom>) : IRangedRandom.Pack(builder, _o.Y);
			Offset<IRangedRandom> zoffset = (_o.Z == null) ? default(Offset<IRangedRandom>) : IRangedRandom.Pack(builder, _o.Z);
			return IAngularVelocityConfig.CreateIAngularVelocityConfig(builder, xoffset, yoffset, zoffset);
		}

		// Token: 0x0400DC7B RID: 56443
		private Table __p;
	}
}
