using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD9 RID: 2777
	[NetMessage(EMessageId.MulCorniceMeetingRewardResponse)]
	public sealed class MulCorniceMeetingRewardResponse : IMessage<MulCorniceMeetingRewardResponse>, IMessage, IEquatable<MulCorniceMeetingRewardResponse>, IDeepCloneable<MulCorniceMeetingRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F1AD RID: 61869 RVA: 0x00234D76 File Offset: 0x00232F76
		[NullableContext(1)]
		public static MulCorniceMeetingRewardResponse Create()
		{
			return new MulCorniceMeetingRewardResponse();
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0600F1AE RID: 61870 RVA: 0x00234D7D File Offset: 0x00232F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600F1AF RID: 61871 RVA: 0x00234D80 File Offset: 0x00232F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCorniceMeetingRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F1B0 RID: 61872 RVA: 0x00234D87 File Offset: 0x00232F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardResponse()
		{
		}

		// Token: 0x0600F1B1 RID: 61873 RVA: 0x00234D9A File Offset: 0x00232F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardResponse(MulCorniceMeetingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.corniceMeetingRewardScoreLists_ = other.corniceMeetingRewardScoreLists_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1B2 RID: 61874 RVA: 0x00234DD0 File Offset: 0x00232FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCorniceMeetingRewardResponse Clone()
		{
			return new MulCorniceMeetingRewardResponse(this);
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600F1B3 RID: 61875 RVA: 0x00234DD8 File Offset: 0x00232FD8
		// (set) Token: 0x0600F1B4 RID: 61876 RVA: 0x00234DE0 File Offset: 0x00232FE0
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

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600F1B5 RID: 61877 RVA: 0x00234DE9 File Offset: 0x00232FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, CorniceMeetingRewardScoreList> CorniceMeetingRewardScoreLists
		{
			get
			{
				return this.corniceMeetingRewardScoreLists_;
			}
		}

		// Token: 0x0600F1B6 RID: 61878 RVA: 0x00234DF1 File Offset: 0x00232FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCorniceMeetingRewardResponse);
		}

		// Token: 0x0600F1B7 RID: 61879 RVA: 0x00234E00 File Offset: 0x00233000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCorniceMeetingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CorniceMeetingRewardScoreLists.Equals(other.CorniceMeetingRewardScoreLists) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1B8 RID: 61880 RVA: 0x00234E50 File Offset: 0x00233050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.CorniceMeetingRewardScoreLists.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F1B9 RID: 61881 RVA: 0x00234EA3 File Offset: 0x002330A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1BA RID: 61882 RVA: 0x00234EB0 File Offset: 0x002330B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1BB RID: 61883 RVA: 0x00234EBC File Offset: 0x002330BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.corniceMeetingRewardScoreLists_.WriteTo(ref output, MulCorniceMeetingRewardResponse._map_corniceMeetingRewardScoreLists_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1BC RID: 61884 RVA: 0x00234F0C File Offset: 0x0023310C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.corniceMeetingRewardScoreLists_.CalculateSize(MulCorniceMeetingRewardResponse._map_corniceMeetingRewardScoreLists_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F1BD RID: 61885 RVA: 0x00234F60 File Offset: 0x00233160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulCorniceMeetingRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.corniceMeetingRewardScoreLists_.MergeFrom(other.corniceMeetingRewardScoreLists_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F1BE RID: 61886 RVA: 0x00234FAD File Offset: 0x002331AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1BF RID: 61887 RVA: 0x00234FB8 File Offset: 0x002331B8
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
				if (num != 10U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.corniceMeetingRewardScoreLists_.AddEntriesFrom(ref input, MulCorniceMeetingRewardResponse._map_corniceMeetingRewardScoreLists_codec);
				}
			}
		}

		// Token: 0x0400619B RID: 24987
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400619C RID: 24988
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400619D RID: 24989
		private ErrorCode errorCode_;

		// Token: 0x0400619E RID: 24990
		public const int CorniceMeetingRewardScoreListsFieldNumber = 1;

		// Token: 0x0400619F RID: 24991
		private static readonly MapField<int, CorniceMeetingRewardScoreList>.Codec _map_corniceMeetingRewardScoreLists_codec = new MapField<int, CorniceMeetingRewardScoreList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<CorniceMeetingRewardScoreList>(18U, CorniceMeetingRewardScoreList.Parser), 10U);

		// Token: 0x040061A0 RID: 24992
		private readonly MapField<int, CorniceMeetingRewardScoreList> corniceMeetingRewardScoreLists_ = new MapField<int, CorniceMeetingRewardScoreList>();
	}
}
