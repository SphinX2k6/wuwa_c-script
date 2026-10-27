using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C7 RID: 22727
	public struct ISceneItemLifeCycleComponent : IFlatbufferObject
	{
		// Token: 0x1700AA29 RID: 43561
		// (get) Token: 0x060265A2 RID: 157090 RVA: 0x005490F9 File Offset: 0x005472F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060265A3 RID: 157091 RVA: 0x00549106 File Offset: 0x00547306
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060265A4 RID: 157092 RVA: 0x00549110 File Offset: 0x00547310
		public static ISceneItemLifeCycleComponent GetRootAsISceneItemLifeCycleComponent(ByteBuffer _bb)
		{
			return ISceneItemLifeCycleComponent.GetRootAsISceneItemLifeCycleComponent(_bb, default(ISceneItemLifeCycleComponent));
		}

		// Token: 0x060265A5 RID: 157093 RVA: 0x0054912C File Offset: 0x0054732C
		public static ISceneItemLifeCycleComponent GetRootAsISceneItemLifeCycleComponent(ByteBuffer _bb, ISceneItemLifeCycleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060265A6 RID: 157094 RVA: 0x00549149 File Offset: 0x00547349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060265A7 RID: 157095 RVA: 0x00549158 File Offset: 0x00547358
		public ISceneItemLifeCycleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA2A RID: 43562
		// (get) Token: 0x060265A8 RID: 157096 RVA: 0x00549168 File Offset: 0x00547368
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA2B RID: 43563
		// (get) Token: 0x060265A9 RID: 157097 RVA: 0x005491A8 File Offset: 0x005473A8
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

		// Token: 0x1700AA2C RID: 43564
		// (get) Token: 0x060265AA RID: 157098 RVA: 0x00549208 File Offset: 0x00547408
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

		// Token: 0x1700AA2D RID: 43565
		// (get) Token: 0x060265AB RID: 157099 RVA: 0x00549268 File Offset: 0x00547468
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

		// Token: 0x060265AC RID: 157100 RVA: 0x005492A5 File Offset: 0x005474A5
		public static Offset<ISceneItemLifeCycleComponent> CreateISceneItemLifeCycleComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ICreateStageConfig> CreateStageConfigOffset = default(Offset<ICreateStageConfig>), Offset<IDestroyStageConfig> DestroyStageConfigOffset = default(Offset<IDestroyStageConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemLifeCycleComponent.AddDestroyStageConfig(builder, DestroyStageConfigOffset);
			ISceneItemLifeCycleComponent.AddCreateStageConfig(builder, CreateStageConfigOffset);
			ISceneItemLifeCycleComponent.AddNullMask(builder, NullMask);
			ISceneItemLifeCycleComponent.AddDisabled(builder, Disabled);
			return ISceneItemLifeCycleComponent.EndISceneItemLifeCycleComponent(builder);
		}

		// Token: 0x060265AD RID: 157101 RVA: 0x005492D1 File Offset: 0x005474D1
		public static void StartISceneItemLifeCycleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060265AE RID: 157102 RVA: 0x005492DA File Offset: 0x005474DA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060265AF RID: 157103 RVA: 0x005492E5 File Offset: 0x005474E5
		public static void AddCreateStageConfig(FlatBufferBuilder builder, Offset<ICreateStageConfig> createStageConfigOffset)
		{
			builder.AddOffset(1, createStageConfigOffset.Value, 0);
		}

		// Token: 0x060265B0 RID: 157104 RVA: 0x005492F5 File Offset: 0x005474F5
		public static void AddDestroyStageConfig(FlatBufferBuilder builder, Offset<IDestroyStageConfig> destroyStageConfigOffset)
		{
			builder.AddOffset(2, destroyStageConfigOffset.Value, 0);
		}

		// Token: 0x060265B1 RID: 157105 RVA: 0x00549305 File Offset: 0x00547505
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060265B2 RID: 157106 RVA: 0x00549310 File Offset: 0x00547510
		public static Offset<ISceneItemLifeCycleComponent> EndISceneItemLifeCycleComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemLifeCycleComponent>(builder.EndTable());
		}

		// Token: 0x060265B3 RID: 157107 RVA: 0x00549320 File Offset: 0x00547520
		public ISceneItemLifeCycleComponentT UnPack()
		{
			ISceneItemLifeCycleComponentT sceneItemLifeCycleComponentT = new ISceneItemLifeCycleComponentT();
			this.UnPackTo(sceneItemLifeCycleComponentT);
			return sceneItemLifeCycleComponentT;
		}

		// Token: 0x060265B4 RID: 157108 RVA: 0x0054933C File Offset: 0x0054753C
		public void UnPackTo(ISceneItemLifeCycleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CreateStageConfig = ((this.CreateStageConfig != null) ? this.CreateStageConfig.Value.UnPack() : null);
			_o.DestroyStageConfig = ((this.DestroyStageConfig != null) ? this.DestroyStageConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060265B5 RID: 157109 RVA: 0x005493C0 File Offset: 0x005475C0
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

		// Token: 0x0400EE3D RID: 60989
		private Table __p;
	}
}
