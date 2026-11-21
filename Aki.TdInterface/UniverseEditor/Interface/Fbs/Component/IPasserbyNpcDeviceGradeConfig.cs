using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C63 RID: 23651
	public struct IPasserbyNpcDeviceGradeConfig : IFlatbufferObject
	{
		// Token: 0x1700ADD8 RID: 44504
		// (get) Token: 0x060273D3 RID: 160723 RVA: 0x00560267 File Offset: 0x0055E467
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060273D4 RID: 160724 RVA: 0x00560274 File Offset: 0x0055E474
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060273D5 RID: 160725 RVA: 0x0056027C File Offset: 0x0055E47C
		public static IPasserbyNpcDeviceGradeConfig GetRootAsIPasserbyNpcDeviceGradeConfig(ByteBuffer _bb)
		{
			return IPasserbyNpcDeviceGradeConfig.GetRootAsIPasserbyNpcDeviceGradeConfig(_bb, default(IPasserbyNpcDeviceGradeConfig));
		}

		// Token: 0x060273D6 RID: 160726 RVA: 0x00560298 File Offset: 0x0055E498
		public static IPasserbyNpcDeviceGradeConfig GetRootAsIPasserbyNpcDeviceGradeConfig(ByteBuffer _bb, IPasserbyNpcDeviceGradeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060273D7 RID: 160727 RVA: 0x005602B5 File Offset: 0x0055E4B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060273D8 RID: 160728 RVA: 0x005602C4 File Offset: 0x0055E4C4
		public IPasserbyNpcDeviceGradeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADD9 RID: 44505
		// (get) Token: 0x060273D9 RID: 160729 RVA: 0x005602D4 File Offset: 0x0055E4D4
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

		// Token: 0x060273DA RID: 160730 RVA: 0x00560331 File Offset: 0x0055E531
		public static Offset<IPasserbyNpcDeviceGradeConfig> CreateIPasserbyNpcDeviceGradeConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcSpawnCountOverride> SpawnCountOverrideOffset = default(Offset<IPasserbyNpcSpawnCountOverride>))
		{
			builder.StartTable(1);
			IPasserbyNpcDeviceGradeConfig.AddSpawnCountOverride(builder, SpawnCountOverrideOffset);
			return IPasserbyNpcDeviceGradeConfig.EndIPasserbyNpcDeviceGradeConfig(builder);
		}

		// Token: 0x060273DB RID: 160731 RVA: 0x00560347 File Offset: 0x0055E547
		public static void StartIPasserbyNpcDeviceGradeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060273DC RID: 160732 RVA: 0x00560350 File Offset: 0x0055E550
		public static void AddSpawnCountOverride(FlatBufferBuilder builder, Offset<IPasserbyNpcSpawnCountOverride> spawnCountOverrideOffset)
		{
			builder.AddOffset(0, spawnCountOverrideOffset.Value, 0);
		}

		// Token: 0x060273DD RID: 160733 RVA: 0x00560360 File Offset: 0x0055E560
		public static Offset<IPasserbyNpcDeviceGradeConfig> EndIPasserbyNpcDeviceGradeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcDeviceGradeConfig>(builder.EndTable());
		}

		// Token: 0x060273DE RID: 160734 RVA: 0x00560370 File Offset: 0x0055E570
		public IPasserbyNpcDeviceGradeConfigT UnPack()
		{
			IPasserbyNpcDeviceGradeConfigT passerbyNpcDeviceGradeConfigT = new IPasserbyNpcDeviceGradeConfigT();
			this.UnPackTo(passerbyNpcDeviceGradeConfigT);
			return passerbyNpcDeviceGradeConfigT;
		}

		// Token: 0x060273DF RID: 160735 RVA: 0x0056038C File Offset: 0x0055E58C
		public void UnPackTo(IPasserbyNpcDeviceGradeConfigT _o)
		{
			_o.SpawnCountOverride = ((this.SpawnCountOverride != null) ? this.SpawnCountOverride.Value.UnPack() : null);
		}

		// Token: 0x060273E0 RID: 160736 RVA: 0x005603C8 File Offset: 0x0055E5C8
		public static Offset<IPasserbyNpcDeviceGradeConfig> Pack(FlatBufferBuilder builder, IPasserbyNpcDeviceGradeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcDeviceGradeConfig>);
			}
			Offset<IPasserbyNpcSpawnCountOverride> spawnCountOverrideOffset = (_o.SpawnCountOverride == null) ? default(Offset<IPasserbyNpcSpawnCountOverride>) : IPasserbyNpcSpawnCountOverride.Pack(builder, _o.SpawnCountOverride);
			return IPasserbyNpcDeviceGradeConfig.CreateIPasserbyNpcDeviceGradeConfig(builder, spawnCountOverrideOffset);
		}

		// Token: 0x0400F762 RID: 63330
		private Table __p;
	}
}
