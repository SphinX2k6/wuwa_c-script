using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A2B RID: 2603
	[NetMessage(EMessageId.MotorDecalMotorIpRequest)]
	public sealed class MotorDecalMotorIpRequest : IMessage<MotorDecalMotorIpRequest>, IMessage, IEquatable<MotorDecalMotorIpRequest>, IDeepCloneable<MotorDecalMotorIpRequest>, IBufferMessage
	{
		// Token: 0x0600E374 RID: 58228 RVA: 0x00214891 File Offset: 0x00212A91
		[NullableContext(1)]
		public static MotorDecalMotorIpRequest Create()
		{
			return new MotorDecalMotorIpRequest();
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600E375 RID: 58229 RVA: 0x00214898 File Offset: 0x00212A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x0600E376 RID: 58230 RVA: 0x0021489B File Offset: 0x00212A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalMotorIpRequest.Descriptor;
			}
		}

		// Token: 0x0600E377 RID: 58231 RVA: 0x002148A2 File Offset: 0x00212AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpRequest()
		{
		}

		// Token: 0x0600E378 RID: 58232 RVA: 0x002148AA File Offset: 0x00212AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpRequest(MotorDecalMotorIpRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E379 RID: 58233 RVA: 0x002148CF File Offset: 0x00212ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpRequest Clone()
		{
			return new MotorDecalMotorIpRequest(this);
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x0600E37A RID: 58234 RVA: 0x002148D7 File Offset: 0x00212AD7
		// (set) Token: 0x0600E37B RID: 58235 RVA: 0x002148DF File Offset: 0x00212ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0600E37C RID: 58236 RVA: 0x002148E8 File Offset: 0x00212AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalMotorIpRequest);
		}

		// Token: 0x0600E37D RID: 58237 RVA: 0x002148F6 File Offset: 0x00212AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalMotorIpRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E37E RID: 58238 RVA: 0x00214924 File Offset: 0x00212B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E37F RID: 58239 RVA: 0x00214963 File Offset: 0x00212B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E380 RID: 58240 RVA: 0x00214970 File Offset: 0x00212B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E381 RID: 58241 RVA: 0x00214979 File Offset: 0x00212B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E382 RID: 58242 RVA: 0x002149AC File Offset: 0x00212BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x002149EA File Offset: 0x00212BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalMotorIpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x00214A1B File Offset: 0x00212C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E385 RID: 58245 RVA: 0x00214A24 File Offset: 0x00212C24
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D33 RID: 23859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D34 RID: 23860
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04005D35 RID: 23861
		private int activityId_;
	}
}
