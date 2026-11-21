using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AAD RID: 19117
	public struct IExecuteActionList : IFlatbufferObject
	{
		// Token: 0x170085E2 RID: 34274
		// (get) Token: 0x0601CBC8 RID: 117704 RVA: 0x0040CCBD File Offset: 0x0040AEBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CBC9 RID: 117705 RVA: 0x0040CCCA File Offset: 0x0040AECA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBCA RID: 117706 RVA: 0x0040CCD4 File Offset: 0x0040AED4
		public static IExecuteActionList GetRootAsIExecuteActionList(ByteBuffer _bb)
		{
			return IExecuteActionList.GetRootAsIExecuteActionList(_bb, default(IExecuteActionList));
		}

		// Token: 0x0601CBCB RID: 117707 RVA: 0x0040CCF0 File Offset: 0x0040AEF0
		public static IExecuteActionList GetRootAsIExecuteActionList(ByteBuffer _bb, IExecuteActionList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBCC RID: 117708 RVA: 0x0040CD0D File Offset: 0x0040AF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBCD RID: 117709 RVA: 0x0040CD1C File Offset: 0x0040AF1C
		public IExecuteActionList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085E3 RID: 34275
		// (get) Token: 0x0601CBCE RID: 117710 RVA: 0x0040CD2C File Offset: 0x0040AF2C
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CBCF RID: 117711 RVA: 0x0040CD68 File Offset: 0x0040AF68
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170085E4 RID: 34276
		// (get) Token: 0x0601CBD0 RID: 117712 RVA: 0x0040CDC8 File Offset: 0x0040AFC8
		public int ActionListLength
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

		// Token: 0x0601CBD1 RID: 117713 RVA: 0x0040CDF3 File Offset: 0x0040AFF3
		public static Offset<IExecuteActionList> CreateIExecuteActionList(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IExecuteActionList.AddActionList(builder, ActionListOffset);
			IExecuteActionList.AddType(builder, Type);
			return IExecuteActionList.EndIExecuteActionList(builder);
		}

		// Token: 0x0601CBD2 RID: 117714 RVA: 0x0040CE10 File Offset: 0x0040B010
		public static void StartIExecuteActionList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CBD3 RID: 117715 RVA: 0x0040CE19 File Offset: 0x0040B019
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CBD4 RID: 117716 RVA: 0x0040CE24 File Offset: 0x0040B024
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(1, actionListOffset.Value, 0);
		}

		// Token: 0x0601CBD5 RID: 117717 RVA: 0x0040CE34 File Offset: 0x0040B034
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CBD6 RID: 117718 RVA: 0x0040CE74 File Offset: 0x0040B074
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CBD7 RID: 117719 RVA: 0x0040CE8E File Offset: 0x0040B08E
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CBD8 RID: 117720 RVA: 0x0040CEAC File Offset: 0x0040B0AC
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CBD9 RID: 117721 RVA: 0x0040CEC5 File Offset: 0x0040B0C5
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CBDA RID: 117722 RVA: 0x0040CED0 File Offset: 0x0040B0D0
		public static Offset<IExecuteActionList> EndIExecuteActionList(FlatBufferBuilder builder)
		{
			return new Offset<IExecuteActionList>(builder.EndTable());
		}

		// Token: 0x0601CBDB RID: 117723 RVA: 0x0040CEE0 File Offset: 0x0040B0E0
		public IExecuteActionListT UnPack()
		{
			IExecuteActionListT executeActionListT = new IExecuteActionListT();
			this.UnPackTo(executeActionListT);
			return executeActionListT;
		}

		// Token: 0x0601CBDC RID: 117724 RVA: 0x0040CEFC File Offset: 0x0040B0FC
		public void UnPackTo(IExecuteActionListT _o)
		{
			_o.Type = this.Type;
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601CBDD RID: 117725 RVA: 0x0040CF68 File Offset: 0x0040B168
		public static Offset<IExecuteActionList> Pack(FlatBufferBuilder builder, IExecuteActionListT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecuteActionList>);
			}
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IExecuteActionList.CreateActionListVector(builder, array);
			}
			return IExecuteActionList.CreateIExecuteActionList(builder, _o.Type, actionListOffset);
		}

		// Token: 0x0400D1E9 RID: 53737
		private Table __p;
	}
}
