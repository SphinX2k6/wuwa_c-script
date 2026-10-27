using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1A RID: 2586
	[NetMessage(EMessageId.MoraleTreasureBoxTraceRequest)]
	public sealed class MoraleTreasureBoxTraceRequest : IMessage<MoraleTreasureBoxTraceRequest>, IMessage, IEquatable<MoraleTreasureBoxTraceRequest>, IDeepCloneable<MoraleTreasureBoxTraceRequest>, IBufferMessage
	{
		// Token: 0x0600E22C RID: 57900 RVA: 0x00211F88 File Offset: 0x00210188
		[NullableContext(1)]
		public static MoraleTreasureBoxTraceRequest Create()
		{
			return new MoraleTreasureBoxTraceRequest();
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0600E22D RID: 57901 RVA: 0x00211F8F File Offset: 0x0021018F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0600E22E RID: 57902 RVA: 0x00211F92 File Offset: 0x00210192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleTreasureBoxTraceRequest.Descriptor;
			}
		}

		// Token: 0x0600E22F RID: 57903 RVA: 0x00211F99 File Offset: 0x00210199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceRequest()
		{
		}

		// Token: 0x0600E230 RID: 57904 RVA: 0x00211FA1 File Offset: 0x002101A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceRequest(MoraleTreasureBoxTraceRequest other) : this()
		{
			this.areaPos_ = other.areaPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E231 RID: 57905 RVA: 0x00211FC6 File Offset: 0x002101C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleTreasureBoxTraceRequest Clone()
		{
			return new MoraleTreasureBoxTraceRequest(this);
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600E232 RID: 57906 RVA: 0x00211FCE File Offset: 0x002101CE
		// (set) Token: 0x0600E233 RID: 57907 RVA: 0x00211FD6 File Offset: 0x002101D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaPos
		{
			get
			{
				return this.areaPos_;
			}
			set
			{
				this.areaPos_ = value;
			}
		}

		// Token: 0x0600E234 RID: 57908 RVA: 0x00211FDF File Offset: 0x002101DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleTreasureBoxTraceRequest);
		}

		// Token: 0x0600E235 RID: 57909 RVA: 0x00211FED File Offset: 0x002101ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleTreasureBoxTraceRequest other)
		{
			return other != null && (other == this || (this.AreaPos == other.AreaPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E236 RID: 57910 RVA: 0x0021201C File Offset: 0x0021021C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaPos != 0)
			{
				num ^= this.AreaPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E237 RID: 57911 RVA: 0x0021205B File Offset: 0x0021025B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E238 RID: 57912 RVA: 0x00212068 File Offset: 0x00210268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E239 RID: 57913 RVA: 0x00212071 File Offset: 0x00210271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaPos != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E23A RID: 57914 RVA: 0x002120A4 File Offset: 0x002102A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E23B RID: 57915 RVA: 0x002120E2 File Offset: 0x002102E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleTreasureBoxTraceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaPos != 0)
			{
				this.AreaPos = other.AreaPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E23C RID: 57916 RVA: 0x00212113 File Offset: 0x00210313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E23D RID: 57917 RVA: 0x0021211C File Offset: 0x0021031C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaPos = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005CE2 RID: 23778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CE3 RID: 23779
		public const int AreaPosFieldNumber = 8;

		// Token: 0x04005CE4 RID: 23780
		private int areaPos_;
	}
}
