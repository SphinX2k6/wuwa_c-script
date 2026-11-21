using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051AE RID: 20910
	public struct IRoleLevelType : IFlatbufferObject
	{
		// Token: 0x170095C5 RID: 38341
		// (get) Token: 0x06020EAD RID: 134829 RVA: 0x0048DB8C File Offset: 0x0048BD8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020EAE RID: 134830 RVA: 0x0048DB99 File Offset: 0x0048BD99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020EAF RID: 134831 RVA: 0x0048DBA0 File Offset: 0x0048BDA0
		public static IRoleLevelType GetRootAsIRoleLevelType(ByteBuffer _bb)
		{
			return IRoleLevelType.GetRootAsIRoleLevelType(_bb, default(IRoleLevelType));
		}

		// Token: 0x06020EB0 RID: 134832 RVA: 0x0048DBBC File Offset: 0x0048BDBC
		public static IRoleLevelType GetRootAsIRoleLevelType(ByteBuffer _bb, IRoleLevelType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020EB1 RID: 134833 RVA: 0x0048DBD9 File Offset: 0x0048BDD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020EB2 RID: 134834 RVA: 0x0048DBE8 File Offset: 0x0048BDE8
		public IRoleLevelType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095C6 RID: 38342
		// (get) Token: 0x06020EB3 RID: 134835 RVA: 0x0048DBF8 File Offset: 0x0048BDF8
		public ERoleLevelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleLevelType.SpecifyRole;
				}
				return (ERoleLevelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020EB4 RID: 134836 RVA: 0x0048DC34 File Offset: 0x0048BE34
		public static Offset<IRoleLevelType> CreateIRoleLevelType(FlatBufferBuilder builder, ERoleLevelType Type = ERoleLevelType.SpecifyRole)
		{
			builder.StartTable(1);
			IRoleLevelType.AddType(builder, Type);
			return IRoleLevelType.EndIRoleLevelType(builder);
		}

		// Token: 0x06020EB5 RID: 134837 RVA: 0x0048DC4A File Offset: 0x0048BE4A
		public static void StartIRoleLevelType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020EB6 RID: 134838 RVA: 0x0048DC53 File Offset: 0x0048BE53
		public static void AddType(FlatBufferBuilder builder, ERoleLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020EB7 RID: 134839 RVA: 0x0048DC5E File Offset: 0x0048BE5E
		public static Offset<IRoleLevelType> EndIRoleLevelType(FlatBufferBuilder builder)
		{
			return new Offset<IRoleLevelType>(builder.EndTable());
		}

		// Token: 0x06020EB8 RID: 134840 RVA: 0x0048DC6C File Offset: 0x0048BE6C
		public IRoleLevelTypeT UnPack()
		{
			IRoleLevelTypeT roleLevelTypeT = new IRoleLevelTypeT();
			this.UnPackTo(roleLevelTypeT);
			return roleLevelTypeT;
		}

		// Token: 0x06020EB9 RID: 134841 RVA: 0x0048DC87 File Offset: 0x0048BE87
		public void UnPackTo(IRoleLevelTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020EBA RID: 134842 RVA: 0x0048DC98 File Offset: 0x0048BE98
		public static Offset<IRoleLevelType> Pack(FlatBufferBuilder builder, IRoleLevelTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleLevelType>);
			}
			return IRoleLevelType.CreateIRoleLevelType(builder, _o.Type);
		}

		// Token: 0x0400E19F RID: 57759
		private Table __p;
	}
}
