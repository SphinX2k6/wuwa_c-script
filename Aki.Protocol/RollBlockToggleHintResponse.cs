using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EA RID: 4330
	[NetMessage(EMessageId.RollBlockToggleHintResponse)]
	public sealed class RollBlockToggleHintResponse : IMessage<RollBlockToggleHintResponse>, IMessage, IEquatable<RollBlockToggleHintResponse>, IDeepCloneable<RollBlockToggleHintResponse>, IBufferMessage
	{
		// Token: 0x06017177 RID: 94583 RVA: 0x00359B40 File Offset: 0x00357D40
		[NullableContext(1)]
		public static RollBlockToggleHintResponse Create()
		{
			return new RollBlockToggleHintResponse();
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x06017178 RID: 94584 RVA: 0x00359B47 File Offset: 0x00357D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D57 RID: 19799
		// (get) Token: 0x06017179 RID: 94585 RVA: 0x00359B4A File Offset: 0x00357D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockToggleHintResponse.Descriptor;
			}
		}

		// Token: 0x0601717A RID: 94586 RVA: 0x00359B51 File Offset: 0x00357D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintResponse()
		{
		}

		// Token: 0x0601717B RID: 94587 RVA: 0x00359B59 File Offset: 0x00357D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintResponse(RollBlockToggleHintResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601717C RID: 94588 RVA: 0x00359B7E File Offset: 0x00357D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintResponse Clone()
		{
			return new RollBlockToggleHintResponse(this);
		}

		// Token: 0x17004D58 RID: 19800
		// (get) Token: 0x0601717D RID: 94589 RVA: 0x00359B86 File Offset: 0x00357D86
		// (set) Token: 0x0601717E RID: 94590 RVA: 0x00359B8E File Offset: 0x00357D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601717F RID: 94591 RVA: 0x00359B97 File Offset: 0x00357D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockToggleHintResponse);
		}

		// Token: 0x06017180 RID: 94592 RVA: 0x00359BA5 File Offset: 0x00357DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockToggleHintResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017181 RID: 94593 RVA: 0x00359BD4 File Offset: 0x00357DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017182 RID: 94594 RVA: 0x00359C19 File Offset: 0x00357E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017183 RID: 94595 RVA: 0x00359C26 File Offset: 0x00357E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017184 RID: 94596 RVA: 0x00359C2F File Offset: 0x00357E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017185 RID: 94597 RVA: 0x00359C64 File Offset: 0x00357E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017186 RID: 94598 RVA: 0x00359CA2 File Offset: 0x00357EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockToggleHintResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017187 RID: 94599 RVA: 0x00359CD3 File Offset: 0x00357ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017188 RID: 94600 RVA: 0x00359CDC File Offset: 0x00357EDC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008953 RID: 35155
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008954 RID: 35156
		public const int CodeFieldNumber = 12;

		// Token: 0x04008955 RID: 35157
		private ErrorCode code_;
	}
}
