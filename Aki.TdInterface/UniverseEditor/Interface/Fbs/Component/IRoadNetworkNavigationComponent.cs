using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E7A RID: 24186
	public struct IRoadNetworkNavigationComponent : IFlatbufferObject
	{
		// Token: 0x1700B283 RID: 45699
		// (get) Token: 0x060287A8 RID: 165800 RVA: 0x0058924A File Offset: 0x0058744A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060287A9 RID: 165801 RVA: 0x00589257 File Offset: 0x00587457
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060287AA RID: 165802 RVA: 0x00589260 File Offset: 0x00587460
		public static IRoadNetworkNavigationComponent GetRootAsIRoadNetworkNavigationComponent(ByteBuffer _bb)
		{
			return IRoadNetworkNavigationComponent.GetRootAsIRoadNetworkNavigationComponent(_bb, default(IRoadNetworkNavigationComponent));
		}

		// Token: 0x060287AB RID: 165803 RVA: 0x0058927C File Offset: 0x0058747C
		public static IRoadNetworkNavigationComponent GetRootAsIRoadNetworkNavigationComponent(ByteBuffer _bb, IRoadNetworkNavigationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060287AC RID: 165804 RVA: 0x00589299 File Offset: 0x00587499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060287AD RID: 165805 RVA: 0x005892A8 File Offset: 0x005874A8
		public IRoadNetworkNavigationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B284 RID: 45700
		// (get) Token: 0x060287AE RID: 165806 RVA: 0x005892B8 File Offset: 0x005874B8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B285 RID: 45701
		// (get) Token: 0x060287AF RID: 165807 RVA: 0x005892F8 File Offset: 0x005874F8
		public bool KeepSelf
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B286 RID: 45702
		// (get) Token: 0x060287B0 RID: 165808 RVA: 0x00589338 File Offset: 0x00587538
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

		// Token: 0x1700B287 RID: 45703
		// (get) Token: 0x060287B1 RID: 165809 RVA: 0x00589398 File Offset: 0x00587598
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

		// Token: 0x1700B288 RID: 45704
		// (get) Token: 0x060287B2 RID: 165810 RVA: 0x005893F8 File Offset: 0x005875F8
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

		// Token: 0x060287B3 RID: 165811 RVA: 0x00589435 File Offset: 0x00587635
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

		// Token: 0x060287B4 RID: 165812 RVA: 0x00589469 File Offset: 0x00587669
		public static void StartIRoadNetworkNavigationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060287B5 RID: 165813 RVA: 0x00589472 File Offset: 0x00587672
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060287B6 RID: 165814 RVA: 0x0058947D File Offset: 0x0058767D
		public static void AddKeepSelf(FlatBufferBuilder builder, bool keepSelf)
		{
			builder.AddBool(1, keepSelf, false);
		}

		// Token: 0x060287B7 RID: 165815 RVA: 0x00589488 File Offset: 0x00587688
		public static void AddBasicConfig(FlatBufferBuilder builder, Offset<ITrafficNavigationConfig> basicConfigOffset)
		{
			builder.AddOffset(2, basicConfigOffset.Value, 0);
		}

		// Token: 0x060287B8 RID: 165816 RVA: 0x00589498 File Offset: 0x00587698
		public static void AddObstacleConfig(FlatBufferBuilder builder, Offset<IObstacleDetectionConfig> obstacleConfigOffset)
		{
			builder.AddOffset(3, obstacleConfigOffset.Value, 0);
		}

		// Token: 0x060287B9 RID: 165817 RVA: 0x005894A8 File Offset: 0x005876A8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060287BA RID: 165818 RVA: 0x005894B3 File Offset: 0x005876B3
		public static Offset<IRoadNetworkNavigationComponent> EndIRoadNetworkNavigationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IRoadNetworkNavigationComponent>(builder.EndTable());
		}

		// Token: 0x060287BB RID: 165819 RVA: 0x005894C0 File Offset: 0x005876C0
		public IRoadNetworkNavigationComponentT UnPack()
		{
			IRoadNetworkNavigationComponentT roadNetworkNavigationComponentT = new IRoadNetworkNavigationComponentT();
			this.UnPackTo(roadNetworkNavigationComponentT);
			return roadNetworkNavigationComponentT;
		}

		// Token: 0x060287BC RID: 165820 RVA: 0x005894DC File Offset: 0x005876DC
		public void UnPackTo(IRoadNetworkNavigationComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.KeepSelf = this.KeepSelf;
			_o.BasicConfig = ((this.BasicConfig != null) ? this.BasicConfig.Value.UnPack() : null);
			_o.ObstacleConfig = ((this.ObstacleConfig != null) ? this.ObstacleConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060287BD RID: 165821 RVA: 0x0058956C File Offset: 0x0058776C
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

		// Token: 0x0400FAA4 RID: 64164
		private Table __p;
	}
}
