using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAF RID: 2735
	[NetMessage(EMessageId.MotorTechTreeSwitchRequest)]
	public sealed class MotorTechTreeSwitchRequest : IMessage<MotorTechTreeSwitchRequest>, IMessage, IEquatable<MotorTechTreeSwitchRequest>, IDeepCloneable<MotorTechTreeSwitchRequest>, IBufferMessage
	{
		// Token: 0x0600EE0F RID: 60943 RVA: 0x0022BF5E File Offset: 0x0022A15E
		[NullableContext(1)]
		public static MotorTechTreeSwitchRequest Create()
		{
			return new MotorTechTreeSwitchRequest();
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0600EE10 RID: 60944 RVA: 0x0022BF65 File Offset: 0x0022A165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0600EE11 RID: 60945 RVA: 0x0022BF68 File Offset: 0x0022A168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechTreeSwitchRequest.Descriptor;
			}
		}

		// Token: 0x0600EE12 RID: 60946 RVA: 0x0022BF6F File Offset: 0x0022A16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchRequest()
		{
		}

		// Token: 0x0600EE13 RID: 60947 RVA: 0x0022BF77 File Offset: 0x0022A177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchRequest(MotorTechTreeSwitchRequest other) : this()
		{
			this.treeId_ = other.treeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE14 RID: 60948 RVA: 0x0022BF9C File Offset: 0x0022A19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechTreeSwitchRequest Clone()
		{
			return new MotorTechTreeSwitchRequest(this);
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0600EE15 RID: 60949 RVA: 0x0022BFA4 File Offset: 0x0022A1A4
		// (set) Token: 0x0600EE16 RID: 60950 RVA: 0x0022BFAC File Offset: 0x0022A1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x0600EE17 RID: 60951 RVA: 0x0022BFB5 File Offset: 0x0022A1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechTreeSwitchRequest);
		}

		// Token: 0x0600EE18 RID: 60952 RVA: 0x0022BFC3 File Offset: 0x0022A1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechTreeSwitchRequest other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE19 RID: 60953 RVA: 0x0022BFF4 File Offset: 0x0022A1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EE1A RID: 60954 RVA: 0x0022C033 File Offset: 0x0022A233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE1B RID: 60955 RVA: 0x0022C040 File Offset: 0x0022A240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE1C RID: 60956 RVA: 0x0022C049 File Offset: 0x0022A249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE1D RID: 60957 RVA: 0x0022C07C File Offset: 0x0022A27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EE1E RID: 60958 RVA: 0x0022C0BA File Offset: 0x0022A2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechTreeSwitchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EE1F RID: 60959 RVA: 0x0022C0EB File Offset: 0x0022A2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE20 RID: 60960 RVA: 0x0022C0F4 File Offset: 0x0022A2F4
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
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400605C RID: 24668
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400605D RID: 24669
		public const int TreeIdFieldNumber = 14;

		// Token: 0x0400605E RID: 24670
		private int treeId_;
	}
}
