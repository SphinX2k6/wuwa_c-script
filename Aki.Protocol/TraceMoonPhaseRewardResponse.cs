using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001447 RID: 5191
	[NetMessage(EMessageId.TraceMoonPhaseRewardResponse)]
	public sealed class TraceMoonPhaseRewardResponse : IMessage<TraceMoonPhaseRewardResponse>, IMessage, IEquatable<TraceMoonPhaseRewardResponse>, IDeepCloneable<TraceMoonPhaseRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B93C RID: 112956 RVA: 0x00401F15 File Offset: 0x00400115
		[NullableContext(1)]
		public static TraceMoonPhaseRewardResponse Create()
		{
			return new TraceMoonPhaseRewardResponse();
		}

		// Token: 0x17005D5A RID: 23898
		// (get) Token: 0x0601B93D RID: 112957 RVA: 0x00401F1C File Offset: 0x0040011C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D5B RID: 23899
		// (get) Token: 0x0601B93E RID: 112958 RVA: 0x00401F1F File Offset: 0x0040011F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceMoonPhaseRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B93F RID: 112959 RVA: 0x00401F26 File Offset: 0x00400126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardResponse()
		{
		}

		// Token: 0x0601B940 RID: 112960 RVA: 0x00401F2E File Offset: 0x0040012E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardResponse(TraceMoonPhaseRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B941 RID: 112961 RVA: 0x00401F53 File Offset: 0x00400153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardResponse Clone()
		{
			return new TraceMoonPhaseRewardResponse(this);
		}

		// Token: 0x17005D5C RID: 23900
		// (get) Token: 0x0601B942 RID: 112962 RVA: 0x00401F5B File Offset: 0x0040015B
		// (set) Token: 0x0601B943 RID: 112963 RVA: 0x00401F63 File Offset: 0x00400163
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

		// Token: 0x0601B944 RID: 112964 RVA: 0x00401F6C File Offset: 0x0040016C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceMoonPhaseRewardResponse);
		}

		// Token: 0x0601B945 RID: 112965 RVA: 0x00401F7A File Offset: 0x0040017A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceMoonPhaseRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B946 RID: 112966 RVA: 0x00401FA8 File Offset: 0x004001A8
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

		// Token: 0x0601B947 RID: 112967 RVA: 0x00401FED File Offset: 0x004001ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B948 RID: 112968 RVA: 0x00401FFA File Offset: 0x004001FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B949 RID: 112969 RVA: 0x00402003 File Offset: 0x00400203
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

		// Token: 0x0601B94A RID: 112970 RVA: 0x00402038 File Offset: 0x00400238
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

		// Token: 0x0601B94B RID: 112971 RVA: 0x00402076 File Offset: 0x00400276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceMoonPhaseRewardResponse other)
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

		// Token: 0x0601B94C RID: 112972 RVA: 0x004020A7 File Offset: 0x004002A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B94D RID: 112973 RVA: 0x004020B0 File Offset: 0x004002B0
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

		// Token: 0x0400A05A RID: 41050
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A05B RID: 41051
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A05C RID: 41052
		private ErrorCode errorCode_;
	}
}
