using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EB RID: 21739
	public struct ILevelQteComponent : IFlatbufferObject
	{
		// Token: 0x1700A05B RID: 41051
		// (get) Token: 0x06023DDF RID: 146911 RVA: 0x004F58AF File Offset: 0x004F3AAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023DE0 RID: 146912 RVA: 0x004F58BC File Offset: 0x004F3ABC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023DE1 RID: 146913 RVA: 0x004F58C4 File Offset: 0x004F3AC4
		public static ILevelQteComponent GetRootAsILevelQteComponent(ByteBuffer _bb)
		{
			return ILevelQteComponent.GetRootAsILevelQteComponent(_bb, default(ILevelQteComponent));
		}

		// Token: 0x06023DE2 RID: 146914 RVA: 0x004F58E0 File Offset: 0x004F3AE0
		public static ILevelQteComponent GetRootAsILevelQteComponent(ByteBuffer _bb, ILevelQteComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023DE3 RID: 146915 RVA: 0x004F58FD File Offset: 0x004F3AFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023DE4 RID: 146916 RVA: 0x004F590C File Offset: 0x004F3B0C
		public ILevelQteComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A05C RID: 41052
		// (get) Token: 0x06023DE5 RID: 146917 RVA: 0x004F591C File Offset: 0x004F3B1C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A05D RID: 41053
		// (get) Token: 0x06023DE6 RID: 146918 RVA: 0x004F595C File Offset: 0x004F3B5C
		public ISingleBtnQte? QteConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISingleBtnQte?(default(ISingleBtnQte).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A05E RID: 41054
		// (get) Token: 0x06023DE7 RID: 146919 RVA: 0x004F59BC File Offset: 0x004F3BBC
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

		// Token: 0x06023DE8 RID: 146920 RVA: 0x004F59F8 File Offset: 0x004F3BF8
		public static Offset<ILevelQteComponent> CreateILevelQteComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISingleBtnQte> QteConfigOffset = default(Offset<ISingleBtnQte>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelQteComponent.AddQteConfig(builder, QteConfigOffset);
			ILevelQteComponent.AddNullMask(builder, NullMask);
			ILevelQteComponent.AddDisabled(builder, Disabled);
			return ILevelQteComponent.EndILevelQteComponent(builder);
		}

		// Token: 0x06023DE9 RID: 146921 RVA: 0x004F5A1C File Offset: 0x004F3C1C
		public static void StartILevelQteComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023DEA RID: 146922 RVA: 0x004F5A25 File Offset: 0x004F3C25
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023DEB RID: 146923 RVA: 0x004F5A30 File Offset: 0x004F3C30
		public static void AddQteConfig(FlatBufferBuilder builder, Offset<ISingleBtnQte> qteConfigOffset)
		{
			builder.AddOffset(1, qteConfigOffset.Value, 0);
		}

		// Token: 0x06023DEC RID: 146924 RVA: 0x004F5A40 File Offset: 0x004F3C40
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023DED RID: 146925 RVA: 0x004F5A4B File Offset: 0x004F3C4B
		public static Offset<ILevelQteComponent> EndILevelQteComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelQteComponent>(builder.EndTable());
		}

		// Token: 0x06023DEE RID: 146926 RVA: 0x004F5A58 File Offset: 0x004F3C58
		public ILevelQteComponentT UnPack()
		{
			ILevelQteComponentT levelQteComponentT = new ILevelQteComponentT();
			this.UnPackTo(levelQteComponentT);
			return levelQteComponentT;
		}

		// Token: 0x06023DEF RID: 146927 RVA: 0x004F5A74 File Offset: 0x004F3C74
		public void UnPackTo(ILevelQteComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.QteConfig = ((this.QteConfig != null) ? this.QteConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023DF0 RID: 146928 RVA: 0x004F5AC8 File Offset: 0x004F3CC8
		public static Offset<ILevelQteComponent> Pack(FlatBufferBuilder builder, ILevelQteComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelQteComponent>);
			}
			Offset<ISingleBtnQte> qteConfigOffset = (_o.QteConfig == null) ? default(Offset<ISingleBtnQte>) : ISingleBtnQte.Pack(builder, _o.QteConfig);
			return ILevelQteComponent.CreateILevelQteComponent(builder, _o.Disabled, qteConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E7C5 RID: 59333
		private Table __p;
	}
}
