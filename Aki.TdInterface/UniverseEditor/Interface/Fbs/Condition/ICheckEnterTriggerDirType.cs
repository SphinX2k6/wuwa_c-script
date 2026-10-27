using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049EB RID: 18923
	public struct ICheckEnterTriggerDirType : IFlatbufferObject
	{
		// Token: 0x170088DE RID: 35038
		// (get) Token: 0x0601D90C RID: 121100 RVA: 0x004295DC File Offset: 0x004277DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D90D RID: 121101 RVA: 0x004295E9 File Offset: 0x004277E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D90E RID: 121102 RVA: 0x004295F0 File Offset: 0x004277F0
		public static ICheckEnterTriggerDirType GetRootAsICheckEnterTriggerDirType(ByteBuffer _bb)
		{
			return ICheckEnterTriggerDirType.GetRootAsICheckEnterTriggerDirType(_bb, default(ICheckEnterTriggerDirType));
		}

		// Token: 0x0601D90F RID: 121103 RVA: 0x0042960C File Offset: 0x0042780C
		public static ICheckEnterTriggerDirType GetRootAsICheckEnterTriggerDirType(ByteBuffer _bb, ICheckEnterTriggerDirType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D910 RID: 121104 RVA: 0x00429629 File Offset: 0x00427829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D911 RID: 121105 RVA: 0x00429638 File Offset: 0x00427838
		public ICheckEnterTriggerDirType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170088DF RID: 35039
		// (get) Token: 0x0601D912 RID: 121106 RVA: 0x00429648 File Offset: 0x00427848
		public ECheckEnterTriggerDirType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEnterTriggerDirType.ForwardAngle;
				}
				return (ECheckEnterTriggerDirType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D913 RID: 121107 RVA: 0x00429684 File Offset: 0x00427884
		public static Offset<ICheckEnterTriggerDirType> CreateICheckEnterTriggerDirType(FlatBufferBuilder builder, ECheckEnterTriggerDirType Type = ECheckEnterTriggerDirType.ForwardAngle)
		{
			builder.StartTable(1);
			ICheckEnterTriggerDirType.AddType(builder, Type);
			return ICheckEnterTriggerDirType.EndICheckEnterTriggerDirType(builder);
		}

		// Token: 0x0601D914 RID: 121108 RVA: 0x0042969A File Offset: 0x0042789A
		public static void StartICheckEnterTriggerDirType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D915 RID: 121109 RVA: 0x004296A3 File Offset: 0x004278A3
		public static void AddType(FlatBufferBuilder builder, ECheckEnterTriggerDirType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D916 RID: 121110 RVA: 0x004296AE File Offset: 0x004278AE
		public static Offset<ICheckEnterTriggerDirType> EndICheckEnterTriggerDirType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEnterTriggerDirType>(builder.EndTable());
		}

		// Token: 0x0601D917 RID: 121111 RVA: 0x004296BC File Offset: 0x004278BC
		public ICheckEnterTriggerDirTypeT UnPack()
		{
			ICheckEnterTriggerDirTypeT checkEnterTriggerDirTypeT = new ICheckEnterTriggerDirTypeT();
			this.UnPackTo(checkEnterTriggerDirTypeT);
			return checkEnterTriggerDirTypeT;
		}

		// Token: 0x0601D918 RID: 121112 RVA: 0x004296D7 File Offset: 0x004278D7
		public void UnPackTo(ICheckEnterTriggerDirTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D919 RID: 121113 RVA: 0x004296E8 File Offset: 0x004278E8
		public static Offset<ICheckEnterTriggerDirType> Pack(FlatBufferBuilder builder, ICheckEnterTriggerDirTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEnterTriggerDirType>);
			}
			return ICheckEnterTriggerDirType.CreateICheckEnterTriggerDirType(builder, _o.Type);
		}

		// Token: 0x0400D21E RID: 53790
		private Table __p;
	}
}
