using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005117 RID: 20759
	public struct IEffectSplineCreationMode : IFlatbufferObject
	{
		// Token: 0x17009741 RID: 38721
		// (get) Token: 0x0602173E RID: 137022 RVA: 0x004A4F9A File Offset: 0x004A319A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602173F RID: 137023 RVA: 0x004A4FA7 File Offset: 0x004A31A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021740 RID: 137024 RVA: 0x004A4FB0 File Offset: 0x004A31B0
		public static IEffectSplineCreationMode GetRootAsIEffectSplineCreationMode(ByteBuffer _bb)
		{
			return IEffectSplineCreationMode.GetRootAsIEffectSplineCreationMode(_bb, default(IEffectSplineCreationMode));
		}

		// Token: 0x06021741 RID: 137025 RVA: 0x004A4FCC File Offset: 0x004A31CC
		public static IEffectSplineCreationMode GetRootAsIEffectSplineCreationMode(ByteBuffer _bb, IEffectSplineCreationMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021742 RID: 137026 RVA: 0x004A4FE9 File Offset: 0x004A31E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021743 RID: 137027 RVA: 0x004A4FF8 File Offset: 0x004A31F8
		public IEffectSplineCreationMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009742 RID: 38722
		// (get) Token: 0x06021744 RID: 137028 RVA: 0x004A5008 File Offset: 0x004A3208
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

		// Token: 0x06021745 RID: 137029 RVA: 0x004A5044 File Offset: 0x004A3244
		public static Offset<IEffectSplineCreationMode> CreateIEffectSplineCreationMode(FlatBufferBuilder builder, EEffectSplineCreateMode Type = EEffectSplineCreateMode.WholeLine)
		{
			builder.StartTable(1);
			IEffectSplineCreationMode.AddType(builder, Type);
			return IEffectSplineCreationMode.EndIEffectSplineCreationMode(builder);
		}

		// Token: 0x06021746 RID: 137030 RVA: 0x004A505A File Offset: 0x004A325A
		public static void StartIEffectSplineCreationMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021747 RID: 137031 RVA: 0x004A5063 File Offset: 0x004A3263
		public static void AddType(FlatBufferBuilder builder, EEffectSplineCreateMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021748 RID: 137032 RVA: 0x004A506E File Offset: 0x004A326E
		public static Offset<IEffectSplineCreationMode> EndIEffectSplineCreationMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSplineCreationMode>(builder.EndTable());
		}

		// Token: 0x06021749 RID: 137033 RVA: 0x004A507C File Offset: 0x004A327C
		public IEffectSplineCreationModeT UnPack()
		{
			IEffectSplineCreationModeT effectSplineCreationModeT = new IEffectSplineCreationModeT();
			this.UnPackTo(effectSplineCreationModeT);
			return effectSplineCreationModeT;
		}

		// Token: 0x0602174A RID: 137034 RVA: 0x004A5097 File Offset: 0x004A3297
		public void UnPackTo(IEffectSplineCreationModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602174B RID: 137035 RVA: 0x004A50A8 File Offset: 0x004A32A8
		public static Offset<IEffectSplineCreationMode> Pack(FlatBufferBuilder builder, IEffectSplineCreationModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectSplineCreationMode>);
			}
			return IEffectSplineCreationMode.CreateIEffectSplineCreationMode(builder, _o.Type);
		}

		// Token: 0x0400E189 RID: 57737
		private Table __p;
	}
}
