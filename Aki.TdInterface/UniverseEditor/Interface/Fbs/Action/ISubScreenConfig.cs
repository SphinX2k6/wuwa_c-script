using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007202 RID: 29186
	public struct ISubScreenConfig : IFlatbufferObject
	{
		// Token: 0x1700D8AF RID: 55471
		// (get) Token: 0x06033C3C RID: 212028 RVA: 0x006F7A21 File Offset: 0x006F5C21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C3D RID: 212029 RVA: 0x006F7A2E File Offset: 0x006F5C2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C3E RID: 212030 RVA: 0x006F7A38 File Offset: 0x006F5C38
		public static ISubScreenConfig GetRootAsISubScreenConfig(ByteBuffer _bb)
		{
			return ISubScreenConfig.GetRootAsISubScreenConfig(_bb, default(ISubScreenConfig));
		}

		// Token: 0x06033C3F RID: 212031 RVA: 0x006F7A54 File Offset: 0x006F5C54
		public static ISubScreenConfig GetRootAsISubScreenConfig(ByteBuffer _bb, ISubScreenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C40 RID: 212032 RVA: 0x006F7A71 File Offset: 0x006F5C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C41 RID: 212033 RVA: 0x006F7A80 File Offset: 0x006F5C80
		public ISubScreenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8B0 RID: 55472
		// (get) Token: 0x06033C42 RID: 212034 RVA: 0x006F7A90 File Offset: 0x006F5C90
		public IVector2? Anchor
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D8B1 RID: 55473
		// (get) Token: 0x06033C43 RID: 212035 RVA: 0x006F7AF0 File Offset: 0x006F5CF0
		public IVector2? Size
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D8B2 RID: 55474
		// (get) Token: 0x06033C44 RID: 212036 RVA: 0x006F7B50 File Offset: 0x006F5D50
		public bool IsSeamlessScreen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D8B3 RID: 55475
		// (get) Token: 0x06033C45 RID: 212037 RVA: 0x006F7B90 File Offset: 0x006F5D90
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

		// Token: 0x06033C46 RID: 212038 RVA: 0x006F7BCD File Offset: 0x006F5DCD
		public static Offset<ISubScreenConfig> CreateISubScreenConfig(FlatBufferBuilder builder, Offset<IVector2> AnchorOffset = default(Offset<IVector2>), Offset<IVector2> SizeOffset = default(Offset<IVector2>), bool IsSeamlessScreen = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISubScreenConfig.AddSize(builder, SizeOffset);
			ISubScreenConfig.AddAnchor(builder, AnchorOffset);
			ISubScreenConfig.AddNullMask(builder, NullMask);
			ISubScreenConfig.AddIsSeamlessScreen(builder, IsSeamlessScreen);
			return ISubScreenConfig.EndISubScreenConfig(builder);
		}

		// Token: 0x06033C47 RID: 212039 RVA: 0x006F7BF9 File Offset: 0x006F5DF9
		public static void StartISubScreenConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033C48 RID: 212040 RVA: 0x006F7C02 File Offset: 0x006F5E02
		public static void AddAnchor(FlatBufferBuilder builder, Offset<IVector2> anchorOffset)
		{
			builder.AddOffset(0, anchorOffset.Value, 0);
		}

		// Token: 0x06033C49 RID: 212041 RVA: 0x006F7C12 File Offset: 0x006F5E12
		public static void AddSize(FlatBufferBuilder builder, Offset<IVector2> sizeOffset)
		{
			builder.AddOffset(1, sizeOffset.Value, 0);
		}

		// Token: 0x06033C4A RID: 212042 RVA: 0x006F7C22 File Offset: 0x006F5E22
		public static void AddIsSeamlessScreen(FlatBufferBuilder builder, bool isSeamlessScreen)
		{
			builder.AddBool(2, isSeamlessScreen, false);
		}

		// Token: 0x06033C4B RID: 212043 RVA: 0x006F7C2D File Offset: 0x006F5E2D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06033C4C RID: 212044 RVA: 0x006F7C38 File Offset: 0x006F5E38
		public static Offset<ISubScreenConfig> EndISubScreenConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenConfig>(builder.EndTable());
		}

		// Token: 0x06033C4D RID: 212045 RVA: 0x006F7C48 File Offset: 0x006F5E48
		public ISubScreenConfigT UnPack()
		{
			ISubScreenConfigT subScreenConfigT = new ISubScreenConfigT();
			this.UnPackTo(subScreenConfigT);
			return subScreenConfigT;
		}

		// Token: 0x06033C4E RID: 212046 RVA: 0x006F7C64 File Offset: 0x006F5E64
		public void UnPackTo(ISubScreenConfigT _o)
		{
			_o.Anchor = ((this.Anchor != null) ? this.Anchor.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.IsSeamlessScreen = this.IsSeamlessScreen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033C4F RID: 212047 RVA: 0x006F7CE8 File Offset: 0x006F5EE8
		public static Offset<ISubScreenConfig> Pack(FlatBufferBuilder builder, ISubScreenConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenConfig>);
			}
			Offset<IVector2> anchorOffset = (_o.Anchor == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Anchor);
			Offset<IVector2> sizeOffset = (_o.Size == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Size);
			return ISubScreenConfig.CreateISubScreenConfig(builder, anchorOffset, sizeOffset, _o.IsSeamlessScreen, _o.NullMask);
		}

		// Token: 0x04011CE6 RID: 72934
		private Table __p;
	}
}
