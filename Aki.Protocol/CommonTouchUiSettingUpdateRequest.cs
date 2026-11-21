using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C5 RID: 709
	[NetMessage(EMessageId.CommonTouchUiSettingUpdateRequest)]
	public sealed class CommonTouchUiSettingUpdateRequest : IMessage<CommonTouchUiSettingUpdateRequest>, IMessage, IEquatable<CommonTouchUiSettingUpdateRequest>, IDeepCloneable<CommonTouchUiSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x06004935 RID: 18741 RVA: 0x000B3A5F File Offset: 0x000B1C5F
		[NullableContext(1)]
		public static CommonTouchUiSettingUpdateRequest Create()
		{
			return new CommonTouchUiSettingUpdateRequest();
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x000B3A66 File Offset: 0x000B1C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x000B3A69 File Offset: 0x000B1C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonTouchUiSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x000B3A70 File Offset: 0x000B1C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateRequest()
		{
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x000B3A83 File Offset: 0x000B1C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateRequest(CommonTouchUiSettingUpdateRequest other) : this()
		{
			this.mobileButtonSettings_ = other.mobileButtonSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x000B3AAD File Offset: 0x000B1CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateRequest Clone()
		{
			return new CommonTouchUiSettingUpdateRequest(this);
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x000B3AB5 File Offset: 0x000B1CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> MobileButtonSettings
		{
			get
			{
				return this.mobileButtonSettings_;
			}
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x000B3ABD File Offset: 0x000B1CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonTouchUiSettingUpdateRequest);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x000B3ACB File Offset: 0x000B1CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonTouchUiSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.mobileButtonSettings_.Equals(other.mobileButtonSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x000B3B00 File Offset: 0x000B1D00
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

		// Token: 0x0600493F RID: 18751 RVA: 0x000B3B34 File Offset: 0x000B1D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x000B3B41 File Offset: 0x000B1D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x000B3B4A File Offset: 0x000B1D4A
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

		// Token: 0x06004942 RID: 18754 RVA: 0x000B3B74 File Offset: 0x000B1D74
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

		// Token: 0x06004943 RID: 18755 RVA: 0x000B3BAD File Offset: 0x000B1DAD
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

		// Token: 0x06004944 RID: 18756 RVA: 0x000B3BDB File Offset: 0x000B1DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x000B3BE4 File Offset: 0x000B1DE4
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

		// Token: 0x04003075 RID: 12405
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003076 RID: 12406
		public const int MobileButtonSettingsFieldNumber = 10;

		// Token: 0x04003077 RID: 12407
		private static readonly FieldCodec<MobileButtonSetting> _repeated_mobileButtonSettings_codec = FieldCodec.ForMessage<MobileButtonSetting>(82U, MobileButtonSetting.Parser);

		// Token: 0x04003078 RID: 12408
		private readonly RepeatedField<MobileButtonSetting> mobileButtonSettings_ = new RepeatedField<MobileButtonSetting>();
	}
}
