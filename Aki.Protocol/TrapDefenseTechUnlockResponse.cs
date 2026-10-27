using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001459 RID: 5209
	[NetMessage(EMessageId.TrapDefenseTechUnlockResponse)]
	public sealed class TrapDefenseTechUnlockResponse : IMessage<TrapDefenseTechUnlockResponse>, IMessage, IEquatable<TrapDefenseTechUnlockResponse>, IDeepCloneable<TrapDefenseTechUnlockResponse>, IBufferMessage
	{
		// Token: 0x0601B956 RID: 112982 RVA: 0x003FE379 File Offset: 0x003FC579
		[NullableContext(1)]
		public static TrapDefenseTechUnlockResponse Create()
		{
			return new TrapDefenseTechUnlockResponse();
		}

		// Token: 0x17005D03 RID: 23811
		// (get) Token: 0x0601B957 RID: 112983 RVA: 0x003FE380 File Offset: 0x003FC580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D04 RID: 23812
		// (get) Token: 0x0601B958 RID: 112984 RVA: 0x003FE383 File Offset: 0x003FC583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0601B959 RID: 112985 RVA: 0x003FE38A File Offset: 0x003FC58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockResponse()
		{
		}

		// Token: 0x0601B95A RID: 112986 RVA: 0x003FE392 File Offset: 0x003FC592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockResponse(TrapDefenseTechUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B95B RID: 112987 RVA: 0x003FE3B7 File Offset: 0x003FC5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockResponse Clone()
		{
			return new TrapDefenseTechUnlockResponse(this);
		}

		// Token: 0x17005D05 RID: 23813
		// (get) Token: 0x0601B95C RID: 112988 RVA: 0x003FE3BF File Offset: 0x003FC5BF
		// (set) Token: 0x0601B95D RID: 112989 RVA: 0x003FE3C7 File Offset: 0x003FC5C7
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

		// Token: 0x0601B95E RID: 112990 RVA: 0x003FE3D0 File Offset: 0x003FC5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechUnlockResponse);
		}

		// Token: 0x0601B95F RID: 112991 RVA: 0x003FE3DE File Offset: 0x003FC5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B960 RID: 112992 RVA: 0x003FE40C File Offset: 0x003FC60C
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

		// Token: 0x0601B961 RID: 112993 RVA: 0x003FE451 File Offset: 0x003FC651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B962 RID: 112994 RVA: 0x003FE45E File Offset: 0x003FC65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B963 RID: 112995 RVA: 0x003FE467 File Offset: 0x003FC667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B964 RID: 112996 RVA: 0x003FE49C File Offset: 0x003FC69C
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

		// Token: 0x0601B965 RID: 112997 RVA: 0x003FE4DA File Offset: 0x003FC6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechUnlockResponse other)
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

		// Token: 0x0601B966 RID: 112998 RVA: 0x003FE50B File Offset: 0x003FC70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B967 RID: 112999 RVA: 0x003FE514 File Offset: 0x003FC714
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009F02 RID: 40706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F03 RID: 40707
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04009F04 RID: 40708
		private ErrorCode errorCode_;
	}
}
