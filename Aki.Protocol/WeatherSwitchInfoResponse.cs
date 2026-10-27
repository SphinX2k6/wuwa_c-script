using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001503 RID: 5379
	[NetMessage(EMessageId.WeatherSwitchInfoResponse)]
	public sealed class WeatherSwitchInfoResponse : IMessage<WeatherSwitchInfoResponse>, IMessage, IEquatable<WeatherSwitchInfoResponse>, IDeepCloneable<WeatherSwitchInfoResponse>, IBufferMessage
	{
		// Token: 0x0601C6E2 RID: 116450 RVA: 0x0041B2FE File Offset: 0x004194FE
		[NullableContext(1)]
		public static WeatherSwitchInfoResponse Create()
		{
			return new WeatherSwitchInfoResponse();
		}

		// Token: 0x17005FD4 RID: 24532
		// (get) Token: 0x0601C6E3 RID: 116451 RVA: 0x0041B305 File Offset: 0x00419505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FD5 RID: 24533
		// (get) Token: 0x0601C6E4 RID: 116452 RVA: 0x0041B308 File Offset: 0x00419508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeatherSwitchInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601C6E5 RID: 116453 RVA: 0x0041B30F File Offset: 0x0041950F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoResponse()
		{
		}

		// Token: 0x0601C6E6 RID: 116454 RVA: 0x0041B322 File Offset: 0x00419522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoResponse(WeatherSwitchInfoResponse other) : this()
		{
			this.unlockedSwitchIds_ = other.unlockedSwitchIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C6E7 RID: 116455 RVA: 0x0041B34C File Offset: 0x0041954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeatherSwitchInfoResponse Clone()
		{
			return new WeatherSwitchInfoResponse(this);
		}

		// Token: 0x17005FD6 RID: 24534
		// (get) Token: 0x0601C6E8 RID: 116456 RVA: 0x0041B354 File Offset: 0x00419554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedSwitchIds
		{
			get
			{
				return this.unlockedSwitchIds_;
			}
		}

		// Token: 0x0601C6E9 RID: 116457 RVA: 0x0041B35C File Offset: 0x0041955C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeatherSwitchInfoResponse);
		}

		// Token: 0x0601C6EA RID: 116458 RVA: 0x0041B36A File Offset: 0x0041956A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeatherSwitchInfoResponse other)
		{
			return other != null && (other == this || (this.unlockedSwitchIds_.Equals(other.unlockedSwitchIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C6EB RID: 116459 RVA: 0x0041B3A0 File Offset: 0x004195A0
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

		// Token: 0x0601C6EC RID: 116460 RVA: 0x0041B3D4 File Offset: 0x004195D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C6ED RID: 116461 RVA: 0x0041B3E1 File Offset: 0x004195E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C6EE RID: 116462 RVA: 0x0041B3EA File Offset: 0x004195EA
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

		// Token: 0x0601C6EF RID: 116463 RVA: 0x0041B414 File Offset: 0x00419614
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

		// Token: 0x0601C6F0 RID: 116464 RVA: 0x0041B44D File Offset: 0x0041964D
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

		// Token: 0x0601C6F1 RID: 116465 RVA: 0x0041B47B File Offset: 0x0041967B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C6F2 RID: 116466 RVA: 0x0041B484 File Offset: 0x00419684
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockedSwitchIds_.AddEntriesFrom(ref input, WeatherSwitchInfoResponse._repeated_unlockedSwitchIds_codec);
				}
			}
		}

		// Token: 0x0400A2BE RID: 41662
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2BF RID: 41663
		public const int UnlockedSwitchIdsFieldNumber = 9;

		// Token: 0x0400A2C0 RID: 41664
		private static readonly FieldCodec<int> _repeated_unlockedSwitchIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400A2C1 RID: 41665
		private readonly RepeatedField<int> unlockedSwitchIds_ = new RepeatedField<int>();
	}
}
