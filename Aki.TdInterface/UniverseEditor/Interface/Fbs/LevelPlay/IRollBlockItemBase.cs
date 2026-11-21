using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049F8 RID: 18936
	public struct IRollBlockItemBase : IFlatbufferObject
	{
		// Token: 0x170084C6 RID: 33990
		// (get) Token: 0x0601C63E RID: 116286 RVA: 0x00402C98 File Offset: 0x00400E98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C63F RID: 116287 RVA: 0x00402CA5 File Offset: 0x00400EA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C640 RID: 116288 RVA: 0x00402CAC File Offset: 0x00400EAC
		public static IRollBlockItemBase GetRootAsIRollBlockItemBase(ByteBuffer _bb)
		{
			return IRollBlockItemBase.GetRootAsIRollBlockItemBase(_bb, default(IRollBlockItemBase));
		}

		// Token: 0x0601C641 RID: 116289 RVA: 0x00402CC8 File Offset: 0x00400EC8
		public static IRollBlockItemBase GetRootAsIRollBlockItemBase(ByteBuffer _bb, IRollBlockItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C642 RID: 116290 RVA: 0x00402CE5 File Offset: 0x00400EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C643 RID: 116291 RVA: 0x00402CF4 File Offset: 0x00400EF4
		public IRollBlockItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084C7 RID: 33991
		// (get) Token: 0x0601C644 RID: 116292 RVA: 0x00402D04 File Offset: 0x00400F04
		public ERollBlockItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockItemType.BreakableObstacle;
				}
				return (ERollBlockItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C645 RID: 116293 RVA: 0x00402D40 File Offset: 0x00400F40
		public static Offset<IRollBlockItemBase> CreateIRollBlockItemBase(FlatBufferBuilder builder, ERollBlockItemType Type = ERollBlockItemType.BreakableObstacle)
		{
			builder.StartTable(1);
			IRollBlockItemBase.AddType(builder, Type);
			return IRollBlockItemBase.EndIRollBlockItemBase(builder);
		}

		// Token: 0x0601C646 RID: 116294 RVA: 0x00402D56 File Offset: 0x00400F56
		public static void StartIRollBlockItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C647 RID: 116295 RVA: 0x00402D5F File Offset: 0x00400F5F
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C648 RID: 116296 RVA: 0x00402D6A File Offset: 0x00400F6A
		public static Offset<IRollBlockItemBase> EndIRollBlockItemBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemBase>(builder.EndTable());
		}

		// Token: 0x0601C649 RID: 116297 RVA: 0x00402D78 File Offset: 0x00400F78
		public IRollBlockItemBaseT UnPack()
		{
			IRollBlockItemBaseT rollBlockItemBaseT = new IRollBlockItemBaseT();
			this.UnPackTo(rollBlockItemBaseT);
			return rollBlockItemBaseT;
		}

		// Token: 0x0601C64A RID: 116298 RVA: 0x00402D93 File Offset: 0x00400F93
		public void UnPackTo(IRollBlockItemBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C64B RID: 116299 RVA: 0x00402DA4 File Offset: 0x00400FA4
		public static Offset<IRollBlockItemBase> Pack(FlatBufferBuilder builder, IRollBlockItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemBase>);
			}
			return IRollBlockItemBase.CreateIRollBlockItemBase(builder, _o.Type);
		}

		// Token: 0x0400D079 RID: 53369
		private Table __p;
	}
}
