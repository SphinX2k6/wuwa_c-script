using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005673 RID: 22131
	public struct IEffectAreaMode : IFlatbufferObject
	{
		// Token: 0x17009F20 RID: 40736
		// (get) Token: 0x0602364A RID: 144970 RVA: 0x004DE62F File Offset: 0x004DC82F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602364B RID: 144971 RVA: 0x004DE63C File Offset: 0x004DC83C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602364C RID: 144972 RVA: 0x004DE644 File Offset: 0x004DC844
		public static IEffectAreaMode GetRootAsIEffectAreaMode(ByteBuffer _bb)
		{
			return IEffectAreaMode.GetRootAsIEffectAreaMode(_bb, default(IEffectAreaMode));
		}

		// Token: 0x0602364D RID: 144973 RVA: 0x004DE660 File Offset: 0x004DC860
		public static IEffectAreaMode GetRootAsIEffectAreaMode(ByteBuffer _bb, IEffectAreaMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602364E RID: 144974 RVA: 0x004DE67D File Offset: 0x004DC87D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602364F RID: 144975 RVA: 0x004DE68C File Offset: 0x004DC88C
		public IEffectAreaMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F21 RID: 40737
		// (get) Token: 0x06023650 RID: 144976 RVA: 0x004DE69C File Offset: 0x004DC89C
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

		// Token: 0x06023651 RID: 144977 RVA: 0x004DE6D8 File Offset: 0x004DC8D8
		public static Offset<IEffectAreaMode> CreateIEffectAreaMode(FlatBufferBuilder builder, EEffectAreaType Type = EEffectAreaType.BuffArea)
		{
			builder.StartTable(1);
			IEffectAreaMode.AddType(builder, Type);
			return IEffectAreaMode.EndIEffectAreaMode(builder);
		}

		// Token: 0x06023652 RID: 144978 RVA: 0x004DE6EE File Offset: 0x004DC8EE
		public static void StartIEffectAreaMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023653 RID: 144979 RVA: 0x004DE6F7 File Offset: 0x004DC8F7
		public static void AddType(FlatBufferBuilder builder, EEffectAreaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023654 RID: 144980 RVA: 0x004DE702 File Offset: 0x004DC902
		public static Offset<IEffectAreaMode> EndIEffectAreaMode(FlatBufferBuilder builder)
		{
			return new Offset<IEffectAreaMode>(builder.EndTable());
		}

		// Token: 0x06023655 RID: 144981 RVA: 0x004DE710 File Offset: 0x004DC910
		public IEffectAreaModeT UnPack()
		{
			IEffectAreaModeT effectAreaModeT = new IEffectAreaModeT();
			this.UnPackTo(effectAreaModeT);
			return effectAreaModeT;
		}

		// Token: 0x06023656 RID: 144982 RVA: 0x004DE72B File Offset: 0x004DC92B
		public void UnPackTo(IEffectAreaModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023657 RID: 144983 RVA: 0x004DE73C File Offset: 0x004DC93C
		public static Offset<IEffectAreaMode> Pack(FlatBufferBuilder builder, IEffectAreaModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEffectAreaMode>);
			}
			return IEffectAreaMode.CreateIEffectAreaMode(builder, _o.Type);
		}

		// Token: 0x0400ED79 RID: 60793
		private Table __p;
	}
}
