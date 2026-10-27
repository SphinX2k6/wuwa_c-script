using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006516 RID: 25878
	public struct ICustomShowUi : IFlatbufferObject
	{
		// Token: 0x1700C068 RID: 49256
		// (get) Token: 0x0602CE35 RID: 183861 RVA: 0x0062A33A File Offset: 0x0062853A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE36 RID: 183862 RVA: 0x0062A347 File Offset: 0x00628547
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE37 RID: 183863 RVA: 0x0062A350 File Offset: 0x00628550
		public static ICustomShowUi GetRootAsICustomShowUi(ByteBuffer _bb)
		{
			return ICustomShowUi.GetRootAsICustomShowUi(_bb, default(ICustomShowUi));
		}

		// Token: 0x0602CE38 RID: 183864 RVA: 0x0062A36C File Offset: 0x0062856C
		public static ICustomShowUi GetRootAsICustomShowUi(ByteBuffer _bb, ICustomShowUi obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE39 RID: 183865 RVA: 0x0062A389 File Offset: 0x00628589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE3A RID: 183866 RVA: 0x0062A398 File Offset: 0x00628598
		public ICustomShowUi __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C069 RID: 49257
		// (get) Token: 0x0602CE3B RID: 183867 RVA: 0x0062A3A8 File Offset: 0x006285A8
		public ICustomScreenTextSetting? TextSetting
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICustomScreenTextSetting?(default(ICustomScreenTextSetting).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C06A RID: 49258
		// (get) Token: 0x0602CE3C RID: 183868 RVA: 0x0062A408 File Offset: 0x00628608
		public bool IsHideCircle
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C06B RID: 49259
		// (get) Token: 0x0602CE3D RID: 183869 RVA: 0x0062A448 File Offset: 0x00628648
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

		// Token: 0x0602CE3E RID: 183870 RVA: 0x0062A484 File Offset: 0x00628684
		public static Offset<ICustomShowUi> CreateICustomShowUi(FlatBufferBuilder builder, Offset<ICustomScreenTextSetting> TextSettingOffset = default(Offset<ICustomScreenTextSetting>), bool IsHideCircle = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICustomShowUi.AddTextSetting(builder, TextSettingOffset);
			ICustomShowUi.AddNullMask(builder, NullMask);
			ICustomShowUi.AddIsHideCircle(builder, IsHideCircle);
			return ICustomShowUi.EndICustomShowUi(builder);
		}

		// Token: 0x0602CE3F RID: 183871 RVA: 0x0062A4A8 File Offset: 0x006286A8
		public static void StartICustomShowUi(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CE40 RID: 183872 RVA: 0x0062A4B1 File Offset: 0x006286B1
		public static void AddTextSetting(FlatBufferBuilder builder, Offset<ICustomScreenTextSetting> textSettingOffset)
		{
			builder.AddOffset(0, textSettingOffset.Value, 0);
		}

		// Token: 0x0602CE41 RID: 183873 RVA: 0x0062A4C1 File Offset: 0x006286C1
		public static void AddIsHideCircle(FlatBufferBuilder builder, bool isHideCircle)
		{
			builder.AddBool(1, isHideCircle, false);
		}

		// Token: 0x0602CE42 RID: 183874 RVA: 0x0062A4CC File Offset: 0x006286CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CE43 RID: 183875 RVA: 0x0062A4D7 File Offset: 0x006286D7
		public static Offset<ICustomShowUi> EndICustomShowUi(FlatBufferBuilder builder)
		{
			return new Offset<ICustomShowUi>(builder.EndTable());
		}

		// Token: 0x0602CE44 RID: 183876 RVA: 0x0062A4E4 File Offset: 0x006286E4
		public ICustomShowUiT UnPack()
		{
			ICustomShowUiT customShowUiT = new ICustomShowUiT();
			this.UnPackTo(customShowUiT);
			return customShowUiT;
		}

		// Token: 0x0602CE45 RID: 183877 RVA: 0x0062A500 File Offset: 0x00628700
		public void UnPackTo(ICustomShowUiT _o)
		{
			_o.TextSetting = ((this.TextSetting != null) ? this.TextSetting.Value.UnPack() : null);
			_o.IsHideCircle = this.IsHideCircle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CE46 RID: 183878 RVA: 0x0062A554 File Offset: 0x00628754
		public static Offset<ICustomShowUi> Pack(FlatBufferBuilder builder, ICustomShowUiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomShowUi>);
			}
			Offset<ICustomScreenTextSetting> textSettingOffset = (_o.TextSetting == null) ? default(Offset<ICustomScreenTextSetting>) : ICustomScreenTextSetting.Pack(builder, _o.TextSetting);
			return ICustomShowUi.CreateICustomShowUi(builder, textSettingOffset, _o.IsHideCircle, _o.NullMask);
		}

		// Token: 0x04010B5F RID: 68447
		private Table __p;
	}
}
