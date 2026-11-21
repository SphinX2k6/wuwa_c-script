using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000906 RID: 2310
	[NetMessage(EMessageId.LifePointChallengeStartRequest)]
	public sealed class LifePointChallengeStartRequest : IMessage<LifePointChallengeStartRequest>, IMessage, IEquatable<LifePointChallengeStartRequest>, IDeepCloneable<LifePointChallengeStartRequest>, IBufferMessage
	{
		// Token: 0x0600CC46 RID: 52294 RVA: 0x001E213C File Offset: 0x001E033C
		[NullableContext(1)]
		public static LifePointChallengeStartRequest Create()
		{
			return new LifePointChallengeStartRequest();
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600CC47 RID: 52295 RVA: 0x001E2143 File Offset: 0x001E0343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600CC48 RID: 52296 RVA: 0x001E2146 File Offset: 0x001E0346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeStartRequest.Descriptor;
			}
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x001E214D File Offset: 0x001E034D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartRequest()
		{
		}

		// Token: 0x0600CC4A RID: 52298 RVA: 0x001E2155 File Offset: 0x001E0355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartRequest(LifePointChallengeStartRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC4B RID: 52299 RVA: 0x001E217A File Offset: 0x001E037A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartRequest Clone()
		{
			return new LifePointChallengeStartRequest(this);
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x0600CC4C RID: 52300 RVA: 0x001E2182 File Offset: 0x001E0382
		// (set) Token: 0x0600CC4D RID: 52301 RVA: 0x001E218A File Offset: 0x001E038A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x001E2193 File Offset: 0x001E0393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeStartRequest);
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x001E21A1 File Offset: 0x001E03A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeStartRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC50 RID: 52304 RVA: 0x001E21D0 File Offset: 0x001E03D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC51 RID: 52305 RVA: 0x001E220F File Offset: 0x001E040F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CC52 RID: 52306 RVA: 0x001E221C File Offset: 0x001E041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC53 RID: 52307 RVA: 0x001E2225 File Offset: 0x001E0425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC54 RID: 52308 RVA: 0x001E2258 File Offset: 0x001E0458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x001E2296 File Offset: 0x001E0496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifePointChallengeStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x001E22C7 File Offset: 0x001E04C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x001E22D0 File Offset: 0x001E04D0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056FC RID: 22268
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056FD RID: 22269
		public const int IdFieldNumber = 3;

		// Token: 0x040056FE RID: 22270
		private int id_;
	}
}
