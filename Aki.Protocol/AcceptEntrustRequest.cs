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
		// Token: 0x060014A5 RID: 5285 RVA: 0x000371E1 File Offset: 0x000353E1
		[NullableContext(1)]
		public static AcceptEntrustRequest Create()
		{
			return new AcceptEntrustRequest();
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x000371E8 File Offset: 0x000353E8
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
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x000371EB File Offset: 0x000353EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptEntrustRequest.Descriptor;
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000371F2 File Offset: 0x000353F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustRequest()
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00037205 File Offset: 0x00035405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustRequest(AcceptEntrustRequest other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0003723B File Offset: 0x0003543B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustRequest Clone()
		{
			return new AcceptEntrustRequest(this);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00037243 File Offset: 0x00035443
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0003724B File Offset: 0x0003544B
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
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00037254 File Offset: 0x00035454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0003725C File Offset: 0x0003545C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptEntrustRequest);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0003726C File Offset: 0x0003546C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptEntrustRequest other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x000372BC File Offset: 0x000354BC
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

		// Token: 0x060014B1 RID: 5297 RVA: 0x00037309 File Offset: 0x00035509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00037316 File Offset: 0x00035516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00037320 File Offset: 0x00035520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleIds_.WriteTo(ref output, AcceptEntrustRequest._repeated_roleIds_codec);
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00037370 File Offset: 0x00035570
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

		// Token: 0x060014B5 RID: 5301 RVA: 0x000373C4 File Offset: 0x000355C4
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

		// Token: 0x060014B6 RID: 5302 RVA: 0x00037411 File Offset: 0x00035611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0003741C File Offset: 0x0003561C
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
				if (num != 32U && num != 34U)
				{
					if (num != 112U)
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

		// Token: 0x040020AC RID: 8364
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020AD RID: 8365
		public const int EntrustIdFieldNumber = 14;

		// Token: 0x040020AE RID: 8366
		private int entrustId_;

		// Token: 0x040020AF RID: 8367
		public const int RoleIdsFieldNumber = 4;

		// Token: 0x040020B0 RID: 8368
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040020B1 RID: 8369
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
