using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C2 RID: 24770
	public struct IActorFxEmoteType : IFlatbufferObject
	{
		// Token: 0x1700B688 RID: 46728
		// (get) Token: 0x0602A4A8 RID: 173224 RVA: 0x005D4400 File Offset: 0x005D2600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A4A9 RID: 173225 RVA: 0x005D440D File Offset: 0x005D260D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A4AA RID: 173226 RVA: 0x005D4414 File Offset: 0x005D2614
		public static IActorFxEmoteType GetRootAsIActorFxEmoteType(ByteBuffer _bb)
		{
			return IActorFxEmoteType.GetRootAsIActorFxEmoteType(_bb, default(IActorFxEmoteType));
		}

		// Token: 0x0602A4AB RID: 173227 RVA: 0x005D4430 File Offset: 0x005D2630
		public static IActorFxEmoteType GetRootAsIActorFxEmoteType(ByteBuffer _bb, IActorFxEmoteType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A4AC RID: 173228 RVA: 0x005D444D File Offset: 0x005D264D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A4AD RID: 173229 RVA: 0x005D445C File Offset: 0x005D265C
		public IActorFxEmoteType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B689 RID: 46729
		// (get) Token: 0x0602A4AE RID: 173230 RVA: 0x005D446C File Offset: 0x005D266C
		public EActorFxEmoteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFxEmoteType.Play;
				}
				return (EActorFxEmoteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A4AF RID: 173231 RVA: 0x005D44A8 File Offset: 0x005D26A8
		public static Offset<IActorFxEmoteType> CreateIActorFxEmoteType(FlatBufferBuilder builder, EActorFxEmoteType Type = EActorFxEmoteType.Play)
		{
			builder.StartTable(1);
			IActorFxEmoteType.AddType(builder, Type);
			return IActorFxEmoteType.EndIActorFxEmoteType(builder);
		}

		// Token: 0x0602A4B0 RID: 173232 RVA: 0x005D44BE File Offset: 0x005D26BE
		public static void StartIActorFxEmoteType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A4B1 RID: 173233 RVA: 0x005D44C7 File Offset: 0x005D26C7
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A4B2 RID: 173234 RVA: 0x005D44D2 File Offset: 0x005D26D2
		public static Offset<IActorFxEmoteType> EndIActorFxEmoteType(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteType>(builder.EndTable());
		}

		// Token: 0x0602A4B3 RID: 173235 RVA: 0x005D44E0 File Offset: 0x005D26E0
		public IActorFxEmoteTypeT UnPack()
		{
			IActorFxEmoteTypeT actorFxEmoteTypeT = new IActorFxEmoteTypeT();
			this.UnPackTo(actorFxEmoteTypeT);
			return actorFxEmoteTypeT;
		}

		// Token: 0x0602A4B4 RID: 173236 RVA: 0x005D44FB File Offset: 0x005D26FB
		public void UnPackTo(IActorFxEmoteTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A4B5 RID: 173237 RVA: 0x005D450C File Offset: 0x005D270C
		public static Offset<IActorFxEmoteType> Pack(FlatBufferBuilder builder, IActorFxEmoteTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteType>);
			}
			return IActorFxEmoteType.CreateIActorFxEmoteType(builder, _o.Type);
		}

		// Token: 0x04010469 RID: 66665
		private Table __p;
	}
}
