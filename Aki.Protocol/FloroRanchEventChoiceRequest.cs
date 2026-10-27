using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AE RID: 1454
	[NetMessage(EMessageId.FloroRanchEventChoiceRequest)]
	public sealed class FloroRanchEventChoiceRequest : IMessage<FloroRanchEventChoiceRequest>, IMessage, IEquatable<FloroRanchEventChoiceRequest>, IDeepCloneable<FloroRanchEventChoiceRequest>, IBufferMessage
	{
		// Token: 0x06008662 RID: 34402 RVA: 0x00142FDB File Offset: 0x001411DB
		[NullableContext(1)]
		public static FloroRanchEventChoiceRequest Create()
		{
			return new FloroRanchEventChoiceRequest();
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06008663 RID: 34403 RVA: 0x00142FE2 File Offset: 0x001411E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06008664 RID: 34404 RVA: 0x00142FE5 File Offset: 0x001411E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchEventChoiceRequest.Descriptor;
			}
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x00142FEC File Offset: 0x001411EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceRequest()
		{
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x00142FF4 File Offset: 0x001411F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceRequest(FloroRanchEventChoiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this.choice_ = other.choice_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008667 RID: 34407 RVA: 0x00143048 File Offset: 0x00141248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEventChoiceRequest Clone()
		{
			return new FloroRanchEventChoiceRequest(this);
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06008668 RID: 34408 RVA: 0x00143050 File Offset: 0x00141250
		// (set) Token: 0x06008669 RID: 34409 RVA: 0x00143058 File Offset: 0x00141258
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

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x0600866A RID: 34410 RVA: 0x00143061 File Offset: 0x00141261
		// (set) Token: 0x0600866B RID: 34411 RVA: 0x00143069 File Offset: 0x00141269
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

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x0600866C RID: 34412 RVA: 0x00143072 File Offset: 0x00141272
		// (set) Token: 0x0600866D RID: 34413 RVA: 0x0014307A File Offset: 0x0014127A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x0600866E RID: 34414 RVA: 0x00143083 File Offset: 0x00141283
		// (set) Token: 0x0600866F RID: 34415 RVA: 0x0014308B File Offset: 0x0014128B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Choice
		{
			get
			{
				return this.choice_;
			}
			set
			{
				this.choice_ = value;
			}
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x00143094 File Offset: 0x00141294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchEventChoiceRequest);
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x001430A4 File Offset: 0x001412A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchEventChoiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && this.Choice == other.Choice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x00143110 File Offset: 0x00141310
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
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Choice != 0)
			{
				num ^= this.Choice.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x0014319A File Offset: 0x0014139A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x001431A7 File Offset: 0x001413A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x001431B0 File Offset: 0x001413B0
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
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncId);
			}
			if (this.Choice != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Choice);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00143244 File Offset: 0x00141444
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
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Choice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Choice);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x001432CC File Offset: 0x001414CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchEventChoiceRequest other)
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
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Choice != 0)
			{
				this.Choice = other.Choice;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00143344 File Offset: 0x00141544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x00143350 File Offset: 0x00141550
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Choice = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400424B RID: 16971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400424C RID: 16972
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x0400424D RID: 16973
		private int activityId_;

		// Token: 0x0400424E RID: 16974
		public const int SubInsIdFieldNumber = 2;

		// Token: 0x0400424F RID: 16975
		private int subInsId_;

		// Token: 0x04004250 RID: 16976
		public const int IncIdFieldNumber = 5;

		// Token: 0x04004251 RID: 16977
		private int incId_;

		// Token: 0x04004252 RID: 16978
		public const int ChoiceFieldNumber = 6;

		// Token: 0x04004253 RID: 16979
		private int choice_;
	}
}
