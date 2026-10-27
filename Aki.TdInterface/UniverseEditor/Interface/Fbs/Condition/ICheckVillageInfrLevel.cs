using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B71 RID: 19313
	public struct ICheckVillageInfrLevel : IFlatbufferObject
	{
		// Token: 0x17008C28 RID: 35880
		// (get) Token: 0x0601E6EB RID: 124651 RVA: 0x004431B4 File Offset: 0x004413B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E6EC RID: 124652 RVA: 0x004431C1 File Offset: 0x004413C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E6ED RID: 124653 RVA: 0x004431C8 File Offset: 0x004413C8
		public static ICheckVillageInfrLevel GetRootAsICheckVillageInfrLevel(ByteBuffer _bb)
		{
			return ICheckVillageInfrLevel.GetRootAsICheckVillageInfrLevel(_bb, default(ICheckVillageInfrLevel));
		}

		// Token: 0x0601E6EE RID: 124654 RVA: 0x004431E4 File Offset: 0x004413E4
		public static ICheckVillageInfrLevel GetRootAsICheckVillageInfrLevel(ByteBuffer _bb, ICheckVillageInfrLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E6EF RID: 124655 RVA: 0x00443201 File Offset: 0x00441401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E6F0 RID: 124656 RVA: 0x00443210 File Offset: 0x00441410
		public ICheckVillageInfrLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C29 RID: 35881
		// (get) Token: 0x0601E6F1 RID: 124657 RVA: 0x00443220 File Offset: 0x00441420
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C2A RID: 35882
		// (get) Token: 0x0601E6F2 RID: 124658 RVA: 0x0044325C File Offset: 0x0044145C
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

		// Token: 0x0601E6F3 RID: 124659 RVA: 0x00443298 File Offset: 0x00441498
		public static Offset<ICheckVillageInfrLevel> CreateICheckVillageInfrLevel(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int Level = 0)
		{
			builder.StartTable(2);
			ICheckVillageInfrLevel.AddLevel(builder, Level);
			ICheckVillageInfrLevel.AddType(builder, Type);
			return ICheckVillageInfrLevel.EndICheckVillageInfrLevel(builder);
		}

		// Token: 0x0601E6F4 RID: 124660 RVA: 0x004432B5 File Offset: 0x004414B5
		public static void StartICheckVillageInfrLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E6F5 RID: 124661 RVA: 0x004432BE File Offset: 0x004414BE
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E6F6 RID: 124662 RVA: 0x004432C9 File Offset: 0x004414C9
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		// Token: 0x0601E6F7 RID: 124663 RVA: 0x004432D4 File Offset: 0x004414D4
		public static Offset<ICheckVillageInfrLevel> EndICheckVillageInfrLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICheckVillageInfrLevel>(builder.EndTable());
		}

		// Token: 0x0601E6F8 RID: 124664 RVA: 0x004432E4 File Offset: 0x004414E4
		public ICheckVillageInfrLevelT UnPack()
		{
			ICheckVillageInfrLevelT checkVillageInfrLevelT = new ICheckVillageInfrLevelT();
			this.UnPackTo(checkVillageInfrLevelT);
			return checkVillageInfrLevelT;
		}

		// Token: 0x0601E6F9 RID: 124665 RVA: 0x004432FF File Offset: 0x004414FF
		public void UnPackTo(ICheckVillageInfrLevelT _o)
		{
			_o.Type = this.Type;
			_o.Level = this.Level;
		}

		// Token: 0x0601E6FA RID: 124666 RVA: 0x0044331C File Offset: 0x0044151C
		public static Offset<ICheckVillageInfrLevel> Pack(FlatBufferBuilder builder, ICheckVillageInfrLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckVillageInfrLevel>);
			}
			return ICheckVillageInfrLevel.CreateICheckVillageInfrLevel(builder, _o.Type, _o.Level);
		}

		// Token: 0x0400D43C RID: 54332
		private Table __p;
	}
}
