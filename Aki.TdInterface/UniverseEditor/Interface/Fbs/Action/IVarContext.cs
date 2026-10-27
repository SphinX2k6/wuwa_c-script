using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F0 RID: 29936
	public struct IVarContext : IFlatbufferObject
	{
		// Token: 0x1700E32A RID: 58154
		// (get) Token: 0x060366F5 RID: 222965 RVA: 0x0076551E File Offset: 0x0076371E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060366F6 RID: 222966 RVA: 0x0076552B File Offset: 0x0076372B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060366F7 RID: 222967 RVA: 0x00765534 File Offset: 0x00763734
		public static IVarContext GetRootAsIVarContext(ByteBuffer _bb)
		{
			return IVarContext.GetRootAsIVarContext(_bb, default(IVarContext));
		}

		// Token: 0x060366F8 RID: 222968 RVA: 0x00765550 File Offset: 0x00763750
		public static IVarContext GetRootAsIVarContext(ByteBuffer _bb, IVarContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060366F9 RID: 222969 RVA: 0x0076556D File Offset: 0x0076376D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060366FA RID: 222970 RVA: 0x0076557C File Offset: 0x0076377C
		public IVarContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E32B RID: 58155
		// (get) Token: 0x060366FB RID: 222971 RVA: 0x0076558C File Offset: 0x0076378C
		public EVarContext Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVarContext.None;
				}
				return (EVarContext)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060366FC RID: 222972 RVA: 0x007655C8 File Offset: 0x007637C8
		public static Offset<IVarContext> CreateIVarContext(FlatBufferBuilder builder, EVarContext Type = EVarContext.None)
		{
			builder.StartTable(1);
			IVarContext.AddType(builder, Type);
			return IVarContext.EndIVarContext(builder);
		}

		// Token: 0x060366FD RID: 222973 RVA: 0x007655DE File Offset: 0x007637DE
		public static void StartIVarContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060366FE RID: 222974 RVA: 0x007655E7 File Offset: 0x007637E7
		public static void AddType(FlatBufferBuilder builder, EVarContext type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060366FF RID: 222975 RVA: 0x007655F2 File Offset: 0x007637F2
		public static Offset<IVarContext> EndIVarContext(FlatBufferBuilder builder)
		{
			return new Offset<IVarContext>(builder.EndTable());
		}

		// Token: 0x06036700 RID: 222976 RVA: 0x00765600 File Offset: 0x00763800
		public IVarContextT UnPack()
		{
			IVarContextT varContextT = new IVarContextT();
			this.UnPackTo(varContextT);
			return varContextT;
		}

		// Token: 0x06036701 RID: 222977 RVA: 0x0076561B File Offset: 0x0076381B
		public void UnPackTo(IVarContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036702 RID: 222978 RVA: 0x0076562C File Offset: 0x0076382C
		public static Offset<IVarContext> Pack(FlatBufferBuilder builder, IVarContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarContext>);
			}
			return IVarContext.CreateIVarContext(builder, _o.Type);
		}

		// Token: 0x040123C5 RID: 74693
		private Table __p;
	}
}
