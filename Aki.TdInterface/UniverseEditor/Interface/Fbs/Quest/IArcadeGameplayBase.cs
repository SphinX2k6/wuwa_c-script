using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004118 RID: 16664
	public struct IArcadeGameplayBase : IFlatbufferObject
	{
		// Token: 0x170070E3 RID: 28899
		// (get) Token: 0x06016DDB RID: 93659 RVA: 0x00344034 File Offset: 0x00342234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016DDC RID: 93660 RVA: 0x00344041 File Offset: 0x00342241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016DDD RID: 93661 RVA: 0x00344048 File Offset: 0x00342248
		public static IArcadeGameplayBase GetRootAsIArcadeGameplayBase(ByteBuffer _bb)
		{
			return IArcadeGameplayBase.GetRootAsIArcadeGameplayBase(_bb, default(IArcadeGameplayBase));
		}

		// Token: 0x06016DDE RID: 93662 RVA: 0x00344064 File Offset: 0x00342264
		public static IArcadeGameplayBase GetRootAsIArcadeGameplayBase(ByteBuffer _bb, IArcadeGameplayBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016DDF RID: 93663 RVA: 0x00344081 File Offset: 0x00342281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016DE0 RID: 93664 RVA: 0x00344090 File Offset: 0x00342290
		public IArcadeGameplayBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070E4 RID: 28900
		// (get) Token: 0x06016DE1 RID: 93665 RVA: 0x003440A0 File Offset: 0x003422A0
		public EArcadeGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EArcadeGameplayType.DropCatch;
				}
				return (EArcadeGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016DE2 RID: 93666 RVA: 0x003440DC File Offset: 0x003422DC
		public static Offset<IArcadeGameplayBase> CreateIArcadeGameplayBase(FlatBufferBuilder builder, EArcadeGameplayType Type = EArcadeGameplayType.DropCatch)
		{
			builder.StartTable(1);
			IArcadeGameplayBase.AddType(builder, Type);
			return IArcadeGameplayBase.EndIArcadeGameplayBase(builder);
		}

		// Token: 0x06016DE3 RID: 93667 RVA: 0x003440F2 File Offset: 0x003422F2
		public static void StartIArcadeGameplayBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016DE4 RID: 93668 RVA: 0x003440FB File Offset: 0x003422FB
		public static void AddType(FlatBufferBuilder builder, EArcadeGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016DE5 RID: 93669 RVA: 0x00344106 File Offset: 0x00342306
		public static Offset<IArcadeGameplayBase> EndIArcadeGameplayBase(FlatBufferBuilder builder)
		{
			return new Offset<IArcadeGameplayBase>(builder.EndTable());
		}

		// Token: 0x06016DE6 RID: 93670 RVA: 0x00344114 File Offset: 0x00342314
		public IArcadeGameplayBaseT UnPack()
		{
			IArcadeGameplayBaseT arcadeGameplayBaseT = new IArcadeGameplayBaseT();
			this.UnPackTo(arcadeGameplayBaseT);
			return arcadeGameplayBaseT;
		}

		// Token: 0x06016DE7 RID: 93671 RVA: 0x0034412F File Offset: 0x0034232F
		public void UnPackTo(IArcadeGameplayBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016DE8 RID: 93672 RVA: 0x00344140 File Offset: 0x00342340
		public static Offset<IArcadeGameplayBase> Pack(FlatBufferBuilder builder, IArcadeGameplayBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IArcadeGameplayBase>);
			}
			return IArcadeGameplayBase.CreateIArcadeGameplayBase(builder, _o.Type);
		}

		// Token: 0x0400BF5F RID: 48991
		private Table __p;
	}
}
