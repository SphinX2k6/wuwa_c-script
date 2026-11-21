using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000436 RID: 1078
	[NetMessage(EMessageId.EnterAreaRequest)]
	public sealed class EnterAreaRequest : IMessage<EnterAreaRequest>, IMessage, IEquatable<EnterAreaRequest>, IDeepCloneable<EnterAreaRequest>, IBufferMessage
	{
		// Token: 0x0600679F RID: 26527 RVA: 0x000F9454 File Offset: 0x000F7654
		[NullableContext(1)]
		public static EnterAreaRequest Create()
		{
			return new EnterAreaRequest();
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x060067A0 RID: 26528 RVA: 0x000F945B File Offset: 0x000F765B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x060067A1 RID: 26529 RVA: 0x000F945E File Offset: 0x000F765E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAreaRequest.Descriptor;
			}
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x000F9465 File Offset: 0x000F7665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaRequest()
		{
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x000F946D File Offset: 0x000F766D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaRequest(EnterAreaRequest other) : this()
		{
			this.id_ = other.id_;
			this.leaveId_ = other.leaveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067A4 RID: 26532 RVA: 0x000F949E File Offset: 0x000F769E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaRequest Clone()
		{
			return new EnterAreaRequest(this);
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x060067A5 RID: 26533 RVA: 0x000F94A6 File Offset: 0x000F76A6
		// (set) Token: 0x060067A6 RID: 26534 RVA: 0x000F94AE File Offset: 0x000F76AE
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

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x060067A7 RID: 26535 RVA: 0x000F94B7 File Offset: 0x000F76B7
		// (set) Token: 0x060067A8 RID: 26536 RVA: 0x000F94BF File Offset: 0x000F76BF
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

		// Token: 0x060067A9 RID: 26537 RVA: 0x000F94C8 File Offset: 0x000F76C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAreaRequest);
		}

		// Token: 0x060067AA RID: 26538 RVA: 0x000F94D6 File Offset: 0x000F76D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAreaRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LeaveId == other.LeaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x000F9514 File Offset: 0x000F7714
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

		// Token: 0x060067AC RID: 26540 RVA: 0x000F956C File Offset: 0x000F776C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x000F9579 File Offset: 0x000F7779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x000F9584 File Offset: 0x000F7784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this.LeaveId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LeaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x000F95E0 File Offset: 0x000F77E0
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

		// Token: 0x060067B0 RID: 26544 RVA: 0x000F9638 File Offset: 0x000F7838
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

		// Token: 0x060067B1 RID: 26545 RVA: 0x000F9688 File Offset: 0x000F7888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x000F9694 File Offset: 0x000F7894
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LeaveId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039D2 RID: 14802
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D3 RID: 14803
		public const int IdFieldNumber = 6;

		// Token: 0x040039D4 RID: 14804
		private int id_;

		// Token: 0x040039D5 RID: 14805
		public const int LeaveIdFieldNumber = 7;

		// Token: 0x040039D6 RID: 14806
		private int leaveId_;
	}
}
