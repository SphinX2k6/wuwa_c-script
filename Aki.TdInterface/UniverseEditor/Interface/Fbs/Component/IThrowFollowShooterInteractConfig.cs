using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006071 RID: 24689
	public struct IThrowFollowShooterInteractConfig : IFlatbufferObject
	{
		// Token: 0x1700B754 RID: 46932
		// (get) Token: 0x06029B61 RID: 170849 RVA: 0x005B1E42 File Offset: 0x005B0042
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B62 RID: 170850 RVA: 0x005B1E4F File Offset: 0x005B004F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B63 RID: 170851 RVA: 0x005B1E58 File Offset: 0x005B0058
		public static IThrowFollowShooterInteractConfig GetRootAsIThrowFollowShooterInteractConfig(ByteBuffer _bb)
		{
			return IThrowFollowShooterInteractConfig.GetRootAsIThrowFollowShooterInteractConfig(_bb, default(IThrowFollowShooterInteractConfig));
		}

		// Token: 0x06029B64 RID: 170852 RVA: 0x005B1E74 File Offset: 0x005B0074
		public static IThrowFollowShooterInteractConfig GetRootAsIThrowFollowShooterInteractConfig(ByteBuffer _bb, IThrowFollowShooterInteractConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B65 RID: 170853 RVA: 0x005B1E91 File Offset: 0x005B0091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B66 RID: 170854 RVA: 0x005B1EA0 File Offset: 0x005B00A0
		public IThrowFollowShooterInteractConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B755 RID: 46933
		// (get) Token: 0x06029B67 RID: 170855 RVA: 0x005B1EB0 File Offset: 0x005B00B0
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029B68 RID: 170856 RVA: 0x005B1EF0 File Offset: 0x005B00F0
		public int MatchIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B756 RID: 46934
		// (get) Token: 0x06029B69 RID: 170857 RVA: 0x005B1F30 File Offset: 0x005B0130
		public int MatchIdsLength
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

		// Token: 0x06029B6A RID: 170858 RVA: 0x005B1F5B File Offset: 0x005B015B
		public Span<int> GetMatchIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06029B6B RID: 170859 RVA: 0x005B1F6A File Offset: 0x005B016A
		public int[] GetMatchIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700B757 RID: 46935
		// (get) Token: 0x06029B6C RID: 170860 RVA: 0x005B1F78 File Offset: 0x005B0178
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029B6D RID: 170861 RVA: 0x005B1FD8 File Offset: 0x005B01D8
		public IConditionAction? ArrivedConditionActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B758 RID: 46936
		// (get) Token: 0x06029B6E RID: 170862 RVA: 0x005B203C File Offset: 0x005B023C
		public int ArrivedConditionActionsLength
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

		// Token: 0x06029B6F RID: 170863 RVA: 0x005B2068 File Offset: 0x005B0268
		public IConditionAction? LeavedConditionActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B759 RID: 46937
		// (get) Token: 0x06029B70 RID: 170864 RVA: 0x005B20CC File Offset: 0x005B02CC
		public int LeavedConditionActionsLength
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

		// Token: 0x1700B75A RID: 46938
		// (get) Token: 0x06029B71 RID: 170865 RVA: 0x005B20F8 File Offset: 0x005B02F8
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

		// Token: 0x06029B72 RID: 170866 RVA: 0x005B2135 File Offset: 0x005B0335
		public static Offset<IThrowFollowShooterInteractConfig> CreateIThrowFollowShooterInteractConfig(FlatBufferBuilder builder, float Radius = 0f, VectorOffset MatchIdsOffset = default(VectorOffset), Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), VectorOffset ArrivedConditionActionsOffset = default(VectorOffset), VectorOffset LeavedConditionActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IThrowFollowShooterInteractConfig.AddLeavedConditionActions(builder, LeavedConditionActionsOffset);
			IThrowFollowShooterInteractConfig.AddArrivedConditionActions(builder, ArrivedConditionActionsOffset);
			IThrowFollowShooterInteractConfig.AddOffset(builder, OffsetOffset);
			IThrowFollowShooterInteractConfig.AddMatchIds(builder, MatchIdsOffset);
			IThrowFollowShooterInteractConfig.AddRadius(builder, Radius);
			IThrowFollowShooterInteractConfig.AddNullMask(builder, NullMask);
			return IThrowFollowShooterInteractConfig.EndIThrowFollowShooterInteractConfig(builder);
		}

		// Token: 0x06029B73 RID: 170867 RVA: 0x005B2171 File Offset: 0x005B0371
		public static void StartIThrowFollowShooterInteractConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029B74 RID: 170868 RVA: 0x005B217A File Offset: 0x005B037A
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x06029B75 RID: 170869 RVA: 0x005B218D File Offset: 0x005B038D
		public static void AddMatchIds(FlatBufferBuilder builder, VectorOffset matchIdsOffset)
		{
			builder.AddOffset(1, matchIdsOffset.Value, 0);
		}

		// Token: 0x06029B76 RID: 170870 RVA: 0x005B21A0 File Offset: 0x005B03A0
		public static VectorOffset CreateMatchIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029B77 RID: 170871 RVA: 0x005B21D7 File Offset: 0x005B03D7
		public static VectorOffset CreateMatchIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B78 RID: 170872 RVA: 0x005B21F1 File Offset: 0x005B03F1
		public static VectorOffset CreateMatchIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B79 RID: 170873 RVA: 0x005B220F File Offset: 0x005B040F
		public static VectorOffset CreateMatchIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029B7A RID: 170874 RVA: 0x005B2228 File Offset: 0x005B0428
		public static void StartMatchIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029B7B RID: 170875 RVA: 0x005B2233 File Offset: 0x005B0433
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06029B7C RID: 170876 RVA: 0x005B2243 File Offset: 0x005B0443
		public static void AddArrivedConditionActions(FlatBufferBuilder builder, VectorOffset arrivedConditionActionsOffset)
		{
			builder.AddOffset(3, arrivedConditionActionsOffset.Value, 0);
		}

		// Token: 0x06029B7D RID: 170877 RVA: 0x005B2254 File Offset: 0x005B0454
		public static VectorOffset CreateArrivedConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029B7E RID: 170878 RVA: 0x005B2294 File Offset: 0x005B0494
		public static VectorOffset CreateArrivedConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B7F RID: 170879 RVA: 0x005B22AE File Offset: 0x005B04AE
		public static VectorOffset CreateArrivedConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B80 RID: 170880 RVA: 0x005B22CC File Offset: 0x005B04CC
		public static VectorOffset CreateArrivedConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029B81 RID: 170881 RVA: 0x005B22E5 File Offset: 0x005B04E5
		public static void StartArrivedConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029B82 RID: 170882 RVA: 0x005B22F0 File Offset: 0x005B04F0
		public static void AddLeavedConditionActions(FlatBufferBuilder builder, VectorOffset leavedConditionActionsOffset)
		{
			builder.AddOffset(4, leavedConditionActionsOffset.Value, 0);
		}

		// Token: 0x06029B83 RID: 170883 RVA: 0x005B2300 File Offset: 0x005B0500
		public static VectorOffset CreateLeavedConditionActionsVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029B84 RID: 170884 RVA: 0x005B2340 File Offset: 0x005B0540
		public static VectorOffset CreateLeavedConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B85 RID: 170885 RVA: 0x005B235A File Offset: 0x005B055A
		public static VectorOffset CreateLeavedConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B86 RID: 170886 RVA: 0x005B2378 File Offset: 0x005B0578
		public static VectorOffset CreateLeavedConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029B87 RID: 170887 RVA: 0x005B2391 File Offset: 0x005B0591
		public static void StartLeavedConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029B88 RID: 170888 RVA: 0x005B239C File Offset: 0x005B059C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06029B89 RID: 170889 RVA: 0x005B23A7 File Offset: 0x005B05A7
		public static Offset<IThrowFollowShooterInteractConfig> EndIThrowFollowShooterInteractConfig(FlatBufferBuilder builder)
		{
			return new Offset<IThrowFollowShooterInteractConfig>(builder.EndTable());
		}

		// Token: 0x06029B8A RID: 170890 RVA: 0x005B23B4 File Offset: 0x005B05B4
		public IThrowFollowShooterInteractConfigT UnPack()
		{
			IThrowFollowShooterInteractConfigT throwFollowShooterInteractConfigT = new IThrowFollowShooterInteractConfigT();
			this.UnPackTo(throwFollowShooterInteractConfigT);
			return throwFollowShooterInteractConfigT;
		}

		// Token: 0x06029B8B RID: 170891 RVA: 0x005B23D0 File Offset: 0x005B05D0
		public void UnPackTo(IThrowFollowShooterInteractConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.MatchIds = new List<int>();
			for (int i = 0; i < this.MatchIdsLength; i++)
			{
				_o.MatchIds.Add(this.MatchIds(i));
			}
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ArrivedConditionActions = new List<IConditionActionT>();
			for (int j = 0; j < this.ArrivedConditionActionsLength; j++)
			{
				_o.ArrivedConditionActions.Add((this.ArrivedConditionActions(j) != null) ? this.ArrivedConditionActions(j).Value.UnPack() : null);
			}
			_o.LeavedConditionActions = new List<IConditionActionT>();
			for (int k = 0; k < this.LeavedConditionActionsLength; k++)
			{
				_o.LeavedConditionActions.Add((this.LeavedConditionActions(k) != null) ? this.LeavedConditionActions(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029B8C RID: 170892 RVA: 0x005B2504 File Offset: 0x005B0704
		public static Offset<IThrowFollowShooterInteractConfig> Pack(FlatBufferBuilder builder, IThrowFollowShooterInteractConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IThrowFollowShooterInteractConfig>);
			}
			VectorOffset matchIdsOffset = default(VectorOffset);
			if (_o.MatchIds != null)
			{
				int[] data = _o.MatchIds.ToArray();
				matchIdsOffset = IThrowFollowShooterInteractConfig.CreateMatchIdsVector(builder, data);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			VectorOffset arrivedConditionActionsOffset = default(VectorOffset);
			if (_o.ArrivedConditionActions != null)
			{
				Offset<IConditionAction>[] array = new Offset<IConditionAction>[_o.ArrivedConditionActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionAction.Pack(builder, _o.ArrivedConditionActions[i]);
				}
				arrivedConditionActionsOffset = IThrowFollowShooterInteractConfig.CreateArrivedConditionActionsVector(builder, array);
			}
			VectorOffset leavedConditionActionsOffset = default(VectorOffset);
			if (_o.LeavedConditionActions != null)
			{
				Offset<IConditionAction>[] array2 = new Offset<IConditionAction>[_o.LeavedConditionActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionAction.Pack(builder, _o.LeavedConditionActions[j]);
				}
				leavedConditionActionsOffset = IThrowFollowShooterInteractConfig.CreateLeavedConditionActionsVector(builder, array2);
			}
			return IThrowFollowShooterInteractConfig.CreateIThrowFollowShooterInteractConfig(builder, _o.Radius, matchIdsOffset, offsetOffset, arrivedConditionActionsOffset, leavedConditionActionsOffset, _o.NullMask);
		}

		// Token: 0x0400FDE9 RID: 65001
		private Table __p;
	}
}
