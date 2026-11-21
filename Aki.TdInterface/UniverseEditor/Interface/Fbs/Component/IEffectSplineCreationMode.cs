using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567C RID: 22140
	public struct IEffectSplineCreationMode : IFlatbufferObject
	{
		// Token: 0x17009F2E RID: 40750
		// (get) Token: 0x06023692 RID: 145042 RVA: 0x004DEF26 File Offset: 0x004DD126
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023693 RID: 145043 RVA: 0x004DEF33 File Offset: 0x004DD133
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023694 RID: 145044 RVA: 0x004DEF3C File Offset: 0x004DD13C
		public static IEffectSplineCreationMode GetRootAsIEffectSplineCreationMode(ByteBuffer _bb)
		{
			return IEffectSplineCreationMode.GetRootAsIEffectSplineCreationMode(_bb, default(IEffectSplineCreationMode));
		}

		// Token: 0x06023695 RID: 145045 RVA: 0x004DEF58 File Offset: 0x004DD158
		public static IEffectSplineCreationMode GetRootAsIEffectSplineCreationMode(ByteBuffer _bb, IEffectSplineCreationMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023696 RID: 145046 RVA: 0x004DEF75 File Offset: 0x004DD175
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023697 RID: 145047 RVA: 0x004DEF84 File Offset: 0x004DD184
		public IEffectSplineCreationMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F2F RID: 40751
		// (get) Token: 0x06023698 RID: 145048 RVA: 0x004DEF94 File Offset: 0x004DD194
		public EEffectSplineCreateMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectSplineCreateMode.WholeLine;
				}
				return (EEffectSplineCreateMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023699 RID: 145049 RVA: 0x004DEFD0 File Offset: 0x004DD1D0
		public static Offset<IEffectSplineCreationMode> CreateIEffectSplineCreationMode(FlatBufferBuilder builder, EEffectSplineCreateMode Type = EEffectSplineCreateMode.WholeLine)
		{
			builder.StartTable(1);
			IEffectSplineCreationMode.AddType(builder, Type);
			return IEffectSplineCreationMode.EndIEffectSplineCreationMode(builder);
		}

		// Token: 0x0602369A RID: 145050 RVA: 0x004DEFE6 File Offset: 0x004DD1E6
		public static void StartIEffectSplineCreationMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602369B RID: 145051 RVA: 0x004DEFEF File Offset: 0x004DD1EF
		public static void AddType(FlatBufferBuilder builder, EEffectSplineCreateMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602369C RID: 145052 RVA: 0x004DEFFA File Offset: 0x004DD1FA
		public static Offset<IEffectSplineCreationMode> EndIEffectSplineCreationMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSplineCreationMode>(builder.EndTable());
		}

		// Token: 0x0602369D RID: 145053 RVA: 0x004DF008 File Offset: 0x004DD208
		public IEffectSplineCreationModeT UnPack()
		{
			IEffectSplineCreationModeT effectSplineCreationModeT = new IEffectSplineCreationModeT();
			this.UnPackTo(effectSplineCreationModeT);
			return effectSplineCreationModeT;
		}

		// Token: 0x0602369E RID: 145054 RVA: 0x004DF023 File Offset: 0x004DD223
		public void UnPackTo(IEffectSplineCreationModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602369F RID: 145055 RVA: 0x004DF034 File Offset: 0x004DD234
		public static Offset<IEffectSplineCreationMode> Pack(FlatBufferBuilder builder, IEffectSplineCreationModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectSplineCreationMode>);
			}
			return IEffectSplineCreationMode.CreateIEffectSplineCreationMode(builder, _o.Type);
		}

		// Token: 0x0400ED86 RID: 60806
		private Table __p;
	}
}
