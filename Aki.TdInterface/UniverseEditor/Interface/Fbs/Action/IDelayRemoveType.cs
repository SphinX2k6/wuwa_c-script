using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD2 RID: 27602
	public struct IDelayRemoveType : IFlatbufferObject
	{
		// Token: 0x1700CA7A RID: 51834
		// (get) Token: 0x0602F82C RID: 194604 RVA: 0x0067A6A5 File Offset: 0x006788A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F82D RID: 194605 RVA: 0x0067A6B2 File Offset: 0x006788B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F82E RID: 194606 RVA: 0x0067A6BC File Offset: 0x006788BC
		public static IDelayRemoveType GetRootAsIDelayRemoveType(ByteBuffer _bb)
		{
			return IDelayRemoveType.GetRootAsIDelayRemoveType(_bb, default(IDelayRemoveType));
		}

		// Token: 0x0602F82F RID: 194607 RVA: 0x0067A6D8 File Offset: 0x006788D8
		public static IDelayRemoveType GetRootAsIDelayRemoveType(ByteBuffer _bb, IDelayRemoveType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F830 RID: 194608 RVA: 0x0067A6F5 File Offset: 0x006788F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F831 RID: 194609 RVA: 0x0067A704 File Offset: 0x00678904
		public IDelayRemoveType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA7B RID: 51835
		// (get) Token: 0x0602F832 RID: 194610 RVA: 0x0067A714 File Offset: 0x00678914
		public EDelayRemoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDelayRemoveType.DelayRemoveAfterSkillFinish;
				}
				return (EDelayRemoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F833 RID: 194611 RVA: 0x0067A750 File Offset: 0x00678950
		public static Offset<IDelayRemoveType> CreateIDelayRemoveType(FlatBufferBuilder builder, EDelayRemoveType Type = EDelayRemoveType.DelayRemoveAfterSkillFinish)
		{
			builder.StartTable(1);
			IDelayRemoveType.AddType(builder, Type);
			return IDelayRemoveType.EndIDelayRemoveType(builder);
		}

		// Token: 0x0602F834 RID: 194612 RVA: 0x0067A766 File Offset: 0x00678966
		public static void StartIDelayRemoveType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F835 RID: 194613 RVA: 0x0067A76F File Offset: 0x0067896F
		public static void AddType(FlatBufferBuilder builder, EDelayRemoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F836 RID: 194614 RVA: 0x0067A77A File Offset: 0x0067897A
		public static Offset<IDelayRemoveType> EndIDelayRemoveType(FlatBufferBuilder builder)
		{
			return new Offset<IDelayRemoveType>(builder.EndTable());
		}

		// Token: 0x0602F837 RID: 194615 RVA: 0x0067A788 File Offset: 0x00678988
		public IDelayRemoveTypeT UnPack()
		{
			IDelayRemoveTypeT delayRemoveTypeT = new IDelayRemoveTypeT();
			this.UnPackTo(delayRemoveTypeT);
			return delayRemoveTypeT;
		}

		// Token: 0x0602F838 RID: 194616 RVA: 0x0067A7A3 File Offset: 0x006789A3
		public void UnPackTo(IDelayRemoveTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F839 RID: 194617 RVA: 0x0067A7B4 File Offset: 0x006789B4
		public static Offset<IDelayRemoveType> Pack(FlatBufferBuilder builder, IDelayRemoveTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDelayRemoveType>);
			}
			return IDelayRemoveType.CreateIDelayRemoveType(builder, _o.Type);
		}

		// Token: 0x040119D1 RID: 72145
		private Table __p;
	}
}
