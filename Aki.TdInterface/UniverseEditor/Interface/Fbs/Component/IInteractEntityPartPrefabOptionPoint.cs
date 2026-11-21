using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D8 RID: 23000
	public struct IInteractEntityPartPrefabOptionPoint : IFlatbufferObject
	{
		// Token: 0x1700A726 RID: 42790
		// (get) Token: 0x060258C7 RID: 153799 RVA: 0x00526A34 File Offset: 0x00524C34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060258C8 RID: 153800 RVA: 0x00526A41 File Offset: 0x00524C41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060258C9 RID: 153801 RVA: 0x00526A48 File Offset: 0x00524C48
		public static IInteractEntityPartPrefabOptionPoint GetRootAsIInteractEntityPartPrefabOptionPoint(ByteBuffer _bb)
		{
			return IInteractEntityPartPrefabOptionPoint.GetRootAsIInteractEntityPartPrefabOptionPoint(_bb, default(IInteractEntityPartPrefabOptionPoint));
		}

		// Token: 0x060258CA RID: 153802 RVA: 0x00526A64 File Offset: 0x00524C64
		public static IInteractEntityPartPrefabOptionPoint GetRootAsIInteractEntityPartPrefabOptionPoint(ByteBuffer _bb, IInteractEntityPartPrefabOptionPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060258CB RID: 153803 RVA: 0x00526A81 File Offset: 0x00524C81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060258CC RID: 153804 RVA: 0x00526A90 File Offset: 0x00524C90
		public IInteractEntityPartPrefabOptionPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A727 RID: 42791
		// (get) Token: 0x060258CD RID: 153805 RVA: 0x00526AA0 File Offset: 0x00524CA0
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

		// Token: 0x060258CE RID: 153806 RVA: 0x00526AD7 File Offset: 0x00524CD7
		public Span<byte> GetUiStyleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060258CF RID: 153807 RVA: 0x00526AE6 File Offset: 0x00524CE6
		public byte[] GetUiStyleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A728 RID: 42792
		// (get) Token: 0x060258D0 RID: 153808 RVA: 0x00526AF4 File Offset: 0x00524CF4
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

		// Token: 0x060258D1 RID: 153809 RVA: 0x00526B2B File Offset: 0x00524D2B
		public Span<byte> GetBindNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060258D2 RID: 153810 RVA: 0x00526B3A File Offset: 0x00524D3A
		public byte[] GetBindNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060258D3 RID: 153811 RVA: 0x00526B48 File Offset: 0x00524D48
		public static Offset<IInteractEntityPartPrefabOptionPoint> CreateIInteractEntityPartPrefabOptionPoint(FlatBufferBuilder builder, StringOffset UiStyleOffset = default(StringOffset), StringOffset BindNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartPrefabOptionPoint.AddBindName(builder, BindNameOffset);
			IInteractEntityPartPrefabOptionPoint.AddUiStyle(builder, UiStyleOffset);
			return IInteractEntityPartPrefabOptionPoint.EndIInteractEntityPartPrefabOptionPoint(builder);
		}

		// Token: 0x060258D4 RID: 153812 RVA: 0x00526B65 File Offset: 0x00524D65
		public static void StartIInteractEntityPartPrefabOptionPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060258D5 RID: 153813 RVA: 0x00526B6E File Offset: 0x00524D6E
		public static void AddUiStyle(FlatBufferBuilder builder, StringOffset uiStyleOffset)
		{
			builder.AddOffset(0, uiStyleOffset.Value, 0);
		}

		// Token: 0x060258D6 RID: 153814 RVA: 0x00526B7E File Offset: 0x00524D7E
		public static void AddBindName(FlatBufferBuilder builder, StringOffset bindNameOffset)
		{
			builder.AddOffset(1, bindNameOffset.Value, 0);
		}

		// Token: 0x060258D7 RID: 153815 RVA: 0x00526B8E File Offset: 0x00524D8E
		public static Offset<IInteractEntityPartPrefabOptionPoint> EndIInteractEntityPartPrefabOptionPoint(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartPrefabOptionPoint>(builder.EndTable());
		}

		// Token: 0x060258D8 RID: 153816 RVA: 0x00526B9C File Offset: 0x00524D9C
		public IInteractEntityPartPrefabOptionPointT UnPack()
		{
			IInteractEntityPartPrefabOptionPointT interactEntityPartPrefabOptionPointT = new IInteractEntityPartPrefabOptionPointT();
			this.UnPackTo(interactEntityPartPrefabOptionPointT);
			return interactEntityPartPrefabOptionPointT;
		}

		// Token: 0x060258D9 RID: 153817 RVA: 0x00526BB7 File Offset: 0x00524DB7
		public void UnPackTo(IInteractEntityPartPrefabOptionPointT _o)
		{
			_o.UiStyle = this.UiStyle;
			_o.BindName = this.BindName;
		}

		// Token: 0x060258DA RID: 153818 RVA: 0x00526BD4 File Offset: 0x00524DD4
		public static Offset<IInteractEntityPartPrefabOptionPoint> Pack(FlatBufferBuilder builder, IInteractEntityPartPrefabOptionPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartPrefabOptionPoint>);
			}
			StringOffset uiStyleOffset = (_o.UiStyle == null) ? default(StringOffset) : builder.CreateString(_o.UiStyle);
			StringOffset bindNameOffset = (_o.BindName == null) ? default(StringOffset) : builder.CreateString(_o.BindName);
			return IInteractEntityPartPrefabOptionPoint.CreateIInteractEntityPartPrefabOptionPoint(builder, uiStyleOffset, bindNameOffset);
		}

		// Token: 0x0400F2F8 RID: 62200
		private Table __p;
	}
}
