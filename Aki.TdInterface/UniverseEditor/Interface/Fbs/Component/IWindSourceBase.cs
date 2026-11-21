using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006196 RID: 24982
	public struct IWindSourceBase : IFlatbufferObject
	{
		// Token: 0x1700BA51 RID: 47697
		// (get) Token: 0x0602A75B RID: 173915 RVA: 0x005CAC7E File Offset: 0x005C8E7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A75C RID: 173916 RVA: 0x005CAC8B File Offset: 0x005C8E8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A75D RID: 173917 RVA: 0x005CAC94 File Offset: 0x005C8E94
		public static IWindSourceBase GetRootAsIWindSourceBase(ByteBuffer _bb)
		{
			return IWindSourceBase.GetRootAsIWindSourceBase(_bb, default(IWindSourceBase));
		}

		// Token: 0x0602A75E RID: 173918 RVA: 0x005CACB0 File Offset: 0x005C8EB0
		public static IWindSourceBase GetRootAsIWindSourceBase(ByteBuffer _bb, IWindSourceBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A75F RID: 173919 RVA: 0x005CACCD File Offset: 0x005C8ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A760 RID: 173920 RVA: 0x005CACDC File Offset: 0x005C8EDC
		public IWindSourceBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA52 RID: 47698
		// (get) Token: 0x0602A761 RID: 173921 RVA: 0x005CACEC File Offset: 0x005C8EEC
		public EWindSourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWindSourceType.Directional;
				}
				return (EWindSourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A762 RID: 173922 RVA: 0x005CAD28 File Offset: 0x005C8F28
		public static Offset<IWindSourceBase> CreateIWindSourceBase(FlatBufferBuilder builder, EWindSourceType Type = EWindSourceType.Directional)
		{
			builder.StartTable(1);
			IWindSourceBase.AddType(builder, Type);
			return IWindSourceBase.EndIWindSourceBase(builder);
		}

		// Token: 0x0602A763 RID: 173923 RVA: 0x005CAD3E File Offset: 0x005C8F3E
		public static void StartIWindSourceBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A764 RID: 173924 RVA: 0x005CAD47 File Offset: 0x005C8F47
		public static void AddType(FlatBufferBuilder builder, EWindSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A765 RID: 173925 RVA: 0x005CAD52 File Offset: 0x005C8F52
		public static Offset<IWindSourceBase> EndIWindSourceBase(FlatBufferBuilder builder)
		{
			return new Offset<IWindSourceBase>(builder.EndTable());
		}

		// Token: 0x0602A766 RID: 173926 RVA: 0x005CAD60 File Offset: 0x005C8F60
		public IWindSourceBaseT UnPack()
		{
			IWindSourceBaseT windSourceBaseT = new IWindSourceBaseT();
			this.UnPackTo(windSourceBaseT);
			return windSourceBaseT;
		}

		// Token: 0x0602A767 RID: 173927 RVA: 0x005CAD7B File Offset: 0x005C8F7B
		public void UnPackTo(IWindSourceBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A768 RID: 173928 RVA: 0x005CAD8C File Offset: 0x005C8F8C
		public static Offset<IWindSourceBase> Pack(FlatBufferBuilder builder, IWindSourceBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindSourceBase>);
			}
			return IWindSourceBase.CreateIWindSourceBase(builder, _o.Type);
		}

		// Token: 0x0400FFE1 RID: 65505
		private Table __p;
	}
}
