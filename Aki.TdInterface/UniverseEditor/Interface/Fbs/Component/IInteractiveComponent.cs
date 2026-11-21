using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059DE RID: 23006
	public struct IInteractiveComponent : IFlatbufferObject
	{
		// Token: 0x1700A734 RID: 42804
		// (get) Token: 0x060258FF RID: 153855 RVA: 0x00526FD4 File Offset: 0x005251D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025900 RID: 153856 RVA: 0x00526FE1 File Offset: 0x005251E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025901 RID: 153857 RVA: 0x00526FE8 File Offset: 0x005251E8
		public static IInteractiveComponent GetRootAsIInteractiveComponent(ByteBuffer _bb)
		{
			return IInteractiveComponent.GetRootAsIInteractiveComponent(_bb, default(IInteractiveComponent));
		}

		// Token: 0x06025902 RID: 153858 RVA: 0x00527004 File Offset: 0x00525204
		public static IInteractiveComponent GetRootAsIInteractiveComponent(ByteBuffer _bb, IInteractiveComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025903 RID: 153859 RVA: 0x00527021 File Offset: 0x00525221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025904 RID: 153860 RVA: 0x00527030 File Offset: 0x00525230
		public IInteractiveComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A735 RID: 42805
		// (get) Token: 0x06025905 RID: 153861 RVA: 0x00527040 File Offset: 0x00525240
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A736 RID: 42806
		// (get) Token: 0x06025906 RID: 153862 RVA: 0x00527080 File Offset: 0x00525280
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

		// Token: 0x06025907 RID: 153863 RVA: 0x005270B7 File Offset: 0x005252B7
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025908 RID: 153864 RVA: 0x005270C6 File Offset: 0x005252C6
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A737 RID: 42807
		// (get) Token: 0x06025909 RID: 153865 RVA: 0x005270D4 File Offset: 0x005252D4
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

		// Token: 0x0602590A RID: 153866 RVA: 0x0052710B File Offset: 0x0052530B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602590B RID: 153867 RVA: 0x0052711A File Offset: 0x0052531A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A738 RID: 42808
		// (get) Token: 0x0602590C RID: 153868 RVA: 0x00527128 File Offset: 0x00525328
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

		// Token: 0x0602590D RID: 153869 RVA: 0x00527165 File Offset: 0x00525365
		public static Offset<IInteractiveComponent> CreateIInteractiveComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ContentOffset = default(StringOffset), StringOffset IconOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IInteractiveComponent.AddIcon(builder, IconOffset);
			IInteractiveComponent.AddContent(builder, ContentOffset);
			IInteractiveComponent.AddNullMask(builder, NullMask);
			IInteractiveComponent.AddDisabled(builder, Disabled);
			return IInteractiveComponent.EndIInteractiveComponent(builder);
		}

		// Token: 0x0602590E RID: 153870 RVA: 0x00527191 File Offset: 0x00525391
		public static void StartIInteractiveComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602590F RID: 153871 RVA: 0x0052719A File Offset: 0x0052539A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025910 RID: 153872 RVA: 0x005271A5 File Offset: 0x005253A5
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x06025911 RID: 153873 RVA: 0x005271B5 File Offset: 0x005253B5
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x06025912 RID: 153874 RVA: 0x005271C5 File Offset: 0x005253C5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06025913 RID: 153875 RVA: 0x005271D0 File Offset: 0x005253D0
		public static Offset<IInteractiveComponent> EndIInteractiveComponent(FlatBufferBuilder builder)
		{
			return new Offset<IInteractiveComponent>(builder.EndTable());
		}

		// Token: 0x06025914 RID: 153876 RVA: 0x005271E0 File Offset: 0x005253E0
		public IInteractiveComponentT UnPack()
		{
			IInteractiveComponentT interactiveComponentT = new IInteractiveComponentT();
			this.UnPackTo(interactiveComponentT);
			return interactiveComponentT;
		}

		// Token: 0x06025915 RID: 153877 RVA: 0x005271FB File Offset: 0x005253FB
		public void UnPackTo(IInteractiveComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Content = this.Content;
			_o.Icon = this.Icon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025916 RID: 153878 RVA: 0x00527230 File Offset: 0x00525430
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

		// Token: 0x0400F300 RID: 62208
		private Table __p;
	}
}
