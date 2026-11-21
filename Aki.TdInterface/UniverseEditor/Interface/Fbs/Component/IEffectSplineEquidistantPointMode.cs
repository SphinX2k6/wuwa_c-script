using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005682 RID: 22146
	public struct IEffectSplineEquidistantPointMode : IFlatbufferObject
	{
		// Token: 0x17009F33 RID: 40755
		// (get) Token: 0x060236B2 RID: 145074 RVA: 0x004DF1E8 File Offset: 0x004DD3E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060236B3 RID: 145075 RVA: 0x004DF1F5 File Offset: 0x004DD3F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060236B4 RID: 145076 RVA: 0x004DF1FC File Offset: 0x004DD3FC
		public static IEffectSplineEquidistantPointMode GetRootAsIEffectSplineEquidistantPointMode(ByteBuffer _bb)
		{
			return IEffectSplineEquidistantPointMode.GetRootAsIEffectSplineEquidistantPointMode(_bb, default(IEffectSplineEquidistantPointMode));
		}

		// Token: 0x060236B5 RID: 145077 RVA: 0x004DF218 File Offset: 0x004DD418
		public static IEffectSplineEquidistantPointMode GetRootAsIEffectSplineEquidistantPointMode(ByteBuffer _bb, IEffectSplineEquidistantPointMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060236B6 RID: 145078 RVA: 0x004DF235 File Offset: 0x004DD435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060236B7 RID: 145079 RVA: 0x004DF244 File Offset: 0x004DD444
		public IEffectSplineEquidistantPointMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F34 RID: 40756
		// (get) Token: 0x060236B8 RID: 145080 RVA: 0x004DF254 File Offset: 0x004DD454
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

		// Token: 0x17009F35 RID: 40757
		// (get) Token: 0x060236B9 RID: 145081 RVA: 0x004DF290 File Offset: 0x004DD490
		public int Space
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060236BA RID: 145082 RVA: 0x004DF2CC File Offset: 0x004DD4CC
		public static Offset<IEffectSplineEquidistantPointMode> CreateIEffectSplineEquidistantPointMode(FlatBufferBuilder builder, EEffectSplineCreateMode Type = EEffectSplineCreateMode.WholeLine, int Space = 0)
		{
			builder.StartTable(2);
			IEffectSplineEquidistantPointMode.AddSpace(builder, Space);
			IEffectSplineEquidistantPointMode.AddType(builder, Type);
			return IEffectSplineEquidistantPointMode.EndIEffectSplineEquidistantPointMode(builder);
		}

		// Token: 0x060236BB RID: 145083 RVA: 0x004DF2E9 File Offset: 0x004DD4E9
		public static void StartIEffectSplineEquidistantPointMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060236BC RID: 145084 RVA: 0x004DF2F2 File Offset: 0x004DD4F2
		public static void AddType(FlatBufferBuilder builder, EEffectSplineCreateMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060236BD RID: 145085 RVA: 0x004DF2FD File Offset: 0x004DD4FD
		public static void AddSpace(FlatBufferBuilder builder, int space)
		{
			builder.AddInt(1, space, 0);
		}

		// Token: 0x060236BE RID: 145086 RVA: 0x004DF308 File Offset: 0x004DD508
		public static Offset<IEffectSplineEquidistantPointMode> EndIEffectSplineEquidistantPointMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSplineEquidistantPointMode>(builder.EndTable());
		}

		// Token: 0x060236BF RID: 145087 RVA: 0x004DF318 File Offset: 0x004DD518
		public IEffectSplineEquidistantPointModeT UnPack()
		{
			IEffectSplineEquidistantPointModeT effectSplineEquidistantPointModeT = new IEffectSplineEquidistantPointModeT();
			this.UnPackTo(effectSplineEquidistantPointModeT);
			return effectSplineEquidistantPointModeT;
		}

		// Token: 0x060236C0 RID: 145088 RVA: 0x004DF333 File Offset: 0x004DD533
		public void UnPackTo(IEffectSplineEquidistantPointModeT _o)
		{
			_o.Type = this.Type;
			_o.Space = this.Space;
		}

		// Token: 0x060236C1 RID: 145089 RVA: 0x004DF350 File Offset: 0x004DD550
		public static Offset<IEffectSplineEquidistantPointMode> Pack(FlatBufferBuilder builder, IEffectSplineEquidistantPointModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectSplineEquidistantPointMode>);
			}
			return IEffectSplineEquidistantPointMode.CreateIEffectSplineEquidistantPointMode(builder, _o.Type, _o.Space);
		}

		// Token: 0x0400ED8F RID: 60815
		private Table __p;
	}
}
