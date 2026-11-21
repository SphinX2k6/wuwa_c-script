using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A10 RID: 18960
	public struct IRollBlockPathNode : IFlatbufferObject
	{
		// Token: 0x170084FE RID: 34046
		// (get) Token: 0x0601C724 RID: 116516 RVA: 0x00404838 File Offset: 0x00402A38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C725 RID: 116517 RVA: 0x00404845 File Offset: 0x00402A45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C726 RID: 116518 RVA: 0x0040484C File Offset: 0x00402A4C
		public static IRollBlockPathNode GetRootAsIRollBlockPathNode(ByteBuffer _bb)
		{
			return IRollBlockPathNode.GetRootAsIRollBlockPathNode(_bb, default(IRollBlockPathNode));
		}

		// Token: 0x0601C727 RID: 116519 RVA: 0x00404868 File Offset: 0x00402A68
		public static IRollBlockPathNode GetRootAsIRollBlockPathNode(ByteBuffer _bb, IRollBlockPathNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C728 RID: 116520 RVA: 0x00404885 File Offset: 0x00402A85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C729 RID: 116521 RVA: 0x00404894 File Offset: 0x00402A94
		public IRollBlockPathNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084FF RID: 34047
		// (get) Token: 0x0601C72A RID: 116522 RVA: 0x004048A4 File Offset: 0x00402AA4
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

		// Token: 0x17008500 RID: 34048
		// (get) Token: 0x0601C72B RID: 116523 RVA: 0x004048E0 File Offset: 0x00402AE0
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

		// Token: 0x0601C72C RID: 116524 RVA: 0x0040491C File Offset: 0x00402B1C
		public static Offset<IRollBlockPathNode> CreateIRollBlockPathNode(FlatBufferBuilder builder, int X = 0, int Y = 0)
		{
			builder.StartTable(2);
			IRollBlockPathNode.AddY(builder, Y);
			IRollBlockPathNode.AddX(builder, X);
			return IRollBlockPathNode.EndIRollBlockPathNode(builder);
		}

		// Token: 0x0601C72D RID: 116525 RVA: 0x00404939 File Offset: 0x00402B39
		public static void StartIRollBlockPathNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C72E RID: 116526 RVA: 0x00404942 File Offset: 0x00402B42
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(0, x, 0);
		}

		// Token: 0x0601C72F RID: 116527 RVA: 0x0040494D File Offset: 0x00402B4D
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(1, y, 0);
		}

		// Token: 0x0601C730 RID: 116528 RVA: 0x00404958 File Offset: 0x00402B58
		public static Offset<IRollBlockPathNode> EndIRollBlockPathNode(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockPathNode>(builder.EndTable());
		}

		// Token: 0x0601C731 RID: 116529 RVA: 0x00404968 File Offset: 0x00402B68
		public IRollBlockPathNodeT UnPack()
		{
			IRollBlockPathNodeT rollBlockPathNodeT = new IRollBlockPathNodeT();
			this.UnPackTo(rollBlockPathNodeT);
			return rollBlockPathNodeT;
		}

		// Token: 0x0601C732 RID: 116530 RVA: 0x00404983 File Offset: 0x00402B83
		public void UnPackTo(IRollBlockPathNodeT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
		}

		// Token: 0x0601C733 RID: 116531 RVA: 0x004049A0 File Offset: 0x00402BA0
		public static Offset<IRollBlockPathNode> Pack(FlatBufferBuilder builder, IRollBlockPathNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockPathNode>);
			}
			return IRollBlockPathNode.CreateIRollBlockPathNode(builder, _o.X, _o.Y);
		}

		// Token: 0x0400D09F RID: 53407
		private Table __p;
	}
}
