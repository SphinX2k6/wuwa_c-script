using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A51 RID: 2641
	[NetMessage(EMessageId.MotorFightRankListRequest)]
	public sealed class MotorFightRankListRequest : IMessage<MotorFightRankListRequest>, IMessage, IEquatable<MotorFightRankListRequest>, IDeepCloneable<MotorFightRankListRequest>, IBufferMessage
	{
		// Token: 0x0600E671 RID: 58993 RVA: 0x0021AAD5 File Offset: 0x00218CD5
		[NullableContext(1)]
		public static MotorFightRankListRequest Create()
		{
			return new MotorFightRankListRequest();
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x0600E672 RID: 58994 RVA: 0x0021AADC File Offset: 0x00218CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x0600E673 RID: 58995 RVA: 0x0021AADF File Offset: 0x00218CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListRequest.Descriptor;
			}
		}

		// Token: 0x0600E674 RID: 58996 RVA: 0x0021AAE6 File Offset: 0x00218CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListRequest()
		{
		}

		// Token: 0x0600E675 RID: 58997 RVA: 0x0021AAEE File Offset: 0x00218CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListRequest(MotorFightRankListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E676 RID: 58998 RVA: 0x0021AB13 File Offset: 0x00218D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListRequest Clone()
		{
			return new MotorFightRankListRequest(this);
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x0600E677 RID: 58999 RVA: 0x0021AB1B File Offset: 0x00218D1B
		// (set) Token: 0x0600E678 RID: 59000 RVA: 0x0021AB23 File Offset: 0x00218D23
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

		// Token: 0x0600E679 RID: 59001 RVA: 0x0021AB2C File Offset: 0x00218D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListRequest);
		}

		// Token: 0x0600E67A RID: 59002 RVA: 0x0021AB3A File Offset: 0x00218D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E67B RID: 59003 RVA: 0x0021AB68 File Offset: 0x00218D68
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

		// Token: 0x0600E67C RID: 59004 RVA: 0x0021ABA7 File Offset: 0x00218DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E67D RID: 59005 RVA: 0x0021ABB4 File Offset: 0x00218DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E67E RID: 59006 RVA: 0x0021ABBD File Offset: 0x00218DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E67F RID: 59007 RVA: 0x0021ABF0 File Offset: 0x00218DF0
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

		// Token: 0x0600E680 RID: 59008 RVA: 0x0021AC2E File Offset: 0x00218E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRankListRequest other)
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

		// Token: 0x0600E681 RID: 59009 RVA: 0x0021AC5F File Offset: 0x00218E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E682 RID: 59010 RVA: 0x0021AC68 File Offset: 0x00218E68
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E01 RID: 24065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E02 RID: 24066
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04005E03 RID: 24067
		private int activityId_;
	}
}
