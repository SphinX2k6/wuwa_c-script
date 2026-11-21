using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004139 RID: 16697
	public struct IAttributeToTarget : IFlatbufferObject
	{
		// Token: 0x17007112 RID: 28946
		// (get) Token: 0x06016EC9 RID: 93897 RVA: 0x00345787 File Offset: 0x00343987
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016ECA RID: 93898 RVA: 0x00345794 File Offset: 0x00343994
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016ECB RID: 93899 RVA: 0x0034579C File Offset: 0x0034399C
		public static IAttributeToTarget GetRootAsIAttributeToTarget(ByteBuffer _bb)
		{
			return IAttributeToTarget.GetRootAsIAttributeToTarget(_bb, default(IAttributeToTarget));
		}

		// Token: 0x06016ECC RID: 93900 RVA: 0x003457B8 File Offset: 0x003439B8
		public static IAttributeToTarget GetRootAsIAttributeToTarget(ByteBuffer _bb, IAttributeToTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016ECD RID: 93901 RVA: 0x003457D5 File Offset: 0x003439D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016ECE RID: 93902 RVA: 0x003457E4 File Offset: 0x003439E4
		public IAttributeToTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007113 RID: 28947
		// (get) Token: 0x06016ECF RID: 93903 RVA: 0x003457F4 File Offset: 0x003439F4
		public EAttributeToTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttributeToTarget.Health;
				}
				return (EAttributeToTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016ED0 RID: 93904 RVA: 0x00345830 File Offset: 0x00343A30
		public static Offset<IAttributeToTarget> CreateIAttributeToTarget(FlatBufferBuilder builder, EAttributeToTarget Type = EAttributeToTarget.Health)
		{
			builder.StartTable(1);
			IAttributeToTarget.AddType(builder, Type);
			return IAttributeToTarget.EndIAttributeToTarget(builder);
		}

		// Token: 0x06016ED1 RID: 93905 RVA: 0x00345846 File Offset: 0x00343A46
		public static void StartIAttributeToTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016ED2 RID: 93906 RVA: 0x0034584F File Offset: 0x00343A4F
		public static void AddType(FlatBufferBuilder builder, EAttributeToTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016ED3 RID: 93907 RVA: 0x0034585A File Offset: 0x00343A5A
		public static Offset<IAttributeToTarget> EndIAttributeToTarget(FlatBufferBuilder builder)
		{
			return new Offset<IAttributeToTarget>(builder.EndTable());
		}

		// Token: 0x06016ED4 RID: 93908 RVA: 0x00345868 File Offset: 0x00343A68
		public IAttributeToTargetT UnPack()
		{
			IAttributeToTargetT attributeToTargetT = new IAttributeToTargetT();
			this.UnPackTo(attributeToTargetT);
			return attributeToTargetT;
		}

		// Token: 0x06016ED5 RID: 93909 RVA: 0x00345883 File Offset: 0x00343A83
		public void UnPackTo(IAttributeToTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016ED6 RID: 93910 RVA: 0x00345894 File Offset: 0x00343A94
		public static Offset<IAttributeToTarget> Pack(FlatBufferBuilder builder, IAttributeToTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttributeToTarget>);
			}
			return IAttributeToTarget.CreateIAttributeToTarget(builder, _o.Type);
		}

		// Token: 0x0400BF86 RID: 49030
		private Table __p;
	}
}
