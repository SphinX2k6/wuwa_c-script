using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050FF RID: 20735
	public struct IDynamicSpawnMonsterPointComponent : IFlatbufferObject
	{
		// Token: 0x17009710 RID: 38672
		// (get) Token: 0x0602166C RID: 136812 RVA: 0x004A379C File Offset: 0x004A199C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602166D RID: 136813 RVA: 0x004A37A9 File Offset: 0x004A19A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602166E RID: 136814 RVA: 0x004A37B0 File Offset: 0x004A19B0
		public static IDynamicSpawnMonsterPointComponent GetRootAsIDynamicSpawnMonsterPointComponent(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterPointComponent.GetRootAsIDynamicSpawnMonsterPointComponent(_bb, default(IDynamicSpawnMonsterPointComponent));
		}

		// Token: 0x0602166F RID: 136815 RVA: 0x004A37CC File Offset: 0x004A19CC
		public static IDynamicSpawnMonsterPointComponent GetRootAsIDynamicSpawnMonsterPointComponent(ByteBuffer _bb, IDynamicSpawnMonsterPointComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021670 RID: 136816 RVA: 0x004A37E9 File Offset: 0x004A19E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021671 RID: 136817 RVA: 0x004A37F8 File Offset: 0x004A19F8
		public IDynamicSpawnMonsterPointComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009711 RID: 38673
		// (get) Token: 0x06021672 RID: 136818 RVA: 0x004A3808 File Offset: 0x004A1A08
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009712 RID: 38674
		// (get) Token: 0x06021673 RID: 136819 RVA: 0x004A3848 File Offset: 0x004A1A48
		public int TagId
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

		// Token: 0x17009713 RID: 38675
		// (get) Token: 0x06021674 RID: 136820 RVA: 0x004A3884 File Offset: 0x004A1A84
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

		// Token: 0x06021675 RID: 136821 RVA: 0x004A38C0 File Offset: 0x004A1AC0
		public static Offset<IDynamicSpawnMonsterPointComponent> CreateIDynamicSpawnMonsterPointComponent(FlatBufferBuilder builder, bool Disabled = false, int TagId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDynamicSpawnMonsterPointComponent.AddTagId(builder, TagId);
			IDynamicSpawnMonsterPointComponent.AddNullMask(builder, NullMask);
			IDynamicSpawnMonsterPointComponent.AddDisabled(builder, Disabled);
			return IDynamicSpawnMonsterPointComponent.EndIDynamicSpawnMonsterPointComponent(builder);
		}

		// Token: 0x06021676 RID: 136822 RVA: 0x004A38E4 File Offset: 0x004A1AE4
		public static void StartIDynamicSpawnMonsterPointComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021677 RID: 136823 RVA: 0x004A38ED File Offset: 0x004A1AED
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021678 RID: 136824 RVA: 0x004A38F8 File Offset: 0x004A1AF8
		public static void AddTagId(FlatBufferBuilder builder, int tagId)
		{
			builder.AddInt(1, tagId, 0);
		}

		// Token: 0x06021679 RID: 136825 RVA: 0x004A3903 File Offset: 0x004A1B03
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602167A RID: 136826 RVA: 0x004A390E File Offset: 0x004A1B0E
		public static Offset<IDynamicSpawnMonsterPointComponent> EndIDynamicSpawnMonsterPointComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterPointComponent>(builder.EndTable());
		}

		// Token: 0x0602167B RID: 136827 RVA: 0x004A391C File Offset: 0x004A1B1C
		public IDynamicSpawnMonsterPointComponentT UnPack()
		{
			IDynamicSpawnMonsterPointComponentT dynamicSpawnMonsterPointComponentT = new IDynamicSpawnMonsterPointComponentT();
			this.UnPackTo(dynamicSpawnMonsterPointComponentT);
			return dynamicSpawnMonsterPointComponentT;
		}

		// Token: 0x0602167C RID: 136828 RVA: 0x004A3937 File Offset: 0x004A1B37
		public void UnPackTo(IDynamicSpawnMonsterPointComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TagId = this.TagId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602167D RID: 136829 RVA: 0x004A3960 File Offset: 0x004A1B60
		public static Offset<IDynamicSpawnMonsterPointComponent> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterPointComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterPointComponent>);
			}
			return IDynamicSpawnMonsterPointComponent.CreateIDynamicSpawnMonsterPointComponent(builder, _o.Disabled, _o.TagId, _o.NullMask);
		}

		// Token: 0x0400E168 RID: 57704
		private Table __p;
	}
}
