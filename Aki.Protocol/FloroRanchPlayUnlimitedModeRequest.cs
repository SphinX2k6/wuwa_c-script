using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C1 RID: 1473
	[NetMessage(EMessageId.FloroRanchPlayUnlimitedModeRequest)]
	public sealed class FloroRanchPlayUnlimitedModeRequest : IMessage<FloroRanchPlayUnlimitedModeRequest>, IMessage, IEquatable<FloroRanchPlayUnlimitedModeRequest>, IDeepCloneable<FloroRanchPlayUnlimitedModeRequest>, IBufferMessage
	{
		// Token: 0x060088E1 RID: 35041 RVA: 0x0014BAC9 File Offset: 0x00149CC9
		[NullableContext(1)]
		public static FloroRanchPlayUnlimitedModeRequest Create()
		{
			return new FloroRanchPlayUnlimitedModeRequest();
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060088E2 RID: 35042 RVA: 0x0014BAD0 File Offset: 0x00149CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060088E3 RID: 35043 RVA: 0x0014BAD3 File Offset: 0x00149CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayUnlimitedModeRequest.Descriptor;
			}
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x0014BADA File Offset: 0x00149CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeRequest()
		{
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x0014BAE2 File Offset: 0x00149CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeRequest(FloroRanchPlayUnlimitedModeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x0014BB13 File Offset: 0x00149D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeRequest Clone()
		{
			return new FloroRanchPlayUnlimitedModeRequest(this);
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060088E7 RID: 35047 RVA: 0x0014BB1B File Offset: 0x00149D1B
		// (set) Token: 0x060088E8 RID: 35048 RVA: 0x0014BB23 File Offset: 0x00149D23
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

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060088E9 RID: 35049 RVA: 0x0014BB2C File Offset: 0x00149D2C
		// (set) Token: 0x060088EA RID: 35050 RVA: 0x0014BB34 File Offset: 0x00149D34
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

		// Token: 0x060088EB RID: 35051 RVA: 0x0014BB3D File Offset: 0x00149D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayUnlimitedModeRequest);
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x0014BB4B File Offset: 0x00149D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayUnlimitedModeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x0014BB8C File Offset: 0x00149D8C
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

		// Token: 0x060088EE RID: 35054 RVA: 0x0014BBE4 File Offset: 0x00149DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088EF RID: 35055 RVA: 0x0014BBF1 File Offset: 0x00149DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x0014BBFC File Offset: 0x00149DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x0014BC54 File Offset: 0x00149E54
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

		// Token: 0x060088F2 RID: 35058 RVA: 0x0014BCAC File Offset: 0x00149EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayUnlimitedModeRequest other)
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

		// Token: 0x060088F3 RID: 35059 RVA: 0x0014BCFC File Offset: 0x00149EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x0014BD08 File Offset: 0x00149F08
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
				if (num != 8U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x040043EE RID: 17390
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043EF RID: 17391
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040043F0 RID: 17392
		private int activityId_;

		// Token: 0x040043F1 RID: 17393
		public const int SubInsIdFieldNumber = 7;

		// Token: 0x040043F2 RID: 17394
		private int subInsId_;
	}
}
