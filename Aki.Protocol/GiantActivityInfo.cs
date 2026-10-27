using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D5 RID: 1749
	public sealed class GiantActivityInfo : IMessage<GiantActivityInfo>, IMessage, IEquatable<GiantActivityInfo>, IDeepCloneable<GiantActivityInfo>, IBufferMessage
	{
		// Token: 0x06009FBC RID: 40892 RVA: 0x00182EF5 File Offset: 0x001810F5
		[NullableContext(1)]
		public static GiantActivityInfo Create()
		{
			return new GiantActivityInfo();
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06009FBD RID: 40893 RVA: 0x00182EFC File Offset: 0x001810FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06009FBE RID: 40894 RVA: 0x00182EFF File Offset: 0x001810FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantActivityInfo.Descriptor;
			}
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x00182F06 File Offset: 0x00181106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityInfo()
		{
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x00182F24 File Offset: 0x00181124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityInfo(GiantActivityInfo other) : this()
		{
			this.totalStableValue_ = other.totalStableValue_;
			this.gotRewardIds_ = other.gotRewardIds_.Clone();
			this.activeIds_ = other.activeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x00182F76 File Offset: 0x00181176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantActivityInfo Clone()
		{
			return new GiantActivityInfo(this);
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06009FC2 RID: 40898 RVA: 0x00182F7E File Offset: 0x0018117E
		// (set) Token: 0x06009FC3 RID: 40899 RVA: 0x00182F86 File Offset: 0x00181186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalStableValue
		{
			get
			{
				return this.totalStableValue_;
			}
			set
			{
				this.totalStableValue_ = value;
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06009FC4 RID: 40900 RVA: 0x00182F8F File Offset: 0x0018118F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GotRewardIds
		{
			get
			{
				return this.gotRewardIds_;
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x00182F97 File Offset: 0x00181197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActiveIds
		{
			get
			{
				return this.activeIds_;
			}
		}

		// Token: 0x06009FC6 RID: 40902 RVA: 0x00182F9F File Offset: 0x0018119F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantActivityInfo);
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x00182FB0 File Offset: 0x001811B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantActivityInfo other)
		{
			return other != null && (other == this || (this.TotalStableValue == other.TotalStableValue && this.gotRewardIds_.Equals(other.gotRewardIds_) && this.activeIds_.Equals(other.activeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x00183014 File Offset: 0x00181214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalStableValue != 0)
			{
				num ^= this.TotalStableValue.GetHashCode();
			}
			num ^= this.gotRewardIds_.GetHashCode();
			num ^= this.activeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x0018306F File Offset: 0x0018126F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x0018307C File Offset: 0x0018127C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x00183088 File Offset: 0x00181288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalStableValue != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TotalStableValue);
			}
			this.gotRewardIds_.WriteTo(ref output, GiantActivityInfo._repeated_gotRewardIds_codec);
			this.activeIds_.WriteTo(ref output, GiantActivityInfo._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x001830E8 File Offset: 0x001812E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalStableValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalStableValue);
			}
			num += this.gotRewardIds_.CalculateSize(GiantActivityInfo._repeated_gotRewardIds_codec);
			num += this.activeIds_.CalculateSize(GiantActivityInfo._repeated_activeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x0018314C File Offset: 0x0018134C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalStableValue != 0)
			{
				this.TotalStableValue = other.TotalStableValue;
			}
			this.gotRewardIds_.Add(other.gotRewardIds_);
			this.activeIds_.Add(other.activeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FCE RID: 40910 RVA: 0x001831AA File Offset: 0x001813AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x001831B4 File Offset: 0x001813B4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.TotalStableValue = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U || num == 26U)
					{
						this.activeIds_.AddEntriesFrom(ref input, GiantActivityInfo._repeated_activeIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.gotRewardIds_.AddEntriesFrom(ref input, GiantActivityInfo._repeated_gotRewardIds_codec);
			}
		}

		// Token: 0x04004A79 RID: 19065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A7A RID: 19066
		public const int TotalStableValueFieldNumber = 1;

		// Token: 0x04004A7B RID: 19067
		private int totalStableValue_;

		// Token: 0x04004A7C RID: 19068
		public const int GotRewardIdsFieldNumber = 2;

		// Token: 0x04004A7D RID: 19069
		private static readonly FieldCodec<int> _repeated_gotRewardIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004A7E RID: 19070
		private readonly RepeatedField<int> gotRewardIds_ = new RepeatedField<int>();

		// Token: 0x04004A7F RID: 19071
		public const int ActiveIdsFieldNumber = 3;

		// Token: 0x04004A80 RID: 19072
		private static readonly FieldCodec<int> _repeated_activeIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004A81 RID: 19073
		private readonly RepeatedField<int> activeIds_ = new RepeatedField<int>();
	}
}
