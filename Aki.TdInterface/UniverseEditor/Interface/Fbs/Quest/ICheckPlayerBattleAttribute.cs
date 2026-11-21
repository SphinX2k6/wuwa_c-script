using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416C RID: 16748
	public struct ICheckPlayerBattleAttribute : IFlatbufferObject
	{
		// Token: 0x1700717E RID: 29054
		// (get) Token: 0x060170BB RID: 94395 RVA: 0x003494B5 File Offset: 0x003476B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060170BC RID: 94396 RVA: 0x003494C2 File Offset: 0x003476C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060170BD RID: 94397 RVA: 0x003494CC File Offset: 0x003476CC
		public static ICheckPlayerBattleAttribute GetRootAsICheckPlayerBattleAttribute(ByteBuffer _bb)
		{
			return ICheckPlayerBattleAttribute.GetRootAsICheckPlayerBattleAttribute(_bb, default(ICheckPlayerBattleAttribute));
		}

		// Token: 0x060170BE RID: 94398 RVA: 0x003494E8 File Offset: 0x003476E8
		public static ICheckPlayerBattleAttribute GetRootAsICheckPlayerBattleAttribute(ByteBuffer _bb, ICheckPlayerBattleAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060170BF RID: 94399 RVA: 0x00349505 File Offset: 0x00347705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060170C0 RID: 94400 RVA: 0x00349514 File Offset: 0x00347714
		public ICheckPlayerBattleAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700717F RID: 29055
		// (get) Token: 0x060170C1 RID: 94401 RVA: 0x00349524 File Offset: 0x00347724
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

		// Token: 0x17007180 RID: 29056
		// (get) Token: 0x060170C2 RID: 94402 RVA: 0x00349560 File Offset: 0x00347760
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

		// Token: 0x060170C3 RID: 94403 RVA: 0x003495BD File Offset: 0x003477BD
		public static Offset<ICheckPlayerBattleAttribute> CreateICheckPlayerBattleAttribute(FlatBufferBuilder builder, ETargetBattleAttribute Type = ETargetBattleAttribute.Player, Offset<IHealthAttributeToTarget> OptionOffset = default(Offset<IHealthAttributeToTarget>))
		{
			builder.StartTable(2);
			ICheckPlayerBattleAttribute.AddOption(builder, OptionOffset);
			ICheckPlayerBattleAttribute.AddType(builder, Type);
			return ICheckPlayerBattleAttribute.EndICheckPlayerBattleAttribute(builder);
		}

		// Token: 0x060170C4 RID: 94404 RVA: 0x003495DA File Offset: 0x003477DA
		public static void StartICheckPlayerBattleAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060170C5 RID: 94405 RVA: 0x003495E3 File Offset: 0x003477E3
		public static void AddType(FlatBufferBuilder builder, ETargetBattleAttribute type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060170C6 RID: 94406 RVA: 0x003495EE File Offset: 0x003477EE
		public static void AddOption(FlatBufferBuilder builder, Offset<IHealthAttributeToTarget> optionOffset)
		{
			builder.AddOffset(1, optionOffset.Value, 0);
		}

		// Token: 0x060170C7 RID: 94407 RVA: 0x003495FE File Offset: 0x003477FE
		public static Offset<ICheckPlayerBattleAttribute> EndICheckPlayerBattleAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerBattleAttribute>(builder.EndTable());
		}

		// Token: 0x060170C8 RID: 94408 RVA: 0x0034960C File Offset: 0x0034780C
		public ICheckPlayerBattleAttributeT UnPack()
		{
			ICheckPlayerBattleAttributeT checkPlayerBattleAttributeT = new ICheckPlayerBattleAttributeT();
			this.UnPackTo(checkPlayerBattleAttributeT);
			return checkPlayerBattleAttributeT;
		}

		// Token: 0x060170C9 RID: 94409 RVA: 0x00349628 File Offset: 0x00347828
		public void UnPackTo(ICheckPlayerBattleAttributeT _o)
		{
			_o.Type = this.Type;
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
		}

		// Token: 0x060170CA RID: 94410 RVA: 0x00349670 File Offset: 0x00347870
		public static Offset<ICheckPlayerBattleAttribute> Pack(FlatBufferBuilder builder, ICheckPlayerBattleAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerBattleAttribute>);
			}
			Offset<IHealthAttributeToTarget> optionOffset = (_o.Option == null) ? default(Offset<IHealthAttributeToTarget>) : IHealthAttributeToTarget.Pack(builder, _o.Option);
			return ICheckPlayerBattleAttribute.CreateICheckPlayerBattleAttribute(builder, _o.Type, optionOffset);
		}

		// Token: 0x0400BFE0 RID: 49120
		private Table __p;
	}
}
