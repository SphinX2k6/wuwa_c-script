using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E0 RID: 4576
	[NetMessage(EMessageId.SettingNotify)]
	public sealed class SettingNotify : IMessage<SettingNotify>, IMessage, IEquatable<SettingNotify>, IDeepCloneable<SettingNotify>, IBufferMessage
	{
		// Token: 0x0601864A RID: 99914 RVA: 0x0038BFD1 File Offset: 0x0038A1D1
		[NullableContext(1)]
		public static SettingNotify Create()
		{
			return new SettingNotify();
		}

		// Token: 0x1700521C RID: 21020
		// (get) Token: 0x0601864B RID: 99915 RVA: 0x0038BFD8 File Offset: 0x0038A1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700521D RID: 21021
		// (get) Token: 0x0601864C RID: 99916 RVA: 0x0038BFDB File Offset: 0x0038A1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettingNotify.Descriptor;
			}
		}

		// Token: 0x0601864D RID: 99917 RVA: 0x0038BFE2 File Offset: 0x0038A1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingNotify()
		{
		}

		// Token: 0x0601864E RID: 99918 RVA: 0x0038BFF5 File Offset: 0x0038A1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingNotify(SettingNotify other) : this()
		{
			this.mobileButtonSettings_ = other.mobileButtonSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601864F RID: 99919 RVA: 0x0038C01F File Offset: 0x0038A21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingNotify Clone()
		{
			return new SettingNotify(this);
		}

		// Token: 0x1700521E RID: 21022
		// (get) Token: 0x06018650 RID: 99920 RVA: 0x0038C027 File Offset: 0x0038A227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> MobileButtonSettings
		{
			get
			{
				return this.mobileButtonSettings_;
			}
		}

		// Token: 0x06018651 RID: 99921 RVA: 0x0038C02F File Offset: 0x0038A22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettingNotify);
		}

		// Token: 0x06018652 RID: 99922 RVA: 0x0038C03D File Offset: 0x0038A23D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SettingNotify other)
		{
			return other != null && (other == this || (this.mobileButtonSettings_.Equals(other.mobileButtonSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018653 RID: 99923 RVA: 0x0038C070 File Offset: 0x0038A270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mobileButtonSettings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018654 RID: 99924 RVA: 0x0038C0A4 File Offset: 0x0038A2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018655 RID: 99925 RVA: 0x0038C0B1 File Offset: 0x0038A2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018656 RID: 99926 RVA: 0x0038C0BA File Offset: 0x0038A2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mobileButtonSettings_.WriteTo(ref output, SettingNotify._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018657 RID: 99927 RVA: 0x0038C0E4 File Offset: 0x0038A2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mobileButtonSettings_.CalculateSize(SettingNotify._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018658 RID: 99928 RVA: 0x0038C11D File Offset: 0x0038A31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SettingNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mobileButtonSettings_.Add(other.mobileButtonSettings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018659 RID: 99929 RVA: 0x0038C14B File Offset: 0x0038A34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601865A RID: 99930 RVA: 0x0038C154 File Offset: 0x0038A354
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
					this.mobileButtonSettings_.AddEntriesFrom(ref input, SettingNotify._repeated_mobileButtonSettings_codec);
				}
			}
		}

		// Token: 0x0400903A RID: 36922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400903B RID: 36923
		public const int MobileButtonSettingsFieldNumber = 10;

		// Token: 0x0400903C RID: 36924
		private static readonly FieldCodec<MobileButtonSetting> _repeated_mobileButtonSettings_codec = FieldCodec.ForMessage<MobileButtonSetting>(82U, MobileButtonSetting.Parser);

		// Token: 0x0400903D RID: 36925
		private readonly RepeatedField<MobileButtonSetting> mobileButtonSettings_ = new RepeatedField<MobileButtonSetting>();
	}
}
