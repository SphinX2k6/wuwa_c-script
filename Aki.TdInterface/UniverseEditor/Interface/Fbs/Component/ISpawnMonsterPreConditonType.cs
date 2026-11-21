using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F66 RID: 24422
	public struct ISpawnMonsterPreConditonType : IFlatbufferObject
	{
		// Token: 0x1700B4E9 RID: 46313
		// (get) Token: 0x060290E5 RID: 168165 RVA: 0x0059BAF4 File Offset: 0x00599CF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060290E6 RID: 168166 RVA: 0x0059BB01 File Offset: 0x00599D01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060290E7 RID: 168167 RVA: 0x0059BB08 File Offset: 0x00599D08
		public static ISpawnMonsterPreConditonType GetRootAsISpawnMonsterPreConditonType(ByteBuffer _bb)
		{
			return ISpawnMonsterPreConditonType.GetRootAsISpawnMonsterPreConditonType(_bb, default(ISpawnMonsterPreConditonType));
		}

		// Token: 0x060290E8 RID: 168168 RVA: 0x0059BB24 File Offset: 0x00599D24
		public static ISpawnMonsterPreConditonType GetRootAsISpawnMonsterPreConditonType(ByteBuffer _bb, ISpawnMonsterPreConditonType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060290E9 RID: 168169 RVA: 0x0059BB41 File Offset: 0x00599D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060290EA RID: 168170 RVA: 0x0059BB50 File Offset: 0x00599D50
		public ISpawnMonsterPreConditonType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4EA RID: 46314
		// (get) Token: 0x060290EB RID: 168171 RVA: 0x0059BB60 File Offset: 0x00599D60
		public ESpawnMonsterPreCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterPreCondition.DependOnPreceding;
				}
				return (ESpawnMonsterPreCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060290EC RID: 168172 RVA: 0x0059BB9C File Offset: 0x00599D9C
		public static Offset<ISpawnMonsterPreConditonType> CreateISpawnMonsterPreConditonType(FlatBufferBuilder builder, ESpawnMonsterPreCondition Type = ESpawnMonsterPreCondition.DependOnPreceding)
		{
			builder.StartTable(1);
			ISpawnMonsterPreConditonType.AddType(builder, Type);
			return ISpawnMonsterPreConditonType.EndISpawnMonsterPreConditonType(builder);
		}

		// Token: 0x060290ED RID: 168173 RVA: 0x0059BBB2 File Offset: 0x00599DB2
		public static void StartISpawnMonsterPreConditonType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060290EE RID: 168174 RVA: 0x0059BBBB File Offset: 0x00599DBB
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterPreCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060290EF RID: 168175 RVA: 0x0059BBC6 File Offset: 0x00599DC6
		public static Offset<ISpawnMonsterPreConditonType> EndISpawnMonsterPreConditonType(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterPreConditonType>(builder.EndTable());
		}

		// Token: 0x060290F0 RID: 168176 RVA: 0x0059BBD4 File Offset: 0x00599DD4
		public ISpawnMonsterPreConditonTypeT UnPack()
		{
			ISpawnMonsterPreConditonTypeT spawnMonsterPreConditonTypeT = new ISpawnMonsterPreConditonTypeT();
			this.UnPackTo(spawnMonsterPreConditonTypeT);
			return spawnMonsterPreConditonTypeT;
		}

		// Token: 0x060290F1 RID: 168177 RVA: 0x0059BBEF File Offset: 0x00599DEF
		public void UnPackTo(ISpawnMonsterPreConditonTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060290F2 RID: 168178 RVA: 0x0059BC00 File Offset: 0x00599E00
		public static Offset<ISpawnMonsterPreConditonType> Pack(FlatBufferBuilder builder, ISpawnMonsterPreConditonTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterPreConditonType>);
			}
			return ISpawnMonsterPreConditonType.CreateISpawnMonsterPreConditonType(builder, _o.Type);
		}

		// Token: 0x0400FC30 RID: 64560
		private Table __p;
	}
}
