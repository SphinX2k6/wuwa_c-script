using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004590 RID: 17808
	public struct IRollBlockItemBase : IFlatbufferObject
	{
		// Token: 0x17007E85 RID: 32389
		// (get) Token: 0x0601AE69 RID: 110185 RVA: 0x003D69FC File Offset: 0x003D4BFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AE6A RID: 110186 RVA: 0x003D6A09 File Offset: 0x003D4C09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AE6B RID: 110187 RVA: 0x003D6A10 File Offset: 0x003D4C10
		public static IRollBlockItemBase GetRootAsIRollBlockItemBase(ByteBuffer _bb)
		{
			return IRollBlockItemBase.GetRootAsIRollBlockItemBase(_bb, default(IRollBlockItemBase));
		}

		// Token: 0x0601AE6C RID: 110188 RVA: 0x003D6A2C File Offset: 0x003D4C2C
		public static IRollBlockItemBase GetRootAsIRollBlockItemBase(ByteBuffer _bb, IRollBlockItemBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AE6D RID: 110189 RVA: 0x003D6A49 File Offset: 0x003D4C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AE6E RID: 110190 RVA: 0x003D6A58 File Offset: 0x003D4C58
		public IRollBlockItemBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E86 RID: 32390
		// (get) Token: 0x0601AE6F RID: 110191 RVA: 0x003D6A68 File Offset: 0x003D4C68
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

		// Token: 0x0601AE70 RID: 110192 RVA: 0x003D6AA4 File Offset: 0x003D4CA4
		public static Offset<IRollBlockItemBase> CreateIRollBlockItemBase(FlatBufferBuilder builder, ERollBlockItemType Type = ERollBlockItemType.BreakableObstacle)
		{
			builder.StartTable(1);
			IRollBlockItemBase.AddType(builder, Type);
			return IRollBlockItemBase.EndIRollBlockItemBase(builder);
		}

		// Token: 0x0601AE71 RID: 110193 RVA: 0x003D6ABA File Offset: 0x003D4CBA
		public static void StartIRollBlockItemBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AE72 RID: 110194 RVA: 0x003D6AC3 File Offset: 0x003D4CC3
		public static void AddType(FlatBufferBuilder builder, ERollBlockItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AE73 RID: 110195 RVA: 0x003D6ACE File Offset: 0x003D4CCE
		public static Offset<IRollBlockItemBase> EndIRollBlockItemBase(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockItemBase>(builder.EndTable());
		}

		// Token: 0x0601AE74 RID: 110196 RVA: 0x003D6ADC File Offset: 0x003D4CDC
		public IRollBlockItemBaseT UnPack()
		{
			IRollBlockItemBaseT rollBlockItemBaseT = new IRollBlockItemBaseT();
			this.UnPackTo(rollBlockItemBaseT);
			return rollBlockItemBaseT;
		}

		// Token: 0x0601AE75 RID: 110197 RVA: 0x003D6AF7 File Offset: 0x003D4CF7
		public void UnPackTo(IRollBlockItemBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AE76 RID: 110198 RVA: 0x003D6B08 File Offset: 0x003D4D08
		public static Offset<IRollBlockItemBase> Pack(FlatBufferBuilder builder, IRollBlockItemBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockItemBase>);
			}
			return IRollBlockItemBase.CreateIRollBlockItemBase(builder, _o.Type);
		}

		// Token: 0x0400C64A RID: 50762
		private Table __p;
	}
}
