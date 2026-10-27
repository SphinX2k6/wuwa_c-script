using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200459C RID: 17820
	public struct IRollBlockItemQuantumObstacle : IFlatbufferObject
	{
		// Token: 0x17007E9C RID: 32412
		// (get) Token: 0x0601AEC7 RID: 110279 RVA: 0x003D73C0 File Offset: 0x003D55C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AEC8 RID: 110280 RVA: 0x003D73CD File Offset: 0x003D55CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AEC9 RID: 110281 RVA: 0x003D73D4 File Offset: 0x003D55D4
		public static IRollBlockItemQuantumObstacle GetRootAsIRollBlockItemQuantumObstacle(ByteBuffer _bb)
		{
			return IRollBlockItemQuantumObstacle.GetRootAsIRollBlockItemQuantumObstacle(_bb, default(IRollBlockItemQuantumObstacle));
		}

		// Token: 0x0601AECA RID: 110282 RVA: 0x003D73F0 File Offset: 0x003D55F0
		public static IRollBlockItemQuantumObstacle GetRootAsIRollBlockItemQuantumObstacle(ByteBuffer _bb, IRollBlockItemQuantumObstacle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AECB RID: 110283 RVA: 0x003D740D File Offset: 0x003D560D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AECC RID: 110284 RVA: 0x003D741C File Offset: 0x003D561C
		public IRollBlockItemQuantumObstacle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E9D RID: 32413
		// (get) Token: 0x0601AECD RID: 110285 RVA: 0x003D742C File Offset: 0x003D562C
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

		// Token: 0x17007E9E RID: 32414
		// (get) Token: 0x0601AECE RID: 110286 RVA: 0x003D7468 File Offset: 0x003D5668
		public bool InitActive
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601AECF RID: 110287 RVA: 0x003D74A7 File Offset: 0x003D56A7
		public static Offset<IRollBlockItemQuantumObstacle> CreateIRollBlockItemQuantumObstacle(FlatBufferBuilder builder, ERollBlockItemType Type = ERollBlockItemType.BreakableObstacle, bool InitActive = false)
		{
			builder.StartTable(2);
			IRollBlockItemQuantumObstacle.AddInitActive(builder, InitActive);
			IRollBlockItemQuantumObstacle.AddType(builder, Type);
			return IRollBlockItemQuantumObstacle.EndIRollBlockItemQuantumObstacle(builder);
		}

		// Token: 0x0601AED0 RID: 110288 RVA: 0x003D74C4 File Offset: 0x003D56C4
		public static void StartIRollBlockItemQuantumObstacle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AED1 RID: 110289 RVA: 0x003D74CD File Offset: 0x003D56CD
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AED2 RID: 110290 RVA: 0x003D74D8 File Offset: 0x003D56D8
		public static void AddInitActive(FlatBufferBuilder builder, bool initActive)
		{
			builder.AddBool(1, initActive, false);
		}

		// Token: 0x0601AED3 RID: 110291 RVA: 0x003D74E3 File Offset: 0x003D56E3
		public static Offset<IRollBlockItemQuantumObstacle> EndIRollBlockItemQuantumObstacle(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemQuantumObstacle>(builder.EndTable());
		}

		// Token: 0x0601AED4 RID: 110292 RVA: 0x003D74F0 File Offset: 0x003D56F0
		public IRollBlockItemQuantumObstacleT UnPack()
		{
			IRollBlockItemQuantumObstacleT rollBlockItemQuantumObstacleT = new IRollBlockItemQuantumObstacleT();
			this.UnPackTo(rollBlockItemQuantumObstacleT);
			return rollBlockItemQuantumObstacleT;
		}

		// Token: 0x0601AED5 RID: 110293 RVA: 0x003D750B File Offset: 0x003D570B
		public void UnPackTo(IRollBlockItemQuantumObstacleT _o)
		{
			_o.Type = this.Type;
			_o.InitActive = this.InitActive;
		}

		// Token: 0x0601AED6 RID: 110294 RVA: 0x003D7528 File Offset: 0x003D5728
		public static Offset<IRollBlockItemQuantumObstacle> Pack(FlatBufferBuilder builder, IRollBlockItemQuantumObstacleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemQuantumObstacle>);
			}
			return IRollBlockItemQuantumObstacle.CreateIRollBlockItemQuantumObstacle(builder, _o.Type, _o.InitActive);
		}

		// Token: 0x0400C65E RID: 50782
		private Table __p;
	}
}
