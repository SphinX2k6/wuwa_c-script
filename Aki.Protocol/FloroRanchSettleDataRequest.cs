using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CA RID: 1482
	[NetMessage(EMessageId.FloroRanchSettleDataRequest)]
	public sealed class FloroRanchSettleDataRequest : IMessage<FloroRanchSettleDataRequest>, IMessage, IEquatable<FloroRanchSettleDataRequest>, IDeepCloneable<FloroRanchSettleDataRequest>, IBufferMessage
	{
		// Token: 0x06008997 RID: 35223 RVA: 0x0014D2BD File Offset: 0x0014B4BD
		[NullableContext(1)]
		public static FloroRanchSettleDataRequest Create()
		{
			return new FloroRanchSettleDataRequest();
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06008998 RID: 35224 RVA: 0x0014D2C4 File Offset: 0x0014B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06008999 RID: 35225 RVA: 0x0014D2C7 File Offset: 0x0014B4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleDataRequest.Descriptor;
			}
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x0014D2CE File Offset: 0x0014B4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataRequest()
		{
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x0014D2D6 File Offset: 0x0014B4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataRequest(FloroRanchSettleDataRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x0014D307 File Offset: 0x0014B507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleDataRequest Clone()
		{
			return new FloroRanchSettleDataRequest(this);
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x0600899D RID: 35229 RVA: 0x0014D30F File Offset: 0x0014B50F
		// (set) Token: 0x0600899E RID: 35230 RVA: 0x0014D317 File Offset: 0x0014B517
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

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x0014D320 File Offset: 0x0014B520
		// (set) Token: 0x060089A0 RID: 35232 RVA: 0x0014D328 File Offset: 0x0014B528
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

		// Token: 0x060089A1 RID: 35233 RVA: 0x0014D331 File Offset: 0x0014B531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleDataRequest);
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x0014D33F File Offset: 0x0014B53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleDataRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x0014D380 File Offset: 0x0014B580
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

		// Token: 0x060089A4 RID: 35236 RVA: 0x0014D3D8 File Offset: 0x0014B5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x0014D3E5 File Offset: 0x0014B5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x0014D3F0 File Offset: 0x0014B5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x0014D44C File Offset: 0x0014B64C
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

		// Token: 0x060089A8 RID: 35240 RVA: 0x0014D4A4 File Offset: 0x0014B6A4
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

		// Token: 0x060089A9 RID: 35241 RVA: 0x0014D4F4 File Offset: 0x0014B6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x0014D500 File Offset: 0x0014B700
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
					if (num != 48U)
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

		// Token: 0x0400441F RID: 17439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004420 RID: 17440
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04004421 RID: 17441
		private int activityId_;

		// Token: 0x04004422 RID: 17442
		public const int SubInsIdFieldNumber = 5;

		// Token: 0x04004423 RID: 17443
		private int subInsId_;
	}
}
