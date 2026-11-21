using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ED4 RID: 16084
	public struct ISystemVarBase : IFlatbufferObject
	{
		// Token: 0x17006CE7 RID: 27879
		// (get) Token: 0x06015C6F RID: 89199 RVA: 0x00322172 File Offset: 0x00320372
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C70 RID: 89200 RVA: 0x0032217F File Offset: 0x0032037F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C71 RID: 89201 RVA: 0x00322188 File Offset: 0x00320388
		public static ISystemVarBase GetRootAsISystemVarBase(ByteBuffer _bb)
		{
			return ISystemVarBase.GetRootAsISystemVarBase(_bb, default(ISystemVarBase));
		}

		// Token: 0x06015C72 RID: 89202 RVA: 0x003221A4 File Offset: 0x003203A4
		public static ISystemVarBase GetRootAsISystemVarBase(ByteBuffer _bb, ISystemVarBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C73 RID: 89203 RVA: 0x003221C1 File Offset: 0x003203C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C74 RID: 89204 RVA: 0x003221D0 File Offset: 0x003203D0
		public ISystemVarBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CE8 RID: 27880
		// (get) Token: 0x06015C75 RID: 89205 RVA: 0x003221E0 File Offset: 0x003203E0
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015C76 RID: 89206 RVA: 0x0032221C File Offset: 0x0032041C
		public static Offset<ISystemVarBase> CreateISystemVarBase(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			ISystemVarBase.AddType(builder, Type);
			return ISystemVarBase.EndISystemVarBase(builder);
		}

		// Token: 0x06015C77 RID: 89207 RVA: 0x00322232 File Offset: 0x00320432
		public static void StartISystemVarBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015C78 RID: 89208 RVA: 0x0032223B File Offset: 0x0032043B
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C79 RID: 89209 RVA: 0x00322246 File Offset: 0x00320446
		public static Offset<ISystemVarBase> EndISystemVarBase(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarBase>(builder.EndTable());
		}

		// Token: 0x06015C7A RID: 89210 RVA: 0x00322254 File Offset: 0x00320454
		public ISystemVarBaseT UnPack()
		{
			ISystemVarBaseT systemVarBaseT = new ISystemVarBaseT();
			this.UnPackTo(systemVarBaseT);
			return systemVarBaseT;
		}

		// Token: 0x06015C7B RID: 89211 RVA: 0x0032226F File Offset: 0x0032046F
		public void UnPackTo(ISystemVarBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015C7C RID: 89212 RVA: 0x00322280 File Offset: 0x00320480
		public static Offset<ISystemVarBase> Pack(FlatBufferBuilder builder, ISystemVarBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemVarBase>);
			}
			return ISystemVarBase.CreateISystemVarBase(builder, _o.Type);
		}

		// Token: 0x0400B8E2 RID: 47330
		private Table __p;
	}
}
