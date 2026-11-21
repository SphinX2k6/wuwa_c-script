using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F95 RID: 28565
	public struct IHideGroup : IFlatbufferObject
	{
		// Token: 0x1700D139 RID: 53561
		// (get) Token: 0x06031728 RID: 202536 RVA: 0x006B418C File Offset: 0x006B238C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031729 RID: 202537 RVA: 0x006B4199 File Offset: 0x006B2399
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603172A RID: 202538 RVA: 0x006B41A0 File Offset: 0x006B23A0
		public static IHideGroup GetRootAsIHideGroup(ByteBuffer _bb)
		{
			return IHideGroup.GetRootAsIHideGroup(_bb, default(IHideGroup));
		}

		// Token: 0x0603172B RID: 202539 RVA: 0x006B41BC File Offset: 0x006B23BC
		public static IHideGroup GetRootAsIHideGroup(ByteBuffer _bb, IHideGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603172C RID: 202540 RVA: 0x006B41D9 File Offset: 0x006B23D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603172D RID: 202541 RVA: 0x006B41E8 File Offset: 0x006B23E8
		public IHideGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D13A RID: 53562
		// (get) Token: 0x0603172E RID: 202542 RVA: 0x006B41F8 File Offset: 0x006B23F8
		public string GroupKey
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603172F RID: 202543 RVA: 0x006B422F File Offset: 0x006B242F
		public Span<byte> GetGroupKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031730 RID: 202544 RVA: 0x006B423E File Offset: 0x006B243E
		public byte[] GetGroupKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D13B RID: 53563
		// (get) Token: 0x06031731 RID: 202545 RVA: 0x006B424C File Offset: 0x006B244C
		public THideGroupConfig HideConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return THideGroupConfig.NONE;
				}
				return (THideGroupConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031732 RID: 202546 RVA: 0x006B4288 File Offset: 0x006B2488
		public TTable? HideConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031733 RID: 202547 RVA: 0x006B42CC File Offset: 0x006B24CC
		public IHideSpecifyDataLayers HideConfigAsIHideSpecifyDataLayers()
		{
			return this.HideConfig<IHideSpecifyDataLayers>().Value;
		}

		// Token: 0x06031734 RID: 202548 RVA: 0x006B42E8 File Offset: 0x006B24E8
		public IHideSpecifyEntityGroup HideConfigAsIHideSpecifyEntityGroup()
		{
			return this.HideConfig<IHideSpecifyEntityGroup>().Value;
		}

		// Token: 0x06031735 RID: 202549 RVA: 0x006B4304 File Offset: 0x006B2504
		public IHideSpecifyLevelPlayGroup HideConfigAsIHideSpecifyLevelPlayGroup()
		{
			return this.HideConfig<IHideSpecifyLevelPlayGroup>().Value;
		}

		// Token: 0x06031736 RID: 202550 RVA: 0x006B4320 File Offset: 0x006B2520
		public IHideWorldEntityAndLevelPlayGroup HideConfigAsIHideWorldEntityAndLevelPlayGroup()
		{
			return this.HideConfig<IHideWorldEntityAndLevelPlayGroup>().Value;
		}

		// Token: 0x06031737 RID: 202551 RVA: 0x006B433C File Offset: 0x006B253C
		public IHideWorldMonsterAndMonsterTreasureGroup HideConfigAsIHideWorldMonsterAndMonsterTreasureGroup()
		{
			return this.HideConfig<IHideWorldMonsterAndMonsterTreasureGroup>().Value;
		}

		// Token: 0x1700D13C RID: 53564
		// (get) Token: 0x06031738 RID: 202552 RVA: 0x006B4358 File Offset: 0x006B2558
		public bool IsHidePasserByNpc
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D13D RID: 53565
		// (get) Token: 0x06031739 RID: 202553 RVA: 0x006B4398 File Offset: 0x006B2598
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603173A RID: 202554 RVA: 0x006B43D5 File Offset: 0x006B25D5
		public static Offset<IHideGroup> CreateIHideGroup(FlatBufferBuilder builder, StringOffset GroupKeyOffset = default(StringOffset), THideGroupConfig HideConfig_type = THideGroupConfig.NONE, int HideConfigOffset = 0, bool IsHidePasserByNpc = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IHideGroup.AddHideConfig(builder, HideConfigOffset);
			IHideGroup.AddGroupKey(builder, GroupKeyOffset);
			IHideGroup.AddNullMask(builder, NullMask);
			IHideGroup.AddIsHidePasserByNpc(builder, IsHidePasserByNpc);
			IHideGroup.AddHideConfigType(builder, HideConfig_type);
			return IHideGroup.EndIHideGroup(builder);
		}

		// Token: 0x0603173B RID: 202555 RVA: 0x006B4409 File Offset: 0x006B2609
		public static void StartIHideGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603173C RID: 202556 RVA: 0x006B4412 File Offset: 0x006B2612
		public static void AddGroupKey(FlatBufferBuilder builder, StringOffset groupKeyOffset)
		{
			builder.AddOffset(0, groupKeyOffset.Value, 0);
		}

		// Token: 0x0603173D RID: 202557 RVA: 0x006B4422 File Offset: 0x006B2622
		public static void AddHideConfigType(FlatBufferBuilder builder, THideGroupConfig hideConfigType)
		{
			builder.AddByte(1, (byte)hideConfigType, 0);
		}

		// Token: 0x0603173E RID: 202558 RVA: 0x006B442D File Offset: 0x006B262D
		public static void AddHideConfig(FlatBufferBuilder builder, int hideConfigOffset)
		{
			builder.AddOffset(2, hideConfigOffset, 0);
		}

		// Token: 0x0603173F RID: 202559 RVA: 0x006B4438 File Offset: 0x006B2638
		public static void AddIsHidePasserByNpc(FlatBufferBuilder builder, bool isHidePasserByNpc)
		{
			builder.AddBool(3, isHidePasserByNpc, false);
		}

		// Token: 0x06031740 RID: 202560 RVA: 0x006B4443 File Offset: 0x006B2643
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06031741 RID: 202561 RVA: 0x006B444E File Offset: 0x006B264E
		public static Offset<IHideGroup> EndIHideGroup(FlatBufferBuilder builder)
		{
			return new Offset<IHideGroup>(builder.EndTable());
		}

		// Token: 0x06031742 RID: 202562 RVA: 0x006B445C File Offset: 0x006B265C
		public IHideGroupT UnPack()
		{
			IHideGroupT hideGroupT = new IHideGroupT();
			this.UnPackTo(hideGroupT);
			return hideGroupT;
		}

		// Token: 0x06031743 RID: 202563 RVA: 0x006B4478 File Offset: 0x006B2678
		public void UnPackTo(IHideGroupT _o)
		{
			_o.GroupKey = this.GroupKey;
			_o.HideConfig = new THideGroupConfigUnion();
			_o.HideConfig.Type = this.HideConfigType;
			switch (this.HideConfigType)
			{
			case THideGroupConfig.IHideSpecifyDataLayers:
				_o.HideConfig.Value = ((this.HideConfig<IHideSpecifyDataLayers>() != null) ? this.HideConfig<IHideSpecifyDataLayers>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideSpecifyEntityGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideSpecifyEntityGroup>() != null) ? this.HideConfig<IHideSpecifyEntityGroup>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideSpecifyLevelPlayGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideSpecifyLevelPlayGroup>() != null) ? this.HideConfig<IHideSpecifyLevelPlayGroup>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideWorldEntityAndLevelPlayGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideWorldEntityAndLevelPlayGroup>() != null) ? this.HideConfig<IHideWorldEntityAndLevelPlayGroup>().Value.UnPack() : null);
				break;
			case THideGroupConfig.IHideWorldMonsterAndMonsterTreasureGroup:
				_o.HideConfig.Value = ((this.HideConfig<IHideWorldMonsterAndMonsterTreasureGroup>() != null) ? this.HideConfig<IHideWorldMonsterAndMonsterTreasureGroup>().Value.UnPack() : null);
				break;
			}
			_o.IsHidePasserByNpc = this.IsHidePasserByNpc;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031744 RID: 202564 RVA: 0x006B460C File Offset: 0x006B280C
		public static Offset<IHideGroup> Pack(FlatBufferBuilder builder, IHideGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideGroup>);
			}
			StringOffset groupKeyOffset = (_o.GroupKey == null) ? default(StringOffset) : builder.CreateString(_o.GroupKey);
			THideGroupConfig hideConfig_type = (_o.HideConfig == null) ? THideGroupConfig.NONE : _o.HideConfig.Type;
			int hideConfigOffset = (_o.HideConfig == null) ? 0 : THideGroupConfigUnion.Pack(builder, _o.HideConfig);
			return IHideGroup.CreateIHideGroup(builder, groupKeyOffset, hideConfig_type, hideConfigOffset, _o.IsHidePasserByNpc, _o.NullMask);
		}

		// Token: 0x04011EB3 RID: 73395
		private Table __p;
	}
}
