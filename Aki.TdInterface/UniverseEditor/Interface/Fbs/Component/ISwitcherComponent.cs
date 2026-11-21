using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200601D RID: 24605
	public struct ISwitcherComponent : IFlatbufferObject
	{
		// Token: 0x1700B675 RID: 46709
		// (get) Token: 0x060297AF RID: 169903 RVA: 0x005A93B2 File Offset: 0x005A75B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060297B0 RID: 169904 RVA: 0x005A93BF File Offset: 0x005A75BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060297B1 RID: 169905 RVA: 0x005A93C8 File Offset: 0x005A75C8
		public static ISwitcherComponent GetRootAsISwitcherComponent(ByteBuffer _bb)
		{
			return ISwitcherComponent.GetRootAsISwitcherComponent(_bb, default(ISwitcherComponent));
		}

		// Token: 0x060297B2 RID: 169906 RVA: 0x005A93E4 File Offset: 0x005A75E4
		public static ISwitcherComponent GetRootAsISwitcherComponent(ByteBuffer _bb, ISwitcherComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060297B3 RID: 169907 RVA: 0x005A9401 File Offset: 0x005A7601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060297B4 RID: 169908 RVA: 0x005A9410 File Offset: 0x005A7610
		public ISwitcherComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B676 RID: 46710
		// (get) Token: 0x060297B5 RID: 169909 RVA: 0x005A9420 File Offset: 0x005A7620
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B677 RID: 46711
		// (get) Token: 0x060297B6 RID: 169910 RVA: 0x005A9460 File Offset: 0x005A7660
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

		// Token: 0x060297B7 RID: 169911 RVA: 0x005A9497 File Offset: 0x005A7697
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060297B8 RID: 169912 RVA: 0x005A94A6 File Offset: 0x005A76A6
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B678 RID: 46712
		// (get) Token: 0x060297B9 RID: 169913 RVA: 0x005A94B4 File Offset: 0x005A76B4
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

		// Token: 0x060297BA RID: 169914 RVA: 0x005A94EB File Offset: 0x005A76EB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060297BB RID: 169915 RVA: 0x005A94FA File Offset: 0x005A76FA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060297BC RID: 169916 RVA: 0x005A9508 File Offset: 0x005A7708
		public IActionInfo? OnActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B679 RID: 46713
		// (get) Token: 0x060297BD RID: 169917 RVA: 0x005A956C File Offset: 0x005A776C
		public int OnActionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060297BE RID: 169918 RVA: 0x005A9598 File Offset: 0x005A7798
		public IActionInfo? OffActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B67A RID: 46714
		// (get) Token: 0x060297BF RID: 169919 RVA: 0x005A95FC File Offset: 0x005A77FC
		public int OffActionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B67B RID: 46715
		// (get) Token: 0x060297C0 RID: 169920 RVA: 0x005A9628 File Offset: 0x005A7828
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060297C1 RID: 169921 RVA: 0x005A9665 File Offset: 0x005A7865
		public static Offset<ISwitcherComponent> CreateISwitcherComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ContentOffset = default(StringOffset), StringOffset IconOffset = default(StringOffset), VectorOffset OnActionsOffset = default(VectorOffset), VectorOffset OffActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISwitcherComponent.AddOffActions(builder, OffActionsOffset);
			ISwitcherComponent.AddOnActions(builder, OnActionsOffset);
			ISwitcherComponent.AddIcon(builder, IconOffset);
			ISwitcherComponent.AddContent(builder, ContentOffset);
			ISwitcherComponent.AddNullMask(builder, NullMask);
			ISwitcherComponent.AddDisabled(builder, Disabled);
			return ISwitcherComponent.EndISwitcherComponent(builder);
		}

		// Token: 0x060297C2 RID: 169922 RVA: 0x005A96A1 File Offset: 0x005A78A1
		public static void StartISwitcherComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060297C3 RID: 169923 RVA: 0x005A96AA File Offset: 0x005A78AA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060297C4 RID: 169924 RVA: 0x005A96B5 File Offset: 0x005A78B5
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x060297C5 RID: 169925 RVA: 0x005A96C5 File Offset: 0x005A78C5
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(2, iconOffset.Value, 0);
		}

		// Token: 0x060297C6 RID: 169926 RVA: 0x005A96D5 File Offset: 0x005A78D5
		public static void AddOnActions(FlatBufferBuilder builder, VectorOffset onActionsOffset)
		{
			builder.AddOffset(3, onActionsOffset.Value, 0);
		}

		// Token: 0x060297C7 RID: 169927 RVA: 0x005A96E8 File Offset: 0x005A78E8
		public static VectorOffset CreateOnActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297C8 RID: 169928 RVA: 0x005A9728 File Offset: 0x005A7928
		public static VectorOffset CreateOnActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297C9 RID: 169929 RVA: 0x005A9742 File Offset: 0x005A7942
		public static VectorOffset CreateOnActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297CA RID: 169930 RVA: 0x005A9760 File Offset: 0x005A7960
		public static VectorOffset CreateOnActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297CB RID: 169931 RVA: 0x005A9779 File Offset: 0x005A7979
		public static void StartOnActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297CC RID: 169932 RVA: 0x005A9784 File Offset: 0x005A7984
		public static void AddOffActions(FlatBufferBuilder builder, VectorOffset offActionsOffset)
		{
			builder.AddOffset(4, offActionsOffset.Value, 0);
		}

		// Token: 0x060297CD RID: 169933 RVA: 0x005A9794 File Offset: 0x005A7994
		public static VectorOffset CreateOffActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297CE RID: 169934 RVA: 0x005A97D4 File Offset: 0x005A79D4
		public static VectorOffset CreateOffActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297CF RID: 169935 RVA: 0x005A97EE File Offset: 0x005A79EE
		public static VectorOffset CreateOffActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297D0 RID: 169936 RVA: 0x005A980C File Offset: 0x005A7A0C
		public static VectorOffset CreateOffActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297D1 RID: 169937 RVA: 0x005A9825 File Offset: 0x005A7A25
		public static void StartOffActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297D2 RID: 169938 RVA: 0x005A9830 File Offset: 0x005A7A30
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060297D3 RID: 169939 RVA: 0x005A983B File Offset: 0x005A7A3B
		public static Offset<ISwitcherComponent> EndISwitcherComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISwitcherComponent>(builder.EndTable());
		}

		// Token: 0x060297D4 RID: 169940 RVA: 0x005A9848 File Offset: 0x005A7A48
		public ISwitcherComponentT UnPack()
		{
			ISwitcherComponentT switcherComponentT = new ISwitcherComponentT();
			this.UnPackTo(switcherComponentT);
			return switcherComponentT;
		}

		// Token: 0x060297D5 RID: 169941 RVA: 0x005A9864 File Offset: 0x005A7A64
		public void UnPackTo(ISwitcherComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Content = this.Content;
			_o.Icon = this.Icon;
			_o.OnActions = new List<IActionInfoT>();
			for (int i = 0; i < this.OnActionsLength; i++)
			{
				_o.OnActions.Add((this.OnActions(i) != null) ? this.OnActions(i).Value.UnPack() : null);
			}
			_o.OffActions = new List<IActionInfoT>();
			for (int j = 0; j < this.OffActionsLength; j++)
			{
				_o.OffActions.Add((this.OffActions(j) != null) ? this.OffActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060297D6 RID: 169942 RVA: 0x005A9948 File Offset: 0x005A7B48
		public static Offset<ISwitcherComponent> Pack(FlatBufferBuilder builder, ISwitcherComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitcherComponent>);
			}
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			VectorOffset onActionsOffset = default(VectorOffset);
			if (_o.OnActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.OnActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.OnActions[i]);
				}
				onActionsOffset = ISwitcherComponent.CreateOnActionsVector(builder, array);
			}
			VectorOffset offActionsOffset = default(VectorOffset);
			if (_o.OffActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.OffActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.OffActions[j]);
				}
				offActionsOffset = ISwitcherComponent.CreateOffActionsVector(builder, array2);
			}
			return ISwitcherComponent.CreateISwitcherComponent(builder, _o.Disabled, contentOffset, iconOffset, onActionsOffset, offActionsOffset, _o.NullMask);
		}

		// Token: 0x0400FD4E RID: 64846
		private Table __p;
	}
}
