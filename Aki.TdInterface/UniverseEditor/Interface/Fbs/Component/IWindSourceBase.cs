using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B80 RID: 23424
	public struct IWindSourceBase : IFlatbufferObject
	{
		// Token: 0x1700B109 RID: 45321
		// (get) Token: 0x06028197 RID: 164247 RVA: 0x005831EE File Offset: 0x005813EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028198 RID: 164248 RVA: 0x005831FB File Offset: 0x005813FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028199 RID: 164249 RVA: 0x00583204 File Offset: 0x00581404
		public static IWindSourceBase GetRootAsIWindSourceBase(ByteBuffer _bb)
		{
			return IWindSourceBase.GetRootAsIWindSourceBase(_bb, default(IWindSourceBase));
		}

		// Token: 0x0602819A RID: 164250 RVA: 0x00583220 File Offset: 0x00581420
		public static IWindSourceBase GetRootAsIWindSourceBase(ByteBuffer _bb, IWindSourceBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602819B RID: 164251 RVA: 0x0058323D File Offset: 0x0058143D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602819C RID: 164252 RVA: 0x0058324C File Offset: 0x0058144C
		public IWindSourceBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B10A RID: 45322
		// (get) Token: 0x0602819D RID: 164253 RVA: 0x0058325C File Offset: 0x0058145C
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

		// Token: 0x0602819E RID: 164254 RVA: 0x00583298 File Offset: 0x00581498
		public static Offset<IWindSourceBase> CreateIWindSourceBase(FlatBufferBuilder builder, EWindSourceType Type = EWindSourceType.Directional)
		{
			builder.StartTable(1);
			IWindSourceBase.AddType(builder, Type);
			return IWindSourceBase.EndIWindSourceBase(builder);
		}

		// Token: 0x0602819F RID: 164255 RVA: 0x005832AE File Offset: 0x005814AE
		public static void StartIWindSourceBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060281A0 RID: 164256 RVA: 0x005832B7 File Offset: 0x005814B7
		public static void AddType(FlatBufferBuilder builder, EWindSourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060281A1 RID: 164257 RVA: 0x005832C2 File Offset: 0x005814C2
		public static Offset<IWindSourceBase> EndIWindSourceBase(FlatBufferBuilder builder)
		{
			return new Offset<IWindSourceBase>(builder.EndTable());
		}

		// Token: 0x060281A2 RID: 164258 RVA: 0x005832D0 File Offset: 0x005814D0
		public IWindSourceBaseT UnPack()
		{
			IWindSourceBaseT windSourceBaseT = new IWindSourceBaseT();
			this.UnPackTo(windSourceBaseT);
			return windSourceBaseT;
		}

		// Token: 0x060281A3 RID: 164259 RVA: 0x005832EB File Offset: 0x005814EB
		public void UnPackTo(IWindSourceBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060281A4 RID: 164260 RVA: 0x005832FC File Offset: 0x005814FC
		public static Offset<IWindSourceBase> Pack(FlatBufferBuilder builder, IWindSourceBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindSourceBase>);
			}
			return IWindSourceBase.CreateIWindSourceBase(builder, _o.Type);
		}

		// Token: 0x0400F2DB RID: 62171
		private Table __p;
	}
}
