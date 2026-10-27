using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006765 RID: 26469
	public struct IFadeBackgroundFadeInEffectTypeBase : IFlatbufferObject
	{
		// Token: 0x1700C47F RID: 50303
		// (get) Token: 0x0602E0C3 RID: 188611 RVA: 0x0064AC29 File Offset: 0x00648E29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E0C4 RID: 188612 RVA: 0x0064AC36 File Offset: 0x00648E36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E0C5 RID: 188613 RVA: 0x0064AC40 File Offset: 0x00648E40
		public static IFadeBackgroundFadeInEffectTypeBase GetRootAsIFadeBackgroundFadeInEffectTypeBase(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffectTypeBase.GetRootAsIFadeBackgroundFadeInEffectTypeBase(_bb, default(IFadeBackgroundFadeInEffectTypeBase));
		}

		// Token: 0x0602E0C6 RID: 188614 RVA: 0x0064AC5C File Offset: 0x00648E5C
		public static IFadeBackgroundFadeInEffectTypeBase GetRootAsIFadeBackgroundFadeInEffectTypeBase(ByteBuffer _bb, IFadeBackgroundFadeInEffectTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E0C7 RID: 188615 RVA: 0x0064AC79 File Offset: 0x00648E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E0C8 RID: 188616 RVA: 0x0064AC88 File Offset: 0x00648E88
		public IFadeBackgroundFadeInEffectTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C480 RID: 50304
		// (get) Token: 0x0602E0C9 RID: 188617 RVA: 0x0064AC98 File Offset: 0x00648E98
		public EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundFadeInEffectType.Black;
				}
				return (EFadeBackgroundFadeInEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E0CA RID: 188618 RVA: 0x0064ACD4 File Offset: 0x00648ED4
		public static Offset<IFadeBackgroundFadeInEffectTypeBase> CreateIFadeBackgroundFadeInEffectTypeBase(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType Type = EFadeBackgroundFadeInEffectType.Black)
		{
			builder.StartTable(1);
			IFadeBackgroundFadeInEffectTypeBase.AddType(builder, Type);
			return IFadeBackgroundFadeInEffectTypeBase.EndIFadeBackgroundFadeInEffectTypeBase(builder);
		}

		// Token: 0x0602E0CB RID: 188619 RVA: 0x0064ACEA File Offset: 0x00648EEA
		public static void StartIFadeBackgroundFadeInEffectTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E0CC RID: 188620 RVA: 0x0064ACF3 File Offset: 0x00648EF3
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E0CD RID: 188621 RVA: 0x0064ACFE File Offset: 0x00648EFE
		public static Offset<IFadeBackgroundFadeInEffectTypeBase> EndIFadeBackgroundFadeInEffectTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffectTypeBase>(builder.EndTable());
		}

		// Token: 0x0602E0CE RID: 188622 RVA: 0x0064AD0C File Offset: 0x00648F0C
		public IFadeBackgroundFadeInEffectTypeBaseT UnPack()
		{
			IFadeBackgroundFadeInEffectTypeBaseT fadeBackgroundFadeInEffectTypeBaseT = new IFadeBackgroundFadeInEffectTypeBaseT();
			this.UnPackTo(fadeBackgroundFadeInEffectTypeBaseT);
			return fadeBackgroundFadeInEffectTypeBaseT;
		}

		// Token: 0x0602E0CF RID: 188623 RVA: 0x0064AD27 File Offset: 0x00648F27
		public void UnPackTo(IFadeBackgroundFadeInEffectTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E0D0 RID: 188624 RVA: 0x0064AD38 File Offset: 0x00648F38
		public static Offset<IFadeBackgroundFadeInEffectTypeBase> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeInEffectTypeBase>);
			}
			return IFadeBackgroundFadeInEffectTypeBase.CreateIFadeBackgroundFadeInEffectTypeBase(builder, _o.Type);
		}

		// Token: 0x04010E59 RID: 69209
		private Table __p;
	}
}
