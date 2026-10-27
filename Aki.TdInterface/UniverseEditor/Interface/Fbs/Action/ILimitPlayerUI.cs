using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2C RID: 27180
	public struct ILimitPlayerUI : IFlatbufferObject
	{
		// Token: 0x1700C99A RID: 51610
		// (get) Token: 0x0602F906 RID: 194822 RVA: 0x0067991E File Offset: 0x00677B1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F907 RID: 194823 RVA: 0x0067992B File Offset: 0x00677B2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F908 RID: 194824 RVA: 0x00679934 File Offset: 0x00677B34
		public static ILimitPlayerUI GetRootAsILimitPlayerUI(ByteBuffer _bb)
		{
			return ILimitPlayerUI.GetRootAsILimitPlayerUI(_bb, default(ILimitPlayerUI));
		}

		// Token: 0x0602F909 RID: 194825 RVA: 0x00679950 File Offset: 0x00677B50
		public static ILimitPlayerUI GetRootAsILimitPlayerUI(ByteBuffer _bb, ILimitPlayerUI obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F90A RID: 194826 RVA: 0x0067996D File Offset: 0x00677B6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F90B RID: 194827 RVA: 0x0067997C File Offset: 0x00677B7C
		public ILimitPlayerUI __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C99B RID: 51611
		// (get) Token: 0x0602F90C RID: 194828 RVA: 0x0067998C File Offset: 0x00677B8C
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F90D RID: 194829 RVA: 0x006799C8 File Offset: 0x00677BC8
		public static Offset<ILimitPlayerUI> CreateILimitPlayerUI(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera)
		{
			builder.StartTable(1);
			ILimitPlayerUI.AddType(builder, Type);
			return ILimitPlayerUI.EndILimitPlayerUI(builder);
		}

		// Token: 0x0602F90E RID: 194830 RVA: 0x006799DE File Offset: 0x00677BDE
		public static void StartILimitPlayerUI(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F90F RID: 194831 RVA: 0x006799E7 File Offset: 0x00677BE7
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F910 RID: 194832 RVA: 0x006799F2 File Offset: 0x00677BF2
		public static Offset<ILimitPlayerUI> EndILimitPlayerUI(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerUI>(builder.EndTable());
		}

		// Token: 0x0602F911 RID: 194833 RVA: 0x00679A00 File Offset: 0x00677C00
		public ILimitPlayerUIT UnPack()
		{
			ILimitPlayerUIT limitPlayerUIT = new ILimitPlayerUIT();
			this.UnPackTo(limitPlayerUIT);
			return limitPlayerUIT;
		}

		// Token: 0x0602F912 RID: 194834 RVA: 0x00679A1B File Offset: 0x00677C1B
		public void UnPackTo(ILimitPlayerUIT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F913 RID: 194835 RVA: 0x00679A2C File Offset: 0x00677C2C
		public static Offset<ILimitPlayerUI> Pack(FlatBufferBuilder builder, ILimitPlayerUIT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerUI>);
			}
			return ILimitPlayerUI.CreateILimitPlayerUI(builder, _o.Type);
		}

		// Token: 0x0401123B RID: 70203
		private Table __p;
	}
}
