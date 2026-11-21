using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A04 RID: 18948
	public struct IRollBlockItemQuantumObstacle : IFlatbufferObject
	{
		// Token: 0x170084DD RID: 34013
		// (get) Token: 0x0601C69C RID: 116380 RVA: 0x0040365C File Offset: 0x0040185C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C69D RID: 116381 RVA: 0x00403669 File Offset: 0x00401869
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C69E RID: 116382 RVA: 0x00403670 File Offset: 0x00401870
		public static IRollBlockItemQuantumObstacle GetRootAsIRollBlockItemQuantumObstacle(ByteBuffer _bb)
		{
			return IRollBlockItemQuantumObstacle.GetRootAsIRollBlockItemQuantumObstacle(_bb, default(IRollBlockItemQuantumObstacle));
		}

		// Token: 0x0601C69F RID: 116383 RVA: 0x0040368C File Offset: 0x0040188C
		public static IRollBlockItemQuantumObstacle GetRootAsIRollBlockItemQuantumObstacle(ByteBuffer _bb, IRollBlockItemQuantumObstacle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C6A0 RID: 116384 RVA: 0x004036A9 File Offset: 0x004018A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C6A1 RID: 116385 RVA: 0x004036B8 File Offset: 0x004018B8
		public IRollBlockItemQuantumObstacle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084DE RID: 34014
		// (get) Token: 0x0601C6A2 RID: 116386 RVA: 0x004036C8 File Offset: 0x004018C8
		public ERollBlockItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockItemType.BreakableObstacle;
				}
				return (ERollBlockItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170084DF RID: 34015
		// (get) Token: 0x0601C6A3 RID: 116387 RVA: 0x00403704 File Offset: 0x00401904
		public bool InitActive
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601C6A4 RID: 116388 RVA: 0x00403743 File Offset: 0x00401943
		public static Offset<IRollBlockItemQuantumObstacle> CreateIRollBlockItemQuantumObstacle(FlatBufferBuilder builder, ERollBlockItemType Type = ERollBlockItemType.BreakableObstacle, bool InitActive = false)
		{
			builder.StartTable(2);
			IRollBlockItemQuantumObstacle.AddInitActive(builder, InitActive);
			IRollBlockItemQuantumObstacle.AddType(builder, Type);
			return IRollBlockItemQuantumObstacle.EndIRollBlockItemQuantumObstacle(builder);
		}

		// Token: 0x0601C6A5 RID: 116389 RVA: 0x00403760 File Offset: 0x00401960
		public static void StartIRollBlockItemQuantumObstacle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C6A6 RID: 116390 RVA: 0x00403769 File Offset: 0x00401969
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C6A7 RID: 116391 RVA: 0x00403774 File Offset: 0x00401974
		public static void AddInitActive(FlatBufferBuilder builder, bool initActive)
		{
			builder.AddBool(1, initActive, false);
		}

		// Token: 0x0601C6A8 RID: 116392 RVA: 0x0040377F File Offset: 0x0040197F
		public static Offset<IRollBlockItemQuantumObstacle> EndIRollBlockItemQuantumObstacle(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemQuantumObstacle>(builder.EndTable());
		}

		// Token: 0x0601C6A9 RID: 116393 RVA: 0x0040378C File Offset: 0x0040198C
		public IRollBlockItemQuantumObstacleT UnPack()
		{
			IRollBlockItemQuantumObstacleT rollBlockItemQuantumObstacleT = new IRollBlockItemQuantumObstacleT();
			this.UnPackTo(rollBlockItemQuantumObstacleT);
			return rollBlockItemQuantumObstacleT;
		}

		// Token: 0x0601C6AA RID: 116394 RVA: 0x004037A7 File Offset: 0x004019A7
		public void UnPackTo(IRollBlockItemQuantumObstacleT _o)
		{
			_o.Type = this.Type;
			_o.InitActive = this.InitActive;
		}

		// Token: 0x0601C6AB RID: 116395 RVA: 0x004037C4 File Offset: 0x004019C4
		public static Offset<IRollBlockItemQuantumObstacle> Pack(FlatBufferBuilder builder, IRollBlockItemQuantumObstacleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemQuantumObstacle>);
			}
			return IRollBlockItemQuantumObstacle.CreateIRollBlockItemQuantumObstacle(builder, _o.Type, _o.InitActive);
		}

		// Token: 0x0400D08D RID: 53389
		private Table __p;
	}
}
