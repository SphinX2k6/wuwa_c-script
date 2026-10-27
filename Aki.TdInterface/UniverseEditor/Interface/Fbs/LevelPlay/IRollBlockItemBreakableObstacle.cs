using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004596 RID: 17814
	public struct IRollBlockItemBreakableObstacle : IFlatbufferObject
	{
		// Token: 0x17007E8A RID: 32394
		// (get) Token: 0x0601AE8B RID: 110219 RVA: 0x003D6CFE File Offset: 0x003D4EFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AE8C RID: 110220 RVA: 0x003D6D0B File Offset: 0x003D4F0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AE8D RID: 110221 RVA: 0x003D6D14 File Offset: 0x003D4F14
		public static IRollBlockItemBreakableObstacle GetRootAsIRollBlockItemBreakableObstacle(ByteBuffer _bb)
		{
			return IRollBlockItemBreakableObstacle.GetRootAsIRollBlockItemBreakableObstacle(_bb, default(IRollBlockItemBreakableObstacle));
		}

		// Token: 0x0601AE8E RID: 110222 RVA: 0x003D6D30 File Offset: 0x003D4F30
		public static IRollBlockItemBreakableObstacle GetRootAsIRollBlockItemBreakableObstacle(ByteBuffer _bb, IRollBlockItemBreakableObstacle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AE8F RID: 110223 RVA: 0x003D6D4D File Offset: 0x003D4F4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AE90 RID: 110224 RVA: 0x003D6D5C File Offset: 0x003D4F5C
		public IRollBlockItemBreakableObstacle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E8B RID: 32395
		// (get) Token: 0x0601AE91 RID: 110225 RVA: 0x003D6D6C File Offset: 0x003D4F6C
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

		// Token: 0x17007E8C RID: 32396
		// (get) Token: 0x0601AE92 RID: 110226 RVA: 0x003D6DA8 File Offset: 0x003D4FA8
		public int Key
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

		// Token: 0x17007E8D RID: 32397
		// (get) Token: 0x0601AE93 RID: 110227 RVA: 0x003D6DE4 File Offset: 0x003D4FE4
		public IRollBlockPath? Path
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IRollBlockPath?(default(IRollBlockPath).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601AE94 RID: 110228 RVA: 0x003D6E41 File Offset: 0x003D5041
		public static Offset<IRollBlockItemBreakableObstacle> CreateIRollBlockItemBreakableObstacle(FlatBufferBuilder builder, ERollBlockItemType Type = ERollBlockItemType.BreakableObstacle, int Key = 0, Offset<IRollBlockPath> PathOffset = default(Offset<IRollBlockPath>))
		{
			builder.StartTable(3);
			IRollBlockItemBreakableObstacle.AddPath(builder, PathOffset);
			IRollBlockItemBreakableObstacle.AddKey(builder, Key);
			IRollBlockItemBreakableObstacle.AddType(builder, Type);
			return IRollBlockItemBreakableObstacle.EndIRollBlockItemBreakableObstacle(builder);
		}

		// Token: 0x0601AE95 RID: 110229 RVA: 0x003D6E65 File Offset: 0x003D5065
		public static void StartIRollBlockItemBreakableObstacle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601AE96 RID: 110230 RVA: 0x003D6E6E File Offset: 0x003D506E
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AE97 RID: 110231 RVA: 0x003D6E79 File Offset: 0x003D5079
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(1, key, 0);
		}

		// Token: 0x0601AE98 RID: 110232 RVA: 0x003D6E84 File Offset: 0x003D5084
		public static void AddPath(FlatBufferBuilder builder, Offset<IRollBlockPath> pathOffset)
		{
			builder.AddOffset(2, pathOffset.Value, 0);
		}

		// Token: 0x0601AE99 RID: 110233 RVA: 0x003D6E94 File Offset: 0x003D5094
		public static Offset<IRollBlockItemBreakableObstacle> EndIRollBlockItemBreakableObstacle(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemBreakableObstacle>(builder.EndTable());
		}

		// Token: 0x0601AE9A RID: 110234 RVA: 0x003D6EA4 File Offset: 0x003D50A4
		public IRollBlockItemBreakableObstacleT UnPack()
		{
			IRollBlockItemBreakableObstacleT rollBlockItemBreakableObstacleT = new IRollBlockItemBreakableObstacleT();
			this.UnPackTo(rollBlockItemBreakableObstacleT);
			return rollBlockItemBreakableObstacleT;
		}

		// Token: 0x0601AE9B RID: 110235 RVA: 0x003D6EC0 File Offset: 0x003D50C0
		public void UnPackTo(IRollBlockItemBreakableObstacleT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Path = ((this.Path != null) ? this.Path.Value.UnPack() : null);
		}

		// Token: 0x0601AE9C RID: 110236 RVA: 0x003D6F14 File Offset: 0x003D5114
		public static Offset<IRollBlockItemBreakableObstacle> Pack(FlatBufferBuilder builder, IRollBlockItemBreakableObstacleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemBreakableObstacle>);
			}
			Offset<IRollBlockPath> pathOffset = (_o.Path == null) ? default(Offset<IRollBlockPath>) : IRollBlockPath.Pack(builder, _o.Path);
			return IRollBlockItemBreakableObstacle.CreateIRollBlockItemBreakableObstacle(builder, _o.Type, _o.Key, pathOffset);
		}

		// Token: 0x0400C654 RID: 50772
		private Table __p;
	}
}
