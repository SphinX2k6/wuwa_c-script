using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EB RID: 1515
	[NetMessage(EMessageId.FlowRestartRequest)]
	public sealed class FlowRestartRequest : IMessage<FlowRestartRequest>, IMessage, IEquatable<FlowRestartRequest>, IDeepCloneable<FlowRestartRequest>, IBufferMessage
	{
		// Token: 0x06008CAD RID: 36013 RVA: 0x00155A17 File Offset: 0x00153C17
		[NullableContext(1)]
		public static FlowRestartRequest Create()
		{
			return new FlowRestartRequest();
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06008CAE RID: 36014 RVA: 0x00155A1E File Offset: 0x00153C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06008CAF RID: 36015 RVA: 0x00155A21 File Offset: 0x00153C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowRestartRequest.Descriptor;
			}
		}

		// Token: 0x06008CB0 RID: 36016 RVA: 0x00155A28 File Offset: 0x00153C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartRequest()
		{
		}

		// Token: 0x06008CB1 RID: 36017 RVA: 0x00155A30 File Offset: 0x00153C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartRequest(FlowRestartRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CB2 RID: 36018 RVA: 0x00155A55 File Offset: 0x00153C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartRequest Clone()
		{
			return new FlowRestartRequest(this);
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x00155A5D File Offset: 0x00153C5D
		// (set) Token: 0x06008CB4 RID: 36020 RVA: 0x00155A65 File Offset: 0x00153C65
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

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00155A6E File Offset: 0x00153C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowRestartRequest);
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x00155A7C File Offset: 0x00153C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowRestartRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x00155AAC File Offset: 0x00153CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x00155AEB File Offset: 0x00153CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x00155AF8 File Offset: 0x00153CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x00155B01 File Offset: 0x00153D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.FlowIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x00155B34 File Offset: 0x00153D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x00155B72 File Offset: 0x00153D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowRestartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CBD RID: 36029 RVA: 0x00155BA3 File Offset: 0x00153DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x00155BAC File Offset: 0x00153DAC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004532 RID: 17714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004533 RID: 17715
		public const int FlowIncIdFieldNumber = 14;

		// Token: 0x04004534 RID: 17716
		private long flowIncId_;
	}
}
