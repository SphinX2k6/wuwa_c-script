using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CE RID: 22222
	public struct IPasserbyNpcSource : IFlatbufferObject
	{
		// Token: 0x1700A562 RID: 42338
		// (get) Token: 0x060251F2 RID: 152050 RVA: 0x0051FEF0 File Offset: 0x0051E0F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060251F3 RID: 152051 RVA: 0x0051FEFD File Offset: 0x0051E0FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060251F4 RID: 152052 RVA: 0x0051FF04 File Offset: 0x0051E104
		public static IPasserbyNpcSource GetRootAsIPasserbyNpcSource(ByteBuffer _bb)
		{
			return IPasserbyNpcSource.GetRootAsIPasserbyNpcSource(_bb, default(IPasserbyNpcSource));
		}

		// Token: 0x060251F5 RID: 152053 RVA: 0x0051FF20 File Offset: 0x0051E120
		public static IPasserbyNpcSource GetRootAsIPasserbyNpcSource(ByteBuffer _bb, IPasserbyNpcSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060251F6 RID: 152054 RVA: 0x0051FF3D File Offset: 0x0051E13D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060251F7 RID: 152055 RVA: 0x0051FF4C File Offset: 0x0051E14C
		public IPasserbyNpcSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A563 RID: 42339
		// (get) Token: 0x060251F8 RID: 152056 RVA: 0x0051FF5C File Offset: 0x0051E15C
		public EPasserbyNpcSource Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcSource.Template;
				}
				return (EPasserbyNpcSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060251F9 RID: 152057 RVA: 0x0051FF98 File Offset: 0x0051E198
		public static Offset<IPasserbyNpcSource> CreateIPasserbyNpcSource(FlatBufferBuilder builder, EPasserbyNpcSource Type = EPasserbyNpcSource.Template)
		{
			builder.StartTable(1);
			IPasserbyNpcSource.AddType(builder, Type);
			return IPasserbyNpcSource.EndIPasserbyNpcSource(builder);
		}

		// Token: 0x060251FA RID: 152058 RVA: 0x0051FFAE File Offset: 0x0051E1AE
		public static void StartIPasserbyNpcSource(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060251FB RID: 152059 RVA: 0x0051FFB7 File Offset: 0x0051E1B7
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060251FC RID: 152060 RVA: 0x0051FFC2 File Offset: 0x0051E1C2
		public static Offset<IPasserbyNpcSource> EndIPasserbyNpcSource(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSource>(builder.EndTable());
		}

		// Token: 0x060251FD RID: 152061 RVA: 0x0051FFD0 File Offset: 0x0051E1D0
		public IPasserbyNpcSourceT UnPack()
		{
			IPasserbyNpcSourceT passerbyNpcSourceT = new IPasserbyNpcSourceT();
			this.UnPackTo(passerbyNpcSourceT);
			return passerbyNpcSourceT;
		}

		// Token: 0x060251FE RID: 152062 RVA: 0x0051FFEB File Offset: 0x0051E1EB
		public void UnPackTo(IPasserbyNpcSourceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060251FF RID: 152063 RVA: 0x0051FFFC File Offset: 0x0051E1FC
		public static Offset<IPasserbyNpcSource> Pack(FlatBufferBuilder builder, IPasserbyNpcSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSource>);
			}
			return IPasserbyNpcSource.CreateIPasserbyNpcSource(builder, _o.Type);
		}

		// Token: 0x0400EB0C RID: 60172
		private Table __p;
	}
}
