using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004B RID: 75
	[NetMessage(EMessageId.AbyssShowNameResponse)]
	public sealed class AbyssShowNameResponse : IMessage<AbyssShowNameResponse>, IMessage, IEquatable<AbyssShowNameResponse>, IDeepCloneable<AbyssShowNameResponse>, IBufferMessage
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x00037000 File Offset: 0x00035200
		[NullableContext(1)]
		public static AbyssShowNameResponse Create()
		{
			return new AbyssShowNameResponse();
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00037007 File Offset: 0x00035207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0003700A File Offset: 0x0003520A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssShowNameResponse.Descriptor;
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00037011 File Offset: 0x00035211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameResponse()
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00037019 File Offset: 0x00035219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameResponse(AbyssShowNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0003703E File Offset: 0x0003523E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameResponse Clone()
		{
			return new AbyssShowNameResponse(this);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00037046 File Offset: 0x00035246
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0003704E File Offset: 0x0003524E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00037057 File Offset: 0x00035257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssShowNameResponse);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00037065 File Offset: 0x00035265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssShowNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00037094 File Offset: 0x00035294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x000370D9 File Offset: 0x000352D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000370E6 File Offset: 0x000352E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x000370EF File Offset: 0x000352EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00037124 File Offset: 0x00035324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00037162 File Offset: 0x00035362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssShowNameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00037193 File Offset: 0x00035393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0003719C File Offset: 0x0003539C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040020A9 RID: 8361
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020AA RID: 8362
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040020AB RID: 8363
		private ErrorCode errorCode_;
	}
}
