using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C6 RID: 22470
	public struct IFireElementalMatch : IFlatbufferObject
	{
		// Token: 0x1700A26E RID: 41582
		// (get) Token: 0x06024467 RID: 148583 RVA: 0x004FC2D3 File Offset: 0x004FA4D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024468 RID: 148584 RVA: 0x004FC2E0 File Offset: 0x004FA4E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024469 RID: 148585 RVA: 0x004FC2E8 File Offset: 0x004FA4E8
		public static IFireElementalMatch GetRootAsIFireElementalMatch(ByteBuffer _bb)
		{
			return IFireElementalMatch.GetRootAsIFireElementalMatch(_bb, default(IFireElementalMatch));
		}

		// Token: 0x0602446A RID: 148586 RVA: 0x004FC304 File Offset: 0x004FA504
		public static IFireElementalMatch GetRootAsIFireElementalMatch(ByteBuffer _bb, IFireElementalMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602446B RID: 148587 RVA: 0x004FC321 File Offset: 0x004FA521
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602446C RID: 148588 RVA: 0x004FC330 File Offset: 0x004FA530
		public IFireElementalMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A26F RID: 41583
		// (get) Token: 0x0602446D RID: 148589 RVA: 0x004FC340 File Offset: 0x004FA540
		public EElementalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602446E RID: 148590 RVA: 0x004FC37C File Offset: 0x004FA57C
		public static Offset<IFireElementalMatch> CreateIFireElementalMatch(FlatBufferBuilder builder, EElementalType Type = EElementalType.Fire)
		{
			builder.StartTable(1);
			IFireElementalMatch.AddType(builder, Type);
			return IFireElementalMatch.EndIFireElementalMatch(builder);
		}

		// Token: 0x0602446F RID: 148591 RVA: 0x004FC392 File Offset: 0x004FA592
		public static void StartIFireElementalMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024470 RID: 148592 RVA: 0x004FC39B File Offset: 0x004FA59B
		public static void AddType(FlatBufferBuilder builder, EElementalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024471 RID: 148593 RVA: 0x004FC3A6 File Offset: 0x004FA5A6
		public static Offset<IFireElementalMatch> EndIFireElementalMatch(FlatBufferBuilder builder)
		{
			return new Offset<IFireElementalMatch>(builder.EndTable());
		}

		// Token: 0x06024472 RID: 148594 RVA: 0x004FC3B4 File Offset: 0x004FA5B4
		public IFireElementalMatchT UnPack()
		{
			IFireElementalMatchT fireElementalMatchT = new IFireElementalMatchT();
			this.UnPackTo(fireElementalMatchT);
			return fireElementalMatchT;
		}

		// Token: 0x06024473 RID: 148595 RVA: 0x004FC3CF File Offset: 0x004FA5CF
		public void UnPackTo(IFireElementalMatchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06024474 RID: 148596 RVA: 0x004FC3E0 File Offset: 0x004FA5E0
		public static Offset<IFireElementalMatch> Pack(FlatBufferBuilder builder, IFireElementalMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireElementalMatch>);
			}
			return IFireElementalMatch.CreateIFireElementalMatch(builder, _o.Type);
		}

		// Token: 0x0400EFB6 RID: 61366
		private Table __p;
	}
}
