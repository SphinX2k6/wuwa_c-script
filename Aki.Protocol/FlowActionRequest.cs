using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E0 RID: 1504
	[NetMessage(EMessageId.FlowActionRequest)]
	public sealed class FlowActionRequest : IMessage<FlowActionRequest>, IMessage, IEquatable<FlowActionRequest>, IDeepCloneable<FlowActionRequest>, IBufferMessage
	{
		// Token: 0x06008BCC RID: 35788 RVA: 0x00153CBD File Offset: 0x00151EBD
		[NullableContext(1)]
		public static FlowActionRequest Create()
		{
			return new FlowActionRequest();
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06008BCD RID: 35789 RVA: 0x00153CC4 File Offset: 0x00151EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06008BCE RID: 35790 RVA: 0x00153CC7 File Offset: 0x00151EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowActionRequest.Descriptor;
			}
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x00153CCE File Offset: 0x00151ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionRequest()
		{
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x00153CD6 File Offset: 0x00151ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionRequest(FlowActionRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this.actionId_ = other.actionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BD1 RID: 35793 RVA: 0x00153D07 File Offset: 0x00151F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionRequest Clone()
		{
			return new FlowActionRequest(this);
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x00153D0F File Offset: 0x00151F0F
		// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x00153D17 File Offset: 0x00151F17
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

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x00153D20 File Offset: 0x00151F20
		// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x00153D28 File Offset: 0x00151F28
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

		// Token: 0x06008BD6 RID: 35798 RVA: 0x00153D31 File Offset: 0x00151F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowActionRequest);
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x00153D3F File Offset: 0x00151F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowActionRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && this.ActionId == other.ActionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x00153D80 File Offset: 0x00151F80
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

		// Token: 0x06008BD9 RID: 35801 RVA: 0x00153DD8 File Offset: 0x00151FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x00153DE5 File Offset: 0x00151FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x00153DF0 File Offset: 0x00151FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActionId);
			}
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

		// Token: 0x06008BDC RID: 35804 RVA: 0x00153E4C File Offset: 0x0015204C
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

		// Token: 0x06008BDD RID: 35805 RVA: 0x00153EA4 File Offset: 0x001520A4
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

		// Token: 0x06008BDE RID: 35806 RVA: 0x00153EF4 File Offset: 0x001520F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x00153F00 File Offset: 0x00152100
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
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FlowIncId = input.ReadInt64();
					}
				}
				else
				{
					this.ActionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040044F4 RID: 17652
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044F5 RID: 17653
		public const int FlowIncIdFieldNumber = 14;

		// Token: 0x040044F6 RID: 17654
		private long flowIncId_;

		// Token: 0x040044F7 RID: 17655
		public const int ActionIdFieldNumber = 11;

		// Token: 0x040044F8 RID: 17656
		private int actionId_;
	}
}
