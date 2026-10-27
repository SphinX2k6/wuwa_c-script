using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200510E RID: 20750
	public struct IEffectAreaMode : IFlatbufferObject
	{
		// Token: 0x17009733 RID: 38707
		// (get) Token: 0x060216F6 RID: 136950 RVA: 0x004A46A3 File Offset: 0x004A28A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060216F7 RID: 136951 RVA: 0x004A46B0 File Offset: 0x004A28B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060216F8 RID: 136952 RVA: 0x004A46B8 File Offset: 0x004A28B8
		public static IEffectAreaMode GetRootAsIEffectAreaMode(ByteBuffer _bb)
		{
			return IEffectAreaMode.GetRootAsIEffectAreaMode(_bb, default(IEffectAreaMode));
		}

		// Token: 0x060216F9 RID: 136953 RVA: 0x004A46D4 File Offset: 0x004A28D4
		public static IEffectAreaMode GetRootAsIEffectAreaMode(ByteBuffer _bb, IEffectAreaMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060216FA RID: 136954 RVA: 0x004A46F1 File Offset: 0x004A28F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060216FB RID: 136955 RVA: 0x004A4700 File Offset: 0x004A2900
		public IEffectAreaMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009734 RID: 38708
		// (get) Token: 0x060216FC RID: 136956 RVA: 0x004A4710 File Offset: 0x004A2910
		public EEffectAreaType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectAreaType.BuffArea;
				}
				return (EEffectAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060216FD RID: 136957 RVA: 0x004A474C File Offset: 0x004A294C
		public static Offset<IEffectAreaMode> CreateIEffectAreaMode(FlatBufferBuilder builder, EEffectAreaType Type = EEffectAreaType.BuffArea)
		{
			builder.StartTable(1);
			IEffectAreaMode.AddType(builder, Type);
			return IEffectAreaMode.EndIEffectAreaMode(builder);
		}

		// Token: 0x060216FE RID: 136958 RVA: 0x004A4762 File Offset: 0x004A2962
		public static void StartIEffectAreaMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060216FF RID: 136959 RVA: 0x004A476B File Offset: 0x004A296B
		public static void AddType(FlatBufferBuilder builder, EEffectAreaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021700 RID: 136960 RVA: 0x004A4776 File Offset: 0x004A2976
		public static Offset<IEffectAreaMode> EndIEffectAreaMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectAreaMode>(builder.EndTable());
		}

		// Token: 0x06021701 RID: 136961 RVA: 0x004A4784 File Offset: 0x004A2984
		public IEffectAreaModeT UnPack()
		{
			IEffectAreaModeT effectAreaModeT = new IEffectAreaModeT();
			this.UnPackTo(effectAreaModeT);
			return effectAreaModeT;
		}

		// Token: 0x06021702 RID: 136962 RVA: 0x004A479F File Offset: 0x004A299F
		public void UnPackTo(IEffectAreaModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021703 RID: 136963 RVA: 0x004A47B0 File Offset: 0x004A29B0
		public static Offset<IEffectAreaMode> Pack(FlatBufferBuilder builder, IEffectAreaModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectAreaMode>);
			}
			return IEffectAreaMode.CreateIEffectAreaMode(builder, _o.Type);
		}

		// Token: 0x0400E17C RID: 57724
		private Table __p;
	}
}
