using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000048 RID: 72
	[NetMessage(EMessageId.AbyssSelfPassRequest)]
	public sealed class AbyssSelfPassRequest : IMessage<AbyssSelfPassRequest>, IMessage, IEquatable<AbyssSelfPassRequest>, IDeepCloneable<AbyssSelfPassRequest>, IBufferMessage
	{
		// Token: 0x0600145B RID: 5211 RVA: 0x000369B9 File Offset: 0x00034BB9
		[NullableContext(1)]
		public static AbyssSelfPassRequest Create()
		{
			return new AbyssSelfPassRequest();
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x000369C0 File Offset: 0x00034BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x000369C3 File Offset: 0x00034BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssSelfPassRequest.Descriptor;
			}
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000369CA File Offset: 0x00034BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassRequest()
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000369D2 File Offset: 0x00034BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassRequest(AbyssSelfPassRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000369F7 File Offset: 0x00034BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssSelfPassRequest Clone()
		{
			return new AbyssSelfPassRequest(this);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x000369FF File Offset: 0x00034BFF
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00036A07 File Offset: 0x00034C07
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

		// Token: 0x06001463 RID: 5219 RVA: 0x00036A10 File Offset: 0x00034C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssSelfPassRequest);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00036A1E File Offset: 0x00034C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssSelfPassRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00036A4C File Offset: 0x00034C4C
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

		// Token: 0x06001466 RID: 5222 RVA: 0x00036A8B File Offset: 0x00034C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00036A98 File Offset: 0x00034C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00036AA1 File Offset: 0x00034CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00036AD4 File Offset: 0x00034CD4
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

		// Token: 0x0600146A RID: 5226 RVA: 0x00036B12 File Offset: 0x00034D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssSelfPassRequest other)
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

		// Token: 0x0600146B RID: 5227 RVA: 0x00036B43 File Offset: 0x00034D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00036B4C File Offset: 0x00034D4C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400209D RID: 8349
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400209E RID: 8350
		public const int IdFieldNumber = 13;

		// Token: 0x0400209F RID: 8351
		private int id_;
	}
}
