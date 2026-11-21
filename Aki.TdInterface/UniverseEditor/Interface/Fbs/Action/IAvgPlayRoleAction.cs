using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006832 RID: 26674
	public struct IAvgPlayRoleAction : IFlatbufferObject
	{
		// Token: 0x1700C41C RID: 50204
		// (get) Token: 0x0602D94F RID: 186703 RVA: 0x0063CB83 File Offset: 0x0063AD83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D950 RID: 186704 RVA: 0x0063CB90 File Offset: 0x0063AD90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D951 RID: 186705 RVA: 0x0063CB98 File Offset: 0x0063AD98
		public static IAvgPlayRoleAction GetRootAsIAvgPlayRoleAction(ByteBuffer _bb)
		{
			return IAvgPlayRoleAction.GetRootAsIAvgPlayRoleAction(_bb, default(IAvgPlayRoleAction));
		}

		// Token: 0x0602D952 RID: 186706 RVA: 0x0063CBB4 File Offset: 0x0063ADB4
		public static IAvgPlayRoleAction GetRootAsIAvgPlayRoleAction(ByteBuffer _bb, IAvgPlayRoleAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D953 RID: 186707 RVA: 0x0063CBD1 File Offset: 0x0063ADD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D954 RID: 186708 RVA: 0x0063CBE0 File Offset: 0x0063ADE0
		public IAvgPlayRoleAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602D955 RID: 186709 RVA: 0x0063CBF0 File Offset: 0x0063ADF0
		public IAvgPlayRoleActionItem? RoleActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IAvgPlayRoleActionItem?(default(IAvgPlayRoleActionItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C41D RID: 50205
		// (get) Token: 0x0602D956 RID: 186710 RVA: 0x0063CC50 File Offset: 0x0063AE50
		public int RoleActionListLength
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

		// Token: 0x0602D957 RID: 186711 RVA: 0x0063CC7B File Offset: 0x0063AE7B
		public static Offset<IAvgPlayRoleAction> CreateIAvgPlayRoleAction(FlatBufferBuilder builder, VectorOffset RoleActionListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IAvgPlayRoleAction.AddRoleActionList(builder, RoleActionListOffset);
			return IAvgPlayRoleAction.EndIAvgPlayRoleAction(builder);
		}

		// Token: 0x0602D958 RID: 186712 RVA: 0x0063CC91 File Offset: 0x0063AE91
		public static void StartIAvgPlayRoleAction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D959 RID: 186713 RVA: 0x0063CC9A File Offset: 0x0063AE9A
		public static void AddRoleActionList(FlatBufferBuilder builder, VectorOffset roleActionListOffset)
		{
			builder.AddOffset(0, roleActionListOffset.Value, 0);
		}

		// Token: 0x0602D95A RID: 186714 RVA: 0x0063CCAC File Offset: 0x0063AEAC
		public static VectorOffset CreateRoleActionListVector(FlatBufferBuilder builder, Offset<IAvgPlayRoleActionItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D95B RID: 186715 RVA: 0x0063CCEC File Offset: 0x0063AEEC
		public static VectorOffset CreateRoleActionListVectorBlock(FlatBufferBuilder builder, Offset<IAvgPlayRoleActionItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAvgPlayRoleActionItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D95C RID: 186716 RVA: 0x0063CD06 File Offset: 0x0063AF06
		public static VectorOffset CreateRoleActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAvgPlayRoleActionItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAvgPlayRoleActionItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D95D RID: 186717 RVA: 0x0063CD24 File Offset: 0x0063AF24
		public static VectorOffset CreateRoleActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAvgPlayRoleActionItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D95E RID: 186718 RVA: 0x0063CD3D File Offset: 0x0063AF3D
		public static void StartRoleActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D95F RID: 186719 RVA: 0x0063CD48 File Offset: 0x0063AF48
		public static Offset<IAvgPlayRoleAction> EndIAvgPlayRoleAction(FlatBufferBuilder builder)
		{
			return new Offset<IAvgPlayRoleAction>(builder.EndTable());
		}

		// Token: 0x0602D960 RID: 186720 RVA: 0x0063CD58 File Offset: 0x0063AF58
		public IAvgPlayRoleActionT UnPack()
		{
			IAvgPlayRoleActionT avgPlayRoleActionT = new IAvgPlayRoleActionT();
			this.UnPackTo(avgPlayRoleActionT);
			return avgPlayRoleActionT;
		}

		// Token: 0x0602D961 RID: 186721 RVA: 0x0063CD74 File Offset: 0x0063AF74
		public void UnPackTo(IAvgPlayRoleActionT _o)
		{
			_o.RoleActionList = new List<IAvgPlayRoleActionItemT>();
			for (int i = 0; i < this.RoleActionListLength; i++)
			{
				_o.RoleActionList.Add((this.RoleActionList(i) != null) ? this.RoleActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602D962 RID: 186722 RVA: 0x0063CDD4 File Offset: 0x0063AFD4
		public static Offset<IAvgPlayRoleAction> Pack(FlatBufferBuilder builder, IAvgPlayRoleActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAvgPlayRoleAction>);
			}
			VectorOffset roleActionListOffset = default(VectorOffset);
			if (_o.RoleActionList != null)
			{
				Offset<IAvgPlayRoleActionItem>[] array = new Offset<IAvgPlayRoleActionItem>[_o.RoleActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAvgPlayRoleActionItem.Pack(builder, _o.RoleActionList[i]);
				}
				roleActionListOffset = IAvgPlayRoleAction.CreateRoleActionListVector(builder, array);
			}
			return IAvgPlayRoleAction.CreateIAvgPlayRoleAction(builder, roleActionListOffset);
		}

		// Token: 0x040114F9 RID: 70905
		private Table __p;
	}
}
