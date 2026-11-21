using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5F RID: 27743
	public struct IDisableSceneInteractionOperation : IFlatbufferObject
	{
		// Token: 0x1700CB74 RID: 52084
		// (get) Token: 0x0602FC76 RID: 195702 RVA: 0x00681DC9 File Offset: 0x0067FFC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC77 RID: 195703 RVA: 0x00681DD6 File Offset: 0x0067FFD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC78 RID: 195704 RVA: 0x00681DE0 File Offset: 0x0067FFE0
		public static IDisableSceneInteractionOperation GetRootAsIDisableSceneInteractionOperation(ByteBuffer _bb)
		{
			return IDisableSceneInteractionOperation.GetRootAsIDisableSceneInteractionOperation(_bb, default(IDisableSceneInteractionOperation));
		}

		// Token: 0x0602FC79 RID: 195705 RVA: 0x00681DFC File Offset: 0x0067FFFC
		public static IDisableSceneInteractionOperation GetRootAsIDisableSceneInteractionOperation(ByteBuffer _bb, IDisableSceneInteractionOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC7A RID: 195706 RVA: 0x00681E19 File Offset: 0x00680019
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC7B RID: 195707 RVA: 0x00681E28 File Offset: 0x00680028
		public IDisableSceneInteractionOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB75 RID: 52085
		// (get) Token: 0x0602FC7C RID: 195708 RVA: 0x00681E38 File Offset: 0x00680038
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

		// Token: 0x0602FC7D RID: 195709 RVA: 0x00681E74 File Offset: 0x00680074
		public static Offset<IDisableSceneInteractionOperation> CreateIDisableSceneInteractionOperation(FlatBufferBuilder builder, ESceneInteractionOperationType Type = ESceneInteractionOperationType.Enable)
		{
			builder.StartTable(1);
			IDisableSceneInteractionOperation.AddType(builder, Type);
			return IDisableSceneInteractionOperation.EndIDisableSceneInteractionOperation(builder);
		}

		// Token: 0x0602FC7E RID: 195710 RVA: 0x00681E8A File Offset: 0x0068008A
		public static void StartIDisableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FC7F RID: 195711 RVA: 0x00681E93 File Offset: 0x00680093
		public static void AddType(FlatBufferBuilder builder, ESceneInteractionOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FC80 RID: 195712 RVA: 0x00681E9E File Offset: 0x0068009E
		public static Offset<IDisableSceneInteractionOperation> EndIDisableSceneInteractionOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableSceneInteractionOperation>(builder.EndTable());
		}

		// Token: 0x0602FC81 RID: 195713 RVA: 0x00681EAC File Offset: 0x006800AC
		public IDisableSceneInteractionOperationT UnPack()
		{
			IDisableSceneInteractionOperationT disableSceneInteractionOperationT = new IDisableSceneInteractionOperationT();
			this.UnPackTo(disableSceneInteractionOperationT);
			return disableSceneInteractionOperationT;
		}

		// Token: 0x0602FC82 RID: 195714 RVA: 0x00681EC7 File Offset: 0x006800C7
		public void UnPackTo(IDisableSceneInteractionOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FC83 RID: 195715 RVA: 0x00681ED8 File Offset: 0x006800D8
		public static Offset<IDisableSceneInteractionOperation> Pack(FlatBufferBuilder builder, IDisableSceneInteractionOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableSceneInteractionOperation>);
			}
			return IDisableSceneInteractionOperation.CreateIDisableSceneInteractionOperation(builder, _o.Type);
		}

		// Token: 0x04011A86 RID: 72326
		private Table __p;
	}
}
