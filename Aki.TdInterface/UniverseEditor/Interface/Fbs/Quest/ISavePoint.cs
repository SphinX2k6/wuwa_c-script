using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004544 RID: 17732
	public struct ISavePoint : IFlatbufferObject
	{
		// Token: 0x17007B4F RID: 31567
		// (get) Token: 0x06019AD4 RID: 105172 RVA: 0x003A7F29 File Offset: 0x003A6129
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019AD5 RID: 105173 RVA: 0x003A7F36 File Offset: 0x003A6136
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019AD6 RID: 105174 RVA: 0x003A7F40 File Offset: 0x003A6140
		public static ISavePoint GetRootAsISavePoint(ByteBuffer _bb)
		{
			return ISavePoint.GetRootAsISavePoint(_bb, default(ISavePoint));
		}

		// Token: 0x06019AD7 RID: 105175 RVA: 0x003A7F5C File Offset: 0x003A615C
		public static ISavePoint GetRootAsISavePoint(ByteBuffer _bb, ISavePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019AD8 RID: 105176 RVA: 0x003A7F79 File Offset: 0x003A6179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019AD9 RID: 105177 RVA: 0x003A7F88 File Offset: 0x003A6188
		public ISavePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B50 RID: 31568
		// (get) Token: 0x06019ADA RID: 105178 RVA: 0x003A7F98 File Offset: 0x003A6198
		public ESaveConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESaveConfig.SaveNew;
				}
				return (ESaveConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B51 RID: 31569
		// (get) Token: 0x06019ADB RID: 105179 RVA: 0x003A7FD4 File Offset: 0x003A61D4
		public bool RelinkRollback
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007B52 RID: 31570
		// (get) Token: 0x06019ADC RID: 105180 RVA: 0x003A8014 File Offset: 0x003A6214
		public IPositionRollbackConfig? PosRollbackCfg
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPositionRollbackConfig?(default(IPositionRollbackConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007B53 RID: 31571
		// (get) Token: 0x06019ADD RID: 105181 RVA: 0x003A8074 File Offset: 0x003A6274
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

		// Token: 0x06019ADE RID: 105182 RVA: 0x003A80B1 File Offset: 0x003A62B1
		public static Offset<ISavePoint> CreateISavePoint(FlatBufferBuilder builder, ESaveConfig Type = ESaveConfig.SaveNew, bool RelinkRollback = false, Offset<IPositionRollbackConfig> PosRollbackCfgOffset = default(Offset<IPositionRollbackConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISavePoint.AddPosRollbackCfg(builder, PosRollbackCfgOffset);
			ISavePoint.AddNullMask(builder, NullMask);
			ISavePoint.AddRelinkRollback(builder, RelinkRollback);
			ISavePoint.AddType(builder, Type);
			return ISavePoint.EndISavePoint(builder);
		}

		// Token: 0x06019ADF RID: 105183 RVA: 0x003A80DD File Offset: 0x003A62DD
		public static void StartISavePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019AE0 RID: 105184 RVA: 0x003A80E6 File Offset: 0x003A62E6
		public static void AddType(FlatBufferBuilder builder, ESaveConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019AE1 RID: 105185 RVA: 0x003A80F1 File Offset: 0x003A62F1
		public static void AddRelinkRollback(FlatBufferBuilder builder, bool relinkRollback)
		{
			builder.AddBool(1, relinkRollback, false);
		}

		// Token: 0x06019AE2 RID: 105186 RVA: 0x003A80FC File Offset: 0x003A62FC
		public static void AddPosRollbackCfg(FlatBufferBuilder builder, Offset<IPositionRollbackConfig> posRollbackCfgOffset)
		{
			builder.AddOffset(2, posRollbackCfgOffset.Value, 0);
		}

		// Token: 0x06019AE3 RID: 105187 RVA: 0x003A810C File Offset: 0x003A630C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019AE4 RID: 105188 RVA: 0x003A8117 File Offset: 0x003A6317
		public static Offset<ISavePoint> EndISavePoint(FlatBufferBuilder builder)
		{
			return new Offset<ISavePoint>(builder.EndTable());
		}

		// Token: 0x06019AE5 RID: 105189 RVA: 0x003A8124 File Offset: 0x003A6324
		public ISavePointT UnPack()
		{
			ISavePointT savePointT = new ISavePointT();
			this.UnPackTo(savePointT);
			return savePointT;
		}

		// Token: 0x06019AE6 RID: 105190 RVA: 0x003A8140 File Offset: 0x003A6340
		public void UnPackTo(ISavePointT _o)
		{
			_o.Type = this.Type;
			_o.RelinkRollback = this.RelinkRollback;
			_o.PosRollbackCfg = ((this.PosRollbackCfg != null) ? this.PosRollbackCfg.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019AE7 RID: 105191 RVA: 0x003A81A0 File Offset: 0x003A63A0
		public static Offset<ISavePoint> Pack(FlatBufferBuilder builder, ISavePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISavePoint>);
			}
			Offset<IPositionRollbackConfig> posRollbackCfgOffset = (_o.PosRollbackCfg == null) ? default(Offset<IPositionRollbackConfig>) : IPositionRollbackConfig.Pack(builder, _o.PosRollbackCfg);
			return ISavePoint.CreateISavePoint(builder, _o.Type, _o.RelinkRollback, posRollbackCfgOffset, _o.NullMask);
		}

		// Token: 0x0400C68D RID: 50829
		private Table __p;
	}
}
