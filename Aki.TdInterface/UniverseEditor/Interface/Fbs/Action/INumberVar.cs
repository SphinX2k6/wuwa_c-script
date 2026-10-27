using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEB RID: 27627
	public struct INumberVar : IFlatbufferObject
	{
		// Token: 0x1700CD5B RID: 52571
		// (get) Token: 0x060308B8 RID: 198840 RVA: 0x00697080 File Offset: 0x00695280
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060308B9 RID: 198841 RVA: 0x0069708D File Offset: 0x0069528D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060308BA RID: 198842 RVA: 0x00697094 File Offset: 0x00695294
		public static INumberVar GetRootAsINumberVar(ByteBuffer _bb)
		{
			return INumberVar.GetRootAsINumberVar(_bb, default(INumberVar));
		}

		// Token: 0x060308BB RID: 198843 RVA: 0x006970B0 File Offset: 0x006952B0
		public static INumberVar GetRootAsINumberVar(ByteBuffer _bb, INumberVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060308BC RID: 198844 RVA: 0x006970CD File Offset: 0x006952CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060308BD RID: 198845 RVA: 0x006970DC File Offset: 0x006952DC
		public INumberVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD5C RID: 52572
		// (get) Token: 0x060308BE RID: 198846 RVA: 0x006970EC File Offset: 0x006952EC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060308BF RID: 198847 RVA: 0x00697123 File Offset: 0x00695323
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060308C0 RID: 198848 RVA: 0x00697132 File Offset: 0x00695332
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CD5D RID: 52573
		// (get) Token: 0x060308C1 RID: 198849 RVA: 0x00697140 File Offset: 0x00695340
		public float Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060308C2 RID: 198850 RVA: 0x00697180 File Offset: 0x00695380
		public static Offset<INumberVar> CreateINumberVar(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), float Value = 0f)
		{
			builder.StartTable(2);
			INumberVar.AddValue(builder, Value);
			INumberVar.AddName(builder, NameOffset);
			return INumberVar.EndINumberVar(builder);
		}

		// Token: 0x060308C3 RID: 198851 RVA: 0x0069719D File Offset: 0x0069539D
		public static void StartINumberVar(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060308C4 RID: 198852 RVA: 0x006971A6 File Offset: 0x006953A6
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x060308C5 RID: 198853 RVA: 0x006971B6 File Offset: 0x006953B6
		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(1, value, 0.0);
		}

		// Token: 0x060308C6 RID: 198854 RVA: 0x006971C9 File Offset: 0x006953C9
		public static Offset<INumberVar> EndINumberVar(FlatBufferBuilder builder)
		{
			return new Offset<INumberVar>(builder.EndTable());
		}

		// Token: 0x060308C7 RID: 198855 RVA: 0x006971D8 File Offset: 0x006953D8
		public INumberVarT UnPack()
		{
			INumberVarT numberVarT = new INumberVarT();
			this.UnPackTo(numberVarT);
			return numberVarT;
		}

		// Token: 0x060308C8 RID: 198856 RVA: 0x006971F3 File Offset: 0x006953F3
		public void UnPackTo(INumberVarT _o)
		{
			_o.Name = this.Name;
			_o.Value = this.Value;
		}

		// Token: 0x060308C9 RID: 198857 RVA: 0x00697210 File Offset: 0x00695410
		public static Offset<INumberVar> Pack(FlatBufferBuilder builder, INumberVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<INumberVar>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return INumberVar.CreateINumberVar(builder, nameOffset, _o.Value);
		}

		// Token: 0x040114DA RID: 70874
		private Table __p;
	}
}
