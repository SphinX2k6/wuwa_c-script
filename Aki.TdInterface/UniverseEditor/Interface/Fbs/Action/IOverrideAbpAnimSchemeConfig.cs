using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B8 RID: 29624
	public struct IOverrideAbpAnimSchemeConfig : IFlatbufferObject
	{
		// Token: 0x1700D99F RID: 55711
		// (get) Token: 0x06033D00 RID: 212224 RVA: 0x006FD283 File Offset: 0x006FB483
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D01 RID: 212225 RVA: 0x006FD290 File Offset: 0x006FB490
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D02 RID: 212226 RVA: 0x006FD298 File Offset: 0x006FB498
		public static IOverrideAbpAnimSchemeConfig GetRootAsIOverrideAbpAnimSchemeConfig(ByteBuffer _bb)
		{
			return IOverrideAbpAnimSchemeConfig.GetRootAsIOverrideAbpAnimSchemeConfig(_bb, default(IOverrideAbpAnimSchemeConfig));
		}

		// Token: 0x06033D03 RID: 212227 RVA: 0x006FD2B4 File Offset: 0x006FB4B4
		public static IOverrideAbpAnimSchemeConfig GetRootAsIOverrideAbpAnimSchemeConfig(ByteBuffer _bb, IOverrideAbpAnimSchemeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D04 RID: 212228 RVA: 0x006FD2D1 File Offset: 0x006FB4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D05 RID: 212229 RVA: 0x006FD2E0 File Offset: 0x006FB4E0
		public IOverrideAbpAnimSchemeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9A0 RID: 55712
		// (get) Token: 0x06033D06 RID: 212230 RVA: 0x006FD2F0 File Offset: 0x006FB4F0
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D9A1 RID: 55713
		// (get) Token: 0x06033D07 RID: 212231 RVA: 0x006FD32C File Offset: 0x006FB52C
		public EAbpAnimScheme AnimScheme
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAbpAnimScheme.Default;
				}
				return (EAbpAnimScheme)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033D08 RID: 212232 RVA: 0x006FD368 File Offset: 0x006FB568
		public static Offset<IOverrideAbpAnimSchemeConfig> CreateIOverrideAbpAnimSchemeConfig(FlatBufferBuilder builder, int EntityId = 0, EAbpAnimScheme AnimScheme = EAbpAnimScheme.Default)
		{
			builder.StartTable(2);
			IOverrideAbpAnimSchemeConfig.AddEntityId(builder, EntityId);
			IOverrideAbpAnimSchemeConfig.AddAnimScheme(builder, AnimScheme);
			return IOverrideAbpAnimSchemeConfig.EndIOverrideAbpAnimSchemeConfig(builder);
		}

		// Token: 0x06033D09 RID: 212233 RVA: 0x006FD385 File Offset: 0x006FB585
		public static void StartIOverrideAbpAnimSchemeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033D0A RID: 212234 RVA: 0x006FD38E File Offset: 0x006FB58E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06033D0B RID: 212235 RVA: 0x006FD399 File Offset: 0x006FB599
		public static void AddAnimScheme(FlatBufferBuilder builder, EAbpAnimScheme animScheme)
		{
			builder.AddByte(1, (byte)animScheme, 0);
		}

		// Token: 0x06033D0C RID: 212236 RVA: 0x006FD3A4 File Offset: 0x006FB5A4
		public static Offset<IOverrideAbpAnimSchemeConfig> EndIOverrideAbpAnimSchemeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOverrideAbpAnimSchemeConfig>(builder.EndTable());
		}

		// Token: 0x06033D0D RID: 212237 RVA: 0x006FD3B4 File Offset: 0x006FB5B4
		public IOverrideAbpAnimSchemeConfigT UnPack()
		{
			IOverrideAbpAnimSchemeConfigT overrideAbpAnimSchemeConfigT = new IOverrideAbpAnimSchemeConfigT();
			this.UnPackTo(overrideAbpAnimSchemeConfigT);
			return overrideAbpAnimSchemeConfigT;
		}

		// Token: 0x06033D0E RID: 212238 RVA: 0x006FD3CF File Offset: 0x006FB5CF
		public void UnPackTo(IOverrideAbpAnimSchemeConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.AnimScheme = this.AnimScheme;
		}

		// Token: 0x06033D0F RID: 212239 RVA: 0x006FD3EC File Offset: 0x006FB5EC
		public static Offset<IOverrideAbpAnimSchemeConfig> Pack(FlatBufferBuilder builder, IOverrideAbpAnimSchemeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOverrideAbpAnimSchemeConfig>);
			}
			return IOverrideAbpAnimSchemeConfig.CreateIOverrideAbpAnimSchemeConfig(builder, _o.EntityId, _o.AnimScheme);
		}

		// Token: 0x040124E9 RID: 74985
		private Table __p;
	}
}
