using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1A RID: 2586
	[NetMessage(EMessageId.MotorDecalMotorIpRequest)]
	public sealed class MotorDecalMotorIpRequest : IMessage<MotorDecalMotorIpRequest>, IMessage, IEquatable<MotorDecalMotorIpRequest>, IDeepCloneable<MotorDecalMotorIpRequest>, IBufferMessage
	{
		// Token: 0x0600E25A RID: 57946 RVA: 0x0021269D File Offset: 0x0021089D
		[NullableContext(1)]
		public static MotorDecalMotorIpRequest Create()
		{
			return new MotorDecalMotorIpRequest();
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0600E25B RID: 57947 RVA: 0x002126A4 File Offset: 0x002108A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600E25C RID: 57948 RVA: 0x002126A7 File Offset: 0x002108A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalMotorIpRequest.Descriptor;
			}
		}

		// Token: 0x0600E25D RID: 57949 RVA: 0x002126AE File Offset: 0x002108AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpRequest()
		{
		}

		// Token: 0x0600E25E RID: 57950 RVA: 0x002126B6 File Offset: 0x002108B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpRequest(MotorDecalMotorIpRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E25F RID: 57951 RVA: 0x002126DB File Offset: 0x002108DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpRequest Clone()
		{
			return new MotorDecalMotorIpRequest(this);
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600E260 RID: 57952 RVA: 0x002126E3 File Offset: 0x002108E3
		// (set) Token: 0x0600E261 RID: 57953 RVA: 0x002126EB File Offset: 0x002108EB
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

		// Token: 0x0600E262 RID: 57954 RVA: 0x002126F4 File Offset: 0x002108F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalMotorIpRequest);
		}

		// Token: 0x0600E263 RID: 57955 RVA: 0x00212702 File Offset: 0x00210902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalMotorIpRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E264 RID: 57956 RVA: 0x00212730 File Offset: 0x00210930
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

		// Token: 0x0600E265 RID: 57957 RVA: 0x0021276F File Offset: 0x0021096F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E266 RID: 57958 RVA: 0x0021277C File Offset: 0x0021097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E267 RID: 57959 RVA: 0x00212785 File Offset: 0x00210985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E268 RID: 57960 RVA: 0x002127B8 File Offset: 0x002109B8
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

		// Token: 0x0600E269 RID: 57961 RVA: 0x002127F6 File Offset: 0x002109F6
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

		// Token: 0x0600E26A RID: 57962 RVA: 0x00212827 File Offset: 0x00210A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E26B RID: 57963 RVA: 0x00212830 File Offset: 0x00210A30
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D3C RID: 23868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D3D RID: 23869
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04005D3E RID: 23870
		private int activityId_;
	}
}
