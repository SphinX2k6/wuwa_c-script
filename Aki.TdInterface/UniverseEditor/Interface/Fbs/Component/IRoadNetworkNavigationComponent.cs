using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586D RID: 22637
	public struct IRoadNetworkNavigationComponent : IFlatbufferObject
	{
		// Token: 0x1700A953 RID: 43347
		// (get) Token: 0x06026246 RID: 156230 RVA: 0x005426FE File Offset: 0x005408FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026247 RID: 156231 RVA: 0x0054270B File Offset: 0x0054090B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026248 RID: 156232 RVA: 0x00542714 File Offset: 0x00540914
		public static IRoadNetworkNavigationComponent GetRootAsIRoadNetworkNavigationComponent(ByteBuffer _bb)
		{
			return IRoadNetworkNavigationComponent.GetRootAsIRoadNetworkNavigationComponent(_bb, default(IRoadNetworkNavigationComponent));
		}

		// Token: 0x06026249 RID: 156233 RVA: 0x00542730 File Offset: 0x00540930
		public static IRoadNetworkNavigationComponent GetRootAsIRoadNetworkNavigationComponent(ByteBuffer _bb, IRoadNetworkNavigationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602624A RID: 156234 RVA: 0x0054274D File Offset: 0x0054094D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602624B RID: 156235 RVA: 0x0054275C File Offset: 0x0054095C
		public IRoadNetworkNavigationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A954 RID: 43348
		// (get) Token: 0x0602624C RID: 156236 RVA: 0x0054276C File Offset: 0x0054096C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A955 RID: 43349
		// (get) Token: 0x0602624D RID: 156237 RVA: 0x005427AC File Offset: 0x005409AC
		public bool KeepSelf
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A956 RID: 43350
		// (get) Token: 0x0602624E RID: 156238 RVA: 0x005427EC File Offset: 0x005409EC
		public ITrafficNavigationConfig? BasicConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITrafficNavigationConfig?(default(ITrafficNavigationConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A957 RID: 43351
		// (get) Token: 0x0602624F RID: 156239 RVA: 0x0054284C File Offset: 0x00540A4C
		public IObstacleDetectionConfig? ObstacleConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IObstacleDetectionConfig?(default(IObstacleDetectionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A958 RID: 43352
		// (get) Token: 0x06026250 RID: 156240 RVA: 0x005428AC File Offset: 0x00540AAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026251 RID: 156241 RVA: 0x005428E9 File Offset: 0x00540AE9
		public static Offset<IRoadNetworkNavigationComponent> CreateIRoadNetworkNavigationComponent(FlatBufferBuilder builder, bool Disabled = false, bool KeepSelf = false, Offset<ITrafficNavigationConfig> BasicConfigOffset = default(Offset<ITrafficNavigationConfig>), Offset<IObstacleDetectionConfig> ObstacleConfigOffset = default(Offset<IObstacleDetectionConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IRoadNetworkNavigationComponent.AddObstacleConfig(builder, ObstacleConfigOffset);
			IRoadNetworkNavigationComponent.AddBasicConfig(builder, BasicConfigOffset);
			IRoadNetworkNavigationComponent.AddNullMask(builder, NullMask);
			IRoadNetworkNavigationComponent.AddKeepSelf(builder, KeepSelf);
			IRoadNetworkNavigationComponent.AddDisabled(builder, Disabled);
			return IRoadNetworkNavigationComponent.EndIRoadNetworkNavigationComponent(builder);
		}

		// Token: 0x06026252 RID: 156242 RVA: 0x0054291D File Offset: 0x00540B1D
		public static void StartIRoadNetworkNavigationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026253 RID: 156243 RVA: 0x00542926 File Offset: 0x00540B26
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026254 RID: 156244 RVA: 0x00542931 File Offset: 0x00540B31
		public static void AddKeepSelf(FlatBufferBuilder builder, bool keepSelf)
		{
			builder.AddBool(1, keepSelf, false);
		}

		// Token: 0x06026255 RID: 156245 RVA: 0x0054293C File Offset: 0x00540B3C
		public static void AddBasicConfig(FlatBufferBuilder builder, Offset<ITrafficNavigationConfig> basicConfigOffset)
		{
			builder.AddOffset(2, basicConfigOffset.Value, 0);
		}

		// Token: 0x06026256 RID: 156246 RVA: 0x0054294C File Offset: 0x00540B4C
		public static void AddObstacleConfig(FlatBufferBuilder builder, Offset<IObstacleDetectionConfig> obstacleConfigOffset)
		{
			builder.AddOffset(3, obstacleConfigOffset.Value, 0);
		}

		// Token: 0x06026257 RID: 156247 RVA: 0x0054295C File Offset: 0x00540B5C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026258 RID: 156248 RVA: 0x00542967 File Offset: 0x00540B67
		public static Offset<IRoadNetworkNavigationComponent> EndIRoadNetworkNavigationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRoadNetworkNavigationComponent>(builder.EndTable());
		}

		// Token: 0x06026259 RID: 156249 RVA: 0x00542974 File Offset: 0x00540B74
		public IRoadNetworkNavigationComponentT UnPack()
		{
			IRoadNetworkNavigationComponentT roadNetworkNavigationComponentT = new IRoadNetworkNavigationComponentT();
			this.UnPackTo(roadNetworkNavigationComponentT);
			return roadNetworkNavigationComponentT;
		}

		// Token: 0x0602625A RID: 156250 RVA: 0x00542990 File Offset: 0x00540B90
		public void UnPackTo(IRoadNetworkNavigationComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.KeepSelf = this.KeepSelf;
			_o.BasicConfig = ((this.BasicConfig != null) ? this.BasicConfig.Value.UnPack() : null);
			_o.ObstacleConfig = ((this.ObstacleConfig != null) ? this.ObstacleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602625B RID: 156251 RVA: 0x00542A20 File Offset: 0x00540C20
		public static Offset<IRoadNetworkNavigationComponent> Pack(FlatBufferBuilder builder, IRoadNetworkNavigationComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoadNetworkNavigationComponent>);
			}
			Offset<ITrafficNavigationConfig> basicConfigOffset = (_o.BasicConfig == null) ? default(Offset<ITrafficNavigationConfig>) : ITrafficNavigationConfig.Pack(builder, _o.BasicConfig);
			Offset<IObstacleDetectionConfig> obstacleConfigOffset = (_o.ObstacleConfig == null) ? default(Offset<IObstacleDetectionConfig>) : IObstacleDetectionConfig.Pack(builder, _o.ObstacleConfig);
			return IRoadNetworkNavigationComponent.CreateIRoadNetworkNavigationComponent(builder, _o.Disabled, _o.KeepSelf, basicConfigOffset, obstacleConfigOffset, _o.NullMask);
		}

		// Token: 0x0400EDB1 RID: 60849
		private Table __p;
	}
}
