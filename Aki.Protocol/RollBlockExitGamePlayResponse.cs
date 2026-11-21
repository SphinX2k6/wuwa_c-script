using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001112 RID: 4370
	[NetMessage(EMessageId.RollBlockExitGamePlayResponse)]
	public sealed class RollBlockExitGamePlayResponse : IMessage<RollBlockExitGamePlayResponse>, IMessage, IEquatable<RollBlockExitGamePlayResponse>, IDeepCloneable<RollBlockExitGamePlayResponse>, IBufferMessage
	{
		// Token: 0x060175AB RID: 95659 RVA: 0x00365C21 File Offset: 0x00363E21
		[NullableContext(1)]
		public static RollBlockExitGamePlayResponse Create()
		{
			return new RollBlockExitGamePlayResponse();
		}

		// Token: 0x17004E76 RID: 20086
		// (get) Token: 0x060175AC RID: 95660 RVA: 0x00365C28 File Offset: 0x00363E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E77 RID: 20087
		// (get) Token: 0x060175AD RID: 95661 RVA: 0x00365C2B File Offset: 0x00363E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockExitGamePlayResponse.Descriptor;
			}
		}

		// Token: 0x060175AE RID: 95662 RVA: 0x00365C32 File Offset: 0x00363E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayResponse()
		{
		}

		// Token: 0x060175AF RID: 95663 RVA: 0x00365C3A File Offset: 0x00363E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayResponse(RollBlockExitGamePlayResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060175B0 RID: 95664 RVA: 0x00365C5F File Offset: 0x00363E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockExitGamePlayResponse Clone()
		{
			return new RollBlockExitGamePlayResponse(this);
		}

		// Token: 0x17004E78 RID: 20088
		// (get) Token: 0x060175B1 RID: 95665 RVA: 0x00365C67 File Offset: 0x00363E67
		// (set) Token: 0x060175B2 RID: 95666 RVA: 0x00365C6F File Offset: 0x00363E6F
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

		// Token: 0x060175B3 RID: 95667 RVA: 0x00365C78 File Offset: 0x00363E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockExitGamePlayResponse);
		}

		// Token: 0x060175B4 RID: 95668 RVA: 0x00365C86 File Offset: 0x00363E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockExitGamePlayResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175B5 RID: 95669 RVA: 0x00365CB4 File Offset: 0x00363EB4
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

		// Token: 0x060175B6 RID: 95670 RVA: 0x00365CF9 File Offset: 0x00363EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175B7 RID: 95671 RVA: 0x00365D06 File Offset: 0x00363F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175B8 RID: 95672 RVA: 0x00365D0F File Offset: 0x00363F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060175B9 RID: 95673 RVA: 0x00365D44 File Offset: 0x00363F44
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

		// Token: 0x060175BA RID: 95674 RVA: 0x00365D82 File Offset: 0x00363F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockExitGamePlayResponse other)
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

		// Token: 0x060175BB RID: 95675 RVA: 0x00365DB3 File Offset: 0x00363FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060175BC RID: 95676 RVA: 0x00365DBC File Offset: 0x00363FBC
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008B81 RID: 35713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B82 RID: 35714
		public const int CodeFieldNumber = 15;

		// Token: 0x04008B83 RID: 35715
		private ErrorCode code_;
	}
}
