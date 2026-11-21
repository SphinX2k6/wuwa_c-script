using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004938 RID: 18744
	public struct IHitNoScoreResult : IFlatbufferObject
	{
		// Token: 0x17008295 RID: 33429
		// (get) Token: 0x0601BD13 RID: 113939 RVA: 0x003EE5DE File Offset: 0x003EC7DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD14 RID: 113940 RVA: 0x003EE5EB File Offset: 0x003EC7EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD15 RID: 113941 RVA: 0x003EE5F4 File Offset: 0x003EC7F4
		public static IHitNoScoreResult GetRootAsIHitNoScoreResult(ByteBuffer _bb)
		{
			return IHitNoScoreResult.GetRootAsIHitNoScoreResult(_bb, default(IHitNoScoreResult));
		}

		// Token: 0x0601BD16 RID: 113942 RVA: 0x003EE610 File Offset: 0x003EC810
		public static IHitNoScoreResult GetRootAsIHitNoScoreResult(ByteBuffer _bb, IHitNoScoreResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD17 RID: 113943 RVA: 0x003EE62D File Offset: 0x003EC82D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD18 RID: 113944 RVA: 0x003EE63C File Offset: 0x003EC83C
		public IHitNoScoreResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008296 RID: 33430
		// (get) Token: 0x0601BD19 RID: 113945 RVA: 0x003EE64C File Offset: 0x003EC84C
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BD1A RID: 113946 RVA: 0x003EE688 File Offset: 0x003EC888
		public static Offset<IHitNoScoreResult> CreateIHitNoScoreResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust)
		{
			builder.StartTable(1);
			IHitNoScoreResult.AddType(builder, Type);
			return IHitNoScoreResult.EndIHitNoScoreResult(builder);
		}

		// Token: 0x0601BD1B RID: 113947 RVA: 0x003EE69E File Offset: 0x003EC89E
		public static void StartIHitNoScoreResult(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BD1C RID: 113948 RVA: 0x003EE6A7 File Offset: 0x003EC8A7
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BD1D RID: 113949 RVA: 0x003EE6B2 File Offset: 0x003EC8B2
		public static Offset<IHitNoScoreResult> EndIHitNoScoreResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitNoScoreResult>(builder.EndTable());
		}

		// Token: 0x0601BD1E RID: 113950 RVA: 0x003EE6C0 File Offset: 0x003EC8C0
		public IHitNoScoreResultT UnPack()
		{
			IHitNoScoreResultT hitNoScoreResultT = new IHitNoScoreResultT();
			this.UnPackTo(hitNoScoreResultT);
			return hitNoScoreResultT;
		}

		// Token: 0x0601BD1F RID: 113951 RVA: 0x003EE6DB File Offset: 0x003EC8DB
		public void UnPackTo(IHitNoScoreResultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601BD20 RID: 113952 RVA: 0x003EE6EC File Offset: 0x003EC8EC
		public static Offset<IHitNoScoreResult> Pack(FlatBufferBuilder builder, IHitNoScoreResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitNoScoreResult>);
			}
			return IHitNoScoreResult.CreateIHitNoScoreResult(builder, _o.Type);
		}

		// Token: 0x0400CF16 RID: 53014
		private Table __p;
	}
}
