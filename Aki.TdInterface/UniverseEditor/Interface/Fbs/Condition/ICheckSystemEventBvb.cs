using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005022 RID: 20514
	public struct ICheckSystemEventBvb : IFlatbufferObject
	{
		// Token: 0x170092CA RID: 37578
		// (get) Token: 0x0602007D RID: 131197 RVA: 0x00471A68 File Offset: 0x0046FC68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602007E RID: 131198 RVA: 0x00471A75 File Offset: 0x0046FC75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602007F RID: 131199 RVA: 0x00471A7C File Offset: 0x0046FC7C
		public static ICheckSystemEventBvb GetRootAsICheckSystemEventBvb(ByteBuffer _bb)
		{
			return ICheckSystemEventBvb.GetRootAsICheckSystemEventBvb(_bb, default(ICheckSystemEventBvb));
		}

		// Token: 0x06020080 RID: 131200 RVA: 0x00471A98 File Offset: 0x0046FC98
		public static ICheckSystemEventBvb GetRootAsICheckSystemEventBvb(ByteBuffer _bb, ICheckSystemEventBvb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020081 RID: 131201 RVA: 0x00471AB5 File Offset: 0x0046FCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020082 RID: 131202 RVA: 0x00471AC4 File Offset: 0x0046FCC4
		public ICheckSystemEventBvb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092CB RID: 37579
		// (get) Token: 0x06020083 RID: 131203 RVA: 0x00471AD4 File Offset: 0x0046FCD4
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092CC RID: 37580
		// (get) Token: 0x06020084 RID: 131204 RVA: 0x00471B10 File Offset: 0x0046FD10
		public EBvbEventName EventName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EBvbEventName.AIEvolution;
				}
				return (EBvbEventName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020085 RID: 131205 RVA: 0x00471B4C File Offset: 0x0046FD4C
		public static Offset<ICheckSystemEventBvb> CreateICheckSystemEventBvb(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EBvbEventName EventName = EBvbEventName.AIEvolution)
		{
			builder.StartTable(2);
			ICheckSystemEventBvb.AddEventName(builder, EventName);
			ICheckSystemEventBvb.AddType(builder, Type);
			return ICheckSystemEventBvb.EndICheckSystemEventBvb(builder);
		}

		// Token: 0x06020086 RID: 131206 RVA: 0x00471B69 File Offset: 0x0046FD69
		public static void StartICheckSystemEventBvb(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020087 RID: 131207 RVA: 0x00471B72 File Offset: 0x0046FD72
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020088 RID: 131208 RVA: 0x00471B7D File Offset: 0x0046FD7D
		public static void AddEventName(FlatBufferBuilder builder, EBvbEventName eventName)
		{
			builder.AddByte(1, (byte)eventName, 0);
		}

		// Token: 0x06020089 RID: 131209 RVA: 0x00471B88 File Offset: 0x0046FD88
		public static Offset<ICheckSystemEventBvb> EndICheckSystemEventBvb(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSystemEventBvb>(builder.EndTable());
		}

		// Token: 0x0602008A RID: 131210 RVA: 0x00471B98 File Offset: 0x0046FD98
		public ICheckSystemEventBvbT UnPack()
		{
			ICheckSystemEventBvbT checkSystemEventBvbT = new ICheckSystemEventBvbT();
			this.UnPackTo(checkSystemEventBvbT);
			return checkSystemEventBvbT;
		}

		// Token: 0x0602008B RID: 131211 RVA: 0x00471BB3 File Offset: 0x0046FDB3
		public void UnPackTo(ICheckSystemEventBvbT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
		}

		// Token: 0x0602008C RID: 131212 RVA: 0x00471BD0 File Offset: 0x0046FDD0
		public static Offset<ICheckSystemEventBvb> Pack(FlatBufferBuilder builder, ICheckSystemEventBvbT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSystemEventBvb>);
			}
			return ICheckSystemEventBvb.CreateICheckSystemEventBvb(builder, _o.Type, _o.EventName);
		}

		// Token: 0x0400DEE2 RID: 57058
		private Table __p;
	}
}
