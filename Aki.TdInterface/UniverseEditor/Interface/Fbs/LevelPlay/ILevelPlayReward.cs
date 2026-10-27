using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004515 RID: 17685
	public struct ILevelPlayReward : IFlatbufferObject
	{
		// Token: 0x17007D5F RID: 32095
		// (get) Token: 0x0601A935 RID: 108853 RVA: 0x003CB812 File Offset: 0x003C9A12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A936 RID: 108854 RVA: 0x003CB81F File Offset: 0x003C9A1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A937 RID: 108855 RVA: 0x003CB828 File Offset: 0x003C9A28
		public static ILevelPlayReward GetRootAsILevelPlayReward(ByteBuffer _bb)
		{
			return ILevelPlayReward.GetRootAsILevelPlayReward(_bb, default(ILevelPlayReward));
		}

		// Token: 0x0601A938 RID: 108856 RVA: 0x003CB844 File Offset: 0x003C9A44
		public static ILevelPlayReward GetRootAsILevelPlayReward(ByteBuffer _bb, ILevelPlayReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A939 RID: 108857 RVA: 0x003CB861 File Offset: 0x003C9A61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A93A RID: 108858 RVA: 0x003CB870 File Offset: 0x003C9A70
		public ILevelPlayReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D60 RID: 32096
		// (get) Token: 0x0601A93B RID: 108859 RVA: 0x003CB880 File Offset: 0x003C9A80
		public ELevelPlayRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRewardType.None;
				}
				return (ELevelPlayRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A93C RID: 108860 RVA: 0x003CB8BC File Offset: 0x003C9ABC
		public static Offset<ILevelPlayReward> CreateILevelPlayReward(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None)
		{
			builder.StartTable(1);
			ILevelPlayReward.AddType(builder, Type);
			return ILevelPlayReward.EndILevelPlayReward(builder);
		}

		// Token: 0x0601A93D RID: 108861 RVA: 0x003CB8D2 File Offset: 0x003C9AD2
		public static void StartILevelPlayReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A93E RID: 108862 RVA: 0x003CB8DB File Offset: 0x003C9ADB
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A93F RID: 108863 RVA: 0x003CB8E6 File Offset: 0x003C9AE6
		public static Offset<ILevelPlayReward> EndILevelPlayReward(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayReward>(builder.EndTable());
		}

		// Token: 0x0601A940 RID: 108864 RVA: 0x003CB8F4 File Offset: 0x003C9AF4
		public ILevelPlayRewardT UnPack()
		{
			ILevelPlayRewardT levelPlayRewardT = new ILevelPlayRewardT();
			this.UnPackTo(levelPlayRewardT);
			return levelPlayRewardT;
		}

		// Token: 0x0601A941 RID: 108865 RVA: 0x003CB90F File Offset: 0x003C9B0F
		public void UnPackTo(ILevelPlayRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A942 RID: 108866 RVA: 0x003CB920 File Offset: 0x003C9B20
		public static Offset<ILevelPlayReward> Pack(FlatBufferBuilder builder, ILevelPlayRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayReward>);
			}
			return ILevelPlayReward.CreateILevelPlayReward(builder, _o.Type);
		}

		// Token: 0x0400C588 RID: 50568
		private Table __p;
	}
}
