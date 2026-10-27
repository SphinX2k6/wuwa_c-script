using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044D RID: 1101
	[NetMessage(EMessageId.EnterAreaRequest)]
	public sealed class EnterAreaRequest : IMessage<EnterAreaRequest>, IMessage, IEquatable<EnterAreaRequest>, IDeepCloneable<EnterAreaRequest>, IBufferMessage
	{
		// Token: 0x0600692F RID: 26927 RVA: 0x000FC5E0 File Offset: 0x000FA7E0
		[NullableContext(1)]
		public static EnterAreaRequest Create()
		{
			return new EnterAreaRequest();
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x000FC5E7 File Offset: 0x000FA7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06006931 RID: 26929 RVA: 0x000FC5EA File Offset: 0x000FA7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAreaRequest.Descriptor;
			}
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x000FC5F1 File Offset: 0x000FA7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaRequest()
		{
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x000FC5F9 File Offset: 0x000FA7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaRequest(EnterAreaRequest other) : this()
		{
			this.id_ = other.id_;
			this.leaveId_ = other.leaveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x000FC62A File Offset: 0x000FA82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaRequest Clone()
		{
			return new EnterAreaRequest(this);
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06006935 RID: 26933 RVA: 0x000FC632 File Offset: 0x000FA832
		// (set) Token: 0x06006936 RID: 26934 RVA: 0x000FC63A File Offset: 0x000FA83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06006937 RID: 26935 RVA: 0x000FC643 File Offset: 0x000FA843
		// (set) Token: 0x06006938 RID: 26936 RVA: 0x000FC64B File Offset: 0x000FA84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeaveId
		{
			get
			{
				return this.leaveId_;
			}
			set
			{
				this.leaveId_ = value;
			}
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x000FC654 File Offset: 0x000FA854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAreaRequest);
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x000FC662 File Offset: 0x000FA862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAreaRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LeaveId == other.LeaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x000FC6A0 File Offset: 0x000FA8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LeaveId != 0)
			{
				num ^= this.LeaveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x000FC6F8 File Offset: 0x000FA8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x000FC705 File Offset: 0x000FA905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x000FC710 File Offset: 0x000FA910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LeaveId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LeaveId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x000FC76C File Offset: 0x000FA96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LeaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeaveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x000FC7C4 File Offset: 0x000FA9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAreaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LeaveId != 0)
			{
				this.LeaveId = other.LeaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x000FC814 File Offset: 0x000FAA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x000FC820 File Offset: 0x000FAA20
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
				if (num != 48U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.LeaveId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039E5 RID: 14821
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E6 RID: 14822
		public const int IdFieldNumber = 9;

		// Token: 0x040039E7 RID: 14823
		private int id_;

		// Token: 0x040039E8 RID: 14824
		public const int LeaveIdFieldNumber = 6;

		// Token: 0x040039E9 RID: 14825
		private int leaveId_;
	}
}
