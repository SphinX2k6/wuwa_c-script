using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D3 RID: 17619
	public struct IHitPlayerLastZoneResult : IFlatbufferObject
	{
		// Token: 0x17007C59 RID: 31833
		// (get) Token: 0x0601A554 RID: 107860 RVA: 0x003C2549 File Offset: 0x003C0749
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A555 RID: 107861 RVA: 0x003C2556 File Offset: 0x003C0756
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A556 RID: 107862 RVA: 0x003C2560 File Offset: 0x003C0760
		public static IHitPlayerLastZoneResult GetRootAsIHitPlayerLastZoneResult(ByteBuffer _bb)
		{
			return IHitPlayerLastZoneResult.GetRootAsIHitPlayerLastZoneResult(_bb, default(IHitPlayerLastZoneResult));
		}

		// Token: 0x0601A557 RID: 107863 RVA: 0x003C257C File Offset: 0x003C077C
		public static IHitPlayerLastZoneResult GetRootAsIHitPlayerLastZoneResult(ByteBuffer _bb, IHitPlayerLastZoneResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A558 RID: 107864 RVA: 0x003C2599 File Offset: 0x003C0799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A559 RID: 107865 RVA: 0x003C25A8 File Offset: 0x003C07A8
		public IHitPlayerLastZoneResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C5A RID: 31834
		// (get) Token: 0x0601A55A RID: 107866 RVA: 0x003C25B8 File Offset: 0x003C07B8
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

		// Token: 0x17007C5B RID: 31835
		// (get) Token: 0x0601A55B RID: 107867 RVA: 0x003C25F4 File Offset: 0x003C07F4
		public int HitTimes
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

		// Token: 0x0601A55C RID: 107868 RVA: 0x003C2630 File Offset: 0x003C0830
		public static Offset<IHitPlayerLastZoneResult> CreateIHitPlayerLastZoneResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int HitTimes = 0)
		{
			builder.StartTable(2);
			IHitPlayerLastZoneResult.AddHitTimes(builder, HitTimes);
			IHitPlayerLastZoneResult.AddType(builder, Type);
			return IHitPlayerLastZoneResult.EndIHitPlayerLastZoneResult(builder);
		}

		// Token: 0x0601A55D RID: 107869 RVA: 0x003C264D File Offset: 0x003C084D
		public static void StartIHitPlayerLastZoneResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A55E RID: 107870 RVA: 0x003C2656 File Offset: 0x003C0856
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A55F RID: 107871 RVA: 0x003C2661 File Offset: 0x003C0861
		public static void AddHitTimes(FlatBufferBuilder builder, int hitTimes)
		{
			builder.AddInt(1, hitTimes, 0);
		}

		// Token: 0x0601A560 RID: 107872 RVA: 0x003C266C File Offset: 0x003C086C
		public static Offset<IHitPlayerLastZoneResult> EndIHitPlayerLastZoneResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitPlayerLastZoneResult>(builder.EndTable());
		}

		// Token: 0x0601A561 RID: 107873 RVA: 0x003C267C File Offset: 0x003C087C
		public IHitPlayerLastZoneResultT UnPack()
		{
			IHitPlayerLastZoneResultT hitPlayerLastZoneResultT = new IHitPlayerLastZoneResultT();
			this.UnPackTo(hitPlayerLastZoneResultT);
			return hitPlayerLastZoneResultT;
		}

		// Token: 0x0601A562 RID: 107874 RVA: 0x003C2697 File Offset: 0x003C0897
		public void UnPackTo(IHitPlayerLastZoneResultT _o)
		{
			_o.Type = this.Type;
			_o.HitTimes = this.HitTimes;
		}

		// Token: 0x0601A563 RID: 107875 RVA: 0x003C26B4 File Offset: 0x003C08B4
		public static Offset<IHitPlayerLastZoneResult> Pack(FlatBufferBuilder builder, IHitPlayerLastZoneResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitPlayerLastZoneResult>);
			}
			return IHitPlayerLastZoneResult.CreateIHitPlayerLastZoneResult(builder, _o.Type, _o.HitTimes);
		}

		// Token: 0x0400C4EA RID: 50410
		private Table __p;
	}
}
