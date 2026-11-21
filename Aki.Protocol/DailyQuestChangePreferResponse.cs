using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032D RID: 813
	[NetMessage(EMessageId.DailyQuestChangePreferResponse)]
	public sealed class DailyQuestChangePreferResponse : IMessage<DailyQuestChangePreferResponse>, IMessage, IEquatable<DailyQuestChangePreferResponse>, IDeepCloneable<DailyQuestChangePreferResponse>, IBufferMessage
	{
		// Token: 0x060051D1 RID: 20945 RVA: 0x000C75F4 File Offset: 0x000C57F4
		[NullableContext(1)]
		public static DailyQuestChangePreferResponse Create()
		{
			return new DailyQuestChangePreferResponse();
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x000C75FB File Offset: 0x000C57FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x000C75FE File Offset: 0x000C57FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestChangePreferResponse.Descriptor;
			}
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x000C7605 File Offset: 0x000C5805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferResponse()
		{
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x000C760D File Offset: 0x000C580D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferResponse(DailyQuestChangePreferResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x000C7632 File Offset: 0x000C5832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestChangePreferResponse Clone()
		{
			return new DailyQuestChangePreferResponse(this);
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060051D7 RID: 20951 RVA: 0x000C763A File Offset: 0x000C583A
		// (set) Token: 0x060051D8 RID: 20952 RVA: 0x000C7642 File Offset: 0x000C5842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x000C764B File Offset: 0x000C584B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestChangePreferResponse);
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x000C7659 File Offset: 0x000C5859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestChangePreferResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x000C7688 File Offset: 0x000C5888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x000C76CD File Offset: 0x000C58CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x000C76DA File Offset: 0x000C58DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x000C76E3 File Offset: 0x000C58E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x000C7718 File Offset: 0x000C5918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x000C7756 File Offset: 0x000C5956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestChangePreferResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x000C7787 File Offset: 0x000C5987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x000C7790 File Offset: 0x000C5990
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400331C RID: 13084
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400331D RID: 13085
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x0400331E RID: 13086
		private ErrorCode errorId_;
	}
}
