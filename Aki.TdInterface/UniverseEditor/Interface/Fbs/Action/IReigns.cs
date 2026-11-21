using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759A RID: 30106
	public struct IReigns : IFlatbufferObject
	{
		// Token: 0x1700DD6C RID: 56684
		// (get) Token: 0x06034CFF RID: 216319 RVA: 0x00719DA4 File Offset: 0x00717FA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D00 RID: 216320 RVA: 0x00719DB1 File Offset: 0x00717FB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D01 RID: 216321 RVA: 0x00719DB8 File Offset: 0x00717FB8
		public static IReigns GetRootAsIReigns(ByteBuffer _bb)
		{
			return IReigns.GetRootAsIReigns(_bb, default(IReigns));
		}

		// Token: 0x06034D02 RID: 216322 RVA: 0x00719DD4 File Offset: 0x00717FD4
		public static IReigns GetRootAsIReigns(ByteBuffer _bb, IReigns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D03 RID: 216323 RVA: 0x00719DF1 File Offset: 0x00717FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D04 RID: 216324 RVA: 0x00719E00 File Offset: 0x00718000
		public IReigns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD6D RID: 56685
		// (get) Token: 0x06034D05 RID: 216325 RVA: 0x00719E10 File Offset: 0x00718010
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DD6E RID: 56686
		// (get) Token: 0x06034D06 RID: 216326 RVA: 0x00719E4C File Offset: 0x0071804C
		public int ReignsId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034D07 RID: 216327 RVA: 0x00719E88 File Offset: 0x00718088
		public static Offset<IReigns> CreateIReigns(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int ReignsId = 0)
		{
			builder.StartTable(2);
			IReigns.AddReignsId(builder, ReignsId);
			IReigns.AddType(builder, Type);
			return IReigns.EndIReigns(builder);
		}

		// Token: 0x06034D08 RID: 216328 RVA: 0x00719EA5 File Offset: 0x007180A5
		public static void StartIReigns(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034D09 RID: 216329 RVA: 0x00719EAE File Offset: 0x007180AE
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034D0A RID: 216330 RVA: 0x00719EB9 File Offset: 0x007180B9
		public static void AddReignsId(FlatBufferBuilder builder, int reignsId)
		{
			builder.AddInt(1, reignsId, 0);
		}

		// Token: 0x06034D0B RID: 216331 RVA: 0x00719EC4 File Offset: 0x007180C4
		public static Offset<IReigns> EndIReigns(FlatBufferBuilder builder)
		{
			return new Offset<IReigns>(builder.EndTable());
		}

		// Token: 0x06034D0C RID: 216332 RVA: 0x00719ED4 File Offset: 0x007180D4
		public IReignsT UnPack()
		{
			IReignsT reignsT = new IReignsT();
			this.UnPackTo(reignsT);
			return reignsT;
		}

		// Token: 0x06034D0D RID: 216333 RVA: 0x00719EEF File Offset: 0x007180EF
		public void UnPackTo(IReignsT _o)
		{
			_o.Type = this.Type;
			_o.ReignsId = this.ReignsId;
		}

		// Token: 0x06034D0E RID: 216334 RVA: 0x00719F0C File Offset: 0x0071810C
		public static Offset<IReigns> Pack(FlatBufferBuilder builder, IReignsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReigns>);
			}
			return IReigns.CreateIReigns(builder, _o.Type, _o.ReignsId);
		}

		// Token: 0x04012786 RID: 75654
		private Table __p;
	}
}
