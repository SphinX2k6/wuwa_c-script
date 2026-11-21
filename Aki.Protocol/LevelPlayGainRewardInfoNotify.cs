using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EB RID: 2283
	[NetMessage(EMessageId.LevelPlayGainRewardInfoNotify)]
	public sealed class LevelPlayGainRewardInfoNotify : IMessage<LevelPlayGainRewardInfoNotify>, IMessage, IEquatable<LevelPlayGainRewardInfoNotify>, IDeepCloneable<LevelPlayGainRewardInfoNotify>, IBufferMessage
	{
		// Token: 0x0600CA1A RID: 51738 RVA: 0x001DD802 File Offset: 0x001DBA02
		[NullableContext(1)]
		public static LevelPlayGainRewardInfoNotify Create()
		{
			return new LevelPlayGainRewardInfoNotify();
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x0600CA1B RID: 51739 RVA: 0x001DD809 File Offset: 0x001DBA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600CA1C RID: 51740 RVA: 0x001DD80C File Offset: 0x001DBA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayGainRewardInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600CA1D RID: 51741 RVA: 0x001DD813 File Offset: 0x001DBA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfoNotify()
		{
		}

		// Token: 0x0600CA1E RID: 51742 RVA: 0x001DD826 File Offset: 0x001DBA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfoNotify(LevelPlayGainRewardInfoNotify other) : this()
		{
			this.gainRewardInfoDict_ = other.gainRewardInfoDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA1F RID: 51743 RVA: 0x001DD850 File Offset: 0x001DBA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfoNotify Clone()
		{
			return new LevelPlayGainRewardInfoNotify(this);
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600CA20 RID: 51744 RVA: 0x001DD858 File Offset: 0x001DBA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, LevelPlayGainRewardInfo> GainRewardInfoDict
		{
			get
			{
				return this.gainRewardInfoDict_;
			}
		}

		// Token: 0x0600CA21 RID: 51745 RVA: 0x001DD860 File Offset: 0x001DBA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayGainRewardInfoNotify);
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x001DD86E File Offset: 0x001DBA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayGainRewardInfoNotify other)
		{
			return other != null && (other == this || (this.GainRewardInfoDict.Equals(other.GainRewardInfoDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x001DD8A4 File Offset: 0x001DBAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.GainRewardInfoDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA24 RID: 51748 RVA: 0x001DD8D8 File Offset: 0x001DBAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA25 RID: 51749 RVA: 0x001DD8E5 File Offset: 0x001DBAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA26 RID: 51750 RVA: 0x001DD8EE File Offset: 0x001DBAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gainRewardInfoDict_.WriteTo(ref output, LevelPlayGainRewardInfoNotify._map_gainRewardInfoDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x001DD918 File Offset: 0x001DBB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gainRewardInfoDict_.CalculateSize(LevelPlayGainRewardInfoNotify._map_gainRewardInfoDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x001DD951 File Offset: 0x001DBB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayGainRewardInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gainRewardInfoDict_.MergeFrom(other.gainRewardInfoDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA29 RID: 51753 RVA: 0x001DD97F File Offset: 0x001DBB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x001DD988 File Offset: 0x001DBB88
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gainRewardInfoDict_.AddEntriesFrom(ref input, LevelPlayGainRewardInfoNotify._map_gainRewardInfoDict_codec);
				}
			}
		}

		// Token: 0x04005660 RID: 22112
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005661 RID: 22113
		public const int GainRewardInfoDictFieldNumber = 10;

		// Token: 0x04005662 RID: 22114
		private static readonly MapField<int, LevelPlayGainRewardInfo>.Codec _map_gainRewardInfoDict_codec = new MapField<int, LevelPlayGainRewardInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<LevelPlayGainRewardInfo>(18U, LevelPlayGainRewardInfo.Parser), 82U);

		// Token: 0x04005663 RID: 22115
		private readonly MapField<int, LevelPlayGainRewardInfo> gainRewardInfoDict_ = new MapField<int, LevelPlayGainRewardInfo>();
	}
}
