using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000600 RID: 1536
	[NetMessage(EMessageId.FlowRestartRequest)]
	public sealed class FlowRestartRequest : IMessage<FlowRestartRequest>, IMessage, IEquatable<FlowRestartRequest>, IDeepCloneable<FlowRestartRequest>, IBufferMessage
	{
		// Token: 0x06008E15 RID: 36373 RVA: 0x00158617 File Offset: 0x00156817
		[NullableContext(1)]
		public static FlowRestartRequest Create()
		{
			return new FlowRestartRequest();
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x0015861E File Offset: 0x0015681E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06008E17 RID: 36375 RVA: 0x00158621 File Offset: 0x00156821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowRestartRequest.Descriptor;
			}
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x00158628 File Offset: 0x00156828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartRequest()
		{
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x00158630 File Offset: 0x00156830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartRequest(FlowRestartRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x00158655 File Offset: 0x00156855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowRestartRequest Clone()
		{
			return new FlowRestartRequest(this);
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x0015865D File Offset: 0x0015685D
		// (set) Token: 0x06008E1C RID: 36380 RVA: 0x00158665 File Offset: 0x00156865
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

		// Token: 0x06008E1D RID: 36381 RVA: 0x0015866E File Offset: 0x0015686E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowRestartRequest);
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x0015867C File Offset: 0x0015687C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowRestartRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x001586AC File Offset: 0x001568AC
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

		// Token: 0x06008E20 RID: 36384 RVA: 0x001586EB File Offset: 0x001568EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x001586F8 File Offset: 0x001568F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x00158701 File Offset: 0x00156901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.FlowIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x00158734 File Offset: 0x00156934
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

		// Token: 0x06008E24 RID: 36388 RVA: 0x00158772 File Offset: 0x00156972
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

		// Token: 0x06008E25 RID: 36389 RVA: 0x001587A3 File Offset: 0x001569A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x001587AC File Offset: 0x001569AC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400453C RID: 17724
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400453D RID: 17725
		public const int FlowIncIdFieldNumber = 2;

		// Token: 0x0400453E RID: 17726
		private long flowIncId_;
	}
}
