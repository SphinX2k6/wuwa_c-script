using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF2 RID: 24306
	public struct ISceneTextGuideUiScaleConfig : IFlatbufferObject
	{
		// Token: 0x1700B3A5 RID: 45989
		// (get) Token: 0x06028C3C RID: 166972 RVA: 0x0059267B File Offset: 0x0059087B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028C3D RID: 166973 RVA: 0x00592688 File Offset: 0x00590888
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028C3E RID: 166974 RVA: 0x00592690 File Offset: 0x00590890
		public static ISceneTextGuideUiScaleConfig GetRootAsISceneTextGuideUiScaleConfig(ByteBuffer _bb)
		{
			return ISceneTextGuideUiScaleConfig.GetRootAsISceneTextGuideUiScaleConfig(_bb, default(ISceneTextGuideUiScaleConfig));
		}

		// Token: 0x06028C3F RID: 166975 RVA: 0x005926AC File Offset: 0x005908AC
		public static ISceneTextGuideUiScaleConfig GetRootAsISceneTextGuideUiScaleConfig(ByteBuffer _bb, ISceneTextGuideUiScaleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028C40 RID: 166976 RVA: 0x005926C9 File Offset: 0x005908C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028C41 RID: 166977 RVA: 0x005926D8 File Offset: 0x005908D8
		public ISceneTextGuideUiScaleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3A6 RID: 45990
		// (get) Token: 0x06028C42 RID: 166978 RVA: 0x005926E8 File Offset: 0x005908E8
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

		// Token: 0x1700B3A7 RID: 45991
		// (get) Token: 0x06028C43 RID: 166979 RVA: 0x00592724 File Offset: 0x00590924
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

		// Token: 0x1700B3A8 RID: 45992
		// (get) Token: 0x06028C44 RID: 166980 RVA: 0x00592760 File Offset: 0x00590960
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

		// Token: 0x1700B3A9 RID: 45993
		// (get) Token: 0x06028C45 RID: 166981 RVA: 0x005927A0 File Offset: 0x005909A0
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

		// Token: 0x1700B3AA RID: 45994
		// (get) Token: 0x06028C46 RID: 166982 RVA: 0x005927E4 File Offset: 0x005909E4
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

		// Token: 0x06028C47 RID: 166983 RVA: 0x00592821 File Offset: 0x00590A21
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

		// Token: 0x06028C48 RID: 166984 RVA: 0x00592855 File Offset: 0x00590A55
		public static void StartISceneTextGuideUiScaleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028C49 RID: 166985 RVA: 0x0059285E File Offset: 0x00590A5E
		public static void AddMinDist(FlatBufferBuilder builder, int minDist)
		{
			builder.AddInt(0, minDist, 0);
		}

		// Token: 0x06028C4A RID: 166986 RVA: 0x00592869 File Offset: 0x00590A69
		public static void AddMaxDist(FlatBufferBuilder builder, int maxDist)
		{
			builder.AddInt(1, maxDist, 0);
		}

		// Token: 0x06028C4B RID: 166987 RVA: 0x00592874 File Offset: 0x00590A74
		public static void AddMinScale(FlatBufferBuilder builder, float minScale)
		{
			builder.AddFloat(2, minScale, 0.0);
		}

		// Token: 0x06028C4C RID: 166988 RVA: 0x00592887 File Offset: 0x00590A87
		public static void AddMaxScale(FlatBufferBuilder builder, float maxScale)
		{
			builder.AddFloat(3, maxScale, 0.0);
		}

		// Token: 0x06028C4D RID: 166989 RVA: 0x0059289A File Offset: 0x00590A9A
		public static void AddScaleType(FlatBufferBuilder builder, ESceneTextGuideUiScaleType scaleType)
		{
			builder.AddByte(4, (byte)scaleType, 0);
		}

		// Token: 0x06028C4E RID: 166990 RVA: 0x005928A5 File Offset: 0x00590AA5
		public static Offset<ISceneTextGuideUiScaleConfig> EndISceneTextGuideUiScaleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISceneTextGuideUiScaleConfig>(builder.EndTable());
		}

		// Token: 0x06028C4F RID: 166991 RVA: 0x005928B4 File Offset: 0x00590AB4
		public ISceneTextGuideUiScaleConfigT UnPack()
		{
			ISceneTextGuideUiScaleConfigT sceneTextGuideUiScaleConfigT = new ISceneTextGuideUiScaleConfigT();
			this.UnPackTo(sceneTextGuideUiScaleConfigT);
			return sceneTextGuideUiScaleConfigT;
		}

		// Token: 0x06028C50 RID: 166992 RVA: 0x005928CF File Offset: 0x00590ACF
		public void UnPackTo(ISceneTextGuideUiScaleConfigT _o)
		{
			_o.MinDist = this.MinDist;
			_o.MaxDist = this.MaxDist;
			_o.MinScale = this.MinScale;
			_o.MaxScale = this.MaxScale;
			_o.ScaleType = this.ScaleType;
		}

		// Token: 0x06028C51 RID: 166993 RVA: 0x00592910 File Offset: 0x00590B10
		public static Offset<ISceneTextGuideUiScaleConfig> Pack(FlatBufferBuilder builder, ISceneTextGuideUiScaleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneTextGuideUiScaleConfig>);
			}
			return ISceneTextGuideUiScaleConfig.CreateISceneTextGuideUiScaleConfig(builder, _o.MinDist, _o.MaxDist, _o.MinScale, _o.MaxScale, _o.ScaleType);
		}

		// Token: 0x0400FB60 RID: 64352
		private Table __p;
	}
}
