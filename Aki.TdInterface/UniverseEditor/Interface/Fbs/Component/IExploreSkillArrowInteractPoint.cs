using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051DA RID: 20954
	public struct IExploreSkillArrowInteractPoint : IFlatbufferObject
	{
		// Token: 0x17009957 RID: 39255
		// (get) Token: 0x06021FA4 RID: 139172 RVA: 0x004B693C File Offset: 0x004B4B3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021FA5 RID: 139173 RVA: 0x004B6949 File Offset: 0x004B4B49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021FA6 RID: 139174 RVA: 0x004B6950 File Offset: 0x004B4B50
		public static IExploreSkillArrowInteractPoint GetRootAsIExploreSkillArrowInteractPoint(ByteBuffer _bb)
		{
			return IExploreSkillArrowInteractPoint.GetRootAsIExploreSkillArrowInteractPoint(_bb, default(IExploreSkillArrowInteractPoint));
		}

		// Token: 0x06021FA7 RID: 139175 RVA: 0x004B696C File Offset: 0x004B4B6C
		public static IExploreSkillArrowInteractPoint GetRootAsIExploreSkillArrowInteractPoint(ByteBuffer _bb, IExploreSkillArrowInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021FA8 RID: 139176 RVA: 0x004B6989 File Offset: 0x004B4B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021FA9 RID: 139177 RVA: 0x004B6998 File Offset: 0x004B4B98
		public IExploreSkillArrowInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009958 RID: 39256
		// (get) Token: 0x06021FAA RID: 139178 RVA: 0x004B69A8 File Offset: 0x004B4BA8
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

		// Token: 0x17009959 RID: 39257
		// (get) Token: 0x06021FAB RID: 139179 RVA: 0x004B69E4 File Offset: 0x004B4BE4
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

		// Token: 0x1700995A RID: 39258
		// (get) Token: 0x06021FAC RID: 139180 RVA: 0x004B6A24 File Offset: 0x004B4C24
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

		// Token: 0x1700995B RID: 39259
		// (get) Token: 0x06021FAD RID: 139181 RVA: 0x004B6A64 File Offset: 0x004B4C64
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

		// Token: 0x06021FAE RID: 139182 RVA: 0x004B6AA5 File Offset: 0x004B4CA5
		public static Offset<IExploreSkillArrowInteractPoint> CreateIExploreSkillArrowInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float MinDistance = 0f, float InteractWaitTime = 0f, float ShootWaitTime = 0f)
		{
			builder.StartTable(4);
			IExploreSkillArrowInteractPoint.AddShootWaitTime(builder, ShootWaitTime);
			IExploreSkillArrowInteractPoint.AddInteractWaitTime(builder, InteractWaitTime);
			IExploreSkillArrowInteractPoint.AddMinDistance(builder, MinDistance);
			IExploreSkillArrowInteractPoint.AddType(builder, Type);
			return IExploreSkillArrowInteractPoint.EndIExploreSkillArrowInteractPoint(builder);
		}

		// Token: 0x06021FAF RID: 139183 RVA: 0x004B6AD1 File Offset: 0x004B4CD1
		public static void StartIExploreSkillArrowInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021FB0 RID: 139184 RVA: 0x004B6ADA File Offset: 0x004B4CDA
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021FB1 RID: 139185 RVA: 0x004B6AE5 File Offset: 0x004B4CE5
		public static void AddMinDistance(FlatBufferBuilder builder, float minDistance)
		{
			builder.AddFloat(1, minDistance, 0.0);
		}

		// Token: 0x06021FB2 RID: 139186 RVA: 0x004B6AF8 File Offset: 0x004B4CF8
		public static void AddInteractWaitTime(FlatBufferBuilder builder, float interactWaitTime)
		{
			builder.AddFloat(2, interactWaitTime, 0.0);
		}

		// Token: 0x06021FB3 RID: 139187 RVA: 0x004B6B0B File Offset: 0x004B4D0B
		public static void AddShootWaitTime(FlatBufferBuilder builder, float shootWaitTime)
		{
			builder.AddFloat(3, shootWaitTime, 0.0);
		}

		// Token: 0x06021FB4 RID: 139188 RVA: 0x004B6B1E File Offset: 0x004B4D1E
		public static Offset<IExploreSkillArrowInteractPoint> EndIExploreSkillArrowInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillArrowInteractPoint>(builder.EndTable());
		}

		// Token: 0x06021FB5 RID: 139189 RVA: 0x004B6B2C File Offset: 0x004B4D2C
		public IExploreSkillArrowInteractPointT UnPack()
		{
			IExploreSkillArrowInteractPointT exploreSkillArrowInteractPointT = new IExploreSkillArrowInteractPointT();
			this.UnPackTo(exploreSkillArrowInteractPointT);
			return exploreSkillArrowInteractPointT;
		}

		// Token: 0x06021FB6 RID: 139190 RVA: 0x004B6B47 File Offset: 0x004B4D47
		public void UnPackTo(IExploreSkillArrowInteractPointT _o)
		{
			_o.Type = this.Type;
			_o.MinDistance = this.MinDistance;
			_o.InteractWaitTime = this.InteractWaitTime;
			_o.ShootWaitTime = this.ShootWaitTime;
		}

		// Token: 0x06021FB7 RID: 139191 RVA: 0x004B6B7C File Offset: 0x004B4D7C
		public static Offset<IExploreSkillArrowInteractPoint> Pack(FlatBufferBuilder builder, IExploreSkillArrowInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillArrowInteractPoint>);
			}
			return IExploreSkillArrowInteractPoint.CreateIExploreSkillArrowInteractPoint(builder, _o.Type, _o.MinDistance, _o.InteractWaitTime, _o.ShootWaitTime);
		}

		// Token: 0x0400E2E3 RID: 58083
		private Table __p;
	}
}
