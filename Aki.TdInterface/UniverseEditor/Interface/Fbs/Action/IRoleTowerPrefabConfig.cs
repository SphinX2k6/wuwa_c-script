using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007681 RID: 30337
	public struct IRoleTowerPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700DEA9 RID: 57001
		// (get) Token: 0x06035380 RID: 217984 RVA: 0x00724672 File Offset: 0x00722872
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035381 RID: 217985 RVA: 0x0072467F File Offset: 0x0072287F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035382 RID: 217986 RVA: 0x00724688 File Offset: 0x00722888
		public static IRoleTowerPrefabConfig GetRootAsIRoleTowerPrefabConfig(ByteBuffer _bb)
		{
			return IRoleTowerPrefabConfig.GetRootAsIRoleTowerPrefabConfig(_bb, default(IRoleTowerPrefabConfig));
		}

		// Token: 0x06035383 RID: 217987 RVA: 0x007246A4 File Offset: 0x007228A4
		public static IRoleTowerPrefabConfig GetRootAsIRoleTowerPrefabConfig(ByteBuffer _bb, IRoleTowerPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035384 RID: 217988 RVA: 0x007246C1 File Offset: 0x007228C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035385 RID: 217989 RVA: 0x007246D0 File Offset: 0x007228D0
		public IRoleTowerPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEAA RID: 57002
		// (get) Token: 0x06035386 RID: 217990 RVA: 0x007246E0 File Offset: 0x007228E0
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

		// Token: 0x06035387 RID: 217991 RVA: 0x0072471C File Offset: 0x0072291C
		public static Offset<IRoleTowerPrefabConfig> CreateIRoleTowerPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId)
		{
			builder.StartTable(1);
			IRoleTowerPrefabConfig.AddType(builder, Type);
			return IRoleTowerPrefabConfig.EndIRoleTowerPrefabConfig(builder);
		}

		// Token: 0x06035388 RID: 217992 RVA: 0x00724732 File Offset: 0x00722932
		public static void StartIRoleTowerPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035389 RID: 217993 RVA: 0x0072473B File Offset: 0x0072293B
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603538A RID: 217994 RVA: 0x00724746 File Offset: 0x00722946
		public static Offset<IRoleTowerPrefabConfig> EndIRoleTowerPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerPrefabConfig>(builder.EndTable());
		}

		// Token: 0x0603538B RID: 217995 RVA: 0x00724754 File Offset: 0x00722954
		public IRoleTowerPrefabConfigT UnPack()
		{
			IRoleTowerPrefabConfigT roleTowerPrefabConfigT = new IRoleTowerPrefabConfigT();
			this.UnPackTo(roleTowerPrefabConfigT);
			return roleTowerPrefabConfigT;
		}

		// Token: 0x0603538C RID: 217996 RVA: 0x0072476F File Offset: 0x0072296F
		public void UnPackTo(IRoleTowerPrefabConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603538D RID: 217997 RVA: 0x00724780 File Offset: 0x00722980
		public static Offset<IRoleTowerPrefabConfig> Pack(FlatBufferBuilder builder, IRoleTowerPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerPrefabConfig>);
			}
			return IRoleTowerPrefabConfig.CreateIRoleTowerPrefabConfig(builder, _o.Type);
		}

		// Token: 0x04012875 RID: 75893
		private Table __p;
	}
}
