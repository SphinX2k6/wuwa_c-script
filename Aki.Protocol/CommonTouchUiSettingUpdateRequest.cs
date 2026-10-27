using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BF RID: 703
	[NetMessage(EMessageId.CommonTouchUiSettingUpdateRequest)]
	public sealed class CommonTouchUiSettingUpdateRequest : IMessage<CommonTouchUiSettingUpdateRequest>, IMessage, IEquatable<CommonTouchUiSettingUpdateRequest>, IDeepCloneable<CommonTouchUiSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600486E RID: 18542 RVA: 0x000B1857 File Offset: 0x000AFA57
		[NullableContext(1)]
		public static CommonTouchUiSettingUpdateRequest Create()
		{
			return new CommonTouchUiSettingUpdateRequest();
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x000B185E File Offset: 0x000AFA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x000B1861 File Offset: 0x000AFA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonTouchUiSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x000B1868 File Offset: 0x000AFA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateRequest()
		{
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x000B187B File Offset: 0x000AFA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateRequest(CommonTouchUiSettingUpdateRequest other) : this()
		{
			this.mobileButtonSettings_ = other.mobileButtonSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x000B18A5 File Offset: 0x000AFAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateRequest Clone()
		{
			return new CommonTouchUiSettingUpdateRequest(this);
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x000B18AD File Offset: 0x000AFAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> MobileButtonSettings
		{
			get
			{
				return this.mobileButtonSettings_;
			}
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x000B18B5 File Offset: 0x000AFAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonTouchUiSettingUpdateRequest);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x000B18C3 File Offset: 0x000AFAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonTouchUiSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.mobileButtonSettings_.Equals(other.mobileButtonSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x000B18F8 File Offset: 0x000AFAF8
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

		// Token: 0x06004878 RID: 18552 RVA: 0x000B192C File Offset: 0x000AFB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x000B1939 File Offset: 0x000AFB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x000B1942 File Offset: 0x000AFB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mobileButtonSettings_.WriteTo(ref output, CommonTouchUiSettingUpdateRequest._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x000B196C File Offset: 0x000AFB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mobileButtonSettings_.CalculateSize(CommonTouchUiSettingUpdateRequest._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x000B19A5 File Offset: 0x000AFBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonTouchUiSettingUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.mobileButtonSettings_.Add(other.mobileButtonSettings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x000B19D3 File Offset: 0x000AFBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x000B19DC File Offset: 0x000AFBDC
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
					this.mobileButtonSettings_.AddEntriesFrom(ref input, CommonTouchUiSettingUpdateRequest._repeated_mobileButtonSettings_codec);
				}
			}
		}

		// Token: 0x04002FE2 RID: 12258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FE3 RID: 12259
		public const int MobileButtonSettingsFieldNumber = 10;

		// Token: 0x04002FE4 RID: 12260
		private static readonly FieldCodec<MobileButtonSetting> _repeated_mobileButtonSettings_codec = FieldCodec.ForMessage<MobileButtonSetting>(82U, MobileButtonSetting.Parser);

		// Token: 0x04002FE5 RID: 12261
		private readonly RepeatedField<MobileButtonSetting> mobileButtonSettings_ = new RepeatedField<MobileButtonSetting>();
	}
}
