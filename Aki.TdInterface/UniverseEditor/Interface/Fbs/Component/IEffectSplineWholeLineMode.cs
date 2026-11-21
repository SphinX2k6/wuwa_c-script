using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005685 RID: 22149
	public struct IEffectSplineWholeLineMode : IFlatbufferObject
	{
		// Token: 0x17009F38 RID: 40760
		// (get) Token: 0x060236C8 RID: 145096 RVA: 0x004DF3E6 File Offset: 0x004DD5E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060236C9 RID: 145097 RVA: 0x004DF3F3 File Offset: 0x004DD5F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060236CA RID: 145098 RVA: 0x004DF3FC File Offset: 0x004DD5FC
		public static IEffectSplineWholeLineMode GetRootAsIEffectSplineWholeLineMode(ByteBuffer _bb)
		{
			return IEffectSplineWholeLineMode.GetRootAsIEffectSplineWholeLineMode(_bb, default(IEffectSplineWholeLineMode));
		}

		// Token: 0x060236CB RID: 145099 RVA: 0x004DF418 File Offset: 0x004DD618
		public static IEffectSplineWholeLineMode GetRootAsIEffectSplineWholeLineMode(ByteBuffer _bb, IEffectSplineWholeLineMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060236CC RID: 145100 RVA: 0x004DF435 File Offset: 0x004DD635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060236CD RID: 145101 RVA: 0x004DF444 File Offset: 0x004DD644
		public IEffectSplineWholeLineMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F39 RID: 40761
		// (get) Token: 0x060236CE RID: 145102 RVA: 0x004DF454 File Offset: 0x004DD654
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

		// Token: 0x060236CF RID: 145103 RVA: 0x004DF490 File Offset: 0x004DD690
		public static Offset<IEffectSplineWholeLineMode> CreateIEffectSplineWholeLineMode(FlatBufferBuilder builder, EEffectSplineCreateMode Type = EEffectSplineCreateMode.WholeLine)
		{
			builder.StartTable(1);
			IEffectSplineWholeLineMode.AddType(builder, Type);
			return IEffectSplineWholeLineMode.EndIEffectSplineWholeLineMode(builder);
		}

		// Token: 0x060236D0 RID: 145104 RVA: 0x004DF4A6 File Offset: 0x004DD6A6
		public static void StartIEffectSplineWholeLineMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060236D1 RID: 145105 RVA: 0x004DF4AF File Offset: 0x004DD6AF
		public static void AddType(FlatBufferBuilder builder, EEffectSplineCreateMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060236D2 RID: 145106 RVA: 0x004DF4BA File Offset: 0x004DD6BA
		public static Offset<IEffectSplineWholeLineMode> EndIEffectSplineWholeLineMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectSplineWholeLineMode>(builder.EndTable());
		}

		// Token: 0x060236D3 RID: 145107 RVA: 0x004DF4C8 File Offset: 0x004DD6C8
		public IEffectSplineWholeLineModeT UnPack()
		{
			IEffectSplineWholeLineModeT effectSplineWholeLineModeT = new IEffectSplineWholeLineModeT();
			this.UnPackTo(effectSplineWholeLineModeT);
			return effectSplineWholeLineModeT;
		}

		// Token: 0x060236D4 RID: 145108 RVA: 0x004DF4E3 File Offset: 0x004DD6E3
		public void UnPackTo(IEffectSplineWholeLineModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060236D5 RID: 145109 RVA: 0x004DF4F4 File Offset: 0x004DD6F4
		public static Offset<IEffectSplineWholeLineMode> Pack(FlatBufferBuilder builder, IEffectSplineWholeLineModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectSplineWholeLineMode>);
			}
			return IEffectSplineWholeLineMode.CreateIEffectSplineWholeLineMode(builder, _o.Type);
		}

		// Token: 0x0400ED92 RID: 60818
		private Table __p;
	}
}
