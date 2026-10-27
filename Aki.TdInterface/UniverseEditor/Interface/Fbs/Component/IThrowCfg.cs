using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5E RID: 23134
	public struct IThrowCfg : IFlatbufferObject
	{
		// Token: 0x1700AE14 RID: 44564
		// (get) Token: 0x060275BA RID: 161210 RVA: 0x0056A81D File Offset: 0x00568A1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060275BB RID: 161211 RVA: 0x0056A82A File Offset: 0x00568A2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060275BC RID: 161212 RVA: 0x0056A834 File Offset: 0x00568A34
		public static IThrowCfg GetRootAsIThrowCfg(ByteBuffer _bb)
		{
			return IThrowCfg.GetRootAsIThrowCfg(_bb, default(IThrowCfg));
		}

		// Token: 0x060275BD RID: 161213 RVA: 0x0056A850 File Offset: 0x00568A50
		public static IThrowCfg GetRootAsIThrowCfg(ByteBuffer _bb, IThrowCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060275BE RID: 161214 RVA: 0x0056A86D File Offset: 0x00568A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060275BF RID: 161215 RVA: 0x0056A87C File Offset: 0x00568A7C
		public IThrowCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE15 RID: 44565
		// (get) Token: 0x060275C0 RID: 161216 RVA: 0x0056A88C File Offset: 0x00568A8C
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

		// Token: 0x060275C1 RID: 161217 RVA: 0x0056A8C8 File Offset: 0x00568AC8
		public TTable? MotionConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060275C2 RID: 161218 RVA: 0x0056A90C File Offset: 0x00568B0C
		public ICircumnutation MotionConfigAsICircumnutation()
		{
			return this.MotionConfig<ICircumnutation>().Value;
		}

		// Token: 0x060275C3 RID: 161219 RVA: 0x0056A928 File Offset: 0x00568B28
		public IProjectileMotion MotionConfigAsIProjectileMotion()
		{
			return this.MotionConfig<IProjectileMotion>().Value;
		}

		// Token: 0x060275C4 RID: 161220 RVA: 0x0056A944 File Offset: 0x00568B44
		public IThrowMotionFreeFall MotionConfigAsIThrowMotionFreeFall()
		{
			return this.MotionConfig<IThrowMotionFreeFall>().Value;
		}

		// Token: 0x060275C5 RID: 161221 RVA: 0x0056A960 File Offset: 0x00568B60
		public IThrowMotionLevitate MotionConfigAsIThrowMotionLevitate()
		{
			return this.MotionConfig<IThrowMotionLevitate>().Value;
		}

		// Token: 0x060275C6 RID: 161222 RVA: 0x0056A97C File Offset: 0x00568B7C
		public IThrowMotionTrackTarget MotionConfigAsIThrowMotionTrackTarget()
		{
			return this.MotionConfig<IThrowMotionTrackTarget>().Value;
		}

		// Token: 0x060275C7 RID: 161223 RVA: 0x0056A997 File Offset: 0x00568B97
		public static Offset<IThrowCfg> CreateIThrowCfg(FlatBufferBuilder builder, TThrowMotion MotionConfig_type = TThrowMotion.NONE, int MotionConfigOffset = 0)
		{
			builder.StartTable(2);
			IThrowCfg.AddMotionConfig(builder, MotionConfigOffset);
			IThrowCfg.AddMotionConfigType(builder, MotionConfig_type);
			return IThrowCfg.EndIThrowCfg(builder);
		}

		// Token: 0x060275C8 RID: 161224 RVA: 0x0056A9B4 File Offset: 0x00568BB4
		public static void StartIThrowCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060275C9 RID: 161225 RVA: 0x0056A9BD File Offset: 0x00568BBD
		public static void AddMotionConfigType(FlatBufferBuilder builder, TThrowMotion motionConfigType)
		{
			builder.AddByte(0, (byte)motionConfigType, 0);
		}

		// Token: 0x060275CA RID: 161226 RVA: 0x0056A9C8 File Offset: 0x00568BC8
		public static void AddMotionConfig(FlatBufferBuilder builder, int motionConfigOffset)
		{
			builder.AddOffset(1, motionConfigOffset, 0);
		}

		// Token: 0x060275CB RID: 161227 RVA: 0x0056A9D3 File Offset: 0x00568BD3
		public static Offset<IThrowCfg> EndIThrowCfg(FlatBufferBuilder builder)
		{
			return new Offset<IThrowCfg>(builder.EndTable());
		}

		// Token: 0x060275CC RID: 161228 RVA: 0x0056A9E0 File Offset: 0x00568BE0
		public IThrowCfgT UnPack()
		{
			IThrowCfgT throwCfgT = new IThrowCfgT();
			this.UnPackTo(throwCfgT);
			return throwCfgT;
		}

		// Token: 0x060275CD RID: 161229 RVA: 0x0056A9FC File Offset: 0x00568BFC
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

		// Token: 0x060275CE RID: 161230 RVA: 0x0056AB5C File Offset: 0x00568D5C
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

		// Token: 0x0400F0ED RID: 61677
		private Table __p;
	}
}
