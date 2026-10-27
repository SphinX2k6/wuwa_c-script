using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200168E RID: 5774
	[NetMessage(EMessageId.CombatSendPackRequest)]
	public sealed class CombatSendPackRequest : IMessage<CombatSendPackRequest>, IMessage, IEquatable<CombatSendPackRequest>, IDeepCloneable<CombatSendPackRequest>, IBufferMessage
	{
		// Token: 0x0601CEDB RID: 118491 RVA: 0x0043B7DD File Offset: 0x004399DD
		[NullableContext(1)]
		public static CombatSendPackRequest Create()
		{
			return new CombatSendPackRequest();
		}

		// Token: 0x1700621C RID: 25116
		// (get) Token: 0x0601CEDC RID: 118492 RVA: 0x0043B7E4 File Offset: 0x004399E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700621D RID: 25117
		// (get) Token: 0x0601CEDD RID: 118493 RVA: 0x0043B7E7 File Offset: 0x004399E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatSendPackRequest.Descriptor;
			}
		}

		// Token: 0x0601CEDE RID: 118494 RVA: 0x0043B7EE File Offset: 0x004399EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackRequest()
		{
		}

		// Token: 0x0601CEDF RID: 118495 RVA: 0x0043B801 File Offset: 0x00439A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackRequest(CombatSendPackRequest other) : this()
		{
			this.data_ = other.data_.Clone();
			this.hostPlayerId_ = other.hostPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CEE0 RID: 118496 RVA: 0x0043B837 File Offset: 0x00439A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackRequest Clone()
		{
			return new CombatSendPackRequest(this);
		}

		// Token: 0x1700621E RID: 25118
		// (get) Token: 0x0601CEE1 RID: 118497 RVA: 0x0043B83F File Offset: 0x00439A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombatSendData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x1700621F RID: 25119
		// (get) Token: 0x0601CEE2 RID: 118498 RVA: 0x0043B847 File Offset: 0x00439A47
		// (set) Token: 0x0601CEE3 RID: 118499 RVA: 0x0043B84F File Offset: 0x00439A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x0601CEE4 RID: 118500 RVA: 0x0043B858 File Offset: 0x00439A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatSendPackRequest);
		}

		// Token: 0x0601CEE5 RID: 118501 RVA: 0x0043B868 File Offset: 0x00439A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatSendPackRequest other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && this.HostPlayerId == other.HostPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CEE6 RID: 118502 RVA: 0x0043B8B8 File Offset: 0x00439AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CEE7 RID: 118503 RVA: 0x0043B905 File Offset: 0x00439B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CEE8 RID: 118504 RVA: 0x0043B912 File Offset: 0x00439B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CEE9 RID: 118505 RVA: 0x0043B91C File Offset: 0x00439B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HostPlayerId);
			}
			this.data_.WriteTo(ref output, CombatSendPackRequest._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CEEA RID: 118506 RVA: 0x0043B96C File Offset: 0x00439B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(CombatSendPackRequest._repeated_data_codec);
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CEEB RID: 118507 RVA: 0x0043B9C0 File Offset: 0x00439BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatSendPackRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CEEC RID: 118508 RVA: 0x0043BA0D File Offset: 0x00439C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CEED RID: 118509 RVA: 0x0043BA18 File Offset: 0x00439C18
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
				if (num != 64U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.data_.AddEntriesFrom(ref input, CombatSendPackRequest._repeated_data_codec);
					}
				}
				else
				{
					this.HostPlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400C356 RID: 50006
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C357 RID: 50007
		public const int DataFieldNumber = 14;

		// Token: 0x0400C358 RID: 50008
		private static readonly FieldCodec<CombatSendData> _repeated_data_codec = FieldCodec.ForMessage<CombatSendData>(114U, CombatSendData.Parser);

		// Token: 0x0400C359 RID: 50009
		private readonly RepeatedField<CombatSendData> data_ = new RepeatedField<CombatSendData>();

		// Token: 0x0400C35A RID: 50010
		public const int HostPlayerIdFieldNumber = 8;

		// Token: 0x0400C35B RID: 50011
		private int hostPlayerId_;
	}
}
