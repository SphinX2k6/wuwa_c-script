using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C58 RID: 19544
	public struct IMusicBeatsConditionBase : IFlatbufferObject
	{
		// Token: 0x17008E00 RID: 36352
		// (get) Token: 0x0601EFD5 RID: 126933 RVA: 0x004558E2 File Offset: 0x00453AE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EFD6 RID: 126934 RVA: 0x004558EF File Offset: 0x00453AEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EFD7 RID: 126935 RVA: 0x004558F8 File Offset: 0x00453AF8
		public static IMusicBeatsConditionBase GetRootAsIMusicBeatsConditionBase(ByteBuffer _bb)
		{
			return IMusicBeatsConditionBase.GetRootAsIMusicBeatsConditionBase(_bb, default(IMusicBeatsConditionBase));
		}

		// Token: 0x0601EFD8 RID: 126936 RVA: 0x00455914 File Offset: 0x00453B14
		public static IMusicBeatsConditionBase GetRootAsIMusicBeatsConditionBase(ByteBuffer _bb, IMusicBeatsConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EFD9 RID: 126937 RVA: 0x00455931 File Offset: 0x00453B31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EFDA RID: 126938 RVA: 0x00455940 File Offset: 0x00453B40
		public IMusicBeatsConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E01 RID: 36353
		// (get) Token: 0x0601EFDB RID: 126939 RVA: 0x00455950 File Offset: 0x00453B50
		public EMusicEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMusicEventType.HcMusicBattle;
				}
				return (EMusicEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EFDC RID: 126940 RVA: 0x0045598C File Offset: 0x00453B8C
		public static Offset<IMusicBeatsConditionBase> CreateIMusicBeatsConditionBase(FlatBufferBuilder builder, EMusicEventType Type = EMusicEventType.HcMusicBattle)
		{
			builder.StartTable(1);
			IMusicBeatsConditionBase.AddType(builder, Type);
			return IMusicBeatsConditionBase.EndIMusicBeatsConditionBase(builder);
		}

		// Token: 0x0601EFDD RID: 126941 RVA: 0x004559A2 File Offset: 0x00453BA2
		public static void StartIMusicBeatsConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EFDE RID: 126942 RVA: 0x004559AB File Offset: 0x00453BAB
		public static void AddType(FlatBufferBuilder builder, EMusicEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFDF RID: 126943 RVA: 0x004559B6 File Offset: 0x00453BB6
		public static Offset<IMusicBeatsConditionBase> EndIMusicBeatsConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<IMusicBeatsConditionBase>(builder.EndTable());
		}

		// Token: 0x0601EFE0 RID: 126944 RVA: 0x004559C4 File Offset: 0x00453BC4
		public IMusicBeatsConditionBaseT UnPack()
		{
			IMusicBeatsConditionBaseT musicBeatsConditionBaseT = new IMusicBeatsConditionBaseT();
			this.UnPackTo(musicBeatsConditionBaseT);
			return musicBeatsConditionBaseT;
		}

		// Token: 0x0601EFE1 RID: 126945 RVA: 0x004559DF File Offset: 0x00453BDF
		public void UnPackTo(IMusicBeatsConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EFE2 RID: 126946 RVA: 0x004559F0 File Offset: 0x00453BF0
		public static Offset<IMusicBeatsConditionBase> Pack(FlatBufferBuilder builder, IMusicBeatsConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMusicBeatsConditionBase>);
			}
			return IMusicBeatsConditionBase.CreateIMusicBeatsConditionBase(builder, _o.Type);
		}

		// Token: 0x0400D602 RID: 54786
		private Table __p;
	}
}
