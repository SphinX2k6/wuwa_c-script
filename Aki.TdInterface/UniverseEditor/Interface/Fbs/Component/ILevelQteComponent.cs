using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A71 RID: 23153
	public struct ILevelQteComponent : IFlatbufferObject
	{
		// Token: 0x1700A895 RID: 43157
		// (get) Token: 0x06025E99 RID: 155289 RVA: 0x005329D3 File Offset: 0x00530BD3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E9A RID: 155290 RVA: 0x005329E0 File Offset: 0x00530BE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E9B RID: 155291 RVA: 0x005329E8 File Offset: 0x00530BE8
		public static ILevelQteComponent GetRootAsILevelQteComponent(ByteBuffer _bb)
		{
			return ILevelQteComponent.GetRootAsILevelQteComponent(_bb, default(ILevelQteComponent));
		}

		// Token: 0x06025E9C RID: 155292 RVA: 0x00532A04 File Offset: 0x00530C04
		public static ILevelQteComponent GetRootAsILevelQteComponent(ByteBuffer _bb, ILevelQteComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E9D RID: 155293 RVA: 0x00532A21 File Offset: 0x00530C21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E9E RID: 155294 RVA: 0x00532A30 File Offset: 0x00530C30
		public ILevelQteComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A896 RID: 43158
		// (get) Token: 0x06025E9F RID: 155295 RVA: 0x00532A40 File Offset: 0x00530C40
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A897 RID: 43159
		// (get) Token: 0x06025EA0 RID: 155296 RVA: 0x00532A80 File Offset: 0x00530C80
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

		// Token: 0x1700A898 RID: 43160
		// (get) Token: 0x06025EA1 RID: 155297 RVA: 0x00532AE0 File Offset: 0x00530CE0
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

		// Token: 0x06025EA2 RID: 155298 RVA: 0x00532B1C File Offset: 0x00530D1C
		public static Offset<ILevelQteComponent> CreateILevelQteComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISingleBtnQte> QteConfigOffset = default(Offset<ISingleBtnQte>), byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelQteComponent.AddQteConfig(builder, QteConfigOffset);
			ILevelQteComponent.AddNullMask(builder, NullMask);
			ILevelQteComponent.AddDisabled(builder, Disabled);
			return ILevelQteComponent.EndILevelQteComponent(builder);
		}

		// Token: 0x06025EA3 RID: 155299 RVA: 0x00532B40 File Offset: 0x00530D40
		public static void StartILevelQteComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025EA4 RID: 155300 RVA: 0x00532B49 File Offset: 0x00530D49
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025EA5 RID: 155301 RVA: 0x00532B54 File Offset: 0x00530D54
		public static void AddQteConfig(FlatBufferBuilder builder, Offset<ISingleBtnQte> qteConfigOffset)
		{
			builder.AddOffset(1, qteConfigOffset.Value, 0);
		}

		// Token: 0x06025EA6 RID: 155302 RVA: 0x00532B64 File Offset: 0x00530D64
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06025EA7 RID: 155303 RVA: 0x00532B6F File Offset: 0x00530D6F
		public static Offset<ILevelQteComponent> EndILevelQteComponent(FlatBufferBuilder builder)
		{
			return new Offset<ILevelQteComponent>(builder.EndTable());
		}

		// Token: 0x06025EA8 RID: 155304 RVA: 0x00532B7C File Offset: 0x00530D7C
		public ILevelQteComponentT UnPack()
		{
			ILevelQteComponentT levelQteComponentT = new ILevelQteComponentT();
			this.UnPackTo(levelQteComponentT);
			return levelQteComponentT;
		}

		// Token: 0x06025EA9 RID: 155305 RVA: 0x00532B98 File Offset: 0x00530D98
		public void UnPackTo(ILevelQteComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.QteConfig = ((this.QteConfig != null) ? this.QteConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025EAA RID: 155306 RVA: 0x00532BEC File Offset: 0x00530DEC
		public static Offset<ILevelQteComponent> Pack(FlatBufferBuilder builder, ILevelQteComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelQteComponent>);
			}
			Offset<ISingleBtnQte> qteConfigOffset = (_o.QteConfig == null) ? default(Offset<ISingleBtnQte>) : ISingleBtnQte.Pack(builder, _o.QteConfig);
			return ILevelQteComponent.CreateILevelQteComponent(builder, _o.Disabled, qteConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F3F6 RID: 62454
		private Table __p;
	}
}
