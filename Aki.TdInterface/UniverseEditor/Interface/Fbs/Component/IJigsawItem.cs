using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AC RID: 21676
	public struct IJigsawItem : IFlatbufferObject
	{
		// Token: 0x17009FA4 RID: 40868
		// (get) Token: 0x06023B08 RID: 146184 RVA: 0x004EF2E9 File Offset: 0x004ED4E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B09 RID: 146185 RVA: 0x004EF2F6 File Offset: 0x004ED4F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B0A RID: 146186 RVA: 0x004EF300 File Offset: 0x004ED500
		public static IJigsawItem GetRootAsIJigsawItem(ByteBuffer _bb)
		{
			return IJigsawItem.GetRootAsIJigsawItem(_bb, default(IJigsawItem));
		}

		// Token: 0x06023B0B RID: 146187 RVA: 0x004EF31C File Offset: 0x004ED51C
		public static IJigsawItem GetRootAsIJigsawItem(ByteBuffer _bb, IJigsawItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B0C RID: 146188 RVA: 0x004EF339 File Offset: 0x004ED539
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B0D RID: 146189 RVA: 0x004EF348 File Offset: 0x004ED548
		public IJigsawItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FA5 RID: 40869
		// (get) Token: 0x06023B0E RID: 146190 RVA: 0x004EF358 File Offset: 0x004ED558
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009FA6 RID: 40870
		// (get) Token: 0x06023B0F RID: 146191 RVA: 0x004EF398 File Offset: 0x004ED598
		public TFillConfig FillCfgType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TFillConfig.NONE;
				}
				return (TFillConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023B10 RID: 146192 RVA: 0x004EF3D4 File Offset: 0x004ED5D4
		public TTable? FillCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023B11 RID: 146193 RVA: 0x004EF418 File Offset: 0x004ED618
		public IDirectionFill FillCfgAsIDirectionFill()
		{
			return this.FillCfg<IDirectionFill>().Value;
		}

		// Token: 0x06023B12 RID: 146194 RVA: 0x004EF434 File Offset: 0x004ED634
		public IFixedFill FillCfgAsIFixedFill()
		{
			return this.FillCfg<IFixedFill>().Value;
		}

		// Token: 0x17009FA7 RID: 40871
		// (get) Token: 0x06023B13 RID: 146195 RVA: 0x004EF450 File Offset: 0x004ED650
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023B14 RID: 146196 RVA: 0x004EF48D File Offset: 0x004ED68D
		public static Offset<IJigsawItem> CreateIJigsawItem(FlatBufferBuilder builder, bool Disabled = false, TFillConfig FillCfg_type = TFillConfig.NONE, int FillCfgOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IJigsawItem.AddFillCfg(builder, FillCfgOffset);
			IJigsawItem.AddNullMask(builder, NullMask);
			IJigsawItem.AddFillCfgType(builder, FillCfg_type);
			IJigsawItem.AddDisabled(builder, Disabled);
			return IJigsawItem.EndIJigsawItem(builder);
		}

		// Token: 0x06023B15 RID: 146197 RVA: 0x004EF4B9 File Offset: 0x004ED6B9
		public static void StartIJigsawItem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023B16 RID: 146198 RVA: 0x004EF4C2 File Offset: 0x004ED6C2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023B17 RID: 146199 RVA: 0x004EF4CD File Offset: 0x004ED6CD
		public static void AddFillCfgType(FlatBufferBuilder builder, TFillConfig fillCfgType)
		{
			builder.AddByte(1, (byte)fillCfgType, 0);
		}

		// Token: 0x06023B18 RID: 146200 RVA: 0x004EF4D8 File Offset: 0x004ED6D8
		public static void AddFillCfg(FlatBufferBuilder builder, int fillCfgOffset)
		{
			builder.AddOffset(2, fillCfgOffset, 0);
		}

		// Token: 0x06023B19 RID: 146201 RVA: 0x004EF4E3 File Offset: 0x004ED6E3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023B1A RID: 146202 RVA: 0x004EF4EE File Offset: 0x004ED6EE
		public static Offset<IJigsawItem> EndIJigsawItem(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawItem>(builder.EndTable());
		}

		// Token: 0x06023B1B RID: 146203 RVA: 0x004EF4FC File Offset: 0x004ED6FC
		public IJigsawItemT UnPack()
		{
			IJigsawItemT jigsawItemT = new IJigsawItemT();
			this.UnPackTo(jigsawItemT);
			return jigsawItemT;
		}

		// Token: 0x06023B1C RID: 146204 RVA: 0x004EF518 File Offset: 0x004ED718
		public void UnPackTo(IJigsawItemT _o)
		{
			_o.Disabled = this.Disabled;
			_o.FillCfg = new TFillConfigUnion();
			_o.FillCfg.Type = this.FillCfgType;
			TFillConfig fillCfgType = this.FillCfgType;
			if (fillCfgType != TFillConfig.IDirectionFill)
			{
				if (fillCfgType == TFillConfig.IFixedFill)
				{
					_o.FillCfg.Value = ((this.FillCfg<IFixedFill>() != null) ? this.FillCfg<IFixedFill>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.FillCfg.Value = ((this.FillCfg<IDirectionFill>() != null) ? this.FillCfg<IDirectionFill>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023B1D RID: 146205 RVA: 0x004EF5D8 File Offset: 0x004ED7D8
		public static Offset<IJigsawItem> Pack(FlatBufferBuilder builder, IJigsawItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IJigsawItem>);
			}
			TFillConfig fillCfg_type = (_o.FillCfg == null) ? TFillConfig.NONE : _o.FillCfg.Type;
			int fillCfgOffset = (_o.FillCfg == null) ? 0 : TFillConfigUnion.Pack(builder, _o.FillCfg);
			return IJigsawItem.CreateIJigsawItem(builder, _o.Disabled, fillCfg_type, fillCfgOffset, _o.NullMask);
		}

		// Token: 0x0400E755 RID: 59221
		private Table __p;
	}
}
