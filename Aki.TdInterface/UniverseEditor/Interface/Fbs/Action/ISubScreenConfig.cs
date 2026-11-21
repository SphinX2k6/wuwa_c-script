using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079D7 RID: 31191
	public struct ISubScreenConfig : IFlatbufferObject
	{
		// Token: 0x1700E4A8 RID: 58536
		// (get) Token: 0x06036F3E RID: 225086 RVA: 0x00758D81 File Offset: 0x00756F81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F3F RID: 225087 RVA: 0x00758D8E File Offset: 0x00756F8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F40 RID: 225088 RVA: 0x00758D98 File Offset: 0x00756F98
		public static ISubScreenConfig GetRootAsISubScreenConfig(ByteBuffer _bb)
		{
			return ISubScreenConfig.GetRootAsISubScreenConfig(_bb, default(ISubScreenConfig));
		}

		// Token: 0x06036F41 RID: 225089 RVA: 0x00758DB4 File Offset: 0x00756FB4
		public static ISubScreenConfig GetRootAsISubScreenConfig(ByteBuffer _bb, ISubScreenConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F42 RID: 225090 RVA: 0x00758DD1 File Offset: 0x00756FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F43 RID: 225091 RVA: 0x00758DE0 File Offset: 0x00756FE0
		public ISubScreenConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4A9 RID: 58537
		// (get) Token: 0x06036F44 RID: 225092 RVA: 0x00758DF0 File Offset: 0x00756FF0
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

		// Token: 0x1700E4AA RID: 58538
		// (get) Token: 0x06036F45 RID: 225093 RVA: 0x00758E50 File Offset: 0x00757050
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

		// Token: 0x1700E4AB RID: 58539
		// (get) Token: 0x06036F46 RID: 225094 RVA: 0x00758EB0 File Offset: 0x007570B0
		public bool IsSeamlessScreen
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E4AC RID: 58540
		// (get) Token: 0x06036F47 RID: 225095 RVA: 0x00758EF0 File Offset: 0x007570F0
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

		// Token: 0x06036F48 RID: 225096 RVA: 0x00758F2D File Offset: 0x0075712D
		public static Offset<ISubScreenConfig> CreateISubScreenConfig(FlatBufferBuilder builder, Offset<IVector2> AnchorOffset = default(Offset<IVector2>), Offset<IVector2> SizeOffset = default(Offset<IVector2>), bool IsSeamlessScreen = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ISubScreenConfig.AddSize(builder, SizeOffset);
			ISubScreenConfig.AddAnchor(builder, AnchorOffset);
			ISubScreenConfig.AddNullMask(builder, NullMask);
			ISubScreenConfig.AddIsSeamlessScreen(builder, IsSeamlessScreen);
			return ISubScreenConfig.EndISubScreenConfig(builder);
		}

		// Token: 0x06036F49 RID: 225097 RVA: 0x00758F59 File Offset: 0x00757159
		public static void StartISubScreenConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036F4A RID: 225098 RVA: 0x00758F62 File Offset: 0x00757162
		public static void AddAnchor(FlatBufferBuilder builder, Offset<IVector2> anchorOffset)
		{
			builder.AddOffset(0, anchorOffset.Value, 0);
		}

		// Token: 0x06036F4B RID: 225099 RVA: 0x00758F72 File Offset: 0x00757172
		public static void AddSize(FlatBufferBuilder builder, Offset<IVector2> sizeOffset)
		{
			builder.AddOffset(1, sizeOffset.Value, 0);
		}

		// Token: 0x06036F4C RID: 225100 RVA: 0x00758F82 File Offset: 0x00757182
		public static void AddIsSeamlessScreen(FlatBufferBuilder builder, bool isSeamlessScreen)
		{
			builder.AddBool(2, isSeamlessScreen, false);
		}

		// Token: 0x06036F4D RID: 225101 RVA: 0x00758F8D File Offset: 0x0075718D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036F4E RID: 225102 RVA: 0x00758F98 File Offset: 0x00757198
		public static Offset<ISubScreenConfig> EndISubScreenConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenConfig>(builder.EndTable());
		}

		// Token: 0x06036F4F RID: 225103 RVA: 0x00758FA8 File Offset: 0x007571A8
		public ISubScreenConfigT UnPack()
		{
			ISubScreenConfigT subScreenConfigT = new ISubScreenConfigT();
			this.UnPackTo(subScreenConfigT);
			return subScreenConfigT;
		}

		// Token: 0x06036F50 RID: 225104 RVA: 0x00758FC4 File Offset: 0x007571C4
		public void UnPackTo(ISubScreenConfigT _o)
		{
			_o.Anchor = ((this.Anchor != null) ? this.Anchor.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.IsSeamlessScreen = this.IsSeamlessScreen;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036F51 RID: 225105 RVA: 0x00759048 File Offset: 0x00757248
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

		// Token: 0x04012CE8 RID: 77032
		private Table __p;
	}
}
