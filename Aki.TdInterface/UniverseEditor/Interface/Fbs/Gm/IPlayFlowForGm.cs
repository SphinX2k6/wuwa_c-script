using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200467E RID: 18046
	public struct IPlayFlowForGm : IFlatbufferObject
	{
		// Token: 0x17008025 RID: 32805
		// (get) Token: 0x0601B657 RID: 112215 RVA: 0x003E4B9A File Offset: 0x003E2D9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B658 RID: 112216 RVA: 0x003E4BA7 File Offset: 0x003E2DA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B659 RID: 112217 RVA: 0x003E4BB0 File Offset: 0x003E2DB0
		public static IPlayFlowForGm GetRootAsIPlayFlowForGm(ByteBuffer _bb)
		{
			return IPlayFlowForGm.GetRootAsIPlayFlowForGm(_bb, default(IPlayFlowForGm));
		}

		// Token: 0x0601B65A RID: 112218 RVA: 0x003E4BCC File Offset: 0x003E2DCC
		public static IPlayFlowForGm GetRootAsIPlayFlowForGm(ByteBuffer _bb, IPlayFlowForGm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B65B RID: 112219 RVA: 0x003E4BE9 File Offset: 0x003E2DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B65C RID: 112220 RVA: 0x003E4BF8 File Offset: 0x003E2DF8
		public IPlayFlowForGm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008026 RID: 32806
		// (get) Token: 0x0601B65D RID: 112221 RVA: 0x003E4C08 File Offset: 0x003E2E08
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

		// Token: 0x17008027 RID: 32807
		// (get) Token: 0x0601B65E RID: 112222 RVA: 0x003E4C44 File Offset: 0x003E2E44
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

		// Token: 0x0601B65F RID: 112223 RVA: 0x003E4CA1 File Offset: 0x003E2EA1
		public static Offset<IPlayFlowForGm> CreateIPlayFlowForGm(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IPlayFlowForGm.AddFlow(builder, FlowOffset);
			IPlayFlowForGm.AddType(builder, Type);
			return IPlayFlowForGm.EndIPlayFlowForGm(builder);
		}

		// Token: 0x0601B660 RID: 112224 RVA: 0x003E4CBE File Offset: 0x003E2EBE
		public static void StartIPlayFlowForGm(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B661 RID: 112225 RVA: 0x003E4CC7 File Offset: 0x003E2EC7
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B662 RID: 112226 RVA: 0x003E4CD2 File Offset: 0x003E2ED2
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x0601B663 RID: 112227 RVA: 0x003E4CE2 File Offset: 0x003E2EE2
		public static Offset<IPlayFlowForGm> EndIPlayFlowForGm(FlatBufferBuilder builder)
		{
			return new Offset<IPlayFlowForGm>(builder.EndTable());
		}

		// Token: 0x0601B664 RID: 112228 RVA: 0x003E4CF0 File Offset: 0x003E2EF0
		public IPlayFlowForGmT UnPack()
		{
			IPlayFlowForGmT playFlowForGmT = new IPlayFlowForGmT();
			this.UnPackTo(playFlowForGmT);
			return playFlowForGmT;
		}

		// Token: 0x0601B665 RID: 112229 RVA: 0x003E4D0C File Offset: 0x003E2F0C
		public void UnPackTo(IPlayFlowForGmT _o)
		{
			_o.Type = this.Type;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x0601B666 RID: 112230 RVA: 0x003E4D54 File Offset: 0x003E2F54
		public static Offset<IPlayFlowForGm> Pack(FlatBufferBuilder builder, IPlayFlowForGmT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayFlowForGm>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IPlayFlowForGm.CreateIPlayFlowForGm(builder, _o.Type, flowOffset);
		}

		// Token: 0x0400C841 RID: 51265
		private Table __p;
	}
}
