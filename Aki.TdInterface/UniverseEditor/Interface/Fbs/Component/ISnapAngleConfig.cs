using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593E RID: 22846
	public struct ISnapAngleConfig : IFlatbufferObject
	{
		// Token: 0x1700AB7E RID: 43902
		// (get) Token: 0x06026A8E RID: 158350 RVA: 0x00553135 File Offset: 0x00551335
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A8F RID: 158351 RVA: 0x00553142 File Offset: 0x00551342
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A90 RID: 158352 RVA: 0x0055314C File Offset: 0x0055134C
		public static ISnapAngleConfig GetRootAsISnapAngleConfig(ByteBuffer _bb)
		{
			return ISnapAngleConfig.GetRootAsISnapAngleConfig(_bb, default(ISnapAngleConfig));
		}

		// Token: 0x06026A91 RID: 158353 RVA: 0x00553168 File Offset: 0x00551368
		public static ISnapAngleConfig GetRootAsISnapAngleConfig(ByteBuffer _bb, ISnapAngleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A92 RID: 158354 RVA: 0x00553185 File Offset: 0x00551385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A93 RID: 158355 RVA: 0x00553194 File Offset: 0x00551394
		public ISnapAngleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB7F RID: 43903
		// (get) Token: 0x06026A94 RID: 158356 RVA: 0x005531A4 File Offset: 0x005513A4
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

		// Token: 0x1700AB80 RID: 43904
		// (get) Token: 0x06026A95 RID: 158357 RVA: 0x005531E4 File Offset: 0x005513E4
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

		// Token: 0x06026A96 RID: 158358 RVA: 0x00553224 File Offset: 0x00551424
		public static Offset<ISnapAngleConfig> CreateISnapAngleConfig(FlatBufferBuilder builder, float Angle = 0f, float Range = 0f)
		{
			builder.StartTable(2);
			ISnapAngleConfig.AddRange(builder, Range);
			ISnapAngleConfig.AddAngle(builder, Angle);
			return ISnapAngleConfig.EndISnapAngleConfig(builder);
		}

		// Token: 0x06026A97 RID: 158359 RVA: 0x00553241 File Offset: 0x00551441
		public static void StartISnapAngleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026A98 RID: 158360 RVA: 0x0055324A File Offset: 0x0055144A
		public static void AddAngle(FlatBufferBuilder builder, float angle)
		{
			builder.AddFloat(0, angle, 0.0);
		}

		// Token: 0x06026A99 RID: 158361 RVA: 0x0055325D File Offset: 0x0055145D
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x06026A9A RID: 158362 RVA: 0x00553270 File Offset: 0x00551470
		public static Offset<ISnapAngleConfig> EndISnapAngleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISnapAngleConfig>(builder.EndTable());
		}

		// Token: 0x06026A9B RID: 158363 RVA: 0x00553280 File Offset: 0x00551480
		public ISnapAngleConfigT UnPack()
		{
			ISnapAngleConfigT snapAngleConfigT = new ISnapAngleConfigT();
			this.UnPackTo(snapAngleConfigT);
			return snapAngleConfigT;
		}

		// Token: 0x06026A9C RID: 158364 RVA: 0x0055329B File Offset: 0x0055149B
		public void UnPackTo(ISnapAngleConfigT _o)
		{
			_o.Angle = this.Angle;
			_o.Range = this.Range;
		}

		// Token: 0x06026A9D RID: 158365 RVA: 0x005532B8 File Offset: 0x005514B8
		public static Offset<ISnapAngleConfig> Pack(FlatBufferBuilder builder, ISnapAngleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISnapAngleConfig>);
			}
			return ISnapAngleConfig.CreateISnapAngleConfig(builder, _o.Angle, _o.Range);
		}

		// Token: 0x0400EF10 RID: 61200
		private Table __p;
	}
}
