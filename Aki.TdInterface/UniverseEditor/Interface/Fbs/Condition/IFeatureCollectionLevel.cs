using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C22 RID: 19490
	public struct IFeatureCollectionLevel : IFlatbufferObject
	{
		// Token: 0x17008D93 RID: 36243
		// (get) Token: 0x0601EE05 RID: 126469 RVA: 0x004525C6 File Offset: 0x004507C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE06 RID: 126470 RVA: 0x004525D3 File Offset: 0x004507D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE07 RID: 126471 RVA: 0x004525DC File Offset: 0x004507DC
		public static IFeatureCollectionLevel GetRootAsIFeatureCollectionLevel(ByteBuffer _bb)
		{
			return IFeatureCollectionLevel.GetRootAsIFeatureCollectionLevel(_bb, default(IFeatureCollectionLevel));
		}

		// Token: 0x0601EE08 RID: 126472 RVA: 0x004525F8 File Offset: 0x004507F8
		public static IFeatureCollectionLevel GetRootAsIFeatureCollectionLevel(ByteBuffer _bb, IFeatureCollectionLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE09 RID: 126473 RVA: 0x00452615 File Offset: 0x00450815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE0A RID: 126474 RVA: 0x00452624 File Offset: 0x00450824
		public IFeatureCollectionLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D94 RID: 36244
		// (get) Token: 0x0601EE0B RID: 126475 RVA: 0x00452634 File Offset: 0x00450834
		public EFormationRoleInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFormationRoleInfoType.RoleLevel;
				}
				return (EFormationRoleInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D95 RID: 36245
		// (get) Token: 0x0601EE0C RID: 126476 RVA: 0x00452670 File Offset: 0x00450870
		public int Id
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

		// Token: 0x17008D96 RID: 36246
		// (get) Token: 0x0601EE0D RID: 126477 RVA: 0x004526AC File Offset: 0x004508AC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D97 RID: 36247
		// (get) Token: 0x0601EE0E RID: 126478 RVA: 0x004526E8 File Offset: 0x004508E8
		public int Level
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

		// Token: 0x0601EE0F RID: 126479 RVA: 0x00452725 File Offset: 0x00450925
		public static Offset<IFeatureCollectionLevel> CreateIFeatureCollectionLevel(FlatBufferBuilder builder, EFormationRoleInfoType Type = EFormationRoleInfoType.RoleLevel, int Id = 0, ECompare Compare = ECompare.Eq, int Level = 0)
		{
			builder.StartTable(4);
			IFeatureCollectionLevel.AddLevel(builder, Level);
			IFeatureCollectionLevel.AddId(builder, Id);
			IFeatureCollectionLevel.AddCompare(builder, Compare);
			IFeatureCollectionLevel.AddType(builder, Type);
			return IFeatureCollectionLevel.EndIFeatureCollectionLevel(builder);
		}

		// Token: 0x0601EE10 RID: 126480 RVA: 0x00452751 File Offset: 0x00450951
		public static void StartIFeatureCollectionLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EE11 RID: 126481 RVA: 0x0045275A File Offset: 0x0045095A
		public static void AddType(FlatBufferBuilder builder, EFormationRoleInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EE12 RID: 126482 RVA: 0x00452765 File Offset: 0x00450965
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601EE13 RID: 126483 RVA: 0x00452770 File Offset: 0x00450970
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601EE14 RID: 126484 RVA: 0x0045277B File Offset: 0x0045097B
		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(3, level, 0);
		}

		// Token: 0x0601EE15 RID: 126485 RVA: 0x00452786 File Offset: 0x00450986
		public static Offset<IFeatureCollectionLevel> EndIFeatureCollectionLevel(FlatBufferBuilder builder)
		{
			return new Offset<IFeatureCollectionLevel>(builder.EndTable());
		}

		// Token: 0x0601EE16 RID: 126486 RVA: 0x00452794 File Offset: 0x00450994
		public IFeatureCollectionLevelT UnPack()
		{
			IFeatureCollectionLevelT featureCollectionLevelT = new IFeatureCollectionLevelT();
			this.UnPackTo(featureCollectionLevelT);
			return featureCollectionLevelT;
		}

		// Token: 0x0601EE17 RID: 126487 RVA: 0x004527AF File Offset: 0x004509AF
		public void UnPackTo(IFeatureCollectionLevelT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Compare = this.Compare;
			_o.Level = this.Level;
		}

		// Token: 0x0601EE18 RID: 126488 RVA: 0x004527E4 File Offset: 0x004509E4
		public static Offset<IFeatureCollectionLevel> Pack(FlatBufferBuilder builder, IFeatureCollectionLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFeatureCollectionLevel>);
			}
			return IFeatureCollectionLevel.CreateIFeatureCollectionLevel(builder, _o.Type, _o.Id, _o.Compare, _o.Level);
		}

		// Token: 0x0400D5BA RID: 54714
		private Table __p;
	}
}
