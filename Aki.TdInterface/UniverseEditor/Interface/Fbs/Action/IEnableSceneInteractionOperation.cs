using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF5 RID: 27893
	public struct IEnableSceneInteractionOperation : IFlatbufferObject
	{
		// Token: 0x1700CC91 RID: 52369
		// (get) Token: 0x0603015E RID: 196958 RVA: 0x0068A864 File Offset: 0x00688A64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603015F RID: 196959 RVA: 0x0068A871 File Offset: 0x00688A71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030160 RID: 196960 RVA: 0x0068A878 File Offset: 0x00688A78
		public static IEnableSceneInteractionOperation GetRootAsIEnableSceneInteractionOperation(ByteBuffer _bb)
		{
			return IEnableSceneInteractionOperation.GetRootAsIEnableSceneInteractionOperation(_bb, default(IEnableSceneInteractionOperation));
		}

		// Token: 0x06030161 RID: 196961 RVA: 0x0068A894 File Offset: 0x00688A94
		public static IEnableSceneInteractionOperation GetRootAsIEnableSceneInteractionOperation(ByteBuffer _bb, IEnableSceneInteractionOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030162 RID: 196962 RVA: 0x0068A8B1 File Offset: 0x00688AB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030163 RID: 196963 RVA: 0x0068A8C0 File Offset: 0x00688AC0
		public IEnableSceneInteractionOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC92 RID: 52370
		// (get) Token: 0x06030164 RID: 196964 RVA: 0x0068A8D0 File Offset: 0x00688AD0
		public ESceneInteractionOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneInteractionOperationType.Enable;
				}
				return (ESceneInteractionOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030165 RID: 196965 RVA: 0x0068A90C File Offset: 0x00688B0C
		public static Offset<IEnableSceneInteractionOperation> CreateIEnableSceneInteractionOperation(FlatBufferBuilder builder, ESceneInteractionOperationType Type = ESceneInteractionOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableSceneInteractionOperation.AddType(builder, Type);
			return IEnableSceneInteractionOperation.EndIEnableSceneInteractionOperation(builder);
		}

		// Token: 0x06030166 RID: 196966 RVA: 0x0068A922 File Offset: 0x00688B22
		public static void StartIEnableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030167 RID: 196967 RVA: 0x0068A92B File Offset: 0x00688B2B
		public static void AddType(FlatBufferBuilder builder, ESceneInteractionOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030168 RID: 196968 RVA: 0x0068A936 File Offset: 0x00688B36
		public static Offset<IEnableSceneInteractionOperation> EndIEnableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSceneInteractionOperation>(builder.EndTable());
		}

		// Token: 0x06030169 RID: 196969 RVA: 0x0068A944 File Offset: 0x00688B44
		public IEnableSceneInteractionOperationT UnPack()
		{
			IEnableSceneInteractionOperationT enableSceneInteractionOperationT = new IEnableSceneInteractionOperationT();
			this.UnPackTo(enableSceneInteractionOperationT);
			return enableSceneInteractionOperationT;
		}

		// Token: 0x0603016A RID: 196970 RVA: 0x0068A95F File Offset: 0x00688B5F
		public void UnPackTo(IEnableSceneInteractionOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603016B RID: 196971 RVA: 0x0068A970 File Offset: 0x00688B70
		public static Offset<IEnableSceneInteractionOperation> Pack(FlatBufferBuilder builder, IEnableSceneInteractionOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSceneInteractionOperation>);
			}
			return IEnableSceneInteractionOperation.CreateIEnableSceneInteractionOperation(builder, _o.Type);
		}

		// Token: 0x04011B48 RID: 72520
		private Table __p;
	}
}
