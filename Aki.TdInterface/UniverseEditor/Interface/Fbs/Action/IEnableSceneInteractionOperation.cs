using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200667B RID: 26235
	public struct IEnableSceneInteractionOperation : IFlatbufferObject
	{
		// Token: 0x1700C2E0 RID: 49888
		// (get) Token: 0x0602D941 RID: 186689 RVA: 0x0063D5B0 File Offset: 0x0063B7B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D942 RID: 186690 RVA: 0x0063D5BD File Offset: 0x0063B7BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D943 RID: 186691 RVA: 0x0063D5C4 File Offset: 0x0063B7C4
		public static IEnableSceneInteractionOperation GetRootAsIEnableSceneInteractionOperation(ByteBuffer _bb)
		{
			return IEnableSceneInteractionOperation.GetRootAsIEnableSceneInteractionOperation(_bb, default(IEnableSceneInteractionOperation));
		}

		// Token: 0x0602D944 RID: 186692 RVA: 0x0063D5E0 File Offset: 0x0063B7E0
		public static IEnableSceneInteractionOperation GetRootAsIEnableSceneInteractionOperation(ByteBuffer _bb, IEnableSceneInteractionOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D945 RID: 186693 RVA: 0x0063D5FD File Offset: 0x0063B7FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D946 RID: 186694 RVA: 0x0063D60C File Offset: 0x0063B80C
		public IEnableSceneInteractionOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2E1 RID: 49889
		// (get) Token: 0x0602D947 RID: 186695 RVA: 0x0063D61C File Offset: 0x0063B81C
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

		// Token: 0x0602D948 RID: 186696 RVA: 0x0063D658 File Offset: 0x0063B858
		public static Offset<IEnableSceneInteractionOperation> CreateIEnableSceneInteractionOperation(FlatBufferBuilder builder, ESceneInteractionOperationType Type = ESceneInteractionOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableSceneInteractionOperation.AddType(builder, Type);
			return IEnableSceneInteractionOperation.EndIEnableSceneInteractionOperation(builder);
		}

		// Token: 0x0602D949 RID: 186697 RVA: 0x0063D66E File Offset: 0x0063B86E
		public static void StartIEnableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D94A RID: 186698 RVA: 0x0063D677 File Offset: 0x0063B877
		public static void AddType(FlatBufferBuilder builder, ESceneInteractionOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D94B RID: 186699 RVA: 0x0063D682 File Offset: 0x0063B882
		public static Offset<IEnableSceneInteractionOperation> EndIEnableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableSceneInteractionOperation>(builder.EndTable());
		}

		// Token: 0x0602D94C RID: 186700 RVA: 0x0063D690 File Offset: 0x0063B890
		public IEnableSceneInteractionOperationT UnPack()
		{
			IEnableSceneInteractionOperationT enableSceneInteractionOperationT = new IEnableSceneInteractionOperationT();
			this.UnPackTo(enableSceneInteractionOperationT);
			return enableSceneInteractionOperationT;
		}

		// Token: 0x0602D94D RID: 186701 RVA: 0x0063D6AB File Offset: 0x0063B8AB
		public void UnPackTo(IEnableSceneInteractionOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D94E RID: 186702 RVA: 0x0063D6BC File Offset: 0x0063B8BC
		public static Offset<IEnableSceneInteractionOperation> Pack(FlatBufferBuilder builder, IEnableSceneInteractionOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableSceneInteractionOperation>);
			}
			return IEnableSceneInteractionOperation.CreateIEnableSceneInteractionOperation(builder, _o.Type);
		}

		// Token: 0x04010D22 RID: 68898
		private Table __p;
	}
}
