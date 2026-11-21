using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2E RID: 3630
	[NetMessage(EMessageId.RacingBetMatchInfoRequest)]
	public sealed class RacingBetMatchInfoRequest : IMessage<RacingBetMatchInfoRequest>, IMessage, IEquatable<RacingBetMatchInfoRequest>, IDeepCloneable<RacingBetMatchInfoRequest>, IBufferMessage
	{
		// Token: 0x06013843 RID: 79939 RVA: 0x002D6A4F File Offset: 0x002D4C4F
		[NullableContext(1)]
		public static RacingBetMatchInfoRequest Create()
		{
			return new RacingBetMatchInfoRequest();
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x06013844 RID: 79940 RVA: 0x002D6A56 File Offset: 0x002D4C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x06013845 RID: 79941 RVA: 0x002D6A59 File Offset: 0x002D4C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013846 RID: 79942 RVA: 0x002D6A60 File Offset: 0x002D4C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoRequest()
		{
		}

		// Token: 0x06013847 RID: 79943 RVA: 0x002D6A68 File Offset: 0x002D4C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoRequest(RacingBetMatchInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013848 RID: 79944 RVA: 0x002D6A99 File Offset: 0x002D4C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoRequest Clone()
		{
			return new RacingBetMatchInfoRequest(this);
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x06013849 RID: 79945 RVA: 0x002D6AA1 File Offset: 0x002D4CA1
		// (set) Token: 0x0601384A RID: 79946 RVA: 0x002D6AA9 File Offset: 0x002D4CA9
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

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x0601384B RID: 79947 RVA: 0x002D6AB2 File Offset: 0x002D4CB2
		// (set) Token: 0x0601384C RID: 79948 RVA: 0x002D6ABA File Offset: 0x002D4CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x0601384D RID: 79949 RVA: 0x002D6AC3 File Offset: 0x002D4CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchInfoRequest);
		}

		// Token: 0x0601384E RID: 79950 RVA: 0x002D6AD1 File Offset: 0x002D4CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601384F RID: 79951 RVA: 0x002D6B10 File Offset: 0x002D4D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013850 RID: 79952 RVA: 0x002D6B68 File Offset: 0x002D4D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013851 RID: 79953 RVA: 0x002D6B75 File Offset: 0x002D4D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013852 RID: 79954 RVA: 0x002D6B80 File Offset: 0x002D4D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013853 RID: 79955 RVA: 0x002D6BDC File Offset: 0x002D4DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013854 RID: 79956 RVA: 0x002D6C34 File Offset: 0x002D4E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013855 RID: 79957 RVA: 0x002D6C84 File Offset: 0x002D4E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013856 RID: 79958 RVA: 0x002D6C90 File Offset: 0x002D4E90
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
				if (num != 24U)
				{
					if (num != 88U)
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
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077F3 RID: 30707
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077F4 RID: 30708
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040077F5 RID: 30709
		private int activityId_;

		// Token: 0x040077F6 RID: 30710
		public const int LegMatchIdFieldNumber = 3;

		// Token: 0x040077F7 RID: 30711
		private int legMatchId_;
	}
}
