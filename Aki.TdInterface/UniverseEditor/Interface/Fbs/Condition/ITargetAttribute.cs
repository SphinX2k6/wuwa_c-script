using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CDF RID: 19679
	public struct ITargetAttribute : IFlatbufferObject
	{
		// Token: 0x17008EDA RID: 36570
		// (get) Token: 0x0601F3C4 RID: 127940 RVA: 0x0045C22C File Offset: 0x0045A42C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F3C5 RID: 127941 RVA: 0x0045C239 File Offset: 0x0045A439
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F3C6 RID: 127942 RVA: 0x0045C240 File Offset: 0x0045A440
		public static ITargetAttribute GetRootAsITargetAttribute(ByteBuffer _bb)
		{
			return ITargetAttribute.GetRootAsITargetAttribute(_bb, default(ITargetAttribute));
		}

		// Token: 0x0601F3C7 RID: 127943 RVA: 0x0045C25C File Offset: 0x0045A45C
		public static ITargetAttribute GetRootAsITargetAttribute(ByteBuffer _bb, ITargetAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F3C8 RID: 127944 RVA: 0x0045C279 File Offset: 0x0045A479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F3C9 RID: 127945 RVA: 0x0045C288 File Offset: 0x0045A488
		public ITargetAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EDB RID: 36571
		// (get) Token: 0x0601F3CA RID: 127946 RVA: 0x0045C298 File Offset: 0x0045A498
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

		// Token: 0x0601F3CB RID: 127947 RVA: 0x0045C2D4 File Offset: 0x0045A4D4
		public static Offset<ITargetAttribute> CreateITargetAttribute(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player)
		{
			builder.StartTable(1);
			ITargetAttribute.AddType(builder, Type);
			return ITargetAttribute.EndITargetAttribute(builder);
		}

		// Token: 0x0601F3CC RID: 127948 RVA: 0x0045C2EA File Offset: 0x0045A4EA
		public static void StartITargetAttribute(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F3CD RID: 127949 RVA: 0x0045C2F3 File Offset: 0x0045A4F3
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F3CE RID: 127950 RVA: 0x0045C2FE File Offset: 0x0045A4FE
		public static Offset<ITargetAttribute> EndITargetAttribute(FlatBufferBuilder builder)
		{
			return new Offset<ITargetAttribute>(builder.EndTable());
		}

		// Token: 0x0601F3CF RID: 127951 RVA: 0x0045C30C File Offset: 0x0045A50C
		public ITargetAttributeT UnPack()
		{
			ITargetAttributeT targetAttributeT = new ITargetAttributeT();
			this.UnPackTo(targetAttributeT);
			return targetAttributeT;
		}

		// Token: 0x0601F3D0 RID: 127952 RVA: 0x0045C327 File Offset: 0x0045A527
		public void UnPackTo(ITargetAttributeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F3D1 RID: 127953 RVA: 0x0045C338 File Offset: 0x0045A538
		public static Offset<ITargetAttribute> Pack(FlatBufferBuilder builder, ITargetAttributeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetAttribute>);
			}
			return ITargetAttribute.CreateITargetAttribute(builder, _o.Type);
		}

		// Token: 0x0400D6B0 RID: 54960
		private Table __p;
	}
}
