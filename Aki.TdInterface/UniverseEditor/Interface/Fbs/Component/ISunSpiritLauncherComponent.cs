using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006017 RID: 24599
	public struct ISunSpiritLauncherComponent : IFlatbufferObject
	{
		// Token: 0x1700B669 RID: 46697
		// (get) Token: 0x06029780 RID: 169856 RVA: 0x005A8F1D File Offset: 0x005A711D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029781 RID: 169857 RVA: 0x005A8F2A File Offset: 0x005A712A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029782 RID: 169858 RVA: 0x005A8F34 File Offset: 0x005A7134
		public static ISunSpiritLauncherComponent GetRootAsISunSpiritLauncherComponent(ByteBuffer _bb)
		{
			return ISunSpiritLauncherComponent.GetRootAsISunSpiritLauncherComponent(_bb, default(ISunSpiritLauncherComponent));
		}

		// Token: 0x06029783 RID: 169859 RVA: 0x005A8F50 File Offset: 0x005A7150
		public static ISunSpiritLauncherComponent GetRootAsISunSpiritLauncherComponent(ByteBuffer _bb, ISunSpiritLauncherComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029784 RID: 169860 RVA: 0x005A8F6D File Offset: 0x005A716D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029785 RID: 169861 RVA: 0x005A8F7C File Offset: 0x005A717C
		public ISunSpiritLauncherComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B66A RID: 46698
		// (get) Token: 0x06029786 RID: 169862 RVA: 0x005A8F8C File Offset: 0x005A718C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B66B RID: 46699
		// (get) Token: 0x06029787 RID: 169863 RVA: 0x005A8FCC File Offset: 0x005A71CC
		public int AreaId
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

		// Token: 0x1700B66C RID: 46700
		// (get) Token: 0x06029788 RID: 169864 RVA: 0x005A9008 File Offset: 0x005A7208
		public int NeedsCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B66D RID: 46701
		// (get) Token: 0x06029789 RID: 169865 RVA: 0x005A9044 File Offset: 0x005A7244
		public int SunSpiritGearId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B66E RID: 46702
		// (get) Token: 0x0602978A RID: 169866 RVA: 0x005A9084 File Offset: 0x005A7284
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

		// Token: 0x0602978B RID: 169867 RVA: 0x005A90C1 File Offset: 0x005A72C1
		public static Offset<ISunSpiritLauncherComponent> CreateISunSpiritLauncherComponent(FlatBufferBuilder builder, bool Disabled = false, int AreaId = 0, int NeedsCount = 0, int SunSpiritGearId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISunSpiritLauncherComponent.AddSunSpiritGearId(builder, SunSpiritGearId);
			ISunSpiritLauncherComponent.AddNeedsCount(builder, NeedsCount);
			ISunSpiritLauncherComponent.AddAreaId(builder, AreaId);
			ISunSpiritLauncherComponent.AddNullMask(builder, NullMask);
			ISunSpiritLauncherComponent.AddDisabled(builder, Disabled);
			return ISunSpiritLauncherComponent.EndISunSpiritLauncherComponent(builder);
		}

		// Token: 0x0602978C RID: 169868 RVA: 0x005A90F5 File Offset: 0x005A72F5
		public static void StartISunSpiritLauncherComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602978D RID: 169869 RVA: 0x005A90FE File Offset: 0x005A72FE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602978E RID: 169870 RVA: 0x005A9109 File Offset: 0x005A7309
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602978F RID: 169871 RVA: 0x005A9114 File Offset: 0x005A7314
		public static void AddNeedsCount(FlatBufferBuilder builder, int needsCount)
		{
			builder.AddInt(2, needsCount, 0);
		}

		// Token: 0x06029790 RID: 169872 RVA: 0x005A911F File Offset: 0x005A731F
		public static void AddSunSpiritGearId(FlatBufferBuilder builder, int sunSpiritGearId)
		{
			builder.AddInt(3, sunSpiritGearId, 0);
		}

		// Token: 0x06029791 RID: 169873 RVA: 0x005A912A File Offset: 0x005A732A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06029792 RID: 169874 RVA: 0x005A9135 File Offset: 0x005A7335
		public static Offset<ISunSpiritLauncherComponent> EndISunSpiritLauncherComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritLauncherComponent>(builder.EndTable());
		}

		// Token: 0x06029793 RID: 169875 RVA: 0x005A9144 File Offset: 0x005A7344
		public ISunSpiritLauncherComponentT UnPack()
		{
			ISunSpiritLauncherComponentT sunSpiritLauncherComponentT = new ISunSpiritLauncherComponentT();
			this.UnPackTo(sunSpiritLauncherComponentT);
			return sunSpiritLauncherComponentT;
		}

		// Token: 0x06029794 RID: 169876 RVA: 0x005A915F File Offset: 0x005A735F
		public void UnPackTo(ISunSpiritLauncherComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AreaId = this.AreaId;
			_o.NeedsCount = this.NeedsCount;
			_o.SunSpiritGearId = this.SunSpiritGearId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029795 RID: 169877 RVA: 0x005A91A0 File Offset: 0x005A73A0
		public static Offset<ISunSpiritLauncherComponent> Pack(FlatBufferBuilder builder, ISunSpiritLauncherComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritLauncherComponent>);
			}
			return ISunSpiritLauncherComponent.CreateISunSpiritLauncherComponent(builder, _o.Disabled, _o.AreaId, _o.NeedsCount, _o.SunSpiritGearId, _o.NullMask);
		}

		// Token: 0x0400FD47 RID: 64839
		private Table __p;
	}
}
