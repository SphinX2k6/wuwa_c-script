using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428F RID: 17039
	public struct IWarningPreformActivateStateRecordEntity : IFlatbufferObject
	{
		// Token: 0x17007900 RID: 30976
		// (get) Token: 0x060193E5 RID: 103397 RVA: 0x003A06B5 File Offset: 0x0039E8B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060193E6 RID: 103398 RVA: 0x003A06C2 File Offset: 0x0039E8C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060193E7 RID: 103399 RVA: 0x003A06CC File Offset: 0x0039E8CC
		public static IWarningPreformActivateStateRecordEntity GetRootAsIWarningPreformActivateStateRecordEntity(ByteBuffer _bb)
		{
			return IWarningPreformActivateStateRecordEntity.GetRootAsIWarningPreformActivateStateRecordEntity(_bb, default(IWarningPreformActivateStateRecordEntity));
		}

		// Token: 0x060193E8 RID: 103400 RVA: 0x003A06E8 File Offset: 0x0039E8E8
		public static IWarningPreformActivateStateRecordEntity GetRootAsIWarningPreformActivateStateRecordEntity(ByteBuffer _bb, IWarningPreformActivateStateRecordEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060193E9 RID: 103401 RVA: 0x003A0705 File Offset: 0x0039E905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060193EA RID: 103402 RVA: 0x003A0714 File Offset: 0x0039E914
		public IWarningPreformActivateStateRecordEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007901 RID: 30977
		// (get) Token: 0x060193EB RID: 103403 RVA: 0x003A0724 File Offset: 0x0039E924
		public EWarningPreformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return (EWarningPreformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060193EC RID: 103404 RVA: 0x003A0760 File Offset: 0x0039E960
		public int TargetEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007902 RID: 30978
		// (get) Token: 0x060193ED RID: 103405 RVA: 0x003A07A0 File Offset: 0x0039E9A0
		public int TargetEntityIdsLength
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

		// Token: 0x060193EE RID: 103406 RVA: 0x003A07CB File Offset: 0x0039E9CB
		public Span<int> GetTargetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060193EF RID: 103407 RVA: 0x003A07DA File Offset: 0x0039E9DA
		public int[] GetTargetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060193F0 RID: 103408 RVA: 0x003A07E8 File Offset: 0x0039E9E8
		public static Offset<IWarningPreformActivateStateRecordEntity> CreateIWarningPreformActivateStateRecordEntity(FlatBufferBuilder builder, EWarningPreformType Type = EWarningPreformType.FadeInScreen, VectorOffset TargetEntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IWarningPreformActivateStateRecordEntity.AddTargetEntityIds(builder, TargetEntityIdsOffset);
			IWarningPreformActivateStateRecordEntity.AddType(builder, Type);
			return IWarningPreformActivateStateRecordEntity.EndIWarningPreformActivateStateRecordEntity(builder);
		}

		// Token: 0x060193F1 RID: 103409 RVA: 0x003A0805 File Offset: 0x0039EA05
		public static void StartIWarningPreformActivateStateRecordEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060193F2 RID: 103410 RVA: 0x003A080E File Offset: 0x0039EA0E
		public static void AddType(FlatBufferBuilder builder, EWarningPreformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060193F3 RID: 103411 RVA: 0x003A0819 File Offset: 0x0039EA19
		public static void AddTargetEntityIds(FlatBufferBuilder builder, VectorOffset targetEntityIdsOffset)
		{
			builder.AddOffset(1, targetEntityIdsOffset.Value, 0);
		}

		// Token: 0x060193F4 RID: 103412 RVA: 0x003A082C File Offset: 0x0039EA2C
		public static VectorOffset CreateTargetEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060193F5 RID: 103413 RVA: 0x003A0863 File Offset: 0x0039EA63
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060193F6 RID: 103414 RVA: 0x003A087D File Offset: 0x0039EA7D
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060193F7 RID: 103415 RVA: 0x003A089B File Offset: 0x0039EA9B
		public static VectorOffset CreateTargetEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060193F8 RID: 103416 RVA: 0x003A08B4 File Offset: 0x0039EAB4
		public static void StartTargetEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060193F9 RID: 103417 RVA: 0x003A08BF File Offset: 0x0039EABF
		public static Offset<IWarningPreformActivateStateRecordEntity> EndIWarningPreformActivateStateRecordEntity(FlatBufferBuilder builder)
		{
			return new Offset<IWarningPreformActivateStateRecordEntity>(builder.EndTable());
		}

		// Token: 0x060193FA RID: 103418 RVA: 0x003A08CC File Offset: 0x0039EACC
		public IWarningPreformActivateStateRecordEntityT UnPack()
		{
			IWarningPreformActivateStateRecordEntityT warningPreformActivateStateRecordEntityT = new IWarningPreformActivateStateRecordEntityT();
			this.UnPackTo(warningPreformActivateStateRecordEntityT);
			return warningPreformActivateStateRecordEntityT;
		}

		// Token: 0x060193FB RID: 103419 RVA: 0x003A08E8 File Offset: 0x0039EAE8
		public void UnPackTo(IWarningPreformActivateStateRecordEntityT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityIds = new List<int>();
			for (int i = 0; i < this.TargetEntityIdsLength; i++)
			{
				_o.TargetEntityIds.Add(this.TargetEntityIds(i));
			}
		}

		// Token: 0x060193FC RID: 103420 RVA: 0x003A0930 File Offset: 0x0039EB30
		public static Offset<IWarningPreformActivateStateRecordEntity> Pack(FlatBufferBuilder builder, IWarningPreformActivateStateRecordEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWarningPreformActivateStateRecordEntity>);
			}
			VectorOffset targetEntityIdsOffset = default(VectorOffset);
			if (_o.TargetEntityIds != null)
			{
				int[] data = _o.TargetEntityIds.ToArray();
				targetEntityIdsOffset = IWarningPreformActivateStateRecordEntity.CreateTargetEntityIdsVector(builder, data);
			}
			return IWarningPreformActivateStateRecordEntity.CreateIWarningPreformActivateStateRecordEntity(builder, _o.Type, targetEntityIdsOffset);
		}

		// Token: 0x0400BF2F RID: 48943
		private Table __p;
	}
}
