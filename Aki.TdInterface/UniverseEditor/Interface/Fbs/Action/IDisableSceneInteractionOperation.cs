using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065EE RID: 26094
	public struct IDisableSceneInteractionOperation : IFlatbufferObject
	{
		// Token: 0x1700C1D6 RID: 49622
		// (get) Token: 0x0602D4A5 RID: 185509 RVA: 0x00635263 File Offset: 0x00633463
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D4A6 RID: 185510 RVA: 0x00635270 File Offset: 0x00633470
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D4A7 RID: 185511 RVA: 0x00635278 File Offset: 0x00633478
		public static IDisableSceneInteractionOperation GetRootAsIDisableSceneInteractionOperation(ByteBuffer _bb)
		{
			return IDisableSceneInteractionOperation.GetRootAsIDisableSceneInteractionOperation(_bb, default(IDisableSceneInteractionOperation));
		}

		// Token: 0x0602D4A8 RID: 185512 RVA: 0x00635294 File Offset: 0x00633494
		public static IDisableSceneInteractionOperation GetRootAsIDisableSceneInteractionOperation(ByteBuffer _bb, IDisableSceneInteractionOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D4A9 RID: 185513 RVA: 0x006352B1 File Offset: 0x006334B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D4AA RID: 185514 RVA: 0x006352C0 File Offset: 0x006334C0
		public IDisableSceneInteractionOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1D7 RID: 49623
		// (get) Token: 0x0602D4AB RID: 185515 RVA: 0x006352D0 File Offset: 0x006334D0
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

		// Token: 0x0602D4AC RID: 185516 RVA: 0x0063530C File Offset: 0x0063350C
		public static Offset<IDisableSceneInteractionOperation> CreateIDisableSceneInteractionOperation(FlatBufferBuilder builder, ESceneInteractionOperationType Type = ESceneInteractionOperationType.Enable)
		{
			builder.StartTable(1);
			IDisableSceneInteractionOperation.AddType(builder, Type);
			return IDisableSceneInteractionOperation.EndIDisableSceneInteractionOperation(builder);
		}

		// Token: 0x0602D4AD RID: 185517 RVA: 0x00635322 File Offset: 0x00633522
		public static void StartIDisableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D4AE RID: 185518 RVA: 0x0063532B File Offset: 0x0063352B
		public static void AddType(FlatBufferBuilder builder, ESceneInteractionOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D4AF RID: 185519 RVA: 0x00635336 File Offset: 0x00633536
		public static Offset<IDisableSceneInteractionOperation> EndIDisableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableSceneInteractionOperation>(builder.EndTable());
		}

		// Token: 0x0602D4B0 RID: 185520 RVA: 0x00635344 File Offset: 0x00633544
		public IDisableSceneInteractionOperationT UnPack()
		{
			IDisableSceneInteractionOperationT disableSceneInteractionOperationT = new IDisableSceneInteractionOperationT();
			this.UnPackTo(disableSceneInteractionOperationT);
			return disableSceneInteractionOperationT;
		}

		// Token: 0x0602D4B1 RID: 185521 RVA: 0x0063535F File Offset: 0x0063355F
		public void UnPackTo(IDisableSceneInteractionOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D4B2 RID: 185522 RVA: 0x00635370 File Offset: 0x00633570
		public static Offset<IDisableSceneInteractionOperation> Pack(FlatBufferBuilder builder, IDisableSceneInteractionOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableSceneInteractionOperation>);
			}
			return IDisableSceneInteractionOperation.CreateIDisableSceneInteractionOperation(builder, _o.Type);
		}

		// Token: 0x04010C6B RID: 68715
		private Table __p;
	}
}
