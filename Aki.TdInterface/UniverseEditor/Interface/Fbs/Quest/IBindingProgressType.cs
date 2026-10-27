using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D31 RID: 15665
	public struct IBindingProgressType : IFlatbufferObject
	{
		// Token: 0x17006B76 RID: 27510
		// (get) Token: 0x06015A29 RID: 88617 RVA: 0x0031F836 File Offset: 0x0031DA36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A2A RID: 88618 RVA: 0x0031F843 File Offset: 0x0031DA43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A2B RID: 88619 RVA: 0x0031F84C File Offset: 0x0031DA4C
		public static IBindingProgressType GetRootAsIBindingProgressType(ByteBuffer _bb)
		{
			return IBindingProgressType.GetRootAsIBindingProgressType(_bb, default(IBindingProgressType));
		}

		// Token: 0x06015A2C RID: 88620 RVA: 0x0031F868 File Offset: 0x0031DA68
		public static IBindingProgressType GetRootAsIBindingProgressType(ByteBuffer _bb, IBindingProgressType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A2D RID: 88621 RVA: 0x0031F885 File Offset: 0x0031DA85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A2E RID: 88622 RVA: 0x0031F894 File Offset: 0x0031DA94
		public IBindingProgressType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B77 RID: 27511
		// (get) Token: 0x06015A2F RID: 88623 RVA: 0x0031F8A4 File Offset: 0x0031DAA4
		public EBindingProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBindingProgressType.PlayerHavingItemCount;
				}
				return (EBindingProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015A30 RID: 88624 RVA: 0x0031F8E0 File Offset: 0x0031DAE0
		public static Offset<IBindingProgressType> CreateIBindingProgressType(FlatBufferBuilder builder, EBindingProgressType Type = EBindingProgressType.PlayerHavingItemCount)
		{
			builder.StartTable(1);
			IBindingProgressType.AddType(builder, Type);
			return IBindingProgressType.EndIBindingProgressType(builder);
		}

		// Token: 0x06015A31 RID: 88625 RVA: 0x0031F8F6 File Offset: 0x0031DAF6
		public static void StartIBindingProgressType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015A32 RID: 88626 RVA: 0x0031F8FF File Offset: 0x0031DAFF
		public static void AddType(FlatBufferBuilder builder, EBindingProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015A33 RID: 88627 RVA: 0x0031F90A File Offset: 0x0031DB0A
		public static Offset<IBindingProgressType> EndIBindingProgressType(FlatBufferBuilder builder)
		{
			return new Offset<IBindingProgressType>(builder.EndTable());
		}

		// Token: 0x06015A34 RID: 88628 RVA: 0x0031F918 File Offset: 0x0031DB18
		public IBindingProgressTypeT UnPack()
		{
			IBindingProgressTypeT bindingProgressTypeT = new IBindingProgressTypeT();
			this.UnPackTo(bindingProgressTypeT);
			return bindingProgressTypeT;
		}

		// Token: 0x06015A35 RID: 88629 RVA: 0x0031F933 File Offset: 0x0031DB33
		public void UnPackTo(IBindingProgressTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015A36 RID: 88630 RVA: 0x0031F944 File Offset: 0x0031DB44
		public static Offset<IBindingProgressType> Pack(FlatBufferBuilder builder, IBindingProgressTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBindingProgressType>);
			}
			return IBindingProgressType.CreateIBindingProgressType(builder, _o.Type);
		}

		// Token: 0x0400B5EF RID: 46575
		private Table __p;
	}
}
