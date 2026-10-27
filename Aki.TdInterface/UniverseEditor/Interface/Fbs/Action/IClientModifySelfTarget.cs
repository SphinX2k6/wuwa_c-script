using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D3 RID: 25555
	public struct IClientModifySelfTarget : IFlatbufferObject
	{
		// Token: 0x1700BE62 RID: 48738
		// (get) Token: 0x0602C343 RID: 181059 RVA: 0x0061182D File Offset: 0x0060FA2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C344 RID: 181060 RVA: 0x0061183A File Offset: 0x0060FA3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C345 RID: 181061 RVA: 0x00611844 File Offset: 0x0060FA44
		public static IClientModifySelfTarget GetRootAsIClientModifySelfTarget(ByteBuffer _bb)
		{
			return IClientModifySelfTarget.GetRootAsIClientModifySelfTarget(_bb, default(IClientModifySelfTarget));
		}

		// Token: 0x0602C346 RID: 181062 RVA: 0x00611860 File Offset: 0x0060FA60
		public static IClientModifySelfTarget GetRootAsIClientModifySelfTarget(ByteBuffer _bb, IClientModifySelfTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C347 RID: 181063 RVA: 0x0061187D File Offset: 0x0060FA7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C348 RID: 181064 RVA: 0x0061188C File Offset: 0x0060FA8C
		public IClientModifySelfTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE63 RID: 48739
		// (get) Token: 0x0602C349 RID: 181065 RVA: 0x0061189C File Offset: 0x0060FA9C
		public EClientModifyTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientModifyTargetType.Self;
				}
				return (EClientModifyTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C34A RID: 181066 RVA: 0x006118D8 File Offset: 0x0060FAD8
		public static Offset<IClientModifySelfTarget> CreateIClientModifySelfTarget(FlatBufferBuilder builder, EClientModifyTargetType Type = EClientModifyTargetType.Self)
		{
			builder.StartTable(1);
			IClientModifySelfTarget.AddType(builder, Type);
			return IClientModifySelfTarget.EndIClientModifySelfTarget(builder);
		}

		// Token: 0x0602C34B RID: 181067 RVA: 0x006118EE File Offset: 0x0060FAEE
		public static void StartIClientModifySelfTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C34C RID: 181068 RVA: 0x006118F7 File Offset: 0x0060FAF7
		public static void AddType(FlatBufferBuilder builder, EClientModifyTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C34D RID: 181069 RVA: 0x00611902 File Offset: 0x0060FB02
		public static Offset<IClientModifySelfTarget> EndIClientModifySelfTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifySelfTarget>(builder.EndTable());
		}

		// Token: 0x0602C34E RID: 181070 RVA: 0x00611910 File Offset: 0x0060FB10
		public IClientModifySelfTargetT UnPack()
		{
			IClientModifySelfTargetT clientModifySelfTargetT = new IClientModifySelfTargetT();
			this.UnPackTo(clientModifySelfTargetT);
			return clientModifySelfTargetT;
		}

		// Token: 0x0602C34F RID: 181071 RVA: 0x0061192B File Offset: 0x0060FB2B
		public void UnPackTo(IClientModifySelfTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C350 RID: 181072 RVA: 0x0061193C File Offset: 0x0060FB3C
		public static Offset<IClientModifySelfTarget> Pack(FlatBufferBuilder builder, IClientModifySelfTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifySelfTarget>);
			}
			return IClientModifySelfTarget.CreateIClientModifySelfTarget(builder, _o.Type);
		}

		// Token: 0x040109AF RID: 68015
		private Table __p;
	}
}
