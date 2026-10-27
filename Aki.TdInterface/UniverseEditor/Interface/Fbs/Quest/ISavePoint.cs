using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004103 RID: 16643
	public struct ISavePoint : IFlatbufferObject
	{
		// Token: 0x17007549 RID: 30025
		// (get) Token: 0x06018433 RID: 99379 RVA: 0x0037DFD9 File Offset: 0x0037C1D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018434 RID: 99380 RVA: 0x0037DFE6 File Offset: 0x0037C1E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018435 RID: 99381 RVA: 0x0037DFF0 File Offset: 0x0037C1F0
		public static ISavePoint GetRootAsISavePoint(ByteBuffer _bb)
		{
			return ISavePoint.GetRootAsISavePoint(_bb, default(ISavePoint));
		}

		// Token: 0x06018436 RID: 99382 RVA: 0x0037E00C File Offset: 0x0037C20C
		public static ISavePoint GetRootAsISavePoint(ByteBuffer _bb, ISavePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018437 RID: 99383 RVA: 0x0037E029 File Offset: 0x0037C229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018438 RID: 99384 RVA: 0x0037E038 File Offset: 0x0037C238
		public ISavePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700754A RID: 30026
		// (get) Token: 0x06018439 RID: 99385 RVA: 0x0037E048 File Offset: 0x0037C248
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

		// Token: 0x1700754B RID: 30027
		// (get) Token: 0x0601843A RID: 99386 RVA: 0x0037E084 File Offset: 0x0037C284
		public bool RelinkRollback
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700754C RID: 30028
		// (get) Token: 0x0601843B RID: 99387 RVA: 0x0037E0C4 File Offset: 0x0037C2C4
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

		// Token: 0x1700754D RID: 30029
		// (get) Token: 0x0601843C RID: 99388 RVA: 0x0037E124 File Offset: 0x0037C324
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

		// Token: 0x0601843D RID: 99389 RVA: 0x0037E161 File Offset: 0x0037C361
		public static Offset<ISavePoint> CreateISavePoint(FlatBufferBuilder builder, ESaveConfig Type = ESaveConfig.SaveNew, bool RelinkRollback = false, Offset<IPositionRollbackConfig> PosRollbackCfgOffset = default(Offset<IPositionRollbackConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISavePoint.AddPosRollbackCfg(builder, PosRollbackCfgOffset);
			ISavePoint.AddNullMask(builder, NullMask);
			ISavePoint.AddRelinkRollback(builder, RelinkRollback);
			ISavePoint.AddType(builder, Type);
			return ISavePoint.EndISavePoint(builder);
		}

		// Token: 0x0601843E RID: 99390 RVA: 0x0037E18D File Offset: 0x0037C38D
		public static void StartISavePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601843F RID: 99391 RVA: 0x0037E196 File Offset: 0x0037C396
		public static void AddType(FlatBufferBuilder builder, ESaveConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018440 RID: 99392 RVA: 0x0037E1A1 File Offset: 0x0037C3A1
		public static void AddRelinkRollback(FlatBufferBuilder builder, bool relinkRollback)
		{
			builder.AddBool(1, relinkRollback, false);
		}

		// Token: 0x06018441 RID: 99393 RVA: 0x0037E1AC File Offset: 0x0037C3AC
		public static void AddPosRollbackCfg(FlatBufferBuilder builder, Offset<IPositionRollbackConfig> posRollbackCfgOffset)
		{
			builder.AddOffset(2, posRollbackCfgOffset.Value, 0);
		}

		// Token: 0x06018442 RID: 99394 RVA: 0x0037E1BC File Offset: 0x0037C3BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06018443 RID: 99395 RVA: 0x0037E1C7 File Offset: 0x0037C3C7
		public static Offset<ISavePoint> EndISavePoint(FlatBufferBuilder builder)
		{
			return new Offset<ISavePoint>(builder.EndTable());
		}

		// Token: 0x06018444 RID: 99396 RVA: 0x0037E1D4 File Offset: 0x0037C3D4
		public ISavePointT UnPack()
		{
			ISavePointT savePointT = new ISavePointT();
			this.UnPackTo(savePointT);
			return savePointT;
		}

		// Token: 0x06018445 RID: 99397 RVA: 0x0037E1F0 File Offset: 0x0037C3F0
		public void UnPackTo(ISavePointT _o)
		{
			_o.Type = this.Type;
			_o.RelinkRollback = this.RelinkRollback;
			_o.PosRollbackCfg = ((this.PosRollbackCfg != null) ? this.PosRollbackCfg.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018446 RID: 99398 RVA: 0x0037E250 File Offset: 0x0037C450
		public static Offset<ISavePoint> Pack(FlatBufferBuilder builder, ISavePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISavePoint>);
			}
			Offset<IPositionRollbackConfig> posRollbackCfgOffset = (_o.PosRollbackCfg == null) ? default(Offset<IPositionRollbackConfig>) : IPositionRollbackConfig.Pack(builder, _o.PosRollbackCfg);
			return ISavePoint.CreateISavePoint(builder, _o.Type, _o.RelinkRollback, posRollbackCfgOffset, _o.NullMask);
		}

		// Token: 0x0400BCA4 RID: 48292
		private Table __p;
	}
}
