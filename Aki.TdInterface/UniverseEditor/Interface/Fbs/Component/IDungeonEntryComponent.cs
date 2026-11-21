using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005628 RID: 22056
	public struct IDungeonEntryComponent : IFlatbufferObject
	{
		// Token: 0x17009E61 RID: 40545
		// (get) Token: 0x06023363 RID: 144227 RVA: 0x004D8A12 File Offset: 0x004D6C12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023364 RID: 144228 RVA: 0x004D8A1F File Offset: 0x004D6C1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023365 RID: 144229 RVA: 0x004D8A28 File Offset: 0x004D6C28
		public static IDungeonEntryComponent GetRootAsIDungeonEntryComponent(ByteBuffer _bb)
		{
			return IDungeonEntryComponent.GetRootAsIDungeonEntryComponent(_bb, default(IDungeonEntryComponent));
		}

		// Token: 0x06023366 RID: 144230 RVA: 0x004D8A44 File Offset: 0x004D6C44
		public static IDungeonEntryComponent GetRootAsIDungeonEntryComponent(ByteBuffer _bb, IDungeonEntryComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023367 RID: 144231 RVA: 0x004D8A61 File Offset: 0x004D6C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023368 RID: 144232 RVA: 0x004D8A70 File Offset: 0x004D6C70
		public IDungeonEntryComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E62 RID: 40546
		// (get) Token: 0x06023369 RID: 144233 RVA: 0x004D8A80 File Offset: 0x004D6C80
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E63 RID: 40547
		// (get) Token: 0x0602336A RID: 144234 RVA: 0x004D8AC0 File Offset: 0x004D6CC0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602336B RID: 144235 RVA: 0x004D8AFC File Offset: 0x004D6CFC
		public static Offset<IDungeonEntryComponent> CreateIDungeonEntryComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDungeonEntryComponent.AddNullMask(builder, NullMask);
			IDungeonEntryComponent.AddDisabled(builder, Disabled);
			return IDungeonEntryComponent.EndIDungeonEntryComponent(builder);
		}

		// Token: 0x0602336C RID: 144236 RVA: 0x004D8B19 File Offset: 0x004D6D19
		public static void StartIDungeonEntryComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602336D RID: 144237 RVA: 0x004D8B22 File Offset: 0x004D6D22
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602336E RID: 144238 RVA: 0x004D8B2D File Offset: 0x004D6D2D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602336F RID: 144239 RVA: 0x004D8B38 File Offset: 0x004D6D38
		public static Offset<IDungeonEntryComponent> EndIDungeonEntryComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonEntryComponent>(builder.EndTable());
		}

		// Token: 0x06023370 RID: 144240 RVA: 0x004D8B48 File Offset: 0x004D6D48
		public IDungeonEntryComponentT UnPack()
		{
			IDungeonEntryComponentT dungeonEntryComponentT = new IDungeonEntryComponentT();
			this.UnPackTo(dungeonEntryComponentT);
			return dungeonEntryComponentT;
		}

		// Token: 0x06023371 RID: 144241 RVA: 0x004D8B63 File Offset: 0x004D6D63
		public void UnPackTo(IDungeonEntryComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023372 RID: 144242 RVA: 0x004D8B80 File Offset: 0x004D6D80
		public static Offset<IDungeonEntryComponent> Pack(FlatBufferBuilder builder, IDungeonEntryComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonEntryComponent>);
			}
			return IDungeonEntryComponent.CreateIDungeonEntryComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400ED04 RID: 60676
		private Table __p;
	}
}
