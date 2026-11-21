using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111B RID: 4379
	[NetMessage(EMessageId.RollBlockMovementFinishResponse)]
	public sealed class RollBlockMovementFinishResponse : IMessage<RollBlockMovementFinishResponse>, IMessage, IEquatable<RollBlockMovementFinishResponse>, IDeepCloneable<RollBlockMovementFinishResponse>, IBufferMessage
	{
		// Token: 0x06017670 RID: 95856 RVA: 0x00367B20 File Offset: 0x00365D20
		[NullableContext(1)]
		public static RollBlockMovementFinishResponse Create()
		{
			return new RollBlockMovementFinishResponse();
		}

		// Token: 0x17004EA4 RID: 20132
		// (get) Token: 0x06017671 RID: 95857 RVA: 0x00367B27 File Offset: 0x00365D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EA5 RID: 20133
		// (get) Token: 0x06017672 RID: 95858 RVA: 0x00367B2A File Offset: 0x00365D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockMovementFinishResponse.Descriptor;
			}
		}

		// Token: 0x06017673 RID: 95859 RVA: 0x00367B31 File Offset: 0x00365D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishResponse()
		{
		}

		// Token: 0x06017674 RID: 95860 RVA: 0x00367B39 File Offset: 0x00365D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishResponse(RollBlockMovementFinishResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017675 RID: 95861 RVA: 0x00367B5E File Offset: 0x00365D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockMovementFinishResponse Clone()
		{
			return new RollBlockMovementFinishResponse(this);
		}

		// Token: 0x17004EA6 RID: 20134
		// (get) Token: 0x06017676 RID: 95862 RVA: 0x00367B66 File Offset: 0x00365D66
		// (set) Token: 0x06017677 RID: 95863 RVA: 0x00367B6E File Offset: 0x00365D6E
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

		// Token: 0x06017678 RID: 95864 RVA: 0x00367B77 File Offset: 0x00365D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockMovementFinishResponse);
		}

		// Token: 0x06017679 RID: 95865 RVA: 0x00367B85 File Offset: 0x00365D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockMovementFinishResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601767A RID: 95866 RVA: 0x00367BB4 File Offset: 0x00365DB4
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

		// Token: 0x0601767B RID: 95867 RVA: 0x00367BF9 File Offset: 0x00365DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601767C RID: 95868 RVA: 0x00367C06 File Offset: 0x00365E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601767D RID: 95869 RVA: 0x00367C0F File Offset: 0x00365E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601767E RID: 95870 RVA: 0x00367C44 File Offset: 0x00365E44
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

		// Token: 0x0601767F RID: 95871 RVA: 0x00367C82 File Offset: 0x00365E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockMovementFinishResponse other)
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

		// Token: 0x06017680 RID: 95872 RVA: 0x00367CB3 File Offset: 0x00365EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017681 RID: 95873 RVA: 0x00367CBC File Offset: 0x00365EBC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008BC4 RID: 35780
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BC5 RID: 35781
		public const int CodeFieldNumber = 8;

		// Token: 0x04008BC6 RID: 35782
		private ErrorCode code_;
	}
}
