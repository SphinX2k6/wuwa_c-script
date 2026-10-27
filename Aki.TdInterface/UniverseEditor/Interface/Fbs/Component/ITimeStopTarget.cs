using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABA RID: 23226
	public struct ITimeStopTarget : IFlatbufferObject
	{
		// Token: 0x1700AEEB RID: 44779
		// (get) Token: 0x0602792A RID: 162090 RVA: 0x00571657 File Offset: 0x0056F857
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602792B RID: 162091 RVA: 0x00571664 File Offset: 0x0056F864
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602792C RID: 162092 RVA: 0x0057166C File Offset: 0x0056F86C
		public static ITimeStopTarget GetRootAsITimeStopTarget(ByteBuffer _bb)
		{
			return ITimeStopTarget.GetRootAsITimeStopTarget(_bb, default(ITimeStopTarget));
		}

		// Token: 0x0602792D RID: 162093 RVA: 0x00571688 File Offset: 0x0056F888
		public static ITimeStopTarget GetRootAsITimeStopTarget(ByteBuffer _bb, ITimeStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602792E RID: 162094 RVA: 0x005716A5 File Offset: 0x0056F8A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602792F RID: 162095 RVA: 0x005716B4 File Offset: 0x0056F8B4
		public ITimeStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06027930 RID: 162096 RVA: 0x005716C4 File Offset: 0x0056F8C4
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AEEC RID: 44780
		// (get) Token: 0x06027931 RID: 162097 RVA: 0x00571704 File Offset: 0x0056F904
		public int EntityIdsLength
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

		// Token: 0x06027932 RID: 162098 RVA: 0x0057172F File Offset: 0x0056F92F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06027933 RID: 162099 RVA: 0x0057173E File Offset: 0x0056F93E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700AEED RID: 44781
		// (get) Token: 0x06027934 RID: 162100 RVA: 0x0057174C File Offset: 0x0056F94C
		public IDynamicEntityMatch? EntityMatch
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027935 RID: 162101 RVA: 0x005717A9 File Offset: 0x0056F9A9
		public static Offset<ITimeStopTarget> CreateITimeStopTarget(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), Offset<IDynamicEntityMatch> EntityMatchOffset = default(Offset<IDynamicEntityMatch>))
		{
			builder.StartTable(2);
			ITimeStopTarget.AddEntityMatch(builder, EntityMatchOffset);
			ITimeStopTarget.AddEntityIds(builder, EntityIdsOffset);
			return ITimeStopTarget.EndITimeStopTarget(builder);
		}

		// Token: 0x06027936 RID: 162102 RVA: 0x005717C6 File Offset: 0x0056F9C6
		public static void StartITimeStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027937 RID: 162103 RVA: 0x005717CF File Offset: 0x0056F9CF
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06027938 RID: 162104 RVA: 0x005717E0 File Offset: 0x0056F9E0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027939 RID: 162105 RVA: 0x00571817 File Offset: 0x0056FA17
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602793A RID: 162106 RVA: 0x00571831 File Offset: 0x0056FA31
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602793B RID: 162107 RVA: 0x0057184F File Offset: 0x0056FA4F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602793C RID: 162108 RVA: 0x00571868 File Offset: 0x0056FA68
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602793D RID: 162109 RVA: 0x00571873 File Offset: 0x0056FA73
		public static void AddEntityMatch(FlatBufferBuilder builder, Offset<IDynamicEntityMatch> entityMatchOffset)
		{
			builder.AddOffset(1, entityMatchOffset.Value, 0);
		}

		// Token: 0x0602793E RID: 162110 RVA: 0x00571883 File Offset: 0x0056FA83
		public static Offset<ITimeStopTarget> EndITimeStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<ITimeStopTarget>(builder.EndTable());
		}

		// Token: 0x0602793F RID: 162111 RVA: 0x00571890 File Offset: 0x0056FA90
		public ITimeStopTargetT UnPack()
		{
			ITimeStopTargetT timeStopTargetT = new ITimeStopTargetT();
			this.UnPackTo(timeStopTargetT);
			return timeStopTargetT;
		}

		// Token: 0x06027940 RID: 162112 RVA: 0x005718AC File Offset: 0x0056FAAC
		public void UnPackTo(ITimeStopTargetT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.EntityMatch = ((this.EntityMatch != null) ? this.EntityMatch.Value.UnPack() : null);
		}

		// Token: 0x06027941 RID: 162113 RVA: 0x00571918 File Offset: 0x0056FB18
		public static Offset<ITimeStopTarget> Pack(FlatBufferBuilder builder, ITimeStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeStopTarget>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ITimeStopTarget.CreateEntityIdsVector(builder, data);
			}
			Offset<IDynamicEntityMatch> entityMatchOffset = (_o.EntityMatch == null) ? default(Offset<IDynamicEntityMatch>) : IDynamicEntityMatch.Pack(builder, _o.EntityMatch);
			return ITimeStopTarget.CreateITimeStopTarget(builder, entityIdsOffset, entityMatchOffset);
		}

		// Token: 0x0400F183 RID: 61827
		private Table __p;
	}
}
