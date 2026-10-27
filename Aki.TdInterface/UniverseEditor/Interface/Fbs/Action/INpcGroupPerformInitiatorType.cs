using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB8 RID: 27576
	public struct INpcGroupPerformInitiatorType : IFlatbufferObject
	{
		// Token: 0x1700CCF7 RID: 52471
		// (get) Token: 0x06030719 RID: 198425 RVA: 0x0069432B File Offset: 0x0069252B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603071A RID: 198426 RVA: 0x00694338 File Offset: 0x00692538
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603071B RID: 198427 RVA: 0x00694340 File Offset: 0x00692540
		public static INpcGroupPerformInitiatorType GetRootAsINpcGroupPerformInitiatorType(ByteBuffer _bb)
		{
			return INpcGroupPerformInitiatorType.GetRootAsINpcGroupPerformInitiatorType(_bb, default(INpcGroupPerformInitiatorType));
		}

		// Token: 0x0603071C RID: 198428 RVA: 0x0069435C File Offset: 0x0069255C
		public static INpcGroupPerformInitiatorType GetRootAsINpcGroupPerformInitiatorType(ByteBuffer _bb, INpcGroupPerformInitiatorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603071D RID: 198429 RVA: 0x00694379 File Offset: 0x00692579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603071E RID: 198430 RVA: 0x00694388 File Offset: 0x00692588
		public INpcGroupPerformInitiatorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCF8 RID: 52472
		// (get) Token: 0x0603071F RID: 198431 RVA: 0x00694398 File Offset: 0x00692598
		public ENpcGroupPerformInitiatorType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcGroupPerformInitiatorType.Player;
				}
				return (ENpcGroupPerformInitiatorType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030720 RID: 198432 RVA: 0x006943D4 File Offset: 0x006925D4
		public static Offset<INpcGroupPerformInitiatorType> CreateINpcGroupPerformInitiatorType(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType Type = ENpcGroupPerformInitiatorType.Player)
		{
			builder.StartTable(1);
			INpcGroupPerformInitiatorType.AddType(builder, Type);
			return INpcGroupPerformInitiatorType.EndINpcGroupPerformInitiatorType(builder);
		}

		// Token: 0x06030721 RID: 198433 RVA: 0x006943EA File Offset: 0x006925EA
		public static void StartINpcGroupPerformInitiatorType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030722 RID: 198434 RVA: 0x006943F3 File Offset: 0x006925F3
		public static void AddType(FlatBufferBuilder builder, ENpcGroupPerformInitiatorType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030723 RID: 198435 RVA: 0x006943FE File Offset: 0x006925FE
		public static Offset<INpcGroupPerformInitiatorType> EndINpcGroupPerformInitiatorType(FlatBufferBuilder builder)
		{
			return new Offset<INpcGroupPerformInitiatorType>(builder.EndTable());
		}

		// Token: 0x06030724 RID: 198436 RVA: 0x0069440C File Offset: 0x0069260C
		public INpcGroupPerformInitiatorTypeT UnPack()
		{
			INpcGroupPerformInitiatorTypeT npcGroupPerformInitiatorTypeT = new INpcGroupPerformInitiatorTypeT();
			this.UnPackTo(npcGroupPerformInitiatorTypeT);
			return npcGroupPerformInitiatorTypeT;
		}

		// Token: 0x06030725 RID: 198437 RVA: 0x00694427 File Offset: 0x00692627
		public void UnPackTo(INpcGroupPerformInitiatorTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030726 RID: 198438 RVA: 0x00694438 File Offset: 0x00692638
		public static Offset<INpcGroupPerformInitiatorType> Pack(FlatBufferBuilder builder, INpcGroupPerformInitiatorTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcGroupPerformInitiatorType>);
			}
			return INpcGroupPerformInitiatorType.CreateINpcGroupPerformInitiatorType(builder, _o.Type);
		}

		// Token: 0x0401148D RID: 70797
		private Table __p;
	}
}
