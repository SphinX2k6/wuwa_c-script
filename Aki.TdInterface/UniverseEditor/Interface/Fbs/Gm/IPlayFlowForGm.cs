using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE6 RID: 19174
	public struct IPlayFlowForGm : IFlatbufferObject
	{
		// Token: 0x17008666 RID: 34406
		// (get) Token: 0x0601CE2C RID: 118316 RVA: 0x00410E36 File Offset: 0x0040F036
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE2D RID: 118317 RVA: 0x00410E43 File Offset: 0x0040F043
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE2E RID: 118318 RVA: 0x00410E4C File Offset: 0x0040F04C
		public static IPlayFlowForGm GetRootAsIPlayFlowForGm(ByteBuffer _bb)
		{
			return IPlayFlowForGm.GetRootAsIPlayFlowForGm(_bb, default(IPlayFlowForGm));
		}

		// Token: 0x0601CE2F RID: 118319 RVA: 0x00410E68 File Offset: 0x0040F068
		public static IPlayFlowForGm GetRootAsIPlayFlowForGm(ByteBuffer _bb, IPlayFlowForGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE30 RID: 118320 RVA: 0x00410E85 File Offset: 0x0040F085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE31 RID: 118321 RVA: 0x00410E94 File Offset: 0x0040F094
		public IPlayFlowForGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008667 RID: 34407
		// (get) Token: 0x0601CE32 RID: 118322 RVA: 0x00410EA4 File Offset: 0x0040F0A4
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008668 RID: 34408
		// (get) Token: 0x0601CE33 RID: 118323 RVA: 0x00410EE0 File Offset: 0x0040F0E0
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601CE34 RID: 118324 RVA: 0x00410F3D File Offset: 0x0040F13D
		public static Offset<IPlayFlowForGm> CreateIPlayFlowForGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IPlayFlowForGm.AddFlow(builder, FlowOffset);
			IPlayFlowForGm.AddType(builder, Type);
			return IPlayFlowForGm.EndIPlayFlowForGm(builder);
		}

		// Token: 0x0601CE35 RID: 118325 RVA: 0x00410F5A File Offset: 0x0040F15A
		public static void StartIPlayFlowForGm(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CE36 RID: 118326 RVA: 0x00410F63 File Offset: 0x0040F163
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE37 RID: 118327 RVA: 0x00410F6E File Offset: 0x0040F16E
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0601CE38 RID: 118328 RVA: 0x00410F7E File Offset: 0x0040F17E
		public static Offset<IPlayFlowForGm> EndIPlayFlowForGm(FlatBufferBuilder builder)
		{
			return new Offset<IPlayFlowForGm>(builder.EndTable());
		}

		// Token: 0x0601CE39 RID: 118329 RVA: 0x00410F8C File Offset: 0x0040F18C
		public IPlayFlowForGmT UnPack()
		{
			IPlayFlowForGmT playFlowForGmT = new IPlayFlowForGmT();
			this.UnPackTo(playFlowForGmT);
			return playFlowForGmT;
		}

		// Token: 0x0601CE3A RID: 118330 RVA: 0x00410FA8 File Offset: 0x0040F1A8
		public void UnPackTo(IPlayFlowForGmT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x0601CE3B RID: 118331 RVA: 0x00410FF0 File Offset: 0x0040F1F0
		public static Offset<IPlayFlowForGm> Pack(FlatBufferBuilder builder, IPlayFlowForGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayFlowForGm>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IPlayFlowForGm.CreateIPlayFlowForGm(builder, _o.Type, flowOffset);
		}

		// Token: 0x0400D270 RID: 53872
		private Table __p;
	}
}
