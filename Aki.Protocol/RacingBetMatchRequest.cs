using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E30 RID: 3632
	[NetMessage(EMessageId.RacingBetMatchRequest)]
	public sealed class RacingBetMatchRequest : IMessage<RacingBetMatchRequest>, IMessage, IEquatable<RacingBetMatchRequest>, IDeepCloneable<RacingBetMatchRequest>, IBufferMessage
	{
		// Token: 0x0601386B RID: 79979 RVA: 0x002D6F9C File Offset: 0x002D519C
		[NullableContext(1)]
		public static RacingBetMatchRequest Create()
		{
			return new RacingBetMatchRequest();
		}

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x0601386C RID: 79980 RVA: 0x002D6FA3 File Offset: 0x002D51A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x0601386D RID: 79981 RVA: 0x002D6FA6 File Offset: 0x002D51A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRequest.Descriptor;
			}
		}

		// Token: 0x0601386E RID: 79982 RVA: 0x002D6FAD File Offset: 0x002D51AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRequest()
		{
		}

		// Token: 0x0601386F RID: 79983 RVA: 0x002D6FB5 File Offset: 0x002D51B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRequest(RacingBetMatchRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013870 RID: 79984 RVA: 0x002D6FE6 File Offset: 0x002D51E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRequest Clone()
		{
			return new RacingBetMatchRequest(this);
		}

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x06013871 RID: 79985 RVA: 0x002D6FEE File Offset: 0x002D51EE
		// (set) Token: 0x06013872 RID: 79986 RVA: 0x002D6FF6 File Offset: 0x002D51F6
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

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x06013873 RID: 79987 RVA: 0x002D6FFF File Offset: 0x002D51FF
		// (set) Token: 0x06013874 RID: 79988 RVA: 0x002D7007 File Offset: 0x002D5207
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

		// Token: 0x06013875 RID: 79989 RVA: 0x002D7010 File Offset: 0x002D5210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRequest);
		}

		// Token: 0x06013876 RID: 79990 RVA: 0x002D701E File Offset: 0x002D521E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013877 RID: 79991 RVA: 0x002D705C File Offset: 0x002D525C
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

		// Token: 0x06013878 RID: 79992 RVA: 0x002D70B4 File Offset: 0x002D52B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013879 RID: 79993 RVA: 0x002D70C1 File Offset: 0x002D52C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601387A RID: 79994 RVA: 0x002D70CC File Offset: 0x002D52CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601387B RID: 79995 RVA: 0x002D7128 File Offset: 0x002D5328
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

		// Token: 0x0601387C RID: 79996 RVA: 0x002D7180 File Offset: 0x002D5380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchRequest other)
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

		// Token: 0x0601387D RID: 79997 RVA: 0x002D71D0 File Offset: 0x002D53D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601387E RID: 79998 RVA: 0x002D71DC File Offset: 0x002D53DC
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LegMatchId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077FE RID: 30718
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077FF RID: 30719
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04007800 RID: 30720
		private int activityId_;

		// Token: 0x04007801 RID: 30721
		public const int LegMatchIdFieldNumber = 11;

		// Token: 0x04007802 RID: 30722
		private int legMatchId_;
	}
}
