using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553C RID: 21820
	public struct IMechFixedPointHook : IFlatbufferObject
	{
		// Token: 0x1700A114 RID: 41236
		// (get) Token: 0x060240CD RID: 147661 RVA: 0x004FAE6D File Offset: 0x004F906D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060240CE RID: 147662 RVA: 0x004FAE7A File Offset: 0x004F907A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060240CF RID: 147663 RVA: 0x004FAE84 File Offset: 0x004F9084
		public static IMechFixedPointHook GetRootAsIMechFixedPointHook(ByteBuffer _bb)
		{
			return IMechFixedPointHook.GetRootAsIMechFixedPointHook(_bb, default(IMechFixedPointHook));
		}

		// Token: 0x060240D0 RID: 147664 RVA: 0x004FAEA0 File Offset: 0x004F90A0
		public static IMechFixedPointHook GetRootAsIMechFixedPointHook(ByteBuffer _bb, IMechFixedPointHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060240D1 RID: 147665 RVA: 0x004FAEBD File Offset: 0x004F90BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060240D2 RID: 147666 RVA: 0x004FAECC File Offset: 0x004F90CC
		public IMechFixedPointHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A115 RID: 41237
		// (get) Token: 0x060240D3 RID: 147667 RVA: 0x004FAEDC File Offset: 0x004F90DC
		public EMechHookConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechHookConfigType.BurrowHook;
				}
				return (EMechHookConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A116 RID: 41238
		// (get) Token: 0x060240D4 RID: 147668 RVA: 0x004FAF18 File Offset: 0x004F9118
		public IMechBehaviorConfig? MechBehaviorConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMechBehaviorConfig?(default(IMechBehaviorConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060240D5 RID: 147669 RVA: 0x004FAF75 File Offset: 0x004F9175
		public static Offset<IMechFixedPointHook> CreateIMechFixedPointHook(FlatBufferBuilder builder, EMechHookConfigType Type = EMechHookConfigType.BurrowHook, Offset<IMechBehaviorConfig> MechBehaviorConfigOffset = default(Offset<IMechBehaviorConfig>))
		{
			builder.StartTable(2);
			IMechFixedPointHook.AddMechBehaviorConfig(builder, MechBehaviorConfigOffset);
			IMechFixedPointHook.AddType(builder, Type);
			return IMechFixedPointHook.EndIMechFixedPointHook(builder);
		}

		// Token: 0x060240D6 RID: 147670 RVA: 0x004FAF92 File Offset: 0x004F9192
		public static void StartIMechFixedPointHook(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060240D7 RID: 147671 RVA: 0x004FAF9B File Offset: 0x004F919B
		public static void AddType(FlatBufferBuilder builder, EMechHookConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060240D8 RID: 147672 RVA: 0x004FAFA6 File Offset: 0x004F91A6
		public static void AddMechBehaviorConfig(FlatBufferBuilder builder, Offset<IMechBehaviorConfig> mechBehaviorConfigOffset)
		{
			builder.AddOffset(1, mechBehaviorConfigOffset.Value, 0);
		}

		// Token: 0x060240D9 RID: 147673 RVA: 0x004FAFB6 File Offset: 0x004F91B6
		public static Offset<IMechFixedPointHook> EndIMechFixedPointHook(FlatBufferBuilder builder)
		{
			return new Offset<IMechFixedPointHook>(builder.EndTable());
		}

		// Token: 0x060240DA RID: 147674 RVA: 0x004FAFC4 File Offset: 0x004F91C4
		public IMechFixedPointHookT UnPack()
		{
			IMechFixedPointHookT mechFixedPointHookT = new IMechFixedPointHookT();
			this.UnPackTo(mechFixedPointHookT);
			return mechFixedPointHookT;
		}

		// Token: 0x060240DB RID: 147675 RVA: 0x004FAFE0 File Offset: 0x004F91E0
		public void UnPackTo(IMechFixedPointHookT _o)
		{
			_o.Type = this.Type;
			_o.MechBehaviorConfig = ((this.MechBehaviorConfig != null) ? this.MechBehaviorConfig.Value.UnPack() : null);
		}

		// Token: 0x060240DC RID: 147676 RVA: 0x004FB028 File Offset: 0x004F9228
		public static Offset<IMechFixedPointHook> Pack(FlatBufferBuilder builder, IMechFixedPointHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechFixedPointHook>);
			}
			Offset<IMechBehaviorConfig> mechBehaviorConfigOffset = (_o.MechBehaviorConfig == null) ? default(Offset<IMechBehaviorConfig>) : IMechBehaviorConfig.Pack(builder, _o.MechBehaviorConfig);
			return IMechFixedPointHook.CreateIMechFixedPointHook(builder, _o.Type, mechBehaviorConfigOffset);
		}

		// Token: 0x0400E83A RID: 59450
		private Table __p;
	}
}
