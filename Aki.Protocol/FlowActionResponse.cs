using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F6 RID: 1526
	[NetMessage(EMessageId.FlowActionResponse)]
	public sealed class FlowActionResponse : IMessage<FlowActionResponse>, IMessage, IEquatable<FlowActionResponse>, IDeepCloneable<FlowActionResponse>, IBufferMessage
	{
		// Token: 0x06008D48 RID: 36168 RVA: 0x00156B5B File Offset: 0x00154D5B
		[NullableContext(1)]
		public static FlowActionResponse Create()
		{
			return new FlowActionResponse();
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06008D49 RID: 36169 RVA: 0x00156B62 File Offset: 0x00154D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06008D4A RID: 36170 RVA: 0x00156B65 File Offset: 0x00154D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowActionResponse.Descriptor;
			}
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x00156B6C File Offset: 0x00154D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionResponse()
		{
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x00156B74 File Offset: 0x00154D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionResponse(FlowActionResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x00156B99 File Offset: 0x00154D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionResponse Clone()
		{
			return new FlowActionResponse(this);
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06008D4E RID: 36174 RVA: 0x00156BA1 File Offset: 0x00154DA1
		// (set) Token: 0x06008D4F RID: 36175 RVA: 0x00156BA9 File Offset: 0x00154DA9
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

		// Token: 0x06008D50 RID: 36176 RVA: 0x00156BB2 File Offset: 0x00154DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowActionResponse);
		}

		// Token: 0x06008D51 RID: 36177 RVA: 0x00156BC0 File Offset: 0x00154DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowActionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x00156BF0 File Offset: 0x00154DF0
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

		// Token: 0x06008D53 RID: 36179 RVA: 0x00156C35 File Offset: 0x00154E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x00156C42 File Offset: 0x00154E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D55 RID: 36181 RVA: 0x00156C4B File Offset: 0x00154E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x00156C80 File Offset: 0x00154E80
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

		// Token: 0x06008D57 RID: 36183 RVA: 0x00156CBE File Offset: 0x00154EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowActionResponse other)
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

		// Token: 0x06008D58 RID: 36184 RVA: 0x00156CEF File Offset: 0x00154EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x00156CF8 File Offset: 0x00154EF8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004503 RID: 17667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004504 RID: 17668
		public const int CodeFieldNumber = 5;

		// Token: 0x04004505 RID: 17669
		private ErrorCode code_;
	}
}
