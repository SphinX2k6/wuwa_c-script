using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200504B RID: 20555
	public struct ICurveControlConfig : IFlatbufferObject
	{
		// Token: 0x17009529 RID: 38185
		// (get) Token: 0x06020F09 RID: 134921 RVA: 0x00494483 File Offset: 0x00492683
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F0A RID: 134922 RVA: 0x00494490 File Offset: 0x00492690
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F0B RID: 134923 RVA: 0x00494498 File Offset: 0x00492698
		public static ICurveControlConfig GetRootAsICurveControlConfig(ByteBuffer _bb)
		{
			return ICurveControlConfig.GetRootAsICurveControlConfig(_bb, default(ICurveControlConfig));
		}

		// Token: 0x06020F0C RID: 134924 RVA: 0x004944B4 File Offset: 0x004926B4
		public static ICurveControlConfig GetRootAsICurveControlConfig(ByteBuffer _bb, ICurveControlConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F0D RID: 134925 RVA: 0x004944D1 File Offset: 0x004926D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F0E RID: 134926 RVA: 0x004944E0 File Offset: 0x004926E0
		public ICurveControlConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700952A RID: 38186
		// (get) Token: 0x06020F0F RID: 134927 RVA: 0x004944F0 File Offset: 0x004926F0
		public ECurveControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECurveControlType.ChargeSlash;
				}
				return (ECurveControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F10 RID: 134928 RVA: 0x0049452C File Offset: 0x0049272C
		public static Offset<ICurveControlConfig> CreateICurveControlConfig(FlatBufferBuilder builder, ECurveControlType Type = ECurveControlType.ChargeSlash)
		{
			builder.StartTable(1);
			ICurveControlConfig.AddType(builder, Type);
			return ICurveControlConfig.EndICurveControlConfig(builder);
		}

		// Token: 0x06020F11 RID: 134929 RVA: 0x00494542 File Offset: 0x00492742
		public static void StartICurveControlConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020F12 RID: 134930 RVA: 0x0049454B File Offset: 0x0049274B
		public static void AddType(FlatBufferBuilder builder, ECurveControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F13 RID: 134931 RVA: 0x00494556 File Offset: 0x00492756
		public static Offset<ICurveControlConfig> EndICurveControlConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICurveControlConfig>(builder.EndTable());
		}

		// Token: 0x06020F14 RID: 134932 RVA: 0x00494564 File Offset: 0x00492764
		public ICurveControlConfigT UnPack()
		{
			ICurveControlConfigT curveControlConfigT = new ICurveControlConfigT();
			this.UnPackTo(curveControlConfigT);
			return curveControlConfigT;
		}

		// Token: 0x06020F15 RID: 134933 RVA: 0x0049457F File Offset: 0x0049277F
		public void UnPackTo(ICurveControlConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020F16 RID: 134934 RVA: 0x00494590 File Offset: 0x00492790
		public static Offset<ICurveControlConfig> Pack(FlatBufferBuilder builder, ICurveControlConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICurveControlConfig>);
			}
			return ICurveControlConfig.CreateICurveControlConfig(builder, _o.Type);
		}

		// Token: 0x0400E040 RID: 57408
		private Table __p;
	}
}
