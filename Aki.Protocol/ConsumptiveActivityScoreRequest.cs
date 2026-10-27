using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E4 RID: 740
	[NetMessage(EMessageId.ConsumptiveActivityScoreRequest)]
	public sealed class ConsumptiveActivityScoreRequest : IMessage<ConsumptiveActivityScoreRequest>, IMessage, IEquatable<ConsumptiveActivityScoreRequest>, IDeepCloneable<ConsumptiveActivityScoreRequest>, IBufferMessage
	{
		// Token: 0x06004B53 RID: 19283 RVA: 0x000B796B File Offset: 0x000B5B6B
		[NullableContext(1)]
		public static ConsumptiveActivityScoreRequest Create()
		{
			return new ConsumptiveActivityScoreRequest();
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06004B54 RID: 19284 RVA: 0x000B7972 File Offset: 0x000B5B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x000B7975 File Offset: 0x000B5B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityScoreRequest.Descriptor;
			}
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x000B797C File Offset: 0x000B5B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreRequest()
		{
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x000B7984 File Offset: 0x000B5B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreRequest(ConsumptiveActivityScoreRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x000B79A9 File Offset: 0x000B5BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreRequest Clone()
		{
			return new ConsumptiveActivityScoreRequest(this);
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x000B79B1 File Offset: 0x000B5BB1
		// (set) Token: 0x06004B5A RID: 19290 RVA: 0x000B79B9 File Offset: 0x000B5BB9
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

		// Token: 0x06004B5B RID: 19291 RVA: 0x000B79C2 File Offset: 0x000B5BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityScoreRequest);
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x000B79D0 File Offset: 0x000B5BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityScoreRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x000B7A00 File Offset: 0x000B5C00
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

		// Token: 0x06004B5E RID: 19294 RVA: 0x000B7A3F File Offset: 0x000B5C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x000B7A4C File Offset: 0x000B5C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x000B7A55 File Offset: 0x000B5C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x000B7A88 File Offset: 0x000B5C88
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

		// Token: 0x06004B62 RID: 19298 RVA: 0x000B7AC6 File Offset: 0x000B5CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityScoreRequest other)
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

		// Token: 0x06004B63 RID: 19299 RVA: 0x000B7AF7 File Offset: 0x000B5CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x000B7B00 File Offset: 0x000B5D00
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030AD RID: 12461
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030AE RID: 12462
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040030AF RID: 12463
		private int activityId_;
	}
}
