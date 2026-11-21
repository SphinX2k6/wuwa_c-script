using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E95 RID: 16021
	public struct IFishState : IFlatbufferObject
	{
		// Token: 0x17006C5B RID: 27739
		// (get) Token: 0x06015A36 RID: 88630 RVA: 0x0031E253 File Offset: 0x0031C453
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A37 RID: 88631 RVA: 0x0031E260 File Offset: 0x0031C460
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A38 RID: 88632 RVA: 0x0031E268 File Offset: 0x0031C468
		public static IFishState GetRootAsIFishState(ByteBuffer _bb)
		{
			return IFishState.GetRootAsIFishState(_bb, default(IFishState));
		}

		// Token: 0x06015A39 RID: 88633 RVA: 0x0031E284 File Offset: 0x0031C484
		public static IFishState GetRootAsIFishState(ByteBuffer _bb, IFishState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A3A RID: 88634 RVA: 0x0031E2A1 File Offset: 0x0031C4A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A3B RID: 88635 RVA: 0x0031E2B0 File Offset: 0x0031C4B0
		public IFishState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C5C RID: 27740
		// (get) Token: 0x06015A3C RID: 88636 RVA: 0x0031E2C0 File Offset: 0x0031C4C0
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

		// Token: 0x06015A3D RID: 88637 RVA: 0x0031E2FC File Offset: 0x0031C4FC
		public static Offset<IFishState> CreateIFishState(FlatBufferBuilder builder, EFishState Type = EFishState.Idle)
		{
			builder.StartTable(1);
			IFishState.AddType(builder, Type);
			return IFishState.EndIFishState(builder);
		}

		// Token: 0x06015A3E RID: 88638 RVA: 0x0031E312 File Offset: 0x0031C512
		public static void StartIFishState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015A3F RID: 88639 RVA: 0x0031E31B File Offset: 0x0031C51B
		public static void AddType(FlatBufferBuilder builder, EFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015A40 RID: 88640 RVA: 0x0031E326 File Offset: 0x0031C526
		public static Offset<IFishState> EndIFishState(FlatBufferBuilder builder)
		{
			return new Offset<IFishState>(builder.EndTable());
		}

		// Token: 0x06015A41 RID: 88641 RVA: 0x0031E334 File Offset: 0x0031C534
		public IFishStateT UnPack()
		{
			IFishStateT fishStateT = new IFishStateT();
			this.UnPackTo(fishStateT);
			return fishStateT;
		}

		// Token: 0x06015A42 RID: 88642 RVA: 0x0031E34F File Offset: 0x0031C54F
		public void UnPackTo(IFishStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015A43 RID: 88643 RVA: 0x0031E360 File Offset: 0x0031C560
		public static Offset<IFishState> Pack(FlatBufferBuilder builder, IFishStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishState>);
			}
			return IFishState.CreateIFishState(builder, _o.Type);
		}

		// Token: 0x0400B879 RID: 47225
		private Table __p;
	}
}
