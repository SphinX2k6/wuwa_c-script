using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D1 RID: 1745
	public sealed class GiantResponsePlayFlowPb : IMessage<GiantResponsePlayFlowPb>, IMessage, IEquatable<GiantResponsePlayFlowPb>, IDeepCloneable<GiantResponsePlayFlowPb>, IBufferMessage
	{
		// Token: 0x06009FB2 RID: 40882 RVA: 0x001832C4 File Offset: 0x001814C4
		[NullableContext(1)]
		public static GiantResponsePlayFlowPb Create()
		{
			return new GiantResponsePlayFlowPb();
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x001832CB File Offset: 0x001814CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06009FB4 RID: 40884 RVA: 0x001832CE File Offset: 0x001814CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponsePlayFlowPb.Descriptor;
			}
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x001832D5 File Offset: 0x001814D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayFlowPb()
		{
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x001832E8 File Offset: 0x001814E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayFlowPb(GiantResponsePlayFlowPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FB7 RID: 40887 RVA: 0x00183325 File Offset: 0x00181525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayFlowPb Clone()
		{
			return new GiantResponsePlayFlowPb(this);
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06009FB8 RID: 40888 RVA: 0x0018332D File Offset: 0x0018152D
		// (set) Token: 0x06009FB9 RID: 40889 RVA: 0x00183335 File Offset: 0x00181535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowListName
		{
			get
			{
				return this.flowListName_;
			}
			set
			{
				this.flowListName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06009FBA RID: 40890 RVA: 0x00183348 File Offset: 0x00181548
		// (set) Token: 0x06009FBB RID: 40891 RVA: 0x00183350 File Offset: 0x00181550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlowId
		{
			get
			{
				return this.flowId_;
			}
			set
			{
				this.flowId_ = value;
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06009FBC RID: 40892 RVA: 0x00183359 File Offset: 0x00181559
		// (set) Token: 0x06009FBD RID: 40893 RVA: 0x00183361 File Offset: 0x00181561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateId
		{
			get
			{
				return this.stateId_;
			}
			set
			{
				this.stateId_ = value;
			}
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x0018336A File Offset: 0x0018156A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponsePlayFlowPb);
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x00183378 File Offset: 0x00181578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponsePlayFlowPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x001833D8 File Offset: 0x001815D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowListName.Length != 0)
			{
				num ^= this.FlowListName.GetHashCode();
			}
			if (this.FlowId != 0)
			{
				num ^= this.FlowId.GetHashCode();
			}
			if (this.StateId != 0)
			{
				num ^= this.StateId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x0018344B File Offset: 0x0018164B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x00183458 File Offset: 0x00181658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x00183464 File Offset: 0x00181664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FlowId);
			}
			if (this.StateId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StateId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x001834E0 File Offset: 0x001816E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowListName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlowId);
			}
			if (this.StateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x00183554 File Offset: 0x00181754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantResponsePlayFlowPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowListName.Length != 0)
			{
				this.FlowListName = other.FlowListName;
			}
			if (other.FlowId != 0)
			{
				this.FlowId = other.FlowId;
			}
			if (other.StateId != 0)
			{
				this.StateId = other.StateId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FC6 RID: 40902 RVA: 0x001835BD File Offset: 0x001817BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x001835C8 File Offset: 0x001817C8
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StateId = input.ReadInt32();
						}
					}
					else
					{
						this.FlowId = input.ReadInt32();
					}
				}
				else
				{
					this.FlowListName = input.ReadString();
				}
			}
		}

		// Token: 0x04004AD4 RID: 19156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AD5 RID: 19157
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x04004AD6 RID: 19158
		private string flowListName_ = "";

		// Token: 0x04004AD7 RID: 19159
		public const int FlowIdFieldNumber = 2;

		// Token: 0x04004AD8 RID: 19160
		private int flowId_;

		// Token: 0x04004AD9 RID: 19161
		public const int StateIdFieldNumber = 3;

		// Token: 0x04004ADA RID: 19162
		private int stateId_;
	}
}
