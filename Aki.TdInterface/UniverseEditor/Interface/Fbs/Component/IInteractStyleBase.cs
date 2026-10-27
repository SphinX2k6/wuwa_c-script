using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005476 RID: 21622
	public struct IInteractStyleBase : IFlatbufferObject
	{
		// Token: 0x17009F26 RID: 40742
		// (get) Token: 0x06023915 RID: 145685 RVA: 0x004EB2EE File Offset: 0x004E94EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023916 RID: 145686 RVA: 0x004EB2FB File Offset: 0x004E94FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023917 RID: 145687 RVA: 0x004EB304 File Offset: 0x004E9504
		public static IInteractStyleBase GetRootAsIInteractStyleBase(ByteBuffer _bb)
		{
			return IInteractStyleBase.GetRootAsIInteractStyleBase(_bb, default(IInteractStyleBase));
		}

		// Token: 0x06023918 RID: 145688 RVA: 0x004EB320 File Offset: 0x004E9520
		public static IInteractStyleBase GetRootAsIInteractStyleBase(ByteBuffer _bb, IInteractStyleBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023919 RID: 145689 RVA: 0x004EB33D File Offset: 0x004E953D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602391A RID: 145690 RVA: 0x004EB34C File Offset: 0x004E954C
		public IInteractStyleBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F27 RID: 40743
		// (get) Token: 0x0602391B RID: 145691 RVA: 0x004EB35C File Offset: 0x004E955C
		public EInteractStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractStyleType.Panorama;
				}
				return (EInteractStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602391C RID: 145692 RVA: 0x004EB398 File Offset: 0x004E9598
		public static Offset<IInteractStyleBase> CreateIInteractStyleBase(FlatBufferBuilder builder, EInteractStyleType Type = EInteractStyleType.Panorama)
		{
			builder.StartTable(1);
			IInteractStyleBase.AddType(builder, Type);
			return IInteractStyleBase.EndIInteractStyleBase(builder);
		}

		// Token: 0x0602391D RID: 145693 RVA: 0x004EB3AE File Offset: 0x004E95AE
		public static void StartIInteractStyleBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602391E RID: 145694 RVA: 0x004EB3B7 File Offset: 0x004E95B7
		public static void AddType(FlatBufferBuilder builder, EInteractStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602391F RID: 145695 RVA: 0x004EB3C2 File Offset: 0x004E95C2
		public static Offset<IInteractStyleBase> EndIInteractStyleBase(FlatBufferBuilder builder)
		{
			return new Offset<IInteractStyleBase>(builder.EndTable());
		}

		// Token: 0x06023920 RID: 145696 RVA: 0x004EB3D0 File Offset: 0x004E95D0
		public IInteractStyleBaseT UnPack()
		{
			IInteractStyleBaseT interactStyleBaseT = new IInteractStyleBaseT();
			this.UnPackTo(interactStyleBaseT);
			return interactStyleBaseT;
		}

		// Token: 0x06023921 RID: 145697 RVA: 0x004EB3EB File Offset: 0x004E95EB
		public void UnPackTo(IInteractStyleBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023922 RID: 145698 RVA: 0x004EB3FC File Offset: 0x004E95FC
		public static Offset<IInteractStyleBase> Pack(FlatBufferBuilder builder, IInteractStyleBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractStyleBase>);
			}
			return IInteractStyleBase.CreateIInteractStyleBase(builder, _o.Type);
		}

		// Token: 0x0400E6F4 RID: 59124
		private Table __p;
	}
}
