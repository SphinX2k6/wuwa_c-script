using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D55 RID: 15701
	public struct ICheckPlayerBattleAttribute : IFlatbufferObject
	{
		// Token: 0x17006BC4 RID: 27588
		// (get) Token: 0x06015B83 RID: 88963 RVA: 0x0032223D File Offset: 0x0032043D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B84 RID: 88964 RVA: 0x0032224A File Offset: 0x0032044A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B85 RID: 88965 RVA: 0x00322254 File Offset: 0x00320454
		public static ICheckPlayerBattleAttribute GetRootAsICheckPlayerBattleAttribute(ByteBuffer _bb)
		{
			return ICheckPlayerBattleAttribute.GetRootAsICheckPlayerBattleAttribute(_bb, default(ICheckPlayerBattleAttribute));
		}

		// Token: 0x06015B86 RID: 88966 RVA: 0x00322270 File Offset: 0x00320470
		public static ICheckPlayerBattleAttribute GetRootAsICheckPlayerBattleAttribute(ByteBuffer _bb, ICheckPlayerBattleAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B87 RID: 88967 RVA: 0x0032228D File Offset: 0x0032048D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B88 RID: 88968 RVA: 0x0032229C File Offset: 0x0032049C
		public ICheckPlayerBattleAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BC5 RID: 27589
		// (get) Token: 0x06015B89 RID: 88969 RVA: 0x003222AC File Offset: 0x003204AC
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

		// Token: 0x17006BC6 RID: 27590
		// (get) Token: 0x06015B8A RID: 88970 RVA: 0x003222E8 File Offset: 0x003204E8
		public IHealthAttributeToTarget? Option
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IHealthAttributeToTarget?(default(IHealthAttributeToTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015B8B RID: 88971 RVA: 0x00322345 File Offset: 0x00320545
		public static Offset<ICheckPlayerBattleAttribute> CreateICheckPlayerBattleAttribute(FlatBufferBuilder builder, ETargetBattleAttribute Type = ETargetBattleAttribute.Player, Offset<IHealthAttributeToTarget> OptionOffset = default(Offset<IHealthAttributeToTarget>))
		{
			builder.StartTable(2);
			ICheckPlayerBattleAttribute.AddOption(builder, OptionOffset);
			ICheckPlayerBattleAttribute.AddType(builder, Type);
			return ICheckPlayerBattleAttribute.EndICheckPlayerBattleAttribute(builder);
		}

		// Token: 0x06015B8C RID: 88972 RVA: 0x00322362 File Offset: 0x00320562
		public static void StartICheckPlayerBattleAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015B8D RID: 88973 RVA: 0x0032236B File Offset: 0x0032056B
		public static void AddType(FlatBufferBuilder builder, ETargetBattleAttribute type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015B8E RID: 88974 RVA: 0x00322376 File Offset: 0x00320576
		public static void AddOption(FlatBufferBuilder builder, Offset<IHealthAttributeToTarget> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x06015B8F RID: 88975 RVA: 0x00322386 File Offset: 0x00320586
		public static Offset<ICheckPlayerBattleAttribute> EndICheckPlayerBattleAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerBattleAttribute>(builder.EndTable());
		}

		// Token: 0x06015B90 RID: 88976 RVA: 0x00322394 File Offset: 0x00320594
		public ICheckPlayerBattleAttributeT UnPack()
		{
			ICheckPlayerBattleAttributeT checkPlayerBattleAttributeT = new ICheckPlayerBattleAttributeT();
			this.UnPackTo(checkPlayerBattleAttributeT);
			return checkPlayerBattleAttributeT;
		}

		// Token: 0x06015B91 RID: 88977 RVA: 0x003223B0 File Offset: 0x003205B0
		public void UnPackTo(ICheckPlayerBattleAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x06015B92 RID: 88978 RVA: 0x003223F8 File Offset: 0x003205F8
		public static Offset<ICheckPlayerBattleAttribute> Pack(FlatBufferBuilder builder, ICheckPlayerBattleAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerBattleAttribute>);
			}
			Offset<IHealthAttributeToTarget> optionOffset = (_o.Option == null) ? default(Offset<IHealthAttributeToTarget>) : IHealthAttributeToTarget.Pack(builder, _o.Option);
			return ICheckPlayerBattleAttribute.CreateICheckPlayerBattleAttribute(builder, _o.Type, optionOffset);
		}

		// Token: 0x0400B633 RID: 46643
		private Table __p;
	}
}
