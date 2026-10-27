using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFD RID: 28413
	public struct IRoleTowerPrefabConfig : IFlatbufferObject
	{
		// Token: 0x1700D352 RID: 54098
		// (get) Token: 0x06032340 RID: 205632 RVA: 0x006C893E File Offset: 0x006C6B3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032341 RID: 205633 RVA: 0x006C894B File Offset: 0x006C6B4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032342 RID: 205634 RVA: 0x006C8954 File Offset: 0x006C6B54
		public static IRoleTowerPrefabConfig GetRootAsIRoleTowerPrefabConfig(ByteBuffer _bb)
		{
			return IRoleTowerPrefabConfig.GetRootAsIRoleTowerPrefabConfig(_bb, default(IRoleTowerPrefabConfig));
		}

		// Token: 0x06032343 RID: 205635 RVA: 0x006C8970 File Offset: 0x006C6B70
		public static IRoleTowerPrefabConfig GetRootAsIRoleTowerPrefabConfig(ByteBuffer _bb, IRoleTowerPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032344 RID: 205636 RVA: 0x006C898D File Offset: 0x006C6B8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032345 RID: 205637 RVA: 0x006C899C File Offset: 0x006C6B9C
		public IRoleTowerPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D353 RID: 54099
		// (get) Token: 0x06032346 RID: 205638 RVA: 0x006C89AC File Offset: 0x006C6BAC
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

		// Token: 0x06032347 RID: 205639 RVA: 0x006C89E8 File Offset: 0x006C6BE8
		public static Offset<IRoleTowerPrefabConfig> CreateIRoleTowerPrefabConfig(FlatBufferBuilder builder, ECreatePrefabType Type = ECreatePrefabType.PrefabId)
		{
			builder.StartTable(1);
			IRoleTowerPrefabConfig.AddType(builder, Type);
			return IRoleTowerPrefabConfig.EndIRoleTowerPrefabConfig(builder);
		}

		// Token: 0x06032348 RID: 205640 RVA: 0x006C89FE File Offset: 0x006C6BFE
		public static void StartIRoleTowerPrefabConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032349 RID: 205641 RVA: 0x006C8A07 File Offset: 0x006C6C07
		public static void AddType(FlatBufferBuilder builder, ECreatePrefabType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603234A RID: 205642 RVA: 0x006C8A12 File Offset: 0x006C6C12
		public static Offset<IRoleTowerPrefabConfig> EndIRoleTowerPrefabConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerPrefabConfig>(builder.EndTable());
		}

		// Token: 0x0603234B RID: 205643 RVA: 0x006C8A20 File Offset: 0x006C6C20
		public IRoleTowerPrefabConfigT UnPack()
		{
			IRoleTowerPrefabConfigT roleTowerPrefabConfigT = new IRoleTowerPrefabConfigT();
			this.UnPackTo(roleTowerPrefabConfigT);
			return roleTowerPrefabConfigT;
		}

		// Token: 0x0603234C RID: 205644 RVA: 0x006C8A3B File Offset: 0x006C6C3B
		public void UnPackTo(IRoleTowerPrefabConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603234D RID: 205645 RVA: 0x006C8A4C File Offset: 0x006C6C4C
		public static Offset<IRoleTowerPrefabConfig> Pack(FlatBufferBuilder builder, IRoleTowerPrefabConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerPrefabConfig>);
			}
			return IRoleTowerPrefabConfig.CreateIRoleTowerPrefabConfig(builder, _o.Type);
		}

		// Token: 0x040118F0 RID: 71920
		private Table __p;
	}
}
