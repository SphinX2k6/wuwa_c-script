using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A53 RID: 2643
	[NetMessage(EMessageId.MotorFightRankListSelfDataRequest)]
	public sealed class MotorFightRankListSelfDataRequest : IMessage<MotorFightRankListSelfDataRequest>, IMessage, IEquatable<MotorFightRankListSelfDataRequest>, IDeepCloneable<MotorFightRankListSelfDataRequest>, IBufferMessage
	{
		// Token: 0x0600E699 RID: 59033 RVA: 0x0021B04A File Offset: 0x0021924A
		[NullableContext(1)]
		public static MotorFightRankListSelfDataRequest Create()
		{
			return new MotorFightRankListSelfDataRequest();
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x0600E69A RID: 59034 RVA: 0x0021B051 File Offset: 0x00219251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x0600E69B RID: 59035 RVA: 0x0021B054 File Offset: 0x00219254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListSelfDataRequest.Descriptor;
			}
		}

		// Token: 0x0600E69C RID: 59036 RVA: 0x0021B05B File Offset: 0x0021925B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataRequest()
		{
		}

		// Token: 0x0600E69D RID: 59037 RVA: 0x0021B063 File Offset: 0x00219263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataRequest(MotorFightRankListSelfDataRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E69E RID: 59038 RVA: 0x0021B088 File Offset: 0x00219288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListSelfDataRequest Clone()
		{
			return new MotorFightRankListSelfDataRequest(this);
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600E69F RID: 59039 RVA: 0x0021B090 File Offset: 0x00219290
		// (set) Token: 0x0600E6A0 RID: 59040 RVA: 0x0021B098 File Offset: 0x00219298
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

		// Token: 0x0600E6A1 RID: 59041 RVA: 0x0021B0A1 File Offset: 0x002192A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListSelfDataRequest);
		}

		// Token: 0x0600E6A2 RID: 59042 RVA: 0x0021B0AF File Offset: 0x002192AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListSelfDataRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x0021B0E0 File Offset: 0x002192E0
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

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x0021B11F File Offset: 0x0021931F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6A5 RID: 59045 RVA: 0x0021B12C File Offset: 0x0021932C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6A6 RID: 59046 RVA: 0x0021B135 File Offset: 0x00219335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6A7 RID: 59047 RVA: 0x0021B168 File Offset: 0x00219368
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

		// Token: 0x0600E6A8 RID: 59048 RVA: 0x0021B1A6 File Offset: 0x002193A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRankListSelfDataRequest other)
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

		// Token: 0x0600E6A9 RID: 59049 RVA: 0x0021B1D7 File Offset: 0x002193D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6AA RID: 59050 RVA: 0x0021B1E0 File Offset: 0x002193E0
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E0C RID: 24076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E0D RID: 24077
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04005E0E RID: 24078
		private int activityId_;
	}
}
