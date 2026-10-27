using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0F RID: 28431
	public struct IRunActions : IFlatbufferObject
	{
		// Token: 0x1700D360 RID: 54112
		// (get) Token: 0x060323A9 RID: 205737 RVA: 0x006C937E File Offset: 0x006C757E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323AA RID: 205738 RVA: 0x006C938B File Offset: 0x006C758B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323AB RID: 205739 RVA: 0x006C9394 File Offset: 0x006C7594
		public static IRunActions GetRootAsIRunActions(ByteBuffer _bb)
		{
			return IRunActions.GetRootAsIRunActions(_bb, default(IRunActions));
		}

		// Token: 0x060323AC RID: 205740 RVA: 0x006C93B0 File Offset: 0x006C75B0
		public static IRunActions GetRootAsIRunActions(ByteBuffer _bb, IRunActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323AD RID: 205741 RVA: 0x006C93CD File Offset: 0x006C75CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323AE RID: 205742 RVA: 0x006C93DC File Offset: 0x006C75DC
		public IRunActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060323AF RID: 205743 RVA: 0x006C93EC File Offset: 0x006C75EC
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D361 RID: 54113
		// (get) Token: 0x060323B0 RID: 205744 RVA: 0x006C944C File Offset: 0x006C764C
		public int ActionListLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060323B1 RID: 205745 RVA: 0x006C9477 File Offset: 0x006C7677
		public static Offset<IRunActions> CreateIRunActions(FlatBufferBuilder builder, VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IRunActions.AddActionList(builder, ActionListOffset);
			return IRunActions.EndIRunActions(builder);
		}

		// Token: 0x060323B2 RID: 205746 RVA: 0x006C948D File Offset: 0x006C768D
		public static void StartIRunActions(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060323B3 RID: 205747 RVA: 0x006C9496 File Offset: 0x006C7696
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(0, actionListOffset.Value, 0);
		}

		// Token: 0x060323B4 RID: 205748 RVA: 0x006C94A8 File Offset: 0x006C76A8
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060323B5 RID: 205749 RVA: 0x006C94E8 File Offset: 0x006C76E8
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060323B6 RID: 205750 RVA: 0x006C9502 File Offset: 0x006C7702
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060323B7 RID: 205751 RVA: 0x006C9520 File Offset: 0x006C7720
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060323B8 RID: 205752 RVA: 0x006C9539 File Offset: 0x006C7739
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060323B9 RID: 205753 RVA: 0x006C9544 File Offset: 0x006C7744
		public static Offset<IRunActions> EndIRunActions(FlatBufferBuilder builder)
		{
			return new Offset<IRunActions>(builder.EndTable());
		}

		// Token: 0x060323BA RID: 205754 RVA: 0x006C9554 File Offset: 0x006C7754
		public IRunActionsT UnPack()
		{
			IRunActionsT runActionsT = new IRunActionsT();
			this.UnPackTo(runActionsT);
			return runActionsT;
		}

		// Token: 0x060323BB RID: 205755 RVA: 0x006C9570 File Offset: 0x006C7770
		public void UnPackTo(IRunActionsT _o)
		{
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060323BC RID: 205756 RVA: 0x006C95D0 File Offset: 0x006C77D0
		public static Offset<IRunActions> Pack(FlatBufferBuilder builder, IRunActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunActions>);
			}
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IRunActions.CreateActionListVector(builder, array);
			}
			return IRunActions.CreateIRunActions(builder, actionListOffset);
		}

		// Token: 0x040118FA RID: 71930
		private Table __p;
	}
}
