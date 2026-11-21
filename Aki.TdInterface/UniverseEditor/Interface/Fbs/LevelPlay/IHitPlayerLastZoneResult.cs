using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200493B RID: 18747
	public struct IHitPlayerLastZoneResult : IFlatbufferObject
	{
		// Token: 0x17008298 RID: 33432
		// (get) Token: 0x0601BD25 RID: 113957 RVA: 0x003EE755 File Offset: 0x003EC955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD26 RID: 113958 RVA: 0x003EE762 File Offset: 0x003EC962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD27 RID: 113959 RVA: 0x003EE76C File Offset: 0x003EC96C
		public static IHitPlayerLastZoneResult GetRootAsIHitPlayerLastZoneResult(ByteBuffer _bb)
		{
			return IHitPlayerLastZoneResult.GetRootAsIHitPlayerLastZoneResult(_bb, default(IHitPlayerLastZoneResult));
		}

		// Token: 0x0601BD28 RID: 113960 RVA: 0x003EE788 File Offset: 0x003EC988
		public static IHitPlayerLastZoneResult GetRootAsIHitPlayerLastZoneResult(ByteBuffer _bb, IHitPlayerLastZoneResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD29 RID: 113961 RVA: 0x003EE7A5 File Offset: 0x003EC9A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD2A RID: 113962 RVA: 0x003EE7B4 File Offset: 0x003EC9B4
		public IHitPlayerLastZoneResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008299 RID: 33433
		// (get) Token: 0x0601BD2B RID: 113963 RVA: 0x003EE7C4 File Offset: 0x003EC9C4
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

		// Token: 0x1700829A RID: 33434
		// (get) Token: 0x0601BD2C RID: 113964 RVA: 0x003EE800 File Offset: 0x003ECA00
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

		// Token: 0x0601BD2D RID: 113965 RVA: 0x003EE83C File Offset: 0x003ECA3C
		public static Offset<IHitPlayerLastZoneResult> CreateIHitPlayerLastZoneResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int HitTimes = 0)
		{
			builder.StartTable(2);
			IHitPlayerLastZoneResult.AddHitTimes(builder, HitTimes);
			IHitPlayerLastZoneResult.AddType(builder, Type);
			return IHitPlayerLastZoneResult.EndIHitPlayerLastZoneResult(builder);
		}

		// Token: 0x0601BD2E RID: 113966 RVA: 0x003EE859 File Offset: 0x003ECA59
		public static void StartIHitPlayerLastZoneResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BD2F RID: 113967 RVA: 0x003EE862 File Offset: 0x003ECA62
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BD30 RID: 113968 RVA: 0x003EE86D File Offset: 0x003ECA6D
		public static void AddHitTimes(FlatBufferBuilder builder, int hitTimes)
		{
			builder.AddInt(1, hitTimes, 0);
		}

		// Token: 0x0601BD31 RID: 113969 RVA: 0x003EE878 File Offset: 0x003ECA78
		public static Offset<IHitPlayerLastZoneResult> EndIHitPlayerLastZoneResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitPlayerLastZoneResult>(builder.EndTable());
		}

		// Token: 0x0601BD32 RID: 113970 RVA: 0x003EE888 File Offset: 0x003ECA88
		public IHitPlayerLastZoneResultT UnPack()
		{
			IHitPlayerLastZoneResultT hitPlayerLastZoneResultT = new IHitPlayerLastZoneResultT();
			this.UnPackTo(hitPlayerLastZoneResultT);
			return hitPlayerLastZoneResultT;
		}

		// Token: 0x0601BD33 RID: 113971 RVA: 0x003EE8A3 File Offset: 0x003ECAA3
		public void UnPackTo(IHitPlayerLastZoneResultT _o)
		{
			_o.Type = this.Type;
			_o.HitTimes = this.HitTimes;
		}

		// Token: 0x0601BD34 RID: 113972 RVA: 0x003EE8C0 File Offset: 0x003ECAC0
		public static Offset<IHitPlayerLastZoneResult> Pack(FlatBufferBuilder builder, IHitPlayerLastZoneResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitPlayerLastZoneResult>);
			}
			return IHitPlayerLastZoneResult.CreateIHitPlayerLastZoneResult(builder, _o.Type, _o.HitTimes);
		}

		// Token: 0x0400CF18 RID: 53016
		private Table __p;
	}
}
