using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200511D RID: 20765
	public struct IEffectSplineEquidistantPointMode : IFlatbufferObject
	{
		// Token: 0x17009746 RID: 38726
		// (get) Token: 0x0602175E RID: 137054 RVA: 0x004A525C File Offset: 0x004A345C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602175F RID: 137055 RVA: 0x004A5269 File Offset: 0x004A3469
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021760 RID: 137056 RVA: 0x004A5270 File Offset: 0x004A3470
		public static IEffectSplineEquidistantPointMode GetRootAsIEffectSplineEquidistantPointMode(ByteBuffer _bb)
		{
			return IEffectSplineEquidistantPointMode.GetRootAsIEffectSplineEquidistantPointMode(_bb, default(IEffectSplineEquidistantPointMode));
		}

		// Token: 0x06021761 RID: 137057 RVA: 0x004A528C File Offset: 0x004A348C
		public static IEffectSplineEquidistantPointMode GetRootAsIEffectSplineEquidistantPointMode(ByteBuffer _bb, IEffectSplineEquidistantPointMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021762 RID: 137058 RVA: 0x004A52A9 File Offset: 0x004A34A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021763 RID: 137059 RVA: 0x004A52B8 File Offset: 0x004A34B8
		public IEffectSplineEquidistantPointMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009747 RID: 38727
		// (get) Token: 0x06021764 RID: 137060 RVA: 0x004A52C8 File Offset: 0x004A34C8
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

		// Token: 0x17009748 RID: 38728
		// (get) Token: 0x06021765 RID: 137061 RVA: 0x004A5304 File Offset: 0x004A3504
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

		// Token: 0x06021766 RID: 137062 RVA: 0x004A5340 File Offset: 0x004A3540
		public static Offset<IEffectSplineEquidistantPointMode> CreateIEffectSplineEquidistantPointMode(FlatBufferBuilder builder, EEffectSplineCreateMode Type = EEffectSplineCreateMode.WholeLine, int Space = 0)
		{
			builder.StartTable(2);
			IEffectSplineEquidistantPointMode.AddSpace(builder, Space);
			IEffectSplineEquidistantPointMode.AddType(builder, Type);
			return IEffectSplineEquidistantPointMode.EndIEffectSplineEquidistantPointMode(builder);
		}

		// Token: 0x06021767 RID: 137063 RVA: 0x004A535D File Offset: 0x004A355D
		public static void StartIEffectSplineEquidistantPointMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021768 RID: 137064 RVA: 0x004A5366 File Offset: 0x004A3566
		public static void AddType(FlatBufferBuilder builder, EEffectSplineCreateMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021769 RID: 137065 RVA: 0x004A5371 File Offset: 0x004A3571
		public static void AddSpace(FlatBufferBuilder builder, int space)
		{
			builder.AddInt(1, space, 0);
		}

		// Token: 0x0602176A RID: 137066 RVA: 0x004A537C File Offset: 0x004A357C
		public static Offset<IEffectSplineEquidistantPointMode> EndIEffectSplineEquidistantPointMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSplineEquidistantPointMode>(builder.EndTable());
		}

		// Token: 0x0602176B RID: 137067 RVA: 0x004A538C File Offset: 0x004A358C
		public IEffectSplineEquidistantPointModeT UnPack()
		{
			IEffectSplineEquidistantPointModeT effectSplineEquidistantPointModeT = new IEffectSplineEquidistantPointModeT();
			this.UnPackTo(effectSplineEquidistantPointModeT);
			return effectSplineEquidistantPointModeT;
		}

		// Token: 0x0602176C RID: 137068 RVA: 0x004A53A7 File Offset: 0x004A35A7
		public void UnPackTo(IEffectSplineEquidistantPointModeT _o)
		{
			_o.Type = this.Type;
			_o.Space = this.Space;
		}

		// Token: 0x0602176D RID: 137069 RVA: 0x004A53C4 File Offset: 0x004A35C4
		public static Offset<IEffectSplineEquidistantPointMode> Pack(FlatBufferBuilder builder, IEffectSplineEquidistantPointModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectSplineEquidistantPointMode>);
			}
			return IEffectSplineEquidistantPointMode.CreateIEffectSplineEquidistantPointMode(builder, _o.Type, _o.Space);
		}

		// Token: 0x0400E192 RID: 57746
		private Table __p;
	}
}
