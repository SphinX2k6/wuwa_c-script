using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F4B RID: 24395
	public struct ISnapAngleConfig : IFlatbufferObject
	{
		// Token: 0x1700B4B2 RID: 46258
		// (get) Token: 0x06028FF8 RID: 167928 RVA: 0x00599DA1 File Offset: 0x00597FA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028FF9 RID: 167929 RVA: 0x00599DAE File Offset: 0x00597FAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028FFA RID: 167930 RVA: 0x00599DB8 File Offset: 0x00597FB8
		public static ISnapAngleConfig GetRootAsISnapAngleConfig(ByteBuffer _bb)
		{
			return ISnapAngleConfig.GetRootAsISnapAngleConfig(_bb, default(ISnapAngleConfig));
		}

		// Token: 0x06028FFB RID: 167931 RVA: 0x00599DD4 File Offset: 0x00597FD4
		public static ISnapAngleConfig GetRootAsISnapAngleConfig(ByteBuffer _bb, ISnapAngleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028FFC RID: 167932 RVA: 0x00599DF1 File Offset: 0x00597FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028FFD RID: 167933 RVA: 0x00599E00 File Offset: 0x00598000
		public ISnapAngleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4B3 RID: 46259
		// (get) Token: 0x06028FFE RID: 167934 RVA: 0x00599E10 File Offset: 0x00598010
		public float Angle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B4B4 RID: 46260
		// (get) Token: 0x06028FFF RID: 167935 RVA: 0x00599E50 File Offset: 0x00598050
		public float Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029000 RID: 167936 RVA: 0x00599E90 File Offset: 0x00598090
		public static Offset<ISnapAngleConfig> CreateISnapAngleConfig(FlatBufferBuilder builder, float Angle = 0f, float Range = 0f)
		{
			builder.StartTable(2);
			ISnapAngleConfig.AddRange(builder, Range);
			ISnapAngleConfig.AddAngle(builder, Angle);
			return ISnapAngleConfig.EndISnapAngleConfig(builder);
		}

		// Token: 0x06029001 RID: 167937 RVA: 0x00599EAD File Offset: 0x005980AD
		public static void StartISnapAngleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029002 RID: 167938 RVA: 0x00599EB6 File Offset: 0x005980B6
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(0, angle, 0.0);
		}

		// Token: 0x06029003 RID: 167939 RVA: 0x00599EC9 File Offset: 0x005980C9
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x06029004 RID: 167940 RVA: 0x00599EDC File Offset: 0x005980DC
		public static Offset<ISnapAngleConfig> EndISnapAngleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISnapAngleConfig>(builder.EndTable());
		}

		// Token: 0x06029005 RID: 167941 RVA: 0x00599EEC File Offset: 0x005980EC
		public ISnapAngleConfigT UnPack()
		{
			ISnapAngleConfigT snapAngleConfigT = new ISnapAngleConfigT();
			this.UnPackTo(snapAngleConfigT);
			return snapAngleConfigT;
		}

		// Token: 0x06029006 RID: 167942 RVA: 0x00599F07 File Offset: 0x00598107
		public void UnPackTo(ISnapAngleConfigT _o)
		{
			_o.Angle = this.Angle;
			_o.Range = this.Range;
		}

		// Token: 0x06029007 RID: 167943 RVA: 0x00599F24 File Offset: 0x00598124
		public static Offset<ISnapAngleConfig> Pack(FlatBufferBuilder builder, ISnapAngleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISnapAngleConfig>);
			}
			return ISnapAngleConfig.CreateISnapAngleConfig(builder, _o.Angle, _o.Range);
		}

		// Token: 0x0400FC05 RID: 64517
		private Table __p;
	}
}
