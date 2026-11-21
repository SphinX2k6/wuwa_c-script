using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045EC RID: 17900
	public struct ITakePhoto2TargetCameraDistanceCondition : IFlatbufferObject
	{
		// Token: 0x17007D35 RID: 32053
		// (get) Token: 0x0601A279 RID: 107129 RVA: 0x003B9BC4 File Offset: 0x003B7DC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A27A RID: 107130 RVA: 0x003B9BD1 File Offset: 0x003B7DD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A27B RID: 107131 RVA: 0x003B9BD8 File Offset: 0x003B7DD8
		public static ITakePhoto2TargetCameraDistanceCondition GetRootAsITakePhoto2TargetCameraDistanceCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetCameraDistanceCondition.GetRootAsITakePhoto2TargetCameraDistanceCondition(_bb, default(ITakePhoto2TargetCameraDistanceCondition));
		}

		// Token: 0x0601A27C RID: 107132 RVA: 0x003B9BF4 File Offset: 0x003B7DF4
		public static ITakePhoto2TargetCameraDistanceCondition GetRootAsITakePhoto2TargetCameraDistanceCondition(ByteBuffer _bb, ITakePhoto2TargetCameraDistanceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A27D RID: 107133 RVA: 0x003B9C11 File Offset: 0x003B7E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A27E RID: 107134 RVA: 0x003B9C20 File Offset: 0x003B7E20
		public ITakePhoto2TargetCameraDistanceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D36 RID: 32054
		// (get) Token: 0x0601A27F RID: 107135 RVA: 0x003B9C30 File Offset: 0x003B7E30
		public int MaxDistance
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

		// Token: 0x0601A280 RID: 107136 RVA: 0x003B9C6C File Offset: 0x003B7E6C
		public static Offset<ITakePhoto2TargetCameraDistanceCondition> CreateITakePhoto2TargetCameraDistanceCondition(FlatBufferBuilder builder, int MaxDistance = 0)
		{
			builder.StartTable(1);
			ITakePhoto2TargetCameraDistanceCondition.AddMaxDistance(builder, MaxDistance);
			return ITakePhoto2TargetCameraDistanceCondition.EndITakePhoto2TargetCameraDistanceCondition(builder);
		}

		// Token: 0x0601A281 RID: 107137 RVA: 0x003B9C82 File Offset: 0x003B7E82
		public static void StartITakePhoto2TargetCameraDistanceCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A282 RID: 107138 RVA: 0x003B9C8B File Offset: 0x003B7E8B
		public static void AddMaxDistance(FlatBufferBuilder builder, int maxDistance)
		{
			builder.AddInt(0, maxDistance, 0);
		}

		// Token: 0x0601A283 RID: 107139 RVA: 0x003B9C96 File Offset: 0x003B7E96
		public static Offset<ITakePhoto2TargetCameraDistanceCondition> EndITakePhoto2TargetCameraDistanceCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetCameraDistanceCondition>(builder.EndTable());
		}

		// Token: 0x0601A284 RID: 107140 RVA: 0x003B9CA4 File Offset: 0x003B7EA4
		public ITakePhoto2TargetCameraDistanceConditionT UnPack()
		{
			ITakePhoto2TargetCameraDistanceConditionT takePhoto2TargetCameraDistanceConditionT = new ITakePhoto2TargetCameraDistanceConditionT();
			this.UnPackTo(takePhoto2TargetCameraDistanceConditionT);
			return takePhoto2TargetCameraDistanceConditionT;
		}

		// Token: 0x0601A285 RID: 107141 RVA: 0x003B9CBF File Offset: 0x003B7EBF
		public void UnPackTo(ITakePhoto2TargetCameraDistanceConditionT _o)
		{
			_o.MaxDistance = this.MaxDistance;
		}

		// Token: 0x0601A286 RID: 107142 RVA: 0x003B9CD0 File Offset: 0x003B7ED0
		public static Offset<ITakePhoto2TargetCameraDistanceCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetCameraDistanceConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetCameraDistanceCondition>);
			}
			return ITakePhoto2TargetCameraDistanceCondition.CreateITakePhoto2TargetCameraDistanceCondition(builder, _o.MaxDistance);
		}

		// Token: 0x0400C7D1 RID: 51153
		private Table __p;
	}
}
