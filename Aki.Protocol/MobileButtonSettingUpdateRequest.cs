using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D2 RID: 2514
	[NetMessage(EMessageId.MobileButtonSettingUpdateRequest)]
	public sealed class MobileButtonSettingUpdateRequest : IMessage<MobileButtonSettingUpdateRequest>, IMessage, IEquatable<MobileButtonSettingUpdateRequest>, IDeepCloneable<MobileButtonSettingUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600DCB3 RID: 56499 RVA: 0x002067A6 File Offset: 0x002049A6
		[NullableContext(1)]
		public static MobileButtonSettingUpdateRequest Create()
		{
			return new MobileButtonSettingUpdateRequest();
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x0600DCB4 RID: 56500 RVA: 0x002067AD File Offset: 0x002049AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0600DCB5 RID: 56501 RVA: 0x002067B0 File Offset: 0x002049B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MobileButtonSettingUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600DCB6 RID: 56502 RVA: 0x002067B7 File Offset: 0x002049B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateRequest()
		{
		}

		// Token: 0x0600DCB7 RID: 56503 RVA: 0x002067CA File Offset: 0x002049CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateRequest(MobileButtonSettingUpdateRequest other) : this()
		{
			this.mobileButtonSettings_ = other.mobileButtonSettings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCB8 RID: 56504 RVA: 0x002067F4 File Offset: 0x002049F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MobileButtonSettingUpdateRequest Clone()
		{
			return new MobileButtonSettingUpdateRequest(this);
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0600DCB9 RID: 56505 RVA: 0x002067FC File Offset: 0x002049FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MobileButtonSetting> MobileButtonSettings
		{
			get
			{
				return this.mobileButtonSettings_;
			}
		}

		// Token: 0x0600DCBA RID: 56506 RVA: 0x00206804 File Offset: 0x00204A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MobileButtonSettingUpdateRequest);
		}

		// Token: 0x0600DCBB RID: 56507 RVA: 0x00206812 File Offset: 0x00204A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MobileButtonSettingUpdateRequest other)
		{
			return other != null && (other == this || (this.mobileButtonSettings_.Equals(other.mobileButtonSettings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCBC RID: 56508 RVA: 0x00206848 File Offset: 0x00204A48
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

		// Token: 0x0600DCBD RID: 56509 RVA: 0x0020687C File Offset: 0x00204A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCBE RID: 56510 RVA: 0x00206889 File Offset: 0x00204A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCBF RID: 56511 RVA: 0x00206892 File Offset: 0x00204A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mobileButtonSettings_.WriteTo(ref output, MobileButtonSettingUpdateRequest._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCC0 RID: 56512 RVA: 0x002068BC File Offset: 0x00204ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mobileButtonSettings_.CalculateSize(MobileButtonSettingUpdateRequest._repeated_mobileButtonSettings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCC1 RID: 56513 RVA: 0x002068F5 File Offset: 0x00204AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MobileButtonSettingUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.mobileButtonSettings_.Add(other.mobileButtonSettings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCC2 RID: 56514 RVA: 0x00206923 File Offset: 0x00204B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCC3 RID: 56515 RVA: 0x0020692C File Offset: 0x00204B2C
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
					this.mobileButtonSettings_.AddEntriesFrom(ref input, MobileButtonSettingUpdateRequest._repeated_mobileButtonSettings_codec);
				}
			}
		}

		// Token: 0x04005BB7 RID: 23479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BB8 RID: 23480
		public const int MobileButtonSettingsFieldNumber = 10;

		// Token: 0x04005BB9 RID: 23481
		private static readonly FieldCodec<MobileButtonSetting> _repeated_mobileButtonSettings_codec = FieldCodec.ForMessage<MobileButtonSetting>(82U, MobileButtonSetting.Parser);

		// Token: 0x04005BBA RID: 23482
		private readonly RepeatedField<MobileButtonSetting> mobileButtonSettings_ = new RepeatedField<MobileButtonSetting>();
	}
}
