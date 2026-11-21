using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005586 RID: 21894
	public struct IControlPointEventConfig : IFlatbufferObject
	{
		// Token: 0x17009CC8 RID: 40136
		// (get) Token: 0x06022CEF RID: 142575 RVA: 0x004CB789 File Offset: 0x004C9989
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022CF0 RID: 142576 RVA: 0x004CB796 File Offset: 0x004C9996
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022CF1 RID: 142577 RVA: 0x004CB7A0 File Offset: 0x004C99A0
		public static IControlPointEventConfig GetRootAsIControlPointEventConfig(ByteBuffer _bb)
		{
			return IControlPointEventConfig.GetRootAsIControlPointEventConfig(_bb, default(IControlPointEventConfig));
		}

		// Token: 0x06022CF2 RID: 142578 RVA: 0x004CB7BC File Offset: 0x004C99BC
		public static IControlPointEventConfig GetRootAsIControlPointEventConfig(ByteBuffer _bb, IControlPointEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022CF3 RID: 142579 RVA: 0x004CB7D9 File Offset: 0x004C99D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022CF4 RID: 142580 RVA: 0x004CB7E8 File Offset: 0x004C99E8
		public IControlPointEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CC9 RID: 40137
		// (get) Token: 0x06022CF5 RID: 142581 RVA: 0x004CB7F8 File Offset: 0x004C99F8
		public int Index
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022CF6 RID: 142582 RVA: 0x004CB834 File Offset: 0x004C9A34
		public IActionInfo? LeftInEventActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CCA RID: 40138
		// (get) Token: 0x06022CF7 RID: 142583 RVA: 0x004CB894 File Offset: 0x004C9A94
		public int LeftInEventActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022CF8 RID: 142584 RVA: 0x004CB8C0 File Offset: 0x004C9AC0
		public IActionInfo? LeftOutEventActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CCB RID: 40139
		// (get) Token: 0x06022CF9 RID: 142585 RVA: 0x004CB920 File Offset: 0x004C9B20
		public int LeftOutEventActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022CFA RID: 142586 RVA: 0x004CB94C File Offset: 0x004C9B4C
		public IActionInfo? RightInEventActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CCC RID: 40140
		// (get) Token: 0x06022CFB RID: 142587 RVA: 0x004CB9B0 File Offset: 0x004C9BB0
		public int RightInEventActionsLength
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

		// Token: 0x06022CFC RID: 142588 RVA: 0x004CB9DC File Offset: 0x004C9BDC
		public IActionInfo? RightOutEventActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009CCD RID: 40141
		// (get) Token: 0x06022CFD RID: 142589 RVA: 0x004CBA40 File Offset: 0x004C9C40
		public int RightOutEventActionsLength
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

		// Token: 0x17009CCE RID: 40142
		// (get) Token: 0x06022CFE RID: 142590 RVA: 0x004CBA6C File Offset: 0x004C9C6C
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

		// Token: 0x06022CFF RID: 142591 RVA: 0x004CBAA9 File Offset: 0x004C9CA9
		public static Offset<IControlPointEventConfig> CreateIControlPointEventConfig(FlatBufferBuilder builder, int Index = 0, VectorOffset LeftInEventActionsOffset = default(VectorOffset), VectorOffset LeftOutEventActionsOffset = default(VectorOffset), VectorOffset RightInEventActionsOffset = default(VectorOffset), VectorOffset RightOutEventActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IControlPointEventConfig.AddRightOutEventActions(builder, RightOutEventActionsOffset);
			IControlPointEventConfig.AddRightInEventActions(builder, RightInEventActionsOffset);
			IControlPointEventConfig.AddLeftOutEventActions(builder, LeftOutEventActionsOffset);
			IControlPointEventConfig.AddLeftInEventActions(builder, LeftInEventActionsOffset);
			IControlPointEventConfig.AddIndex(builder, Index);
			IControlPointEventConfig.AddNullMask(builder, NullMask);
			return IControlPointEventConfig.EndIControlPointEventConfig(builder);
		}

		// Token: 0x06022D00 RID: 142592 RVA: 0x004CBAE5 File Offset: 0x004C9CE5
		public static void StartIControlPointEventConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06022D01 RID: 142593 RVA: 0x004CBAEE File Offset: 0x004C9CEE
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x06022D02 RID: 142594 RVA: 0x004CBAF9 File Offset: 0x004C9CF9
		public static void AddLeftInEventActions(FlatBufferBuilder builder, VectorOffset leftInEventActionsOffset)
		{
			builder.AddOffset(1, leftInEventActionsOffset.Value, 0);
		}

		// Token: 0x06022D03 RID: 142595 RVA: 0x004CBB0C File Offset: 0x004C9D0C
		public static VectorOffset CreateLeftInEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D04 RID: 142596 RVA: 0x004CBB4C File Offset: 0x004C9D4C
		public static VectorOffset CreateLeftInEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D05 RID: 142597 RVA: 0x004CBB66 File Offset: 0x004C9D66
		public static VectorOffset CreateLeftInEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D06 RID: 142598 RVA: 0x004CBB84 File Offset: 0x004C9D84
		public static VectorOffset CreateLeftInEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D07 RID: 142599 RVA: 0x004CBB9D File Offset: 0x004C9D9D
		public static void StartLeftInEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D08 RID: 142600 RVA: 0x004CBBA8 File Offset: 0x004C9DA8
		public static void AddLeftOutEventActions(FlatBufferBuilder builder, VectorOffset leftOutEventActionsOffset)
		{
			builder.AddOffset(2, leftOutEventActionsOffset.Value, 0);
		}

		// Token: 0x06022D09 RID: 142601 RVA: 0x004CBBB8 File Offset: 0x004C9DB8
		public static VectorOffset CreateLeftOutEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D0A RID: 142602 RVA: 0x004CBBF8 File Offset: 0x004C9DF8
		public static VectorOffset CreateLeftOutEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D0B RID: 142603 RVA: 0x004CBC12 File Offset: 0x004C9E12
		public static VectorOffset CreateLeftOutEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D0C RID: 142604 RVA: 0x004CBC30 File Offset: 0x004C9E30
		public static VectorOffset CreateLeftOutEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D0D RID: 142605 RVA: 0x004CBC49 File Offset: 0x004C9E49
		public static void StartLeftOutEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D0E RID: 142606 RVA: 0x004CBC54 File Offset: 0x004C9E54
		public static void AddRightInEventActions(FlatBufferBuilder builder, VectorOffset rightInEventActionsOffset)
		{
			builder.AddOffset(3, rightInEventActionsOffset.Value, 0);
		}

		// Token: 0x06022D0F RID: 142607 RVA: 0x004CBC64 File Offset: 0x004C9E64
		public static VectorOffset CreateRightInEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D10 RID: 142608 RVA: 0x004CBCA4 File Offset: 0x004C9EA4
		public static VectorOffset CreateRightInEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D11 RID: 142609 RVA: 0x004CBCBE File Offset: 0x004C9EBE
		public static VectorOffset CreateRightInEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D12 RID: 142610 RVA: 0x004CBCDC File Offset: 0x004C9EDC
		public static VectorOffset CreateRightInEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D13 RID: 142611 RVA: 0x004CBCF5 File Offset: 0x004C9EF5
		public static void StartRightInEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D14 RID: 142612 RVA: 0x004CBD00 File Offset: 0x004C9F00
		public static void AddRightOutEventActions(FlatBufferBuilder builder, VectorOffset rightOutEventActionsOffset)
		{
			builder.AddOffset(4, rightOutEventActionsOffset.Value, 0);
		}

		// Token: 0x06022D15 RID: 142613 RVA: 0x004CBD10 File Offset: 0x004C9F10
		public static VectorOffset CreateRightOutEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022D16 RID: 142614 RVA: 0x004CBD50 File Offset: 0x004C9F50
		public static VectorOffset CreateRightOutEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D17 RID: 142615 RVA: 0x004CBD6A File Offset: 0x004C9F6A
		public static VectorOffset CreateRightOutEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022D18 RID: 142616 RVA: 0x004CBD88 File Offset: 0x004C9F88
		public static VectorOffset CreateRightOutEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022D19 RID: 142617 RVA: 0x004CBDA1 File Offset: 0x004C9FA1
		public static void StartRightOutEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022D1A RID: 142618 RVA: 0x004CBDAC File Offset: 0x004C9FAC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06022D1B RID: 142619 RVA: 0x004CBDB7 File Offset: 0x004C9FB7
		public static Offset<IControlPointEventConfig> EndIControlPointEventConfig(FlatBufferBuilder builder)
		{
			return new Offset<IControlPointEventConfig>(builder.EndTable());
		}

		// Token: 0x06022D1C RID: 142620 RVA: 0x004CBDC4 File Offset: 0x004C9FC4
		public IControlPointEventConfigT UnPack()
		{
			IControlPointEventConfigT controlPointEventConfigT = new IControlPointEventConfigT();
			this.UnPackTo(controlPointEventConfigT);
			return controlPointEventConfigT;
		}

		// Token: 0x06022D1D RID: 142621 RVA: 0x004CBDE0 File Offset: 0x004C9FE0
		public void UnPackTo(IControlPointEventConfigT _o)
		{
			_o.Index = this.Index;
			_o.LeftInEventActions = new List<IActionInfoT>();
			for (int i = 0; i < this.LeftInEventActionsLength; i++)
			{
				_o.LeftInEventActions.Add((this.LeftInEventActions(i) != null) ? this.LeftInEventActions(i).Value.UnPack() : null);
			}
			_o.LeftOutEventActions = new List<IActionInfoT>();
			for (int j = 0; j < this.LeftOutEventActionsLength; j++)
			{
				_o.LeftOutEventActions.Add((this.LeftOutEventActions(j) != null) ? this.LeftOutEventActions(j).Value.UnPack() : null);
			}
			_o.RightInEventActions = new List<IActionInfoT>();
			for (int k = 0; k < this.RightInEventActionsLength; k++)
			{
				_o.RightInEventActions.Add((this.RightInEventActions(k) != null) ? this.RightInEventActions(k).Value.UnPack() : null);
			}
			_o.RightOutEventActions = new List<IActionInfoT>();
			for (int l = 0; l < this.RightOutEventActionsLength; l++)
			{
				_o.RightOutEventActions.Add((this.RightOutEventActions(l) != null) ? this.RightOutEventActions(l).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022D1E RID: 142622 RVA: 0x004CBF5C File Offset: 0x004CA15C
		public static Offset<IControlPointEventConfig> Pack(FlatBufferBuilder builder, IControlPointEventConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlPointEventConfig>);
			}
			VectorOffset leftInEventActionsOffset = default(VectorOffset);
			if (_o.LeftInEventActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.LeftInEventActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.LeftInEventActions[i]);
				}
				leftInEventActionsOffset = IControlPointEventConfig.CreateLeftInEventActionsVector(builder, array);
			}
			VectorOffset leftOutEventActionsOffset = default(VectorOffset);
			if (_o.LeftOutEventActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.LeftOutEventActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.LeftOutEventActions[j]);
				}
				leftOutEventActionsOffset = IControlPointEventConfig.CreateLeftOutEventActionsVector(builder, array2);
			}
			VectorOffset rightInEventActionsOffset = default(VectorOffset);
			if (_o.RightInEventActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.RightInEventActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.RightInEventActions[k]);
				}
				rightInEventActionsOffset = IControlPointEventConfig.CreateRightInEventActionsVector(builder, array3);
			}
			VectorOffset rightOutEventActionsOffset = default(VectorOffset);
			if (_o.RightOutEventActions != null)
			{
				Offset<IActionInfo>[] array4 = new Offset<IActionInfo>[_o.RightOutEventActions.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IActionInfo.Pack(builder, _o.RightOutEventActions[l]);
				}
				rightOutEventActionsOffset = IControlPointEventConfig.CreateRightOutEventActionsVector(builder, array4);
			}
			return IControlPointEventConfig.CreateIControlPointEventConfig(builder, _o.Index, leftInEventActionsOffset, leftOutEventActionsOffset, rightInEventActionsOffset, rightOutEventActionsOffset, _o.NullMask);
		}

		// Token: 0x0400EC05 RID: 60421
		private Table __p;
	}
}
