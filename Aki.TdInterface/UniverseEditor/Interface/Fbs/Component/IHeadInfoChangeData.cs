using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005362 RID: 21346
	public struct IHeadInfoChangeData : IFlatbufferObject
	{
		// Token: 0x17009CD8 RID: 40152
		// (get) Token: 0x06022EC4 RID: 143044 RVA: 0x004D62FC File Offset: 0x004D44FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022EC5 RID: 143045 RVA: 0x004D6309 File Offset: 0x004D4509
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022EC6 RID: 143046 RVA: 0x004D6310 File Offset: 0x004D4510
		public static IHeadInfoChangeData GetRootAsIHeadInfoChangeData(ByteBuffer _bb)
		{
			return IHeadInfoChangeData.GetRootAsIHeadInfoChangeData(_bb, default(IHeadInfoChangeData));
		}

		// Token: 0x06022EC7 RID: 143047 RVA: 0x004D632C File Offset: 0x004D452C
		public static IHeadInfoChangeData GetRootAsIHeadInfoChangeData(ByteBuffer _bb, IHeadInfoChangeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022EC8 RID: 143048 RVA: 0x004D6349 File Offset: 0x004D4549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022EC9 RID: 143049 RVA: 0x004D6358 File Offset: 0x004D4558
		public IHeadInfoChangeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CD9 RID: 40153
		// (get) Token: 0x06022ECA RID: 143050 RVA: 0x004D6368 File Offset: 0x004D4568
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009CDA RID: 40154
		// (get) Token: 0x06022ECB RID: 143051 RVA: 0x004D63C8 File Offset: 0x004D45C8
		public string TidName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022ECC RID: 143052 RVA: 0x004D63FF File Offset: 0x004D45FF
		public Span<byte> GetTidNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022ECD RID: 143053 RVA: 0x004D640E File Offset: 0x004D460E
		public byte[] GetTidNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009CDB RID: 40155
		// (get) Token: 0x06022ECE RID: 143054 RVA: 0x004D641C File Offset: 0x004D461C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022ECF RID: 143055 RVA: 0x004D6453 File Offset: 0x004D4653
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06022ED0 RID: 143056 RVA: 0x004D6462 File Offset: 0x004D4662
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009CDC RID: 40156
		// (get) Token: 0x06022ED1 RID: 143057 RVA: 0x004D6470 File Offset: 0x004D4670
		public string TidSecondaryName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022ED2 RID: 143058 RVA: 0x004D64A8 File Offset: 0x004D46A8
		public Span<byte> GetTidSecondaryNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06022ED3 RID: 143059 RVA: 0x004D64B8 File Offset: 0x004D46B8
		public byte[] GetTidSecondaryNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06022ED4 RID: 143060 RVA: 0x004D64C7 File Offset: 0x004D46C7
		public static Offset<IHeadInfoChangeData> CreateIHeadInfoChangeData(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), StringOffset TidNameOffset = default(StringOffset), StringOffset IconOffset = default(StringOffset), StringOffset TidSecondaryNameOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IHeadInfoChangeData.AddTidSecondaryName(builder, TidSecondaryNameOffset);
			IHeadInfoChangeData.AddIcon(builder, IconOffset);
			IHeadInfoChangeData.AddTidName(builder, TidNameOffset);
			IHeadInfoChangeData.AddConditions(builder, ConditionsOffset);
			return IHeadInfoChangeData.EndIHeadInfoChangeData(builder);
		}

		// Token: 0x06022ED5 RID: 143061 RVA: 0x004D64F3 File Offset: 0x004D46F3
		public static void StartIHeadInfoChangeData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022ED6 RID: 143062 RVA: 0x004D64FC File Offset: 0x004D46FC
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06022ED7 RID: 143063 RVA: 0x004D650C File Offset: 0x004D470C
		public static void AddTidName(FlatBufferBuilder builder, StringOffset tidNameOffset)
		{
			builder.AddOffset(1, tidNameOffset.Value, 0);
		}

		// Token: 0x06022ED8 RID: 143064 RVA: 0x004D651C File Offset: 0x004D471C
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x06022ED9 RID: 143065 RVA: 0x004D652C File Offset: 0x004D472C
		public static void AddTidSecondaryName(FlatBufferBuilder builder, StringOffset tidSecondaryNameOffset)
		{
			builder.AddOffset(3, tidSecondaryNameOffset.Value, 0);
		}

		// Token: 0x06022EDA RID: 143066 RVA: 0x004D653C File Offset: 0x004D473C
		public static Offset<IHeadInfoChangeData> EndIHeadInfoChangeData(FlatBufferBuilder builder)
		{
			return new Offset<IHeadInfoChangeData>(builder.EndTable());
		}

		// Token: 0x06022EDB RID: 143067 RVA: 0x004D654C File Offset: 0x004D474C
		public IHeadInfoChangeDataT UnPack()
		{
			IHeadInfoChangeDataT headInfoChangeDataT = new IHeadInfoChangeDataT();
			this.UnPackTo(headInfoChangeDataT);
			return headInfoChangeDataT;
		}

		// Token: 0x06022EDC RID: 143068 RVA: 0x004D6568 File Offset: 0x004D4768
		public void UnPackTo(IHeadInfoChangeDataT _o)
		{
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.TidName = this.TidName;
			_o.Icon = this.Icon;
			_o.TidSecondaryName = this.TidSecondaryName;
		}

		// Token: 0x06022EDD RID: 143069 RVA: 0x004D65C8 File Offset: 0x004D47C8
		public static Offset<IHeadInfoChangeData> Pack(FlatBufferBuilder builder, IHeadInfoChangeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadInfoChangeData>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			StringOffset tidNameOffset = (_o.TidName == null) ? default(StringOffset) : builder.CreateString(_o.TidName);
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			StringOffset tidSecondaryNameOffset = (_o.TidSecondaryName == null) ? default(StringOffset) : builder.CreateString(_o.TidSecondaryName);
			return IHeadInfoChangeData.CreateIHeadInfoChangeData(builder, conditionsOffset, tidNameOffset, iconOffset, tidSecondaryNameOffset);
		}

		// Token: 0x0400E53D RID: 58685
		private Table __p;
	}
}
