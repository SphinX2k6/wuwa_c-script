using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001579 RID: 5497
	[NetMessage(EMessageId.WeatherSwitchInfoResponse)]
	public sealed class WeatherSwitchInfoResponse : IMessage<WeatherSwitchInfoResponse>, IMessage, IEquatable<WeatherSwitchInfoResponse>, IDeepCloneable<WeatherSwitchInfoResponse>, IBufferMessage
	{
		// Token: 0x0601D1A9 RID: 119209 RVA: 0x00436DBE File Offset: 0x00434FBE
		[NullableContext(1)]
		public static WeatherSwitchInfoResponse Create()
		{
			return new WeatherSwitchInfoResponse();
		}

		// Token: 0x17006275 RID: 25205
		// (get) Token: 0x0601D1AA RID: 119210 RVA: 0x00436DC5 File Offset: 0x00434FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006276 RID: 25206
		// (get) Token: 0x0601D1AB RID: 119211 RVA: 0x00436DC8 File Offset: 0x00434FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherSwitchInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601D1AC RID: 119212 RVA: 0x00436DCF File Offset: 0x00434FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoResponse()
		{
		}

		// Token: 0x0601D1AD RID: 119213 RVA: 0x00436DE2 File Offset: 0x00434FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoResponse(WeatherSwitchInfoResponse other) : this()
		{
			this.unlockedSwitchIds_ = other.unlockedSwitchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1AE RID: 119214 RVA: 0x00436E0C File Offset: 0x0043500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoResponse Clone()
		{
			return new WeatherSwitchInfoResponse(this);
		}

		// Token: 0x17006277 RID: 25207
		// (get) Token: 0x0601D1AF RID: 119215 RVA: 0x00436E14 File Offset: 0x00435014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedSwitchIds
		{
			get
			{
				return this.unlockedSwitchIds_;
			}
		}

		// Token: 0x0601D1B0 RID: 119216 RVA: 0x00436E1C File Offset: 0x0043501C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherSwitchInfoResponse);
		}

		// Token: 0x0601D1B1 RID: 119217 RVA: 0x00436E2A File Offset: 0x0043502A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherSwitchInfoResponse other)
		{
			return other != null && (other == this || (this.unlockedSwitchIds_.Equals(other.unlockedSwitchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1B2 RID: 119218 RVA: 0x00436E60 File Offset: 0x00435060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedSwitchIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D1B3 RID: 119219 RVA: 0x00436E94 File Offset: 0x00435094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1B4 RID: 119220 RVA: 0x00436EA1 File Offset: 0x004350A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1B5 RID: 119221 RVA: 0x00436EAA File Offset: 0x004350AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedSwitchIds_.WriteTo(ref output, WeatherSwitchInfoResponse._repeated_unlockedSwitchIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D1B6 RID: 119222 RVA: 0x00436ED4 File Offset: 0x004350D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedSwitchIds_.CalculateSize(WeatherSwitchInfoResponse._repeated_unlockedSwitchIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D1B7 RID: 119223 RVA: 0x00436F0D File Offset: 0x0043510D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeatherSwitchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedSwitchIds_.Add(other.unlockedSwitchIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D1B8 RID: 119224 RVA: 0x00436F3B File Offset: 0x0043513B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1B9 RID: 119225 RVA: 0x00436F44 File Offset: 0x00435144
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedSwitchIds_.AddEntriesFrom(ref input, WeatherSwitchInfoResponse._repeated_unlockedSwitchIds_codec);
				}
			}
		}

		// Token: 0x0400A717 RID: 42775
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A718 RID: 42776
		public const int UnlockedSwitchIdsFieldNumber = 14;

		// Token: 0x0400A719 RID: 42777
		private static readonly FieldCodec<int> _repeated_unlockedSwitchIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400A71A RID: 42778
		private readonly RepeatedField<int> unlockedSwitchIds_ = new RepeatedField<int>();
	}
}
