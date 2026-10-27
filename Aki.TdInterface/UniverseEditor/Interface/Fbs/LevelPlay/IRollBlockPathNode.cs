using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A8 RID: 17832
	public struct IRollBlockPathNode : IFlatbufferObject
	{
		// Token: 0x17007EBD RID: 32445
		// (get) Token: 0x0601AF4F RID: 110415 RVA: 0x003D859C File Offset: 0x003D679C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AF50 RID: 110416 RVA: 0x003D85A9 File Offset: 0x003D67A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AF51 RID: 110417 RVA: 0x003D85B0 File Offset: 0x003D67B0
		public static IRollBlockPathNode GetRootAsIRollBlockPathNode(ByteBuffer _bb)
		{
			return IRollBlockPathNode.GetRootAsIRollBlockPathNode(_bb, default(IRollBlockPathNode));
		}

		// Token: 0x0601AF52 RID: 110418 RVA: 0x003D85CC File Offset: 0x003D67CC
		public static IRollBlockPathNode GetRootAsIRollBlockPathNode(ByteBuffer _bb, IRollBlockPathNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AF53 RID: 110419 RVA: 0x003D85E9 File Offset: 0x003D67E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AF54 RID: 110420 RVA: 0x003D85F8 File Offset: 0x003D67F8
		public IRollBlockPathNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EBE RID: 32446
		// (get) Token: 0x0601AF55 RID: 110421 RVA: 0x003D8608 File Offset: 0x003D6808
		public int X
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

		// Token: 0x17007EBF RID: 32447
		// (get) Token: 0x0601AF56 RID: 110422 RVA: 0x003D8644 File Offset: 0x003D6844
		public int Y
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AF57 RID: 110423 RVA: 0x003D8680 File Offset: 0x003D6880
		public static Offset<IRollBlockPathNode> CreateIRollBlockPathNode(FlatBufferBuilder builder, int X = 0, int Y = 0)
		{
			builder.StartTable(2);
			IRollBlockPathNode.AddY(builder, Y);
			IRollBlockPathNode.AddX(builder, X);
			return IRollBlockPathNode.EndIRollBlockPathNode(builder);
		}

		// Token: 0x0601AF58 RID: 110424 RVA: 0x003D869D File Offset: 0x003D689D
		public static void StartIRollBlockPathNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AF59 RID: 110425 RVA: 0x003D86A6 File Offset: 0x003D68A6
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(0, x, 0);
		}

		// Token: 0x0601AF5A RID: 110426 RVA: 0x003D86B1 File Offset: 0x003D68B1
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(1, y, 0);
		}

		// Token: 0x0601AF5B RID: 110427 RVA: 0x003D86BC File Offset: 0x003D68BC
		public static Offset<IRollBlockPathNode> EndIRollBlockPathNode(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockPathNode>(builder.EndTable());
		}

		// Token: 0x0601AF5C RID: 110428 RVA: 0x003D86CC File Offset: 0x003D68CC
		public IRollBlockPathNodeT UnPack()
		{
			IRollBlockPathNodeT rollBlockPathNodeT = new IRollBlockPathNodeT();
			this.UnPackTo(rollBlockPathNodeT);
			return rollBlockPathNodeT;
		}

		// Token: 0x0601AF5D RID: 110429 RVA: 0x003D86E7 File Offset: 0x003D68E7
		public void UnPackTo(IRollBlockPathNodeT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
		}

		// Token: 0x0601AF5E RID: 110430 RVA: 0x003D8704 File Offset: 0x003D6904
		public static Offset<IRollBlockPathNode> Pack(FlatBufferBuilder builder, IRollBlockPathNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockPathNode>);
			}
			return IRollBlockPathNode.CreateIRollBlockPathNode(builder, _o.X, _o.Y);
		}

		// Token: 0x0400C670 RID: 50800
		private Table __p;
	}
}
