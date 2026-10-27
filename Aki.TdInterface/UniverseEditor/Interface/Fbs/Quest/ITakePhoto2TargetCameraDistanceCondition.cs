using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004193 RID: 16787
	public struct ITakePhoto2TargetCameraDistanceCondition : IFlatbufferObject
	{
		// Token: 0x17007709 RID: 30473
		// (get) Token: 0x06018B23 RID: 101155 RVA: 0x0038E770 File Offset: 0x0038C970
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B24 RID: 101156 RVA: 0x0038E77D File Offset: 0x0038C97D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B25 RID: 101157 RVA: 0x0038E784 File Offset: 0x0038C984
		public static ITakePhoto2TargetCameraDistanceCondition GetRootAsITakePhoto2TargetCameraDistanceCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetCameraDistanceCondition.GetRootAsITakePhoto2TargetCameraDistanceCondition(_bb, default(ITakePhoto2TargetCameraDistanceCondition));
		}

		// Token: 0x06018B26 RID: 101158 RVA: 0x0038E7A0 File Offset: 0x0038C9A0
		public static ITakePhoto2TargetCameraDistanceCondition GetRootAsITakePhoto2TargetCameraDistanceCondition(ByteBuffer _bb, ITakePhoto2TargetCameraDistanceCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B27 RID: 101159 RVA: 0x0038E7BD File Offset: 0x0038C9BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B28 RID: 101160 RVA: 0x0038E7CC File Offset: 0x0038C9CC
		public ITakePhoto2TargetCameraDistanceCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700770A RID: 30474
		// (get) Token: 0x06018B29 RID: 101161 RVA: 0x0038E7DC File Offset: 0x0038C9DC
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

		// Token: 0x06018B2A RID: 101162 RVA: 0x0038E818 File Offset: 0x0038CA18
		public static Offset<ITakePhoto2TargetCameraDistanceCondition> CreateITakePhoto2TargetCameraDistanceCondition(FlatBufferBuilder builder, int MaxDistance = 0)
		{
			builder.StartTable(1);
			ITakePhoto2TargetCameraDistanceCondition.AddMaxDistance(builder, MaxDistance);
			return ITakePhoto2TargetCameraDistanceCondition.EndITakePhoto2TargetCameraDistanceCondition(builder);
		}

		// Token: 0x06018B2B RID: 101163 RVA: 0x0038E82E File Offset: 0x0038CA2E
		public static void StartITakePhoto2TargetCameraDistanceCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018B2C RID: 101164 RVA: 0x0038E837 File Offset: 0x0038CA37
		public static void AddMaxDistance(FlatBufferBuilder builder, int maxDistance)
		{
			builder.AddInt(0, maxDistance, 0);
		}

		// Token: 0x06018B2D RID: 101165 RVA: 0x0038E842 File Offset: 0x0038CA42
		public static Offset<ITakePhoto2TargetCameraDistanceCondition> EndITakePhoto2TargetCameraDistanceCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetCameraDistanceCondition>(builder.EndTable());
		}

		// Token: 0x06018B2E RID: 101166 RVA: 0x0038E850 File Offset: 0x0038CA50
		public ITakePhoto2TargetCameraDistanceConditionT UnPack()
		{
			ITakePhoto2TargetCameraDistanceConditionT takePhoto2TargetCameraDistanceConditionT = new ITakePhoto2TargetCameraDistanceConditionT();
			this.UnPackTo(takePhoto2TargetCameraDistanceConditionT);
			return takePhoto2TargetCameraDistanceConditionT;
		}

		// Token: 0x06018B2F RID: 101167 RVA: 0x0038E86B File Offset: 0x0038CA6B
		public void UnPackTo(ITakePhoto2TargetCameraDistanceConditionT _o)
		{
			_o.MaxDistance = this.MaxDistance;
		}

		// Token: 0x06018B30 RID: 101168 RVA: 0x0038E87C File Offset: 0x0038CA7C
		public static Offset<ITakePhoto2TargetCameraDistanceCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetCameraDistanceConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetCameraDistanceCondition>);
			}
			return ITakePhoto2TargetCameraDistanceCondition.CreateITakePhoto2TargetCameraDistanceCondition(builder, _o.MaxDistance);
		}

		// Token: 0x0400BDC7 RID: 48583
		private Table __p;
	}
}
