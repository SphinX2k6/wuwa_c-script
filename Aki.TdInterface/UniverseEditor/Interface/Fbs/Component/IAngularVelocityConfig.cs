using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CA RID: 21450
	public struct IAngularVelocityConfig : IFlatbufferObject
	{
		// Token: 0x170097B8 RID: 38840
		// (get) Token: 0x060217DB RID: 137179 RVA: 0x0049E754 File Offset: 0x0049C954
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060217DC RID: 137180 RVA: 0x0049E761 File Offset: 0x0049C961
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060217DD RID: 137181 RVA: 0x0049E768 File Offset: 0x0049C968
		public static IAngularVelocityConfig GetRootAsIAngularVelocityConfig(ByteBuffer _bb)
		{
			return IAngularVelocityConfig.GetRootAsIAngularVelocityConfig(_bb, default(IAngularVelocityConfig));
		}

		// Token: 0x060217DE RID: 137182 RVA: 0x0049E784 File Offset: 0x0049C984
		public static IAngularVelocityConfig GetRootAsIAngularVelocityConfig(ByteBuffer _bb, IAngularVelocityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060217DF RID: 137183 RVA: 0x0049E7A1 File Offset: 0x0049C9A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060217E0 RID: 137184 RVA: 0x0049E7B0 File Offset: 0x0049C9B0
		public IAngularVelocityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097B9 RID: 38841
		// (get) Token: 0x060217E1 RID: 137185 RVA: 0x0049E7C0 File Offset: 0x0049C9C0
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

		// Token: 0x170097BA RID: 38842
		// (get) Token: 0x060217E2 RID: 137186 RVA: 0x0049E820 File Offset: 0x0049CA20
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

		// Token: 0x170097BB RID: 38843
		// (get) Token: 0x060217E3 RID: 137187 RVA: 0x0049E880 File Offset: 0x0049CA80
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

		// Token: 0x060217E4 RID: 137188 RVA: 0x0049E8DD File Offset: 0x0049CADD
		public static Offset<IAngularVelocityConfig> CreateIAngularVelocityConfig(FlatBufferBuilder builder, Offset<IRangedRandom> XOffset = default(Offset<IRangedRandom>), Offset<IRangedRandom> YOffset = default(Offset<IRangedRandom>), Offset<IRangedRandom> ZOffset = default(Offset<IRangedRandom>))
		{
			builder.StartTable(3);
			IAngularVelocityConfig.AddZ(builder, ZOffset);
			IAngularVelocityConfig.AddY(builder, YOffset);
			IAngularVelocityConfig.AddX(builder, XOffset);
			return IAngularVelocityConfig.EndIAngularVelocityConfig(builder);
		}

		// Token: 0x060217E5 RID: 137189 RVA: 0x0049E901 File Offset: 0x0049CB01
		public static void StartIAngularVelocityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060217E6 RID: 137190 RVA: 0x0049E90A File Offset: 0x0049CB0A
		public static void AddX(FlatBufferBuilder builder, Offset<IRangedRandom> xOffset)
		{
			builder.AddOffset(0, xOffset.Value, 0);
		}

		// Token: 0x060217E7 RID: 137191 RVA: 0x0049E91A File Offset: 0x0049CB1A
		public static void AddY(FlatBufferBuilder builder, Offset<IRangedRandom> yOffset)
		{
			builder.AddOffset(1, yOffset.Value, 0);
		}

		// Token: 0x060217E8 RID: 137192 RVA: 0x0049E92A File Offset: 0x0049CB2A
		public static void AddZ(FlatBufferBuilder builder, Offset<IRangedRandom> zOffset)
		{
			builder.AddOffset(2, zOffset.Value, 0);
		}

		// Token: 0x060217E9 RID: 137193 RVA: 0x0049E93A File Offset: 0x0049CB3A
		public static Offset<IAngularVelocityConfig> EndIAngularVelocityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAngularVelocityConfig>(builder.EndTable());
		}

		// Token: 0x060217EA RID: 137194 RVA: 0x0049E948 File Offset: 0x0049CB48
		public IAngularVelocityConfigT UnPack()
		{
			IAngularVelocityConfigT angularVelocityConfigT = new IAngularVelocityConfigT();
			this.UnPackTo(angularVelocityConfigT);
			return angularVelocityConfigT;
		}

		// Token: 0x060217EB RID: 137195 RVA: 0x0049E964 File Offset: 0x0049CB64
		public void UnPackTo(IAngularVelocityConfigT _o)
		{
			_o.X = ((this.X != null) ? this.X.Value.UnPack() : null);
			_o.Y = ((this.Y != null) ? this.Y.Value.UnPack() : null);
			_o.Z = ((this.Z != null) ? this.Z.Value.UnPack() : null);
		}

		// Token: 0x060217EC RID: 137196 RVA: 0x0049EA00 File Offset: 0x0049CC00
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

		// Token: 0x0400E816 RID: 59414
		private Table __p;
	}
}
