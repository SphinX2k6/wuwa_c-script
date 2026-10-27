using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001362 RID: 4962
	[NetMessage(EMessageId.ThroughTrainFinishViewRequest)]
	public sealed class ThroughTrainFinishViewRequest : IMessage<ThroughTrainFinishViewRequest>, IMessage, IEquatable<ThroughTrainFinishViewRequest>, IDeepCloneable<ThroughTrainFinishViewRequest>, IBufferMessage
	{
		// Token: 0x0601A5AB RID: 107947 RVA: 0x003D3CF0 File Offset: 0x003D1EF0
		[NullableContext(1)]
		public static ThroughTrainFinishViewRequest Create()
		{
			return new ThroughTrainFinishViewRequest();
		}

		// Token: 0x170058E7 RID: 22759
		// (get) Token: 0x0601A5AC RID: 107948 RVA: 0x003D3CF7 File Offset: 0x003D1EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058E8 RID: 22760
		// (get) Token: 0x0601A5AD RID: 107949 RVA: 0x003D3CFA File Offset: 0x003D1EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThroughTrainFinishViewRequest.Descriptor;
			}
		}

		// Token: 0x0601A5AE RID: 107950 RVA: 0x003D3D01 File Offset: 0x003D1F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewRequest()
		{
		}

		// Token: 0x0601A5AF RID: 107951 RVA: 0x003D3D09 File Offset: 0x003D1F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewRequest(ThroughTrainFinishViewRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A5B0 RID: 107952 RVA: 0x003D3D2E File Offset: 0x003D1F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThroughTrainFinishViewRequest Clone()
		{
			return new ThroughTrainFinishViewRequest(this);
		}

		// Token: 0x170058E9 RID: 22761
		// (get) Token: 0x0601A5B1 RID: 107953 RVA: 0x003D3D36 File Offset: 0x003D1F36
		// (set) Token: 0x0601A5B2 RID: 107954 RVA: 0x003D3D3E File Offset: 0x003D1F3E
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

		// Token: 0x0601A5B3 RID: 107955 RVA: 0x003D3D47 File Offset: 0x003D1F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThroughTrainFinishViewRequest);
		}

		// Token: 0x0601A5B4 RID: 107956 RVA: 0x003D3D55 File Offset: 0x003D1F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThroughTrainFinishViewRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A5B5 RID: 107957 RVA: 0x003D3D84 File Offset: 0x003D1F84
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

		// Token: 0x0601A5B6 RID: 107958 RVA: 0x003D3DC3 File Offset: 0x003D1FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A5B7 RID: 107959 RVA: 0x003D3DD0 File Offset: 0x003D1FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A5B8 RID: 107960 RVA: 0x003D3DD9 File Offset: 0x003D1FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A5B9 RID: 107961 RVA: 0x003D3E0C File Offset: 0x003D200C
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

		// Token: 0x0601A5BA RID: 107962 RVA: 0x003D3E4A File Offset: 0x003D204A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThroughTrainFinishViewRequest other)
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

		// Token: 0x0601A5BB RID: 107963 RVA: 0x003D3E7B File Offset: 0x003D207B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A5BC RID: 107964 RVA: 0x003D3E84 File Offset: 0x003D2084
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009992 RID: 39314
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009993 RID: 39315
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04009994 RID: 39316
		private int activityId_;
	}
}
