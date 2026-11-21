using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573F RID: 22335
	public struct IExploreSkillArrowInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700A146 RID: 41286
		// (get) Token: 0x06023EFC RID: 147196 RVA: 0x004F09A4 File Offset: 0x004EEBA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023EFD RID: 147197 RVA: 0x004F09B1 File Offset: 0x004EEBB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023EFE RID: 147198 RVA: 0x004F09B8 File Offset: 0x004EEBB8
		public static IExploreSkillArrowInteractPoint GetRootAsIExploreSkillArrowInteractPoint(ByteBuffer _bb)
		{
			return IExploreSkillArrowInteractPoint.GetRootAsIExploreSkillArrowInteractPoint(_bb, default(IExploreSkillArrowInteractPoint));
		}

		// Token: 0x06023EFF RID: 147199 RVA: 0x004F09D4 File Offset: 0x004EEBD4
		public static IExploreSkillArrowInteractPoint GetRootAsIExploreSkillArrowInteractPoint(ByteBuffer _bb, IExploreSkillArrowInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023F00 RID: 147200 RVA: 0x004F09F1 File Offset: 0x004EEBF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023F01 RID: 147201 RVA: 0x004F0A00 File Offset: 0x004EEC00
		public IExploreSkillArrowInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A147 RID: 41287
		// (get) Token: 0x06023F02 RID: 147202 RVA: 0x004F0A10 File Offset: 0x004EEC10
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A148 RID: 41288
		// (get) Token: 0x06023F03 RID: 147203 RVA: 0x004F0A4C File Offset: 0x004EEC4C
		public float MinDistance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A149 RID: 41289
		// (get) Token: 0x06023F04 RID: 147204 RVA: 0x004F0A8C File Offset: 0x004EEC8C
		public float InteractWaitTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A14A RID: 41290
		// (get) Token: 0x06023F05 RID: 147205 RVA: 0x004F0ACC File Offset: 0x004EECCC
		public float ShootWaitTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023F06 RID: 147206 RVA: 0x004F0B0D File Offset: 0x004EED0D
		public static Offset<IExploreSkillArrowInteractPoint> CreateIExploreSkillArrowInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float MinDistance = 0f, float InteractWaitTime = 0f, float ShootWaitTime = 0f)
		{
			builder.StartTable(4);
			IExploreSkillArrowInteractPoint.AddShootWaitTime(builder, ShootWaitTime);
			IExploreSkillArrowInteractPoint.AddInteractWaitTime(builder, InteractWaitTime);
			IExploreSkillArrowInteractPoint.AddMinDistance(builder, MinDistance);
			IExploreSkillArrowInteractPoint.AddType(builder, Type);
			return IExploreSkillArrowInteractPoint.EndIExploreSkillArrowInteractPoint(builder);
		}

		// Token: 0x06023F07 RID: 147207 RVA: 0x004F0B39 File Offset: 0x004EED39
		public static void StartIExploreSkillArrowInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023F08 RID: 147208 RVA: 0x004F0B42 File Offset: 0x004EED42
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023F09 RID: 147209 RVA: 0x004F0B4D File Offset: 0x004EED4D
		public static void AddMinDistance(FlatBufferBuilder builder, float minDistance)
		{
			builder.AddFloat(1, minDistance, 0.0);
		}

		// Token: 0x06023F0A RID: 147210 RVA: 0x004F0B60 File Offset: 0x004EED60
		public static void AddInteractWaitTime(FlatBufferBuilder builder, float interactWaitTime)
		{
			builder.AddFloat(2, interactWaitTime, 0.0);
		}

		// Token: 0x06023F0B RID: 147211 RVA: 0x004F0B73 File Offset: 0x004EED73
		public static void AddShootWaitTime(FlatBufferBuilder builder, float shootWaitTime)
		{
			builder.AddFloat(3, shootWaitTime, 0.0);
		}

		// Token: 0x06023F0C RID: 147212 RVA: 0x004F0B86 File Offset: 0x004EED86
		public static Offset<IExploreSkillArrowInteractPoint> EndIExploreSkillArrowInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillArrowInteractPoint>(builder.EndTable());
		}

		// Token: 0x06023F0D RID: 147213 RVA: 0x004F0B94 File Offset: 0x004EED94
		public IExploreSkillArrowInteractPointT UnPack()
		{
			IExploreSkillArrowInteractPointT exploreSkillArrowInteractPointT = new IExploreSkillArrowInteractPointT();
			this.UnPackTo(exploreSkillArrowInteractPointT);
			return exploreSkillArrowInteractPointT;
		}

		// Token: 0x06023F0E RID: 147214 RVA: 0x004F0BAF File Offset: 0x004EEDAF
		public void UnPackTo(IExploreSkillArrowInteractPointT _o)
		{
			_o.Type = this.Type;
			_o.MinDistance = this.MinDistance;
			_o.InteractWaitTime = this.InteractWaitTime;
			_o.ShootWaitTime = this.ShootWaitTime;
		}

		// Token: 0x06023F0F RID: 147215 RVA: 0x004F0BE4 File Offset: 0x004EEDE4
		public static Offset<IExploreSkillArrowInteractPoint> Pack(FlatBufferBuilder builder, IExploreSkillArrowInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillArrowInteractPoint>);
			}
			return IExploreSkillArrowInteractPoint.CreateIExploreSkillArrowInteractPoint(builder, _o.Type, _o.MinDistance, _o.InteractWaitTime, _o.ShootWaitTime);
		}

		// Token: 0x0400EEE1 RID: 61153
		private Table __p;
	}
}
