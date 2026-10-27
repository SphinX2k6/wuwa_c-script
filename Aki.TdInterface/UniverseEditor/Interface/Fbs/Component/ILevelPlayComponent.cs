using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DF RID: 21727
	public struct ILevelPlayComponent : IFlatbufferObject
	{
		// Token: 0x1700A035 RID: 41013
		// (get) Token: 0x06023D3E RID: 146750 RVA: 0x004F40BF File Offset: 0x004F22BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023D3F RID: 146751 RVA: 0x004F40CC File Offset: 0x004F22CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023D40 RID: 146752 RVA: 0x004F40D4 File Offset: 0x004F22D4
		public static ILevelPlayComponent GetRootAsILevelPlayComponent(ByteBuffer _bb)
		{
			return ILevelPlayComponent.GetRootAsILevelPlayComponent(_bb, default(ILevelPlayComponent));
		}

		// Token: 0x06023D41 RID: 146753 RVA: 0x004F40F0 File Offset: 0x004F22F0
		public static ILevelPlayComponent GetRootAsILevelPlayComponent(ByteBuffer _bb, ILevelPlayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023D42 RID: 146754 RVA: 0x004F410D File Offset: 0x004F230D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023D43 RID: 146755 RVA: 0x004F411C File Offset: 0x004F231C
		public ILevelPlayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A036 RID: 41014
		// (get) Token: 0x06023D44 RID: 146756 RVA: 0x004F412C File Offset: 0x004F232C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A037 RID: 41015
		// (get) Token: 0x06023D45 RID: 146757 RVA: 0x004F416C File Offset: 0x004F236C
		public int LevelPlayId
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

		// Token: 0x1700A038 RID: 41016
		// (get) Token: 0x06023D46 RID: 146758 RVA: 0x004F41A8 File Offset: 0x004F23A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023D47 RID: 146759 RVA: 0x004F41E4 File Offset: 0x004F23E4
		public static Offset<ILevelPlayComponent> CreateILevelPlayComponent(FlatBufferBuilder builder, bool Disabled = false, int LevelPlayId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelPlayComponent.AddLevelPlayId(builder, LevelPlayId);
			ILevelPlayComponent.AddNullMask(builder, NullMask);
			ILevelPlayComponent.AddDisabled(builder, Disabled);
			return ILevelPlayComponent.EndILevelPlayComponent(builder);
		}

		// Token: 0x06023D48 RID: 146760 RVA: 0x004F4208 File Offset: 0x004F2408
		public static void StartILevelPlayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023D49 RID: 146761 RVA: 0x004F4211 File Offset: 0x004F2411
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023D4A RID: 146762 RVA: 0x004F421C File Offset: 0x004F241C
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x06023D4B RID: 146763 RVA: 0x004F4227 File Offset: 0x004F2427
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023D4C RID: 146764 RVA: 0x004F4232 File Offset: 0x004F2432
		public static Offset<ILevelPlayComponent> EndILevelPlayComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayComponent>(builder.EndTable());
		}

		// Token: 0x06023D4D RID: 146765 RVA: 0x004F4240 File Offset: 0x004F2440
		public ILevelPlayComponentT UnPack()
		{
			ILevelPlayComponentT levelPlayComponentT = new ILevelPlayComponentT();
			this.UnPackTo(levelPlayComponentT);
			return levelPlayComponentT;
		}

		// Token: 0x06023D4E RID: 146766 RVA: 0x004F425B File Offset: 0x004F245B
		public void UnPackTo(ILevelPlayComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.LevelPlayId = this.LevelPlayId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023D4F RID: 146767 RVA: 0x004F4284 File Offset: 0x004F2484
		public static Offset<ILevelPlayComponent> Pack(FlatBufferBuilder builder, ILevelPlayComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayComponent>);
			}
			return ILevelPlayComponent.CreateILevelPlayComponent(builder, _o.Disabled, _o.LevelPlayId, _o.NullMask);
		}

		// Token: 0x0400E7B0 RID: 59312
		private Table __p;
	}
}
