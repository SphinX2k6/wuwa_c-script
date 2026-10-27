using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000577 RID: 1399
	[NetMessage(EMessageId.FishingSailingResponse)]
	public sealed class FishingSailingResponse : IMessage<FishingSailingResponse>, IMessage, IEquatable<FishingSailingResponse>, IDeepCloneable<FishingSailingResponse>, IBufferMessage
	{
		// Token: 0x0600821E RID: 33310 RVA: 0x0013A140 File Offset: 0x00138340
		[NullableContext(1)]
		public static FishingSailingResponse Create()
		{
			return new FishingSailingResponse();
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x0600821F RID: 33311 RVA: 0x0013A147 File Offset: 0x00138347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06008220 RID: 33312 RVA: 0x0013A14A File Offset: 0x0013834A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSailingResponse.Descriptor;
			}
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x0013A151 File Offset: 0x00138351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingResponse()
		{
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x0013A159 File Offset: 0x00138359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingResponse(FishingSailingResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x0013A17E File Offset: 0x0013837E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingResponse Clone()
		{
			return new FishingSailingResponse(this);
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06008224 RID: 33316 RVA: 0x0013A186 File Offset: 0x00138386
		// (set) Token: 0x06008225 RID: 33317 RVA: 0x0013A18E File Offset: 0x0013838E
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

		// Token: 0x06008226 RID: 33318 RVA: 0x0013A197 File Offset: 0x00138397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSailingResponse);
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x0013A1A5 File Offset: 0x001383A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSailingResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x0013A1D4 File Offset: 0x001383D4
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

		// Token: 0x06008229 RID: 33321 RVA: 0x0013A219 File Offset: 0x00138419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600822A RID: 33322 RVA: 0x0013A226 File Offset: 0x00138426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x0013A22F File Offset: 0x0013842F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x0013A264 File Offset: 0x00138464
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

		// Token: 0x0600822D RID: 33325 RVA: 0x0013A2A2 File Offset: 0x001384A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSailingResponse other)
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

		// Token: 0x0600822E RID: 33326 RVA: 0x0013A2D3 File Offset: 0x001384D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600822F RID: 33327 RVA: 0x0013A2DC File Offset: 0x001384DC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400412D RID: 16685
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400412E RID: 16686
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400412F RID: 16687
		private ErrorCode errorCode_;
	}
}
