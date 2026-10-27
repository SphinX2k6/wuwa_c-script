using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD2 RID: 15058
	public struct ISystemVarBase : IFlatbufferObject
	{
		// Token: 0x1700674C RID: 26444
		// (get) Token: 0x060147C5 RID: 83909 RVA: 0x002FBEE2 File Offset: 0x002FA0E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060147C6 RID: 83910 RVA: 0x002FBEEF File Offset: 0x002FA0EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060147C7 RID: 83911 RVA: 0x002FBEF8 File Offset: 0x002FA0F8
		public static ISystemVarBase GetRootAsISystemVarBase(ByteBuffer _bb)
		{
			return ISystemVarBase.GetRootAsISystemVarBase(_bb, default(ISystemVarBase));
		}

		// Token: 0x060147C8 RID: 83912 RVA: 0x002FBF14 File Offset: 0x002FA114
		public static ISystemVarBase GetRootAsISystemVarBase(ByteBuffer _bb, ISystemVarBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060147C9 RID: 83913 RVA: 0x002FBF31 File Offset: 0x002FA131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060147CA RID: 83914 RVA: 0x002FBF40 File Offset: 0x002FA140
		public ISystemVarBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700674D RID: 26445
		// (get) Token: 0x060147CB RID: 83915 RVA: 0x002FBF50 File Offset: 0x002FA150
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

		// Token: 0x060147CC RID: 83916 RVA: 0x002FBF8C File Offset: 0x002FA18C
		public static Offset<ISystemVarBase> CreateISystemVarBase(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar)
		{
			builder.StartTable(1);
			ISystemVarBase.AddType(builder, Type);
			return ISystemVarBase.EndISystemVarBase(builder);
		}

		// Token: 0x060147CD RID: 83917 RVA: 0x002FBFA2 File Offset: 0x002FA1A2
		public static void StartISystemVarBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060147CE RID: 83918 RVA: 0x002FBFAB File Offset: 0x002FA1AB
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060147CF RID: 83919 RVA: 0x002FBFB6 File Offset: 0x002FA1B6
		public static Offset<ISystemVarBase> EndISystemVarBase(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarBase>(builder.EndTable());
		}

		// Token: 0x060147D0 RID: 83920 RVA: 0x002FBFC4 File Offset: 0x002FA1C4
		public ISystemVarBaseT UnPack()
		{
			ISystemVarBaseT systemVarBaseT = new ISystemVarBaseT();
			this.UnPackTo(systemVarBaseT);
			return systemVarBaseT;
		}

		// Token: 0x060147D1 RID: 83921 RVA: 0x002FBFDF File Offset: 0x002FA1DF
		public void UnPackTo(ISystemVarBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060147D2 RID: 83922 RVA: 0x002FBFF0 File Offset: 0x002FA1F0
		public static Offset<ISystemVarBase> Pack(FlatBufferBuilder builder, ISystemVarBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemVarBase>);
			}
			return ISystemVarBase.CreateISystemVarBase(builder, _o.Type);
		}

		// Token: 0x0400AF75 RID: 44917
		private Table __p;
	}
}
