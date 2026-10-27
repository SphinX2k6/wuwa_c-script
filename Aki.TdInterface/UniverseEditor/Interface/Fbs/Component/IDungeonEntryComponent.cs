using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C3 RID: 20675
	public struct IDungeonEntryComponent : IFlatbufferObject
	{
		// Token: 0x17009674 RID: 38516
		// (get) Token: 0x0602140F RID: 136207 RVA: 0x0049EA86 File Offset: 0x0049CC86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021410 RID: 136208 RVA: 0x0049EA93 File Offset: 0x0049CC93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021411 RID: 136209 RVA: 0x0049EA9C File Offset: 0x0049CC9C
		public static IDungeonEntryComponent GetRootAsIDungeonEntryComponent(ByteBuffer _bb)
		{
			return IDungeonEntryComponent.GetRootAsIDungeonEntryComponent(_bb, default(IDungeonEntryComponent));
		}

		// Token: 0x06021412 RID: 136210 RVA: 0x0049EAB8 File Offset: 0x0049CCB8
		public static IDungeonEntryComponent GetRootAsIDungeonEntryComponent(ByteBuffer _bb, IDungeonEntryComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021413 RID: 136211 RVA: 0x0049EAD5 File Offset: 0x0049CCD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021414 RID: 136212 RVA: 0x0049EAE4 File Offset: 0x0049CCE4
		public IDungeonEntryComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009675 RID: 38517
		// (get) Token: 0x06021415 RID: 136213 RVA: 0x0049EAF4 File Offset: 0x0049CCF4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009676 RID: 38518
		// (get) Token: 0x06021416 RID: 136214 RVA: 0x0049EB34 File Offset: 0x0049CD34
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

		// Token: 0x06021417 RID: 136215 RVA: 0x0049EB70 File Offset: 0x0049CD70
		public static Offset<IDungeonEntryComponent> CreateIDungeonEntryComponent(FlatBufferBuilder builder, bool Disabled = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDungeonEntryComponent.AddNullMask(builder, NullMask);
			IDungeonEntryComponent.AddDisabled(builder, Disabled);
			return IDungeonEntryComponent.EndIDungeonEntryComponent(builder);
		}

		// Token: 0x06021418 RID: 136216 RVA: 0x0049EB8D File Offset: 0x0049CD8D
		public static void StartIDungeonEntryComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021419 RID: 136217 RVA: 0x0049EB96 File Offset: 0x0049CD96
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602141A RID: 136218 RVA: 0x0049EBA1 File Offset: 0x0049CDA1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602141B RID: 136219 RVA: 0x0049EBAC File Offset: 0x0049CDAC
		public static Offset<IDungeonEntryComponent> EndIDungeonEntryComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonEntryComponent>(builder.EndTable());
		}

		// Token: 0x0602141C RID: 136220 RVA: 0x0049EBBC File Offset: 0x0049CDBC
		public IDungeonEntryComponentT UnPack()
		{
			IDungeonEntryComponentT dungeonEntryComponentT = new IDungeonEntryComponentT();
			this.UnPackTo(dungeonEntryComponentT);
			return dungeonEntryComponentT;
		}

		// Token: 0x0602141D RID: 136221 RVA: 0x0049EBD7 File Offset: 0x0049CDD7
		public void UnPackTo(IDungeonEntryComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602141E RID: 136222 RVA: 0x0049EBF4 File Offset: 0x0049CDF4
		public static Offset<IDungeonEntryComponent> Pack(FlatBufferBuilder builder, IDungeonEntryComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonEntryComponent>);
			}
			return IDungeonEntryComponent.CreateIDungeonEntryComponent(builder, _o.Disabled, _o.NullMask);
		}

		// Token: 0x0400E107 RID: 57607
		private Table __p;
	}
}
