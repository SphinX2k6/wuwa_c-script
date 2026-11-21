using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200606B RID: 24683
	public struct IThrowCfg : IFlatbufferObject
	{
		// Token: 0x1700B74C RID: 46924
		// (get) Token: 0x06029B32 RID: 170802 RVA: 0x005B1829 File Offset: 0x005AFA29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B33 RID: 170803 RVA: 0x005B1836 File Offset: 0x005AFA36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B34 RID: 170804 RVA: 0x005B1840 File Offset: 0x005AFA40
		public static IThrowCfg GetRootAsIThrowCfg(ByteBuffer _bb)
		{
			return IThrowCfg.GetRootAsIThrowCfg(_bb, default(IThrowCfg));
		}

		// Token: 0x06029B35 RID: 170805 RVA: 0x005B185C File Offset: 0x005AFA5C
		public static IThrowCfg GetRootAsIThrowCfg(ByteBuffer _bb, IThrowCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B36 RID: 170806 RVA: 0x005B1879 File Offset: 0x005AFA79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B37 RID: 170807 RVA: 0x005B1888 File Offset: 0x005AFA88
		public IThrowCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B74D RID: 46925
		// (get) Token: 0x06029B38 RID: 170808 RVA: 0x005B1898 File Offset: 0x005AFA98
		public TThrowMotion MotionConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TThrowMotion.NONE;
				}
				return (TThrowMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029B39 RID: 170809 RVA: 0x005B18D4 File Offset: 0x005AFAD4
		public TTable? MotionConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029B3A RID: 170810 RVA: 0x005B1918 File Offset: 0x005AFB18
		public ICircumnutation MotionConfigAsICircumnutation()
		{
			return this.MotionConfig<ICircumnutation>().Value;
		}

		// Token: 0x06029B3B RID: 170811 RVA: 0x005B1934 File Offset: 0x005AFB34
		public IProjectileMotion MotionConfigAsIProjectileMotion()
		{
			return this.MotionConfig<IProjectileMotion>().Value;
		}

		// Token: 0x06029B3C RID: 170812 RVA: 0x005B1950 File Offset: 0x005AFB50
		public IThrowMotionFreeFall MotionConfigAsIThrowMotionFreeFall()
		{
			return this.MotionConfig<IThrowMotionFreeFall>().Value;
		}

		// Token: 0x06029B3D RID: 170813 RVA: 0x005B196C File Offset: 0x005AFB6C
		public IThrowMotionLevitate MotionConfigAsIThrowMotionLevitate()
		{
			return this.MotionConfig<IThrowMotionLevitate>().Value;
		}

		// Token: 0x06029B3E RID: 170814 RVA: 0x005B1988 File Offset: 0x005AFB88
		public IThrowMotionTrackTarget MotionConfigAsIThrowMotionTrackTarget()
		{
			return this.MotionConfig<IThrowMotionTrackTarget>().Value;
		}

		// Token: 0x06029B3F RID: 170815 RVA: 0x005B19A3 File Offset: 0x005AFBA3
		public static Offset<IThrowCfg> CreateIThrowCfg(FlatBufferBuilder builder, TThrowMotion MotionConfig_type = TThrowMotion.NONE, int MotionConfigOffset = 0)
		{
			builder.StartTable(2);
			IThrowCfg.AddMotionConfig(builder, MotionConfigOffset);
			IThrowCfg.AddMotionConfigType(builder, MotionConfig_type);
			return IThrowCfg.EndIThrowCfg(builder);
		}

		// Token: 0x06029B40 RID: 170816 RVA: 0x005B19C0 File Offset: 0x005AFBC0
		public static void StartIThrowCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029B41 RID: 170817 RVA: 0x005B19C9 File Offset: 0x005AFBC9
		public static void AddMotionConfigType(FlatBufferBuilder builder, TThrowMotion motionConfigType)
		{
			builder.AddByte(0, (byte)motionConfigType, 0);
		}

		// Token: 0x06029B42 RID: 170818 RVA: 0x005B19D4 File Offset: 0x005AFBD4
		public static void AddMotionConfig(FlatBufferBuilder builder, int motionConfigOffset)
		{
			builder.AddOffset(1, motionConfigOffset, 0);
		}

		// Token: 0x06029B43 RID: 170819 RVA: 0x005B19DF File Offset: 0x005AFBDF
		public static Offset<IThrowCfg> EndIThrowCfg(FlatBufferBuilder builder)
		{
			return new Offset<IThrowCfg>(builder.EndTable());
		}

		// Token: 0x06029B44 RID: 170820 RVA: 0x005B19EC File Offset: 0x005AFBEC
		public IThrowCfgT UnPack()
		{
			IThrowCfgT throwCfgT = new IThrowCfgT();
			this.UnPackTo(throwCfgT);
			return throwCfgT;
		}

		// Token: 0x06029B45 RID: 170821 RVA: 0x005B1A08 File Offset: 0x005AFC08
		public void UnPackTo(IThrowCfgT _o)
		{
			_o.MotionConfig = new TThrowMotionUnion();
			_o.MotionConfig.Type = this.MotionConfigType;
			switch (this.MotionConfigType)
			{
			case TThrowMotion.ICircumnutation:
				_o.MotionConfig.Value = ((this.MotionConfig<ICircumnutation>() != null) ? this.MotionConfig<ICircumnutation>().Value.UnPack() : null);
				return;
			case TThrowMotion.IProjectileMotion:
				_o.MotionConfig.Value = ((this.MotionConfig<IProjectileMotion>() != null) ? this.MotionConfig<IProjectileMotion>().Value.UnPack() : null);
				return;
			case TThrowMotion.IThrowMotionFreeFall:
				_o.MotionConfig.Value = ((this.MotionConfig<IThrowMotionFreeFall>() != null) ? this.MotionConfig<IThrowMotionFreeFall>().Value.UnPack() : null);
				return;
			case TThrowMotion.IThrowMotionLevitate:
				_o.MotionConfig.Value = ((this.MotionConfig<IThrowMotionLevitate>() != null) ? this.MotionConfig<IThrowMotionLevitate>().Value.UnPack() : null);
				return;
			case TThrowMotion.IThrowMotionTrackTarget:
				_o.MotionConfig.Value = ((this.MotionConfig<IThrowMotionTrackTarget>() != null) ? this.MotionConfig<IThrowMotionTrackTarget>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06029B46 RID: 170822 RVA: 0x005B1B68 File Offset: 0x005AFD68
		public static Offset<IThrowCfg> Pack(FlatBufferBuilder builder, IThrowCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowCfg>);
			}
			TThrowMotion motionConfig_type = (_o.MotionConfig == null) ? TThrowMotion.NONE : _o.MotionConfig.Type;
			int motionConfigOffset = (_o.MotionConfig == null) ? 0 : TThrowMotionUnion.Pack(builder, _o.MotionConfig);
			return IThrowCfg.CreateIThrowCfg(builder, motionConfig_type, motionConfigOffset);
		}

		// Token: 0x0400FDE4 RID: 64996
		private Table __p;
	}
}
