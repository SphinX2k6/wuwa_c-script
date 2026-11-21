using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB3 RID: 24243
	public struct ISceneBulletGroup : IFlatbufferObject
	{
		// Token: 0x1700B318 RID: 45848
		// (get) Token: 0x060289EC RID: 166380 RVA: 0x0058DB87 File Offset: 0x0058BD87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060289ED RID: 166381 RVA: 0x0058DB94 File Offset: 0x0058BD94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060289EE RID: 166382 RVA: 0x0058DB9C File Offset: 0x0058BD9C
		public static ISceneBulletGroup GetRootAsISceneBulletGroup(ByteBuffer _bb)
		{
			return ISceneBulletGroup.GetRootAsISceneBulletGroup(_bb, default(ISceneBulletGroup));
		}

		// Token: 0x060289EF RID: 166383 RVA: 0x0058DBB8 File Offset: 0x0058BDB8
		public static ISceneBulletGroup GetRootAsISceneBulletGroup(ByteBuffer _bb, ISceneBulletGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060289F0 RID: 166384 RVA: 0x0058DBD5 File Offset: 0x0058BDD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060289F1 RID: 166385 RVA: 0x0058DBE4 File Offset: 0x0058BDE4
		public ISceneBulletGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B319 RID: 45849
		// (get) Token: 0x060289F2 RID: 166386 RVA: 0x0058DBF4 File Offset: 0x0058BDF4
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

		// Token: 0x060289F3 RID: 166387 RVA: 0x0058DC2B File Offset: 0x0058BE2B
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060289F4 RID: 166388 RVA: 0x0058DC3A File Offset: 0x0058BE3A
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B31A RID: 45850
		// (get) Token: 0x060289F5 RID: 166389 RVA: 0x0058DC48 File Offset: 0x0058BE48
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

		// Token: 0x1700B31B RID: 45851
		// (get) Token: 0x060289F6 RID: 166390 RVA: 0x0058DC88 File Offset: 0x0058BE88
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

		// Token: 0x1700B31C RID: 45852
		// (get) Token: 0x060289F7 RID: 166391 RVA: 0x0058DCE8 File Offset: 0x0058BEE8
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

		// Token: 0x1700B31D RID: 45853
		// (get) Token: 0x060289F8 RID: 166392 RVA: 0x0058DD48 File Offset: 0x0058BF48
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

		// Token: 0x060289F9 RID: 166393 RVA: 0x0058DDA6 File Offset: 0x0058BFA6
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

		// Token: 0x060289FA RID: 166394 RVA: 0x0058DDDA File Offset: 0x0058BFDA
		public static void StartISceneBulletGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060289FB RID: 166395 RVA: 0x0058DDE3 File Offset: 0x0058BFE3
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x060289FC RID: 166396 RVA: 0x0058DDF3 File Offset: 0x0058BFF3
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x060289FD RID: 166397 RVA: 0x0058DDFF File Offset: 0x0058BFFF
		public static void AddRange(FlatBufferBuilder builder, Offset<IVectorInfo> rangeOffset)
		{
			builder.AddOffset(2, rangeOffset.Value, 0);
		}

		// Token: 0x060289FE RID: 166398 RVA: 0x0058DE0F File Offset: 0x0058C00F
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(3, offsetOffset.Value, 0);
		}

		// Token: 0x060289FF RID: 166399 RVA: 0x0058DE1F File Offset: 0x0058C01F
		public static void AddCustomBulletLogic(FlatBufferBuilder builder, Offset<ITrafficBulletLogic> customBulletLogicOffset)
		{
			builder.AddOffset(4, customBulletLogicOffset.Value, 0);
		}

		// Token: 0x06028A00 RID: 166400 RVA: 0x0058DE2F File Offset: 0x0058C02F
		public static Offset<ISceneBulletGroup> EndISceneBulletGroup(FlatBufferBuilder builder)
		{
			return new Offset<ISceneBulletGroup>(builder.EndTable());
		}

		// Token: 0x06028A01 RID: 166401 RVA: 0x0058DE3C File Offset: 0x0058C03C
		public ISceneBulletGroupT UnPack()
		{
			ISceneBulletGroupT sceneBulletGroupT = new ISceneBulletGroupT();
			this.UnPackTo(sceneBulletGroupT);
			return sceneBulletGroupT;
		}

		// Token: 0x06028A02 RID: 166402 RVA: 0x0058DE58 File Offset: 0x0058C058
		public void UnPackTo(ISceneBulletGroupT _o)
		{
			_o.EntityState = this.EntityState;
			_o.BulletId = this.BulletId;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.CustomBulletLogic = ((this.CustomBulletLogic != null) ? this.CustomBulletLogic.Value.UnPack() : null);
		}

		// Token: 0x06028A03 RID: 166403 RVA: 0x0058DF0C File Offset: 0x0058C10C
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

		// Token: 0x0400FB01 RID: 64257
		private Table __p;
	}
}
