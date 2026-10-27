using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007547 RID: 30023
	public struct IVillageInfrVillageLevel : IFlatbufferObject
	{
		// Token: 0x1700E3C9 RID: 58313
		// (get) Token: 0x060369F4 RID: 223732 RVA: 0x0076B9BE File Offset: 0x00769BBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060369F5 RID: 223733 RVA: 0x0076B9CB File Offset: 0x00769BCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060369F6 RID: 223734 RVA: 0x0076B9D4 File Offset: 0x00769BD4
		public static IVillageInfrVillageLevel GetRootAsIVillageInfrVillageLevel(ByteBuffer _bb)
		{
			return IVillageInfrVillageLevel.GetRootAsIVillageInfrVillageLevel(_bb, default(IVillageInfrVillageLevel));
		}

		// Token: 0x060369F7 RID: 223735 RVA: 0x0076B9F0 File Offset: 0x00769BF0
		public static IVillageInfrVillageLevel GetRootAsIVillageInfrVillageLevel(ByteBuffer _bb, IVillageInfrVillageLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060369F8 RID: 223736 RVA: 0x0076BA0D File Offset: 0x00769C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060369F9 RID: 223737 RVA: 0x0076BA1C File Offset: 0x00769C1C
		public IVillageInfrVillageLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3CA RID: 58314
		// (get) Token: 0x060369FA RID: 223738 RVA: 0x0076BA2C File Offset: 0x00769C2C
		public EVillageInfrBuildType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVillageInfrBuildType.Village;
				}
				return (EVillageInfrBuildType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3CB RID: 58315
		// (get) Token: 0x060369FB RID: 223739 RVA: 0x0076BA68 File Offset: 0x00769C68
		public int Level
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

		// Token: 0x060369FC RID: 223740 RVA: 0x0076BAA4 File Offset: 0x00769CA4
		public static Offset<IVillageInfrVillageLevel> CreateIVillageInfrVillageLevel(FlatBufferBuilder builder, EVillageInfrBuildType Type = EVillageInfrBuildType.Village, int Level = 0)
		{
			builder.StartTable(2);
			IVillageInfrVillageLevel.AddLevel(builder, Level);
			IVillageInfrVillageLevel.AddType(builder, Type);
			return IVillageInfrVillageLevel.EndIVillageInfrVillageLevel(builder);
		}

		// Token: 0x060369FD RID: 223741 RVA: 0x0076BAC1 File Offset: 0x00769CC1
		public static void StartIVillageInfrVillageLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060369FE RID: 223742 RVA: 0x0076BACA File Offset: 0x00769CCA
		public static void AddType(FlatBufferBuilder builder, EVillageInfrBuildType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060369FF RID: 223743 RVA: 0x0076BAD5 File Offset: 0x00769CD5
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		// Token: 0x06036A00 RID: 223744 RVA: 0x0076BAE0 File Offset: 0x00769CE0
		public static Offset<IVillageInfrVillageLevel> EndIVillageInfrVillageLevel(FlatBufferBuilder builder)
		{
			return new Offset<IVillageInfrVillageLevel>(builder.EndTable());
		}

		// Token: 0x06036A01 RID: 223745 RVA: 0x0076BAF0 File Offset: 0x00769CF0
		public IVillageInfrVillageLevelT UnPack()
		{
			IVillageInfrVillageLevelT villageInfrVillageLevelT = new IVillageInfrVillageLevelT();
			this.UnPackTo(villageInfrVillageLevelT);
			return villageInfrVillageLevelT;
		}

		// Token: 0x06036A02 RID: 223746 RVA: 0x0076BB0B File Offset: 0x00769D0B
		public void UnPackTo(IVillageInfrVillageLevelT _o)
		{
			_o.Type = this.Type;
			_o.Level = this.Level;
		}

		// Token: 0x06036A03 RID: 223747 RVA: 0x0076BB28 File Offset: 0x00769D28
		public static Offset<IVillageInfrVillageLevel> Pack(FlatBufferBuilder builder, IVillageInfrVillageLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVillageInfrVillageLevel>);
			}
			return IVillageInfrVillageLevel.CreateIVillageInfrVillageLevel(builder, _o.Type, _o.Level);
		}

		// Token: 0x0401243D RID: 74813
		private Table __p;
	}
}
