using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007283 RID: 29315
	public struct ISystemOption : IFlatbufferObject
	{
		// Token: 0x1700D979 RID: 55673
		// (get) Token: 0x06034025 RID: 213029 RVA: 0x006FE452 File Offset: 0x006FC652
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034026 RID: 213030 RVA: 0x006FE45F File Offset: 0x006FC65F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034027 RID: 213031 RVA: 0x006FE468 File Offset: 0x006FC668
		public static ISystemOption GetRootAsISystemOption(ByteBuffer _bb)
		{
			return ISystemOption.GetRootAsISystemOption(_bb, default(ISystemOption));
		}

		// Token: 0x06034028 RID: 213032 RVA: 0x006FE484 File Offset: 0x006FC684
		public static ISystemOption GetRootAsISystemOption(ByteBuffer _bb, ISystemOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034029 RID: 213033 RVA: 0x006FE4A1 File Offset: 0x006FC6A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603402A RID: 213034 RVA: 0x006FE4B0 File Offset: 0x006FC6B0
		public ISystemOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D97A RID: 55674
		// (get) Token: 0x0603402B RID: 213035 RVA: 0x006FE4C0 File Offset: 0x006FC6C0
		public int OptionId
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

		// Token: 0x0603402C RID: 213036 RVA: 0x006FE4FC File Offset: 0x006FC6FC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D97B RID: 55675
		// (get) Token: 0x0603402D RID: 213037 RVA: 0x006FE55C File Offset: 0x006FC75C
		public int ActionsLength
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

		// Token: 0x1700D97C RID: 55676
		// (get) Token: 0x0603402E RID: 213038 RVA: 0x006FE588 File Offset: 0x006FC788
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603402F RID: 213039 RVA: 0x006FE5C4 File Offset: 0x006FC7C4
		public static Offset<ISystemOption> CreateISystemOption(FlatBufferBuilder builder, int OptionId = 0, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISystemOption.AddActions(builder, ActionsOffset);
			ISystemOption.AddOptionId(builder, OptionId);
			ISystemOption.AddNullMask(builder, NullMask);
			return ISystemOption.EndISystemOption(builder);
		}

		// Token: 0x06034030 RID: 213040 RVA: 0x006FE5E8 File Offset: 0x006FC7E8
		public static void StartISystemOption(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034031 RID: 213041 RVA: 0x006FE5F1 File Offset: 0x006FC7F1
		public static void AddOptionId(FlatBufferBuilder builder, int optionId)
		{
			builder.AddInt(0, optionId, 0);
		}

		// Token: 0x06034032 RID: 213042 RVA: 0x006FE5FC File Offset: 0x006FC7FC
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06034033 RID: 213043 RVA: 0x006FE60C File Offset: 0x006FC80C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06034034 RID: 213044 RVA: 0x006FE64C File Offset: 0x006FC84C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034035 RID: 213045 RVA: 0x006FE666 File Offset: 0x006FC866
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06034036 RID: 213046 RVA: 0x006FE684 File Offset: 0x006FC884
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034037 RID: 213047 RVA: 0x006FE69D File Offset: 0x006FC89D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034038 RID: 213048 RVA: 0x006FE6A8 File Offset: 0x006FC8A8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034039 RID: 213049 RVA: 0x006FE6B3 File Offset: 0x006FC8B3
		public static Offset<ISystemOption> EndISystemOption(FlatBufferBuilder builder)
		{
			return new Offset<ISystemOption>(builder.EndTable());
		}

		// Token: 0x0603403A RID: 213050 RVA: 0x006FE6C0 File Offset: 0x006FC8C0
		public ISystemOptionT UnPack()
		{
			ISystemOptionT systemOptionT = new ISystemOptionT();
			this.UnPackTo(systemOptionT);
			return systemOptionT;
		}

		// Token: 0x0603403B RID: 213051 RVA: 0x006FE6DC File Offset: 0x006FC8DC
		public void UnPackTo(ISystemOptionT _o)
		{
			_o.OptionId = this.OptionId;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603403C RID: 213052 RVA: 0x006FE754 File Offset: 0x006FC954
		public static Offset<ISystemOption> Pack(FlatBufferBuilder builder, ISystemOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemOption>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ISystemOption.CreateActionsVector(builder, array);
			}
			return ISystemOption.CreateISystemOption(builder, _o.OptionId, actionsOffset, _o.NullMask);
		}

		// Token: 0x04011D8B RID: 73099
		private Table __p;
	}
}
