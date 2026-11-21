using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053B RID: 1339
	[NetMessage(EMessageId.FishingEntrustAcceptRequest)]
	public sealed class FishingEntrustAcceptRequest : IMessage<FishingEntrustAcceptRequest>, IMessage, IEquatable<FishingEntrustAcceptRequest>, IDeepCloneable<FishingEntrustAcceptRequest>, IBufferMessage
	{
		// Token: 0x06007DAF RID: 32175 RVA: 0x00130CD4 File Offset: 0x0012EED4
		[NullableContext(1)]
		public static FishingEntrustAcceptRequest Create()
		{
			return new FishingEntrustAcceptRequest();
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06007DB0 RID: 32176 RVA: 0x00130CDB File Offset: 0x0012EEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x00130CDE File Offset: 0x0012EEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustAcceptRequest.Descriptor;
			}
		}

		// Token: 0x06007DB2 RID: 32178 RVA: 0x00130CE5 File Offset: 0x0012EEE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptRequest()
		{
		}

		// Token: 0x06007DB3 RID: 32179 RVA: 0x00130CED File Offset: 0x0012EEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptRequest(FishingEntrustAcceptRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.accept_ = other.accept_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x00130D1E File Offset: 0x0012EF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptRequest Clone()
		{
			return new FishingEntrustAcceptRequest(this);
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x00130D26 File Offset: 0x0012EF26
		// (set) Token: 0x06007DB6 RID: 32182 RVA: 0x00130D2E File Offset: 0x0012EF2E
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

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06007DB7 RID: 32183 RVA: 0x00130D37 File Offset: 0x0012EF37
		// (set) Token: 0x06007DB8 RID: 32184 RVA: 0x00130D3F File Offset: 0x0012EF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accept
		{
			get
			{
				return this.accept_;
			}
			set
			{
				this.accept_ = value;
			}
		}

		// Token: 0x06007DB9 RID: 32185 RVA: 0x00130D48 File Offset: 0x0012EF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustAcceptRequest);
		}

		// Token: 0x06007DBA RID: 32186 RVA: 0x00130D56 File Offset: 0x0012EF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustAcceptRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.Accept == other.Accept && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DBB RID: 32187 RVA: 0x00130D94 File Offset: 0x0012EF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this.Accept)
			{
				num ^= this.Accept.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DBC RID: 32188 RVA: 0x00130DEC File Offset: 0x0012EFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x00130DF9 File Offset: 0x0012EFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x00130E04 File Offset: 0x0012F004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Accept)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Accept);
			}
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DBF RID: 32191 RVA: 0x00130E60 File Offset: 0x0012F060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this.Accept)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x00130EAC File Offset: 0x0012F0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustAcceptRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			if (other.Accept)
			{
				this.Accept = other.Accept;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x00130EFC File Offset: 0x0012F0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x00130F08 File Offset: 0x0012F108
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
				if (num != 80U)
				{
					if (num != 96U)
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
					this.Accept = input.ReadBool();
				}
			}
		}

		// Token: 0x04004043 RID: 16451
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004044 RID: 16452
		public const int EntrustIdFieldNumber = 12;

		// Token: 0x04004045 RID: 16453
		private int entrustId_;

		// Token: 0x04004046 RID: 16454
		public const int AcceptFieldNumber = 10;

		// Token: 0x04004047 RID: 16455
		private bool accept_;
	}
}
