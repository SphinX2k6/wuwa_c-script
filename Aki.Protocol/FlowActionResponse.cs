using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E1 RID: 1505
	[NetMessage(EMessageId.FlowActionResponse)]
	public sealed class FlowActionResponse : IMessage<FlowActionResponse>, IMessage, IEquatable<FlowActionResponse>, IDeepCloneable<FlowActionResponse>, IBufferMessage
	{
		// Token: 0x06008BE0 RID: 35808 RVA: 0x00153F58 File Offset: 0x00152158
		[NullableContext(1)]
		public static FlowActionResponse Create()
		{
			return new FlowActionResponse();
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06008BE1 RID: 35809 RVA: 0x00153F5F File Offset: 0x0015215F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06008BE2 RID: 35810 RVA: 0x00153F62 File Offset: 0x00152162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowActionResponse.Descriptor;
			}
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x00153F69 File Offset: 0x00152169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionResponse()
		{
		}

		// Token: 0x06008BE4 RID: 35812 RVA: 0x00153F71 File Offset: 0x00152171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionResponse(FlowActionResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BE5 RID: 35813 RVA: 0x00153F96 File Offset: 0x00152196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionResponse Clone()
		{
			return new FlowActionResponse(this);
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06008BE6 RID: 35814 RVA: 0x00153F9E File Offset: 0x0015219E
		// (set) Token: 0x06008BE7 RID: 35815 RVA: 0x00153FA6 File Offset: 0x001521A6
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

		// Token: 0x06008BE8 RID: 35816 RVA: 0x00153FAF File Offset: 0x001521AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowActionResponse);
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x00153FBD File Offset: 0x001521BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowActionResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x00153FEC File Offset: 0x001521EC
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

		// Token: 0x06008BEB RID: 35819 RVA: 0x00154031 File Offset: 0x00152231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x0015403E File Offset: 0x0015223E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x00154047 File Offset: 0x00152247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x0015407C File Offset: 0x0015227C
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

		// Token: 0x06008BEF RID: 35823 RVA: 0x001540BA File Offset: 0x001522BA
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

		// Token: 0x06008BF0 RID: 35824 RVA: 0x001540EB File Offset: 0x001522EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x001540F4 File Offset: 0x001522F4
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040044F9 RID: 17657
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044FA RID: 17658
		public const int CodeFieldNumber = 4;

		// Token: 0x040044FB RID: 17659
		private ErrorCode code_;
	}
}
