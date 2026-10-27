using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D3 RID: 5075
	[NetMessage(EMessageId.TraceMoonPhaseRewardRequest)]
	public sealed class TraceMoonPhaseRewardRequest : IMessage<TraceMoonPhaseRewardRequest>, IMessage, IEquatable<TraceMoonPhaseRewardRequest>, IDeepCloneable<TraceMoonPhaseRewardRequest>, IBufferMessage
	{
		// Token: 0x0601AE9F RID: 110239 RVA: 0x003E6A78 File Offset: 0x003E4C78
		[NullableContext(1)]
		public static TraceMoonPhaseRewardRequest Create()
		{
			return new TraceMoonPhaseRewardRequest();
		}

		// Token: 0x17005AC2 RID: 23234
		// (get) Token: 0x0601AEA0 RID: 110240 RVA: 0x003E6A7F File Offset: 0x003E4C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC3 RID: 23235
		// (get) Token: 0x0601AEA1 RID: 110241 RVA: 0x003E6A82 File Offset: 0x003E4C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceMoonPhaseRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601AEA2 RID: 110242 RVA: 0x003E6A89 File Offset: 0x003E4C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardRequest()
		{
		}

		// Token: 0x0601AEA3 RID: 110243 RVA: 0x003E6A91 File Offset: 0x003E4C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardRequest(TraceMoonPhaseRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AEA4 RID: 110244 RVA: 0x003E6AB6 File Offset: 0x003E4CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseRewardRequest Clone()
		{
			return new TraceMoonPhaseRewardRequest(this);
		}

		// Token: 0x17005AC4 RID: 23236
		// (get) Token: 0x0601AEA5 RID: 110245 RVA: 0x003E6ABE File Offset: 0x003E4CBE
		// (set) Token: 0x0601AEA6 RID: 110246 RVA: 0x003E6AC6 File Offset: 0x003E4CC6
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

		// Token: 0x0601AEA7 RID: 110247 RVA: 0x003E6ACF File Offset: 0x003E4CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceMoonPhaseRewardRequest);
		}

		// Token: 0x0601AEA8 RID: 110248 RVA: 0x003E6ADD File Offset: 0x003E4CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceMoonPhaseRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AEA9 RID: 110249 RVA: 0x003E6B0C File Offset: 0x003E4D0C
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

		// Token: 0x0601AEAA RID: 110250 RVA: 0x003E6B4B File Offset: 0x003E4D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AEAB RID: 110251 RVA: 0x003E6B58 File Offset: 0x003E4D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEAC RID: 110252 RVA: 0x003E6B61 File Offset: 0x003E4D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AEAD RID: 110253 RVA: 0x003E6B94 File Offset: 0x003E4D94
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

		// Token: 0x0601AEAE RID: 110254 RVA: 0x003E6BD2 File Offset: 0x003E4DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceMoonPhaseRewardRequest other)
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

		// Token: 0x0601AEAF RID: 110255 RVA: 0x003E6C03 File Offset: 0x003E4E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AEB0 RID: 110256 RVA: 0x003E6C0C File Offset: 0x003E4E0C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C10 RID: 39952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C11 RID: 39953
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04009C12 RID: 39954
		private int activityId_;
	}
}
