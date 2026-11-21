using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000562 RID: 1378
	[NetMessage(EMessageId.FishingSailingResponse)]
	public sealed class FishingSailingResponse : IMessage<FishingSailingResponse>, IMessage, IEquatable<FishingSailingResponse>, IDeepCloneable<FishingSailingResponse>, IBufferMessage
	{
		// Token: 0x060080B6 RID: 32950 RVA: 0x0013753B File Offset: 0x0013573B
		[NullableContext(1)]
		public static FishingSailingResponse Create()
		{
			return new FishingSailingResponse();
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060080B7 RID: 32951 RVA: 0x00137542 File Offset: 0x00135742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060080B8 RID: 32952 RVA: 0x00137545 File Offset: 0x00135745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSailingResponse.Descriptor;
			}
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x0013754C File Offset: 0x0013574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingResponse()
		{
		}

		// Token: 0x060080BA RID: 32954 RVA: 0x00137554 File Offset: 0x00135754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingResponse(FishingSailingResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080BB RID: 32955 RVA: 0x00137579 File Offset: 0x00135779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSailingResponse Clone()
		{
			return new FishingSailingResponse(this);
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060080BC RID: 32956 RVA: 0x00137581 File Offset: 0x00135781
		// (set) Token: 0x060080BD RID: 32957 RVA: 0x00137589 File Offset: 0x00135789
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

		// Token: 0x060080BE RID: 32958 RVA: 0x00137592 File Offset: 0x00135792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSailingResponse);
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x001375A0 File Offset: 0x001357A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSailingResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x001375D0 File Offset: 0x001357D0
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

		// Token: 0x060080C1 RID: 32961 RVA: 0x00137615 File Offset: 0x00135815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x00137622 File Offset: 0x00135822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080C3 RID: 32963 RVA: 0x0013762B File Offset: 0x0013582B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x00137660 File Offset: 0x00135860
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

		// Token: 0x060080C5 RID: 32965 RVA: 0x0013769E File Offset: 0x0013589E
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

		// Token: 0x060080C6 RID: 32966 RVA: 0x001376CF File Offset: 0x001358CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x001376D8 File Offset: 0x001358D8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004123 RID: 16675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004124 RID: 16676
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004125 RID: 16677
		private ErrorCode errorCode_;
	}
}
