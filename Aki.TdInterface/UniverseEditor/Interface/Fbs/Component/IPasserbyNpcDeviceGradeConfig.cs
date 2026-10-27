using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BF RID: 22207
	public struct IPasserbyNpcDeviceGradeConfig : IFlatbufferObject
	{
		// Token: 0x1700A544 RID: 42308
		// (get) Token: 0x0602517E RID: 151934 RVA: 0x0051F31F File Offset: 0x0051D51F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602517F RID: 151935 RVA: 0x0051F32C File Offset: 0x0051D52C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025180 RID: 151936 RVA: 0x0051F334 File Offset: 0x0051D534
		public static IPasserbyNpcDeviceGradeConfig GetRootAsIPasserbyNpcDeviceGradeConfig(ByteBuffer _bb)
		{
			return IPasserbyNpcDeviceGradeConfig.GetRootAsIPasserbyNpcDeviceGradeConfig(_bb, default(IPasserbyNpcDeviceGradeConfig));
		}

		// Token: 0x06025181 RID: 151937 RVA: 0x0051F350 File Offset: 0x0051D550
		public static IPasserbyNpcDeviceGradeConfig GetRootAsIPasserbyNpcDeviceGradeConfig(ByteBuffer _bb, IPasserbyNpcDeviceGradeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025182 RID: 151938 RVA: 0x0051F36D File Offset: 0x0051D56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025183 RID: 151939 RVA: 0x0051F37C File Offset: 0x0051D57C
		public IPasserbyNpcDeviceGradeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A545 RID: 42309
		// (get) Token: 0x06025184 RID: 151940 RVA: 0x0051F38C File Offset: 0x0051D58C
		public IPasserbyNpcSpawnCountOverride? SpawnCountOverride
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcSpawnCountOverride?(default(IPasserbyNpcSpawnCountOverride).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025185 RID: 151941 RVA: 0x0051F3E9 File Offset: 0x0051D5E9
		public static Offset<IPasserbyNpcDeviceGradeConfig> CreateIPasserbyNpcDeviceGradeConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcSpawnCountOverride> SpawnCountOverrideOffset = default(Offset<IPasserbyNpcSpawnCountOverride>))
		{
			builder.StartTable(1);
			IPasserbyNpcDeviceGradeConfig.AddSpawnCountOverride(builder, SpawnCountOverrideOffset);
			return IPasserbyNpcDeviceGradeConfig.EndIPasserbyNpcDeviceGradeConfig(builder);
		}

		// Token: 0x06025186 RID: 151942 RVA: 0x0051F3FF File Offset: 0x0051D5FF
		public static void StartIPasserbyNpcDeviceGradeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025187 RID: 151943 RVA: 0x0051F408 File Offset: 0x0051D608
		public static void AddSpawnCountOverride(FlatBufferBuilder builder, Offset<IPasserbyNpcSpawnCountOverride> spawnCountOverrideOffset)
		{
			builder.AddOffset(0, spawnCountOverrideOffset.Value, 0);
		}

		// Token: 0x06025188 RID: 151944 RVA: 0x0051F418 File Offset: 0x0051D618
		public static Offset<IPasserbyNpcDeviceGradeConfig> EndIPasserbyNpcDeviceGradeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcDeviceGradeConfig>(builder.EndTable());
		}

		// Token: 0x06025189 RID: 151945 RVA: 0x0051F428 File Offset: 0x0051D628
		public IPasserbyNpcDeviceGradeConfigT UnPack()
		{
			IPasserbyNpcDeviceGradeConfigT passerbyNpcDeviceGradeConfigT = new IPasserbyNpcDeviceGradeConfigT();
			this.UnPackTo(passerbyNpcDeviceGradeConfigT);
			return passerbyNpcDeviceGradeConfigT;
		}

		// Token: 0x0602518A RID: 151946 RVA: 0x0051F444 File Offset: 0x0051D644
		public void UnPackTo(IPasserbyNpcDeviceGradeConfigT _o)
		{
			_o.SpawnCountOverride = ((this.SpawnCountOverride != null) ? this.SpawnCountOverride.Value.UnPack() : null);
		}

		// Token: 0x0602518B RID: 151947 RVA: 0x0051F480 File Offset: 0x0051D680
		public static Offset<IPasserbyNpcDeviceGradeConfig> Pack(FlatBufferBuilder builder, IPasserbyNpcDeviceGradeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcDeviceGradeConfig>);
			}
			Offset<IPasserbyNpcSpawnCountOverride> spawnCountOverrideOffset = (_o.SpawnCountOverride == null) ? default(Offset<IPasserbyNpcSpawnCountOverride>) : IPasserbyNpcSpawnCountOverride.Pack(builder, _o.SpawnCountOverride);
			return IPasserbyNpcDeviceGradeConfig.CreateIPasserbyNpcDeviceGradeConfig(builder, spawnCountOverrideOffset);
		}

		// Token: 0x0400EAF6 RID: 60150
		private Table __p;
	}
}
