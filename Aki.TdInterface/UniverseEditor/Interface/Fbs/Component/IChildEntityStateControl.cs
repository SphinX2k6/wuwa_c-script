using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F9A RID: 20378
	public struct IChildEntityStateControl : IFlatbufferObject
	{
		// Token: 0x17009379 RID: 37753
		// (get) Token: 0x0602066B RID: 132715 RVA: 0x004820BC File Offset: 0x004802BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602066C RID: 132716 RVA: 0x004820C9 File Offset: 0x004802C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602066D RID: 132717 RVA: 0x004820D0 File Offset: 0x004802D0
		public static IChildEntityStateControl GetRootAsIChildEntityStateControl(ByteBuffer _bb)
		{
			return IChildEntityStateControl.GetRootAsIChildEntityStateControl(_bb, default(IChildEntityStateControl));
		}

		// Token: 0x0602066E RID: 132718 RVA: 0x004820EC File Offset: 0x004802EC
		public static IChildEntityStateControl GetRootAsIChildEntityStateControl(ByteBuffer _bb, IChildEntityStateControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602066F RID: 132719 RVA: 0x00482109 File Offset: 0x00480309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020670 RID: 132720 RVA: 0x00482118 File Offset: 0x00480318
		public IChildEntityStateControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700937A RID: 37754
		// (get) Token: 0x06020671 RID: 132721 RVA: 0x00482128 File Offset: 0x00480328
		public ETemplateEntityGroupType GroupType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETemplateEntityGroupType.None;
				}
				return (ETemplateEntityGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700937B RID: 37755
		// (get) Token: 0x06020672 RID: 132722 RVA: 0x00482164 File Offset: 0x00480364
		public string InitState
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

		// Token: 0x06020673 RID: 132723 RVA: 0x0048219B File Offset: 0x0048039B
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020674 RID: 132724 RVA: 0x004821AA File Offset: 0x004803AA
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06020675 RID: 132725 RVA: 0x004821B8 File Offset: 0x004803B8
		public IChildStateChangedConfig? OnChildStateChangedConfigs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IChildStateChangedConfig?(default(IChildStateChangedConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700937C RID: 37756
		// (get) Token: 0x06020676 RID: 132726 RVA: 0x00482218 File Offset: 0x00480418
		public int OnChildStateChangedConfigsLength
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

		// Token: 0x1700937D RID: 37757
		// (get) Token: 0x06020677 RID: 132727 RVA: 0x00482244 File Offset: 0x00480444
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

		// Token: 0x06020678 RID: 132728 RVA: 0x00482281 File Offset: 0x00480481
		public static Offset<IChildEntityStateControl> CreateIChildEntityStateControl(FlatBufferBuilder builder, ETemplateEntityGroupType GroupType = ETemplateEntityGroupType.None, StringOffset InitStateOffset = default(StringOffset), VectorOffset OnChildStateChangedConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IChildEntityStateControl.AddOnChildStateChangedConfigs(builder, OnChildStateChangedConfigsOffset);
			IChildEntityStateControl.AddInitState(builder, InitStateOffset);
			IChildEntityStateControl.AddNullMask(builder, NullMask);
			IChildEntityStateControl.AddGroupType(builder, GroupType);
			return IChildEntityStateControl.EndIChildEntityStateControl(builder);
		}

		// Token: 0x06020679 RID: 132729 RVA: 0x004822AD File Offset: 0x004804AD
		public static void StartIChildEntityStateControl(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602067A RID: 132730 RVA: 0x004822B6 File Offset: 0x004804B6
		public static void AddGroupType(FlatBufferBuilder builder, ETemplateEntityGroupType groupType)
		{
			builder.AddByte(0, (byte)groupType, 0);
		}

		// Token: 0x0602067B RID: 132731 RVA: 0x004822C1 File Offset: 0x004804C1
		public static void AddInitState(FlatBufferBuilder builder, StringOffset initStateOffset)
		{
			builder.AddOffset(1, initStateOffset.Value, 0);
		}

		// Token: 0x0602067C RID: 132732 RVA: 0x004822D1 File Offset: 0x004804D1
		public static void AddOnChildStateChangedConfigs(FlatBufferBuilder builder, VectorOffset onChildStateChangedConfigsOffset)
		{
			builder.AddOffset(2, onChildStateChangedConfigsOffset.Value, 0);
		}

		// Token: 0x0602067D RID: 132733 RVA: 0x004822E4 File Offset: 0x004804E4
		public static VectorOffset CreateOnChildStateChangedConfigsVector(FlatBufferBuilder builder, Offset<IChildStateChangedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602067E RID: 132734 RVA: 0x00482324 File Offset: 0x00480524
		public static VectorOffset CreateOnChildStateChangedConfigsVectorBlock(FlatBufferBuilder builder, Offset<IChildStateChangedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IChildStateChangedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602067F RID: 132735 RVA: 0x0048233E File Offset: 0x0048053E
		public static VectorOffset CreateOnChildStateChangedConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IChildStateChangedConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IChildStateChangedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020680 RID: 132736 RVA: 0x0048235C File Offset: 0x0048055C
		public static VectorOffset CreateOnChildStateChangedConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IChildStateChangedConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020681 RID: 132737 RVA: 0x00482375 File Offset: 0x00480575
		public static void StartOnChildStateChangedConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020682 RID: 132738 RVA: 0x00482380 File Offset: 0x00480580
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020683 RID: 132739 RVA: 0x0048238B File Offset: 0x0048058B
		public static Offset<IChildEntityStateControl> EndIChildEntityStateControl(FlatBufferBuilder builder)
		{
			return new Offset<IChildEntityStateControl>(builder.EndTable());
		}

		// Token: 0x06020684 RID: 132740 RVA: 0x00482398 File Offset: 0x00480598
		public IChildEntityStateControlT UnPack()
		{
			IChildEntityStateControlT childEntityStateControlT = new IChildEntityStateControlT();
			this.UnPackTo(childEntityStateControlT);
			return childEntityStateControlT;
		}

		// Token: 0x06020685 RID: 132741 RVA: 0x004823B4 File Offset: 0x004805B4
		public void UnPackTo(IChildEntityStateControlT _o)
		{
			_o.GroupType = this.GroupType;
			_o.InitState = this.InitState;
			_o.OnChildStateChangedConfigs = new List<IChildStateChangedConfigT>();
			for (int i = 0; i < this.OnChildStateChangedConfigsLength; i++)
			{
				_o.OnChildStateChangedConfigs.Add((this.OnChildStateChangedConfigs(i) != null) ? this.OnChildStateChangedConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020686 RID: 132742 RVA: 0x00482438 File Offset: 0x00480638
		public static Offset<IChildEntityStateControl> Pack(FlatBufferBuilder builder, IChildEntityStateControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildEntityStateControl>);
			}
			StringOffset initStateOffset = (_o.InitState == null) ? default(StringOffset) : builder.CreateString(_o.InitState);
			VectorOffset onChildStateChangedConfigsOffset = default(VectorOffset);
			if (_o.OnChildStateChangedConfigs != null)
			{
				Offset<IChildStateChangedConfig>[] array = new Offset<IChildStateChangedConfig>[_o.OnChildStateChangedConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IChildStateChangedConfig.Pack(builder, _o.OnChildStateChangedConfigs[i]);
				}
				onChildStateChangedConfigsOffset = IChildEntityStateControl.CreateOnChildStateChangedConfigsVector(builder, array);
			}
			return IChildEntityStateControl.CreateIChildEntityStateControl(builder, _o.GroupType, initStateOffset, onChildStateChangedConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400DE62 RID: 56930
		private Table __p;
	}
}
