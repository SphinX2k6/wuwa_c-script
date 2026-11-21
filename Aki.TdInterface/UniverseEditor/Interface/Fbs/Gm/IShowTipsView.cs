using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B04 RID: 19204
	public struct IShowTipsView : IFlatbufferObject
	{
		// Token: 0x1700869C RID: 34460
		// (get) Token: 0x0601CF14 RID: 118548 RVA: 0x00412476 File Offset: 0x00410676
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF15 RID: 118549 RVA: 0x00412483 File Offset: 0x00410683
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF16 RID: 118550 RVA: 0x0041248C File Offset: 0x0041068C
		public static IShowTipsView GetRootAsIShowTipsView(ByteBuffer _bb)
		{
			return IShowTipsView.GetRootAsIShowTipsView(_bb, default(IShowTipsView));
		}

		// Token: 0x0601CF17 RID: 118551 RVA: 0x004124A8 File Offset: 0x004106A8
		public static IShowTipsView GetRootAsIShowTipsView(ByteBuffer _bb, IShowTipsView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF18 RID: 118552 RVA: 0x004124C5 File Offset: 0x004106C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF19 RID: 118553 RVA: 0x004124D4 File Offset: 0x004106D4
		public IShowTipsView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700869D RID: 34461
		// (get) Token: 0x0601CF1A RID: 118554 RVA: 0x004124E4 File Offset: 0x004106E4
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

		// Token: 0x1700869E RID: 34462
		// (get) Token: 0x0601CF1B RID: 118555 RVA: 0x00412520 File Offset: 0x00410720
		public bool IsShield
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CF1C RID: 118556 RVA: 0x0041255F File Offset: 0x0041075F
		public static Offset<IShowTipsView> CreateIShowTipsView(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, bool IsShield = false)
		{
			builder.StartTable(2);
			IShowTipsView.AddIsShield(builder, IsShield);
			IShowTipsView.AddType(builder, Type);
			return IShowTipsView.EndIShowTipsView(builder);
		}

		// Token: 0x0601CF1D RID: 118557 RVA: 0x0041257C File Offset: 0x0041077C
		public static void StartIShowTipsView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CF1E RID: 118558 RVA: 0x00412585 File Offset: 0x00410785
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF1F RID: 118559 RVA: 0x00412590 File Offset: 0x00410790
		public static void AddIsShield(FlatBufferBuilder builder, bool isShield)
		{
			builder.AddBool(1, isShield, false);
		}

		// Token: 0x0601CF20 RID: 118560 RVA: 0x0041259B File Offset: 0x0041079B
		public static Offset<IShowTipsView> EndIShowTipsView(FlatBufferBuilder builder)
		{
			return new Offset<IShowTipsView>(builder.EndTable());
		}

		// Token: 0x0601CF21 RID: 118561 RVA: 0x004125A8 File Offset: 0x004107A8
		public IShowTipsViewT UnPack()
		{
			IShowTipsViewT showTipsViewT = new IShowTipsViewT();
			this.UnPackTo(showTipsViewT);
			return showTipsViewT;
		}

		// Token: 0x0601CF22 RID: 118562 RVA: 0x004125C3 File Offset: 0x004107C3
		public void UnPackTo(IShowTipsViewT _o)
		{
			_o.Type = this.Type;
			_o.IsShield = this.IsShield;
		}

		// Token: 0x0601CF23 RID: 118563 RVA: 0x004125E0 File Offset: 0x004107E0
		public static Offset<IShowTipsView> Pack(FlatBufferBuilder builder, IShowTipsViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTipsView>);
			}
			return IShowTipsView.CreateIShowTipsView(builder, _o.Type, _o.IsShield);
		}

		// Token: 0x0400D290 RID: 53904
		private Table __p;
	}
}
