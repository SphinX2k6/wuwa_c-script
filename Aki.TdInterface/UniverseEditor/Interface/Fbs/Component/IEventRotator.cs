using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572D RID: 22317
	public struct IEventRotator : IFlatbufferObject
	{
		// Token: 0x1700A125 RID: 41253
		// (get) Token: 0x06023E5C RID: 147036 RVA: 0x004EF560 File Offset: 0x004ED760
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023E5D RID: 147037 RVA: 0x004EF56D File Offset: 0x004ED76D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023E5E RID: 147038 RVA: 0x004EF574 File Offset: 0x004ED774
		public static IEventRotator GetRootAsIEventRotator(ByteBuffer _bb)
		{
			return IEventRotator.GetRootAsIEventRotator(_bb, default(IEventRotator));
		}

		// Token: 0x06023E5F RID: 147039 RVA: 0x004EF590 File Offset: 0x004ED790
		public static IEventRotator GetRootAsIEventRotator(ByteBuffer _bb, IEventRotator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023E60 RID: 147040 RVA: 0x004EF5AD File Offset: 0x004ED7AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023E61 RID: 147041 RVA: 0x004EF5BC File Offset: 0x004ED7BC
		public IEventRotator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06023E62 RID: 147042 RVA: 0x004EF5CC File Offset: 0x004ED7CC
		public IActionInfo? StartActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A126 RID: 41254
		// (get) Token: 0x06023E63 RID: 147043 RVA: 0x004EF62C File Offset: 0x004ED82C
		public int StartActionsLength
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

		// Token: 0x06023E64 RID: 147044 RVA: 0x004EF658 File Offset: 0x004ED858
		public IActionInfo? EndActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A127 RID: 41255
		// (get) Token: 0x06023E65 RID: 147045 RVA: 0x004EF6B8 File Offset: 0x004ED8B8
		public int EndActionsLength
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

		// Token: 0x06023E66 RID: 147046 RVA: 0x004EF6E3 File Offset: 0x004ED8E3
		public static Offset<IEventRotator> CreateIEventRotator(FlatBufferBuilder builder, VectorOffset StartActionsOffset = default(VectorOffset), VectorOffset EndActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEventRotator.AddEndActions(builder, EndActionsOffset);
			IEventRotator.AddStartActions(builder, StartActionsOffset);
			return IEventRotator.EndIEventRotator(builder);
		}

		// Token: 0x06023E67 RID: 147047 RVA: 0x004EF700 File Offset: 0x004ED900
		public static void StartIEventRotator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023E68 RID: 147048 RVA: 0x004EF709 File Offset: 0x004ED909
		public static void AddStartActions(FlatBufferBuilder builder, VectorOffset startActionsOffset)
		{
			builder.AddOffset(0, startActionsOffset.Value, 0);
		}

		// Token: 0x06023E69 RID: 147049 RVA: 0x004EF71C File Offset: 0x004ED91C
		public static VectorOffset CreateStartActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E6A RID: 147050 RVA: 0x004EF75C File Offset: 0x004ED95C
		public static VectorOffset CreateStartActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E6B RID: 147051 RVA: 0x004EF776 File Offset: 0x004ED976
		public static VectorOffset CreateStartActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E6C RID: 147052 RVA: 0x004EF794 File Offset: 0x004ED994
		public static VectorOffset CreateStartActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E6D RID: 147053 RVA: 0x004EF7AD File Offset: 0x004ED9AD
		public static void StartStartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E6E RID: 147054 RVA: 0x004EF7B8 File Offset: 0x004ED9B8
		public static void AddEndActions(FlatBufferBuilder builder, VectorOffset endActionsOffset)
		{
			builder.AddOffset(1, endActionsOffset.Value, 0);
		}

		// Token: 0x06023E6F RID: 147055 RVA: 0x004EF7C8 File Offset: 0x004ED9C8
		public static VectorOffset CreateEndActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023E70 RID: 147056 RVA: 0x004EF808 File Offset: 0x004EDA08
		public static VectorOffset CreateEndActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E71 RID: 147057 RVA: 0x004EF822 File Offset: 0x004EDA22
		public static VectorOffset CreateEndActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023E72 RID: 147058 RVA: 0x004EF840 File Offset: 0x004EDA40
		public static VectorOffset CreateEndActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023E73 RID: 147059 RVA: 0x004EF859 File Offset: 0x004EDA59
		public static void StartEndActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023E74 RID: 147060 RVA: 0x004EF864 File Offset: 0x004EDA64
		public static Offset<IEventRotator> EndIEventRotator(FlatBufferBuilder builder)
		{
			return new Offset<IEventRotator>(builder.EndTable());
		}

		// Token: 0x06023E75 RID: 147061 RVA: 0x004EF874 File Offset: 0x004EDA74
		public IEventRotatorT UnPack()
		{
			IEventRotatorT eventRotatorT = new IEventRotatorT();
			this.UnPackTo(eventRotatorT);
			return eventRotatorT;
		}

		// Token: 0x06023E76 RID: 147062 RVA: 0x004EF890 File Offset: 0x004EDA90
		public void UnPackTo(IEventRotatorT _o)
		{
			_o.StartActions = new List<IActionInfoT>();
			for (int i = 0; i < this.StartActionsLength; i++)
			{
				_o.StartActions.Add((this.StartActions(i) != null) ? this.StartActions(i).Value.UnPack() : null);
			}
			_o.EndActions = new List<IActionInfoT>();
			for (int j = 0; j < this.EndActionsLength; j++)
			{
				_o.EndActions.Add((this.EndActions(j) != null) ? this.EndActions(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06023E77 RID: 147063 RVA: 0x004EF944 File Offset: 0x004EDB44
		public static Offset<IEventRotator> Pack(FlatBufferBuilder builder, IEventRotatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEventRotator>);
			}
			VectorOffset startActionsOffset = default(VectorOffset);
			if (_o.StartActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.StartActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.StartActions[i]);
				}
				startActionsOffset = IEventRotator.CreateStartActionsVector(builder, array);
			}
			VectorOffset endActionsOffset = default(VectorOffset);
			if (_o.EndActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.EndActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.EndActions[j]);
				}
				endActionsOffset = IEventRotator.CreateEndActionsVector(builder, array2);
			}
			return IEventRotator.CreateIEventRotator(builder, startActionsOffset, endActionsOffset);
		}

		// Token: 0x0400EEC8 RID: 61128
		private Table __p;
	}
}
