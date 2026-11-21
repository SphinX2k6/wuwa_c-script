using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001098 RID: 4248
	[NetMessage(EMessageId.RoleSexChangeRequest)]
	public sealed class RoleSexChangeRequest : IMessage<RoleSexChangeRequest>, IMessage, IEquatable<RoleSexChangeRequest>, IDeepCloneable<RoleSexChangeRequest>, IBufferMessage
	{
		// Token: 0x06016B70 RID: 93040 RVA: 0x0034DB55 File Offset: 0x0034BD55
		[NullableContext(1)]
		public static RoleSexChangeRequest Create()
		{
			return new RoleSexChangeRequest();
		}

		// Token: 0x17004C23 RID: 19491
		// (get) Token: 0x06016B71 RID: 93041 RVA: 0x0034DB5C File Offset: 0x0034BD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C24 RID: 19492
		// (get) Token: 0x06016B72 RID: 93042 RVA: 0x0034DB5F File Offset: 0x0034BD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSexChangeRequest.Descriptor;
			}
		}

		// Token: 0x06016B73 RID: 93043 RVA: 0x0034DB66 File Offset: 0x0034BD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeRequest()
		{
		}

		// Token: 0x06016B74 RID: 93044 RVA: 0x0034DB6E File Offset: 0x0034BD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeRequest(RoleSexChangeRequest other) : this()
		{
			this.sex_ = other.sex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B75 RID: 93045 RVA: 0x0034DB93 File Offset: 0x0034BD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeRequest Clone()
		{
			return new RoleSexChangeRequest(this);
		}

		// Token: 0x17004C25 RID: 19493
		// (get) Token: 0x06016B76 RID: 93046 RVA: 0x0034DB9B File Offset: 0x0034BD9B
		// (set) Token: 0x06016B77 RID: 93047 RVA: 0x0034DBA3 File Offset: 0x0034BDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sex
		{
			get
			{
				return this.sex_;
			}
			set
			{
				this.sex_ = value;
			}
		}

		// Token: 0x06016B78 RID: 93048 RVA: 0x0034DBAC File Offset: 0x0034BDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSexChangeRequest);
		}

		// Token: 0x06016B79 RID: 93049 RVA: 0x0034DBBA File Offset: 0x0034BDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSexChangeRequest other)
		{
			return other != null && (other == this || (this.Sex == other.Sex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B7A RID: 93050 RVA: 0x0034DBE8 File Offset: 0x0034BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Sex != 0)
			{
				num ^= this.Sex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B7B RID: 93051 RVA: 0x0034DC27 File Offset: 0x0034BE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B7C RID: 93052 RVA: 0x0034DC34 File Offset: 0x0034BE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B7D RID: 93053 RVA: 0x0034DC3D File Offset: 0x0034BE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Sex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Sex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B7E RID: 93054 RVA: 0x0034DC70 File Offset: 0x0034BE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Sex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B7F RID: 93055 RVA: 0x0034DCAE File Offset: 0x0034BEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSexChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Sex != 0)
			{
				this.Sex = other.Sex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B80 RID: 93056 RVA: 0x0034DCDF File Offset: 0x0034BEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B81 RID: 93057 RVA: 0x0034DCE8 File Offset: 0x0034BEE8
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Sex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008824 RID: 34852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008825 RID: 34853
		public const int SexFieldNumber = 7;

		// Token: 0x04008826 RID: 34854
		private int sex_;
	}
}
