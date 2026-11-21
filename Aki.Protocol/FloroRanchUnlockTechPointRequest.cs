using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D7 RID: 1495
	[NetMessage(EMessageId.FloroRanchUnlockTechPointRequest)]
	public sealed class FloroRanchUnlockTechPointRequest : IMessage<FloroRanchUnlockTechPointRequest>, IMessage, IEquatable<FloroRanchUnlockTechPointRequest>, IDeepCloneable<FloroRanchUnlockTechPointRequest>, IBufferMessage
	{
		// Token: 0x06008AFA RID: 35578 RVA: 0x00151891 File Offset: 0x0014FA91
		[NullableContext(1)]
		public static FloroRanchUnlockTechPointRequest Create()
		{
			return new FloroRanchUnlockTechPointRequest();
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06008AFB RID: 35579 RVA: 0x00151898 File Offset: 0x0014FA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06008AFC RID: 35580 RVA: 0x0015189B File Offset: 0x0014FA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUnlockTechPointRequest.Descriptor;
			}
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x001518A2 File Offset: 0x0014FAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointRequest()
		{
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x001518AA File Offset: 0x0014FAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointRequest(FloroRanchUnlockTechPointRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.techPoint_ = other.techPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x001518DB File Offset: 0x0014FADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointRequest Clone()
		{
			return new FloroRanchUnlockTechPointRequest(this);
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06008B00 RID: 35584 RVA: 0x001518E3 File Offset: 0x0014FAE3
		// (set) Token: 0x06008B01 RID: 35585 RVA: 0x001518EB File Offset: 0x0014FAEB
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

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06008B02 RID: 35586 RVA: 0x001518F4 File Offset: 0x0014FAF4
		// (set) Token: 0x06008B03 RID: 35587 RVA: 0x001518FC File Offset: 0x0014FAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TechPoint
		{
			get
			{
				return this.techPoint_;
			}
			set
			{
				this.techPoint_ = value;
			}
		}

		// Token: 0x06008B04 RID: 35588 RVA: 0x00151905 File Offset: 0x0014FB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUnlockTechPointRequest);
		}

		// Token: 0x06008B05 RID: 35589 RVA: 0x00151913 File Offset: 0x0014FB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUnlockTechPointRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.TechPoint == other.TechPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x00151954 File Offset: 0x0014FB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.TechPoint != 0)
			{
				num ^= this.TechPoint.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x001519AC File Offset: 0x0014FBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x001519B9 File Offset: 0x0014FBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x001519C4 File Offset: 0x0014FBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.TechPoint != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TechPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x00151A20 File Offset: 0x0014FC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.TechPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TechPoint);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x00151A78 File Offset: 0x0014FC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchUnlockTechPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.TechPoint != 0)
			{
				this.TechPoint = other.TechPoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x00151AC8 File Offset: 0x0014FCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x00151AD4 File Offset: 0x0014FCD4
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TechPoint = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040044B3 RID: 17587
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044B4 RID: 17588
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040044B5 RID: 17589
		private int activityId_;

		// Token: 0x040044B6 RID: 17590
		public const int TechPointFieldNumber = 15;

		// Token: 0x040044B7 RID: 17591
		private int techPoint_;
	}
}
