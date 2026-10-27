using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE5 RID: 19685
	public struct ITargetBuffContainer : IFlatbufferObject
	{
		// Token: 0x17008EDF RID: 36575
		// (get) Token: 0x0601F3E2 RID: 127970 RVA: 0x0045C49E File Offset: 0x0045A69E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F3E3 RID: 127971 RVA: 0x0045C4AB File Offset: 0x0045A6AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F3E4 RID: 127972 RVA: 0x0045C4B4 File Offset: 0x0045A6B4
		public static ITargetBuffContainer GetRootAsITargetBuffContainer(ByteBuffer _bb)
		{
			return ITargetBuffContainer.GetRootAsITargetBuffContainer(_bb, default(ITargetBuffContainer));
		}

		// Token: 0x0601F3E5 RID: 127973 RVA: 0x0045C4D0 File Offset: 0x0045A6D0
		public static ITargetBuffContainer GetRootAsITargetBuffContainer(ByteBuffer _bb, ITargetBuffContainer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F3E6 RID: 127974 RVA: 0x0045C4ED File Offset: 0x0045A6ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F3E7 RID: 127975 RVA: 0x0045C4FC File Offset: 0x0045A6FC
		public ITargetBuffContainer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EE0 RID: 36576
		// (get) Token: 0x0601F3E8 RID: 127976 RVA: 0x0045C50C File Offset: 0x0045A70C
		public ETargetBuffContainer Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetBuffContainer.Monster;
				}
				return (ETargetBuffContainer)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F3E9 RID: 127977 RVA: 0x0045C548 File Offset: 0x0045A748
		public static Offset<ITargetBuffContainer> CreateITargetBuffContainer(FlatBufferBuilder builder, ETargetBuffContainer Type = ETargetBuffContainer.Monster)
		{
			builder.StartTable(1);
			ITargetBuffContainer.AddType(builder, Type);
			return ITargetBuffContainer.EndITargetBuffContainer(builder);
		}

		// Token: 0x0601F3EA RID: 127978 RVA: 0x0045C55E File Offset: 0x0045A75E
		public static void StartITargetBuffContainer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F3EB RID: 127979 RVA: 0x0045C567 File Offset: 0x0045A767
		public static void AddType(FlatBufferBuilder builder, ETargetBuffContainer type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F3EC RID: 127980 RVA: 0x0045C572 File Offset: 0x0045A772
		public static Offset<ITargetBuffContainer> EndITargetBuffContainer(FlatBufferBuilder builder)
		{
			return new Offset<ITargetBuffContainer>(builder.EndTable());
		}

		// Token: 0x0601F3ED RID: 127981 RVA: 0x0045C580 File Offset: 0x0045A780
		public ITargetBuffContainerT UnPack()
		{
			ITargetBuffContainerT targetBuffContainerT = new ITargetBuffContainerT();
			this.UnPackTo(targetBuffContainerT);
			return targetBuffContainerT;
		}

		// Token: 0x0601F3EE RID: 127982 RVA: 0x0045C59B File Offset: 0x0045A79B
		public void UnPackTo(ITargetBuffContainerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F3EF RID: 127983 RVA: 0x0045C5AC File Offset: 0x0045A7AC
		public static Offset<ITargetBuffContainer> Pack(FlatBufferBuilder builder, ITargetBuffContainerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetBuffContainer>);
			}
			return ITargetBuffContainer.CreateITargetBuffContainer(builder, _o.Type);
		}

		// Token: 0x0400D6B8 RID: 54968
		private Table __p;
	}
}
