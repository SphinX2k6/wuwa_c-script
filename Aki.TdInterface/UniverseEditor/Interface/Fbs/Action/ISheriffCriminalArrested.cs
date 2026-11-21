using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200788D RID: 30861
	public struct ISheriffCriminalArrested : IFlatbufferObject
	{
		// Token: 0x1700E251 RID: 57937
		// (get) Token: 0x060364A0 RID: 222368 RVA: 0x007454FA File Offset: 0x007436FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060364A1 RID: 222369 RVA: 0x00745507 File Offset: 0x00743707
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060364A2 RID: 222370 RVA: 0x00745510 File Offset: 0x00743710
		public static ISheriffCriminalArrested GetRootAsISheriffCriminalArrested(ByteBuffer _bb)
		{
			return ISheriffCriminalArrested.GetRootAsISheriffCriminalArrested(_bb, default(ISheriffCriminalArrested));
		}

		// Token: 0x060364A3 RID: 222371 RVA: 0x0074552C File Offset: 0x0074372C
		public static ISheriffCriminalArrested GetRootAsISheriffCriminalArrested(ByteBuffer _bb, ISheriffCriminalArrested obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060364A4 RID: 222372 RVA: 0x00745549 File Offset: 0x00743749
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060364A5 RID: 222373 RVA: 0x00745558 File Offset: 0x00743758
		public ISheriffCriminalArrested __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E252 RID: 57938
		// (get) Token: 0x060364A6 RID: 222374 RVA: 0x00745568 File Offset: 0x00743768
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E253 RID: 57939
		// (get) Token: 0x060364A7 RID: 222375 RVA: 0x007455A4 File Offset: 0x007437A4
		public int Id
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

		// Token: 0x060364A8 RID: 222376 RVA: 0x007455E0 File Offset: 0x007437E0
		public static Offset<ISheriffCriminalArrested> CreateISheriffCriminalArrested(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, int Id = 0)
		{
			builder.StartTable(2);
			ISheriffCriminalArrested.AddId(builder, Id);
			ISheriffCriminalArrested.AddType(builder, Type);
			return ISheriffCriminalArrested.EndISheriffCriminalArrested(builder);
		}

		// Token: 0x060364A9 RID: 222377 RVA: 0x007455FD File Offset: 0x007437FD
		public static void StartISheriffCriminalArrested(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060364AA RID: 222378 RVA: 0x00745606 File Offset: 0x00743806
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060364AB RID: 222379 RVA: 0x00745611 File Offset: 0x00743811
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x060364AC RID: 222380 RVA: 0x0074561C File Offset: 0x0074381C
		public static Offset<ISheriffCriminalArrested> EndISheriffCriminalArrested(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffCriminalArrested>(builder.EndTable());
		}

		// Token: 0x060364AD RID: 222381 RVA: 0x0074562C File Offset: 0x0074382C
		public ISheriffCriminalArrestedT UnPack()
		{
			ISheriffCriminalArrestedT sheriffCriminalArrestedT = new ISheriffCriminalArrestedT();
			this.UnPackTo(sheriffCriminalArrestedT);
			return sheriffCriminalArrestedT;
		}

		// Token: 0x060364AE RID: 222382 RVA: 0x00745647 File Offset: 0x00743847
		public void UnPackTo(ISheriffCriminalArrestedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x060364AF RID: 222383 RVA: 0x00745664 File Offset: 0x00743864
		public static Offset<ISheriffCriminalArrested> Pack(FlatBufferBuilder builder, ISheriffCriminalArrestedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffCriminalArrested>);
			}
			return ISheriffCriminalArrested.CreateISheriffCriminalArrested(builder, _o.Type, _o.Id);
		}

		// Token: 0x04012B1E RID: 76574
		private Table __p;
	}
}
