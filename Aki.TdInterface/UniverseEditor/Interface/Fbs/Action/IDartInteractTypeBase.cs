using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAE RID: 27566
	public struct IDartInteractTypeBase : IFlatbufferObject
	{
		// Token: 0x1700CA3E RID: 51774
		// (get) Token: 0x0602F716 RID: 194326 RVA: 0x00678BFC File Offset: 0x00676DFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F717 RID: 194327 RVA: 0x00678C09 File Offset: 0x00676E09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F718 RID: 194328 RVA: 0x00678C10 File Offset: 0x00676E10
		public static IDartInteractTypeBase GetRootAsIDartInteractTypeBase(ByteBuffer _bb)
		{
			return IDartInteractTypeBase.GetRootAsIDartInteractTypeBase(_bb, default(IDartInteractTypeBase));
		}

		// Token: 0x0602F719 RID: 194329 RVA: 0x00678C2C File Offset: 0x00676E2C
		public static IDartInteractTypeBase GetRootAsIDartInteractTypeBase(ByteBuffer _bb, IDartInteractTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F71A RID: 194330 RVA: 0x00678C49 File Offset: 0x00676E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F71B RID: 194331 RVA: 0x00678C58 File Offset: 0x00676E58
		public IDartInteractTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA3F RID: 51775
		// (get) Token: 0x0602F71C RID: 194332 RVA: 0x00678C68 File Offset: 0x00676E68
		public EDartInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartInteractType.Machine;
				}
				return (EDartInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F71D RID: 194333 RVA: 0x00678CA4 File Offset: 0x00676EA4
		public static Offset<IDartInteractTypeBase> CreateIDartInteractTypeBase(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine)
		{
			builder.StartTable(1);
			IDartInteractTypeBase.AddType(builder, Type);
			return IDartInteractTypeBase.EndIDartInteractTypeBase(builder);
		}

		// Token: 0x0602F71E RID: 194334 RVA: 0x00678CBA File Offset: 0x00676EBA
		public static void StartIDartInteractTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F71F RID: 194335 RVA: 0x00678CC3 File Offset: 0x00676EC3
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F720 RID: 194336 RVA: 0x00678CCE File Offset: 0x00676ECE
		public static Offset<IDartInteractTypeBase> EndIDartInteractTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IDartInteractTypeBase>(builder.EndTable());
		}

		// Token: 0x0602F721 RID: 194337 RVA: 0x00678CDC File Offset: 0x00676EDC
		public IDartInteractTypeBaseT UnPack()
		{
			IDartInteractTypeBaseT dartInteractTypeBaseT = new IDartInteractTypeBaseT();
			this.UnPackTo(dartInteractTypeBaseT);
			return dartInteractTypeBaseT;
		}

		// Token: 0x0602F722 RID: 194338 RVA: 0x00678CF7 File Offset: 0x00676EF7
		public void UnPackTo(IDartInteractTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F723 RID: 194339 RVA: 0x00678D08 File Offset: 0x00676F08
		public static Offset<IDartInteractTypeBase> Pack(FlatBufferBuilder builder, IDartInteractTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartInteractTypeBase>);
			}
			return IDartInteractTypeBase.CreateIDartInteractTypeBase(builder, _o.Type);
		}

		// Token: 0x040119A1 RID: 72097
		private Table __p;
	}
}
