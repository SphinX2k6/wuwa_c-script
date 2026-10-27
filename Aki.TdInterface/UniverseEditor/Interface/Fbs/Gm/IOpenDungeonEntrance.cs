using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004678 RID: 18040
	public struct IOpenDungeonEntrance : IFlatbufferObject
	{
		// Token: 0x1700801B RID: 32795
		// (get) Token: 0x0601B62B RID: 112171 RVA: 0x003E4799 File Offset: 0x003E2999
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B62C RID: 112172 RVA: 0x003E47A6 File Offset: 0x003E29A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B62D RID: 112173 RVA: 0x003E47B0 File Offset: 0x003E29B0
		public static IOpenDungeonEntrance GetRootAsIOpenDungeonEntrance(ByteBuffer _bb)
		{
			return IOpenDungeonEntrance.GetRootAsIOpenDungeonEntrance(_bb, default(IOpenDungeonEntrance));
		}

		// Token: 0x0601B62E RID: 112174 RVA: 0x003E47CC File Offset: 0x003E29CC
		public static IOpenDungeonEntrance GetRootAsIOpenDungeonEntrance(ByteBuffer _bb, IOpenDungeonEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B62F RID: 112175 RVA: 0x003E47E9 File Offset: 0x003E29E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B630 RID: 112176 RVA: 0x003E47F8 File Offset: 0x003E29F8
		public IOpenDungeonEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700801C RID: 32796
		// (get) Token: 0x0601B631 RID: 112177 RVA: 0x003E4808 File Offset: 0x003E2A08
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

		// Token: 0x1700801D RID: 32797
		// (get) Token: 0x0601B632 RID: 112178 RVA: 0x003E4844 File Offset: 0x003E2A44
		public int EntranceId
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

		// Token: 0x0601B633 RID: 112179 RVA: 0x003E4880 File Offset: 0x003E2A80
		public static Offset<IOpenDungeonEntrance> CreateIOpenDungeonEntrance(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int EntranceId = 0)
		{
			builder.StartTable(2);
			IOpenDungeonEntrance.AddEntranceId(builder, EntranceId);
			IOpenDungeonEntrance.AddType(builder, Type);
			return IOpenDungeonEntrance.EndIOpenDungeonEntrance(builder);
		}

		// Token: 0x0601B634 RID: 112180 RVA: 0x003E489D File Offset: 0x003E2A9D
		public static void StartIOpenDungeonEntrance(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B635 RID: 112181 RVA: 0x003E48A6 File Offset: 0x003E2AA6
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B636 RID: 112182 RVA: 0x003E48B1 File Offset: 0x003E2AB1
		public static void AddEntranceId(FlatBufferBuilder builder, int entranceId)
		{
			builder.AddInt(1, entranceId, 0);
		}

		// Token: 0x0601B637 RID: 112183 RVA: 0x003E48BC File Offset: 0x003E2ABC
		public static Offset<IOpenDungeonEntrance> EndIOpenDungeonEntrance(FlatBufferBuilder builder)
		{
			return new Offset<IOpenDungeonEntrance>(builder.EndTable());
		}

		// Token: 0x0601B638 RID: 112184 RVA: 0x003E48CC File Offset: 0x003E2ACC
		public IOpenDungeonEntranceT UnPack()
		{
			IOpenDungeonEntranceT openDungeonEntranceT = new IOpenDungeonEntranceT();
			this.UnPackTo(openDungeonEntranceT);
			return openDungeonEntranceT;
		}

		// Token: 0x0601B639 RID: 112185 RVA: 0x003E48E7 File Offset: 0x003E2AE7
		public void UnPackTo(IOpenDungeonEntranceT _o)
		{
			_o.Type = this.Type;
			_o.EntranceId = this.EntranceId;
		}

		// Token: 0x0601B63A RID: 112186 RVA: 0x003E4904 File Offset: 0x003E2B04
		public static Offset<IOpenDungeonEntrance> Pack(FlatBufferBuilder builder, IOpenDungeonEntranceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenDungeonEntrance>);
			}
			return IOpenDungeonEntrance.CreateIOpenDungeonEntrance(builder, _o.Type, _o.EntranceId);
		}

		// Token: 0x0400C83B RID: 51259
		private Table __p;
	}
}
