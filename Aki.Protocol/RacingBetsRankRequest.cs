using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E72 RID: 3698
	[NetMessage(EMessageId.RacingBetsRankRequest)]
	public sealed class RacingBetsRankRequest : IMessage<RacingBetsRankRequest>, IMessage, IEquatable<RacingBetsRankRequest>, IDeepCloneable<RacingBetsRankRequest>, IBufferMessage
	{
		// Token: 0x06013DDB RID: 81371 RVA: 0x002E4AB7 File Offset: 0x002E2CB7
		[NullableContext(1)]
		public static RacingBetsRankRequest Create()
		{
			return new RacingBetsRankRequest();
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x06013DDC RID: 81372 RVA: 0x002E4ABE File Offset: 0x002E2CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x06013DDD RID: 81373 RVA: 0x002E4AC1 File Offset: 0x002E2CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRankRequest.Descriptor;
			}
		}

		// Token: 0x06013DDE RID: 81374 RVA: 0x002E4AC8 File Offset: 0x002E2CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankRequest()
		{
		}

		// Token: 0x06013DDF RID: 81375 RVA: 0x002E4AD0 File Offset: 0x002E2CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankRequest(RacingBetsRankRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013DE0 RID: 81376 RVA: 0x002E4AF5 File Offset: 0x002E2CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankRequest Clone()
		{
			return new RacingBetsRankRequest(this);
		}

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x06013DE1 RID: 81377 RVA: 0x002E4AFD File Offset: 0x002E2CFD
		// (set) Token: 0x06013DE2 RID: 81378 RVA: 0x002E4B05 File Offset: 0x002E2D05
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

		// Token: 0x06013DE3 RID: 81379 RVA: 0x002E4B0E File Offset: 0x002E2D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRankRequest);
		}

		// Token: 0x06013DE4 RID: 81380 RVA: 0x002E4B1C File Offset: 0x002E2D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRankRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DE5 RID: 81381 RVA: 0x002E4B4C File Offset: 0x002E2D4C
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

		// Token: 0x06013DE6 RID: 81382 RVA: 0x002E4B8B File Offset: 0x002E2D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013DE7 RID: 81383 RVA: 0x002E4B98 File Offset: 0x002E2D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013DE8 RID: 81384 RVA: 0x002E4BA1 File Offset: 0x002E2DA1
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

		// Token: 0x06013DE9 RID: 81385 RVA: 0x002E4BD4 File Offset: 0x002E2DD4
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

		// Token: 0x06013DEA RID: 81386 RVA: 0x002E4C12 File Offset: 0x002E2E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsRankRequest other)
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

		// Token: 0x06013DEB RID: 81387 RVA: 0x002E4C43 File Offset: 0x002E2E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013DEC RID: 81388 RVA: 0x002E4C4C File Offset: 0x002E2E4C
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

		// Token: 0x0400797F RID: 31103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007980 RID: 31104
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04007981 RID: 31105
		private int activityId_;
	}
}
