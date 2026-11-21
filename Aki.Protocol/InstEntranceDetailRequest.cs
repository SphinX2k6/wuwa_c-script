using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080F RID: 2063
	[NetMessage(EMessageId.InstEntranceDetailRequest)]
	public sealed class InstEntranceDetailRequest : IMessage<InstEntranceDetailRequest>, IMessage, IEquatable<InstEntranceDetailRequest>, IDeepCloneable<InstEntranceDetailRequest>, IBufferMessage
	{
		// Token: 0x0600B8BE RID: 47294 RVA: 0x001B8191 File Offset: 0x001B6391
		[NullableContext(1)]
		public static InstEntranceDetailRequest Create()
		{
			return new InstEntranceDetailRequest();
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x0600B8BF RID: 47295 RVA: 0x001B8198 File Offset: 0x001B6398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x0600B8C0 RID: 47296 RVA: 0x001B819B File Offset: 0x001B639B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntranceDetailRequest.Descriptor;
			}
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x001B81A2 File Offset: 0x001B63A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailRequest()
		{
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x001B81AA File Offset: 0x001B63AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailRequest(InstEntranceDetailRequest other) : this()
		{
			this.entranceId_ = other.entranceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x001B81CF File Offset: 0x001B63CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailRequest Clone()
		{
			return new InstEntranceDetailRequest(this);
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x001B81D7 File Offset: 0x001B63D7
		// (set) Token: 0x0600B8C5 RID: 47301 RVA: 0x001B81DF File Offset: 0x001B63DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntranceId
		{
			get
			{
				return this.entranceId_;
			}
			set
			{
				this.entranceId_ = value;
			}
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x001B81E8 File Offset: 0x001B63E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntranceDetailRequest);
		}

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x001B81F6 File Offset: 0x001B63F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntranceDetailRequest other)
		{
			return other != null && (other == this || (this.EntranceId == other.EntranceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x001B8224 File Offset: 0x001B6424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntranceId != 0)
			{
				num ^= this.EntranceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x001B8263 File Offset: 0x001B6463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8CA RID: 47306 RVA: 0x001B8270 File Offset: 0x001B6470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x001B8279 File Offset: 0x001B6479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8CC RID: 47308 RVA: 0x001B82AC File Offset: 0x001B64AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntranceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B8CD RID: 47309 RVA: 0x001B82EA File Offset: 0x001B64EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstEntranceDetailRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntranceId != 0)
			{
				this.EntranceId = other.EntranceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x001B831B File Offset: 0x001B651B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x001B8324 File Offset: 0x001B6524
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntranceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040051A5 RID: 20901
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051A6 RID: 20902
		public const int EntranceIdFieldNumber = 11;

		// Token: 0x040051A7 RID: 20903
		private int entranceId_;
	}
}
