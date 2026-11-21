using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051ED RID: 20973
	public struct ITargetEntityType : IFlatbufferObject
	{
		// Token: 0x17009629 RID: 38441
		// (get) Token: 0x06021075 RID: 135285 RVA: 0x00490AF4 File Offset: 0x0048ECF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021076 RID: 135286 RVA: 0x00490B01 File Offset: 0x0048ED01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021077 RID: 135287 RVA: 0x00490B08 File Offset: 0x0048ED08
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb)
		{
			return ITargetEntityType.GetRootAsITargetEntityType(_bb, default(ITargetEntityType));
		}

		// Token: 0x06021078 RID: 135288 RVA: 0x00490B24 File Offset: 0x0048ED24
		public static ITargetEntityType GetRootAsITargetEntityType(ByteBuffer _bb, ITargetEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021079 RID: 135289 RVA: 0x00490B41 File Offset: 0x0048ED41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602107A RID: 135290 RVA: 0x00490B50 File Offset: 0x0048ED50
		public ITargetEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700962A RID: 38442
		// (get) Token: 0x0602107B RID: 135291 RVA: 0x00490B60 File Offset: 0x0048ED60
		public ETargetEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetEntityType.Target;
				}
				return (ETargetEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602107C RID: 135292 RVA: 0x00490B9C File Offset: 0x0048ED9C
		public static Offset<ITargetEntityType> CreateITargetEntityType(FlatBufferBuilder builder, ETargetEntityType Type = ETargetEntityType.Target)
		{
			builder.StartTable(1);
			ITargetEntityType.AddType(builder, Type);
			return ITargetEntityType.EndITargetEntityType(builder);
		}

		// Token: 0x0602107D RID: 135293 RVA: 0x00490BB2 File Offset: 0x0048EDB2
		public static void StartITargetEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602107E RID: 135294 RVA: 0x00490BBB File Offset: 0x0048EDBB
		public static void AddType(FlatBufferBuilder builder, ETargetEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602107F RID: 135295 RVA: 0x00490BC6 File Offset: 0x0048EDC6
		public static Offset<ITargetEntityType> EndITargetEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ITargetEntityType>(builder.EndTable());
		}

		// Token: 0x06021080 RID: 135296 RVA: 0x00490BD4 File Offset: 0x0048EDD4
		public ITargetEntityTypeT UnPack()
		{
			ITargetEntityTypeT targetEntityTypeT = new ITargetEntityTypeT();
			this.UnPackTo(targetEntityTypeT);
			return targetEntityTypeT;
		}

		// Token: 0x06021081 RID: 135297 RVA: 0x00490BEF File Offset: 0x0048EDEF
		public void UnPackTo(ITargetEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021082 RID: 135298 RVA: 0x00490C00 File Offset: 0x0048EE00
		public static Offset<ITargetEntityType> Pack(FlatBufferBuilder builder, ITargetEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetEntityType>);
			}
			return ITargetEntityType.CreateITargetEntityType(builder, _o.Type);
		}

		// Token: 0x0400E1F4 RID: 57844
		private Table __p;
	}
}
