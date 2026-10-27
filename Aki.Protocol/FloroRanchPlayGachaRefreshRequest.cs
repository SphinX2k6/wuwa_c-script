using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BC RID: 1468
	[NetMessage(EMessageId.FloroRanchPlayGachaRefreshRequest)]
	public sealed class FloroRanchPlayGachaRefreshRequest : IMessage<FloroRanchPlayGachaRefreshRequest>, IMessage, IEquatable<FloroRanchPlayGachaRefreshRequest>, IDeepCloneable<FloroRanchPlayGachaRefreshRequest>, IBufferMessage
	{
		// Token: 0x0600879D RID: 34717 RVA: 0x0014641F File Offset: 0x0014461F
		[NullableContext(1)]
		public static FloroRanchPlayGachaRefreshRequest Create()
		{
			return new FloroRanchPlayGachaRefreshRequest();
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600879E RID: 34718 RVA: 0x00146426 File Offset: 0x00144626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x0600879F RID: 34719 RVA: 0x00146429 File Offset: 0x00144629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaRefreshRequest.Descriptor;
			}
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x00146430 File Offset: 0x00144630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshRequest()
		{
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x00146438 File Offset: 0x00144638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshRequest(FloroRanchPlayGachaRefreshRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x00146475 File Offset: 0x00144675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshRequest Clone()
		{
			return new FloroRanchPlayGachaRefreshRequest(this);
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x060087A3 RID: 34723 RVA: 0x0014647D File Offset: 0x0014467D
		// (set) Token: 0x060087A4 RID: 34724 RVA: 0x00146485 File Offset: 0x00144685
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

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x060087A5 RID: 34725 RVA: 0x0014648E File Offset: 0x0014468E
		// (set) Token: 0x060087A6 RID: 34726 RVA: 0x00146496 File Offset: 0x00144696
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

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x060087A7 RID: 34727 RVA: 0x0014649F File Offset: 0x0014469F
		// (set) Token: 0x060087A8 RID: 34728 RVA: 0x001464A7 File Offset: 0x001446A7
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

		// Token: 0x060087A9 RID: 34729 RVA: 0x001464B0 File Offset: 0x001446B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaRefreshRequest);
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x001464C0 File Offset: 0x001446C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaRefreshRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x0014651C File Offset: 0x0014471C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x0014658D File Offset: 0x0014478D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x0014659A File Offset: 0x0014479A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x001465A4 File Offset: 0x001447A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SubInsId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x0014661C File Offset: 0x0014481C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x0014668C File Offset: 0x0014488C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGachaRefreshRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x001466F0 File Offset: 0x001448F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x001466FC File Offset: 0x001448FC
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
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.SubInsId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040042CE RID: 17102
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042CF RID: 17103
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040042D0 RID: 17104
		private int activityId_;

		// Token: 0x040042D1 RID: 17105
		public const int SubInsIdFieldNumber = 8;

		// Token: 0x040042D2 RID: 17106
		private int subInsId_;

		// Token: 0x040042D3 RID: 17107
		public const int IncIdFieldNumber = 14;

		// Token: 0x040042D4 RID: 17108
		private int incId_;
	}
}
