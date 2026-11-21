using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A1F RID: 31263
	public struct ISwingGetUp : IFlatbufferObject
	{
		// Token: 0x1700E511 RID: 58641
		// (get) Token: 0x0603714E RID: 225614 RVA: 0x0075C48E File Offset: 0x0075A68E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603714F RID: 225615 RVA: 0x0075C49B File Offset: 0x0075A69B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037150 RID: 225616 RVA: 0x0075C4A4 File Offset: 0x0075A6A4
		public static ISwingGetUp GetRootAsISwingGetUp(ByteBuffer _bb)
		{
			return ISwingGetUp.GetRootAsISwingGetUp(_bb, default(ISwingGetUp));
		}

		// Token: 0x06037151 RID: 225617 RVA: 0x0075C4C0 File Offset: 0x0075A6C0
		public static ISwingGetUp GetRootAsISwingGetUp(ByteBuffer _bb, ISwingGetUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037152 RID: 225618 RVA: 0x0075C4DD File Offset: 0x0075A6DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037153 RID: 225619 RVA: 0x0075C4EC File Offset: 0x0075A6EC
		public ISwingGetUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E512 RID: 58642
		// (get) Token: 0x06037154 RID: 225620 RVA: 0x0075C4FC File Offset: 0x0075A6FC
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

		// Token: 0x06037155 RID: 225621 RVA: 0x0075C538 File Offset: 0x0075A738
		public static Offset<ISwingGetUp> CreateISwingGetUp(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISwingGetUp.AddType(builder, Type);
			return ISwingGetUp.EndISwingGetUp(builder);
		}

		// Token: 0x06037156 RID: 225622 RVA: 0x0075C54E File Offset: 0x0075A74E
		public static void StartISwingGetUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06037157 RID: 225623 RVA: 0x0075C557 File Offset: 0x0075A757
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037158 RID: 225624 RVA: 0x0075C562 File Offset: 0x0075A762
		public static Offset<ISwingGetUp> EndISwingGetUp(FlatBufferBuilder builder)
		{
			return new Offset<ISwingGetUp>(builder.EndTable());
		}

		// Token: 0x06037159 RID: 225625 RVA: 0x0075C570 File Offset: 0x0075A770
		public ISwingGetUpT UnPack()
		{
			ISwingGetUpT swingGetUpT = new ISwingGetUpT();
			this.UnPackTo(swingGetUpT);
			return swingGetUpT;
		}

		// Token: 0x0603715A RID: 225626 RVA: 0x0075C58B File Offset: 0x0075A78B
		public void UnPackTo(ISwingGetUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603715B RID: 225627 RVA: 0x0075C59C File Offset: 0x0075A79C
		public static Offset<ISwingGetUp> Pack(FlatBufferBuilder builder, ISwingGetUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwingGetUp>);
			}
			return ISwingGetUp.CreateISwingGetUp(builder, _o.Type);
		}

		// Token: 0x04012D3E RID: 77118
		private Table __p;
	}
}
