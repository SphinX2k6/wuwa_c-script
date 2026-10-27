using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D4 RID: 24788
	public struct IActorLookAtData : IFlatbufferObject
	{
		// Token: 0x1700B6AD RID: 46765
		// (get) Token: 0x0602A55C RID: 173404 RVA: 0x005D5D6C File Offset: 0x005D3F6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A55D RID: 173405 RVA: 0x005D5D79 File Offset: 0x005D3F79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A55E RID: 173406 RVA: 0x005D5D80 File Offset: 0x005D3F80
		public static IActorLookAtData GetRootAsIActorLookAtData(ByteBuffer _bb)
		{
			return IActorLookAtData.GetRootAsIActorLookAtData(_bb, default(IActorLookAtData));
		}

		// Token: 0x0602A55F RID: 173407 RVA: 0x005D5D9C File Offset: 0x005D3F9C
		public static IActorLookAtData GetRootAsIActorLookAtData(ByteBuffer _bb, IActorLookAtData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A560 RID: 173408 RVA: 0x005D5DB9 File Offset: 0x005D3FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A561 RID: 173409 RVA: 0x005D5DC8 File Offset: 0x005D3FC8
		public IActorLookAtData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6AE RID: 46766
		// (get) Token: 0x0602A562 RID: 173410 RVA: 0x005D5DD8 File Offset: 0x005D3FD8
		public EActorLookAtMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorLookAtMode.Talker;
				}
				return (EActorLookAtMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A563 RID: 173411 RVA: 0x005D5E14 File Offset: 0x005D4014
		public static Offset<IActorLookAtData> CreateIActorLookAtData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker)
		{
			builder.StartTable(1);
			IActorLookAtData.AddType(builder, Type);
			return IActorLookAtData.EndIActorLookAtData(builder);
		}

		// Token: 0x0602A564 RID: 173412 RVA: 0x005D5E2A File Offset: 0x005D402A
		public static void StartIActorLookAtData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A565 RID: 173413 RVA: 0x005D5E33 File Offset: 0x005D4033
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A566 RID: 173414 RVA: 0x005D5E3E File Offset: 0x005D403E
		public static Offset<IActorLookAtData> EndIActorLookAtData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtData>(builder.EndTable());
		}

		// Token: 0x0602A567 RID: 173415 RVA: 0x005D5E4C File Offset: 0x005D404C
		public IActorLookAtDataT UnPack()
		{
			IActorLookAtDataT actorLookAtDataT = new IActorLookAtDataT();
			this.UnPackTo(actorLookAtDataT);
			return actorLookAtDataT;
		}

		// Token: 0x0602A568 RID: 173416 RVA: 0x005D5E67 File Offset: 0x005D4067
		public void UnPackTo(IActorLookAtDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A569 RID: 173417 RVA: 0x005D5E78 File Offset: 0x005D4078
		public static Offset<IActorLookAtData> Pack(FlatBufferBuilder builder, IActorLookAtDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtData>);
			}
			return IActorLookAtData.CreateIActorLookAtData(builder, _o.Type);
		}

		// Token: 0x04010484 RID: 66692
		private Table __p;
	}
}
