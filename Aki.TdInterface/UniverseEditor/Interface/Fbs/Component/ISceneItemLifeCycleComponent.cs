using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED4 RID: 24276
	public struct ISceneItemLifeCycleComponent : IFlatbufferObject
	{
		// Token: 0x1700B359 RID: 45913
		// (get) Token: 0x06028B04 RID: 166660 RVA: 0x0058FC45 File Offset: 0x0058DE45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B05 RID: 166661 RVA: 0x0058FC52 File Offset: 0x0058DE52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B06 RID: 166662 RVA: 0x0058FC5C File Offset: 0x0058DE5C
		public static ISceneItemLifeCycleComponent GetRootAsISceneItemLifeCycleComponent(ByteBuffer _bb)
		{
			return ISceneItemLifeCycleComponent.GetRootAsISceneItemLifeCycleComponent(_bb, default(ISceneItemLifeCycleComponent));
		}

		// Token: 0x06028B07 RID: 166663 RVA: 0x0058FC78 File Offset: 0x0058DE78
		public static ISceneItemLifeCycleComponent GetRootAsISceneItemLifeCycleComponent(ByteBuffer _bb, ISceneItemLifeCycleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B08 RID: 166664 RVA: 0x0058FC95 File Offset: 0x0058DE95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B09 RID: 166665 RVA: 0x0058FCA4 File Offset: 0x0058DEA4
		public ISceneItemLifeCycleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B35A RID: 45914
		// (get) Token: 0x06028B0A RID: 166666 RVA: 0x0058FCB4 File Offset: 0x0058DEB4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B35B RID: 45915
		// (get) Token: 0x06028B0B RID: 166667 RVA: 0x0058FCF4 File Offset: 0x0058DEF4
		public ICreateStageConfig? CreateStageConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICreateStageConfig?(default(ICreateStageConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B35C RID: 45916
		// (get) Token: 0x06028B0C RID: 166668 RVA: 0x0058FD54 File Offset: 0x0058DF54
		public IDestroyStageConfig? DestroyStageConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IDestroyStageConfig?(default(IDestroyStageConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B35D RID: 45917
		// (get) Token: 0x06028B0D RID: 166669 RVA: 0x0058FDB4 File Offset: 0x0058DFB4
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

		// Token: 0x06028B0E RID: 166670 RVA: 0x0058FDF1 File Offset: 0x0058DFF1
		public static Offset<ISceneItemLifeCycleComponent> CreateISceneItemLifeCycleComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ICreateStageConfig> CreateStageConfigOffset = default(Offset<ICreateStageConfig>), Offset<IDestroyStageConfig> DestroyStageConfigOffset = default(Offset<IDestroyStageConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemLifeCycleComponent.AddDestroyStageConfig(builder, DestroyStageConfigOffset);
			ISceneItemLifeCycleComponent.AddCreateStageConfig(builder, CreateStageConfigOffset);
			ISceneItemLifeCycleComponent.AddNullMask(builder, NullMask);
			ISceneItemLifeCycleComponent.AddDisabled(builder, Disabled);
			return ISceneItemLifeCycleComponent.EndISceneItemLifeCycleComponent(builder);
		}

		// Token: 0x06028B0F RID: 166671 RVA: 0x0058FE1D File Offset: 0x0058E01D
		public static void StartISceneItemLifeCycleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028B10 RID: 166672 RVA: 0x0058FE26 File Offset: 0x0058E026
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028B11 RID: 166673 RVA: 0x0058FE31 File Offset: 0x0058E031
		public static void AddCreateStageConfig(FlatBufferBuilder builder, Offset<ICreateStageConfig> createStageConfigOffset)
		{
			builder.AddOffset(1, createStageConfigOffset.Value, 0);
		}

		// Token: 0x06028B12 RID: 166674 RVA: 0x0058FE41 File Offset: 0x0058E041
		public static void AddDestroyStageConfig(FlatBufferBuilder builder, Offset<IDestroyStageConfig> destroyStageConfigOffset)
		{
			builder.AddOffset(2, destroyStageConfigOffset.Value, 0);
		}

		// Token: 0x06028B13 RID: 166675 RVA: 0x0058FE51 File Offset: 0x0058E051
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028B14 RID: 166676 RVA: 0x0058FE5C File Offset: 0x0058E05C
		public static Offset<ISceneItemLifeCycleComponent> EndISceneItemLifeCycleComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemLifeCycleComponent>(builder.EndTable());
		}

		// Token: 0x06028B15 RID: 166677 RVA: 0x0058FE6C File Offset: 0x0058E06C
		public ISceneItemLifeCycleComponentT UnPack()
		{
			ISceneItemLifeCycleComponentT sceneItemLifeCycleComponentT = new ISceneItemLifeCycleComponentT();
			this.UnPackTo(sceneItemLifeCycleComponentT);
			return sceneItemLifeCycleComponentT;
		}

		// Token: 0x06028B16 RID: 166678 RVA: 0x0058FE88 File Offset: 0x0058E088
		public void UnPackTo(ISceneItemLifeCycleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CreateStageConfig = ((this.CreateStageConfig != null) ? this.CreateStageConfig.Value.UnPack() : null);
			_o.DestroyStageConfig = ((this.DestroyStageConfig != null) ? this.DestroyStageConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028B17 RID: 166679 RVA: 0x0058FF0C File Offset: 0x0058E10C
		public static Offset<ISceneItemLifeCycleComponent> Pack(FlatBufferBuilder builder, ISceneItemLifeCycleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemLifeCycleComponent>);
			}
			Offset<ICreateStageConfig> createStageConfigOffset = (_o.CreateStageConfig == null) ? default(Offset<ICreateStageConfig>) : ICreateStageConfig.Pack(builder, _o.CreateStageConfig);
			Offset<IDestroyStageConfig> destroyStageConfigOffset = (_o.DestroyStageConfig == null) ? default(Offset<IDestroyStageConfig>) : IDestroyStageConfig.Pack(builder, _o.DestroyStageConfig);
			return ISceneItemLifeCycleComponent.CreateISceneItemLifeCycleComponent(builder, _o.Disabled, createStageConfigOffset, destroyStageConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FB30 RID: 64304
		private Table __p;
	}
}
