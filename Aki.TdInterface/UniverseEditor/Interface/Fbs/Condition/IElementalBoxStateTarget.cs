using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050F7 RID: 20727
	public struct IElementalBoxStateTarget : IFlatbufferObject
	{
		// Token: 0x1700948C RID: 38028
		// (get) Token: 0x06020929 RID: 133417 RVA: 0x00484886 File Offset: 0x00482A86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602092A RID: 133418 RVA: 0x00484893 File Offset: 0x00482A93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602092B RID: 133419 RVA: 0x0048489C File Offset: 0x00482A9C
		public static IElementalBoxStateTarget GetRootAsIElementalBoxStateTarget(ByteBuffer _bb)
		{
			return IElementalBoxStateTarget.GetRootAsIElementalBoxStateTarget(_bb, default(IElementalBoxStateTarget));
		}

		// Token: 0x0602092C RID: 133420 RVA: 0x004848B8 File Offset: 0x00482AB8
		public static IElementalBoxStateTarget GetRootAsIElementalBoxStateTarget(ByteBuffer _bb, IElementalBoxStateTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602092D RID: 133421 RVA: 0x004848D5 File Offset: 0x00482AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602092E RID: 133422 RVA: 0x004848E4 File Offset: 0x00482AE4
		public IElementalBoxStateTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700948D RID: 38029
		// (get) Token: 0x0602092F RID: 133423 RVA: 0x004848F4 File Offset: 0x00482AF4
		public EElementalBoxStateTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxStateTargetType.Player;
				}
				return (EElementalBoxStateTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020930 RID: 133424 RVA: 0x00484930 File Offset: 0x00482B30
		public static Offset<IElementalBoxStateTarget> CreateIElementalBoxStateTarget(FlatBufferBuilder builder, EElementalBoxStateTargetType Type = EElementalBoxStateTargetType.Player)
		{
			builder.StartTable(1);
			IElementalBoxStateTarget.AddType(builder, Type);
			return IElementalBoxStateTarget.EndIElementalBoxStateTarget(builder);
		}

		// Token: 0x06020931 RID: 133425 RVA: 0x00484946 File Offset: 0x00482B46
		public static void StartIElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020932 RID: 133426 RVA: 0x0048494F File Offset: 0x00482B4F
		public static void AddType(FlatBufferBuilder builder, EElementalBoxStateTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020933 RID: 133427 RVA: 0x0048495A File Offset: 0x00482B5A
		public static Offset<IElementalBoxStateTarget> EndIElementalBoxStateTarget(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxStateTarget>(builder.EndTable());
		}

		// Token: 0x06020934 RID: 133428 RVA: 0x00484968 File Offset: 0x00482B68
		public IElementalBoxStateTargetT UnPack()
		{
			IElementalBoxStateTargetT elementalBoxStateTargetT = new IElementalBoxStateTargetT();
			this.UnPackTo(elementalBoxStateTargetT);
			return elementalBoxStateTargetT;
		}

		// Token: 0x06020935 RID: 133429 RVA: 0x00484983 File Offset: 0x00482B83
		public void UnPackTo(IElementalBoxStateTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020936 RID: 133430 RVA: 0x00484994 File Offset: 0x00482B94
		public static Offset<IElementalBoxStateTarget> Pack(FlatBufferBuilder builder, IElementalBoxStateTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxStateTarget>);
			}
			return IElementalBoxStateTarget.CreateIElementalBoxStateTarget(builder, _o.Type);
		}

		// Token: 0x0400E0B0 RID: 57520
		private Table __p;
	}
}
