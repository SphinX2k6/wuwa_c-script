using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F31 RID: 3889
	[NetMessage(EMessageId.RhythmRankListSelfDataRequest)]
	public sealed class RhythmRankListSelfDataRequest : IMessage<RhythmRankListSelfDataRequest>, IMessage, IEquatable<RhythmRankListSelfDataRequest>, IDeepCloneable<RhythmRankListSelfDataRequest>, IBufferMessage
	{
		// Token: 0x06014D64 RID: 85348 RVA: 0x00306752 File Offset: 0x00304952
		[NullableContext(1)]
		public static RhythmRankListSelfDataRequest Create()
		{
			return new RhythmRankListSelfDataRequest();
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x06014D65 RID: 85349 RVA: 0x00306759 File Offset: 0x00304959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x06014D66 RID: 85350 RVA: 0x0030675C File Offset: 0x0030495C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListSelfDataRequest.Descriptor;
			}
		}

		// Token: 0x06014D67 RID: 85351 RVA: 0x00306763 File Offset: 0x00304963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataRequest()
		{
		}

		// Token: 0x06014D68 RID: 85352 RVA: 0x0030676B File Offset: 0x0030496B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataRequest(RhythmRankListSelfDataRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D69 RID: 85353 RVA: 0x00306790 File Offset: 0x00304990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataRequest Clone()
		{
			return new RhythmRankListSelfDataRequest(this);
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x06014D6A RID: 85354 RVA: 0x00306798 File Offset: 0x00304998
		// (set) Token: 0x06014D6B RID: 85355 RVA: 0x003067A0 File Offset: 0x003049A0
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

		// Token: 0x06014D6C RID: 85356 RVA: 0x003067A9 File Offset: 0x003049A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListSelfDataRequest);
		}

		// Token: 0x06014D6D RID: 85357 RVA: 0x003067B7 File Offset: 0x003049B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListSelfDataRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D6E RID: 85358 RVA: 0x003067E8 File Offset: 0x003049E8
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

		// Token: 0x06014D6F RID: 85359 RVA: 0x00306827 File Offset: 0x00304A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D70 RID: 85360 RVA: 0x00306834 File Offset: 0x00304A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D71 RID: 85361 RVA: 0x0030683D File Offset: 0x00304A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D72 RID: 85362 RVA: 0x00306870 File Offset: 0x00304A70
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

		// Token: 0x06014D73 RID: 85363 RVA: 0x003068AE File Offset: 0x00304AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRankListSelfDataRequest other)
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

		// Token: 0x06014D74 RID: 85364 RVA: 0x003068DF File Offset: 0x00304ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D75 RID: 85365 RVA: 0x003068E8 File Offset: 0x00304AE8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E2A RID: 32298
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E2B RID: 32299
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04007E2C RID: 32300
		private int activityId_;
	}
}
