using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2D RID: 2605
	[NetMessage(EMessageId.MotorDecalTaskRequest)]
	public sealed class MotorDecalTaskRequest : IMessage<MotorDecalTaskRequest>, IMessage, IEquatable<MotorDecalTaskRequest>, IDeepCloneable<MotorDecalTaskRequest>, IBufferMessage
	{
		// Token: 0x0600E39A RID: 58266 RVA: 0x00214D04 File Offset: 0x00212F04
		[NullableContext(1)]
		public static MotorDecalTaskRequest Create()
		{
			return new MotorDecalTaskRequest();
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0600E39B RID: 58267 RVA: 0x00214D0B File Offset: 0x00212F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600E39C RID: 58268 RVA: 0x00214D0E File Offset: 0x00212F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalTaskRequest.Descriptor;
			}
		}

		// Token: 0x0600E39D RID: 58269 RVA: 0x00214D15 File Offset: 0x00212F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskRequest()
		{
		}

		// Token: 0x0600E39E RID: 58270 RVA: 0x00214D1D File Offset: 0x00212F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskRequest(MotorDecalTaskRequest other) : this()
		{
			this.motorIp_ = other.motorIp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E39F RID: 58271 RVA: 0x00214D42 File Offset: 0x00212F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskRequest Clone()
		{
			return new MotorDecalTaskRequest(this);
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0600E3A0 RID: 58272 RVA: 0x00214D4A File Offset: 0x00212F4A
		// (set) Token: 0x0600E3A1 RID: 58273 RVA: 0x00214D52 File Offset: 0x00212F52
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

		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00214D5B File Offset: 0x00212F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalTaskRequest);
		}

		// Token: 0x0600E3A3 RID: 58275 RVA: 0x00214D69 File Offset: 0x00212F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalTaskRequest other)
		{
			return other != null && (other == this || (this.MotorIp == other.MotorIp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3A4 RID: 58276 RVA: 0x00214D98 File Offset: 0x00212F98
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

		// Token: 0x0600E3A5 RID: 58277 RVA: 0x00214DD7 File Offset: 0x00212FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E3A6 RID: 58278 RVA: 0x00214DE4 File Offset: 0x00212FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3A7 RID: 58279 RVA: 0x00214DED File Offset: 0x00212FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorIp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3A8 RID: 58280 RVA: 0x00214E20 File Offset: 0x00213020
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

		// Token: 0x0600E3A9 RID: 58281 RVA: 0x00214E5E File Offset: 0x0021305E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalTaskRequest other)
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

		// Token: 0x0600E3AA RID: 58282 RVA: 0x00214E8F File Offset: 0x0021308F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x00214E98 File Offset: 0x00213098
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
					this.MotorIp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D3B RID: 23867
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D3C RID: 23868
		public const int MotorIpFieldNumber = 2;

		// Token: 0x04005D3D RID: 23869
		private int motorIp_;
	}
}
