using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D6 RID: 25558
	public struct IClientModifyTarget : IFlatbufferObject
	{
		// Token: 0x1700BE65 RID: 48741
		// (get) Token: 0x0602C355 RID: 181077 RVA: 0x006119A5 File Offset: 0x0060FBA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C356 RID: 181078 RVA: 0x006119B2 File Offset: 0x0060FBB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C357 RID: 181079 RVA: 0x006119BC File Offset: 0x0060FBBC
		public static IClientModifyTarget GetRootAsIClientModifyTarget(ByteBuffer _bb)
		{
			return IClientModifyTarget.GetRootAsIClientModifyTarget(_bb, default(IClientModifyTarget));
		}

		// Token: 0x0602C358 RID: 181080 RVA: 0x006119D8 File Offset: 0x0060FBD8
		public static IClientModifyTarget GetRootAsIClientModifyTarget(ByteBuffer _bb, IClientModifyTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C359 RID: 181081 RVA: 0x006119F5 File Offset: 0x0060FBF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C35A RID: 181082 RVA: 0x00611A04 File Offset: 0x0060FC04
		public IClientModifyTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE66 RID: 48742
		// (get) Token: 0x0602C35B RID: 181083 RVA: 0x00611A14 File Offset: 0x0060FC14
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

		// Token: 0x0602C35C RID: 181084 RVA: 0x00611A50 File Offset: 0x0060FC50
		public static Offset<IClientModifyTarget> CreateIClientModifyTarget(FlatBufferBuilder builder, EClientModifyTargetType Type = EClientModifyTargetType.Self)
		{
			builder.StartTable(1);
			IClientModifyTarget.AddType(builder, Type);
			return IClientModifyTarget.EndIClientModifyTarget(builder);
		}

		// Token: 0x0602C35D RID: 181085 RVA: 0x00611A66 File Offset: 0x0060FC66
		public static void StartIClientModifyTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C35E RID: 181086 RVA: 0x00611A6F File Offset: 0x0060FC6F
		public static void AddType(FlatBufferBuilder builder, EClientModifyTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C35F RID: 181087 RVA: 0x00611A7A File Offset: 0x0060FC7A
		public static Offset<IClientModifyTarget> EndIClientModifyTarget(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifyTarget>(builder.EndTable());
		}

		// Token: 0x0602C360 RID: 181088 RVA: 0x00611A88 File Offset: 0x0060FC88
		public IClientModifyTargetT UnPack()
		{
			IClientModifyTargetT clientModifyTargetT = new IClientModifyTargetT();
			this.UnPackTo(clientModifyTargetT);
			return clientModifyTargetT;
		}

		// Token: 0x0602C361 RID: 181089 RVA: 0x00611AA3 File Offset: 0x0060FCA3
		public void UnPackTo(IClientModifyTargetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C362 RID: 181090 RVA: 0x00611AB4 File Offset: 0x0060FCB4
		public static Offset<IClientModifyTarget> Pack(FlatBufferBuilder builder, IClientModifyTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifyTarget>);
			}
			return IClientModifyTarget.CreateIClientModifyTarget(builder, _o.Type);
		}

		// Token: 0x040109B1 RID: 68017
		private Table __p;
	}
}
