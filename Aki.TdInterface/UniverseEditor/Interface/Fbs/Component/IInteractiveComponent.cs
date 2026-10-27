using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005458 RID: 21592
	public struct IInteractiveComponent : IFlatbufferObject
	{
		// Token: 0x17009EFA RID: 40698
		// (get) Token: 0x06023847 RID: 145479 RVA: 0x004E9F60 File Offset: 0x004E8160
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023848 RID: 145480 RVA: 0x004E9F6D File Offset: 0x004E816D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023849 RID: 145481 RVA: 0x004E9F74 File Offset: 0x004E8174
		public static IInteractiveComponent GetRootAsIInteractiveComponent(ByteBuffer _bb)
		{
			return IInteractiveComponent.GetRootAsIInteractiveComponent(_bb, default(IInteractiveComponent));
		}

		// Token: 0x0602384A RID: 145482 RVA: 0x004E9F90 File Offset: 0x004E8190
		public static IInteractiveComponent GetRootAsIInteractiveComponent(ByteBuffer _bb, IInteractiveComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602384B RID: 145483 RVA: 0x004E9FAD File Offset: 0x004E81AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602384C RID: 145484 RVA: 0x004E9FBC File Offset: 0x004E81BC
		public IInteractiveComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EFB RID: 40699
		// (get) Token: 0x0602384D RID: 145485 RVA: 0x004E9FCC File Offset: 0x004E81CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009EFC RID: 40700
		// (get) Token: 0x0602384E RID: 145486 RVA: 0x004EA00C File Offset: 0x004E820C
		public string Content
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

		// Token: 0x0602384F RID: 145487 RVA: 0x004EA043 File Offset: 0x004E8243
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023850 RID: 145488 RVA: 0x004EA052 File Offset: 0x004E8252
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009EFD RID: 40701
		// (get) Token: 0x06023851 RID: 145489 RVA: 0x004EA060 File Offset: 0x004E8260
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023852 RID: 145490 RVA: 0x004EA097 File Offset: 0x004E8297
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06023853 RID: 145491 RVA: 0x004EA0A6 File Offset: 0x004E82A6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009EFE RID: 40702
		// (get) Token: 0x06023854 RID: 145492 RVA: 0x004EA0B4 File Offset: 0x004E82B4
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

		// Token: 0x06023855 RID: 145493 RVA: 0x004EA0F1 File Offset: 0x004E82F1
		public static Offset<IInteractiveComponent> CreateIInteractiveComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ContentOffset = default(StringOffset), StringOffset IconOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IInteractiveComponent.AddIcon(builder, IconOffset);
			IInteractiveComponent.AddContent(builder, ContentOffset);
			IInteractiveComponent.AddNullMask(builder, NullMask);
			IInteractiveComponent.AddDisabled(builder, Disabled);
			return IInteractiveComponent.EndIInteractiveComponent(builder);
		}

		// Token: 0x06023856 RID: 145494 RVA: 0x004EA11D File Offset: 0x004E831D
		public static void StartIInteractiveComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023857 RID: 145495 RVA: 0x004EA126 File Offset: 0x004E8326
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023858 RID: 145496 RVA: 0x004EA131 File Offset: 0x004E8331
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x06023859 RID: 145497 RVA: 0x004EA141 File Offset: 0x004E8341
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x0602385A RID: 145498 RVA: 0x004EA151 File Offset: 0x004E8351
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602385B RID: 145499 RVA: 0x004EA15C File Offset: 0x004E835C
		public static Offset<IInteractiveComponent> EndIInteractiveComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractiveComponent>(builder.EndTable());
		}

		// Token: 0x0602385C RID: 145500 RVA: 0x004EA16C File Offset: 0x004E836C
		public IInteractiveComponentT UnPack()
		{
			IInteractiveComponentT interactiveComponentT = new IInteractiveComponentT();
			this.UnPackTo(interactiveComponentT);
			return interactiveComponentT;
		}

		// Token: 0x0602385D RID: 145501 RVA: 0x004EA187 File Offset: 0x004E8387
		public void UnPackTo(IInteractiveComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Content = this.Content;
			_o.Icon = this.Icon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602385E RID: 145502 RVA: 0x004EA1BC File Offset: 0x004E83BC
		public static Offset<IInteractiveComponent> Pack(FlatBufferBuilder builder, IInteractiveComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractiveComponent>);
			}
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			return IInteractiveComponent.CreateIInteractiveComponent(builder, _o.Disabled, contentOffset, iconOffset, _o.NullMask);
		}

		// Token: 0x0400E6CF RID: 59087
		private Table __p;
	}
}
