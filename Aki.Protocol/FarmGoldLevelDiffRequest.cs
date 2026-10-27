using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051E RID: 1310
	[NetMessage(EMessageId.FarmGoldLevelDiffRequest)]
	public sealed class FarmGoldLevelDiffRequest : IMessage<FarmGoldLevelDiffRequest>, IMessage, IEquatable<FarmGoldLevelDiffRequest>, IDeepCloneable<FarmGoldLevelDiffRequest>, IBufferMessage
	{
		// Token: 0x06007B00 RID: 31488 RVA: 0x0012A79D File Offset: 0x0012899D
		[NullableContext(1)]
		public static FarmGoldLevelDiffRequest Create()
		{
			return new FarmGoldLevelDiffRequest();
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06007B01 RID: 31489 RVA: 0x0012A7A4 File Offset: 0x001289A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06007B02 RID: 31490 RVA: 0x0012A7A7 File Offset: 0x001289A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelDiffRequest.Descriptor;
			}
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x0012A7AE File Offset: 0x001289AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffRequest()
		{
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x0012A7B6 File Offset: 0x001289B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffRequest(FarmGoldLevelDiffRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this.diff_ = other.diff_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x0012A7F3 File Offset: 0x001289F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelDiffRequest Clone()
		{
			return new FarmGoldLevelDiffRequest(this);
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06007B06 RID: 31494 RVA: 0x0012A7FB File Offset: 0x001289FB
		// (set) Token: 0x06007B07 RID: 31495 RVA: 0x0012A803 File Offset: 0x00128A03
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

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x0012A80C File Offset: 0x00128A0C
		// (set) Token: 0x06007B09 RID: 31497 RVA: 0x0012A814 File Offset: 0x00128A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06007B0A RID: 31498 RVA: 0x0012A81D File Offset: 0x00128A1D
		// (set) Token: 0x06007B0B RID: 31499 RVA: 0x0012A825 File Offset: 0x00128A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Diff
		{
			get
			{
				return this.diff_;
			}
			set
			{
				this.diff_ = value;
			}
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x0012A82E File Offset: 0x00128A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelDiffRequest);
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x0012A83C File Offset: 0x00128A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelDiffRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.Diff == other.Diff && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x0012A898 File Offset: 0x00128A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Diff != 0)
			{
				num ^= this.Diff.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x0012A909 File Offset: 0x00128B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x0012A916 File Offset: 0x00128B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x0012A920 File Offset: 0x00128B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.InstId);
			}
			if (this.Diff != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Diff);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x0012A998 File Offset: 0x00128B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Diff != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Diff);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x0012AA08 File Offset: 0x00128C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelDiffRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Diff != 0)
			{
				this.Diff = other.Diff;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x0012AA6C File Offset: 0x00128C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x0012AA78 File Offset: 0x00128C78
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
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Diff = input.ReadInt32();
						}
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F0D RID: 16141
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F0E RID: 16142
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04003F0F RID: 16143
		private int activityId_;

		// Token: 0x04003F10 RID: 16144
		public const int InstIdFieldNumber = 13;

		// Token: 0x04003F11 RID: 16145
		private int instId_;

		// Token: 0x04003F12 RID: 16146
		public const int DiffFieldNumber = 14;

		// Token: 0x04003F13 RID: 16147
		private int diff_;
	}
}
