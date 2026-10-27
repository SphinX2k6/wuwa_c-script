using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200649E RID: 25758
	public struct ICommonTipId : IFlatbufferObject
	{
		// Token: 0x1700BFAD RID: 49069
		// (get) Token: 0x0602CA46 RID: 182854 RVA: 0x00621085 File Offset: 0x0061F285
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA47 RID: 182855 RVA: 0x00621092 File Offset: 0x0061F292
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA48 RID: 182856 RVA: 0x0062109C File Offset: 0x0061F29C
		public static ICommonTipId GetRootAsICommonTipId(ByteBuffer _bb)
		{
			return ICommonTipId.GetRootAsICommonTipId(_bb, default(ICommonTipId));
		}

		// Token: 0x0602CA49 RID: 182857 RVA: 0x006210B8 File Offset: 0x0061F2B8
		public static ICommonTipId GetRootAsICommonTipId(ByteBuffer _bb, ICommonTipId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA4A RID: 182858 RVA: 0x006210D5 File Offset: 0x0061F2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA4B RID: 182859 RVA: 0x006210E4 File Offset: 0x0061F2E4
		public ICommonTipId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFAE RID: 49070
		// (get) Token: 0x0602CA4C RID: 182860 RVA: 0x006210F4 File Offset: 0x0061F2F4
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFAF RID: 49071
		// (get) Token: 0x0602CA4D RID: 182861 RVA: 0x00621130 File Offset: 0x0061F330
		public int Id
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

		// Token: 0x0602CA4E RID: 182862 RVA: 0x0062116C File Offset: 0x0061F36C
		public static Offset<ICommonTipId> CreateICommonTipId(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, int Id = 0)
		{
			builder.StartTable(2);
			ICommonTipId.AddId(builder, Id);
			ICommonTipId.AddType(builder, Type);
			return ICommonTipId.EndICommonTipId(builder);
		}

		// Token: 0x0602CA4F RID: 182863 RVA: 0x00621189 File Offset: 0x0061F389
		public static void StartICommonTipId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CA50 RID: 182864 RVA: 0x00621192 File Offset: 0x0061F392
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA51 RID: 182865 RVA: 0x0062119D File Offset: 0x0061F39D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602CA52 RID: 182866 RVA: 0x006211A8 File Offset: 0x0061F3A8
		public static Offset<ICommonTipId> EndICommonTipId(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipId>(builder.EndTable());
		}

		// Token: 0x0602CA53 RID: 182867 RVA: 0x006211B8 File Offset: 0x0061F3B8
		public ICommonTipIdT UnPack()
		{
			ICommonTipIdT commonTipIdT = new ICommonTipIdT();
			this.UnPackTo(commonTipIdT);
			return commonTipIdT;
		}

		// Token: 0x0602CA54 RID: 182868 RVA: 0x006211D3 File Offset: 0x0061F3D3
		public void UnPackTo(ICommonTipIdT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602CA55 RID: 182869 RVA: 0x006211F0 File Offset: 0x0061F3F0
		public static Offset<ICommonTipId> Pack(FlatBufferBuilder builder, ICommonTipIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipId>);
			}
			return ICommonTipId.CreateICommonTipId(builder, _o.Type, _o.Id);
		}

		// Token: 0x04010AAB RID: 68267
		private Table __p;
	}
}
