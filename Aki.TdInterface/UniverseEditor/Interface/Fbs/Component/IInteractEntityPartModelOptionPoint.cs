using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D2 RID: 22994
	public struct IInteractEntityPartModelOptionPoint : IFlatbufferObject
	{
		// Token: 0x1700A71C RID: 42780
		// (get) Token: 0x06025891 RID: 153745 RVA: 0x00526424 File Offset: 0x00524624
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025892 RID: 153746 RVA: 0x00526431 File Offset: 0x00524631
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025893 RID: 153747 RVA: 0x00526438 File Offset: 0x00524638
		public static IInteractEntityPartModelOptionPoint GetRootAsIInteractEntityPartModelOptionPoint(ByteBuffer _bb)
		{
			return IInteractEntityPartModelOptionPoint.GetRootAsIInteractEntityPartModelOptionPoint(_bb, default(IInteractEntityPartModelOptionPoint));
		}

		// Token: 0x06025894 RID: 153748 RVA: 0x00526454 File Offset: 0x00524654
		public static IInteractEntityPartModelOptionPoint GetRootAsIInteractEntityPartModelOptionPoint(ByteBuffer _bb, IInteractEntityPartModelOptionPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025895 RID: 153749 RVA: 0x00526471 File Offset: 0x00524671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025896 RID: 153750 RVA: 0x00526480 File Offset: 0x00524680
		public IInteractEntityPartModelOptionPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A71D RID: 42781
		// (get) Token: 0x06025897 RID: 153751 RVA: 0x00526490 File Offset: 0x00524690
		public string UiStyle
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

		// Token: 0x06025898 RID: 153752 RVA: 0x005264C7 File Offset: 0x005246C7
		public Span<byte> GetUiStyleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025899 RID: 153753 RVA: 0x005264D6 File Offset: 0x005246D6
		public byte[] GetUiStyleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A71E RID: 42782
		// (get) Token: 0x0602589A RID: 153754 RVA: 0x005264E4 File Offset: 0x005246E4
		public string BindName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602589B RID: 153755 RVA: 0x0052651B File Offset: 0x0052471B
		public Span<byte> GetBindNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602589C RID: 153756 RVA: 0x0052652A File Offset: 0x0052472A
		public byte[] GetBindNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602589D RID: 153757 RVA: 0x00526538 File Offset: 0x00524738
		public static Offset<IInteractEntityPartModelOptionPoint> CreateIInteractEntityPartModelOptionPoint(FlatBufferBuilder builder, StringOffset UiStyleOffset = default(StringOffset), StringOffset BindNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartModelOptionPoint.AddBindName(builder, BindNameOffset);
			IInteractEntityPartModelOptionPoint.AddUiStyle(builder, UiStyleOffset);
			return IInteractEntityPartModelOptionPoint.EndIInteractEntityPartModelOptionPoint(builder);
		}

		// Token: 0x0602589E RID: 153758 RVA: 0x00526555 File Offset: 0x00524755
		public static void StartIInteractEntityPartModelOptionPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602589F RID: 153759 RVA: 0x0052655E File Offset: 0x0052475E
		public static void AddUiStyle(FlatBufferBuilder builder, StringOffset uiStyleOffset)
		{
			builder.AddOffset(0, uiStyleOffset.Value, 0);
		}

		// Token: 0x060258A0 RID: 153760 RVA: 0x0052656E File Offset: 0x0052476E
		public static void AddBindName(FlatBufferBuilder builder, StringOffset bindNameOffset)
		{
			builder.AddOffset(1, bindNameOffset.Value, 0);
		}

		// Token: 0x060258A1 RID: 153761 RVA: 0x0052657E File Offset: 0x0052477E
		public static Offset<IInteractEntityPartModelOptionPoint> EndIInteractEntityPartModelOptionPoint(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartModelOptionPoint>(builder.EndTable());
		}

		// Token: 0x060258A2 RID: 153762 RVA: 0x0052658C File Offset: 0x0052478C
		public IInteractEntityPartModelOptionPointT UnPack()
		{
			IInteractEntityPartModelOptionPointT interactEntityPartModelOptionPointT = new IInteractEntityPartModelOptionPointT();
			this.UnPackTo(interactEntityPartModelOptionPointT);
			return interactEntityPartModelOptionPointT;
		}

		// Token: 0x060258A3 RID: 153763 RVA: 0x005265A7 File Offset: 0x005247A7
		public void UnPackTo(IInteractEntityPartModelOptionPointT _o)
		{
			_o.UiStyle = this.UiStyle;
			_o.BindName = this.BindName;
		}

		// Token: 0x060258A4 RID: 153764 RVA: 0x005265C4 File Offset: 0x005247C4
		public static Offset<IInteractEntityPartModelOptionPoint> Pack(FlatBufferBuilder builder, IInteractEntityPartModelOptionPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartModelOptionPoint>);
			}
			StringOffset uiStyleOffset = (_o.UiStyle == null) ? default(StringOffset) : builder.CreateString(_o.UiStyle);
			StringOffset bindNameOffset = (_o.BindName == null) ? default(StringOffset) : builder.CreateString(_o.BindName);
			return IInteractEntityPartModelOptionPoint.CreateIInteractEntityPartModelOptionPoint(builder, uiStyleOffset, bindNameOffset);
		}

		// Token: 0x0400F2F2 RID: 62194
		private Table __p;
	}
}
