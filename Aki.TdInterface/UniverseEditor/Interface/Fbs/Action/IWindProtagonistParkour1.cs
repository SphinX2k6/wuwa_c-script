using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E15 RID: 32277
	public struct IWindProtagonistParkour1 : IFlatbufferObject
	{
		// Token: 0x1700F1C2 RID: 61890
		// (get) Token: 0x0603A547 RID: 238919 RVA: 0x007DB94D File Offset: 0x007D9B4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A548 RID: 238920 RVA: 0x007DB95A File Offset: 0x007D9B5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A549 RID: 238921 RVA: 0x007DB964 File Offset: 0x007D9B64
		public static IWindProtagonistParkour1 GetRootAsIWindProtagonistParkour1(ByteBuffer _bb)
		{
			return IWindProtagonistParkour1.GetRootAsIWindProtagonistParkour1(_bb, default(IWindProtagonistParkour1));
		}

		// Token: 0x0603A54A RID: 238922 RVA: 0x007DB980 File Offset: 0x007D9B80
		public static IWindProtagonistParkour1 GetRootAsIWindProtagonistParkour1(ByteBuffer _bb, IWindProtagonistParkour1 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A54B RID: 238923 RVA: 0x007DB99D File Offset: 0x007D9B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A54C RID: 238924 RVA: 0x007DB9AC File Offset: 0x007D9BAC
		public IWindProtagonistParkour1 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1C3 RID: 61891
		// (get) Token: 0x0603A54D RID: 238925 RVA: 0x007DB9BC File Offset: 0x007D9BBC
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A54E RID: 238926 RVA: 0x007DB9F8 File Offset: 0x007D9BF8
		public static Offset<IWindProtagonistParkour1> CreateIWindProtagonistParkour1(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IWindProtagonistParkour1.AddType(builder, Type);
			return IWindProtagonistParkour1.EndIWindProtagonistParkour1(builder);
		}

		// Token: 0x0603A54F RID: 238927 RVA: 0x007DBA0E File Offset: 0x007D9C0E
		public static void StartIWindProtagonistParkour1(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A550 RID: 238928 RVA: 0x007DBA17 File Offset: 0x007D9C17
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A551 RID: 238929 RVA: 0x007DBA22 File Offset: 0x007D9C22
		public static Offset<IWindProtagonistParkour1> EndIWindProtagonistParkour1(FlatBufferBuilder builder)
		{
			return new Offset<IWindProtagonistParkour1>(builder.EndTable());
		}

		// Token: 0x0603A552 RID: 238930 RVA: 0x007DBA30 File Offset: 0x007D9C30
		public IWindProtagonistParkour1T UnPack()
		{
			IWindProtagonistParkour1T windProtagonistParkour1T = new IWindProtagonistParkour1T();
			this.UnPackTo(windProtagonistParkour1T);
			return windProtagonistParkour1T;
		}

		// Token: 0x0603A553 RID: 238931 RVA: 0x007DBA4B File Offset: 0x007D9C4B
		public void UnPackTo(IWindProtagonistParkour1T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A554 RID: 238932 RVA: 0x007DBA5C File Offset: 0x007D9C5C
		public static Offset<IWindProtagonistParkour1> Pack(FlatBufferBuilder builder, IWindProtagonistParkour1T _o)
		{
			if (_o == null)
			{
				return default(Offset<IWindProtagonistParkour1>);
			}
			return IWindProtagonistParkour1.CreateIWindProtagonistParkour1(builder, _o.Type);
		}

		// Token: 0x040135C3 RID: 79299
		private Table __p;
	}
}
