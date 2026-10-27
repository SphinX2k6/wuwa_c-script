using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4D RID: 27213
	public struct ILongPressInteractStyleCoreFix : IFlatbufferObject
	{
		// Token: 0x1700C9E6 RID: 51686
		// (get) Token: 0x0602FA5E RID: 195166 RVA: 0x0067C450 File Offset: 0x0067A650
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FA5F RID: 195167 RVA: 0x0067C45D File Offset: 0x0067A65D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FA60 RID: 195168 RVA: 0x0067C464 File Offset: 0x0067A664
		public static ILongPressInteractStyleCoreFix GetRootAsILongPressInteractStyleCoreFix(ByteBuffer _bb)
		{
			return ILongPressInteractStyleCoreFix.GetRootAsILongPressInteractStyleCoreFix(_bb, default(ILongPressInteractStyleCoreFix));
		}

		// Token: 0x0602FA61 RID: 195169 RVA: 0x0067C480 File Offset: 0x0067A680
		public static ILongPressInteractStyleCoreFix GetRootAsILongPressInteractStyleCoreFix(ByteBuffer _bb, ILongPressInteractStyleCoreFix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FA62 RID: 195170 RVA: 0x0067C49D File Offset: 0x0067A69D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FA63 RID: 195171 RVA: 0x0067C4AC File Offset: 0x0067A6AC
		public ILongPressInteractStyleCoreFix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9E7 RID: 51687
		// (get) Token: 0x0602FA64 RID: 195172 RVA: 0x0067C4BC File Offset: 0x0067A6BC
		public ELongPressInteractStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELongPressInteractStyle.Default;
				}
				return (ELongPressInteractStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FA65 RID: 195173 RVA: 0x0067C4F8 File Offset: 0x0067A6F8
		public static Offset<ILongPressInteractStyleCoreFix> CreateILongPressInteractStyleCoreFix(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleCoreFix.AddType(builder, Type);
			return ILongPressInteractStyleCoreFix.EndILongPressInteractStyleCoreFix(builder);
		}

		// Token: 0x0602FA66 RID: 195174 RVA: 0x0067C50E File Offset: 0x0067A70E
		public static void StartILongPressInteractStyleCoreFix(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FA67 RID: 195175 RVA: 0x0067C517 File Offset: 0x0067A717
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FA68 RID: 195176 RVA: 0x0067C522 File Offset: 0x0067A722
		public static Offset<ILongPressInteractStyleCoreFix> EndILongPressInteractStyleCoreFix(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleCoreFix>(builder.EndTable());
		}

		// Token: 0x0602FA69 RID: 195177 RVA: 0x0067C530 File Offset: 0x0067A730
		public ILongPressInteractStyleCoreFixT UnPack()
		{
			ILongPressInteractStyleCoreFixT longPressInteractStyleCoreFixT = new ILongPressInteractStyleCoreFixT();
			this.UnPackTo(longPressInteractStyleCoreFixT);
			return longPressInteractStyleCoreFixT;
		}

		// Token: 0x0602FA6A RID: 195178 RVA: 0x0067C54B File Offset: 0x0067A74B
		public void UnPackTo(ILongPressInteractStyleCoreFixT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FA6B RID: 195179 RVA: 0x0067C55C File Offset: 0x0067A75C
		public static Offset<ILongPressInteractStyleCoreFix> Pack(FlatBufferBuilder builder, ILongPressInteractStyleCoreFixT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleCoreFix>);
			}
			return ILongPressInteractStyleCoreFix.CreateILongPressInteractStyleCoreFix(builder, _o.Type);
		}

		// Token: 0x0401126E RID: 70254
		private Table __p;
	}
}
