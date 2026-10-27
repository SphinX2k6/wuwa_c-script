using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A1B RID: 18971
	public struct ICheckEntityType : IFlatbufferObject
	{
		// Token: 0x17008959 RID: 35161
		// (get) Token: 0x0601DAF5 RID: 121589 RVA: 0x0042D2B7 File Offset: 0x0042B4B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DAF6 RID: 121590 RVA: 0x0042D2C4 File Offset: 0x0042B4C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DAF7 RID: 121591 RVA: 0x0042D2CC File Offset: 0x0042B4CC
		public static ICheckEntityType GetRootAsICheckEntityType(ByteBuffer _bb)
		{
			return ICheckEntityType.GetRootAsICheckEntityType(_bb, default(ICheckEntityType));
		}

		// Token: 0x0601DAF8 RID: 121592 RVA: 0x0042D2E8 File Offset: 0x0042B4E8
		public static ICheckEntityType GetRootAsICheckEntityType(ByteBuffer _bb, ICheckEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DAF9 RID: 121593 RVA: 0x0042D305 File Offset: 0x0042B505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DAFA RID: 121594 RVA: 0x0042D314 File Offset: 0x0042B514
		public ICheckEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700895A RID: 35162
		// (get) Token: 0x0601DAFB RID: 121595 RVA: 0x0042D324 File Offset: 0x0042B524
		public ECheckEntity Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEntity.OnlinePlayer;
				}
				return (ECheckEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DAFC RID: 121596 RVA: 0x0042D360 File Offset: 0x0042B560
		public static Offset<ICheckEntityType> CreateICheckEntityType(FlatBufferBuilder builder, ECheckEntity Type = ECheckEntity.OnlinePlayer)
		{
			builder.StartTable(1);
			ICheckEntityType.AddType(builder, Type);
			return ICheckEntityType.EndICheckEntityType(builder);
		}

		// Token: 0x0601DAFD RID: 121597 RVA: 0x0042D376 File Offset: 0x0042B576
		public static void StartICheckEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DAFE RID: 121598 RVA: 0x0042D37F File Offset: 0x0042B57F
		public static void AddType(FlatBufferBuilder builder, ECheckEntity type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DAFF RID: 121599 RVA: 0x0042D38A File Offset: 0x0042B58A
		public static Offset<ICheckEntityType> EndICheckEntityType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityType>(builder.EndTable());
		}

		// Token: 0x0601DB00 RID: 121600 RVA: 0x0042D398 File Offset: 0x0042B598
		public ICheckEntityTypeT UnPack()
		{
			ICheckEntityTypeT checkEntityTypeT = new ICheckEntityTypeT();
			this.UnPackTo(checkEntityTypeT);
			return checkEntityTypeT;
		}

		// Token: 0x0601DB01 RID: 121601 RVA: 0x0042D3B3 File Offset: 0x0042B5B3
		public void UnPackTo(ICheckEntityTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601DB02 RID: 121602 RVA: 0x0042D3C4 File Offset: 0x0042B5C4
		public static Offset<ICheckEntityType> Pack(FlatBufferBuilder builder, ICheckEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityType>);
			}
			return ICheckEntityType.CreateICheckEntityType(builder, _o.Type);
		}

		// Token: 0x0400D269 RID: 53865
		private Table __p;
	}
}
