using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F5 RID: 1525
	[NetMessage(EMessageId.FlowActionRequest)]
	public sealed class FlowActionRequest : IMessage<FlowActionRequest>, IMessage, IEquatable<FlowActionRequest>, IDeepCloneable<FlowActionRequest>, IBufferMessage
	{
		// Token: 0x06008D34 RID: 36148 RVA: 0x001568C5 File Offset: 0x00154AC5
		[NullableContext(1)]
		public static FlowActionRequest Create()
		{
			return new FlowActionRequest();
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x001568CC File Offset: 0x00154ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06008D36 RID: 36150 RVA: 0x001568CF File Offset: 0x00154ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowActionRequest.Descriptor;
			}
		}

		// Token: 0x06008D37 RID: 36151 RVA: 0x001568D6 File Offset: 0x00154AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionRequest()
		{
		}

		// Token: 0x06008D38 RID: 36152 RVA: 0x001568DE File Offset: 0x00154ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionRequest(FlowActionRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.actionId_ = other.actionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x0015690F File Offset: 0x00154B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionRequest Clone()
		{
			return new FlowActionRequest(this);
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06008D3A RID: 36154 RVA: 0x00156917 File Offset: 0x00154B17
		// (set) Token: 0x06008D3B RID: 36155 RVA: 0x0015691F File Offset: 0x00154B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowIncId
		{
			get
			{
				return this.flowIncId_;
			}
			set
			{
				this.flowIncId_ = value;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06008D3C RID: 36156 RVA: 0x00156928 File Offset: 0x00154B28
		// (set) Token: 0x06008D3D RID: 36157 RVA: 0x00156930 File Offset: 0x00154B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
		{
			get
			{
				return this.actionId_;
			}
			set
			{
				this.actionId_ = value;
			}
		}

		// Token: 0x06008D3E RID: 36158 RVA: 0x00156939 File Offset: 0x00154B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowActionRequest);
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x00156947 File Offset: 0x00154B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowActionRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.ActionId == other.ActionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x00156988 File Offset: 0x00154B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this.ActionId != 0)
			{
				num ^= this.ActionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x001569E0 File Offset: 0x00154BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x001569ED File Offset: 0x00154BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x001569F8 File Offset: 0x00154BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.FlowIncId);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x00156A50 File Offset: 0x00154C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this.ActionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x00156AA8 File Offset: 0x00154CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			if (other.ActionId != 0)
			{
				this.ActionId = other.ActionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x00156AF8 File Offset: 0x00154CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x00156B04 File Offset: 0x00154D04
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
				if (num != 8U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActionId = input.ReadInt32();
					}
				}
				else
				{
					this.FlowIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040044FE RID: 17662
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044FF RID: 17663
		public const int FlowIncIdFieldNumber = 1;

		// Token: 0x04004500 RID: 17664
		private long flowIncId_;

		// Token: 0x04004501 RID: 17665
		public const int ActionIdFieldNumber = 7;

		// Token: 0x04004502 RID: 17666
		private int actionId_;
	}
}
