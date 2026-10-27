using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB5 RID: 19637
	public struct IRoleLevelType : IFlatbufferObject
	{
		// Token: 0x17008E97 RID: 36503
		// (get) Token: 0x0601F28B RID: 127627 RVA: 0x0045A03C File Offset: 0x0045823C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F28C RID: 127628 RVA: 0x0045A049 File Offset: 0x00458249
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F28D RID: 127629 RVA: 0x0045A050 File Offset: 0x00458250
		public static IRoleLevelType GetRootAsIRoleLevelType(ByteBuffer _bb)
		{
			return IRoleLevelType.GetRootAsIRoleLevelType(_bb, default(IRoleLevelType));
		}

		// Token: 0x0601F28E RID: 127630 RVA: 0x0045A06C File Offset: 0x0045826C
		public static IRoleLevelType GetRootAsIRoleLevelType(ByteBuffer _bb, IRoleLevelType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F28F RID: 127631 RVA: 0x0045A089 File Offset: 0x00458289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F290 RID: 127632 RVA: 0x0045A098 File Offset: 0x00458298
		public IRoleLevelType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E98 RID: 36504
		// (get) Token: 0x0601F291 RID: 127633 RVA: 0x0045A0A8 File Offset: 0x004582A8
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

		// Token: 0x0601F292 RID: 127634 RVA: 0x0045A0E4 File Offset: 0x004582E4
		public static Offset<IRoleLevelType> CreateIRoleLevelType(FlatBufferBuilder builder, ERoleLevelType Type = ERoleLevelType.SpecifyRole)
		{
			builder.StartTable(1);
			IRoleLevelType.AddType(builder, Type);
			return IRoleLevelType.EndIRoleLevelType(builder);
		}

		// Token: 0x0601F293 RID: 127635 RVA: 0x0045A0FA File Offset: 0x004582FA
		public static void StartIRoleLevelType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F294 RID: 127636 RVA: 0x0045A103 File Offset: 0x00458303
		public static void AddType(FlatBufferBuilder builder, ERoleLevelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F295 RID: 127637 RVA: 0x0045A10E File Offset: 0x0045830E
		public static Offset<IRoleLevelType> EndIRoleLevelType(FlatBufferBuilder builder)
		{
			return new Offset<IRoleLevelType>(builder.EndTable());
		}

		// Token: 0x0601F296 RID: 127638 RVA: 0x0045A11C File Offset: 0x0045831C
		public IRoleLevelTypeT UnPack()
		{
			IRoleLevelTypeT roleLevelTypeT = new IRoleLevelTypeT();
			this.UnPackTo(roleLevelTypeT);
			return roleLevelTypeT;
		}

		// Token: 0x0601F297 RID: 127639 RVA: 0x0045A137 File Offset: 0x00458337
		public void UnPackTo(IRoleLevelTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F298 RID: 127640 RVA: 0x0045A148 File Offset: 0x00458348
		public static Offset<IRoleLevelType> Pack(FlatBufferBuilder builder, IRoleLevelTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleLevelType>);
			}
			return IRoleLevelType.CreateIRoleLevelType(builder, _o.Type);
		}

		// Token: 0x0400D678 RID: 54904
		private Table __p;
	}
}
