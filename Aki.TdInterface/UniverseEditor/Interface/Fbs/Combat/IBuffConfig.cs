using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006527 RID: 25895
	public struct IBuffConfig : IFlatbufferObject
	{
		// Token: 0x1700BF0F RID: 48911
		// (get) Token: 0x0602C226 RID: 180774 RVA: 0x00602FD0 File Offset: 0x006011D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C227 RID: 180775 RVA: 0x00602FDD File Offset: 0x006011DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C228 RID: 180776 RVA: 0x00602FE4 File Offset: 0x006011E4
		public static IBuffConfig GetRootAsIBuffConfig(ByteBuffer _bb)
		{
			return IBuffConfig.GetRootAsIBuffConfig(_bb, default(IBuffConfig));
		}

		// Token: 0x0602C229 RID: 180777 RVA: 0x00603000 File Offset: 0x00601200
		public static IBuffConfig GetRootAsIBuffConfig(ByteBuffer _bb, IBuffConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C22A RID: 180778 RVA: 0x0060301D File Offset: 0x0060121D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C22B RID: 180779 RVA: 0x0060302C File Offset: 0x0060122C
		public IBuffConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF10 RID: 48912
		// (get) Token: 0x0602C22C RID: 180780 RVA: 0x0060303C File Offset: 0x0060123C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF11 RID: 48913
		// (get) Token: 0x0602C22D RID: 180781 RVA: 0x00603078 File Offset: 0x00601278
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C22E RID: 180782 RVA: 0x006030AF File Offset: 0x006012AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C22F RID: 180783 RVA: 0x006030BE File Offset: 0x006012BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C230 RID: 180784 RVA: 0x006030CC File Offset: 0x006012CC
		public static Offset<IBuffConfig> CreateIBuffConfig(FlatBufferBuilder builder, int Id = 0, StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBuffConfig.AddName(builder, NameOffset);
			IBuffConfig.AddId(builder, Id);
			return IBuffConfig.EndIBuffConfig(builder);
		}

		// Token: 0x0602C231 RID: 180785 RVA: 0x006030E9 File Offset: 0x006012E9
		public static void StartIBuffConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C232 RID: 180786 RVA: 0x006030F2 File Offset: 0x006012F2
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602C233 RID: 180787 RVA: 0x006030FD File Offset: 0x006012FD
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0602C234 RID: 180788 RVA: 0x0060310D File Offset: 0x0060130D
		public static Offset<IBuffConfig> EndIBuffConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBuffConfig>(builder.EndTable());
		}

		// Token: 0x0602C235 RID: 180789 RVA: 0x0060311C File Offset: 0x0060131C
		public IBuffConfigT UnPack()
		{
			IBuffConfigT buffConfigT = new IBuffConfigT();
			this.UnPackTo(buffConfigT);
			return buffConfigT;
		}

		// Token: 0x0602C236 RID: 180790 RVA: 0x00603137 File Offset: 0x00601337
		public void UnPackTo(IBuffConfigT _o)
		{
			_o.Id = this.Id;
			_o.Name = this.Name;
		}

		// Token: 0x0602C237 RID: 180791 RVA: 0x00603154 File Offset: 0x00601354
		public static Offset<IBuffConfig> Pack(FlatBufferBuilder builder, IBuffConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffConfig>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IBuffConfig.CreateIBuffConfig(builder, _o.Id, nameOffset);
		}

		// Token: 0x0401074D RID: 67405
		private Table __p;
	}
}
