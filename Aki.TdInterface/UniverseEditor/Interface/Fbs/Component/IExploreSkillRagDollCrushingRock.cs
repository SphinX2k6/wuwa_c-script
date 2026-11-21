using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005769 RID: 22377
	public struct IExploreSkillRagDollCrushingRock : IFlatbufferObject
	{
		// Token: 0x1700A1C7 RID: 41415
		// (get) Token: 0x06024158 RID: 147800 RVA: 0x004F68EB File Offset: 0x004F4AEB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024159 RID: 147801 RVA: 0x004F68F8 File Offset: 0x004F4AF8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602415A RID: 147802 RVA: 0x004F6900 File Offset: 0x004F4B00
		public static IExploreSkillRagDollCrushingRock GetRootAsIExploreSkillRagDollCrushingRock(ByteBuffer _bb)
		{
			return IExploreSkillRagDollCrushingRock.GetRootAsIExploreSkillRagDollCrushingRock(_bb, default(IExploreSkillRagDollCrushingRock));
		}

		// Token: 0x0602415B RID: 147803 RVA: 0x004F691C File Offset: 0x004F4B1C
		public static IExploreSkillRagDollCrushingRock GetRootAsIExploreSkillRagDollCrushingRock(ByteBuffer _bb, IExploreSkillRagDollCrushingRock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602415C RID: 147804 RVA: 0x004F6939 File Offset: 0x004F4B39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602415D RID: 147805 RVA: 0x004F6948 File Offset: 0x004F4B48
		public IExploreSkillRagDollCrushingRock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1C8 RID: 41416
		// (get) Token: 0x0602415E RID: 147806 RVA: 0x004F6958 File Offset: 0x004F4B58
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

		// Token: 0x0602415F RID: 147807 RVA: 0x004F6994 File Offset: 0x004F4B94
		public static Offset<IExploreSkillRagDollCrushingRock> CreateIExploreSkillRagDollCrushingRock(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant)
		{
			builder.StartTable(1);
			IExploreSkillRagDollCrushingRock.AddType(builder, Type);
			return IExploreSkillRagDollCrushingRock.EndIExploreSkillRagDollCrushingRock(builder);
		}

		// Token: 0x06024160 RID: 147808 RVA: 0x004F69AA File Offset: 0x004F4BAA
		public static void StartIExploreSkillRagDollCrushingRock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024161 RID: 147809 RVA: 0x004F69B3 File Offset: 0x004F4BB3
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024162 RID: 147810 RVA: 0x004F69BE File Offset: 0x004F4BBE
		public static Offset<IExploreSkillRagDollCrushingRock> EndIExploreSkillRagDollCrushingRock(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillRagDollCrushingRock>(builder.EndTable());
		}

		// Token: 0x06024163 RID: 147811 RVA: 0x004F69CC File Offset: 0x004F4BCC
		public IExploreSkillRagDollCrushingRockT UnPack()
		{
			IExploreSkillRagDollCrushingRockT exploreSkillRagDollCrushingRockT = new IExploreSkillRagDollCrushingRockT();
			this.UnPackTo(exploreSkillRagDollCrushingRockT);
			return exploreSkillRagDollCrushingRockT;
		}

		// Token: 0x06024164 RID: 147812 RVA: 0x004F69E7 File Offset: 0x004F4BE7
		public void UnPackTo(IExploreSkillRagDollCrushingRockT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024165 RID: 147813 RVA: 0x004F69F8 File Offset: 0x004F4BF8
		public static Offset<IExploreSkillRagDollCrushingRock> Pack(FlatBufferBuilder builder, IExploreSkillRagDollCrushingRockT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillRagDollCrushingRock>);
			}
			return IExploreSkillRagDollCrushingRock.CreateIExploreSkillRagDollCrushingRock(builder, _o.Type);
		}

		// Token: 0x0400EF3A RID: 61242
		private Table __p;
	}
}
