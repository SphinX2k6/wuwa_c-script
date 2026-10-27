using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A6 RID: 22694
	public struct ISceneBulletGroup : IFlatbufferObject
	{
		// Token: 0x1700A9E8 RID: 43496
		// (get) Token: 0x0602648A RID: 156810 RVA: 0x0054703B File Offset: 0x0054523B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602648B RID: 156811 RVA: 0x00547048 File Offset: 0x00545248
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602648C RID: 156812 RVA: 0x00547050 File Offset: 0x00545250
		public static ISceneBulletGroup GetRootAsISceneBulletGroup(ByteBuffer _bb)
		{
			return ISceneBulletGroup.GetRootAsISceneBulletGroup(_bb, default(ISceneBulletGroup));
		}

		// Token: 0x0602648D RID: 156813 RVA: 0x0054706C File Offset: 0x0054526C
		public static ISceneBulletGroup GetRootAsISceneBulletGroup(ByteBuffer _bb, ISceneBulletGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602648E RID: 156814 RVA: 0x00547089 File Offset: 0x00545289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602648F RID: 156815 RVA: 0x00547098 File Offset: 0x00545298
		public ISceneBulletGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9E9 RID: 43497
		// (get) Token: 0x06026490 RID: 156816 RVA: 0x005470A8 File Offset: 0x005452A8
		public string EntityState
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

		// Token: 0x06026491 RID: 156817 RVA: 0x005470DF File Offset: 0x005452DF
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026492 RID: 156818 RVA: 0x005470EE File Offset: 0x005452EE
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A9EA RID: 43498
		// (get) Token: 0x06026493 RID: 156819 RVA: 0x005470FC File Offset: 0x005452FC
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A9EB RID: 43499
		// (get) Token: 0x06026494 RID: 156820 RVA: 0x0054713C File Offset: 0x0054533C
		public IVectorInfo? Range
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A9EC RID: 43500
		// (get) Token: 0x06026495 RID: 156821 RVA: 0x0054719C File Offset: 0x0054539C
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A9ED RID: 43501
		// (get) Token: 0x06026496 RID: 156822 RVA: 0x005471FC File Offset: 0x005453FC
		public ITrafficBulletLogic? CustomBulletLogic
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITrafficBulletLogic?(default(ITrafficBulletLogic).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026497 RID: 156823 RVA: 0x0054725A File Offset: 0x0054545A
		public static Offset<ISceneBulletGroup> CreateISceneBulletGroup(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), long BulletId = 0L, Offset<IVectorInfo> RangeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<ITrafficBulletLogic> CustomBulletLogicOffset = default(Offset<ITrafficBulletLogic>))
		{
			builder.StartTable(5);
			ISceneBulletGroup.AddBulletId(builder, BulletId);
			ISceneBulletGroup.AddCustomBulletLogic(builder, CustomBulletLogicOffset);
			ISceneBulletGroup.AddOffset(builder, OffsetOffset);
			ISceneBulletGroup.AddRange(builder, RangeOffset);
			ISceneBulletGroup.AddEntityState(builder, EntityStateOffset);
			return ISceneBulletGroup.EndISceneBulletGroup(builder);
		}

		// Token: 0x06026498 RID: 156824 RVA: 0x0054728E File Offset: 0x0054548E
		public static void StartISceneBulletGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026499 RID: 156825 RVA: 0x00547297 File Offset: 0x00545497
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x0602649A RID: 156826 RVA: 0x005472A7 File Offset: 0x005454A7
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x0602649B RID: 156827 RVA: 0x005472B3 File Offset: 0x005454B3
		public static void AddRange(FlatBufferBuilder builder, Offset<IVectorInfo> rangeOffset)
		{
			builder.AddOffset(2, rangeOffset.Value, 0);
		}

		// Token: 0x0602649C RID: 156828 RVA: 0x005472C3 File Offset: 0x005454C3
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(3, offsetOffset.Value, 0);
		}

		// Token: 0x0602649D RID: 156829 RVA: 0x005472D3 File Offset: 0x005454D3
		public static void AddCustomBulletLogic(FlatBufferBuilder builder, Offset<ITrafficBulletLogic> customBulletLogicOffset)
		{
			builder.AddOffset(4, customBulletLogicOffset.Value, 0);
		}

		// Token: 0x0602649E RID: 156830 RVA: 0x005472E3 File Offset: 0x005454E3
		public static Offset<ISceneBulletGroup> EndISceneBulletGroup(FlatBufferBuilder builder)
		{
			return new Offset<ISceneBulletGroup>(builder.EndTable());
		}

		// Token: 0x0602649F RID: 156831 RVA: 0x005472F0 File Offset: 0x005454F0
		public ISceneBulletGroupT UnPack()
		{
			ISceneBulletGroupT sceneBulletGroupT = new ISceneBulletGroupT();
			this.UnPackTo(sceneBulletGroupT);
			return sceneBulletGroupT;
		}

		// Token: 0x060264A0 RID: 156832 RVA: 0x0054730C File Offset: 0x0054550C
		public void UnPackTo(ISceneBulletGroupT _o)
		{
			_o.EntityState = this.EntityState;
			_o.BulletId = this.BulletId;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.CustomBulletLogic = ((this.CustomBulletLogic != null) ? this.CustomBulletLogic.Value.UnPack() : null);
		}

		// Token: 0x060264A1 RID: 156833 RVA: 0x005473C0 File Offset: 0x005455C0
		public static Offset<ISceneBulletGroup> Pack(FlatBufferBuilder builder, ISceneBulletGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneBulletGroup>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			Offset<IVectorInfo> rangeOffset = (_o.Range == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Range);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<ITrafficBulletLogic> customBulletLogicOffset = (_o.CustomBulletLogic == null) ? default(Offset<ITrafficBulletLogic>) : ITrafficBulletLogic.Pack(builder, _o.CustomBulletLogic);
			return ISceneBulletGroup.CreateISceneBulletGroup(builder, entityStateOffset, _o.BulletId, rangeOffset, offsetOffset, customBulletLogicOffset);
		}

		// Token: 0x0400EE0E RID: 60942
		private Table __p;
	}
}
