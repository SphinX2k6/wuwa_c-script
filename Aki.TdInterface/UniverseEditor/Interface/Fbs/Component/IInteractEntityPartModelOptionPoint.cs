using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544C RID: 21580
	public struct IInteractEntityPartModelOptionPoint : IFlatbufferObject
	{
		// Token: 0x17009EE2 RID: 40674
		// (get) Token: 0x060237D9 RID: 145369 RVA: 0x004E93B0 File Offset: 0x004E75B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060237DA RID: 145370 RVA: 0x004E93BD File Offset: 0x004E75BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060237DB RID: 145371 RVA: 0x004E93C4 File Offset: 0x004E75C4
		public static IInteractEntityPartModelOptionPoint GetRootAsIInteractEntityPartModelOptionPoint(ByteBuffer _bb)
		{
			return IInteractEntityPartModelOptionPoint.GetRootAsIInteractEntityPartModelOptionPoint(_bb, default(IInteractEntityPartModelOptionPoint));
		}

		// Token: 0x060237DC RID: 145372 RVA: 0x004E93E0 File Offset: 0x004E75E0
		public static IInteractEntityPartModelOptionPoint GetRootAsIInteractEntityPartModelOptionPoint(ByteBuffer _bb, IInteractEntityPartModelOptionPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060237DD RID: 145373 RVA: 0x004E93FD File Offset: 0x004E75FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060237DE RID: 145374 RVA: 0x004E940C File Offset: 0x004E760C
		public IInteractEntityPartModelOptionPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EE3 RID: 40675
		// (get) Token: 0x060237DF RID: 145375 RVA: 0x004E941C File Offset: 0x004E761C
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

		// Token: 0x060237E0 RID: 145376 RVA: 0x004E9453 File Offset: 0x004E7653
		public Span<byte> GetUiStyleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060237E1 RID: 145377 RVA: 0x004E9462 File Offset: 0x004E7662
		public byte[] GetUiStyleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009EE4 RID: 40676
		// (get) Token: 0x060237E2 RID: 145378 RVA: 0x004E9470 File Offset: 0x004E7670
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

		// Token: 0x060237E3 RID: 145379 RVA: 0x004E94A7 File Offset: 0x004E76A7
		public Span<byte> GetBindNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060237E4 RID: 145380 RVA: 0x004E94B6 File Offset: 0x004E76B6
		public byte[] GetBindNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060237E5 RID: 145381 RVA: 0x004E94C4 File Offset: 0x004E76C4
		public static Offset<IInteractEntityPartModelOptionPoint> CreateIInteractEntityPartModelOptionPoint(FlatBufferBuilder builder, StringOffset UiStyleOffset = default(StringOffset), StringOffset BindNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartModelOptionPoint.AddBindName(builder, BindNameOffset);
			IInteractEntityPartModelOptionPoint.AddUiStyle(builder, UiStyleOffset);
			return IInteractEntityPartModelOptionPoint.EndIInteractEntityPartModelOptionPoint(builder);
		}

		// Token: 0x060237E6 RID: 145382 RVA: 0x004E94E1 File Offset: 0x004E76E1
		public static void StartIInteractEntityPartModelOptionPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060237E7 RID: 145383 RVA: 0x004E94EA File Offset: 0x004E76EA
		public static void AddUiStyle(FlatBufferBuilder builder, StringOffset uiStyleOffset)
		{
			builder.AddOffset(0, uiStyleOffset.Value, 0);
		}

		// Token: 0x060237E8 RID: 145384 RVA: 0x004E94FA File Offset: 0x004E76FA
		public static void AddBindName(FlatBufferBuilder builder, StringOffset bindNameOffset)
		{
			builder.AddOffset(1, bindNameOffset.Value, 0);
		}

		// Token: 0x060237E9 RID: 145385 RVA: 0x004E950A File Offset: 0x004E770A
		public static Offset<IInteractEntityPartModelOptionPoint> EndIInteractEntityPartModelOptionPoint(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartModelOptionPoint>(builder.EndTable());
		}

		// Token: 0x060237EA RID: 145386 RVA: 0x004E9518 File Offset: 0x004E7718
		public IInteractEntityPartModelOptionPointT UnPack()
		{
			IInteractEntityPartModelOptionPointT interactEntityPartModelOptionPointT = new IInteractEntityPartModelOptionPointT();
			this.UnPackTo(interactEntityPartModelOptionPointT);
			return interactEntityPartModelOptionPointT;
		}

		// Token: 0x060237EB RID: 145387 RVA: 0x004E9533 File Offset: 0x004E7733
		public void UnPackTo(IInteractEntityPartModelOptionPointT _o)
		{
			_o.UiStyle = this.UiStyle;
			_o.BindName = this.BindName;
		}

		// Token: 0x060237EC RID: 145388 RVA: 0x004E9550 File Offset: 0x004E7750
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

		// Token: 0x0400E6C1 RID: 59073
		private Table __p;
	}
}
