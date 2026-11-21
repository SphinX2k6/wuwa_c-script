using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2F RID: 3887
	[NetMessage(EMessageId.RhythmRankListRequest)]
	public sealed class RhythmRankListRequest : IMessage<RhythmRankListRequest>, IMessage, IEquatable<RhythmRankListRequest>, IDeepCloneable<RhythmRankListRequest>, IBufferMessage
	{
		// Token: 0x06014D3C RID: 85308 RVA: 0x003061DC File Offset: 0x003043DC
		[NullableContext(1)]
		public static RhythmRankListRequest Create()
		{
			return new RhythmRankListRequest();
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x06014D3D RID: 85309 RVA: 0x003061E3 File Offset: 0x003043E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x06014D3E RID: 85310 RVA: 0x003061E6 File Offset: 0x003043E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListRequest.Descriptor;
			}
		}

		// Token: 0x06014D3F RID: 85311 RVA: 0x003061ED File Offset: 0x003043ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListRequest()
		{
		}

		// Token: 0x06014D40 RID: 85312 RVA: 0x003061F5 File Offset: 0x003043F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListRequest(RhythmRankListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D41 RID: 85313 RVA: 0x0030621A File Offset: 0x0030441A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListRequest Clone()
		{
			return new RhythmRankListRequest(this);
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x06014D42 RID: 85314 RVA: 0x00306222 File Offset: 0x00304422
		// (set) Token: 0x06014D43 RID: 85315 RVA: 0x0030622A File Offset: 0x0030442A
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

		// Token: 0x06014D44 RID: 85316 RVA: 0x00306233 File Offset: 0x00304433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListRequest);
		}

		// Token: 0x06014D45 RID: 85317 RVA: 0x00306241 File Offset: 0x00304441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D46 RID: 85318 RVA: 0x00306270 File Offset: 0x00304470
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

		// Token: 0x06014D47 RID: 85319 RVA: 0x003062AF File Offset: 0x003044AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D48 RID: 85320 RVA: 0x003062BC File Offset: 0x003044BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D49 RID: 85321 RVA: 0x003062C5 File Offset: 0x003044C5
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

		// Token: 0x06014D4A RID: 85322 RVA: 0x003062F8 File Offset: 0x003044F8
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

		// Token: 0x06014D4B RID: 85323 RVA: 0x00306336 File Offset: 0x00304536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRankListRequest other)
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

		// Token: 0x06014D4C RID: 85324 RVA: 0x00306367 File Offset: 0x00304567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D4D RID: 85325 RVA: 0x00306370 File Offset: 0x00304570
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

		// Token: 0x04007E1F RID: 32287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E20 RID: 32288
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04007E21 RID: 32289
		private int activityId_;
	}
}
