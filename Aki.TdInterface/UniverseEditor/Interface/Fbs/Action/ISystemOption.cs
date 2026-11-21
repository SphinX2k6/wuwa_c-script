using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A58 RID: 31320
	public struct ISystemOption : IFlatbufferObject
	{
		// Token: 0x1700E572 RID: 58738
		// (get) Token: 0x06037327 RID: 226087 RVA: 0x0075F7B2 File Offset: 0x0075D9B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037328 RID: 226088 RVA: 0x0075F7BF File Offset: 0x0075D9BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037329 RID: 226089 RVA: 0x0075F7C8 File Offset: 0x0075D9C8
		public static ISystemOption GetRootAsISystemOption(ByteBuffer _bb)
		{
			return ISystemOption.GetRootAsISystemOption(_bb, default(ISystemOption));
		}

		// Token: 0x0603732A RID: 226090 RVA: 0x0075F7E4 File Offset: 0x0075D9E4
		public static ISystemOption GetRootAsISystemOption(ByteBuffer _bb, ISystemOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603732B RID: 226091 RVA: 0x0075F801 File Offset: 0x0075DA01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603732C RID: 226092 RVA: 0x0075F810 File Offset: 0x0075DA10
		public ISystemOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E573 RID: 58739
		// (get) Token: 0x0603732D RID: 226093 RVA: 0x0075F820 File Offset: 0x0075DA20
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

		// Token: 0x0603732E RID: 226094 RVA: 0x0075F85C File Offset: 0x0075DA5C
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E574 RID: 58740
		// (get) Token: 0x0603732F RID: 226095 RVA: 0x0075F8BC File Offset: 0x0075DABC
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

		// Token: 0x1700E575 RID: 58741
		// (get) Token: 0x06037330 RID: 226096 RVA: 0x0075F8E8 File Offset: 0x0075DAE8
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

		// Token: 0x06037331 RID: 226097 RVA: 0x0075F924 File Offset: 0x0075DB24
		public static Offset<ISystemOption> CreateISystemOption(FlatBufferBuilder builder, int OptionId = 0, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			ISystemOption.AddActions(builder, ActionsOffset);
			ISystemOption.AddOptionId(builder, OptionId);
			ISystemOption.AddNullMask(builder, NullMask);
			return ISystemOption.EndISystemOption(builder);
		}

		// Token: 0x06037332 RID: 226098 RVA: 0x0075F948 File Offset: 0x0075DB48
		public static void StartISystemOption(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06037333 RID: 226099 RVA: 0x0075F951 File Offset: 0x0075DB51
		public static void AddOptionId(FlatBufferBuilder builder, int optionId)
		{
			builder.AddInt(0, optionId, 0);
		}

		// Token: 0x06037334 RID: 226100 RVA: 0x0075F95C File Offset: 0x0075DB5C
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06037335 RID: 226101 RVA: 0x0075F96C File Offset: 0x0075DB6C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06037336 RID: 226102 RVA: 0x0075F9AC File Offset: 0x0075DBAC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06037337 RID: 226103 RVA: 0x0075F9C6 File Offset: 0x0075DBC6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06037338 RID: 226104 RVA: 0x0075F9E4 File Offset: 0x0075DBE4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06037339 RID: 226105 RVA: 0x0075F9FD File Offset: 0x0075DBFD
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603733A RID: 226106 RVA: 0x0075FA08 File Offset: 0x0075DC08
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603733B RID: 226107 RVA: 0x0075FA13 File Offset: 0x0075DC13
		public static Offset<ISystemOption> EndISystemOption(FlatBufferBuilder builder)
		{
			return new Offset<ISystemOption>(builder.EndTable());
		}

		// Token: 0x0603733C RID: 226108 RVA: 0x0075FA20 File Offset: 0x0075DC20
		public ISystemOptionT UnPack()
		{
			ISystemOptionT systemOptionT = new ISystemOptionT();
			this.UnPackTo(systemOptionT);
			return systemOptionT;
		}

		// Token: 0x0603733D RID: 226109 RVA: 0x0075FA3C File Offset: 0x0075DC3C
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

		// Token: 0x0603733E RID: 226110 RVA: 0x0075FAB4 File Offset: 0x0075DCB4
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

		// Token: 0x04012D8D RID: 77197
		private Table __p;
	}
}
