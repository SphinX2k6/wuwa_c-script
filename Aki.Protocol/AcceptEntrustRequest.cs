using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004C RID: 76
	[NetMessage(EMessageId.AcceptEntrustRequest)]
	public sealed class AcceptEntrustRequest : IMessage<AcceptEntrustRequest>, IMessage, IEquatable<AcceptEntrustRequest>, IDeepCloneable<AcceptEntrustRequest>, IBufferMessage
	{
		// Token: 0x0600147A RID: 5242 RVA: 0x00036C29 File Offset: 0x00034E29
		[NullableContext(1)]
		public static AcceptEntrustRequest Create()
		{
			return new AcceptEntrustRequest();
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x00036C30 File Offset: 0x00034E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00036C33 File Offset: 0x00034E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptEntrustRequest.Descriptor;
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00036C3A File Offset: 0x00034E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustRequest()
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00036C4D File Offset: 0x00034E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustRequest(AcceptEntrustRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00036C83 File Offset: 0x00034E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustRequest Clone()
		{
			return new AcceptEntrustRequest(this);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00036C8B File Offset: 0x00034E8B
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00036C93 File Offset: 0x00034E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00036C9C File Offset: 0x00034E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00036CA4 File Offset: 0x00034EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptEntrustRequest);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00036CB4 File Offset: 0x00034EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptEntrustRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00036D04 File Offset: 0x00034F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00036D51 File Offset: 0x00034F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x00036D5E File Offset: 0x00034F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00036D68 File Offset: 0x00034F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleIds_.WriteTo(ref output, AcceptEntrustRequest._repeated_roleIds_codec);
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00036DB8 File Offset: 0x00034FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			num += this.roleIds_.CalculateSize(AcceptEntrustRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00036E0C File Offset: 0x0003500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptEntrustRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00036E59 File Offset: 0x00035059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00036E64 File Offset: 0x00035064
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
				if (num != 40U && num != 42U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntrustId = input.ReadInt32();
					}
				}
				else
				{
					this.roleIds_.AddEntriesFrom(ref input, AcceptEntrustRequest._repeated_roleIds_codec);
				}
			}
		}

		// Token: 0x04002056 RID: 8278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002057 RID: 8279
		public const int EntrustIdFieldNumber = 13;

		// Token: 0x04002058 RID: 8280
		private int entrustId_;

		// Token: 0x04002059 RID: 8281
		public const int RoleIdsFieldNumber = 5;

		// Token: 0x0400205A RID: 8282
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400205B RID: 8283
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
