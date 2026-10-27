using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E68 RID: 3688
	[NetMessage(EMessageId.RacingBetsMatchInfoRequest)]
	public sealed class RacingBetsMatchInfoRequest : IMessage<RacingBetsMatchInfoRequest>, IMessage, IEquatable<RacingBetsMatchInfoRequest>, IDeepCloneable<RacingBetsMatchInfoRequest>, IBufferMessage
	{
		// Token: 0x06013D03 RID: 81155 RVA: 0x002E2A43 File Offset: 0x002E0C43
		[NullableContext(1)]
		public static RacingBetsMatchInfoRequest Create()
		{
			return new RacingBetsMatchInfoRequest();
		}

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x06013D04 RID: 81156 RVA: 0x002E2A4A File Offset: 0x002E0C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x06013D05 RID: 81157 RVA: 0x002E2A4D File Offset: 0x002E0C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013D06 RID: 81158 RVA: 0x002E2A54 File Offset: 0x002E0C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoRequest()
		{
		}

		// Token: 0x06013D07 RID: 81159 RVA: 0x002E2A5C File Offset: 0x002E0C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoRequest(RacingBetsMatchInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D08 RID: 81160 RVA: 0x002E2A81 File Offset: 0x002E0C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchInfoRequest Clone()
		{
			return new RacingBetsMatchInfoRequest(this);
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x06013D09 RID: 81161 RVA: 0x002E2A89 File Offset: 0x002E0C89
		// (set) Token: 0x06013D0A RID: 81162 RVA: 0x002E2A91 File Offset: 0x002E0C91
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

		// Token: 0x06013D0B RID: 81163 RVA: 0x002E2A9A File Offset: 0x002E0C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchInfoRequest);
		}

		// Token: 0x06013D0C RID: 81164 RVA: 0x002E2AA8 File Offset: 0x002E0CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D0D RID: 81165 RVA: 0x002E2AD8 File Offset: 0x002E0CD8
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

		// Token: 0x06013D0E RID: 81166 RVA: 0x002E2B17 File Offset: 0x002E0D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D0F RID: 81167 RVA: 0x002E2B24 File Offset: 0x002E0D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D10 RID: 81168 RVA: 0x002E2B2D File Offset: 0x002E0D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D11 RID: 81169 RVA: 0x002E2B60 File Offset: 0x002E0D60
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

		// Token: 0x06013D12 RID: 81170 RVA: 0x002E2B9E File Offset: 0x002E0D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsMatchInfoRequest other)
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

		// Token: 0x06013D13 RID: 81171 RVA: 0x002E2BCF File Offset: 0x002E0DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D14 RID: 81172 RVA: 0x002E2BD8 File Offset: 0x002E0DD8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007936 RID: 31030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007937 RID: 31031
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04007938 RID: 31032
		private int activityId_;
	}
}
