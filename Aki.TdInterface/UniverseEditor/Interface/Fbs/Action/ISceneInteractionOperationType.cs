using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F33 RID: 28467
	public struct ISceneInteractionOperationType : IFlatbufferObject
	{
		// Token: 0x1700D397 RID: 54167
		// (get) Token: 0x060324BF RID: 206015 RVA: 0x006CB267 File Offset: 0x006C9467
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060324C0 RID: 206016 RVA: 0x006CB274 File Offset: 0x006C9474
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060324C1 RID: 206017 RVA: 0x006CB27C File Offset: 0x006C947C
		public static ISceneInteractionOperationType GetRootAsISceneInteractionOperationType(ByteBuffer _bb)
		{
			return ISceneInteractionOperationType.GetRootAsISceneInteractionOperationType(_bb, default(ISceneInteractionOperationType));
		}

		// Token: 0x060324C2 RID: 206018 RVA: 0x006CB298 File Offset: 0x006C9498
		public static ISceneInteractionOperationType GetRootAsISceneInteractionOperationType(ByteBuffer _bb, ISceneInteractionOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060324C3 RID: 206019 RVA: 0x006CB2B5 File Offset: 0x006C94B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060324C4 RID: 206020 RVA: 0x006CB2C4 File Offset: 0x006C94C4
		public ISceneInteractionOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D398 RID: 54168
		// (get) Token: 0x060324C5 RID: 206021 RVA: 0x006CB2D4 File Offset: 0x006C94D4
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

		// Token: 0x060324C6 RID: 206022 RVA: 0x006CB310 File Offset: 0x006C9510
		public static Offset<ISceneInteractionOperationType> CreateISceneInteractionOperationType(FlatBufferBuilder builder, ESceneInteractionOperationType Type = ESceneInteractionOperationType.Enable)
		{
			builder.StartTable(1);
			ISceneInteractionOperationType.AddType(builder, Type);
			return ISceneInteractionOperationType.EndISceneInteractionOperationType(builder);
		}

		// Token: 0x060324C7 RID: 206023 RVA: 0x006CB326 File Offset: 0x006C9526
		public static void StartISceneInteractionOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060324C8 RID: 206024 RVA: 0x006CB32F File Offset: 0x006C952F
		public static void AddType(FlatBufferBuilder builder, ESceneInteractionOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060324C9 RID: 206025 RVA: 0x006CB33A File Offset: 0x006C953A
		public static Offset<ISceneInteractionOperationType> EndISceneInteractionOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneInteractionOperationType>(builder.EndTable());
		}

		// Token: 0x060324CA RID: 206026 RVA: 0x006CB348 File Offset: 0x006C9548
		public ISceneInteractionOperationTypeT UnPack()
		{
			ISceneInteractionOperationTypeT sceneInteractionOperationTypeT = new ISceneInteractionOperationTypeT();
			this.UnPackTo(sceneInteractionOperationTypeT);
			return sceneInteractionOperationTypeT;
		}

		// Token: 0x060324CB RID: 206027 RVA: 0x006CB363 File Offset: 0x006C9563
		public void UnPackTo(ISceneInteractionOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060324CC RID: 206028 RVA: 0x006CB374 File Offset: 0x006C9574
		public static Offset<ISceneInteractionOperationType> Pack(FlatBufferBuilder builder, ISceneInteractionOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneInteractionOperationType>);
			}
			return ISceneInteractionOperationType.CreateISceneInteractionOperationType(builder, _o.Type);
		}

		// Token: 0x04011922 RID: 71970
		private Table __p;
	}
}
