using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005027 RID: 20519
	public struct IControlPointEventConfig : IFlatbufferObject
	{
		// Token: 0x170094E7 RID: 38119
		// (get) Token: 0x06020DCF RID: 134607 RVA: 0x00491D39 File Offset: 0x0048FF39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020DD0 RID: 134608 RVA: 0x00491D46 File Offset: 0x0048FF46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020DD1 RID: 134609 RVA: 0x00491D50 File Offset: 0x0048FF50
		public static IControlPointEventConfig GetRootAsIControlPointEventConfig(ByteBuffer _bb)
		{
			return IControlPointEventConfig.GetRootAsIControlPointEventConfig(_bb, default(IControlPointEventConfig));
		}

		// Token: 0x06020DD2 RID: 134610 RVA: 0x00491D6C File Offset: 0x0048FF6C
		public static IControlPointEventConfig GetRootAsIControlPointEventConfig(ByteBuffer _bb, IControlPointEventConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020DD3 RID: 134611 RVA: 0x00491D89 File Offset: 0x0048FF89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020DD4 RID: 134612 RVA: 0x00491D98 File Offset: 0x0048FF98
		public IControlPointEventConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094E8 RID: 38120
		// (get) Token: 0x06020DD5 RID: 134613 RVA: 0x00491DA8 File Offset: 0x0048FFA8
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

		// Token: 0x06020DD6 RID: 134614 RVA: 0x00491DE4 File Offset: 0x0048FFE4
		public IActionInfo? LeftInEventActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094E9 RID: 38121
		// (get) Token: 0x06020DD7 RID: 134615 RVA: 0x00491E44 File Offset: 0x00490044
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

		// Token: 0x06020DD8 RID: 134616 RVA: 0x00491E70 File Offset: 0x00490070
		public IActionInfo? LeftOutEventActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094EA RID: 38122
		// (get) Token: 0x06020DD9 RID: 134617 RVA: 0x00491ED0 File Offset: 0x004900D0
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

		// Token: 0x06020DDA RID: 134618 RVA: 0x00491EFC File Offset: 0x004900FC
		public IActionInfo? RightInEventActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094EB RID: 38123
		// (get) Token: 0x06020DDB RID: 134619 RVA: 0x00491F60 File Offset: 0x00490160
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

		// Token: 0x06020DDC RID: 134620 RVA: 0x00491F8C File Offset: 0x0049018C
		public IActionInfo? RightOutEventActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170094EC RID: 38124
		// (get) Token: 0x06020DDD RID: 134621 RVA: 0x00491FF0 File Offset: 0x004901F0
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

		// Token: 0x170094ED RID: 38125
		// (get) Token: 0x06020DDE RID: 134622 RVA: 0x0049201C File Offset: 0x0049021C
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

		// Token: 0x06020DDF RID: 134623 RVA: 0x00492059 File Offset: 0x00490259
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

		// Token: 0x06020DE0 RID: 134624 RVA: 0x00492095 File Offset: 0x00490295
		public static void StartIControlPointEventConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06020DE1 RID: 134625 RVA: 0x0049209E File Offset: 0x0049029E
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x06020DE2 RID: 134626 RVA: 0x004920A9 File Offset: 0x004902A9
		public static void AddLeftInEventActions(FlatBufferBuilder builder, VectorOffset leftInEventActionsOffset)
		{
			builder.AddOffset(1, leftInEventActionsOffset.Value, 0);
		}

		// Token: 0x06020DE3 RID: 134627 RVA: 0x004920BC File Offset: 0x004902BC
		public static VectorOffset CreateLeftInEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020DE4 RID: 134628 RVA: 0x004920FC File Offset: 0x004902FC
		public static VectorOffset CreateLeftInEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DE5 RID: 134629 RVA: 0x00492116 File Offset: 0x00490316
		public static VectorOffset CreateLeftInEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DE6 RID: 134630 RVA: 0x00492134 File Offset: 0x00490334
		public static VectorOffset CreateLeftInEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020DE7 RID: 134631 RVA: 0x0049214D File Offset: 0x0049034D
		public static void StartLeftInEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020DE8 RID: 134632 RVA: 0x00492158 File Offset: 0x00490358
		public static void AddLeftOutEventActions(FlatBufferBuilder builder, VectorOffset leftOutEventActionsOffset)
		{
			builder.AddOffset(2, leftOutEventActionsOffset.Value, 0);
		}

		// Token: 0x06020DE9 RID: 134633 RVA: 0x00492168 File Offset: 0x00490368
		public static VectorOffset CreateLeftOutEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020DEA RID: 134634 RVA: 0x004921A8 File Offset: 0x004903A8
		public static VectorOffset CreateLeftOutEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DEB RID: 134635 RVA: 0x004921C2 File Offset: 0x004903C2
		public static VectorOffset CreateLeftOutEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DEC RID: 134636 RVA: 0x004921E0 File Offset: 0x004903E0
		public static VectorOffset CreateLeftOutEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020DED RID: 134637 RVA: 0x004921F9 File Offset: 0x004903F9
		public static void StartLeftOutEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020DEE RID: 134638 RVA: 0x00492204 File Offset: 0x00490404
		public static void AddRightInEventActions(FlatBufferBuilder builder, VectorOffset rightInEventActionsOffset)
		{
			builder.AddOffset(3, rightInEventActionsOffset.Value, 0);
		}

		// Token: 0x06020DEF RID: 134639 RVA: 0x00492214 File Offset: 0x00490414
		public static VectorOffset CreateRightInEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020DF0 RID: 134640 RVA: 0x00492254 File Offset: 0x00490454
		public static VectorOffset CreateRightInEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DF1 RID: 134641 RVA: 0x0049226E File Offset: 0x0049046E
		public static VectorOffset CreateRightInEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DF2 RID: 134642 RVA: 0x0049228C File Offset: 0x0049048C
		public static VectorOffset CreateRightInEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020DF3 RID: 134643 RVA: 0x004922A5 File Offset: 0x004904A5
		public static void StartRightInEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020DF4 RID: 134644 RVA: 0x004922B0 File Offset: 0x004904B0
		public static void AddRightOutEventActions(FlatBufferBuilder builder, VectorOffset rightOutEventActionsOffset)
		{
			builder.AddOffset(4, rightOutEventActionsOffset.Value, 0);
		}

		// Token: 0x06020DF5 RID: 134645 RVA: 0x004922C0 File Offset: 0x004904C0
		public static VectorOffset CreateRightOutEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020DF6 RID: 134646 RVA: 0x00492300 File Offset: 0x00490500
		public static VectorOffset CreateRightOutEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DF7 RID: 134647 RVA: 0x0049231A File Offset: 0x0049051A
		public static VectorOffset CreateRightOutEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020DF8 RID: 134648 RVA: 0x00492338 File Offset: 0x00490538
		public static VectorOffset CreateRightOutEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020DF9 RID: 134649 RVA: 0x00492351 File Offset: 0x00490551
		public static void StartRightOutEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020DFA RID: 134650 RVA: 0x0049235C File Offset: 0x0049055C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06020DFB RID: 134651 RVA: 0x00492367 File Offset: 0x00490567
		public static Offset<IControlPointEventConfig> EndIControlPointEventConfig(FlatBufferBuilder builder)
		{
			return new Offset<IControlPointEventConfig>(builder.EndTable());
		}

		// Token: 0x06020DFC RID: 134652 RVA: 0x00492374 File Offset: 0x00490574
		public IControlPointEventConfigT UnPack()
		{
			IControlPointEventConfigT controlPointEventConfigT = new IControlPointEventConfigT();
			this.UnPackTo(controlPointEventConfigT);
			return controlPointEventConfigT;
		}

		// Token: 0x06020DFD RID: 134653 RVA: 0x00492390 File Offset: 0x00490590
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

		// Token: 0x06020DFE RID: 134654 RVA: 0x0049250C File Offset: 0x0049070C
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

		// Token: 0x0400E00F RID: 57359
		private Table __p;
	}
}
