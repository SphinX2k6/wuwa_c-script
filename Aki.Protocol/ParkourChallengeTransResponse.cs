using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC0 RID: 3008
	[NetMessage(EMessageId.ParkourChallengeTransResponse)]
	public sealed class ParkourChallengeTransResponse : IMessage<ParkourChallengeTransResponse>, IMessage, IEquatable<ParkourChallengeTransResponse>, IDeepCloneable<ParkourChallengeTransResponse>, IBufferMessage
	{
		// Token: 0x060104CF RID: 66767 RVA: 0x00260E39 File Offset: 0x0025F039
		[NullableContext(1)]
		public static ParkourChallengeTransResponse Create()
		{
			return new ParkourChallengeTransResponse();
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x060104D0 RID: 66768 RVA: 0x00260E40 File Offset: 0x0025F040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x060104D1 RID: 66769 RVA: 0x00260E43 File Offset: 0x0025F043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTransResponse.Descriptor;
			}
		}

		// Token: 0x060104D2 RID: 66770 RVA: 0x00260E4A File Offset: 0x0025F04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransResponse()
		{
		}

		// Token: 0x060104D3 RID: 66771 RVA: 0x00260E52 File Offset: 0x0025F052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransResponse(ParkourChallengeTransResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104D4 RID: 66772 RVA: 0x00260E77 File Offset: 0x0025F077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransResponse Clone()
		{
			return new ParkourChallengeTransResponse(this);
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x060104D5 RID: 66773 RVA: 0x00260E7F File Offset: 0x0025F07F
		// (set) Token: 0x060104D6 RID: 66774 RVA: 0x00260E87 File Offset: 0x0025F087
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

		// Token: 0x060104D7 RID: 66775 RVA: 0x00260E90 File Offset: 0x0025F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTransResponse);
		}

		// Token: 0x060104D8 RID: 66776 RVA: 0x00260E9E File Offset: 0x0025F09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTransResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104D9 RID: 66777 RVA: 0x00260ECC File Offset: 0x0025F0CC
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

		// Token: 0x060104DA RID: 66778 RVA: 0x00260F11 File Offset: 0x0025F111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104DB RID: 66779 RVA: 0x00260F1E File Offset: 0x0025F11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104DC RID: 66780 RVA: 0x00260F27 File Offset: 0x0025F127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104DD RID: 66781 RVA: 0x00260F5C File Offset: 0x0025F15C
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

		// Token: 0x060104DE RID: 66782 RVA: 0x00260F9A File Offset: 0x0025F19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeTransResponse other)
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

		// Token: 0x060104DF RID: 66783 RVA: 0x00260FCB File Offset: 0x0025F1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104E0 RID: 66784 RVA: 0x00260FD4 File Offset: 0x0025F1D4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040067A3 RID: 26531
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067A4 RID: 26532
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040067A5 RID: 26533
		private ErrorCode errorCode_;
	}
}
