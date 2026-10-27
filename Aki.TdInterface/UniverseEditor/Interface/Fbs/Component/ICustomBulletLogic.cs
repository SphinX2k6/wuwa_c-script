using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005054 RID: 20564
	public struct ICustomBulletLogic : IFlatbufferObject
	{
		// Token: 0x17009535 RID: 38197
		// (get) Token: 0x06020F41 RID: 134977 RVA: 0x00494988 File Offset: 0x00492B88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F42 RID: 134978 RVA: 0x00494995 File Offset: 0x00492B95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F43 RID: 134979 RVA: 0x0049499C File Offset: 0x00492B9C
		public static ICustomBulletLogic GetRootAsICustomBulletLogic(ByteBuffer _bb)
		{
			return ICustomBulletLogic.GetRootAsICustomBulletLogic(_bb, default(ICustomBulletLogic));
		}

		// Token: 0x06020F44 RID: 134980 RVA: 0x004949B8 File Offset: 0x00492BB8
		public static ICustomBulletLogic GetRootAsICustomBulletLogic(ByteBuffer _bb, ICustomBulletLogic obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F45 RID: 134981 RVA: 0x004949D5 File Offset: 0x00492BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F46 RID: 134982 RVA: 0x004949E4 File Offset: 0x00492BE4
		public ICustomBulletLogic __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009536 RID: 38198
		// (get) Token: 0x06020F47 RID: 134983 RVA: 0x004949F4 File Offset: 0x00492BF4
		public ECustomBulletLogic Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomBulletLogic.TrafficBullet;
				}
				return (ECustomBulletLogic)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020F48 RID: 134984 RVA: 0x00494A30 File Offset: 0x00492C30
		public static Offset<ICustomBulletLogic> CreateICustomBulletLogic(FlatBufferBuilder builder, ECustomBulletLogic Type = ECustomBulletLogic.TrafficBullet)
		{
			builder.StartTable(1);
			ICustomBulletLogic.AddType(builder, Type);
			return ICustomBulletLogic.EndICustomBulletLogic(builder);
		}

		// Token: 0x06020F49 RID: 134985 RVA: 0x00494A46 File Offset: 0x00492C46
		public static void StartICustomBulletLogic(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020F4A RID: 134986 RVA: 0x00494A4F File Offset: 0x00492C4F
		public static void AddType(FlatBufferBuilder builder, ECustomBulletLogic type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F4B RID: 134987 RVA: 0x00494A5A File Offset: 0x00492C5A
		public static Offset<ICustomBulletLogic> EndICustomBulletLogic(FlatBufferBuilder builder)
		{
			return new Offset<ICustomBulletLogic>(builder.EndTable());
		}

		// Token: 0x06020F4C RID: 134988 RVA: 0x00494A68 File Offset: 0x00492C68
		public ICustomBulletLogicT UnPack()
		{
			ICustomBulletLogicT customBulletLogicT = new ICustomBulletLogicT();
			this.UnPackTo(customBulletLogicT);
			return customBulletLogicT;
		}

		// Token: 0x06020F4D RID: 134989 RVA: 0x00494A83 File Offset: 0x00492C83
		public void UnPackTo(ICustomBulletLogicT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020F4E RID: 134990 RVA: 0x00494A94 File Offset: 0x00492C94
		public static Offset<ICustomBulletLogic> Pack(FlatBufferBuilder builder, ICustomBulletLogicT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomBulletLogic>);
			}
			return ICustomBulletLogic.CreateICustomBulletLogic(builder, _o.Type);
		}

		// Token: 0x0400E04C RID: 57420
		private Table __p;
	}
}
