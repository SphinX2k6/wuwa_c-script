using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200460A RID: 17930
	public struct ITargetBattleAttribute : IFlatbufferObject
	{
		// Token: 0x17007D72 RID: 32114
		// (get) Token: 0x0601A384 RID: 107396 RVA: 0x003BBE43 File Offset: 0x003BA043
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A385 RID: 107397 RVA: 0x003BBE50 File Offset: 0x003BA050
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A386 RID: 107398 RVA: 0x003BBE58 File Offset: 0x003BA058
		public static ITargetBattleAttribute GetRootAsITargetBattleAttribute(ByteBuffer _bb)
		{
			return ITargetBattleAttribute.GetRootAsITargetBattleAttribute(_bb, default(ITargetBattleAttribute));
		}

		// Token: 0x0601A387 RID: 107399 RVA: 0x003BBE74 File Offset: 0x003BA074
		public static ITargetBattleAttribute GetRootAsITargetBattleAttribute(ByteBuffer _bb, ITargetBattleAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A388 RID: 107400 RVA: 0x003BBE91 File Offset: 0x003BA091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A389 RID: 107401 RVA: 0x003BBEA0 File Offset: 0x003BA0A0
		public ITargetBattleAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D73 RID: 32115
		// (get) Token: 0x0601A38A RID: 107402 RVA: 0x003BBEB0 File Offset: 0x003BA0B0
		public ETargetBattleAttribute Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetBattleAttribute.Player;
				}
				return (ETargetBattleAttribute)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A38B RID: 107403 RVA: 0x003BBEEC File Offset: 0x003BA0EC
		public static Offset<ITargetBattleAttribute> CreateITargetBattleAttribute(FlatBufferBuilder builder, ETargetBattleAttribute Type = ETargetBattleAttribute.Player)
		{
			builder.StartTable(1);
			ITargetBattleAttribute.AddType(builder, Type);
			return ITargetBattleAttribute.EndITargetBattleAttribute(builder);
		}

		// Token: 0x0601A38C RID: 107404 RVA: 0x003BBF02 File Offset: 0x003BA102
		public static void StartITargetBattleAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A38D RID: 107405 RVA: 0x003BBF0B File Offset: 0x003BA10B
		public static void AddType(FlatBufferBuilder builder, ETargetBattleAttribute type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A38E RID: 107406 RVA: 0x003BBF16 File Offset: 0x003BA116
		public static Offset<ITargetBattleAttribute> EndITargetBattleAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ITargetBattleAttribute>(builder.EndTable());
		}

		// Token: 0x0601A38F RID: 107407 RVA: 0x003BBF24 File Offset: 0x003BA124
		public ITargetBattleAttributeT UnPack()
		{
			ITargetBattleAttributeT targetBattleAttributeT = new ITargetBattleAttributeT();
			this.UnPackTo(targetBattleAttributeT);
			return targetBattleAttributeT;
		}

		// Token: 0x0601A390 RID: 107408 RVA: 0x003BBF3F File Offset: 0x003BA13F
		public void UnPackTo(ITargetBattleAttributeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A391 RID: 107409 RVA: 0x003BBF50 File Offset: 0x003BA150
		public static Offset<ITargetBattleAttribute> Pack(FlatBufferBuilder builder, ITargetBattleAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetBattleAttribute>);
			}
			return ITargetBattleAttribute.CreateITargetBattleAttribute(builder, _o.Type);
		}

		// Token: 0x0400C7FC RID: 51196
		private Table __p;
	}
}
