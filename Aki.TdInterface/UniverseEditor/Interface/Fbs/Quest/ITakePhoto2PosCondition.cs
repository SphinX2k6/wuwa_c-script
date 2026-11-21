using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D7 RID: 17879
	public struct ITakePhoto2PosCondition : IFlatbufferObject
	{
		// Token: 0x17007D0F RID: 32015
		// (get) Token: 0x0601A1D5 RID: 106965 RVA: 0x003B8A80 File Offset: 0x003B6C80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A1D6 RID: 106966 RVA: 0x003B8A8D File Offset: 0x003B6C8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A1D7 RID: 106967 RVA: 0x003B8A94 File Offset: 0x003B6C94
		public static ITakePhoto2PosCondition GetRootAsITakePhoto2PosCondition(ByteBuffer _bb)
		{
			return ITakePhoto2PosCondition.GetRootAsITakePhoto2PosCondition(_bb, default(ITakePhoto2PosCondition));
		}

		// Token: 0x0601A1D8 RID: 106968 RVA: 0x003B8AB0 File Offset: 0x003B6CB0
		public static ITakePhoto2PosCondition GetRootAsITakePhoto2PosCondition(ByteBuffer _bb, ITakePhoto2PosCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A1D9 RID: 106969 RVA: 0x003B8ACD File Offset: 0x003B6CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A1DA RID: 106970 RVA: 0x003B8ADC File Offset: 0x003B6CDC
		public ITakePhoto2PosCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D10 RID: 32016
		// (get) Token: 0x0601A1DB RID: 106971 RVA: 0x003B8AEC File Offset: 0x003B6CEC
		public int RangeEntity
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

		// Token: 0x0601A1DC RID: 106972 RVA: 0x003B8B28 File Offset: 0x003B6D28
		public static Offset<ITakePhoto2PosCondition> CreateITakePhoto2PosCondition(FlatBufferBuilder builder, int RangeEntity = 0)
		{
			builder.StartTable(1);
			ITakePhoto2PosCondition.AddRangeEntity(builder, RangeEntity);
			return ITakePhoto2PosCondition.EndITakePhoto2PosCondition(builder);
		}

		// Token: 0x0601A1DD RID: 106973 RVA: 0x003B8B3E File Offset: 0x003B6D3E
		public static void StartITakePhoto2PosCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A1DE RID: 106974 RVA: 0x003B8B47 File Offset: 0x003B6D47
		public static void AddRangeEntity(FlatBufferBuilder builder, int rangeEntity)
		{
			builder.AddInt(0, rangeEntity, 0);
		}

		// Token: 0x0601A1DF RID: 106975 RVA: 0x003B8B52 File Offset: 0x003B6D52
		public static Offset<ITakePhoto2PosCondition> EndITakePhoto2PosCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2PosCondition>(builder.EndTable());
		}

		// Token: 0x0601A1E0 RID: 106976 RVA: 0x003B8B60 File Offset: 0x003B6D60
		public ITakePhoto2PosConditionT UnPack()
		{
			ITakePhoto2PosConditionT takePhoto2PosConditionT = new ITakePhoto2PosConditionT();
			this.UnPackTo(takePhoto2PosConditionT);
			return takePhoto2PosConditionT;
		}

		// Token: 0x0601A1E1 RID: 106977 RVA: 0x003B8B7B File Offset: 0x003B6D7B
		public void UnPackTo(ITakePhoto2PosConditionT _o)
		{
			_o.RangeEntity = this.RangeEntity;
		}

		// Token: 0x0601A1E2 RID: 106978 RVA: 0x003B8B8C File Offset: 0x003B6D8C
		public static Offset<ITakePhoto2PosCondition> Pack(FlatBufferBuilder builder, ITakePhoto2PosConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2PosCondition>);
			}
			return ITakePhoto2PosCondition.CreateITakePhoto2PosCondition(builder, _o.RangeEntity);
		}

		// Token: 0x0400C7B5 RID: 51125
		private Table __p;
	}
}
