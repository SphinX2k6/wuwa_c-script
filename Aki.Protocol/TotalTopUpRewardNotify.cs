using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138D RID: 5005
	[NetMessage(EMessageId.TotalTopUpRewardNotify)]
	public sealed class TotalTopUpRewardNotify : IMessage<TotalTopUpRewardNotify>, IMessage, IEquatable<TotalTopUpRewardNotify>, IDeepCloneable<TotalTopUpRewardNotify>, IBufferMessage
	{
		// Token: 0x0601A900 RID: 108800 RVA: 0x003DAA78 File Offset: 0x003D8C78
		[NullableContext(1)]
		public static TotalTopUpRewardNotify Create()
		{
			return new TotalTopUpRewardNotify();
		}

		// Token: 0x17005991 RID: 22929
		// (get) Token: 0x0601A901 RID: 108801 RVA: 0x003DAA7F File Offset: 0x003D8C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005992 RID: 22930
		// (get) Token: 0x0601A902 RID: 108802 RVA: 0x003DAA82 File Offset: 0x003D8C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardNotify.Descriptor;
			}
		}

		// Token: 0x0601A903 RID: 108803 RVA: 0x003DAA89 File Offset: 0x003D8C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardNotify()
		{
		}

		// Token: 0x0601A904 RID: 108804 RVA: 0x003DAA9C File Offset: 0x003D8C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardNotify(TotalTopUpRewardNotify other) : this()
		{
			this.totalTopUpRewardInfo_ = other.totalTopUpRewardInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A905 RID: 108805 RVA: 0x003DAAC6 File Offset: 0x003D8CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardNotify Clone()
		{
			return new TotalTopUpRewardNotify(this);
		}

		// Token: 0x17005993 RID: 22931
		// (get) Token: 0x0601A906 RID: 108806 RVA: 0x003DAACE File Offset: 0x003D8CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TotalTopUpRewardInfo> TotalTopUpRewardInfo
		{
			get
			{
				return this.totalTopUpRewardInfo_;
			}
		}

		// Token: 0x0601A907 RID: 108807 RVA: 0x003DAAD6 File Offset: 0x003D8CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardNotify);
		}

		// Token: 0x0601A908 RID: 108808 RVA: 0x003DAAE4 File Offset: 0x003D8CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardNotify other)
		{
			return other != null && (other == this || (this.totalTopUpRewardInfo_.Equals(other.totalTopUpRewardInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A909 RID: 108809 RVA: 0x003DAB18 File Offset: 0x003D8D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.totalTopUpRewardInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A90A RID: 108810 RVA: 0x003DAB4C File Offset: 0x003D8D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A90B RID: 108811 RVA: 0x003DAB59 File Offset: 0x003D8D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A90C RID: 108812 RVA: 0x003DAB62 File Offset: 0x003D8D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.totalTopUpRewardInfo_.WriteTo(ref output, TotalTopUpRewardNotify._repeated_totalTopUpRewardInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A90D RID: 108813 RVA: 0x003DAB8C File Offset: 0x003D8D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.totalTopUpRewardInfo_.CalculateSize(TotalTopUpRewardNotify._repeated_totalTopUpRewardInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A90E RID: 108814 RVA: 0x003DABC5 File Offset: 0x003D8DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.totalTopUpRewardInfo_.Add(other.totalTopUpRewardInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A90F RID: 108815 RVA: 0x003DABF3 File Offset: 0x003D8DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A910 RID: 108816 RVA: 0x003DABFC File Offset: 0x003D8DFC
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.totalTopUpRewardInfo_.AddEntriesFrom(ref input, TotalTopUpRewardNotify._repeated_totalTopUpRewardInfo_codec);
				}
			}
		}

		// Token: 0x04009A6E RID: 39534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A6F RID: 39535
		public const int TotalTopUpRewardInfoFieldNumber = 5;

		// Token: 0x04009A70 RID: 39536
		private static readonly FieldCodec<TotalTopUpRewardInfo> _repeated_totalTopUpRewardInfo_codec = FieldCodec.ForMessage<TotalTopUpRewardInfo>(42U, Aki.Protocol.TotalTopUpRewardInfo.Parser);

		// Token: 0x04009A71 RID: 39537
		private readonly RepeatedField<TotalTopUpRewardInfo> totalTopUpRewardInfo_ = new RepeatedField<TotalTopUpRewardInfo>();
	}
}
