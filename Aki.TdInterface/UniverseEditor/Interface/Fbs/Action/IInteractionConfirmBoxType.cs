using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698A RID: 27018
	public struct IInteractionConfirmBoxType : IFlatbufferObject
	{
		// Token: 0x1700C85D RID: 51293
		// (get) Token: 0x0602F2F6 RID: 193270 RVA: 0x0066D618 File Offset: 0x0066B818
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F2F7 RID: 193271 RVA: 0x0066D625 File Offset: 0x0066B825
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F2F8 RID: 193272 RVA: 0x0066D62C File Offset: 0x0066B82C
		public static IInteractionConfirmBoxType GetRootAsIInteractionConfirmBoxType(ByteBuffer _bb)
		{
			return IInteractionConfirmBoxType.GetRootAsIInteractionConfirmBoxType(_bb, default(IInteractionConfirmBoxType));
		}

		// Token: 0x0602F2F9 RID: 193273 RVA: 0x0066D648 File Offset: 0x0066B848
		public static IInteractionConfirmBoxType GetRootAsIInteractionConfirmBoxType(ByteBuffer _bb, IInteractionConfirmBoxType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F2FA RID: 193274 RVA: 0x0066D665 File Offset: 0x0066B865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F2FB RID: 193275 RVA: 0x0066D674 File Offset: 0x0066B874
		public IInteractionConfirmBoxType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C85E RID: 51294
		// (get) Token: 0x0602F2FC RID: 193276 RVA: 0x0066D684 File Offset: 0x0066B884
		public EInteractionConfirmBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return (EInteractionConfirmBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F2FD RID: 193277 RVA: 0x0066D6C0 File Offset: 0x0066B8C0
		public static Offset<IInteractionConfirmBoxType> CreateIInteractionConfirmBoxType(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common)
		{
			builder.StartTable(1);
			IInteractionConfirmBoxType.AddType(builder, Type);
			return IInteractionConfirmBoxType.EndIInteractionConfirmBoxType(builder);
		}

		// Token: 0x0602F2FE RID: 193278 RVA: 0x0066D6D6 File Offset: 0x0066B8D6
		public static void StartIInteractionConfirmBoxType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F2FF RID: 193279 RVA: 0x0066D6DF File Offset: 0x0066B8DF
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F300 RID: 193280 RVA: 0x0066D6EA File Offset: 0x0066B8EA
		public static Offset<IInteractionConfirmBoxType> EndIInteractionConfirmBoxType(FlatBufferBuilder builder)
		{
			return new Offset<IInteractionConfirmBoxType>(builder.EndTable());
		}

		// Token: 0x0602F301 RID: 193281 RVA: 0x0066D6F8 File Offset: 0x0066B8F8
		public IInteractionConfirmBoxTypeT UnPack()
		{
			IInteractionConfirmBoxTypeT interactionConfirmBoxTypeT = new IInteractionConfirmBoxTypeT();
			this.UnPackTo(interactionConfirmBoxTypeT);
			return interactionConfirmBoxTypeT;
		}

		// Token: 0x0602F302 RID: 193282 RVA: 0x0066D713 File Offset: 0x0066B913
		public void UnPackTo(IInteractionConfirmBoxTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F303 RID: 193283 RVA: 0x0066D724 File Offset: 0x0066B924
		public static Offset<IInteractionConfirmBoxType> Pack(FlatBufferBuilder builder, IInteractionConfirmBoxTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractionConfirmBoxType>);
			}
			return IInteractionConfirmBoxType.CreateIInteractionConfirmBoxType(builder, _o.Type);
		}

		// Token: 0x04011118 RID: 69912
		private Table __p;
	}
}
