using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A65 RID: 2661
	[NetMessage(EMessageId.MotorLinkTaskRequest)]
	public sealed class MotorLinkTaskRequest : IMessage<MotorLinkTaskRequest>, IMessage, IEquatable<MotorLinkTaskRequest>, IDeepCloneable<MotorLinkTaskRequest>, IBufferMessage
	{
		// Token: 0x0600E859 RID: 59481 RVA: 0x0021F478 File Offset: 0x0021D678
		[NullableContext(1)]
		public static MotorLinkTaskRequest Create()
		{
			return new MotorLinkTaskRequest();
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0600E85A RID: 59482 RVA: 0x0021F47F File Offset: 0x0021D67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600E85B RID: 59483 RVA: 0x0021F482 File Offset: 0x0021D682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLinkTaskRequest.Descriptor;
			}
		}

		// Token: 0x0600E85C RID: 59484 RVA: 0x0021F489 File Offset: 0x0021D689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskRequest()
		{
		}

		// Token: 0x0600E85D RID: 59485 RVA: 0x0021F491 File Offset: 0x0021D691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskRequest(MotorLinkTaskRequest other) : this()
		{
			this.motorIp_ = other.motorIp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E85E RID: 59486 RVA: 0x0021F4B6 File Offset: 0x0021D6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskRequest Clone()
		{
			return new MotorLinkTaskRequest(this);
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600E85F RID: 59487 RVA: 0x0021F4BE File Offset: 0x0021D6BE
		// (set) Token: 0x0600E860 RID: 59488 RVA: 0x0021F4C6 File Offset: 0x0021D6C6
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

		// Token: 0x0600E861 RID: 59489 RVA: 0x0021F4CF File Offset: 0x0021D6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLinkTaskRequest);
		}

		// Token: 0x0600E862 RID: 59490 RVA: 0x0021F4DD File Offset: 0x0021D6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLinkTaskRequest other)
		{
			return other != null && (other == this || (this.MotorIp == other.MotorIp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E863 RID: 59491 RVA: 0x0021F50C File Offset: 0x0021D70C
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

		// Token: 0x0600E864 RID: 59492 RVA: 0x0021F54B File Offset: 0x0021D74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E865 RID: 59493 RVA: 0x0021F558 File Offset: 0x0021D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E866 RID: 59494 RVA: 0x0021F561 File Offset: 0x0021D761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorIp != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E867 RID: 59495 RVA: 0x0021F594 File Offset: 0x0021D794
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

		// Token: 0x0600E868 RID: 59496 RVA: 0x0021F5D2 File Offset: 0x0021D7D2
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

		// Token: 0x0600E869 RID: 59497 RVA: 0x0021F603 File Offset: 0x0021D803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E86A RID: 59498 RVA: 0x0021F60C File Offset: 0x0021D80C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MotorIp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005EF4 RID: 24308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EF5 RID: 24309
		public const int MotorIpFieldNumber = 13;

		// Token: 0x04005EF6 RID: 24310
		private int motorIp_;
	}
}
