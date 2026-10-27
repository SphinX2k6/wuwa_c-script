using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B7A RID: 19322
	public struct IClientEventTarget : IFlatbufferObject
	{
		// Token: 0x17008C39 RID: 35897
		// (get) Token: 0x0601E731 RID: 124721 RVA: 0x00443846 File Offset: 0x00441A46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E732 RID: 124722 RVA: 0x00443853 File Offset: 0x00441A53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E733 RID: 124723 RVA: 0x0044385C File Offset: 0x00441A5C
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb)
		{
			return IClientEventTarget.GetRootAsIClientEventTarget(_bb, default(IClientEventTarget));
		}

		// Token: 0x0601E734 RID: 124724 RVA: 0x00443878 File Offset: 0x00441A78
		public static IClientEventTarget GetRootAsIClientEventTarget(ByteBuffer _bb, IClientEventTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E735 RID: 124725 RVA: 0x00443895 File Offset: 0x00441A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E736 RID: 124726 RVA: 0x004438A4 File Offset: 0x00441AA4
		public IClientEventTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C3A RID: 35898
		// (get) Token: 0x0601E737 RID: 124727 RVA: 0x004438B4 File Offset: 0x00441AB4
		public EClientEventTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventTarget.Self;
				}
				return (EClientEventTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E738 RID: 124728 RVA: 0x004438F0 File Offset: 0x00441AF0
		public static Offset<IClientEventTarget> CreateIClientEventTarget(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			IClientEventTarget.AddType(builder, Type);
			return IClientEventTarget.EndIClientEventTarget(builder);
		}

		// Token: 0x0601E739 RID: 124729 RVA: 0x00443906 File Offset: 0x00441B06
		public static void StartIClientEventTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E73A RID: 124730 RVA: 0x0044390F File Offset: 0x00441B0F
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E73B RID: 124731 RVA: 0x0044391A File Offset: 0x00441B1A
		public static Offset<IClientEventTarget> EndIClientEventTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventTarget>(builder.EndTable());
		}

		// Token: 0x0601E73C RID: 124732 RVA: 0x00443928 File Offset: 0x00441B28
		public IClientEventTargetT UnPack()
		{
			IClientEventTargetT clientEventTargetT = new IClientEventTargetT();
			this.UnPackTo(clientEventTargetT);
			return clientEventTargetT;
		}

		// Token: 0x0601E73D RID: 124733 RVA: 0x00443943 File Offset: 0x00441B43
		public void UnPackTo(IClientEventTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E73E RID: 124734 RVA: 0x00443954 File Offset: 0x00441B54
		public static Offset<IClientEventTarget> Pack(FlatBufferBuilder builder, IClientEventTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventTarget>);
			}
			return IClientEventTarget.CreateIClientEventTarget(builder, _o.Type);
		}

		// Token: 0x0400D446 RID: 54342
		private Table __p;
	}
}
