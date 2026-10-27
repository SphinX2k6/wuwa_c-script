using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E5 RID: 22757
	public struct ISceneTextGuideUiScaleConfig : IFlatbufferObject
	{
		// Token: 0x1700AA75 RID: 43637
		// (get) Token: 0x060266DA RID: 157402 RVA: 0x0054BB2F File Offset: 0x00549D2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060266DB RID: 157403 RVA: 0x0054BB3C File Offset: 0x00549D3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060266DC RID: 157404 RVA: 0x0054BB44 File Offset: 0x00549D44
		public static ISceneTextGuideUiScaleConfig GetRootAsISceneTextGuideUiScaleConfig(ByteBuffer _bb)
		{
			return ISceneTextGuideUiScaleConfig.GetRootAsISceneTextGuideUiScaleConfig(_bb, default(ISceneTextGuideUiScaleConfig));
		}

		// Token: 0x060266DD RID: 157405 RVA: 0x0054BB60 File Offset: 0x00549D60
		public static ISceneTextGuideUiScaleConfig GetRootAsISceneTextGuideUiScaleConfig(ByteBuffer _bb, ISceneTextGuideUiScaleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060266DE RID: 157406 RVA: 0x0054BB7D File Offset: 0x00549D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060266DF RID: 157407 RVA: 0x0054BB8C File Offset: 0x00549D8C
		public ISceneTextGuideUiScaleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA76 RID: 43638
		// (get) Token: 0x060266E0 RID: 157408 RVA: 0x0054BB9C File Offset: 0x00549D9C
		public int MinDist
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA77 RID: 43639
		// (get) Token: 0x060266E1 RID: 157409 RVA: 0x0054BBD8 File Offset: 0x00549DD8
		public int MaxDist
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA78 RID: 43640
		// (get) Token: 0x060266E2 RID: 157410 RVA: 0x0054BC14 File Offset: 0x00549E14
		public float MinScale
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA79 RID: 43641
		// (get) Token: 0x060266E3 RID: 157411 RVA: 0x0054BC54 File Offset: 0x00549E54
		public float MaxScale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA7A RID: 43642
		// (get) Token: 0x060266E4 RID: 157412 RVA: 0x0054BC98 File Offset: 0x00549E98
		public ESceneTextGuideUiScaleType ScaleType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ESceneTextGuideUiScaleType.FarBigNearSmall;
				}
				return (ESceneTextGuideUiScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060266E5 RID: 157413 RVA: 0x0054BCD5 File Offset: 0x00549ED5
		public static Offset<ISceneTextGuideUiScaleConfig> CreateISceneTextGuideUiScaleConfig(FlatBufferBuilder builder, int MinDist = 0, int MaxDist = 0, float MinScale = 0f, float MaxScale = 0f, ESceneTextGuideUiScaleType ScaleType = ESceneTextGuideUiScaleType.FarBigNearSmall)
		{
			builder.StartTable(5);
			ISceneTextGuideUiScaleConfig.AddMaxScale(builder, MaxScale);
			ISceneTextGuideUiScaleConfig.AddMinScale(builder, MinScale);
			ISceneTextGuideUiScaleConfig.AddMaxDist(builder, MaxDist);
			ISceneTextGuideUiScaleConfig.AddMinDist(builder, MinDist);
			ISceneTextGuideUiScaleConfig.AddScaleType(builder, ScaleType);
			return ISceneTextGuideUiScaleConfig.EndISceneTextGuideUiScaleConfig(builder);
		}

		// Token: 0x060266E6 RID: 157414 RVA: 0x0054BD09 File Offset: 0x00549F09
		public static void StartISceneTextGuideUiScaleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060266E7 RID: 157415 RVA: 0x0054BD12 File Offset: 0x00549F12
		public static void AddMinDist(FlatBufferBuilder builder, int minDist)
		{
			builder.AddInt(0, minDist, 0);
		}

		// Token: 0x060266E8 RID: 157416 RVA: 0x0054BD1D File Offset: 0x00549F1D
		public static void AddMaxDist(FlatBufferBuilder builder, int maxDist)
		{
			builder.AddInt(1, maxDist, 0);
		}

		// Token: 0x060266E9 RID: 157417 RVA: 0x0054BD28 File Offset: 0x00549F28
		public static void AddMinScale(FlatBufferBuilder builder, float minScale)
		{
			builder.AddFloat(2, minScale, 0.0);
		}

		// Token: 0x060266EA RID: 157418 RVA: 0x0054BD3B File Offset: 0x00549F3B
		public static void AddMaxScale(FlatBufferBuilder builder, float maxScale)
		{
			builder.AddFloat(3, maxScale, 0.0);
		}

		// Token: 0x060266EB RID: 157419 RVA: 0x0054BD4E File Offset: 0x00549F4E
		public static void AddScaleType(FlatBufferBuilder builder, ESceneTextGuideUiScaleType scaleType)
		{
			builder.AddByte(4, (byte)scaleType, 0);
		}

		// Token: 0x060266EC RID: 157420 RVA: 0x0054BD59 File Offset: 0x00549F59
		public static Offset<ISceneTextGuideUiScaleConfig> EndISceneTextGuideUiScaleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUiScaleConfig>(builder.EndTable());
		}

		// Token: 0x060266ED RID: 157421 RVA: 0x0054BD68 File Offset: 0x00549F68
		public ISceneTextGuideUiScaleConfigT UnPack()
		{
			ISceneTextGuideUiScaleConfigT sceneTextGuideUiScaleConfigT = new ISceneTextGuideUiScaleConfigT();
			this.UnPackTo(sceneTextGuideUiScaleConfigT);
			return sceneTextGuideUiScaleConfigT;
		}

		// Token: 0x060266EE RID: 157422 RVA: 0x0054BD83 File Offset: 0x00549F83
		public void UnPackTo(ISceneTextGuideUiScaleConfigT _o)
		{
			_o.MinDist = this.MinDist;
			_o.MaxDist = this.MaxDist;
			_o.MinScale = this.MinScale;
			_o.MaxScale = this.MaxScale;
			_o.ScaleType = this.ScaleType;
		}

		// Token: 0x060266EF RID: 157423 RVA: 0x0054BDC4 File Offset: 0x00549FC4
		public static Offset<ISceneTextGuideUiScaleConfig> Pack(FlatBufferBuilder builder, ISceneTextGuideUiScaleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextGuideUiScaleConfig>);
			}
			return ISceneTextGuideUiScaleConfig.CreateISceneTextGuideUiScaleConfig(builder, _o.MinDist, _o.MaxDist, _o.MinScale, _o.MaxScale, _o.ScaleType);
		}

		// Token: 0x0400EE6D RID: 61037
		private Table __p;
	}
}
