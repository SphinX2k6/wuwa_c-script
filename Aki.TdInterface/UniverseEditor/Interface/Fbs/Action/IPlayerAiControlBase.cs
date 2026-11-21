using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007462 RID: 29794
	public struct IPlayerAiControlBase : IFlatbufferObject
	{
		// Token: 0x1700DAF0 RID: 56048
		// (get) Token: 0x0603428F RID: 213647 RVA: 0x0070715A File Offset: 0x0070535A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034290 RID: 213648 RVA: 0x00707167 File Offset: 0x00705367
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034291 RID: 213649 RVA: 0x00707170 File Offset: 0x00705370
		public static IPlayerAiControlBase GetRootAsIPlayerAiControlBase(ByteBuffer _bb)
		{
			return IPlayerAiControlBase.GetRootAsIPlayerAiControlBase(_bb, default(IPlayerAiControlBase));
		}

		// Token: 0x06034292 RID: 213650 RVA: 0x0070718C File Offset: 0x0070538C
		public static IPlayerAiControlBase GetRootAsIPlayerAiControlBase(ByteBuffer _bb, IPlayerAiControlBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034293 RID: 213651 RVA: 0x007071A9 File Offset: 0x007053A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034294 RID: 213652 RVA: 0x007071B8 File Offset: 0x007053B8
		public IPlayerAiControlBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAF1 RID: 56049
		// (get) Token: 0x06034295 RID: 213653 RVA: 0x007071C8 File Offset: 0x007053C8
		public EPlayerAiControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerAiControlType.Enable;
				}
				return (EPlayerAiControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034296 RID: 213654 RVA: 0x00707204 File Offset: 0x00705404
		public static Offset<IPlayerAiControlBase> CreateIPlayerAiControlBase(FlatBufferBuilder builder, EPlayerAiControlType Type = EPlayerAiControlType.Enable)
		{
			builder.StartTable(1);
			IPlayerAiControlBase.AddType(builder, Type);
			return IPlayerAiControlBase.EndIPlayerAiControlBase(builder);
		}

		// Token: 0x06034297 RID: 213655 RVA: 0x0070721A File Offset: 0x0070541A
		public static void StartIPlayerAiControlBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034298 RID: 213656 RVA: 0x00707223 File Offset: 0x00705423
		public static void AddType(FlatBufferBuilder builder, EPlayerAiControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034299 RID: 213657 RVA: 0x0070722E File Offset: 0x0070542E
		public static Offset<IPlayerAiControlBase> EndIPlayerAiControlBase(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerAiControlBase>(builder.EndTable());
		}

		// Token: 0x0603429A RID: 213658 RVA: 0x0070723C File Offset: 0x0070543C
		public IPlayerAiControlBaseT UnPack()
		{
			IPlayerAiControlBaseT playerAiControlBaseT = new IPlayerAiControlBaseT();
			this.UnPackTo(playerAiControlBaseT);
			return playerAiControlBaseT;
		}

		// Token: 0x0603429B RID: 213659 RVA: 0x00707257 File Offset: 0x00705457
		public void UnPackTo(IPlayerAiControlBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603429C RID: 213660 RVA: 0x00707268 File Offset: 0x00705468
		public static Offset<IPlayerAiControlBase> Pack(FlatBufferBuilder builder, IPlayerAiControlBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerAiControlBase>);
			}
			return IPlayerAiControlBase.CreateIPlayerAiControlBase(builder, _o.Type);
		}

		// Token: 0x040125DC RID: 75228
		private Table __p;
	}
}
