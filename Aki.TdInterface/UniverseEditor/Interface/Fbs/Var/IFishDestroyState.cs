using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E86 RID: 16006
	public struct IFishDestroyState : IFlatbufferObject
	{
		// Token: 0x17006C22 RID: 27682
		// (get) Token: 0x0601597E RID: 88446 RVA: 0x0031CA5A File Offset: 0x0031AC5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601597F RID: 88447 RVA: 0x0031CA67 File Offset: 0x0031AC67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015980 RID: 88448 RVA: 0x0031CA70 File Offset: 0x0031AC70
		public static IFishDestroyState GetRootAsIFishDestroyState(ByteBuffer _bb)
		{
			return IFishDestroyState.GetRootAsIFishDestroyState(_bb, default(IFishDestroyState));
		}

		// Token: 0x06015981 RID: 88449 RVA: 0x0031CA8C File Offset: 0x0031AC8C
		public static IFishDestroyState GetRootAsIFishDestroyState(ByteBuffer _bb, IFishDestroyState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015982 RID: 88450 RVA: 0x0031CAA9 File Offset: 0x0031ACA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015983 RID: 88451 RVA: 0x0031CAB8 File Offset: 0x0031ACB8
		public IFishDestroyState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C23 RID: 27683
		// (get) Token: 0x06015984 RID: 88452 RVA: 0x0031CAC8 File Offset: 0x0031ACC8
		public EFishState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFishState.Idle;
				}
				return (EFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C24 RID: 27684
		// (get) Token: 0x06015985 RID: 88453 RVA: 0x0031CB04 File Offset: 0x0031AD04
		public float DissolveDuration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015986 RID: 88454 RVA: 0x0031CB44 File Offset: 0x0031AD44
		public static Offset<IFishDestroyState> CreateIFishDestroyState(FlatBufferBuilder builder, EFishState Type = EFishState.Idle, float DissolveDuration = 0f)
		{
			builder.StartTable(2);
			IFishDestroyState.AddDissolveDuration(builder, DissolveDuration);
			IFishDestroyState.AddType(builder, Type);
			return IFishDestroyState.EndIFishDestroyState(builder);
		}

		// Token: 0x06015987 RID: 88455 RVA: 0x0031CB61 File Offset: 0x0031AD61
		public static void StartIFishDestroyState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015988 RID: 88456 RVA: 0x0031CB6A File Offset: 0x0031AD6A
		public static void AddType(FlatBufferBuilder builder, EFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015989 RID: 88457 RVA: 0x0031CB75 File Offset: 0x0031AD75
		public static void AddDissolveDuration(FlatBufferBuilder builder, float dissolveDuration)
		{
			builder.AddFloat(1, dissolveDuration, 0.0);
		}

		// Token: 0x0601598A RID: 88458 RVA: 0x0031CB88 File Offset: 0x0031AD88
		public static Offset<IFishDestroyState> EndIFishDestroyState(FlatBufferBuilder builder)
		{
			return new Offset<IFishDestroyState>(builder.EndTable());
		}

		// Token: 0x0601598B RID: 88459 RVA: 0x0031CB98 File Offset: 0x0031AD98
		public IFishDestroyStateT UnPack()
		{
			IFishDestroyStateT fishDestroyStateT = new IFishDestroyStateT();
			this.UnPackTo(fishDestroyStateT);
			return fishDestroyStateT;
		}

		// Token: 0x0601598C RID: 88460 RVA: 0x0031CBB3 File Offset: 0x0031ADB3
		public void UnPackTo(IFishDestroyStateT _o)
		{
			_o.Type = this.Type;
			_o.DissolveDuration = this.DissolveDuration;
		}

		// Token: 0x0601598D RID: 88461 RVA: 0x0031CBD0 File Offset: 0x0031ADD0
		public static Offset<IFishDestroyState> Pack(FlatBufferBuilder builder, IFishDestroyStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishDestroyState>);
			}
			return IFishDestroyState.CreateIFishDestroyState(builder, _o.Type, _o.DissolveDuration);
		}

		// Token: 0x0400B85A RID: 47194
		private Table __p;
	}
}
