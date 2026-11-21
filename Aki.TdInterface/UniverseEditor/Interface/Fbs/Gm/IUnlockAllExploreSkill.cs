using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B34 RID: 19252
	public struct IUnlockAllExploreSkill : IFlatbufferObject
	{
		// Token: 0x17008708 RID: 34568
		// (get) Token: 0x0601D0B0 RID: 118960 RVA: 0x00414E55 File Offset: 0x00413055
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D0B1 RID: 118961 RVA: 0x00414E62 File Offset: 0x00413062
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D0B2 RID: 118962 RVA: 0x00414E6C File Offset: 0x0041306C
		public static IUnlockAllExploreSkill GetRootAsIUnlockAllExploreSkill(ByteBuffer _bb)
		{
			return IUnlockAllExploreSkill.GetRootAsIUnlockAllExploreSkill(_bb, default(IUnlockAllExploreSkill));
		}

		// Token: 0x0601D0B3 RID: 118963 RVA: 0x00414E88 File Offset: 0x00413088
		public static IUnlockAllExploreSkill GetRootAsIUnlockAllExploreSkill(ByteBuffer _bb, IUnlockAllExploreSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D0B4 RID: 118964 RVA: 0x00414EA5 File Offset: 0x004130A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D0B5 RID: 118965 RVA: 0x00414EB4 File Offset: 0x004130B4
		public IUnlockAllExploreSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008709 RID: 34569
		// (get) Token: 0x0601D0B6 RID: 118966 RVA: 0x00414EC4 File Offset: 0x004130C4
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D0B7 RID: 118967 RVA: 0x00414F00 File Offset: 0x00413100
		public static Offset<IUnlockAllExploreSkill> CreateIUnlockAllExploreSkill(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IUnlockAllExploreSkill.AddType(builder, Type);
			return IUnlockAllExploreSkill.EndIUnlockAllExploreSkill(builder);
		}

		// Token: 0x0601D0B8 RID: 118968 RVA: 0x00414F16 File Offset: 0x00413116
		public static void StartIUnlockAllExploreSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D0B9 RID: 118969 RVA: 0x00414F1F File Offset: 0x0041311F
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D0BA RID: 118970 RVA: 0x00414F2A File Offset: 0x0041312A
		public static Offset<IUnlockAllExploreSkill> EndIUnlockAllExploreSkill(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAllExploreSkill>(builder.EndTable());
		}

		// Token: 0x0601D0BB RID: 118971 RVA: 0x00414F38 File Offset: 0x00413138
		public IUnlockAllExploreSkillT UnPack()
		{
			IUnlockAllExploreSkillT unlockAllExploreSkillT = new IUnlockAllExploreSkillT();
			this.UnPackTo(unlockAllExploreSkillT);
			return unlockAllExploreSkillT;
		}

		// Token: 0x0601D0BC RID: 118972 RVA: 0x00414F53 File Offset: 0x00413153
		public void UnPackTo(IUnlockAllExploreSkillT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D0BD RID: 118973 RVA: 0x00414F64 File Offset: 0x00413164
		public static Offset<IUnlockAllExploreSkill> Pack(FlatBufferBuilder builder, IUnlockAllExploreSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockAllExploreSkill>);
			}
			return IUnlockAllExploreSkill.CreateIUnlockAllExploreSkill(builder, _o.Type);
		}

		// Token: 0x0400D2CE RID: 53966
		private Table __p;
	}
}
