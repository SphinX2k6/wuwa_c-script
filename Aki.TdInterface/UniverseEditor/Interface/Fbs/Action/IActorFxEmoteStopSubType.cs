using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671E RID: 26398
	public struct IActorFxEmoteStopSubType : IFlatbufferObject
	{
		// Token: 0x1700BFEE RID: 49134
		// (get) Token: 0x0602CB69 RID: 183145 RVA: 0x0061E0E5 File Offset: 0x0061C2E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB6A RID: 183146 RVA: 0x0061E0F2 File Offset: 0x0061C2F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB6B RID: 183147 RVA: 0x0061E0FC File Offset: 0x0061C2FC
		public static IActorFxEmoteStopSubType GetRootAsIActorFxEmoteStopSubType(ByteBuffer _bb)
		{
			return IActorFxEmoteStopSubType.GetRootAsIActorFxEmoteStopSubType(_bb, default(IActorFxEmoteStopSubType));
		}

		// Token: 0x0602CB6C RID: 183148 RVA: 0x0061E118 File Offset: 0x0061C318
		public static IActorFxEmoteStopSubType GetRootAsIActorFxEmoteStopSubType(ByteBuffer _bb, IActorFxEmoteStopSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB6D RID: 183149 RVA: 0x0061E135 File Offset: 0x0061C335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB6E RID: 183150 RVA: 0x0061E144 File Offset: 0x0061C344
		public IActorFxEmoteStopSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFEF RID: 49135
		// (get) Token: 0x0602CB6F RID: 183151 RVA: 0x0061E154 File Offset: 0x0061C354
		public EActorFxEmoteStopSubType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFxEmoteStopSubType.StopAll;
				}
				return (EActorFxEmoteStopSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB70 RID: 183152 RVA: 0x0061E190 File Offset: 0x0061C390
		public static Offset<IActorFxEmoteStopSubType> CreateIActorFxEmoteStopSubType(FlatBufferBuilder builder, EActorFxEmoteStopSubType Type = EActorFxEmoteStopSubType.StopAll)
		{
			builder.StartTable(1);
			IActorFxEmoteStopSubType.AddType(builder, Type);
			return IActorFxEmoteStopSubType.EndIActorFxEmoteStopSubType(builder);
		}

		// Token: 0x0602CB71 RID: 183153 RVA: 0x0061E1A6 File Offset: 0x0061C3A6
		public static void StartIActorFxEmoteStopSubType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CB72 RID: 183154 RVA: 0x0061E1AF File Offset: 0x0061C3AF
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteStopSubType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CB73 RID: 183155 RVA: 0x0061E1BA File Offset: 0x0061C3BA
		public static Offset<IActorFxEmoteStopSubType> EndIActorFxEmoteStopSubType(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStopSubType>(builder.EndTable());
		}

		// Token: 0x0602CB74 RID: 183156 RVA: 0x0061E1C8 File Offset: 0x0061C3C8
		public IActorFxEmoteStopSubTypeT UnPack()
		{
			IActorFxEmoteStopSubTypeT actorFxEmoteStopSubTypeT = new IActorFxEmoteStopSubTypeT();
			this.UnPackTo(actorFxEmoteStopSubTypeT);
			return actorFxEmoteStopSubTypeT;
		}

		// Token: 0x0602CB75 RID: 183157 RVA: 0x0061E1E3 File Offset: 0x0061C3E3
		public void UnPackTo(IActorFxEmoteStopSubTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CB76 RID: 183158 RVA: 0x0061E1F4 File Offset: 0x0061C3F4
		public static Offset<IActorFxEmoteStopSubType> Pack(FlatBufferBuilder builder, IActorFxEmoteStopSubTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteStopSubType>);
			}
			return IActorFxEmoteStopSubType.CreateIActorFxEmoteStopSubType(builder, _o.Type);
		}

		// Token: 0x04011264 RID: 70244
		private Table __p;
	}
}
