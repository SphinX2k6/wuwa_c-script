using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A76 RID: 2678
	[NetMessage(EMessageId.MotorLinkTaskRequest)]
	public sealed class MotorLinkTaskRequest : IMessage<MotorLinkTaskRequest>, IMessage, IEquatable<MotorLinkTaskRequest>, IDeepCloneable<MotorLinkTaskRequest>, IBufferMessage
	{
		// Token: 0x0600E973 RID: 59763 RVA: 0x0022166C File Offset: 0x0021F86C
		[NullableContext(1)]
		public static MotorLinkTaskRequest Create()
		{
			return new MotorLinkTaskRequest();
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x0600E974 RID: 59764 RVA: 0x00221673 File Offset: 0x0021F873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0600E975 RID: 59765 RVA: 0x00221676 File Offset: 0x0021F876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLinkTaskRequest.Descriptor;
			}
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x0022167D File Offset: 0x0021F87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskRequest()
		{
		}

		// Token: 0x0600E977 RID: 59767 RVA: 0x00221685 File Offset: 0x0021F885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskRequest(MotorLinkTaskRequest other) : this()
		{
			this.motorIp_ = other.motorIp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E978 RID: 59768 RVA: 0x002216AA File Offset: 0x0021F8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskRequest Clone()
		{
			return new MotorLinkTaskRequest(this);
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0600E979 RID: 59769 RVA: 0x002216B2 File Offset: 0x0021F8B2
		// (set) Token: 0x0600E97A RID: 59770 RVA: 0x002216BA File Offset: 0x0021F8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorIp
		{
			get
			{
				return this.motorIp_;
			}
			set
			{
				this.motorIp_ = value;
			}
		}

		// Token: 0x0600E97B RID: 59771 RVA: 0x002216C3 File Offset: 0x0021F8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLinkTaskRequest);
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x002216D1 File Offset: 0x0021F8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLinkTaskRequest other)
		{
			return other != null && (other == this || (this.MotorIp == other.MotorIp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x00221700 File Offset: 0x0021F900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorIp != 0)
			{
				num ^= this.MotorIp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E97E RID: 59774 RVA: 0x0022173F File Offset: 0x0021F93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E97F RID: 59775 RVA: 0x0022174C File Offset: 0x0021F94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E980 RID: 59776 RVA: 0x00221755 File Offset: 0x0021F955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorIp != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E981 RID: 59777 RVA: 0x00221788 File Offset: 0x0021F988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorIp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E982 RID: 59778 RVA: 0x002217C6 File Offset: 0x0021F9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorLinkTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorIp != 0)
			{
				this.MotorIp = other.MotorIp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E983 RID: 59779 RVA: 0x002217F7 File Offset: 0x0021F9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E984 RID: 59780 RVA: 0x00221800 File Offset: 0x0021FA00
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
					this.MotorIp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005EEB RID: 24299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EEC RID: 24300
		public const int MotorIpFieldNumber = 14;

		// Token: 0x04005EED RID: 24301
		private int motorIp_;
	}
}
