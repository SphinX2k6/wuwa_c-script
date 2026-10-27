using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3E RID: 3646
	[NetMessage(EMessageId.RacingBetMatchInfoRequest)]
	public sealed class RacingBetMatchInfoRequest : IMessage<RacingBetMatchInfoRequest>, IMessage, IEquatable<RacingBetMatchInfoRequest>, IDeepCloneable<RacingBetMatchInfoRequest>, IBufferMessage
	{
		// Token: 0x06013928 RID: 80168 RVA: 0x002D810F File Offset: 0x002D630F
		[NullableContext(1)]
		public static RacingBetMatchInfoRequest Create()
		{
			return new RacingBetMatchInfoRequest();
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x06013929 RID: 80169 RVA: 0x002D8116 File Offset: 0x002D6316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x0601392A RID: 80170 RVA: 0x002D8119 File Offset: 0x002D6319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601392B RID: 80171 RVA: 0x002D8120 File Offset: 0x002D6320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoRequest()
		{
		}

		// Token: 0x0601392C RID: 80172 RVA: 0x002D8128 File Offset: 0x002D6328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoRequest(RacingBetMatchInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601392D RID: 80173 RVA: 0x002D8159 File Offset: 0x002D6359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchInfoRequest Clone()
		{
			return new RacingBetMatchInfoRequest(this);
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x0601392E RID: 80174 RVA: 0x002D8161 File Offset: 0x002D6361
		// (set) Token: 0x0601392F RID: 80175 RVA: 0x002D8169 File Offset: 0x002D6369
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

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x06013930 RID: 80176 RVA: 0x002D8172 File Offset: 0x002D6372
		// (set) Token: 0x06013931 RID: 80177 RVA: 0x002D817A File Offset: 0x002D637A
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

		// Token: 0x06013932 RID: 80178 RVA: 0x002D8183 File Offset: 0x002D6383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchInfoRequest);
		}

		// Token: 0x06013933 RID: 80179 RVA: 0x002D8191 File Offset: 0x002D6391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013934 RID: 80180 RVA: 0x002D81D0 File Offset: 0x002D63D0
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

		// Token: 0x06013935 RID: 80181 RVA: 0x002D8228 File Offset: 0x002D6428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013936 RID: 80182 RVA: 0x002D8235 File Offset: 0x002D6435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013937 RID: 80183 RVA: 0x002D8240 File Offset: 0x002D6440
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

		// Token: 0x06013938 RID: 80184 RVA: 0x002D829C File Offset: 0x002D649C
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

		// Token: 0x06013939 RID: 80185 RVA: 0x002D82F4 File Offset: 0x002D64F4
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

		// Token: 0x0601393A RID: 80186 RVA: 0x002D8344 File Offset: 0x002D6544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601393B RID: 80187 RVA: 0x002D8350 File Offset: 0x002D6550
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

		// Token: 0x040077C9 RID: 30665
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077CA RID: 30666
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040077CB RID: 30667
		private int activityId_;

		// Token: 0x040077CC RID: 30668
		public const int LegMatchIdFieldNumber = 11;

		// Token: 0x040077CD RID: 30669
		private int legMatchId_;
	}
}
