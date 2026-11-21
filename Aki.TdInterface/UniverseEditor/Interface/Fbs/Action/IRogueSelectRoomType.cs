using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007675 RID: 30325
	public struct IRogueSelectRoomType : IFlatbufferObject
	{
		// Token: 0x1700DE9E RID: 56990
		// (get) Token: 0x0603533F RID: 217919 RVA: 0x00724117 File Offset: 0x00722317
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035340 RID: 217920 RVA: 0x00724124 File Offset: 0x00722324
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035341 RID: 217921 RVA: 0x0072412C File Offset: 0x0072232C
		public static IRogueSelectRoomType GetRootAsIRogueSelectRoomType(ByteBuffer _bb)
		{
			return IRogueSelectRoomType.GetRootAsIRogueSelectRoomType(_bb, default(IRogueSelectRoomType));
		}

		// Token: 0x06035342 RID: 217922 RVA: 0x00724148 File Offset: 0x00722348
		public static IRogueSelectRoomType GetRootAsIRogueSelectRoomType(ByteBuffer _bb, IRogueSelectRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035343 RID: 217923 RVA: 0x00724165 File Offset: 0x00722365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035344 RID: 217924 RVA: 0x00724174 File Offset: 0x00722374
		public IRogueSelectRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE9F RID: 56991
		// (get) Token: 0x06035345 RID: 217925 RVA: 0x00724184 File Offset: 0x00722384
		public ERogueSelectRoomType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueSelectRoomType.Role;
				}
				return (ERogueSelectRoomType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035346 RID: 217926 RVA: 0x007241C0 File Offset: 0x007223C0
		public static Offset<IRogueSelectRoomType> CreateIRogueSelectRoomType(FlatBufferBuilder builder, ERogueSelectRoomType Type = ERogueSelectRoomType.Role)
		{
			builder.StartTable(1);
			IRogueSelectRoomType.AddType(builder, Type);
			return IRogueSelectRoomType.EndIRogueSelectRoomType(builder);
		}

		// Token: 0x06035347 RID: 217927 RVA: 0x007241D6 File Offset: 0x007223D6
		public static void StartIRogueSelectRoomType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035348 RID: 217928 RVA: 0x007241DF File Offset: 0x007223DF
		public static void AddType(FlatBufferBuilder builder, ERogueSelectRoomType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035349 RID: 217929 RVA: 0x007241EA File Offset: 0x007223EA
		public static Offset<IRogueSelectRoomType> EndIRogueSelectRoomType(FlatBufferBuilder builder)
		{
			return new Offset<IRogueSelectRoomType>(builder.EndTable());
		}

		// Token: 0x0603534A RID: 217930 RVA: 0x007241F8 File Offset: 0x007223F8
		public IRogueSelectRoomTypeT UnPack()
		{
			IRogueSelectRoomTypeT rogueSelectRoomTypeT = new IRogueSelectRoomTypeT();
			this.UnPackTo(rogueSelectRoomTypeT);
			return rogueSelectRoomTypeT;
		}

		// Token: 0x0603534B RID: 217931 RVA: 0x00724213 File Offset: 0x00722413
		public void UnPackTo(IRogueSelectRoomTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603534C RID: 217932 RVA: 0x00724224 File Offset: 0x00722424
		public static Offset<IRogueSelectRoomType> Pack(FlatBufferBuilder builder, IRogueSelectRoomTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueSelectRoomType>);
			}
			return IRogueSelectRoomType.CreateIRogueSelectRoomType(builder, _o.Type);
		}

		// Token: 0x04012869 RID: 75881
		private Table __p;
	}
}
