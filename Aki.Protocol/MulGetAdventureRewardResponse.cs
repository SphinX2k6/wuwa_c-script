using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADF RID: 2783
	[NetMessage(EMessageId.MulGetAdventureRewardResponse)]
	public sealed class MulGetAdventureRewardResponse : IMessage<MulGetAdventureRewardResponse>, IMessage, IEquatable<MulGetAdventureRewardResponse>, IDeepCloneable<MulGetAdventureRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F21D RID: 61981 RVA: 0x00235A79 File Offset: 0x00233C79
		[NullableContext(1)]
		public static MulGetAdventureRewardResponse Create()
		{
			return new MulGetAdventureRewardResponse();
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600F21E RID: 61982 RVA: 0x00235A80 File Offset: 0x00233C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600F21F RID: 61983 RVA: 0x00235A83 File Offset: 0x00233C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulGetAdventureRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F220 RID: 61984 RVA: 0x00235A8A File Offset: 0x00233C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardResponse()
		{
		}

		// Token: 0x0600F221 RID: 61985 RVA: 0x00235A9D File Offset: 0x00233C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardResponse(MulGetAdventureRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F222 RID: 61986 RVA: 0x00235AD3 File Offset: 0x00233CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulGetAdventureRewardResponse Clone()
		{
			return new MulGetAdventureRewardResponse(this);
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600F223 RID: 61987 RVA: 0x00235ADB File Offset: 0x00233CDB
		// (set) Token: 0x0600F224 RID: 61988 RVA: 0x00235AE3 File Offset: 0x00233CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600F225 RID: 61989 RVA: 0x00235AEC File Offset: 0x00233CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			get
			{
				return this.id_;
			}
		}

		// Token: 0x0600F226 RID: 61990 RVA: 0x00235AF4 File Offset: 0x00233CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulGetAdventureRewardResponse);
		}

		// Token: 0x0600F227 RID: 61991 RVA: 0x00235B04 File Offset: 0x00233D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulGetAdventureRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.id_.Equals(other.id_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F228 RID: 61992 RVA: 0x00235B54 File Offset: 0x00233D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.id_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F229 RID: 61993 RVA: 0x00235BA7 File Offset: 0x00233DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F22A RID: 61994 RVA: 0x00235BB4 File Offset: 0x00233DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F22B RID: 61995 RVA: 0x00235BC0 File Offset: 0x00233DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			this.id_.WriteTo(ref output, MulGetAdventureRewardResponse._repeated_id_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F22C RID: 61996 RVA: 0x00235C10 File Offset: 0x00233E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.id_.CalculateSize(MulGetAdventureRewardResponse._repeated_id_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F22D RID: 61997 RVA: 0x00235C64 File Offset: 0x00233E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulGetAdventureRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.id_.Add(other.id_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F22E RID: 61998 RVA: 0x00235CB1 File Offset: 0x00233EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F22F RID: 61999 RVA: 0x00235CBC File Offset: 0x00233EBC
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
				if (num != 32U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.id_.AddEntriesFrom(ref input, MulGetAdventureRewardResponse._repeated_id_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040061B6 RID: 25014
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061B7 RID: 25015
		public const int CodeFieldNumber = 4;

		// Token: 0x040061B8 RID: 25016
		private ErrorCode code_;

		// Token: 0x040061B9 RID: 25017
		public const int IdFieldNumber = 6;

		// Token: 0x040061BA RID: 25018
		private static readonly FieldCodec<int> _repeated_id_codec = FieldCodec.ForInt32(50U);

		// Token: 0x040061BB RID: 25019
		private readonly RepeatedField<int> id_ = new RepeatedField<int>();
	}
}
