using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6A RID: 3178
	[NetMessage(EMessageId.PhantomBattleDebugInfoResponse)]
	public sealed class PhantomBattleDebugInfoResponse : IMessage<PhantomBattleDebugInfoResponse>, IMessage, IEquatable<PhantomBattleDebugInfoResponse>, IDeepCloneable<PhantomBattleDebugInfoResponse>, IBufferMessage
	{
		// Token: 0x06011402 RID: 70658 RVA: 0x002871B6 File Offset: 0x002853B6
		[NullableContext(1)]
		public static PhantomBattleDebugInfoResponse Create()
		{
			return new PhantomBattleDebugInfoResponse();
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x06011403 RID: 70659 RVA: 0x002871BD File Offset: 0x002853BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x06011404 RID: 70660 RVA: 0x002871C0 File Offset: 0x002853C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugInfoResponse.Descriptor;
			}
		}

		// Token: 0x06011405 RID: 70661 RVA: 0x002871C7 File Offset: 0x002853C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoResponse()
		{
		}

		// Token: 0x06011406 RID: 70662 RVA: 0x002871DA File Offset: 0x002853DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoResponse(PhantomBattleDebugInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleDebugGamerInfos_ = other.phantomBattleDebugGamerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011407 RID: 70663 RVA: 0x00287210 File Offset: 0x00285410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoResponse Clone()
		{
			return new PhantomBattleDebugInfoResponse(this);
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x06011408 RID: 70664 RVA: 0x00287218 File Offset: 0x00285418
		// (set) Token: 0x06011409 RID: 70665 RVA: 0x00287220 File Offset: 0x00285420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0601140A RID: 70666 RVA: 0x00287229 File Offset: 0x00285429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleDebugGamerInfo> PhantomBattleDebugGamerInfos
		{
			get
			{
				return this.phantomBattleDebugGamerInfos_;
			}
		}

		// Token: 0x0601140B RID: 70667 RVA: 0x00287231 File Offset: 0x00285431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugInfoResponse);
		}

		// Token: 0x0601140C RID: 70668 RVA: 0x00287240 File Offset: 0x00285440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleDebugGamerInfos_.Equals(other.phantomBattleDebugGamerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601140D RID: 70669 RVA: 0x00287290 File Offset: 0x00285490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomBattleDebugGamerInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601140E RID: 70670 RVA: 0x002872E3 File Offset: 0x002854E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601140F RID: 70671 RVA: 0x002872F0 File Offset: 0x002854F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011410 RID: 70672 RVA: 0x002872FC File Offset: 0x002854FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomBattleDebugGamerInfos_.WriteTo(ref output, PhantomBattleDebugInfoResponse._repeated_phantomBattleDebugGamerInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011411 RID: 70673 RVA: 0x0028734C File Offset: 0x0028554C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomBattleDebugGamerInfos_.CalculateSize(PhantomBattleDebugInfoResponse._repeated_phantomBattleDebugGamerInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011412 RID: 70674 RVA: 0x002873A0 File Offset: 0x002855A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomBattleDebugGamerInfos_.Add(other.phantomBattleDebugGamerInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011413 RID: 70675 RVA: 0x002873ED File Offset: 0x002855ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011414 RID: 70676 RVA: 0x002873F8 File Offset: 0x002855F8
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
				if (num != 48U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomBattleDebugGamerInfos_.AddEntriesFrom(ref input, PhantomBattleDebugInfoResponse._repeated_phantomBattleDebugGamerInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006D8B RID: 28043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D8C RID: 28044
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006D8D RID: 28045
		private ErrorCode errorCode_;

		// Token: 0x04006D8E RID: 28046
		public const int PhantomBattleDebugGamerInfosFieldNumber = 11;

		// Token: 0x04006D8F RID: 28047
		private static readonly FieldCodec<PhantomBattleDebugGamerInfo> _repeated_phantomBattleDebugGamerInfos_codec = FieldCodec.ForMessage<PhantomBattleDebugGamerInfo>(90U, PhantomBattleDebugGamerInfo.Parser);

		// Token: 0x04006D90 RID: 28048
		private readonly RepeatedField<PhantomBattleDebugGamerInfo> phantomBattleDebugGamerInfos_ = new RepeatedField<PhantomBattleDebugGamerInfo>();
	}
}
