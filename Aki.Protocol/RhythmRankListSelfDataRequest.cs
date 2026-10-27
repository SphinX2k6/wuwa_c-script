using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F41 RID: 3905
	[NetMessage(EMessageId.RhythmRankListSelfDataRequest)]
	public sealed class RhythmRankListSelfDataRequest : IMessage<RhythmRankListSelfDataRequest>, IMessage, IEquatable<RhythmRankListSelfDataRequest>, IDeepCloneable<RhythmRankListSelfDataRequest>, IBufferMessage
	{
		// Token: 0x06014E49 RID: 85577 RVA: 0x00307E0E File Offset: 0x0030600E
		[NullableContext(1)]
		public static RhythmRankListSelfDataRequest Create()
		{
			return new RhythmRankListSelfDataRequest();
		}

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x06014E4A RID: 85578 RVA: 0x00307E15 File Offset: 0x00306015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x06014E4B RID: 85579 RVA: 0x00307E18 File Offset: 0x00306018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRankListSelfDataRequest.Descriptor;
			}
		}

		// Token: 0x06014E4C RID: 85580 RVA: 0x00307E1F File Offset: 0x0030601F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataRequest()
		{
		}

		// Token: 0x06014E4D RID: 85581 RVA: 0x00307E27 File Offset: 0x00306027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataRequest(RhythmRankListSelfDataRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E4E RID: 85582 RVA: 0x00307E4C File Offset: 0x0030604C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRankListSelfDataRequest Clone()
		{
			return new RhythmRankListSelfDataRequest(this);
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x06014E4F RID: 85583 RVA: 0x00307E54 File Offset: 0x00306054
		// (set) Token: 0x06014E50 RID: 85584 RVA: 0x00307E5C File Offset: 0x0030605C
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

		// Token: 0x06014E51 RID: 85585 RVA: 0x00307E65 File Offset: 0x00306065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRankListSelfDataRequest);
		}

		// Token: 0x06014E52 RID: 85586 RVA: 0x00307E73 File Offset: 0x00306073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRankListSelfDataRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E53 RID: 85587 RVA: 0x00307EA4 File Offset: 0x003060A4
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

		// Token: 0x06014E54 RID: 85588 RVA: 0x00307EE3 File Offset: 0x003060E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E55 RID: 85589 RVA: 0x00307EF0 File Offset: 0x003060F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E56 RID: 85590 RVA: 0x00307EF9 File Offset: 0x003060F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E57 RID: 85591 RVA: 0x00307F2C File Offset: 0x0030612C
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

		// Token: 0x06014E58 RID: 85592 RVA: 0x00307F6A File Offset: 0x0030616A
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

		// Token: 0x06014E59 RID: 85593 RVA: 0x00307F9B File Offset: 0x0030619B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E5A RID: 85594 RVA: 0x00307FA4 File Offset: 0x003061A4
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E00 RID: 32256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E01 RID: 32257
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04007E02 RID: 32258
		private int activityId_;
	}
}
