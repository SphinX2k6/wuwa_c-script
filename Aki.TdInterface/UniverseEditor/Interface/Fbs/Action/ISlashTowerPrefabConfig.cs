using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200713C RID: 28988
	public struct ISlashTowerPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700D766 RID: 55142
		// (get) Token: 0x0603363A RID: 210490 RVA: 0x006ECF71 File Offset: 0x006EB171
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603363B RID: 210491 RVA: 0x006ECF7E File Offset: 0x006EB17E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603363C RID: 210492 RVA: 0x006ECF88 File Offset: 0x006EB188
		public static ISlashTowerPrefabConfig GetRootAsISlashTowerPrefabConfig(ByteBuffer _bb)
		{
			return ISlashTowerPrefabConfig.GetRootAsISlashTowerPrefabConfig(_bb, default(ISlashTowerPrefabConfig));
		}

		// Token: 0x0603363D RID: 210493 RVA: 0x006ECFA4 File Offset: 0x006EB1A4
		public static ISlashTowerPrefabConfig GetRootAsISlashTowerPrefabConfig(ByteBuffer _bb, ISlashTowerPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603363E RID: 210494 RVA: 0x006ECFC1 File Offset: 0x006EB1C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603363F RID: 210495 RVA: 0x006ECFD0 File Offset: 0x006EB1D0
		public ISlashTowerPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D767 RID: 55143
		// (get) Token: 0x06033640 RID: 210496 RVA: 0x006ECFE0 File Offset: 0x006EB1E0
		public ECreatePrefabType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECreatePrefabType.PrefabId;
				}
				return (ECreatePrefabType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D768 RID: 55144
		// (get) Token: 0x06033641 RID: 210497 RVA: 0x006ED01C File Offset: 0x006EB21C
		public int Index
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

		// Token: 0x06033642 RID: 210498 RVA: 0x006ED058 File Offset: 0x006EB258
		public static Offset<ISlashTowerPrefabConfig> CreateISlashTowerPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId, int Index = 0)
		{
			builder.StartTable(2);
			ISlashTowerPrefabConfig.AddIndex(builder, Index);
			ISlashTowerPrefabConfig.AddType(builder, Type);
			return ISlashTowerPrefabConfig.EndISlashTowerPrefabConfig(builder);
		}

		// Token: 0x06033643 RID: 210499 RVA: 0x006ED075 File Offset: 0x006EB275
		public static void StartISlashTowerPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033644 RID: 210500 RVA: 0x006ED07E File Offset: 0x006EB27E
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033645 RID: 210501 RVA: 0x006ED089 File Offset: 0x006EB289
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(1, index, 0);
		}

		// Token: 0x06033646 RID: 210502 RVA: 0x006ED094 File Offset: 0x006EB294
		public static Offset<ISlashTowerPrefabConfig> EndISlashTowerPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISlashTowerPrefabConfig>(builder.EndTable());
		}

		// Token: 0x06033647 RID: 210503 RVA: 0x006ED0A4 File Offset: 0x006EB2A4
		public ISlashTowerPrefabConfigT UnPack()
		{
			ISlashTowerPrefabConfigT slashTowerPrefabConfigT = new ISlashTowerPrefabConfigT();
			this.UnPackTo(slashTowerPrefabConfigT);
			return slashTowerPrefabConfigT;
		}

		// Token: 0x06033648 RID: 210504 RVA: 0x006ED0BF File Offset: 0x006EB2BF
		public void UnPackTo(ISlashTowerPrefabConfigT _o)
		{
			_o.Type = this.Type;
			_o.Index = this.Index;
		}

		// Token: 0x06033649 RID: 210505 RVA: 0x006ED0DC File Offset: 0x006EB2DC
		public static Offset<ISlashTowerPrefabConfig> Pack(FlatBufferBuilder builder, ISlashTowerPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlashTowerPrefabConfig>);
			}
			return ISlashTowerPrefabConfig.CreateISlashTowerPrefabConfig(builder, _o.Type, _o.Index);
		}

		// Token: 0x04011BD7 RID: 72663
		private Table __p;
	}
}
