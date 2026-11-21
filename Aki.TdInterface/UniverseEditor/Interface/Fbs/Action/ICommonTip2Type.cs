using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF1 RID: 27377
	public struct ICommonTip2Type : IFlatbufferObject
	{
		// Token: 0x1700C915 RID: 51477
		// (get) Token: 0x0602F10C RID: 192780 RVA: 0x0066BBF4 File Offset: 0x00669DF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F10D RID: 192781 RVA: 0x0066BC01 File Offset: 0x00669E01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F10E RID: 192782 RVA: 0x0066BC08 File Offset: 0x00669E08
		public static ICommonTip2Type GetRootAsICommonTip2Type(ByteBuffer _bb)
		{
			return ICommonTip2Type.GetRootAsICommonTip2Type(_bb, default(ICommonTip2Type));
		}

		// Token: 0x0602F10F RID: 192783 RVA: 0x0066BC24 File Offset: 0x00669E24
		public static ICommonTip2Type GetRootAsICommonTip2Type(ByteBuffer _bb, ICommonTip2Type obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F110 RID: 192784 RVA: 0x0066BC41 File Offset: 0x00669E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F111 RID: 192785 RVA: 0x0066BC50 File Offset: 0x00669E50
		public ICommonTip2Type __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C916 RID: 51478
		// (get) Token: 0x0602F112 RID: 192786 RVA: 0x0066BC60 File Offset: 0x00669E60
		public ECommonTip2Type Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTip2Type.PrepareCountdown;
				}
				return (ECommonTip2Type)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F113 RID: 192787 RVA: 0x0066BC9C File Offset: 0x00669E9C
		public static Offset<ICommonTip2Type> CreateICommonTip2Type(FlatBufferBuilder builder, ECommonTip2Type Type = ECommonTip2Type.PrepareCountdown)
		{
			builder.StartTable(1);
			ICommonTip2Type.AddType(builder, Type);
			return ICommonTip2Type.EndICommonTip2Type(builder);
		}

		// Token: 0x0602F114 RID: 192788 RVA: 0x0066BCB2 File Offset: 0x00669EB2
		public static void StartICommonTip2Type(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F115 RID: 192789 RVA: 0x0066BCBB File Offset: 0x00669EBB
		public static void AddType(FlatBufferBuilder builder, ECommonTip2Type type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F116 RID: 192790 RVA: 0x0066BCC6 File Offset: 0x00669EC6
		public static Offset<ICommonTip2Type> EndICommonTip2Type(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTip2Type>(builder.EndTable());
		}

		// Token: 0x0602F117 RID: 192791 RVA: 0x0066BCD4 File Offset: 0x00669ED4
		public ICommonTip2TypeT UnPack()
		{
			ICommonTip2TypeT commonTip2TypeT = new ICommonTip2TypeT();
			this.UnPackTo(commonTip2TypeT);
			return commonTip2TypeT;
		}

		// Token: 0x0602F118 RID: 192792 RVA: 0x0066BCEF File Offset: 0x00669EEF
		public void UnPackTo(ICommonTip2TypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F119 RID: 192793 RVA: 0x0066BD00 File Offset: 0x00669F00
		public static Offset<ICommonTip2Type> Pack(FlatBufferBuilder builder, ICommonTip2TypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTip2Type>);
			}
			return ICommonTip2Type.CreateICommonTip2Type(builder, _o.Type);
		}

		// Token: 0x040118A1 RID: 71841
		private Table __p;
	}
}
