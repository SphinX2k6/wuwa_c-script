using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DF RID: 1503
	[NetMessage(EMessageId.FloroRanchSettleDataRequest)]
	public sealed class FloroRanchSettleDataRequest : IMessage<FloroRanchSettleDataRequest>, IMessage, IEquatable<FloroRanchSettleDataRequest>, IDeepCloneable<FloroRanchSettleDataRequest>, IBufferMessage
	{
		// Token: 0x06008AFF RID: 35583 RVA: 0x0014FED5 File Offset: 0x0014E0D5
		[NullableContext(1)]
		public static FloroRanchSettleDataRequest Create()
		{
			return new FloroRanchSettleDataRequest();
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06008B00 RID: 35584 RVA: 0x0014FEDC File Offset: 0x0014E0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06008B01 RID: 35585 RVA: 0x0014FEDF File Offset: 0x0014E0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleDataRequest.Descriptor;
			}
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x0014FEE6 File Offset: 0x0014E0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataRequest()
		{
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x0014FEEE File Offset: 0x0014E0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataRequest(FloroRanchSettleDataRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B04 RID: 35588 RVA: 0x0014FF1F File Offset: 0x0014E11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataRequest Clone()
		{
			return new FloroRanchSettleDataRequest(this);
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06008B05 RID: 35589 RVA: 0x0014FF27 File Offset: 0x0014E127
		// (set) Token: 0x06008B06 RID: 35590 RVA: 0x0014FF2F File Offset: 0x0014E12F
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

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06008B07 RID: 35591 RVA: 0x0014FF38 File Offset: 0x0014E138
		// (set) Token: 0x06008B08 RID: 35592 RVA: 0x0014FF40 File Offset: 0x0014E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x0014FF49 File Offset: 0x0014E149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleDataRequest);
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x0014FF57 File Offset: 0x0014E157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleDataRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x0014FF98 File Offset: 0x0014E198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x0014FFF0 File Offset: 0x0014E1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x0014FFFD File Offset: 0x0014E1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x00150008 File Offset: 0x0014E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x00150064 File Offset: 0x0014E264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x001500BC File Offset: 0x0014E2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSettleDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x0015010C File Offset: 0x0014E30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x00150118 File Offset: 0x0014E318
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004429 RID: 17449
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400442A RID: 17450
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x0400442B RID: 17451
		private int activityId_;

		// Token: 0x0400442C RID: 17452
		public const int SubInsIdFieldNumber = 2;

		// Token: 0x0400442D RID: 17453
		private int subInsId_;
	}
}
