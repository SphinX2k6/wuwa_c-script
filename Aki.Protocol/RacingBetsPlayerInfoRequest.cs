using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6E RID: 3694
	[NetMessage(EMessageId.RacingBetsPlayerInfoRequest)]
	public sealed class RacingBetsPlayerInfoRequest : IMessage<RacingBetsPlayerInfoRequest>, IMessage, IEquatable<RacingBetsPlayerInfoRequest>, IDeepCloneable<RacingBetsPlayerInfoRequest>, IBufferMessage
	{
		// Token: 0x06013D8F RID: 81295 RVA: 0x002E4117 File Offset: 0x002E2317
		[NullableContext(1)]
		public static RacingBetsPlayerInfoRequest Create()
		{
			return new RacingBetsPlayerInfoRequest();
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x06013D90 RID: 81296 RVA: 0x002E411E File Offset: 0x002E231E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x06013D91 RID: 81297 RVA: 0x002E4121 File Offset: 0x002E2321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsPlayerInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013D92 RID: 81298 RVA: 0x002E4128 File Offset: 0x002E2328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoRequest()
		{
		}

		// Token: 0x06013D93 RID: 81299 RVA: 0x002E4130 File Offset: 0x002E2330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoRequest(RacingBetsPlayerInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D94 RID: 81300 RVA: 0x002E4155 File Offset: 0x002E2355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPlayerInfoRequest Clone()
		{
			return new RacingBetsPlayerInfoRequest(this);
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x06013D95 RID: 81301 RVA: 0x002E415D File Offset: 0x002E235D
		// (set) Token: 0x06013D96 RID: 81302 RVA: 0x002E4165 File Offset: 0x002E2365
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

		// Token: 0x06013D97 RID: 81303 RVA: 0x002E416E File Offset: 0x002E236E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsPlayerInfoRequest);
		}

		// Token: 0x06013D98 RID: 81304 RVA: 0x002E417C File Offset: 0x002E237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsPlayerInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D99 RID: 81305 RVA: 0x002E41AC File Offset: 0x002E23AC
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

		// Token: 0x06013D9A RID: 81306 RVA: 0x002E41EB File Offset: 0x002E23EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D9B RID: 81307 RVA: 0x002E41F8 File Offset: 0x002E23F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D9C RID: 81308 RVA: 0x002E4201 File Offset: 0x002E2401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D9D RID: 81309 RVA: 0x002E4234 File Offset: 0x002E2434
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

		// Token: 0x06013D9E RID: 81310 RVA: 0x002E4272 File Offset: 0x002E2472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsPlayerInfoRequest other)
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

		// Token: 0x06013D9F RID: 81311 RVA: 0x002E42A3 File Offset: 0x002E24A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DA0 RID: 81312 RVA: 0x002E42AC File Offset: 0x002E24AC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400796E RID: 31086
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400796F RID: 31087
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04007970 RID: 31088
		private int activityId_;
	}
}
