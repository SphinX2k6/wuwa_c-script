using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200170A RID: 5898
	[NetMessage(EMessageId.CombatSendPackRequest)]
	public sealed class CombatSendPackRequest : IMessage<CombatSendPackRequest>, IMessage, IEquatable<CombatSendPackRequest>, IDeepCloneable<CombatSendPackRequest>, IBufferMessage
	{
		// Token: 0x0601D9A6 RID: 121254 RVA: 0x00457389 File Offset: 0x00455589
		[NullableContext(1)]
		public static CombatSendPackRequest Create()
		{
			return new CombatSendPackRequest();
		}

		// Token: 0x170064BF RID: 25791
		// (get) Token: 0x0601D9A7 RID: 121255 RVA: 0x00457390 File Offset: 0x00455590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064C0 RID: 25792
		// (get) Token: 0x0601D9A8 RID: 121256 RVA: 0x00457393 File Offset: 0x00455593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatSendPackRequest.Descriptor;
			}
		}

		// Token: 0x0601D9A9 RID: 121257 RVA: 0x0045739A File Offset: 0x0045559A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackRequest()
		{
		}

		// Token: 0x0601D9AA RID: 121258 RVA: 0x004573AD File Offset: 0x004555AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackRequest(CombatSendPackRequest other) : this()
		{
			this.data_ = other.data_.Clone();
			this.hostPlayerId_ = other.hostPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D9AB RID: 121259 RVA: 0x004573E3 File Offset: 0x004555E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatSendPackRequest Clone()
		{
			return new CombatSendPackRequest(this);
		}

		// Token: 0x170064C1 RID: 25793
		// (get) Token: 0x0601D9AC RID: 121260 RVA: 0x004573EB File Offset: 0x004555EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombatSendData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x170064C2 RID: 25794
		// (get) Token: 0x0601D9AD RID: 121261 RVA: 0x004573F3 File Offset: 0x004555F3
		// (set) Token: 0x0601D9AE RID: 121262 RVA: 0x004573FB File Offset: 0x004555FB
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

		// Token: 0x0601D9AF RID: 121263 RVA: 0x00457404 File Offset: 0x00455604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatSendPackRequest);
		}

		// Token: 0x0601D9B0 RID: 121264 RVA: 0x00457414 File Offset: 0x00455614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatSendPackRequest other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && this.HostPlayerId == other.HostPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D9B1 RID: 121265 RVA: 0x00457464 File Offset: 0x00455664
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

		// Token: 0x0601D9B2 RID: 121266 RVA: 0x004574B1 File Offset: 0x004556B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D9B3 RID: 121267 RVA: 0x004574BE File Offset: 0x004556BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D9B4 RID: 121268 RVA: 0x004574C8 File Offset: 0x004556C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HostPlayerId);
			}
			this.data_.WriteTo(ref output, CombatSendPackRequest._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D9B5 RID: 121269 RVA: 0x00457518 File Offset: 0x00455718
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

		// Token: 0x0601D9B6 RID: 121270 RVA: 0x0045756C File Offset: 0x0045576C
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

		// Token: 0x0601D9B7 RID: 121271 RVA: 0x004575B9 File Offset: 0x004557B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D9B8 RID: 121272 RVA: 0x004575C4 File Offset: 0x004557C4
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
					if (num != 90U)
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

		// Token: 0x0400C881 RID: 51329
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C882 RID: 51330
		public const int DataFieldNumber = 11;

		// Token: 0x0400C883 RID: 51331
		private static readonly FieldCodec<CombatSendData> _repeated_data_codec = FieldCodec.ForMessage<CombatSendData>(90U, CombatSendData.Parser);

		// Token: 0x0400C884 RID: 51332
		private readonly RepeatedField<CombatSendData> data_ = new RepeatedField<CombatSendData>();

		// Token: 0x0400C885 RID: 51333
		public const int HostPlayerIdFieldNumber = 10;

		// Token: 0x0400C886 RID: 51334
		private int hostPlayerId_;
	}
}
