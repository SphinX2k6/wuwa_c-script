using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A32 RID: 23090
	public struct IJigsawItem : IFlatbufferObject
	{
		// Token: 0x1700A7DE RID: 42974
		// (get) Token: 0x06025BC0 RID: 154560 RVA: 0x0052C35D File Offset: 0x0052A55D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025BC1 RID: 154561 RVA: 0x0052C36A File Offset: 0x0052A56A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025BC2 RID: 154562 RVA: 0x0052C374 File Offset: 0x0052A574
		public static IJigsawItem GetRootAsIJigsawItem(ByteBuffer _bb)
		{
			return IJigsawItem.GetRootAsIJigsawItem(_bb, default(IJigsawItem));
		}

		// Token: 0x06025BC3 RID: 154563 RVA: 0x0052C390 File Offset: 0x0052A590
		public static IJigsawItem GetRootAsIJigsawItem(ByteBuffer _bb, IJigsawItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025BC4 RID: 154564 RVA: 0x0052C3AD File Offset: 0x0052A5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025BC5 RID: 154565 RVA: 0x0052C3BC File Offset: 0x0052A5BC
		public IJigsawItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7DF RID: 42975
		// (get) Token: 0x06025BC6 RID: 154566 RVA: 0x0052C3CC File Offset: 0x0052A5CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7E0 RID: 42976
		// (get) Token: 0x06025BC7 RID: 154567 RVA: 0x0052C40C File Offset: 0x0052A60C
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

		// Token: 0x06025BC8 RID: 154568 RVA: 0x0052C448 File Offset: 0x0052A648
		public TTable? FillCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025BC9 RID: 154569 RVA: 0x0052C48C File Offset: 0x0052A68C
		public IDirectionFill FillCfgAsIDirectionFill()
		{
			return this.FillCfg<IDirectionFill>().Value;
		}

		// Token: 0x06025BCA RID: 154570 RVA: 0x0052C4A8 File Offset: 0x0052A6A8
		public IFixedFill FillCfgAsIFixedFill()
		{
			return this.FillCfg<IFixedFill>().Value;
		}

		// Token: 0x1700A7E1 RID: 42977
		// (get) Token: 0x06025BCB RID: 154571 RVA: 0x0052C4C4 File Offset: 0x0052A6C4
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

		// Token: 0x06025BCC RID: 154572 RVA: 0x0052C501 File Offset: 0x0052A701
		public static Offset<IJigsawItem> CreateIJigsawItem(FlatBufferBuilder builder, bool Disabled = false, TFillConfig FillCfg_type = TFillConfig.NONE, int FillCfgOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IJigsawItem.AddFillCfg(builder, FillCfgOffset);
			IJigsawItem.AddNullMask(builder, NullMask);
			IJigsawItem.AddFillCfgType(builder, FillCfg_type);
			IJigsawItem.AddDisabled(builder, Disabled);
			return IJigsawItem.EndIJigsawItem(builder);
		}

		// Token: 0x06025BCD RID: 154573 RVA: 0x0052C52D File Offset: 0x0052A72D
		public static void StartIJigsawItem(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025BCE RID: 154574 RVA: 0x0052C536 File Offset: 0x0052A736
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025BCF RID: 154575 RVA: 0x0052C541 File Offset: 0x0052A741
		public static void AddFillCfgType(FlatBufferBuilder builder, TFillConfig fillCfgType)
		{
			builder.AddByte(1, (byte)fillCfgType, 0);
		}

		// Token: 0x06025BD0 RID: 154576 RVA: 0x0052C54C File Offset: 0x0052A74C
		public static void AddFillCfg(FlatBufferBuilder builder, int fillCfgOffset)
		{
			builder.AddOffset(2, fillCfgOffset, 0);
		}

		// Token: 0x06025BD1 RID: 154577 RVA: 0x0052C557 File Offset: 0x0052A757
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025BD2 RID: 154578 RVA: 0x0052C562 File Offset: 0x0052A762
		public static Offset<IJigsawItem> EndIJigsawItem(FlatBufferBuilder builder)
		{
			return new Offset<IJigsawItem>(builder.EndTable());
		}

		// Token: 0x06025BD3 RID: 154579 RVA: 0x0052C570 File Offset: 0x0052A770
		public IJigsawItemT UnPack()
		{
			IJigsawItemT jigsawItemT = new IJigsawItemT();
			this.UnPackTo(jigsawItemT);
			return jigsawItemT;
		}

		// Token: 0x06025BD4 RID: 154580 RVA: 0x0052C58C File Offset: 0x0052A78C
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

		// Token: 0x06025BD5 RID: 154581 RVA: 0x0052C64C File Offset: 0x0052A84C
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

		// Token: 0x0400F386 RID: 62342
		private Table __p;
	}
}
