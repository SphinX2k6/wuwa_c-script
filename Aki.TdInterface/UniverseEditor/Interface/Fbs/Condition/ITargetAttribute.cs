using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051DB RID: 20955
	public struct ITargetAttribute : IFlatbufferObject
	{
		// Token: 0x17009613 RID: 38419
		// (get) Token: 0x06021009 RID: 135177 RVA: 0x0049017C File Offset: 0x0048E37C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602100A RID: 135178 RVA: 0x00490189 File Offset: 0x0048E389
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602100B RID: 135179 RVA: 0x00490190 File Offset: 0x0048E390
		public static ITargetAttribute GetRootAsITargetAttribute(ByteBuffer _bb)
		{
			return ITargetAttribute.GetRootAsITargetAttribute(_bb, default(ITargetAttribute));
		}

		// Token: 0x0602100C RID: 135180 RVA: 0x004901AC File Offset: 0x0048E3AC
		public static ITargetAttribute GetRootAsITargetAttribute(ByteBuffer _bb, ITargetAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602100D RID: 135181 RVA: 0x004901C9 File Offset: 0x0048E3C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602100E RID: 135182 RVA: 0x004901D8 File Offset: 0x0048E3D8
		public ITargetAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009614 RID: 38420
		// (get) Token: 0x0602100F RID: 135183 RVA: 0x004901E8 File Offset: 0x0048E3E8
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021010 RID: 135184 RVA: 0x00490224 File Offset: 0x0048E424
		public static Offset<ITargetAttribute> CreateITargetAttribute(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player)
		{
			builder.StartTable(1);
			ITargetAttribute.AddType(builder, Type);
			return ITargetAttribute.EndITargetAttribute(builder);
		}

		// Token: 0x06021011 RID: 135185 RVA: 0x0049023A File Offset: 0x0048E43A
		public static void StartITargetAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021012 RID: 135186 RVA: 0x00490243 File Offset: 0x0048E443
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021013 RID: 135187 RVA: 0x0049024E File Offset: 0x0048E44E
		public static Offset<ITargetAttribute> EndITargetAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ITargetAttribute>(builder.EndTable());
		}

		// Token: 0x06021014 RID: 135188 RVA: 0x0049025C File Offset: 0x0048E45C
		public ITargetAttributeT UnPack()
		{
			ITargetAttributeT targetAttributeT = new ITargetAttributeT();
			this.UnPackTo(targetAttributeT);
			return targetAttributeT;
		}

		// Token: 0x06021015 RID: 135189 RVA: 0x00490277 File Offset: 0x0048E477
		public void UnPackTo(ITargetAttributeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021016 RID: 135190 RVA: 0x00490288 File Offset: 0x0048E488
		public static Offset<ITargetAttribute> Pack(FlatBufferBuilder builder, ITargetAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetAttribute>);
			}
			return ITargetAttribute.CreateITargetAttribute(builder, _o.Type);
		}

		// Token: 0x0400E1DD RID: 57821
		private Table __p;
	}
}
